// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListActionRecordsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListActionRecordsResponseBodyResult> Result { get; set; }
        public class ListActionRecordsResponseBodyResult : TeaModel {
            [NameInMap("ActionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }

            [NameInMap("ActionParams")]
            [Validation(Required=false)]
            public Dictionary<string, object> ActionParams { get; set; }

            [NameInMap("ActionResultAccessList")]
            [Validation(Required=false)]
            public List<string> ActionResultAccessList { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("MetaNow")]
            [Validation(Required=false)]
            public string MetaNow { get; set; }

            [NameInMap("MetaOld")]
            [Validation(Required=false)]
            public string MetaOld { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            [NameInMap("RecordDiff")]
            [Validation(Required=false)]
            public Dictionary<string, object> RecordDiff { get; set; }

            [NameInMap("RecordIds")]
            [Validation(Required=false)]
            public List<string> RecordIds { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("StateType")]
            [Validation(Required=false)]
            public string StateType { get; set; }

            [NameInMap("StatusInfo")]
            [Validation(Required=false)]
            public List<ListActionRecordsResponseBodyResultStatusInfo> StatusInfo { get; set; }
            public class ListActionRecordsResponseBodyResultStatusInfo : TeaModel {
                [NameInMap("completeNodeCount")]
                [Validation(Required=false)]
                public int? CompleteNodeCount { get; set; }

                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("exception")]
                [Validation(Required=false)]
                public string Exception { get; set; }

                [NameInMap("latencyMills")]
                [Validation(Required=false)]
                public long? LatencyMills { get; set; }

                [NameInMap("nodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                [NameInMap("process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("stateType")]
                [Validation(Required=false)]
                public string StateType { get; set; }

                [NameInMap("subState")]
                [Validation(Required=false)]
                public string SubState { get; set; }

                [NameInMap("subStatusInfo")]
                [Validation(Required=false)]
                public List<ListActionRecordsResponseBodyResultStatusInfoSubStatusInfo> SubStatusInfo { get; set; }
                public class ListActionRecordsResponseBodyResultStatusInfoSubStatusInfo : TeaModel {
                    [NameInMap("completeNodeCount")]
                    [Validation(Required=false)]
                    public int? CompleteNodeCount { get; set; }

                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("exception")]
                    [Validation(Required=false)]
                    public string Exception { get; set; }

                    [NameInMap("latencyMills")]
                    [Validation(Required=false)]
                    public long? LatencyMills { get; set; }

                    [NameInMap("nodeCount")]
                    [Validation(Required=false)]
                    public int? NodeCount { get; set; }

                    [NameInMap("process")]
                    [Validation(Required=false)]
                    public string Process { get; set; }

                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("stateType")]
                    [Validation(Required=false)]
                    public string StateType { get; set; }

                    [NameInMap("subState")]
                    [Validation(Required=false)]
                    public string SubState { get; set; }

                }

            }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public string UserInfo { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

    }

}
