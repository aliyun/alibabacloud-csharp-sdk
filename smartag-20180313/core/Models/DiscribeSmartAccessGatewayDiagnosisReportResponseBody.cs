// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DiscribeSmartAccessGatewayDiagnosisReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The diagnosis report of the SAG device.</para>
        /// </summary>
        [NameInMap("DiagnoseResult")]
        [Validation(Required=false)]
        public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResult DiagnoseResult { get; set; }
        public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResult : TeaModel {
            /// <summary>
            /// <para>The model of the SAG device.</para>
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
            /// <para>The version of the SAG device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.1.0</para>
            /// </summary>
            [NameInMap("BoxVersion")]
            [Validation(Required=false)]
            public string BoxVersion { get; set; }

            /// <summary>
            /// <para>The list of diagnoses that are returned.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetails> Details { get; set; }
            public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetails : TeaModel {
                /// <summary>
                /// <para>The list of items diagnosed.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItems> Items { get; set; }
                public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItems : TeaModel {
                    /// <summary>
                    /// <para>The diagnosis report in Chinese.</para>
                    /// </summary>
                    [NameInMap("CN")]
                    [Validation(Required=false)]
                    public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItemsCN CN { get; set; }
                    public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItemsCN : TeaModel {
                        /// <summary>
                        /// <para>The suggestion for the diagnosis.</para>
                        /// </summary>
                        [NameInMap("Advice")]
                        [Validation(Required=false)]
                        public List<string> Advice { get; set; }

                        /// <summary>
                        /// <para>The diagnosis.</para>
                        /// </summary>
                        [NameInMap("Details")]
                        [Validation(Required=false)]
                        public List<string> Details { get; set; }

                        /// <summary>
                        /// <para>The diagnosis level of the item. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>ERROR</b>: indicates that the item has an issue that may affect your services. We recommend that you handle the issue at the earliest opportunity.</description></item>
                        /// <item><description><b>WARNING</b>: indicates that the item has an issue. You can handle the issue based on your business requirements.</description></item>
                        /// <item><description><b>INFO</b>: indicates that the item is working as expected. No additional operation is required.</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("ItemLevel")]
                        [Validation(Required=false)]
                        public string ItemLevel { get; set; }

                        /// <summary>
                        /// <para>The name of the item.</para>
                        /// </summary>
                        [NameInMap("ItemName")]
                        [Validation(Required=false)]
                        public string ItemName { get; set; }

                        /// <summary>
                        /// <para>The type of the item. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Config</b>: <b>SAG configuration</b></description></item>
                        /// <item><description><b>Service</b>: <b>service quality</b></description></item>
                        /// <item><description><b>Internet</b>: <b>quality of connections to the Internet</b></description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("ItemType")]
                        [Validation(Required=false)]
                        public string ItemType { get; set; }

                    }

                    /// <summary>
                    /// <para>The diagnosis report in English.</para>
                    /// </summary>
                    [NameInMap("EN")]
                    [Validation(Required=false)]
                    public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItemsEN EN { get; set; }
                    public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsItemsEN : TeaModel {
                        /// <summary>
                        /// <para>The suggestion for the diagnosis.</para>
                        /// </summary>
                        [NameInMap("Advice")]
                        [Validation(Required=false)]
                        public List<string> Advice { get; set; }

                        /// <summary>
                        /// <para>The diagnosis.</para>
                        /// </summary>
                        [NameInMap("Details")]
                        [Validation(Required=false)]
                        public List<string> Details { get; set; }

                        /// <summary>
                        /// <para>The diagnosis level of the item. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>ERROR</b>: indicates that the item has an issue that may affect your services. We recommend that you handle the issue at the earliest opportunity.</description></item>
                        /// <item><description><b>WARNING</b>: indicates that the item has an issue. You can handle the issue based on your business requirements.</description></item>
                        /// <item><description><b>INFO</b>: indicates that the item is working as expected. No additional operation is required.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ERROR</para>
                        /// </summary>
                        [NameInMap("ItemLevel")]
                        [Validation(Required=false)]
                        public string ItemLevel { get; set; }

                        /// <summary>
                        /// <para>The name of the item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Express Connect Port Configuration</para>
                        /// </summary>
                        [NameInMap("ItemName")]
                        [Validation(Required=false)]
                        public string ItemName { get; set; }

                        /// <summary>
                        /// <para>The type of the item. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Config</b>: <b>SAG configuration</b></description></item>
                        /// <item><description><b>Service</b>: <b>service quality</b></description></item>
                        /// <item><description><b>Internet</b>: <b>quality of connections to the Internet</b></description></item>
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
                    /// <para>The timestamp when the system finishes diagnosing the item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1602741570596</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The name of the item, which is the unique identifier of the item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eccConfigCheck</para>
                    /// </summary>
                    [NameInMap("ItemName")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    /// <summary>
                    /// <para>The diagnosis level of the item. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>error</b>: severe</description></item>
                    /// <item><description><b>warning</b>: warning</description></item>
                    /// <item><description><b>info</b>: normal</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>error</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>The timestamp when the system starts to diagnose the item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1602741570567</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <para>The type of the item. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>config</b>: SAG configuration</description></item>
                    /// <item><description><b>internet</b>: quality of connections to the Internet</description></item>
                    /// <item><description><b>biz</b>: service quality</description></item>
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
                /// <para>The information about items of each diagnosis level for the current diagnosis type.</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsStatistics Statistics { get; set; }
                public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultDetailsStatistics : TeaModel {
                    /// <summary>
                    /// <para>The number of items of the <b>ERROR</b> level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Error")]
                    [Validation(Required=false)]
                    public int? Error { get; set; }

                    /// <summary>
                    /// <para>The number of items of the <b>INFO</b> level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public int? Info { get; set; }

                    /// <summary>
                    /// <para>The total number of items for the current diagnosis type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                    /// <summary>
                    /// <para>The number of items of the <b>WARNING</b> level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Warning")]
                    [Validation(Required=false)]
                    public int? Warning { get; set; }

                }

                /// <summary>
                /// <para>The type of the diagnosis. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>config</b>: SAG configuration</description></item>
                /// <item><description><b>internet</b>: quality of connections to the Internet</description></item>
                /// <item><description><b>biz</b>: service quality</description></item>
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
            /// <para>The ID of the diagnosis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dia-sag42c3t703trh02olv5rf****</para>
            /// </summary>
            [NameInMap("DiagnoseId")]
            [Validation(Required=false)]
            public string DiagnoseId { get; set; }

            /// <summary>
            /// <para>The timestamp when the system finishes diagnosing the item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160274157</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            /// <summary>
            /// <para>The number of items that are diagnosed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("FinishedNumber")]
            [Validation(Required=false)]
            public int? FinishedNumber { get; set; }

            /// <summary>
            /// <para>The ID of the SAG instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag-0nnteglltw6z4b***</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The diagnosis level.</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultLevel Level { get; set; }
            public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultLevel : TeaModel {
                /// <summary>
                /// <para>The diagnosis level of the service quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>warning</para>
                /// </summary>
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public string Biz { get; set; }

                /// <summary>
                /// <para>The diagnosis level of the SAG configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>info</para>
                /// </summary>
                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public string Configuration { get; set; }

                /// <summary>
                /// <para>The overall diagnosis level.</para>
                /// <list type="bullet">
                /// <item><description><b>error</b>: severe</description></item>
                /// <item><description><b>warning</b>: warning</description></item>
                /// <item><description><b>info</b>: normal</description></item>
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
            /// <para>The version of the monitoring feature that is used by the SAG device.</para>
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
            /// <para>The status of the diagnosis report to be uploaded to Log Service.</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The system failed to upload the report.</description></item>
            /// <item><description><b>1</b>: The system has uploaded the report to Log Service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReportSLSSuccess")]
            [Validation(Required=false)]
            public int? ReportSLSSuccess { get; set; }

            /// <summary>
            /// <para>The serial number of the SAG device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag42c3****</para>
            /// </summary>
            [NameInMap("SN")]
            [Validation(Required=false)]
            public string SN { get; set; }

            /// <summary>
            /// <para>The timestamp when the system starts to diagnose the item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160274157</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            /// <summary>
            /// <para>The diagnosis status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>processing</b>: The SAG device is being diagnosed.</description></item>
            /// <item><description><b>finished</b>: The SAG device is diagnosed.</description></item>
            /// <item><description><b>failed</b>: The system failed to diagnose the SAG device.</description></item>
            /// <item><description><b>error</b>: A diagnostic error occurred.</description></item>
            /// <item><description><b>upload_to_sls_fail</b>: The system failed to upload the diagnosis report.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The overall diagnosis level.</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultStatistics Statistics { get; set; }
            public class DiscribeSmartAccessGatewayDiagnosisReportResponseBodyDiagnoseResultStatistics : TeaModel {
                /// <summary>
                /// <para>The number of items of the <b>ERROR</b> level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Error")]
                [Validation(Required=false)]
                public int? Error { get; set; }

                /// <summary>
                /// <para>The number of items of the <b>INFO</b> level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Info")]
                [Validation(Required=false)]
                public int? Info { get; set; }

                /// <summary>
                /// <para>The total number of items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// <para>The number of items of the <b>WARNING</b> level.</para>
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
            /// <para>The value is set to <b>both</b>, which indicates that the data is stored in the SAG device and Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>both</para>
            /// </summary>
            [NameInMap("StoreType")]
            [Validation(Required=false)]
            public string StoreType { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TotalNumber")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

            /// <summary>
            /// <para>The user ID (UID) of the Alibaba Cloud account to which the SAG instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1688000000000000</para>
            /// </summary>
            [NameInMap("UId")]
            [Validation(Required=false)]
            public string UId { get; set; }

            /// <summary>
            /// <para>The type of user that initiated the diagnostics. The value is set to <b>user</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("UserLevel")]
            [Validation(Required=false)]
            public string UserLevel { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7D6E3AB-D41A-42E3-8D4E-97B145F4B7C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
