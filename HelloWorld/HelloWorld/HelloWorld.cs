diff --git a/HelloWorld/HelloWorld/App.config b/HelloWorld/HelloWorld/App.config
deleted file mode 100644
index 88fa402..0000000
--- a/HelloWorld/HelloWorld/App.config
+++ /dev/null
@@ -1,6 +0,0 @@
-﻿<?xml version="1.0" encoding="utf-8" ?>
-<configuration>
-    <startup> 
-        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5.2" />
-    </startup>
-</configuration>
\ No newline at end of file
diff --git a/HelloWorld/HelloWorld/HelloWorld.Designer.cs b/HelloWorld/HelloWorld/Form1.Designer.cs
similarity index 99%
rename from HelloWorld/HelloWorld/HelloWorld.Designer.cs
rename to HelloWorld/HelloWorld/Form1.Designer.cs
index e28f1f3..8f08a82 100644
--- a/HelloWorld/HelloWorld/HelloWorld.Designer.cs
+++ b/HelloWorld/HelloWorld/Form1.Designer.cs
@@ -1,6 +1,6 @@
 ﻿namespace helloworld
 {
-    partial class HelloWorld
+    partial class Form1
     {
         /// <summary>
         /// Required designer variable.
diff --git a/HelloWorld/HelloWorld/HelloWorld.resx b/HelloWorld/HelloWorld/Form1.resx
similarity index 100%
rename from HelloWorld/HelloWorld/HelloWorld.resx
rename to HelloWorld/HelloWorld/Form1.resx
diff --git a/HelloWorld/HelloWorld/HelloWorld.cs b/HelloWorld/HelloWorld/HelloWorld.cs
deleted file mode 100644
index 19b1318..0000000
--- a/HelloWorld/HelloWorld/HelloWorld.cs
+++ /dev/null
@@ -1,55 +0,0 @@
-﻿using System;
-using System.Collections.Generic;
-using System.ComponentModel;
-using System.Data;
-using System.Drawing;
-using System.Linq;
-using System.Text;
-using System.Threading.Tasks;
-using System.Windows.Forms;
-
-namespace helloworld
-{
-    public partial class HelloWorld : Form
-    {
-        public HelloWorld()
-        {
-            InitializeComponent();
-        }
-
-        private void button1_Click(object sender, EventArgs e)
-        {
-            MessageBox.Show("Hello World", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
-        }
-
-        private void Form1_Load(object sender, EventArgs e)
-        {
-
-        }
-
-        private void button2_Click(object sender, EventArgs e)
-        {
-
-        }
-
-        private void button1_Click_1(object sender, EventArgs e)
-        {
-
-        }
-
-        private void label1_Click(object sender, EventArgs e)
-        {
-
-        }
-
-        private void button1_Click_2(object sender, EventArgs e)
-        {
-            MessageBox.Show("Hello : " + textBox1.Text);
-        }
-
-        private void textBox1_TextChanged(object sender, EventArgs e)
-        {
-
-        }
-    }
-}
diff --git a/HelloWorld/HelloWorld/Program.cs b/HelloWorld/HelloWorld/Program.cs
index 768b6b8..972e6cd 100644
--- a/HelloWorld/HelloWorld/Program.cs
+++ b/HelloWorld/HelloWorld/Program.cs
@@ -16,7 +16,7 @@ namespace helloworld
         {
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
-            Application.Run(new HelloWorld());
+            Application.Run(new Form1());
         }
     }
 }
diff --git a/HelloWorld/HelloWorld/helloworld.csproj b/HelloWorld/HelloWorld/helloworld.csproj
index a6fbe5e..3840832 100644
--- a/HelloWorld/HelloWorld/helloworld.csproj
+++ b/HelloWorld/HelloWorld/helloworld.csproj
@@ -46,16 +46,16 @@
     <Reference Include="System.Xml" />
   </ItemGroup>
   <ItemGroup>
-    <Compile Include="HelloWorld.cs">
+    <Compile Include="Form1.cs">
       <SubType>Form</SubType>
     </Compile>
-    <Compile Include="HelloWorld.Designer.cs">
-      <DependentUpon>HelloWorld.cs</DependentUpon>
+    <Compile Include="Form1.Designer.cs">
+      <DependentUpon>Form1.cs</DependentUpon>
     </Compile>
     <Compile Include="Program.cs" />
     <Compile Include="Properties\AssemblyInfo.cs" />
-    <EmbeddedResource Include="HelloWorld.resx">
-      <DependentUpon>HelloWorld.cs</DependentUpon>
+    <EmbeddedResource Include="Form1.resx">
+      <DependentUpon>Form1.cs</DependentUpon>
     </EmbeddedResource>
     <EmbeddedResource Include="Properties\Resources.resx">
       <Generator>ResXFileCodeGenerator</Generator>
diff --git a/HelloWorld/vinayasolutions.sln b/HelloWorld/vinayasolutions.sln
index 3d2f961..472d4ea 100644
--- a/HelloWorld/vinayasolutions.sln
+++ b/HelloWorld/vinayasolutions.sln
@@ -3,7 +3,7 @@ Microsoft Visual Studio Solution File, Format Version 12.00
 # Visual Studio 14
 VisualStudioVersion = 14.0.25420.1
 MinimumVisualStudioVersion = 10.0.40219.1
-Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "HelloWorld", "helloworld\HelloWorld.csproj", "{E7DF63E7-1569-4D3E-AD8B-F8170B4C9D5F}"
+Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "helloworld", "helloworld\helloworld.csproj", "{E7DF63E7-1569-4D3E-AD8B-F8170B4C9D5F}"
 EndProject
 Global
 	GlobalSection(SolutionConfigurationPlatforms) = preSolution
