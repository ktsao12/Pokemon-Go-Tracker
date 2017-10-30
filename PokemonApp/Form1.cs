// CS480
// Prof. Hummel
// Summer 2016
// Jaskaran Singh and Kevin Tsao
// Final Project: Pokemon Go App
//
// Please read the Readme for details!
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PokemonApp
{
    public partial class Pokemon_App : Form
    {
        string localInfo;
        string remoteInfo;
        
        public Pokemon_App()
        {
            InitializeComponent();
            string filename = "TestTx.mdf";

            localInfo = String.Format(@"
Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\{0};Integrated Security=True;
", filename);

            //
            // remote Azure cloud connection info:
            //
            string NetID = "jsingh10";
            string databasename = "PokemonDB";
            string username = "jsingh10";
            string pwd = "hat9Salk";

            remoteInfo = String.Format(@"
Server=tcp:{0}.database.windows.net,1433;Initial Catalog={1};Persist Security Info=False;User ID={2};Password={3};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
", NetID, databasename, username, pwd);
        }
        static void ExecuteActionQuery(SqlConnection db, string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();
        }

        
        private void ResetButton_Click(object sender, EventArgs e)
        {
            string connectionInfo = remoteInfo;
            SqlConnection db = null;
            db = new SqlConnection(connectionInfo);
            db.Open();
            string sql = string.Format(@"
                    DROP TABLE Gyms;
                    DROP TABLE History;
                    DROP TABLE Roster;  
                    DROP TABLE Pokemon;
                    DROP TABLE Types;
                    DROP TABLE Trainers;
                    DROP TABLE Teams;

                    Create Table Teams(
                        TeamID  INT   PRIMARY KEY NOT NULL,
                        Name    NVARCHAR(64)    NOT NULL
                    )
                    Create Table Trainers(
                        TrainerID   INT PRIMARY KEY,
                        Name        NVARCHAR(128)    NOT NULL,
                        Email       NVARCHAR(128)   UNIQUE NOT NULL,
                        Team        INT NOT NULL    FOREIGN KEY REFERENCES Teams(TeamID)
                    )
                    Create Table Types(
                        TypeNum     INT PRIMARY KEY,
                        TypeName    NVARCHAR(64)
                    )
                    Create Table Pokemon(
                        PokemonNum  INT PRIMARY KEY,
                        Name        NVARCHAR(64),
                        Type        INT FOREIGN KEY REFERENCES Types(TypeNum)
                    )
                    Create Table Roster(
                        TrainerID   INT FOREIGN KEY REFERENCES Trainers(TrainerID),
                        PokemonNum  INT FOREIGN KEY REFERENCES Pokemon(PokemonNum),
                        CP          INT NOT NULL    CHECK(CP>0 AND CP<4001)
                    )             
                    Create Table History(
                        HistoryID   INT PRIMARY KEY IDENTITY(1,1),
                        TrainerID   INT FOREIGN KEY REFERENCES Trainers(TrainerID),
                        PokemonNum  INT FOREIGN KEY REFERENCES Pokemon(PokemonNum),
                        Street1     NVARCHAR(64)    NOT NULL,
                        Street2     NVARCHAR(64)    NOT NULL,
                        DateCaught  DATE            NOT NULL
                    )     
                    Create Table Gyms(
                        GymID   INT PRIMARY KEY NOT NULL,
                        TrainerID  INT FOREIGN KEY REFERENCES Trainers(TrainerID),
                        PokemonNum  INT FOREIGN KEY REFERENCES Pokemon(PokemonNum) NOT NULL,
                        Street1     NVARCHAR(64)    NOT NULL,
                        Street2     NVARCHAR(64)    NOT NULL
                    )  
                    ");
            ExecuteActionQuery(db, sql);
            
            
            string filename = "Teams.csv";

            using (var file = new System.IO.StreamReader(filename))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                                       
                    string[] values = line.Split(',');

                    int Teamid = Convert.ToInt32(values[0]);
                    string Name = values[1];
                    
                    sql = string.Format(@"
                        INSERT INTO 
                        Teams(TeamID,Name)
                        Values('{0}', '{1}');
                        ",Teamid,Name
                        );

                    ExecuteActionQuery(db, sql);
                }//while
            }//using
            filename = "Trainers.csv";
            using (var file = new System.IO.StreamReader(filename))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();

                    string[] values = line.Split(',');

                    int TrainId = Convert.ToInt32(values[0]);
                    string Name = values[1];
                    string email = values[2];
                    int teamID = Convert.ToInt32(values[3]);

                    sql = string.Format(@"
                        INSERT INTO 
                        Trainers(TrainerID,Name, Email, Team)
                        Values('{0}', '{1}','{2}',{3});
                        ", TrainId,Name, email,teamID
                        );

                    ExecuteActionQuery(db, sql);
                }//while
            }//using
            filename = "Types.csv";
            using (var file = new System.IO.StreamReader(filename))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();

                    string[] values = line.Split(',');

                    int TypeID = Convert.ToInt32(values[0]);
                    string Typing = values[1];

                    sql = string.Format(@"
                        INSERT INTO
                        Types(TypeNum,TypeName)
                        Values({0}, '{1}');
                        ", TypeID, Typing
                        );

                    ExecuteActionQuery(db, sql);
                }
            }
                //Number,Name,Type
            filename = "Pokemon.csv";
            using (var file = new System.IO.StreamReader(filename))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();

                    string[] values = line.Split(',');

                    int PokeNum = Convert.ToInt32(values[0]);
                    string Name = values[1];
                    string Type = values[2];

                    sql = string.Format(@"
                        INSERT INTO 
                        Pokemon(PokemonNum,Name,Type)
                        Values('{0}', '{1}','{2}');
                        ", PokeNum, Name, Type
                        );

                    ExecuteActionQuery(db, sql);
                }//while
            }//using

            filename = "Rosters.csv";
            using (var file = new System.IO.StreamReader(filename))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();

                    string[] values = line.Split(',');

                    int TrainID = Convert.ToInt32(values[0]);
                    int Pokenum = Convert.ToInt32(values[1]);
                    int CP = Convert.ToInt32(values[2]);

                    sql = string.Format(@"
                        INSERT INTO 
                        Roster(TrainerID,PokemonNum,CP)
                        Values('{0}', '{1}','{2}');
                        ", TrainID, Pokenum, CP
                        );

                    ExecuteActionQuery(db, sql);
                }//while
            }//using

            filename = "History.csv";
            using (var file = new System.IO.StreamReader(filename))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();

                    string[] values = line.Split(',');
                    
                    int TrainID = Convert.ToInt32(values[0]);
                    int Pokenum = Convert.ToInt32(values[1]);
                    string street1 = values[2];
                    string street2 = values[3];
                    DateTime date = Convert.ToDateTime(values[4]);

                    string sql_date = date.ToShortDateString();

                    sql = string.Format(@"
                        INSERT INTO 
                        History(TrainerID,PokemonNum,Street1,Street2,DateCaught)
                        Values({0},{1},'{2}','{3}','{4}');
                        ", TrainID, Pokenum, street1, street2, sql_date
                        );

                    ExecuteActionQuery(db, sql);
                }//while
            }//using
            filename = "Gyms.csv";
            using (var file = new System.IO.StreamReader(filename))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();

                    string[] values = line.Split(',');

                    int gymID = Convert.ToInt32(values[0]);
                    int TrainID = Convert.ToInt32(values[1]);
                    int Pokenum = Convert.ToInt32(values[2]);
                    string street1 = values[3];
                    string street2 = values[4];
                    
                    
                    sql = string.Format(@"
                        INSERT INTO 
                        Gyms(GymID,TrainerID,PokemonNum,Street1,Street2)
                        Values({0},{1},{2},'{3}','{4}');
                        ", gymID, TrainID, Pokenum, street1, street2
                        );

                    ExecuteActionQuery(db, sql);
                }//while
            }//using
            db.Close();
        }

        private void PokemonCaught_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                string input = EmailBox.Text;
                string name = PokemonList.SelectedItem.ToString();
                string[] vals = name.Split(':');
                int CP = Convert.ToInt32(CP_Box.Text);
                string street1 = Street1Box.SelectedItem.ToString();
                string street2 = Street2Box.SelectedItem.ToString();
                sql = string.Format(@"
                
                Declare @TID INT;
                BEGIN Transaction;
                Select	@TID = TrainerID 
                FROM	Trainers
                Where	Email = '{0}'; 
                
                IF @TID IS NULL
                BEGIN
                    ROLLBACK Transaction;
                END
                ELSE
                BEGIN
                    Insert Into Roster(TrainerID,PokemonNum,CP)
                    Values(@TID,{1},{2})

                    Insert Into History(TrainerID,PokemonNum,Street1,Street2,DateCaught)
					Values(@TID,{1},'{3}','{4}',GETDATE())

                    COMMIT Transaction;
	            END
                
                ", input, Convert.ToInt32(vals[0]), CP, street1, street2);
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("One of the following was not entered: Email, Pokemon Name, CP, Street Caught");
                return;
            }
            SqlConnection db = null;
            db = new SqlConnection(remoteInfo);

            db.Open();
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void Pokemon_App_Load(object sender, EventArgs e)
        {
            string sql = string.Format(@"
                --SQL to retrieve list of pokemon
                Select  PokemonNum,Name
                From    Pokemon
            ");
            string gym_sql = String.Format(@"
                Select  GymID,Street1,Street2
                From    Gyms
            ");

            SqlConnection db = null;
            SqlCommand comm = new SqlCommand();
            

            db = new SqlConnection(remoteInfo);
            db.Open();
            comm.Connection = db;

            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            DataSet gym_return = new DataSet();
            
            comm.CommandText = sql;
            adapter.Fill(ds);
            comm.CommandText = gym_sql;
            adapter.Fill(gym_return);

            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string pokemon = String.Format("{1}: {0}",row["Name"],Convert.ToInt32(row["PokemonNum"]));
                PokemonList.Items.Add(pokemon);
            }
            foreach (DataRow row in gym_return.Tables["TABLE"].Rows)
            {
                string gym = String.Format("{0}: {1} and {2}", row["GymID"],row["Street1"],row["Street2"]);
                GymList.Items.Add(gym); 
            }

            string street1sql = string.Format(@"
                SELECT Street1
                FROM History
                GROUP BY Street1
                ORDER BY Street1 ASC
            ");
            string street2sql = string.Format(@"
                SELECT Street2
                FROM History
                GROUP BY Street2
                ORDER BY Street2 ASC
            ");
            
            DataSet Street1list = new DataSet();
            DataSet Street2list = new DataSet();
            comm.CommandText = street1sql;
            adapter.Fill(Street1list);
            comm.CommandText = street2sql;
            adapter.Fill(Street2list);

            foreach (DataRow row in Street1list.Tables["TABLE"].Rows)
            {
                string Street1 = string.Format("{0}", row["Street1"]);
                Street1Box.Items.Add(Street1);
            }
            foreach (DataRow row in Street2list.Tables["TABLE"].Rows)
            {
                string Street2 = string.Format("{0}", row["Street2"]);
                Street2Box.Items.Add(Street2);
            }
            db.Close();
        }
        
        private void PokemonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PokemonList.SelectedIndex < 0)
                return;

            string name = PokemonList.SelectedItem.ToString();
            string[] vals = name.Split(':');
            string pokenum = vals[0]+".gif";
            pictureBox1.Image = Image.FromFile(pokenum);
            
            string sql = string.Format(@"
                SELECT TypeName
                FROM Types
                INNER JOIN Pokemon ON Pokemon.Type = Types.TypeNum
                WHERE Pokemon.Name = '{0}'
            ",vals[1].Remove(0,1));
            
            SqlConnection db = null;
            SqlCommand comm = new SqlCommand();
            
            db = new SqlConnection(remoteInfo);
            db.Open();
            comm.Connection = db;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            cmd.CommandText = sql;
            
            string result = Convert.ToString(cmd.ExecuteScalar());
            TypeBox.Items.Clear();
            TypeBox.Items.Add(result);

            string sql2 = string.Format(@"
                SELECT Street1, Street2, Count(*) as Total
                FROM History
                WHERE PokemonNum = {0}
                GROUP BY Street1, Street2
                ORDER BY Count(*) DESC
            ", vals[0]);

            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            comm.CommandText = sql2;
            adapter.Fill(ds);
            Locations.Items.Clear();

            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string streets = String.Format("{0} and {1}", row["Street1"], row["Street2"]);
                Locations.Items.Add(streets);
            }
            db.Close();
        }
        
        private void GymList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GymList.SelectedIndex < 0)
                return;

            string location = GymList.SelectedItem.ToString();
            string[] streets = location.Split(':');
            SqlConnection db = null;
            SqlCommand cmd = new SqlCommand();
            db = new SqlConnection(remoteInfo);
            db.Open();
            cmd.Connection = db;

            string sql = string.Format(@"
                Declare @TID as INT;
                Declare @PID as INT;

                SELECT  @TID = TrainerID
                FROM Gyms
                WHERE GymID = {0};

                SELECT @PID = PokemonNum
                FROM Gyms
                WHERE GymID = {0};
    
                SELECT CP
                FROM Roster
                WHERE TrainerID = @TID AND
                      PokemonNum = @PID
            ", streets[0]);
            cmd.CommandText = sql;
            string combatpower = Convert.ToString(cmd.ExecuteScalar());

            string sql4 = string.Format(@"
                Declare @PID as INT;

                SELECT @PID = PokemonNum
                FROM Gyms
                WHERE GymID = {0};

                SELECT Name
                FROM   Pokemon
                WHERE  PokemonNum = @PID
            ", streets[0]);
            cmd.CommandText = sql4;
            string pokemonName = Convert.ToString(cmd.ExecuteScalar());

            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox4.Items.Add(pokemonName);
            listBox5.Items.Add(combatpower);
            db.Close();
        }

        private void Show_Team_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text;
            string sql = String.Format(@"
                Select  Pokemon.Name, Roster.CP
                From    Pokemon
                Inner Join Roster on Roster.PokemonNum = Pokemon.PokemonNum
                Inner Join Trainers on Trainers.TrainerID = Roster.TrainerID
                Where   Trainers.Email = '{0}';
            ",email);
            SqlConnection db = null;
            SqlCommand comm = new SqlCommand();


            db = new SqlConnection(remoteInfo);
            db.Open();
            comm.Connection = db;

            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            

            comm.CommandText = sql;
            adapter.Fill(ds);
            Pokemon_Team.Items.Clear();
            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                string Pokenames = Convert.ToString(row["Name"]) + "     CP:"+Convert.ToInt32(row["CP"]);
                Pokemon_Team.Items.Add(Pokenames);
            }
            db.Close();
        }

       

        private void CP_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Release_Click(object sender, EventArgs e)
        {
            string name = Pokemon_Team.SelectedItem.ToString();
            string email = EmailBox.Text;
            string[] vals = name.Split(' ');
            string[] CP_string = vals[5].Split(':');
            int CP = Convert.ToInt32(CP_string[1]);

            string sql = String.Format(@"
                Declare @TID INT;
                Declare @PID INT;
    
                BEGIN Transaction;
                Select	@TID = TrainerID 
                FROM	Trainers
                Where	Email = '{0}'; 
                
                Select  @PID = PokemonNum
                From    Pokemon
                Where   Name = '{1}';

                IF @TID IS NULL
                BEGIN
	                ROLLBACK Transaction;
                END

                ELSE
                BEGIN
	                Delete TOP(1) From Roster
	                Where TrainerID = @TID AND PokemonNum = @PID AND CP = {2}
	                COMMIT Transaction;
                END
            ",email,vals[0],CP);

            SqlConnection db = null;
            db = new SqlConnection(remoteInfo);

            db.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void Gym_Taken_Click(object sender, EventArgs e)
        {
            SqlConnection db = null;
            db = new SqlConnection(remoteInfo);

            db.Open();
            try
            {
                string name = Pokemon_Team.SelectedItem.ToString();

                string email = EmailBox.Text;


                string[] vals = name.Split(' ');                
                string gym = GymList.SelectedItem.ToString();
                string[] gym_id = gym.Split(':');

                string sql = String.Format(@"
                    Declare @TID INT;
                    Declare @PID INT;

                    Begin Transaction;

                    Select @TID = TrainerID
                    From Trainers
                    Where	Email = '{0}';

                    Select @PID = PokemonNum
                    From Pokemon
                    Where	Name = '{1}';

                    IF @TID IS NULL OR @PID IS NULL
                    BEGIN
	                    Rollback Transaction;
                    END
                    ELSE
                    BEGIN
	                  update	Gyms
	                  Set		TrainerID = @TID, PokemonNum = @PID
	                  Where	    GymID = {2};

	                  Commit Transaction;
                    END
                ", email, vals[0], gym_id[0]);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("One of the following is not input: Pokemon in team, gym, email");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
    }
}
