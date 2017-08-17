using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;

{
	public class ItemNPTY
	{
		private string sqf, txt, zip;
		private string oldNS = "RO";
		private bool isNew = true;
		private List<List<string>> moduleDBs = new List<List<string>> {  new List<string>{"RODesign", "ROCmon"},new List<string>{"ROCmonD"} };

		{
			progress(0, "Copying client tier files ...");
			zip = "_0087_NPTY_RO.Client405.zip";
			Utils.ExtractBinRsc(zip, zip);
			Utils.JFileUnzip(zip, Application.StartupPath + @"\Temp");
			DirectoryInfo srcDi = new DirectoryInfo(Application.StartupPath + @"\Temp");
			Utils.ReplFileNS(Application.StartupPath + @"\Temp", TarPath, oldNS, newNS, moduleDBs[0], moduleDBs[1], isNew, srcDi);
			srcDi.Delete(true); Utils.DeleteFile(zip); progress(12,string.Empty);
			progress(0, "Copying web service tier files ...");
			zip = "_0087_NPTY_RO.Ws405.zip";
			Utils.ExtractBinRsc(zip, zip);
			Utils.JFileUnzip(zip, Application.StartupPath + @"\Temp");
			srcDi = new DirectoryInfo(Application.StartupPath + @"\Temp");
			Utils.ReplFileNS(Application.StartupPath + @"\Temp", WsPath, oldNS, newNS, moduleDBs[0], moduleDBs[1], isNew, srcDi);
			srcDi.Delete(true); Utils.DeleteFile(zip); progress(12,string.Empty);
			zip = "_0087_NPTY_RO.Xls405.zip";
			Utils.ExtractBinRsc(zip, zip);
			Utils.JFileUnzip(zip, Application.StartupPath + @"\Temp");
			srcDi = new DirectoryInfo(Application.StartupPath + @"\Temp");
			Utils.ReplFileNS(Application.StartupPath + @"\Temp", XlsPath, oldNS, newNS, moduleDBs[0], moduleDBs[1], isNew, srcDi);
			srcDi.Delete(true); Utils.DeleteFile(zip); progress(12,string.Empty);
		}

		{
			Utils.CreateDatabase("M", Svr, Usr, Pwd, newNS + "Design", dbPath, serverVer,encKey,AppUsr,AppPwd, bIntegratedSecurity);
			progress(0, "Creating " + newNS + "Design tables ...");
			sqf = "_0087_NPTY_RO.Server406.RODesignTable.sql";
			Utils.ExtractSqlRsc("M", sqf, oldNS, newNS, Svr, Usr, Pwd, newNS + "Design", moduleDBs[0], moduleDBs[1], isNew, encKey, bIntegratedSecurity);

			zip = "_0087_NPTY_RO.Server406.DataDesign.zip";
			Utils.ExtractBinRsc(zip, "DataDesign.zip");
			Utils.JFileUnzip(@"DataDesign.zip", @"DataDesign");
			txt = "_0087_NPTY_RO.Server406.RODesignSrcI.bat";
			Utils.ExtractTxtRsc("M", txt, oldNS, newNS, moduleDBs[0],moduleDBs[1], isNew, serverVer, bIntegratedSecurity);
			Utils.ExecuteCommand(txt, "\"" + Svr + "\" \"" + Usr + "\" \"" + Pwd + "\"", true);
			try { Directory.Delete("DataDesign",true);
			Utils.DeleteFile("DataDesign.zip"); } catch {}; Utils.DeleteFile(txt);

			sqf = "_0087_NPTY_RO.Server406.RODesignIndex.sql";
			Utils.ExtractSqlRsc("M", sqf, oldNS, newNS, Svr, Usr, Pwd, newNS + "Design", moduleDBs[0], moduleDBs[1], isNew, encKey, bIntegratedSecurity);

			sqf = "_0087_NPTY_RO.Server406.RODesignSp.sql";
			Utils.ExtractSqlRsc("M", sqf, oldNS, newNS, Svr, Usr, Pwd, newNS + "Design", moduleDBs[0], moduleDBs[1], isNew, encKey, bIntegratedSecurity);
			progress(12,string.Empty);
		}

		{
			progress(12,string.Empty);
		}

		{
			progress(0, "Copying rule tier files ...");
			zip = "_0087_NPTY_RO.Rule413.zip";
			Utils.ExtractBinRsc(zip, zip);
			Utils.JFileUnzip(zip, Application.StartupPath + @"\Temp");
			DirectoryInfo srcDi = new DirectoryInfo(Application.StartupPath + @"\Temp");
			Utils.ReplFileNS(Application.StartupPath + @"\Temp", TarPath, oldNS, newNS, moduleDBs[0], moduleDBs[1], isNew, srcDi);
			srcDi.Delete(true); Utils.DeleteFile(zip); progress(12,string.Empty);
		}

		{
			Utils.CreateDatabase("M", Svr, Usr, Pwd, newNS + "Cmon", dbPath, serverVer,encKey,AppUsr,AppPwd, bIntegratedSecurity);
			progress(0, "Creating " + newNS + "Cmon tables ...");
			sqf = "_0087_NPTY_RO.Server408.ROCmonTable.sql";
			Utils.ExtractSqlRsc("M", sqf, oldNS, newNS, Svr, Usr, Pwd, newNS + "Cmon", moduleDBs[0], moduleDBs[1], isNew, encKey, bIntegratedSecurity);

			zip = "_0087_NPTY_RO.Server408.DataCmon.zip";
			Utils.ExtractBinRsc(zip, "DataCmon.zip");
			Utils.JFileUnzip(@"DataCmon.zip", @"DataCmon");
			txt = "_0087_NPTY_RO.Server408.ROCmonSrcI.bat";
			Utils.ExtractTxtRsc("M", txt, oldNS, newNS, moduleDBs[0],moduleDBs[1], isNew, serverVer, bIntegratedSecurity);
			Utils.ExecuteCommand(txt, "\"" + Svr + "\" \"" + Usr + "\" \"" + Pwd + "\"", true);
			try { Directory.Delete("DataCmon",true);
			Utils.DeleteFile("DataCmon.zip"); } catch {}; Utils.DeleteFile(txt);

			sqf = "_0087_NPTY_RO.Server408.ROCmonIndex.sql";
			Utils.ExtractSqlRsc("M", sqf, oldNS, newNS, Svr, Usr, Pwd, newNS + "Cmon", moduleDBs[0], moduleDBs[1], isNew, encKey, bIntegratedSecurity);

			sqf = "_0087_NPTY_RO.Server408.ROCmonSp.sql";
			Utils.ExtractSqlRsc("M", sqf, oldNS, newNS, Svr, Usr, Pwd, newNS + "Cmon", moduleDBs[0], moduleDBs[1], isNew, encKey, bIntegratedSecurity);
			progress(12,string.Empty);
		}

		{
			progress(12,string.Empty);
		}

		{
			Utils.CreateDatabase("M", Svr, Usr, Pwd, newNS + "CmonD", dbPath, serverVer,encKey,AppUsr,AppPwd, bIntegratedSecurity);
			progress(0, "Creating " + newNS + "CmonD tables ...");
			sqf = "_0087_NPTY_RO.Server410.ROCmonDTable.sql";
			Utils.ExtractSqlRsc("M", sqf, oldNS, newNS, Svr, Usr, Pwd, newNS + "CmonD", moduleDBs[0], moduleDBs[1], isNew, encKey, bIntegratedSecurity);

			zip = "_0087_NPTY_RO.Server410.DataCmonD.zip";
			Utils.ExtractBinRsc(zip, "DataCmonD.zip");
			Utils.JFileUnzip(@"DataCmonD.zip", @"DataCmonD");
			txt = "_0087_NPTY_RO.Server410.ROCmonDSrcI.bat";
			Utils.ExtractTxtRsc("M", txt, oldNS, newNS, moduleDBs[0],moduleDBs[1], isNew, serverVer, bIntegratedSecurity);
			Utils.ExecuteCommand(txt, "\"" + Svr + "\" \"" + Usr + "\" \"" + Pwd + "\"", true);
			try { Directory.Delete("DataCmonD",true);
			Utils.DeleteFile("DataCmonD.zip"); } catch {}; Utils.DeleteFile(txt);

			sqf = "_0087_NPTY_RO.Server410.ROCmonDIndex.sql";
			Utils.ExtractSqlRsc("M", sqf, oldNS, newNS, Svr, Usr, Pwd, newNS + "CmonD", moduleDBs[0], moduleDBs[1], isNew, encKey, bIntegratedSecurity);
			progress(0, "Upgrading all design database S.Procs ...");
			sqf = "_0087_NPTY_RO.Server410.ROCmonDSp.sql";
			DataView dv = new DataView(Utils.GetAppDb("M", Svr, Usr, Pwd, newNS + "Design", bIntegratedSecurity));
			foreach (DataRowView drv in dv)
			{
				Utils.ExtractSqlRsc("M", sqf, oldNS, newNS, Svr, Usr, Pwd, drv["dbDesDatabase"].ToString(), moduleDBs[0], moduleDBs[1], isNew, encKey, bIntegratedSecurity);
			}
			progress(12,string.Empty);
		}

		{
			progress(12,string.Empty);
		}

		{
			zip = "Version.Design.zip";
			Utils.ExtractBinRsc(zip, zip);
			Utils.JFileUnzip(zip, Application.StartupPath + @"\Temp");
			Utils.UpgradeServer(DbProvider, Svr, Usr, Pwd, newNS + "Design", Application.StartupPath + @"\Temp", newNS, bIntegratedSecurity);
			(new DirectoryInfo(Application.StartupPath + @"\Temp")).Delete(true); Utils.DeleteFile(zip);
		}

		{
			zip = "Version.CmonD.zip";
			Utils.ExtractBinRsc(zip, zip);
			Utils.JFileUnzip(zip, Application.StartupPath + @"\Temp");
			Utils.UpgradeServer(DbProvider, Svr, Usr, Pwd, newNS + "Cmon", Application.StartupPath + @"\Temp", newNS, bIntegratedSecurity);
			(new DirectoryInfo(Application.StartupPath + @"\Temp")).Delete(true); Utils.DeleteFile(zip);
		}
	}
}