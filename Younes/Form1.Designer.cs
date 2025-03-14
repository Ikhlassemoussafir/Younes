namespace Younes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panelMenu = new Panel();
            panel2 = new Panel();
            panelMain = new Panel();
            btnDashboard = new Button();
            btnProjects = new Button();
            btnTasks = new Button();
            btnTeam = new Button();
            btnLogout = new Button();
            panelAdmin = new Panel();
            panelChefProjet = new Panel();
            panelChefEquipe = new Panel();
            panel6 = new Panel();
            panelMembreEquipe = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panelMenu.SuspendLayout();
            panelMain.SuspendLayout();
            panelAdmin.SuspendLayout();
            panelChefProjet.SuspendLayout();
            panelChefEquipe.SuspendLayout();
            panelMembreEquipe.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panelMenu);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 863);
            panel1.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnTeam);
            panelMenu.Controls.Add(btnTasks);
            panelMenu.Controls.Add(btnProjects);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(300, 863);
            panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(298, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(1137, 867);
            panel2.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelMembreEquipe);
            panelMain.Controls.Add(panelChefEquipe);
            panelMain.Controls.Add(panelChefProjet);
            panelMain.Controls.Add(panelAdmin);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(300, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1137, 863);
            panelMain.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(300, 69);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Tableau de Bord";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnProjects
            // 
            btnProjects.Location = new Point(0, 84);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(297, 87);
            btnProjects.TabIndex = 1;
            btnProjects.Text = " Projets";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += button2_Click;
            // 
            // btnTasks
            // 
            btnTasks.Location = new Point(0, 177);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(300, 84);
            btnTasks.TabIndex = 2;
            btnTasks.Text = " Tâches";
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += button3_Click;
            // 
            // btnTeam
            // 
            btnTeam.Location = new Point(0, 281);
            btnTeam.Name = "btnTeam";
            btnTeam.Size = new Size(300, 82);
            btnTeam.TabIndex = 3;
            btnTeam.Text = "Équipe";
            btnTeam.UseVisualStyleBackColor = true;
            btnTeam.Click += button4_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(0, 384);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(303, 83);
            btnLogout.TabIndex = 4;
            btnLogout.Text = " Déconnexion";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button5_Click;
            // 
            // panelAdmin
            // 
            panelAdmin.Controls.Add(label1);
            panelAdmin.Controls.Add(textBox1);
            panelAdmin.Location = new Point(24, 32);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(219, 176);
            panelAdmin.TabIndex = 0;
            // 
            // panelChefProjet
            // 
            panelChefProjet.Controls.Add(label2);
            panelChefProjet.Controls.Add(textBox2);
            panelChefProjet.Location = new Point(280, 32);
            panelChefProjet.Name = "panelChefProjet";
            panelChefProjet.Size = new Size(236, 177);
            panelChefProjet.TabIndex = 1;
            panelChefProjet.Visible = false;
            // 
            // panelChefEquipe
            // 
            panelChefEquipe.Controls.Add(label3);
            panelChefEquipe.Controls.Add(textBox3);
            panelChefEquipe.Controls.Add(panel6);
            panelChefEquipe.Location = new Point(590, 32);
            panelChefEquipe.Name = "panelChefEquipe";
            panelChefEquipe.Size = new Size(225, 177);
            panelChefEquipe.TabIndex = 2;
            panelChefEquipe.Visible = false;
            // 
            // panel6
            // 
            panel6.Location = new Point(266, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(334, 300);
            panel6.TabIndex = 0;
            // 
            // panelMembreEquipe
            // 
            panelMembreEquipe.Controls.Add(label4);
            panelMembreEquipe.Controls.Add(textBox4);
            panelMembreEquipe.Location = new Point(856, 31);
            panelMembreEquipe.Name = "panelMembreEquipe";
            panelMembreEquipe.Size = new Size(228, 176);
            panelMembreEquipe.TabIndex = 3;
            panelMembreEquipe.Visible = false;
            panelMembreEquipe.Paint += panelMembreEquipe_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 55);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 55);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(38, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 55);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(28, 106);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 55);
            textBox4.TabIndex = 0;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 37);
            label1.Name = "label1";
            label1.Size = new Size(255, 48);
            label1.TabIndex = 1;
            label1.Text = "Administrateur";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 37);
            label2.Name = "label2";
            label2.Size = new Size(246, 48);
            label2.TabIndex = 1;
            label2.Text = "Chef de Projet";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 37);
            label3.Name = "label3";
            label3.Size = new Size(239, 48);
            label3.TabIndex = 2;
            label3.Text = "Chef d’Équipe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 38);
            label4.Name = "label4";
            label4.Size = new Size(302, 48);
            label4.TabIndex = 1;
            label4.Text = "Membre d’Équipe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 863);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            panelChefProjet.ResumeLayout(false);
            panelChefProjet.PerformLayout();
            panelChefEquipe.ResumeLayout(false);
            panelChefEquipe.PerformLayout();
            panelMembreEquipe.ResumeLayout(false);
            panelMembreEquipe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelMenu;
        private Panel panel2;
        private Panel panelMain;
        private Button btnLogout;
        private Button btnTeam;
        private Button btnTasks;
        private Button btnProjects;
        private Button btnDashboard;
        private Panel panelMembreEquipe;
        private TextBox textBox4;
        private Panel panelChefEquipe;
        private TextBox textBox3;
        private Panel panel6;
        private Panel panelChefProjet;
        private TextBox textBox2;
        private Panel panelAdmin;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
