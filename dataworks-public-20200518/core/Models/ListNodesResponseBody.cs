// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodesResponseBody : TeaModel {
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
        public ListNodesResponseBodyData Data { get; set; }
        public class ListNodesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyDataNodes> Nodes { get; set; }
            public class ListNodesResponseBodyDataNodes : TeaModel {
                public string SchedulerType { get; set; }
                public long? RepeatInterval { get; set; }
                public bool? Repeatability { get; set; }
                public long? ProjectId { get; set; }
                public string ProgramType { get; set; }
                public int? Priority { get; set; }
                public string OwnerId { get; set; }
                public string Connection { get; set; }
                public string ParamValues { get; set; }
                public long? RelatedFlowId { get; set; }
                public int? DqcType { get; set; }
                public long? BaselineId { get; set; }
                public string Description { get; set; }
                public string NodeName { get; set; }
                public string ResGroupName { get; set; }
                public string DqcDescription { get; set; }
                public string CronExpress { get; set; }
                public long? NodeId { get; set; }
            }
        };

    }

}
