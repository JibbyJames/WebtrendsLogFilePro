using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebtrendsLogFilePro;
using static WebtrendsLogFilePro.LogFileProForm;

namespace WebtrendsLogFileProTests
{
    [TestClass]
    public class WebtrendsLogFileProTests
    {
        public static string assetsFolderLocation = @"D:\Documents\GitHub\WebtrendsLogFilePro\WebtrendsLogFileProTests\assets";

        public static string smallLogFile = assetsFolderLocation +  @"\small-log-file.log";
        public static string mediumLogFile = assetsFolderLocation + @"\medium-log-file.log";
        public static string bigLogFile = assetsFolderLocation + @"\big-log-file.log";
        public static string hugeLogFile = assetsFolderLocation + @"\huge-log-file.log";

        public static LogFileProForm logFileProForm;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            logFileProForm = new LogFileProForm();
        }

        [TestMethod]
        public void RunSingleScanOnSmallLogFile()
        {
            var result = logFileProForm.FindQueryParams(FindQueryParamsSpeed.Single, smallLogFile);
        }

        [TestMethod]
        public void RunSingleScanOnMediumLogFile()
        {
            var result = logFileProForm.FindQueryParams(FindQueryParamsSpeed.Single, mediumLogFile);
        }

        [TestMethod]
        public void RunSingleScanOnBigLogFile()
        {
            var result = logFileProForm.FindQueryParams(FindQueryParamsSpeed.Single, bigLogFile);
        }

        [TestMethod]
        public void RunSingleScanOnHugeLogFile()
        {
            var result = logFileProForm.FindQueryParams(FindQueryParamsSpeed.Single, hugeLogFile);
        }

        [TestMethod]
        public void RunQuickScanOnSmallLogFile()
        {
            var result = logFileProForm.FindQueryParams(FindQueryParamsSpeed.Quick, smallLogFile);
        }

        [TestMethod]
        public void RunQuickScanOnMediumLogFile()
        {
            var result = logFileProForm.FindQueryParams(FindQueryParamsSpeed.Quick, mediumLogFile);
        }

        [TestMethod]
        public void RunQuickScanOnBigLogFile()
        {
            var result = logFileProForm.FindQueryParams(FindQueryParamsSpeed.Quick, bigLogFile);
        }

        [TestMethod]
        public void RunQuickScanOnHugeLogFile()
        {
            var result = logFileProForm.FindQueryParams(FindQueryParamsSpeed.Quick, hugeLogFile);
        }

        [TestMethod]
        public void RunFullScanOnSmallLogFile()
        {
            var result = logFileProForm.FindQueryParams(FindQueryParamsSpeed.Full, smallLogFile);
        }

        [TestMethod]
        public void RunFullScanOnMediumLogFile()
        {
            var result = logFileProForm.FindQueryParams(FindQueryParamsSpeed.Full, mediumLogFile);
        }

        [TestMethod]
        public void RunFullScanOnBigLogFile()
        {
            var result = logFileProForm.FindQueryParams(FindQueryParamsSpeed.Full, bigLogFile);
        }

        [TestMethod]
        public void RunFullScanOnHugeLogFile()
        {
            var result = logFileProForm.FindQueryParams(FindQueryParamsSpeed.Full, hugeLogFile);
        }
    }
}
