// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstancesResponse : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=true)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=true)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListInstancesResponseData Data { get; set; }
        public class ListInstancesResponseData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("Instances")]
            [Validation(Required=true)]
            public List<ListInstancesResponseDataInstances> Instances { get; set; }
            public class ListInstancesResponseDataInstances : TeaModel {
                public long? NodeId { get; set; }
                public long? InstanceId { get; set; }
                public long? DagId { get; set; }
                public string DagType { get; set; }
                public string Status { get; set; }
                public long? Bizdate { get; set; }
                public long? CycTime { get; set; }
                public long? CreateTime { get; set; }
                public long? ModifyTime { get; set; }
                public string NodeName { get; set; }
                public long? BeginWaitTimeTime { get; set; }
                public long? BeginWaitResTime { get; set; }
                public long? BeginRunningTime { get; set; }
                public string ParamValues { get; set; }
                public long? FinishTime { get; set; }
                public int? Priority { get; set; }
                public long? BaselineId { get; set; }
                public bool? Repeatability { get; set; }
                public long? RepeatInterval { get; set; }
                public string Connection { get; set; }
                public int? DqcType { get; set; }
                public string DqcDescription { get; set; }
                public string ErrorMessage { get; set; }
                public long? RelatedFlowId { get; set; }
                public string TaskType { get; set; }
                public int? TaskRerunTime { get; set; }
                public long? BusinessId { get; set; }
            }
        };

    }

}
