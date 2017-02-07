using System;
using System.Reflection;
using System.Windows.Forms;

namespace WebtrendsLogFilePro
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.labelProductName.Text = String.Format("{0} v{1}", AssemblyTitle, AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;

            string howTo =
                "" + System.Environment.NewLine
                + "What is WebtrendsLogFilePro" + System.Environment.NewLine
                + "---------------------------------------------------------------------------------------------------------------------------------------------" + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "This tool is for when you have a standard Webtrends log file and wish to select certain fields and query parameters you want to view in a more readable format. It is useful for reducing the size of large log files into more manageable ones containing only the relevant fields/query parameters you are interested in." + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "How to Use WebtrendsLogFilePro" + System.Environment.NewLine
                + "---------------------------------------------------------------------------------------------------------------------------------------------" + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "1. Select either a directory containing compressed log files in gz formet or a single log file. The extraction requires that you have 7z.exe on your machine, and that the filepath shown in the UI is correct. The single log file chosen can be many smaller log files merged into on file, the additional header rows are removed during the parsing process." + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "2. If a directory is chosen, click \"Extract\" which will extract the files and create a single log file which will populate the \"Single Log File\" box. This process may take a while if the compressed log files are large in size. There was no way to show a progress bar for this unfortunately! " + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "3. Once a single log file is ready, click the \"Submit\" button, which will validate the log file, then load some basic statistics for the file. The rest of the UI will become activated at this point." + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "4. Select which fields you wish to include in your output file. You can expand the query parameters field and include/exclude certain query parameters too." + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "5. When the log file was first added, only the first row of query parameters was added to the list. To add more, either perform a \"Quick Scan\" (5% of file), \"Full Scan\" (entire file), or add the query parameters manually." + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "6. Once you have your fields selected, choose your output config options. The default save location is the same as the source log file, and the default name will be \"single-tab-file\". You can choose if you want the values to be URL decoded none/once/twice, and choose to wrap the values with quotation marks too." + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "7. Once your output config is set, click the \"Start\" button. This will begin the parsing process and the progress will be shown in the progress box." + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "8. Once the parsing job has finished, two buttons will appear to let you open the output file directly in Excel, or view the file in Explorer." + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "Reporting Bugs / Feature Requests" + System.Environment.NewLine
                + "---------------------------------------------------------------------------------------------------------------------------------------------" + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "Please email me: james.buckley@webtrends.com if you run into any bugs or would like to suggest a feature. I enjoyed making this little tool in my spare time and would like others to benefit from it as much as possible!" + System.Environment.NewLine
                + "" + System.Environment.NewLine
                + "";

            this.textBoxDescription.Text = howTo;

        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0) {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "") {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion {
            get {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
