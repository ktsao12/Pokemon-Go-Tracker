namespace PokemonApp
{
    partial class Pokemon_App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pokemon_App));
            this.ResetButton = new System.Windows.Forms.Button();
            this.PokemonList = new System.Windows.Forms.ListBox();
            this.pokemontable = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.PokemonCaught = new System.Windows.Forms.Button();
            this.Release = new System.Windows.Forms.Button();
            this.GymList = new System.Windows.Forms.ListBox();
            this.Gym_Taken = new System.Windows.Forms.Button();
            this.Show_Team = new System.Windows.Forms.Button();
            this.Pokemon_Team = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ListBox();
            this.Locations = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Street1Box = new System.Windows.Forms.ListBox();
            this.Street2Box = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CP_Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(523, 590);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(181, 37);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Reset DB";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PokemonList
            // 
            this.PokemonList.FormattingEnabled = true;
            this.PokemonList.Location = new System.Drawing.Point(12, 35);
            this.PokemonList.Name = "PokemonList";
            this.PokemonList.Size = new System.Drawing.Size(245, 589);
            this.PokemonList.TabIndex = 3;
            this.PokemonList.SelectedIndexChanged += new System.EventHandler(this.PokemonList_SelectedIndexChanged);
            // 
            // pokemontable
            // 
            this.pokemontable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pokemontable.FormattingEnabled = true;
            this.pokemontable.Items.AddRange(new object[] {
            "Pokemon:"});
            this.pokemontable.Location = new System.Drawing.Point(12, 12);
            this.pokemontable.Name = "pokemontable";
            this.pokemontable.Size = new System.Drawing.Size(120, 17);
            this.pokemontable.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Email:"});
            this.listBox2.Location = new System.Drawing.Point(526, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(180, 17);
            this.listBox2.TabIndex = 5;
            // 
            // PokemonCaught
            // 
            this.PokemonCaught.Location = new System.Drawing.Point(629, 77);
            this.PokemonCaught.Name = "PokemonCaught";
            this.PokemonCaught.Size = new System.Drawing.Size(77, 21);
            this.PokemonCaught.TabIndex = 7;
            this.PokemonCaught.Text = "Catch";
            this.PokemonCaught.UseVisualStyleBackColor = true;
            this.PokemonCaught.Click += new System.EventHandler(this.PokemonCaught_Click);
            // 
            // Release
            // 
            this.Release.Location = new System.Drawing.Point(523, 421);
            this.Release.Name = "Release";
            this.Release.Size = new System.Drawing.Size(183, 43);
            this.Release.TabIndex = 8;
            this.Release.Text = "Release";
            this.Release.UseVisualStyleBackColor = true;
            this.Release.Click += new System.EventHandler(this.Release_Click);
            // 
            // GymList
            // 
            this.GymList.FormattingEnabled = true;
            this.GymList.Location = new System.Drawing.Point(284, 519);
            this.GymList.Name = "GymList";
            this.GymList.Size = new System.Drawing.Size(212, 108);
            this.GymList.TabIndex = 9;
            this.GymList.SelectedIndexChanged += new System.EventHandler(this.GymList_SelectedIndexChanged);
            // 
            // Gym_Taken
            // 
            this.Gym_Taken.Location = new System.Drawing.Point(523, 525);
            this.Gym_Taken.Name = "Gym_Taken";
            this.Gym_Taken.Size = new System.Drawing.Size(182, 43);
            this.Gym_Taken.TabIndex = 10;
            this.Gym_Taken.Text = "Take Gym";
            this.Gym_Taken.UseVisualStyleBackColor = true;
            this.Gym_Taken.Click += new System.EventHandler(this.Gym_Taken_Click);
            // 
            // Show_Team
            // 
            this.Show_Team.Location = new System.Drawing.Point(526, 111);
            this.Show_Team.Name = "Show_Team";
            this.Show_Team.Size = new System.Drawing.Size(180, 43);
            this.Show_Team.TabIndex = 11;
            this.Show_Team.Text = "Show Team";
            this.Show_Team.UseVisualStyleBackColor = true;
            this.Show_Team.Click += new System.EventHandler(this.Show_Team_Click);
            // 
            // Pokemon_Team
            // 
            this.Pokemon_Team.FormattingEnabled = true;
            this.Pokemon_Team.Location = new System.Drawing.Point(526, 203);
            this.Pokemon_Team.Name = "Pokemon_Team";
            this.Pokemon_Team.Size = new System.Drawing.Size(180, 212);
            this.Pokemon_Team.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Team:"});
            this.listBox1.Location = new System.Drawing.Point(526, 180);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 17);
            this.listBox1.TabIndex = 13;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "Gyms:"});
            this.listBox3.Location = new System.Drawing.Point(284, 489);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(212, 17);
            this.listBox3.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(284, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(526, 38);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(180, 20);
            this.EmailBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type:";
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(314, 160);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.TypeBox.Size = new System.Drawing.Size(182, 17);
            this.TypeBox.TabIndex = 18;
            // 
            // Locations
            // 
            this.Locations.FormattingEnabled = true;
            this.Locations.Location = new System.Drawing.Point(284, 196);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(212, 134);
            this.Locations.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Found at:";
            // 
            // Street1Box
            // 
            this.Street1Box.FormattingEnabled = true;
            this.Street1Box.Location = new System.Drawing.Point(284, 349);
            this.Street1Box.Name = "Street1Box";
            this.Street1Box.Size = new System.Drawing.Size(105, 134);
            this.Street1Box.TabIndex = 21;
            // 
            // Street2Box
            // 
            this.Street2Box.FormattingEnabled = true;
            this.Street2Box.Location = new System.Drawing.Point(391, 349);
            this.Street2Box.Name = "Street2Box";
            this.Street2Box.Size = new System.Drawing.Size(105, 134);
            this.Street2Box.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Caught at:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Currently Defending:";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(527, 489);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(125, 30);
            this.listBox4.TabIndex = 25;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(656, 489);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(50, 30);
            this.listBox5.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "CP:";
            // 
            // CP_Box
            // 
            this.CP_Box.Location = new System.Drawing.Point(526, 77);
            this.CP_Box.Name = "CP_Box";
            this.CP_Box.Size = new System.Drawing.Size(94, 20);
            this.CP_Box.TabIndex = 28;
            this.CP_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CP_Box_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "CP of Selected Pokemon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 629);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Jaskaran Singh and Kevin Tsao";
            // 
            // Pokemon_App
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(750, 651);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CP_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Street2Box);
            this.Controls.Add(this.Street1Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Locations);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Pokemon_Team);
            this.Controls.Add(this.Show_Team);
            this.Controls.Add(this.Gym_Taken);
            this.Controls.Add(this.GymList);
            this.Controls.Add(this.Release);
            this.Controls.Add(this.PokemonCaught);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.pokemontable);
            this.Controls.Add(this.PokemonList);
            this.Controls.Add(this.ResetButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pokemon_App";
            this.Text = "PokemonGO Tracker";
            this.Load += new System.EventHandler(this.Pokemon_App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox TrainerName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ListBox PokemonList;
        private System.Windows.Forms.ListBox pokemontable;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button PokemonCaught;
        private System.Windows.Forms.Button Release;
        private System.Windows.Forms.ListBox GymList;
        private System.Windows.Forms.Button Gym_Taken;
        private System.Windows.Forms.Button Show_Team;
        private System.Windows.Forms.ListBox Pokemon_Team;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TypeBox;
        private System.Windows.Forms.ListBox Locations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Street1Box;
        private System.Windows.Forms.ListBox Street2Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CP_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

