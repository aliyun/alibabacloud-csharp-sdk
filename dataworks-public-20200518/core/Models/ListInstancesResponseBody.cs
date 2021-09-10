// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstancesResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyData Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyDataInstances> Instances { get; set; }
            public class ListInstancesResponseBodyDataInstances : TeaModel {
                public string Status { get; set; }
                public long? CycTime { get; set; }
                public long? BeginRunningTime { get; set; }
                public long? FinishTime { get; set; }
                public string ErrorMessage { get; set; }
                public long? CreateTime { get; set; }
                public long? DagId { get; set; }
                public int? Priority { get; set; }
                public string TaskType { get; set; }
                public string ParamValues { get; set; }
                public string Connection { get; set; }
                public long? BaselineId { get; set; }
                public int? DqcType { get; set; }
                public string DagType { get; set; }
                public long? BusinessId { get; set; }
                public int? TaskRerunTime { get; set; }
                public long? ModifyTime { get; set; }
                public bool? Repeatability { get; set; }
                public long? RepeatInterval { get; set; }
                public long? InstanceId { get; set; }
                public long? BeginWaitResTime { get; set; }
                public long? RelatedFlowId { get; set; }
                public long? Bizdate { get; set; }
                public string NodeName { get; set; }
                public long? BeginWaitTimeTime { get; set; }
                public string DqcDescription { get; set; }
                public long? NodeId { get; set; }
            }
        };

    }

}
