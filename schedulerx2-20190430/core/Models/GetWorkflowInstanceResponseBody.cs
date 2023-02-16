// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetWorkflowInstanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkflowInstanceResponseBodyData Data { get; set; }
        public class GetWorkflowInstanceResponseBodyData : TeaModel {
            [NameInMap("WfInstanceDag")]
            [Validation(Required=false)]
            public GetWorkflowInstanceResponseBodyDataWfInstanceDag WfInstanceDag { get; set; }
            public class GetWorkflowInstanceResponseBodyDataWfInstanceDag : TeaModel {
                [NameInMap("Edges")]
                [Validation(Required=false)]
                public List<GetWorkflowInstanceResponseBodyDataWfInstanceDagEdges> Edges { get; set; }
                public class GetWorkflowInstanceResponseBodyDataWfInstanceDagEdges : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public long? Source { get; set; }

                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public long? Target { get; set; }

                }

                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<GetWorkflowInstanceResponseBodyDataWfInstanceDagNodes> Nodes { get; set; }
                public class GetWorkflowInstanceResponseBodyDataWfInstanceDagNodes : TeaModel {
                    [NameInMap("Attempt")]
                    [Validation(Required=false)]
                    public int? Attempt { get; set; }

                    [NameInMap("DataTime")]
                    [Validation(Required=false)]
                    public string DataTime { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public long? JobId { get; set; }

                    [NameInMap("JobInstanceId")]
                    [Validation(Required=false)]
                    public long? JobInstanceId { get; set; }

                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    [NameInMap("ScheduleTime")]
                    [Validation(Required=false)]
                    public string ScheduleTime { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("WorkAddr")]
                    [Validation(Required=false)]
                    public string WorkAddr { get; set; }

                }

            }

            [NameInMap("WfInstanceInfo")]
            [Validation(Required=false)]
            public GetWorkflowInstanceResponseBodyDataWfInstanceInfo WfInstanceInfo { get; set; }
            public class GetWorkflowInstanceResponseBodyDataWfInstanceInfo : TeaModel {
                [NameInMap("DataTime")]
                [Validation(Required=false)]
                public string DataTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public string ScheduleTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

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
