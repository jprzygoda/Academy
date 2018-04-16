namespace DeansOffice
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.StudentNumberCheckBox = new System.Windows.Forms.CheckBox();
            this.LastNameCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchPhraseTB = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SemesterPanel = new System.Windows.Forms.Panel();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.SemesterComboBox = new System.Windows.Forms.ComboBox();
            this.StudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.GridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajStudentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SemesterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).BeginInit();
            this.GridViewContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.StudentNumberCheckBox);
            this.SearchPanel.Controls.Add(this.LastNameCheckBox);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.searchPhraseTB);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchPanel.Location = new System.Drawing.Point(0, 24);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(543, 56);
            this.SearchPanel.TabIndex = 0;
            // 
            // StudentNumberCheckBox
            // 
            this.StudentNumberCheckBox.AutoSize = true;
            this.StudentNumberCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentNumberCheckBox.Location = new System.Drawing.Point(380, 18);
            this.StudentNumberCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentNumberCheckBox.Name = "StudentNumberCheckBox";
            this.StudentNumberCheckBox.Size = new System.Drawing.Size(143, 24);
            this.StudentNumberCheckBox.TabIndex = 3;
            this.StudentNumberCheckBox.Text = "Indeks studenta";
            this.StudentNumberCheckBox.UseVisualStyleBackColor = true;
            // 
            // LastNameCheckBox
            // 
            this.LastNameCheckBox.AutoSize = true;
            this.LastNameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastNameCheckBox.Location = new System.Drawing.Point(271, 18);
            this.LastNameCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastNameCheckBox.Name = "LastNameCheckBox";
            this.LastNameCheckBox.Size = new System.Drawing.Size(95, 24);
            this.LastNameCheckBox.TabIndex = 2;
            this.LastNameCheckBox.Text = "Nazwisko";
            this.LastNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchButton.Location = new System.Drawing.Point(144, 16);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 24);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Szukaj";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchPhraseTB
            // 
            this.searchPhraseTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchPhraseTB.Location = new System.Drawing.Point(12, 16);
            this.searchPhraseTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchPhraseTB.Name = "searchPhraseTB";
            this.searchPhraseTB.Size = new System.Drawing.Size(130, 26);
            this.searchPhraseTB.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem,
            this.dodajStudentaToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.FileToolStripMenuItem.Text = "Plik";
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CloseToolStripMenuItem.Text = "Zamknij";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // ReportsToolStripMenuItem
            // 
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.ReportsToolStripMenuItem.Text = "Raporty";
            // 
            // SemesterPanel
            // 
            this.SemesterPanel.Controls.Add(this.DeleteButton);
            this.SemesterPanel.Controls.Add(this.SemesterLabel);
            this.SemesterPanel.Controls.Add(this.SemesterComboBox);
            this.SemesterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SemesterPanel.Location = new System.Drawing.Point(0, 281);
            this.SemesterPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SemesterPanel.Name = "SemesterPanel";
            this.SemesterPanel.Size = new System.Drawing.Size(543, 60);
            this.SemesterPanel.TabIndex = 2;
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SemesterLabel.Location = new System.Drawing.Point(9, 21);
            this.SemesterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(69, 20);
            this.SemesterLabel.TabIndex = 1;
            this.SemesterLabel.Text = "Semestr";
            // 
            // SemesterComboBox
            // 
            this.SemesterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SemesterComboBox.FormattingEnabled = true;
            this.SemesterComboBox.Location = new System.Drawing.Point(80, 19);
            this.SemesterComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SemesterComboBox.Name = "SemesterComboBox";
            this.SemesterComboBox.Size = new System.Drawing.Size(174, 28);
            this.SemesterComboBox.TabIndex = 0;
            this.SemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.SemesterComboBox_SelectedIndexChanged);
            // 
            // StudentsDataGridView
            // 
            this.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsDataGridView.Location = new System.Drawing.Point(0, 80);
            this.StudentsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentsDataGridView.Name = "StudentsDataGridView";
            this.StudentsDataGridView.RowTemplate.Height = 33;
            this.StudentsDataGridView.Size = new System.Drawing.Size(543, 201);
            this.StudentsDataGridView.TabIndex = 3;
            // 
            // GridViewContextMenuStrip
            // 
            this.GridViewContextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.GridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStudentToolStripMenuItem,
            this.EditStudentToolStripMenuItem,
            this.RemoveStudentToolStripMenuItem});
            this.GridViewContextMenuStrip.Name = "GridViewContextMenuStrip";
            this.GridViewContextMenuStrip.Size = new System.Drawing.Size(157, 70);
            // 
            // AddStudentToolStripMenuItem
            // 
            this.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem";
            this.AddStudentToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.AddStudentToolStripMenuItem.Text = "Dodaj studenta";
            this.AddStudentToolStripMenuItem.Click += new System.EventHandler(this.AddStudentToolStripMenuItem_Click);
            // 
            // EditStudentToolStripMenuItem
            // 
            this.EditStudentToolStripMenuItem.Name = "EditStudentToolStripMenuItem";
            this.EditStudentToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.EditStudentToolStripMenuItem.Text = "Edytuj studenta";
            this.EditStudentToolStripMenuItem.Click += new System.EventHandler(this.EditStudentToolStripMenuItem_Click);
            // 
            // RemoveStudentToolStripMenuItem
            // 
            this.RemoveStudentToolStripMenuItem.Name = "RemoveStudentToolStripMenuItem";
            this.RemoveStudentToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.RemoveStudentToolStripMenuItem.Text = "Usuń studenta";
            this.RemoveStudentToolStripMenuItem.Click += new System.EventHandler(this.RemoveStudentToolStripMenuItem_Click);
            // 
            // dodajStudentaToolStripMenuItem
            // 
            this.dodajStudentaToolStripMenuItem.Name = "dodajStudentaToolStripMenuItem";
            this.dodajStudentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajStudentaToolStripMenuItem.Text = "Dodaj studenta";
            this.dodajStudentaToolStripMenuItem.Click += new System.EventHandler(this.dodajStudentaToolStripMenuItem_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.Location = new System.Drawing.Point(439, 17);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(84, 24);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 341);
            this.Controls.Add(this.StudentsDataGridView);
            this.Controls.Add(this.SemesterPanel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Aplikacja dziekanat";
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SemesterPanel.ResumeLayout(false);
            this.SemesterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).EndInit();
            this.GridViewContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.TextBox searchPhraseTB;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.CheckBox LastNameCheckBox;
        private System.Windows.Forms.CheckBox StudentNumberCheckBox;
        private System.Windows.Forms.Panel SemesterPanel;
        private System.Windows.Forms.DataGridView StudentsDataGridView;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.ComboBox SemesterComboBox;
        private System.Windows.Forms.ContextMenuStrip GridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajStudentaToolStripMenuItem;
        private System.Windows.Forms.Button DeleteButton;
    }
}

