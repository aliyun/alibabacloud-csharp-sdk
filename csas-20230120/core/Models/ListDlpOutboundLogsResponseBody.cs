// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDlpOutboundLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The log objects.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<ListDlpOutboundLogsResponseBodyLogs> Logs { get; set; }
        public class ListDlpOutboundLogsResponseBodyLogs : TeaModel {
            /// <summary>
            /// <para>The file category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Document</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The primary channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The primary channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Web Upload</para>
            /// </summary>
            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// <para>The department.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D Department</para>
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <para>The local path of the file on the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\Users\a\Desktop\x.xlsx</para>
            /// </summary>
            [NameInMap("DevFilePath")]
            [Validation(Required=false)]
            public string DevFilePath { get; set; }

            /// <summary>
            /// <para>The unique identifier of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69FFB8EB-3E5E-5F11-A9D3-59ED8CBB345D</para>
            /// </summary>
            [NameInMap("DeviceTag")]
            [Validation(Required=false)]
            public string DeviceTag { get; set; }

            /// <summary>
            /// <para>The device type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>The storage policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("DlpStorageConfigId")]
            [Validation(Required=false)]
            public string DlpStorageConfigId { get; set; }

            /// <summary>
            /// <para>The storage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("DlpStorageType")]
            [Validation(Required=false)]
            public string DlpStorageType { get; set; }

            /// <summary>
            /// <para>The outbound destination address or URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://mail.example.com">https://mail.example.com</a></para>
            /// </summary>
            [NameInMap("DstAddr")]
            [Validation(Required=false)]
            public string DstAddr { get; set; }

            /// <summary>
            /// <para>The file source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>download</para>
            /// </summary>
            [NameInMap("FileOrigin")]
            [Validation(Required=false)]
            public string FileOrigin { get; set; }

            /// <summary>
            /// <para>The host of the file source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drive.example.com</para>
            /// </summary>
            [NameInMap("FileOriginHost")]
            [Validation(Required=false)]
            public string FileOriginHost { get; set; }

            /// <summary>
            /// <para>The referrer of the file source.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://drive.example.com/">https://drive.example.com/</a></para>
            /// </summary>
            [NameInMap("FileOriginReferrer")]
            [Validation(Required=false)]
            public string FileOriginReferrer { get; set; }

            /// <summary>
            /// <para>The file content preview snippet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>preview</para>
            /// </summary>
            [NameInMap("FilePreview")]
            [Validation(Required=false)]
            public string FilePreview { get; set; }

            /// <summary>
            /// <para>The file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xlsx</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The organizational structure path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D Center-Data Platform Team</para>
            /// </summary>
            [NameInMap("GroupInfo")]
            [Validation(Required=false)]
            public string GroupInfo { get; set; }

            /// <summary>
            /// <para>The hostname of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MacBook-Pro</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>LogId</para>
            /// 
            /// <b>Example:</b>
            /// <para>da817m4mfrcs6xxxx3hg</para>
            /// </summary>
            [NameInMap("LogId")]
            [Validation(Required=false)]
            public string LogId { get; set; }

            /// <summary>
            /// <para>The matched dictionary statistics.</para>
            /// </summary>
            [NameInMap("MatchedDicts")]
            [Validation(Required=false)]
            public ListDlpOutboundLogsResponseBodyLogsMatchedDicts MatchedDicts { get; set; }
            public class ListDlpOutboundLogsResponseBodyLogsMatchedDicts : TeaModel {
                /// <summary>
                /// <para>The matched built-in dictionaries.</para>
                /// </summary>
                [NameInMap("InnerDicts")]
                [Validation(Required=false)]
                public List<ListDlpOutboundLogsResponseBodyLogsMatchedDictsInnerDicts> InnerDicts { get; set; }
                public class ListDlpOutboundLogsResponseBodyLogsMatchedDictsInnerDicts : TeaModel {
                    /// <summary>
                    /// <para>The number of matches.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The dictionary name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Identify Number</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The matched keywords.</para>
                /// </summary>
                [NameInMap("Keywords")]
                [Validation(Required=false)]
                public List<ListDlpOutboundLogsResponseBodyLogsMatchedDictsKeywords> Keywords { get; set; }
                public class ListDlpOutboundLogsResponseBodyLogsMatchedDictsKeywords : TeaModel {
                    /// <summary>
                    /// <para>The number of matches.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The keyword name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Report</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The matched built-in dictionaries.</para>
                /// </summary>
                [NameInMap("UserDicts")]
                [Validation(Required=false)]
                public List<ListDlpOutboundLogsResponseBodyLogsMatchedDictsUserDicts> UserDicts { get; set; }
                public class ListDlpOutboundLogsResponseBodyLogsMatchedDictsUserDicts : TeaModel {
                    /// <summary>
                    /// <para>The number of matches.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The dictionary name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Work Number</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of matched policy details.</para>
            /// </summary>
            [NameInMap("MatchedPolicies")]
            [Validation(Required=false)]
            public List<ListDlpOutboundLogsResponseBodyLogsMatchedPolicies> MatchedPolicies { get; set; }
            public class ListDlpOutboundLogsResponseBodyLogsMatchedPolicies : TeaModel {
                /// <summary>
                /// <para>The corresponding data level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>L3</para>
                /// </summary>
                [NameInMap("EngineDataLevel")]
                [Validation(Required=false)]
                public string EngineDataLevel { get; set; }

                /// <summary>
                /// <para>The corresponding data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Company Data</para>
                /// </summary>
                [NameInMap("EngineDataType")]
                [Validation(Required=false)]
                public string EngineDataType { get; set; }

                /// <summary>
                /// <para>The matched detection rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ID No</para>
                /// </summary>
                [NameInMap("EngineName")]
                [Validation(Required=false)]
                public string EngineName { get; set; }

                /// <summary>
                /// <para>The policy description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gitlab-tag-policy</para>
                /// </summary>
                [NameInMap("PolicyDesc")]
                [Validation(Required=false)]
                public string PolicyDesc { get; set; }

                /// <summary>
                /// <para>The matched policy name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

            }

            /// <summary>
            /// <para>The object path of the sensitive file in the storage bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dlp/2026/08/10/xxx.xlsx</para>
            /// </summary>
            [NameInMap("OssFileName")]
            [Validation(Required=false)]
            public string OssFileName { get; set; }

            /// <summary>
            /// <para>The policy action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>block_and_hint</para>
            /// </summary>
            [NameInMap("PolicyAction")]
            [Validation(Required=false)]
            public string PolicyAction { get; set; }

            /// <summary>
            /// <para>The list of matched policy names.</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public List<string> PolicyName { get; set; }

            /// <summary>
            /// <para>The outbound process name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chrome.exe</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The secondary channel description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WeCom-FileSend</para>
            /// </summary>
            [NameInMap("ProcessNameDesc")]
            [Validation(Required=false)]
            public string ProcessNameDesc { get; set; }

            /// <summary>
            /// <para>The risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The matched risk scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The storage path of the screenshot file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dlp/screen/xxx.png</para>
            /// </summary>
            [NameInMap("ScreenFilePath")]
            [Validation(Required=false)]
            public string ScreenFilePath { get; set; }

            /// <summary>
            /// <para>The file size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1048576</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>The original file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026Q2FinancialReport.xlsx</para>
            /// </summary>
            [NameInMap("SrcFileName")]
            [Validation(Required=false)]
            public string SrcFileName { get; set; }

            /// <summary>
            /// <para>The source IP address of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.5</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            /// <summary>
            /// <para>The time when the event occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-10 14:03:22</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The time when the log was reported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-10 14:03:25</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9350F06D-80FB-5B8B-983A-0E25CBD08479</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public int? TotalNumber { get; set; }

    }

}
