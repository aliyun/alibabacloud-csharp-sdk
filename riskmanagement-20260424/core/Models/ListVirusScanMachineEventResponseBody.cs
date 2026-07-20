// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class ListVirusScanMachineEventResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVirusScanMachineEventResponseBodyData Data { get; set; }
        public class ListVirusScanMachineEventResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1E222AB5-5C2B-50AD-8A96-E704AF80F2A0</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("VirusScanLatestTaskStatistic")]
            [Validation(Required=false)]
            public ListVirusScanMachineEventResponseBodyDataVirusScanLatestTaskStatistic VirusScanLatestTaskStatistic { get; set; }
            public class ListVirusScanMachineEventResponseBodyDataVirusScanLatestTaskStatistic : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CompleteMachine")]
                [Validation(Required=false)]
                public int? CompleteMachine { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testMahine1</para>
                /// </summary>
                [NameInMap("MachineName")]
                [Validation(Required=false)]
                public string MachineName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>92</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>medium</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SafeMachine")]
                [Validation(Required=false)]
                public int? SafeMachine { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ScanMachine")]
                [Validation(Required=false)]
                public int? ScanMachine { get; set; }

                [NameInMap("ScanPath")]
                [Validation(Required=false)]
                public List<string> ScanPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1681145862000</para>
                /// </summary>
                [NameInMap("ScanTime")]
                [Validation(Required=false)]
                public long? ScanTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("ScanType")]
                [Validation(Required=false)]
                public string ScanType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SuspiciousCount")]
                [Validation(Required=false)]
                public int? SuspiciousCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuspiciousMachine")]
                [Validation(Required=false)]
                public int? SuspiciousMachine { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>t-0mqu9dhpi365dp5iyf</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UnCompleteMachine")]
                [Validation(Required=false)]
                public int? UnCompleteMachine { get; set; }

            }

            [NameInMap("VirusScanMachineEventList")]
            [Validation(Required=false)]
            public ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventList VirusScanMachineEventList { get; set; }
            public class ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventList : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListData> Data { get; set; }
                public class ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListData : TeaModel {
                    [NameInMap("Details")]
                    [Validation(Required=false)]
                    public List<ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListDataDetails> Details { get; set; }
                    public class ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListDataDetails : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>download_url</para>
                        /// </summary>
                        [NameInMap("InfoType")]
                        [Validation(Required=false)]
                        public string InfoType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Trojan Path</para>
                        /// </summary>
                        [NameInMap("NameDisplay")]
                        [Validation(Required=false)]
                        public string NameDisplay { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>text</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>getopt</para>
                        /// </summary>
                        [NameInMap("ValueDisplay")]
                        [Validation(Required=false)]
                        public string ValueDisplay { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123-2CcoavZnCXrJKqk2KQKxp9WGwup</para>
                    /// </summary>
                    [NameInMap("EventId")]
                    [Validation(Required=false)]
                    public long? EventId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>恶意脚本代码执行</para>
                    /// </summary>
                    [NameInMap("EventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>i-wz92q7m5hsbgfhdss***</para>
                    /// </summary>
                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>47.57.*1.65</para>
                    /// </summary>
                    [NameInMap("InternetIp")]
                    [Validation(Required=false)]
                    public string InternetIp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>47.57.*1.65</para>
                    /// </summary>
                    [NameInMap("IntranetIp")]
                    [Validation(Required=false)]
                    public string IntranetIp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1682046733628</para>
                    /// </summary>
                    [NameInMap("LastTimeStamp")]
                    [Validation(Required=false)]
                    public long? LastTimeStamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>remind</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                }

                [NameInMap("PageInfo")]
                [Validation(Required=false)]
                public ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListPageInfo PageInfo { get; set; }
                public class ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListPageInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CurrentPage")]
                    [Validation(Required=false)]
                    public int? CurrentPage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>successful‌</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F0AD8096-E7A2-573D-ACF0-7CE9050CDE38</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
