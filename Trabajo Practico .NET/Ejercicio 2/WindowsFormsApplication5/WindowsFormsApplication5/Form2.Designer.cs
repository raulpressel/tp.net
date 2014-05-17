namespace WindowsFormsApplication5
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this._AccesoDatos_AccesoADatosDataSet1 = new WindowsFormsApplication5._AccesoDatos_AccesoADatosDataSet1();
            this.gerentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerentesTableAdapter = new WindowsFormsApplication5._AccesoDatos_AccesoADatosDataSet1TableAdapters.GerentesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DNIG = new System.Windows.Forms.Label();
            this.ContraseñaG = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.ApellidoG = new System.Windows.Forms.Label();
            this.NombreG = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._AccesoDatos_AccesoADatosDataSet2 = new WindowsFormsApplication5._AccesoDatos_AccesoADatosDataSet2();
            this.gerentesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gerentesTableAdapter1 = new WindowsFormsApplication5._AccesoDatos_AccesoADatosDataSet2TableAdapters.GerentesTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this._AccesoDatos_AccesoADatosDataSet3 = new WindowsFormsApplication5._AccesoDatos_AccesoADatosDataSet3();
            this.proyectoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoesTableAdapter = new WindowsFormsApplication5._AccesoDatos_AccesoADatosDataSet3TableAdapters.ProyectoesTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this._AccesoDatos_AccesoADatosDataSet4 = new WindowsFormsApplication5._AccesoDatos_AccesoADatosDataSet4();
            this.factorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factorsTableAdapter = new WindowsFormsApplication5._AccesoDatos_AccesoADatosDataSet4TableAdapters.FactorsTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._AccesoDatos_AccesoADatosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerentesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._AccesoDatos_AccesoADatosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerentesBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._AccesoDatos_AccesoADatosDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoesBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._AccesoDatos_AccesoADatosDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Baja";
            // 
            // _AccesoDatos_AccesoADatosDataSet1
            // 
            this._AccesoDatos_AccesoADatosDataSet1.DataSetName = "_AccesoDatos_AccesoADatosDataSet1";
            this._AccesoDatos_AccesoADatosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gerentesBindingSource
            // 
            this.gerentesBindingSource.DataMember = "Gerentes";
            this.gerentesBindingSource.DataSource = this._AccesoDatos_AccesoADatosDataSet1;
            // 
            // gerentesTableAdapter
            // 
            this.gerentesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.DNIG);
            this.groupBox1.Controls.Add(this.ContraseñaG);
            this.groupBox1.Controls.Add(this.Usuario);
            this.groupBox1.Controls.Add(this.ApellidoG);
            this.groupBox1.Controls.Add(this.NombreG);
            this.groupBox1.Location = new System.Drawing.Point(543, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 244);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerente";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(117, 164);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(94, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 5;
            // 
            // DNIG
            // 
            this.DNIG.AutoSize = true;
            this.DNIG.Location = new System.Drawing.Point(23, 167);
            this.DNIG.Name = "DNIG";
            this.DNIG.Size = new System.Drawing.Size(26, 13);
            this.DNIG.TabIndex = 4;
            this.DNIG.Text = "DNI";
            // 
            // ContraseñaG
            // 
            this.ContraseñaG.AutoSize = true;
            this.ContraseñaG.Location = new System.Drawing.Point(23, 141);
            this.ContraseñaG.Name = "ContraseñaG";
            this.ContraseñaG.Size = new System.Drawing.Size(61, 13);
            this.ContraseñaG.TabIndex = 3;
            this.ContraseñaG.Text = "Contraseña";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(23, 116);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Usuario";
            // 
            // ApellidoG
            // 
            this.ApellidoG.AutoSize = true;
            this.ApellidoG.Location = new System.Drawing.Point(23, 88);
            this.ApellidoG.Name = "ApellidoG";
            this.ApellidoG.Size = new System.Drawing.Size(44, 13);
            this.ApellidoG.TabIndex = 1;
            this.ApellidoG.Text = "Apellido";
            // 
            // NombreG
            // 
            this.NombreG.AutoSize = true;
            this.NombreG.Location = new System.Drawing.Point(23, 63);
            this.NombreG.Name = "NombreG";
            this.NombreG.Size = new System.Drawing.Size(44, 13);
            this.NombreG.TabIndex = 0;
            this.NombreG.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.gerentesBindingSource;
            this.comboBox1.DisplayMember = "Id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(117, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // _AccesoDatos_AccesoADatosDataSet2
            // 
            this._AccesoDatos_AccesoADatosDataSet2.DataSetName = "_AccesoDatos_AccesoADatosDataSet2";
            this._AccesoDatos_AccesoADatosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gerentesBindingSource1
            // 
            this.gerentesBindingSource1.DataMember = "Gerentes";
            this.gerentesBindingSource1.DataSource = this._AccesoDatos_AccesoADatosDataSet2;
            // 
            // gerentesTableAdapter1
            // 
            this.gerentesTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleccione Id";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(21, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 244);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proyecto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seleccione Id";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.proyectoesBindingSource;
            this.comboBox2.DisplayMember = "Id";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox2.Location = new System.Drawing.Point(117, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(94, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "Id";
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(117, 86);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(94, 20);
            this.textBox9.TabIndex = 6;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(117, 59);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(94, 20);
            this.textBox10.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Descripcion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha";
            // 
            // _AccesoDatos_AccesoADatosDataSet3
            // 
            this._AccesoDatos_AccesoADatosDataSet3.DataSetName = "_AccesoDatos_AccesoADatosDataSet3";
            this._AccesoDatos_AccesoADatosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoesBindingSource
            // 
            this.proyectoesBindingSource.DataMember = "Proyectoes";
            this.proyectoesBindingSource.DataSource = this._AccesoDatos_AccesoADatosDataSet3;
            // 
            // proyectoesTableAdapter
            // 
            this.proyectoesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(277, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 244);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Factor";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Seleccione Id";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(20, 210);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 7;
            this.button9.Text = "Eliminar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.factorsBindingSource;
            this.comboBox3.DisplayMember = "Id";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox3.Location = new System.Drawing.Point(117, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(94, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.ValueMember = "Id";
            this.comboBox3.TextChanged += new System.EventHandler(this.comboBox3_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(117, 86);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(94, 20);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(117, 59);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(94, 20);
            this.textBox7.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ponderacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(26, 119);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Habilitado          ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // _AccesoDatos_AccesoADatosDataSet4
            // 
            this._AccesoDatos_AccesoADatosDataSet4.DataSetName = "_AccesoDatos_AccesoADatosDataSet4";
            this._AccesoDatos_AccesoADatosDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factorsBindingSource
            // 
            this.factorsBindingSource.DataMember = "Factors";
            this.factorsBindingSource.DataSource = this._AccesoDatos_AccesoADatosDataSet4;
            // 
            // factorsTableAdapter
            // 
            this.factorsTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Modificar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(136, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Modificar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(136, 210);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "Modificar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Modificar";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(814, 358);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this._AccesoDatos_AccesoADatosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerentesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._AccesoDatos_AccesoADatosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerentesBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._AccesoDatos_AccesoADatosDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoesBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._AccesoDatos_AccesoADatosDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _AccesoDatos_AccesoADatosDataSet1 _AccesoDatos_AccesoADatosDataSet1;
        private System.Windows.Forms.BindingSource gerentesBindingSource;
        private _AccesoDatos_AccesoADatosDataSet1TableAdapters.GerentesTableAdapter gerentesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DNIG;
        private System.Windows.Forms.Label ContraseñaG;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label ApellidoG;
        private System.Windows.Forms.Label NombreG;
        private System.Windows.Forms.Button button2;
        private _AccesoDatos_AccesoADatosDataSet2 _AccesoDatos_AccesoADatosDataSet2;
        private System.Windows.Forms.BindingSource gerentesBindingSource1;
        private _AccesoDatos_AccesoADatosDataSet2TableAdapters.GerentesTableAdapter gerentesTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private _AccesoDatos_AccesoADatosDataSet3 _AccesoDatos_AccesoADatosDataSet3;
        private System.Windows.Forms.BindingSource proyectoesBindingSource;
        private _AccesoDatos_AccesoADatosDataSet3TableAdapters.ProyectoesTableAdapter proyectoesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private _AccesoDatos_AccesoADatosDataSet4 _AccesoDatos_AccesoADatosDataSet4;
        private System.Windows.Forms.BindingSource factorsBindingSource;
        private _AccesoDatos_AccesoADatosDataSet4TableAdapters.FactorsTableAdapter factorsTableAdapter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
    }
}