// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DiscribeSmartAccessGatewayDiagnosisReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The diagnosis report of the Smart Access Gateway device.</para>
        /// </summary>
        [NameInMap("DiagnoseResult")]
        [Validation(Required=false)]
        public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResult DiagnoseResult { get; set; }
        public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResult : TeaModel {
            /// <summary>
            /// <para>The type of the Smart Access Gateway device.</para>
            /// <list type="bullet">
            /// <item><description><b>sag-1000</b></description></item>
            /// <item><description><b>sag-100WM</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sag-1000</para>
            /// </summary>
            [NameInMap("BoxType")]
            [Validation(Required=false)]
            public string BoxType { get; set; }

            /// <summary>
            /// <para>The software version that runs on the Smart Access Gateway device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.1.0</para>
            /// </summary>
            [NameInMap("BoxVersion")]
            [Validation(Required=false)]
            public string BoxVersion { get; set; }

            /// <summary>
            /// <para>The list of diagnosis results.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetails> Details { get; set; }
            public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetails : TeaModel {
                /// <summary>
                /// <para>The list of detailed information about diagnosis items.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItems> Items { get; set; }
                public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItems : TeaModel {
                    /// <summary>
                    /// <para>The diagnosis result in Chinese.</para>
                    /// </summary>
                    [NameInMap("CN")]
                    [Validation(Required=false)]
                    public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItemsCN CN { get; set; }
                    public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItemsCN : TeaModel {
                        /// <summary>
                        /// <para>The diagnosis suggestion.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Check the leased-line port link wiring first, and then go to the local Leased Line Management page for configuration.</para>
                        /// </summary>
                        [NameInMap("Advice")]
                        [Validation(Required=false)]
                        public List<string> Advice { get; set; }

                        /// <summary>
                        /// <para>The diagnosis result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>All leased-line ports have link anomalies or missing port IPs: Port 4.</para>
                        /// </summary>
                        [NameInMap("Details")]
                        [Validation(Required=false)]
                        public List<string> Details { get; set; }

                        /// <summary>
                        /// <para>The severity level of the diagnosis result for the diagnosis item.</para>
                        /// <list type="bullet">
                        /// <item><description><b>严重</b> (Critical): indicates that the issue of the diagnosis item may affect service running. We recommend that you handle the issue at the earliest opportunity.</description></item>
                        /// <item><description><b>警告</b> (Warning): indicates that the diagnosis item has an issue. Handle the issue based on the suggestion.</description></item>
                        /// <item><description><b>正常</b> (Normal): indicates that the diagnosis item is running as expected. No action is required.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Normal</para>
                        /// </summary>
                        [NameInMap("ItemLevel")]
                        [Validation(Required=false)]
                        public string ItemLevel { get; set; }

                        /// <summary>
                        /// <para>The name of the diagnosis item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Leased line port configuration check</para>
                        /// </summary>
                        [NameInMap("ItemName")]
                        [Validation(Required=false)]
                        public string ItemName { get; set; }

                        /// <summary>
                        /// <para>The diagnosis type to which the diagnosis item belongs.</para>
                        /// <list type="bullet">
                        /// <item><description><b>配置</b> (Configuration): indicates the <b>SAG configuration</b> type.</description></item>
                        /// <item><description><b>业务</b> (Service): indicates the <b>service quality</b> type.</description></item>
                        /// <item><description><b>公网</b> (Internet): indicates the <b>Internet quality</b> type.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Configuration</para>
                        /// </summary>
                        [NameInMap("ItemType")]
                        [Validation(Required=false)]
                        public string ItemType { get; set; }

                    }

                    /// <summary>
                    /// <para>The diagnosis result in English.</para>
                    /// </summary>
                    [NameInMap("EN")]
                    [Validation(Required=false)]
                    public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItemsEN EN { get; set; }
                    public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItemsEN : TeaModel {
                        /// <summary>
                        /// <para>The diagnosis suggestion.</para>
                        /// </summary>
                        [NameInMap("Advice")]
                        [Validation(Required=false)]
                        public List<string> Advice { get; set; }

                        /// <summary>
                        /// <para>The diagnosis result.</para>
                        /// </summary>
                        [NameInMap("Details")]
                        [Validation(Required=false)]
                        public List<string> Details { get; set; }

                        /// <summary>
                        /// <para>The severity level of the diagnosis result for the diagnosis item.</para>
                        /// <list type="bullet">
                        /// <item><description><b>ERROR</b>: indicates that the issue of the diagnosis item may affect service running. We recommend that you handle the issue at the earliest opportunity.</description></item>
                        /// <item><description><b>WARNING</b>: indicates that the diagnosis item has an issue. Handle the issue based on the suggestion.</description></item>
                        /// <item><description><b>INFO</b>: indicates that the diagnosis item is running as expected. No action is required.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ERROR</para>
                        /// </summary>
                        [NameInMap("ItemLevel")]
                        [Validation(Required=false)]
                        public string ItemLevel { get; set; }

                        /// <summary>
                        /// <para>The name of the diagnosis item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Express Connect Port Configuration</para>
                        /// </summary>
                        [NameInMap("ItemName")]
                        [Validation(Required=false)]
                        public string ItemName { get; set; }

                        /// <summary>
                        /// <para>The diagnosis type to which the diagnosis item belongs.</para>
                        /// <list type="bullet">
                        /// <item><description><b>Config</b>: indicates the <b>SAG configuration</b> type.</description></item>
                        /// <item><description><b>Service</b>: indicates the <b>service quality</b> type.</description></item>
                        /// <item><description><b>Internet</b>: indicates the <b>Internet quality</b> type.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Config</para>
                        /// </summary>
                        [NameInMap("ItemType")]
                        [Validation(Required=false)]
                        public string ItemType { get; set; }

                    }

                    /// <summary>
                    /// <para>The timestamp when the diagnosis of the diagnosis item ended.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1602741570596</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The name of the diagnosis item, which is the unique identifier of the diagnosis item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eccConfigCheck</para>
                    /// </summary>
                    [NameInMap("ItemName")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    /// <summary>
                    /// <para>The severity level of the diagnosis result for the diagnosis item.</para>
                    /// <list type="bullet">
                    /// <item><description><b>error</b>: Critical.</description></item>
                    /// <item><description><b>warning</b>: Warning.</description></item>
                    /// <item><description><b>info</b>: Normal.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>error</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>The timestamp when the diagnosis of the diagnosis item started.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1602741570567</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <para>The diagnosis type to which the diagnosis item belongs.</para>
                    /// <list type="bullet">
                    /// <item><description><b>config</b>: SAG configuration.</description></item>
                    /// <item><description><b>internet</b>: Internet quality.</description></item>
                    /// <item><description><b>biz</b>: Service quality.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>config</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The statistics on the severity levels of diagnosis items under the current diagnosis type.</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsStatistics Statistics { get; set; }
                public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsStatistics : TeaModel {
                    /// <summary>
                    /// <para>The number of diagnosis items with the <b>Error</b> severity level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Error")]
                    [Validation(Required=false)]
                    public int? Error { get; set; }

                    /// <summary>
                    /// <para>The number of diagnosis items with the <b>Info</b> severity level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public int? Info { get; set; }

                    /// <summary>
                    /// <para>The total number of diagnosis items under the current diagnosis type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                    /// <summary>
                    /// <para>The number of diagnosis items with the <b>Warning</b> severity level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Warning")]
                    [Validation(Required=false)]
                    public int? Warning { get; set; }

                }

                /// <summary>
                /// <para>The diagnosis type.</para>
                /// <list type="bullet">
                /// <item><description><b>config</b>: SAG configuration.</description></item>
                /// <item><description><b>internet</b>: Internet quality.</description></item>
                /// <item><description><b>biz</b>: Service quality.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>config</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The diagnosis ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dia-sag42c3t703trh02olv5rf****</para>
            /// </summary>
            [NameInMap("DiagnoseId")]
            [Validation(Required=false)]
            public string DiagnoseId { get; set; }

            /// <summary>
            /// <para>The timestamp when the diagnosis ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160274157</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            /// <summary>
            /// <para>The number of completed diagnosis items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("FinishedNumber")]
            [Validation(Required=false)]
            public int? FinishedNumber { get; set; }

            /// <summary>
            /// <para>The ID of the Smart Access Gateway instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag-0nnteglltw6z4b***</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The diagnosis result level.</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultLevel Level { get; set; }
            public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultLevel : TeaModel {
                /// <summary>
                /// <para>The diagnosis result level for service quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>warning</para>
                /// </summary>
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public string Biz { get; set; }

                /// <summary>
                /// <para>The diagnosis result level for SAG configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>info</para>
                /// </summary>
                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public string Configuration { get; set; }

                /// <summary>
                /// <para>The overall diagnosis result level.</para>
                /// <list type="bullet">
                /// <item><description><b>error</b>: Critical.</description></item>
                /// <item><description><b>warning</b>: Warning.</description></item>
                /// <item><description><b>info</b>: Normal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>error</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public string Total { get; set; }

            }

            /// <summary>
            /// <para>The monitoring version used by the Smart Access Gateway device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.2.9</para>
            /// </summary>
            [NameInMap("MonitorVersion")]
            [Validation(Required=false)]
            public string MonitorVersion { get; set; }

            /// <summary>
            /// <para>The completion percentage of the diagnosis report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            /// <summary>
            /// <para>The status of uploading the diagnosis report to SLS.</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The upload failed.</description></item>
            /// <item><description><b>1</b>: The upload was successful.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReportSLSSuccess")]
            [Validation(Required=false)]
            public int? ReportSLSSuccess { get; set; }

            /// <summary>
            /// <para>The serial number of the Smart Access Gateway device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag42c3****</para>
            /// </summary>
            [NameInMap("SN")]
            [Validation(Required=false)]
            public string SN { get; set; }

            /// <summary>
            /// <para>The timestamp when the diagnosis started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160274157</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            /// <summary>
            /// <para>The diagnosis state.</para>
            /// <list type="bullet">
            /// <item><description><b>processing</b>: The diagnosis is in progress.</description></item>
            /// <item><description><b>finished</b>: The diagnosis is successful.</description></item>
            /// <item><description><b>failed</b>: The diagnosis failed.</description></item>
            /// <item><description><b>error</b>: An error occurred during the diagnosis.</description></item>
            /// <item><description><b>upload_to_sls_fail</b>: The diagnosis report failed to be uploaded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The overall statistics of diagnosis item results.</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultStatistics Statistics { get; set; }
            public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultStatistics : TeaModel {
                /// <summary>
                /// <para>The total number of diagnosis items with the <b>Error</b> severity level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Error")]
                [Validation(Required=false)]
                public int? Error { get; set; }

                /// <summary>
                /// <para>The total number of diagnosis items with the <b>Info</b> severity level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Info")]
                [Validation(Required=false)]
                public int? Info { get; set; }

                /// <summary>
                /// <para>The total number of all diagnosis items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// <para>The total number of diagnosis items with the <b>Warning</b> severity level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Warning")]
                [Validation(Required=false)]
                public int? Warning { get; set; }

            }

            /// <summary>
            /// <para>The storage type.</para>
            /// <para>Value: <b>both</b>, which indicates that the diagnosis report is stored on both the Smart Access Gateway device and in Log Service (SLS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>both</para>
            /// </summary>
            [NameInMap("StoreType")]
            [Validation(Required=false)]
            public string StoreType { get; set; }

            /// <summary>
            /// <para>The total number of diagnosis result entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TotalNumber")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

            /// <summary>
            /// <para>The ID of the account to which the Smart Access Gateway instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1688000000000000</para>
            /// </summary>
            [NameInMap("UId")]
            [Validation(Required=false)]
            public string UId { get; set; }

            /// <summary>
            /// <para>The type of user who initiated the diagnosis. Value: <b>user</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("UserLevel")]
            [Validation(Required=false)]
            public string UserLevel { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7D6E3AB-D41A-42E3-8D4E-97B145F4B7C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
