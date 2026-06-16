// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class ListVirusScanMachineEventResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVirusScanMachineEventResponseBodyData Data { get; set; }
        public class ListVirusScanMachineEventResponseBodyData : TeaModel {
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("VirusScanLatestTaskStatistic")]
            [Validation(Required=false)]
            public ListVirusScanMachineEventResponseBodyDataVirusScanLatestTaskStatistic VirusScanLatestTaskStatistic { get; set; }
            public class ListVirusScanMachineEventResponseBodyDataVirusScanLatestTaskStatistic : TeaModel {
                [NameInMap("CompleteMachine")]
                [Validation(Required=false)]
                public int? CompleteMachine { get; set; }

                [NameInMap("MachineName")]
                [Validation(Required=false)]
                public string MachineName { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                [NameInMap("SafeMachine")]
                [Validation(Required=false)]
                public int? SafeMachine { get; set; }

                [NameInMap("ScanMachine")]
                [Validation(Required=false)]
                public int? ScanMachine { get; set; }

                [NameInMap("ScanPath")]
                [Validation(Required=false)]
                public List<string> ScanPath { get; set; }

                [NameInMap("ScanTime")]
                [Validation(Required=false)]
                public long? ScanTime { get; set; }

                [NameInMap("ScanType")]
                [Validation(Required=false)]
                public string ScanType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("SuspiciousCount")]
                [Validation(Required=false)]
                public int? SuspiciousCount { get; set; }

                [NameInMap("SuspiciousMachine")]
                [Validation(Required=false)]
                public int? SuspiciousMachine { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

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
                        [NameInMap("InfoType")]
                        [Validation(Required=false)]
                        public string InfoType { get; set; }

                        [NameInMap("NameDisplay")]
                        [Validation(Required=false)]
                        public string NameDisplay { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("ValueDisplay")]
                        [Validation(Required=false)]
                        public string ValueDisplay { get; set; }

                    }

                    [NameInMap("EventId")]
                    [Validation(Required=false)]
                    public long? EventId { get; set; }

                    [NameInMap("EventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                    [NameInMap("InternetIp")]
                    [Validation(Required=false)]
                    public string InternetIp { get; set; }

                    [NameInMap("IntranetIp")]
                    [Validation(Required=false)]
                    public string IntranetIp { get; set; }

                    [NameInMap("LastTimeStamp")]
                    [Validation(Required=false)]
                    public long? LastTimeStamp { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                }

                [NameInMap("PageInfo")]
                [Validation(Required=false)]
                public ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListPageInfo PageInfo { get; set; }
                public class ListVirusScanMachineEventResponseBodyDataVirusScanMachineEventListPageInfo : TeaModel {
                    [NameInMap("CurrentPage")]
                    [Validation(Required=false)]
                    public int? CurrentPage { get; set; }

                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public int? TotalCount { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
