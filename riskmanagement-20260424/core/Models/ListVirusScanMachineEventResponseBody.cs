// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class ListVirusScanMachineEventResponseBody : TeaModel {
        /// <summary>
        /// <para>code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVirusScanMachineEventResponseBodyData Data { get; set; }
        public class ListVirusScanMachineEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1E222AB5-5C2B-50AD-8A96-E704AF80F2A0</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The information about the latest virus scan task.</para>
            /// </summary>
            [NameInMap("VirusScanLatestTaskStatistic")]
            [Validation(Required=false)]
            public ListVirusScanMachineEventResponseBodyDataVirusScanLatestTaskStatistic VirusScanLatestTaskStatistic { get; set; }
            public class ListVirusScanMachineEventResponseBodyDataVirusScanLatestTaskStatistic : TeaModel {
                /// <summary>
                /// <para>The number of machines that completed scanning.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CompleteMachine")]
                [Validation(Required=false)]
                public int? CompleteMachine { get; set; }

                /// <summary>
                /// <para>The server machine name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testMahine1</para>
                /// </summary>
                [NameInMap("MachineName")]
                [Validation(Required=false)]
                public string MachineName { get; set; }

                /// <summary>
                /// <para>The percentage of the scan task progress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>92</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The highest risk level of the detected alerts. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>medium</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The number of machines on which no risks were detected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SafeMachine")]
                [Validation(Required=false)]
                public int? SafeMachine { get; set; }

                /// <summary>
                /// <para>The number of machines scanned in this virus scan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ScanMachine")]
                [Validation(Required=false)]
                public int? ScanMachine { get; set; }

                /// <summary>
                /// <para>The file paths specified for scanning when the user-defined scan type is used.</para>
                /// </summary>
                [NameInMap("ScanPath")]
                [Validation(Required=false)]
                public List<string> ScanPath { get; set; }

                /// <summary>
                /// <para>The scan timestamp, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1681145862000</para>
                /// </summary>
                [NameInMap("ScanTime")]
                [Validation(Required=false)]
                public long? ScanTime { get; set; }

                /// <summary>
                /// <para>The scan type of this virus scan. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("ScanType")]
                [Validation(Required=false)]
                public string ScanType { get; set; }

                /// <summary>
                /// <para>The status of the scan task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The number of security alerts detected during the scan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SuspiciousCount")]
                [Validation(Required=false)]
                public int? SuspiciousCount { get; set; }

                /// <summary>
                /// <para>The number of machines on which risks were detected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuspiciousMachine")]
                [Validation(Required=false)]
                public int? SuspiciousMachine { get; set; }

                /// <summary>
                /// <para>The ID of the scan task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t-0mqu9dhpi365dp5iyf</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The number of machines that did not complete scanning or failed during scanning.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UnCompleteMachine")]
                [Validation(Required=false)]
                public int? UnCompleteMachine { get; set; }

            }

            /// <summary>
            /// <para>The virus alerts detected on specific machines during virus scanning.</para>
            /// </summary>
            [NameInMap("VirusScanMachineEventList")]
            [Validation(Required=false)]
            public ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventList VirusScanMachineEventList { get; set; }
            public class ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventList : TeaModel {
                /// <summary>
                /// <para>The details of the alert events.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListData> Data { get; set; }
                public class ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListData : TeaModel {
                    /// <summary>
                    /// <para>The details of the anomalous event.</para>
                    /// </summary>
                    [NameInMap("Details")]
                    [Validation(Required=false)]
                    public List<ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListDataDetails> Details { get; set; }
                    public class ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListDataDetails : TeaModel {
                        /// <summary>
                        /// <para>The display type of valueDisplay. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>download_url</para>
                        /// </summary>
                        [NameInMap("InfoType")]
                        [Validation(Required=false)]
                        public string InfoType { get; set; }

                        /// <summary>
                        /// <para>The display name of the alert event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Trojan Path</para>
                        /// </summary>
                        [NameInMap("NameDisplay")]
                        [Validation(Required=false)]
                        public string NameDisplay { get; set; }

                        /// <summary>
                        /// <para>The display method of the anomalous event details.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>text</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The additional attribute information of the anomalous event, such as the logon time or logon location for abnormal logon alerts, or the trojan file path or trojan type for trojan alerts.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>getopt</para>
                        /// </summary>
                        [NameInMap("ValueDisplay")]
                        [Validation(Required=false)]
                        public string ValueDisplay { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the alert event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123-2CcoavZnCXrJKqk2KQKxp9WGwup</para>
                    /// </summary>
                    [NameInMap("EventId")]
                    [Validation(Required=false)]
                    public long? EventId { get; set; }

                    /// <summary>
                    /// <para>The name (subtype) of the alert event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Malicious script code execution.</para>
                    /// </summary>
                    [NameInMap("EventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                    /// <summary>
                    /// <para>The instance name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-wz92q7m5hsbgfhdss***</para>
                    /// </summary>
                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                    /// <summary>
                    /// <para>The public IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>47.57.*1.65</para>
                    /// </summary>
                    [NameInMap("InternetIp")]
                    [Validation(Required=false)]
                    public string InternetIp { get; set; }

                    /// <summary>
                    /// <para>The private IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>47.57.*1.65</para>
                    /// </summary>
                    [NameInMap("IntranetIp")]
                    [Validation(Required=false)]
                    public string IntranetIp { get; set; }

                    /// <summary>
                    /// <para>The timestamp of the last occurrence, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1682046733628</para>
                    /// </summary>
                    [NameInMap("LastTimeStamp")]
                    [Validation(Required=false)]
                    public long? LastTimeStamp { get; set; }

                    /// <summary>
                    /// <para>The risk level of the alert event. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>remind</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                }

                /// <summary>
                /// <para>The pagination information.</para>
                /// </summary>
                [NameInMap("PageInfo")]
                [Validation(Required=false)]
                public ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListPageInfo PageInfo { get; set; }
                public class ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListPageInfo : TeaModel {
                    /// <summary>
                    /// <para>The page number of the current page in a paged query.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CurrentPage")]
                    [Validation(Required=false)]
                    public int? CurrentPage { get; set; }

                    /// <summary>
                    /// <para>The maximum number of entries displayed per page in a paged query.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    /// <summary>
                    /// <para>The total number of alert events returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public int? TotalCount { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The message information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful‌</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0AD8096-E7A2-573D-ACF0-7CE9050CDE38</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
