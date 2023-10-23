﻿namespace KukaMovementEditor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_IncrementalMove = new System.Windows.Forms.GroupBox();
            this.textBox_DistanceStep = new System.Windows.Forms.TextBox();
            this.button_rZplus = new System.Windows.Forms.Button();
            this.button_Zplus = new System.Windows.Forms.Button();
            this.button_rYplus = new System.Windows.Forms.Button();
            this.button_Yplus = new System.Windows.Forms.Button();
            this.button_rXplus = new System.Windows.Forms.Button();
            this.button_Xplus = new System.Windows.Forms.Button();
            this.button_rZminus = new System.Windows.Forms.Button();
            this.button_rYminus = new System.Windows.Forms.Button();
            this.button_rXminus = new System.Windows.Forms.Button();
            this.button_Zminus = new System.Windows.Forms.Button();
            this.button_Yminus = new System.Windows.Forms.Button();
            this.button_Xminus = new System.Windows.Forms.Button();
            this.radioButton_JointMove = new System.Windows.Forms.RadioButton();
            this.radioButton_Tool = new System.Windows.Forms.RadioButton();
            this.radioButton_Reference = new System.Windows.Forms.RadioButton();
            this.groupBox_Mode = new System.Windows.Forms.GroupBox();
            this.button_RealRobot = new System.Windows.Forms.Button();
            this.button_Simulation = new System.Windows.Forms.Button();
            this.groupBox_currentPosition = new System.Windows.Forms.GroupBox();
            this.label_Position = new System.Windows.Forms.Label();
            this.label_Joints = new System.Windows.Forms.Label();
            this.textBox_Positions = new System.Windows.Forms.TextBox();
            this.textBox_Joints = new System.Windows.Forms.TextBox();
            this.groupBox_PositionList = new System.Windows.Forms.GroupBox();
            this.listBox_PositionList = new System.Windows.Forms.ListBox();
            this.listBox_NameList = new System.Windows.Forms.ListBox();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Run = new System.Windows.Forms.Button();
            this.button_LoadSaveTxT = new System.Windows.Forms.Button();
            this.button_LoadTxT = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.listBox_JointsList = new System.Windows.Forms.ListBox();
            this.button_Select = new System.Windows.Forms.Button();
            this.groupBox_Gripper = new System.Windows.Forms.GroupBox();
            this.button_GripperClose = new System.Windows.Forms.Button();
            this.button_GripperOpen = new System.Windows.Forms.Button();
            this.groupBox_MoveToPosition = new System.Windows.Forms.GroupBox();
            this.button_JointsMove = new System.Windows.Forms.Button();
            this.textBox_MoveToJoints = new System.Windows.Forms.TextBox();
            this.button_PositionMove = new System.Windows.Forms.Button();
            this.textBox_MoveToPosition = new System.Windows.Forms.TextBox();
            this.button_InsertGripperOpen = new System.Windows.Forms.Button();
            this.button_InsertGripperClose = new System.Windows.Forms.Button();
            this.groupBox_IncrementalMove.SuspendLayout();
            this.groupBox_Mode.SuspendLayout();
            this.groupBox_currentPosition.SuspendLayout();
            this.groupBox_PositionList.SuspendLayout();
            this.groupBox_Gripper.SuspendLayout();
            this.groupBox_MoveToPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_IncrementalMove
            // 
            this.groupBox_IncrementalMove.Controls.Add(this.textBox_DistanceStep);
            this.groupBox_IncrementalMove.Controls.Add(this.button_rZplus);
            this.groupBox_IncrementalMove.Controls.Add(this.button_Zplus);
            this.groupBox_IncrementalMove.Controls.Add(this.button_rYplus);
            this.groupBox_IncrementalMove.Controls.Add(this.button_Yplus);
            this.groupBox_IncrementalMove.Controls.Add(this.button_rXplus);
            this.groupBox_IncrementalMove.Controls.Add(this.button_Xplus);
            this.groupBox_IncrementalMove.Controls.Add(this.button_rZminus);
            this.groupBox_IncrementalMove.Controls.Add(this.button_rYminus);
            this.groupBox_IncrementalMove.Controls.Add(this.button_rXminus);
            this.groupBox_IncrementalMove.Controls.Add(this.button_Zminus);
            this.groupBox_IncrementalMove.Controls.Add(this.button_Yminus);
            this.groupBox_IncrementalMove.Controls.Add(this.button_Xminus);
            this.groupBox_IncrementalMove.Controls.Add(this.radioButton_JointMove);
            this.groupBox_IncrementalMove.Controls.Add(this.radioButton_Tool);
            this.groupBox_IncrementalMove.Controls.Add(this.radioButton_Reference);
            this.groupBox_IncrementalMove.Location = new System.Drawing.Point(9, 10);
            this.groupBox_IncrementalMove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_IncrementalMove.Name = "groupBox_IncrementalMove";
            this.groupBox_IncrementalMove.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_IncrementalMove.Size = new System.Drawing.Size(143, 262);
            this.groupBox_IncrementalMove.TabIndex = 0;
            this.groupBox_IncrementalMove.TabStop = false;
            this.groupBox_IncrementalMove.Text = "Incremental Move";
            // 
            // textBox_DistanceStep
            // 
            this.textBox_DistanceStep.Location = new System.Drawing.Point(13, 92);
            this.textBox_DistanceStep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_DistanceStep.Name = "textBox_DistanceStep";
            this.textBox_DistanceStep.Size = new System.Drawing.Size(76, 20);
            this.textBox_DistanceStep.TabIndex = 15;
            this.textBox_DistanceStep.Text = "10";
            // 
            // button_rZplus
            // 
            this.button_rZplus.Location = new System.Drawing.Point(74, 232);
            this.button_rZplus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_rZplus.Name = "button_rZplus";
            this.button_rZplus.Size = new System.Drawing.Size(56, 19);
            this.button_rZplus.TabIndex = 14;
            this.button_rZplus.Text = "rZ+";
            this.button_rZplus.UseVisualStyleBackColor = true;
            this.button_rZplus.Click += new System.EventHandler(this.IncrementalMovementClick);
            // 
            // button_Zplus
            // 
            this.button_Zplus.Location = new System.Drawing.Point(74, 162);
            this.button_Zplus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Zplus.Name = "button_Zplus";
            this.button_Zplus.Size = new System.Drawing.Size(56, 19);
            this.button_Zplus.TabIndex = 11;
            this.button_Zplus.Text = "Z+";
            this.button_Zplus.UseVisualStyleBackColor = true;
            this.button_Zplus.Click += new System.EventHandler(this.IncrementalMovementClick);
            // 
            // button_rYplus
            // 
            this.button_rYplus.Location = new System.Drawing.Point(74, 209);
            this.button_rYplus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_rYplus.Name = "button_rYplus";
            this.button_rYplus.Size = new System.Drawing.Size(56, 19);
            this.button_rYplus.TabIndex = 13;
            this.button_rYplus.Text = "rY+";
            this.button_rYplus.UseVisualStyleBackColor = true;
            this.button_rYplus.Click += new System.EventHandler(this.IncrementalMovementClick);
            // 
            // button_Yplus
            // 
            this.button_Yplus.Location = new System.Drawing.Point(74, 138);
            this.button_Yplus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Yplus.Name = "button_Yplus";
            this.button_Yplus.Size = new System.Drawing.Size(56, 19);
            this.button_Yplus.TabIndex = 10;
            this.button_Yplus.Text = "Y+";
            this.button_Yplus.UseVisualStyleBackColor = true;
            this.button_Yplus.Click += new System.EventHandler(this.IncrementalMovementClick);
            // 
            // button_rXplus
            // 
            this.button_rXplus.Location = new System.Drawing.Point(74, 185);
            this.button_rXplus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_rXplus.Name = "button_rXplus";
            this.button_rXplus.Size = new System.Drawing.Size(56, 19);
            this.button_rXplus.TabIndex = 12;
            this.button_rXplus.Text = "rX+";
            this.button_rXplus.UseVisualStyleBackColor = true;
            this.button_rXplus.Click += new System.EventHandler(this.IncrementalMovementClick);
            // 
            // button_Xplus
            // 
            this.button_Xplus.Location = new System.Drawing.Point(74, 115);
            this.button_Xplus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Xplus.Name = "button_Xplus";
            this.button_Xplus.Size = new System.Drawing.Size(56, 19);
            this.button_Xplus.TabIndex = 9;
            this.button_Xplus.Text = "X+";
            this.button_Xplus.UseVisualStyleBackColor = true;
            this.button_Xplus.Click += new System.EventHandler(this.IncrementalMovementClick);
            // 
            // button_rZminus
            // 
            this.button_rZminus.Location = new System.Drawing.Point(13, 232);
            this.button_rZminus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_rZminus.Name = "button_rZminus";
            this.button_rZminus.Size = new System.Drawing.Size(56, 19);
            this.button_rZminus.TabIndex = 8;
            this.button_rZminus.Text = "rZ-";
            this.button_rZminus.UseVisualStyleBackColor = true;
            this.button_rZminus.Click += new System.EventHandler(this.IncrementalMovementClick);
            // 
            // button_rYminus
            // 
            this.button_rYminus.Location = new System.Drawing.Point(13, 209);
            this.button_rYminus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_rYminus.Name = "button_rYminus";
            this.button_rYminus.Size = new System.Drawing.Size(56, 19);
            this.button_rYminus.TabIndex = 7;
            this.button_rYminus.Text = "rY-";
            this.button_rYminus.UseVisualStyleBackColor = true;
            this.button_rYminus.Click += new System.EventHandler(this.IncrementalMovementClick);
            // 
            // button_rXminus
            // 
            this.button_rXminus.Location = new System.Drawing.Point(13, 185);
            this.button_rXminus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_rXminus.Name = "button_rXminus";
            this.button_rXminus.Size = new System.Drawing.Size(56, 19);
            this.button_rXminus.TabIndex = 6;
            this.button_rXminus.Text = "rX-";
            this.button_rXminus.UseVisualStyleBackColor = true;
            this.button_rXminus.Click += new System.EventHandler(this.IncrementalMovementClick);
            // 
            // button_Zminus
            // 
            this.button_Zminus.Location = new System.Drawing.Point(13, 162);
            this.button_Zminus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Zminus.Name = "button_Zminus";
            this.button_Zminus.Size = new System.Drawing.Size(56, 19);
            this.button_Zminus.TabIndex = 5;
            this.button_Zminus.Text = "Z-";
            this.button_Zminus.UseVisualStyleBackColor = true;
            this.button_Zminus.Click += new System.EventHandler(this.IncrementalMovementClick);
            // 
            // button_Yminus
            // 
            this.button_Yminus.Location = new System.Drawing.Point(13, 138);
            this.button_Yminus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Yminus.Name = "button_Yminus";
            this.button_Yminus.Size = new System.Drawing.Size(56, 19);
            this.button_Yminus.TabIndex = 4;
            this.button_Yminus.Text = "Y-";
            this.button_Yminus.UseVisualStyleBackColor = true;
            this.button_Yminus.Click += new System.EventHandler(this.IncrementalMovementClick);
            // 
            // button_Xminus
            // 
            this.button_Xminus.Location = new System.Drawing.Point(13, 115);
            this.button_Xminus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Xminus.Name = "button_Xminus";
            this.button_Xminus.Size = new System.Drawing.Size(56, 19);
            this.button_Xminus.TabIndex = 3;
            this.button_Xminus.Text = "X-";
            this.button_Xminus.UseVisualStyleBackColor = true;
            this.button_Xminus.Click += new System.EventHandler(this.IncrementalMovementClick);
            // 
            // radioButton_JointMove
            // 
            this.radioButton_JointMove.AutoSize = true;
            this.radioButton_JointMove.Location = new System.Drawing.Point(13, 68);
            this.radioButton_JointMove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_JointMove.Name = "radioButton_JointMove";
            this.radioButton_JointMove.Size = new System.Drawing.Size(77, 17);
            this.radioButton_JointMove.TabIndex = 2;
            this.radioButton_JointMove.TabStop = true;
            this.radioButton_JointMove.Text = "Joint Move";
            this.radioButton_JointMove.UseVisualStyleBackColor = true;
            this.radioButton_JointMove.CheckedChanged += new System.EventHandler(this.IncrementalMoveRadioCheckedChange);
            // 
            // radioButton_Tool
            // 
            this.radioButton_Tool.AutoSize = true;
            this.radioButton_Tool.Location = new System.Drawing.Point(13, 47);
            this.radioButton_Tool.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_Tool.Name = "radioButton_Tool";
            this.radioButton_Tool.Size = new System.Drawing.Size(46, 17);
            this.radioButton_Tool.TabIndex = 1;
            this.radioButton_Tool.TabStop = true;
            this.radioButton_Tool.Text = "Tool";
            this.radioButton_Tool.UseVisualStyleBackColor = true;
            this.radioButton_Tool.CheckedChanged += new System.EventHandler(this.IncrementalMoveRadioCheckedChange);
            // 
            // radioButton_Reference
            // 
            this.radioButton_Reference.AutoSize = true;
            this.radioButton_Reference.Location = new System.Drawing.Point(13, 26);
            this.radioButton_Reference.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_Reference.Name = "radioButton_Reference";
            this.radioButton_Reference.Size = new System.Drawing.Size(75, 17);
            this.radioButton_Reference.TabIndex = 0;
            this.radioButton_Reference.TabStop = true;
            this.radioButton_Reference.Text = "Reference";
            this.radioButton_Reference.UseVisualStyleBackColor = true;
            this.radioButton_Reference.CheckedChanged += new System.EventHandler(this.IncrementalMoveRadioCheckedChange);
            // 
            // groupBox_Mode
            // 
            this.groupBox_Mode.Controls.Add(this.button_RealRobot);
            this.groupBox_Mode.Controls.Add(this.button_Simulation);
            this.groupBox_Mode.Location = new System.Drawing.Point(157, 10);
            this.groupBox_Mode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Mode.Name = "groupBox_Mode";
            this.groupBox_Mode.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Mode.Size = new System.Drawing.Size(114, 70);
            this.groupBox_Mode.TabIndex = 1;
            this.groupBox_Mode.TabStop = false;
            this.groupBox_Mode.Text = "Mode";
            // 
            // button_RealRobot
            // 
            this.button_RealRobot.Location = new System.Drawing.Point(4, 43);
            this.button_RealRobot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_RealRobot.Name = "button_RealRobot";
            this.button_RealRobot.Size = new System.Drawing.Size(105, 19);
            this.button_RealRobot.TabIndex = 1;
            this.button_RealRobot.Text = "Real Robot";
            this.button_RealRobot.UseVisualStyleBackColor = true;
            this.button_RealRobot.Click += new System.EventHandler(this.btn_RobotRealRobot_Click);
            // 
            // button_Simulation
            // 
            this.button_Simulation.Location = new System.Drawing.Point(4, 17);
            this.button_Simulation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Simulation.Name = "button_Simulation";
            this.button_Simulation.Size = new System.Drawing.Size(105, 19);
            this.button_Simulation.TabIndex = 0;
            this.button_Simulation.Text = "Simulation";
            this.button_Simulation.UseVisualStyleBackColor = true;
            this.button_Simulation.Click += new System.EventHandler(this.btn_RobotSimulation_Click);
            // 
            // groupBox_currentPosition
            // 
            this.groupBox_currentPosition.Controls.Add(this.label_Position);
            this.groupBox_currentPosition.Controls.Add(this.label_Joints);
            this.groupBox_currentPosition.Controls.Add(this.textBox_Positions);
            this.groupBox_currentPosition.Controls.Add(this.textBox_Joints);
            this.groupBox_currentPosition.Location = new System.Drawing.Point(9, 280);
            this.groupBox_currentPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_currentPosition.Name = "groupBox_currentPosition";
            this.groupBox_currentPosition.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_currentPosition.Size = new System.Drawing.Size(739, 76);
            this.groupBox_currentPosition.TabIndex = 2;
            this.groupBox_currentPosition.TabStop = false;
            this.groupBox_currentPosition.Text = "current Position";
            // 
            // label_Position
            // 
            this.label_Position.AutoSize = true;
            this.label_Position.Location = new System.Drawing.Point(10, 50);
            this.label_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(47, 13);
            this.label_Position.TabIndex = 3;
            this.label_Position.Text = "Position:";
            // 
            // label_Joints
            // 
            this.label_Joints.AutoSize = true;
            this.label_Joints.Location = new System.Drawing.Point(10, 26);
            this.label_Joints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Joints.Name = "label_Joints";
            this.label_Joints.Size = new System.Drawing.Size(37, 13);
            this.label_Joints.TabIndex = 2;
            this.label_Joints.Text = "Joints:";
            // 
            // textBox_Positions
            // 
            this.textBox_Positions.Location = new System.Drawing.Point(68, 48);
            this.textBox_Positions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Positions.Name = "textBox_Positions";
            this.textBox_Positions.ReadOnly = true;
            this.textBox_Positions.Size = new System.Drawing.Size(667, 20);
            this.textBox_Positions.TabIndex = 1;
            // 
            // textBox_Joints
            // 
            this.textBox_Joints.Location = new System.Drawing.Point(68, 24);
            this.textBox_Joints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Joints.Name = "textBox_Joints";
            this.textBox_Joints.ReadOnly = true;
            this.textBox_Joints.Size = new System.Drawing.Size(667, 20);
            this.textBox_Joints.TabIndex = 0;
            // 
            // groupBox_PositionList
            // 
            this.groupBox_PositionList.Controls.Add(this.button_InsertGripperClose);
            this.groupBox_PositionList.Controls.Add(this.button_InsertGripperOpen);
            this.groupBox_PositionList.Controls.Add(this.listBox_PositionList);
            this.groupBox_PositionList.Controls.Add(this.listBox_NameList);
            this.groupBox_PositionList.Controls.Add(this.button_Insert);
            this.groupBox_PositionList.Controls.Add(this.button_Run);
            this.groupBox_PositionList.Controls.Add(this.button_LoadSaveTxT);
            this.groupBox_PositionList.Controls.Add(this.button_LoadTxT);
            this.groupBox_PositionList.Controls.Add(this.button_New);
            this.groupBox_PositionList.Controls.Add(this.button_Delete);
            this.groupBox_PositionList.Controls.Add(this.textBox_Name);
            this.groupBox_PositionList.Controls.Add(this.listBox_JointsList);
            this.groupBox_PositionList.Controls.Add(this.button_Select);
            this.groupBox_PositionList.Location = new System.Drawing.Point(275, 10);
            this.groupBox_PositionList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_PositionList.Name = "groupBox_PositionList";
            this.groupBox_PositionList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_PositionList.Size = new System.Drawing.Size(472, 262);
            this.groupBox_PositionList.TabIndex = 3;
            this.groupBox_PositionList.TabStop = false;
            this.groupBox_PositionList.Text = "Position List";
            // 
            // listBox_PositionList
            // 
            this.listBox_PositionList.FormattingEnabled = true;
            this.listBox_PositionList.Location = new System.Drawing.Point(241, 17);
            this.listBox_PositionList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_PositionList.Name = "listBox_PositionList";
            this.listBox_PositionList.ScrollAlwaysVisible = true;
            this.listBox_PositionList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_PositionList.Size = new System.Drawing.Size(105, 238);
            this.listBox_PositionList.TabIndex = 14;
            // 
            // listBox_NameList
            // 
            this.listBox_NameList.FormattingEnabled = true;
            this.listBox_NameList.Location = new System.Drawing.Point(4, 17);
            this.listBox_NameList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_NameList.Name = "listBox_NameList";
            this.listBox_NameList.ScrollAlwaysVisible = true;
            this.listBox_NameList.Size = new System.Drawing.Size(124, 238);
            this.listBox_NameList.TabIndex = 13;
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(350, 86);
            this.button_Insert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(109, 19);
            this.button_Insert.TabIndex = 12;
            this.button_Insert.Text = "Insert";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(350, 236);
            this.button_Run.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(109, 19);
            this.button_Run.TabIndex = 11;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // button_LoadSaveTxT
            // 
            this.button_LoadSaveTxT.Location = new System.Drawing.Point(350, 188);
            this.button_LoadSaveTxT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_LoadSaveTxT.Name = "button_LoadSaveTxT";
            this.button_LoadSaveTxT.Size = new System.Drawing.Size(109, 19);
            this.button_LoadSaveTxT.TabIndex = 10;
            this.button_LoadSaveTxT.Text = "Save .kmf";
            this.button_LoadSaveTxT.UseVisualStyleBackColor = true;
            this.button_LoadSaveTxT.Click += new System.EventHandler(this.button_LoadSaveTxT_Click);
            // 
            // button_LoadTxT
            // 
            this.button_LoadTxT.Location = new System.Drawing.Point(350, 212);
            this.button_LoadTxT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_LoadTxT.Name = "button_LoadTxT";
            this.button_LoadTxT.Size = new System.Drawing.Size(109, 19);
            this.button_LoadTxT.TabIndex = 9;
            this.button_LoadTxT.Text = "Load .kmf";
            this.button_LoadTxT.UseVisualStyleBackColor = true;
            this.button_LoadTxT.Click += new System.EventHandler(this.button_LoadTxT_Click);
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(350, 40);
            this.button_New.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(109, 19);
            this.button_New.TabIndex = 8;
            this.button_New.Text = "New";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(350, 110);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(109, 19);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(350, 17);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(110, 20);
            this.textBox_Name.TabIndex = 7;
            // 
            // listBox_JointsList
            // 
            this.listBox_JointsList.FormattingEnabled = true;
            this.listBox_JointsList.Location = new System.Drawing.Point(132, 17);
            this.listBox_JointsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_JointsList.Name = "listBox_JointsList";
            this.listBox_JointsList.ScrollAlwaysVisible = true;
            this.listBox_JointsList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_JointsList.Size = new System.Drawing.Size(105, 238);
            this.listBox_JointsList.TabIndex = 0;
            // 
            // button_Select
            // 
            this.button_Select.Location = new System.Drawing.Point(350, 63);
            this.button_Select.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(109, 19);
            this.button_Select.TabIndex = 4;
            this.button_Select.Text = "Select";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // groupBox_Gripper
            // 
            this.groupBox_Gripper.Controls.Add(this.button_GripperClose);
            this.groupBox_Gripper.Controls.Add(this.button_GripperOpen);
            this.groupBox_Gripper.Location = new System.Drawing.Point(157, 84);
            this.groupBox_Gripper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Gripper.Name = "groupBox_Gripper";
            this.groupBox_Gripper.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Gripper.Size = new System.Drawing.Size(114, 82);
            this.groupBox_Gripper.TabIndex = 4;
            this.groupBox_Gripper.TabStop = false;
            this.groupBox_Gripper.Text = "Gripper";
            // 
            // button_GripperClose
            // 
            this.button_GripperClose.Location = new System.Drawing.Point(4, 48);
            this.button_GripperClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_GripperClose.Name = "button_GripperClose";
            this.button_GripperClose.Size = new System.Drawing.Size(105, 26);
            this.button_GripperClose.TabIndex = 2;
            this.button_GripperClose.Text = "GripperClose";
            this.button_GripperClose.UseVisualStyleBackColor = true;
            this.button_GripperClose.Click += new System.EventHandler(this.button_GripperClose_Click);
            // 
            // button_GripperOpen
            // 
            this.button_GripperOpen.Location = new System.Drawing.Point(4, 17);
            this.button_GripperOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_GripperOpen.Name = "button_GripperOpen";
            this.button_GripperOpen.Size = new System.Drawing.Size(105, 26);
            this.button_GripperOpen.TabIndex = 3;
            this.button_GripperOpen.Text = "Gripper Open";
            this.button_GripperOpen.UseVisualStyleBackColor = true;
            this.button_GripperOpen.Click += new System.EventHandler(this.button_GripperOpen_Click);
            // 
            // groupBox_MoveToPosition
            // 
            this.groupBox_MoveToPosition.Controls.Add(this.button_JointsMove);
            this.groupBox_MoveToPosition.Controls.Add(this.textBox_MoveToJoints);
            this.groupBox_MoveToPosition.Controls.Add(this.button_PositionMove);
            this.groupBox_MoveToPosition.Controls.Add(this.textBox_MoveToPosition);
            this.groupBox_MoveToPosition.Location = new System.Drawing.Point(157, 171);
            this.groupBox_MoveToPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_MoveToPosition.Name = "groupBox_MoveToPosition";
            this.groupBox_MoveToPosition.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_MoveToPosition.Size = new System.Drawing.Size(114, 100);
            this.groupBox_MoveToPosition.TabIndex = 5;
            this.groupBox_MoveToPosition.TabStop = false;
            this.groupBox_MoveToPosition.Text = "MovePosition";
            // 
            // button_JointsMove
            // 
            this.button_JointsMove.Location = new System.Drawing.Point(4, 81);
            this.button_JointsMove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_JointsMove.Name = "button_JointsMove";
            this.button_JointsMove.Size = new System.Drawing.Size(105, 19);
            this.button_JointsMove.TabIndex = 3;
            this.button_JointsMove.Text = "Joints!";
            this.button_JointsMove.UseVisualStyleBackColor = true;
            this.button_JointsMove.Click += new System.EventHandler(this.button_JointsMove_Click);
            // 
            // textBox_MoveToJoints
            // 
            this.textBox_MoveToJoints.Location = new System.Drawing.Point(4, 62);
            this.textBox_MoveToJoints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_MoveToJoints.Name = "textBox_MoveToJoints";
            this.textBox_MoveToJoints.Size = new System.Drawing.Size(106, 20);
            this.textBox_MoveToJoints.TabIndex = 2;
            // 
            // button_PositionMove
            // 
            this.button_PositionMove.Location = new System.Drawing.Point(4, 38);
            this.button_PositionMove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_PositionMove.Name = "button_PositionMove";
            this.button_PositionMove.Size = new System.Drawing.Size(105, 19);
            this.button_PositionMove.TabIndex = 1;
            this.button_PositionMove.Text = "Position!";
            this.button_PositionMove.UseVisualStyleBackColor = true;
            this.button_PositionMove.Click += new System.EventHandler(this.button_PositionMove_Click);
            // 
            // textBox_MoveToPosition
            // 
            this.textBox_MoveToPosition.Location = new System.Drawing.Point(4, 17);
            this.textBox_MoveToPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_MoveToPosition.Name = "textBox_MoveToPosition";
            this.textBox_MoveToPosition.Size = new System.Drawing.Size(106, 20);
            this.textBox_MoveToPosition.TabIndex = 0;
            // 
            // button_InsertGripperOpen
            // 
            this.button_InsertGripperOpen.Location = new System.Drawing.Point(351, 133);
            this.button_InsertGripperOpen.Margin = new System.Windows.Forms.Padding(2);
            this.button_InsertGripperOpen.Name = "button_InsertGripperOpen";
            this.button_InsertGripperOpen.Size = new System.Drawing.Size(109, 19);
            this.button_InsertGripperOpen.TabIndex = 15;
            this.button_InsertGripperOpen.Text = "Insert GripperOpen";
            this.button_InsertGripperOpen.UseVisualStyleBackColor = true;
            this.button_InsertGripperOpen.Click += new System.EventHandler(this.button_InsertGripperOpen_Click);
            // 
            // button_InsertGripperClose
            // 
            this.button_InsertGripperClose.Location = new System.Drawing.Point(350, 156);
            this.button_InsertGripperClose.Margin = new System.Windows.Forms.Padding(2);
            this.button_InsertGripperClose.Name = "button_InsertGripperClose";
            this.button_InsertGripperClose.Size = new System.Drawing.Size(109, 19);
            this.button_InsertGripperClose.TabIndex = 16;
            this.button_InsertGripperClose.Text = "Insert Gripper Close";
            this.button_InsertGripperClose.UseVisualStyleBackColor = true;
            this.button_InsertGripperClose.Click += new System.EventHandler(this.button_InsertGripperClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 366);
            this.Controls.Add(this.groupBox_MoveToPosition);
            this.Controls.Add(this.groupBox_Gripper);
            this.Controls.Add(this.groupBox_PositionList);
            this.Controls.Add(this.groupBox_currentPosition);
            this.Controls.Add(this.groupBox_Mode);
            this.Controls.Add(this.groupBox_IncrementalMove);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "KukaMovementEditorWindow";
            this.groupBox_IncrementalMove.ResumeLayout(false);
            this.groupBox_IncrementalMove.PerformLayout();
            this.groupBox_Mode.ResumeLayout(false);
            this.groupBox_currentPosition.ResumeLayout(false);
            this.groupBox_currentPosition.PerformLayout();
            this.groupBox_PositionList.ResumeLayout(false);
            this.groupBox_PositionList.PerformLayout();
            this.groupBox_Gripper.ResumeLayout(false);
            this.groupBox_MoveToPosition.ResumeLayout(false);
            this.groupBox_MoveToPosition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_IncrementalMove;
        private System.Windows.Forms.RadioButton radioButton_JointMove;
        private System.Windows.Forms.RadioButton radioButton_Tool;
        private System.Windows.Forms.RadioButton radioButton_Reference;
        private System.Windows.Forms.Button button_rZplus;
        private System.Windows.Forms.Button button_rYplus;
        private System.Windows.Forms.Button button_rXplus;
        private System.Windows.Forms.Button button_rXminus;
        private System.Windows.Forms.Button button_Zminus;
        private System.Windows.Forms.Button button_Yminus;
        private System.Windows.Forms.Button button_Xminus;
        private System.Windows.Forms.Button button_rYminus;
        private System.Windows.Forms.Button button_rZminus;
        private System.Windows.Forms.Button button_Xplus;
        private System.Windows.Forms.Button button_Yplus;
        private System.Windows.Forms.Button button_Zplus;
        private System.Windows.Forms.TextBox textBox_DistanceStep;
        private System.Windows.Forms.GroupBox groupBox_Mode;
        private System.Windows.Forms.Button button_RealRobot;
        private System.Windows.Forms.Button button_Simulation;
        private System.Windows.Forms.GroupBox groupBox_currentPosition;
        private System.Windows.Forms.Label label_Position;
        private System.Windows.Forms.Label label_Joints;
        private System.Windows.Forms.TextBox textBox_Positions;
        private System.Windows.Forms.TextBox textBox_Joints;
        private System.Windows.Forms.GroupBox groupBox_PositionList;
        private System.Windows.Forms.ListBox listBox_JointsList;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_LoadSaveTxT;
        private System.Windows.Forms.Button button_LoadTxT;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.ListBox listBox_NameList;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.GroupBox groupBox_Gripper;
        private System.Windows.Forms.Button button_GripperClose;
        private System.Windows.Forms.Button button_GripperOpen;
        private System.Windows.Forms.ListBox listBox_PositionList;
        private System.Windows.Forms.GroupBox groupBox_MoveToPosition;
        private System.Windows.Forms.Button button_JointsMove;
        private System.Windows.Forms.TextBox textBox_MoveToJoints;
        private System.Windows.Forms.Button button_PositionMove;
        private System.Windows.Forms.TextBox textBox_MoveToPosition;
        private System.Windows.Forms.Button button_InsertGripperClose;
        private System.Windows.Forms.Button button_InsertGripperOpen;
    }
}

