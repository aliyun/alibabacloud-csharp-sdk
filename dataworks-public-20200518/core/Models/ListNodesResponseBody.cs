// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNodesResponseBodyData Data { get; set; }
        public class ListNodesResponseBodyData : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyDataNodes> Nodes { get; set; }
            public class ListNodesResponseBodyDataNodes : TeaModel {
                public long? BaselineId { get; set; }
                public long? BusinessId { get; set; }
                public string Connection { get; set; }
                public string CronExpress { get; set; }
                public string Description { get; set; }
                public string DqcDescription { get; set; }
                public int? DqcType { get; set; }
                public long? NodeId { get; set; }
                public string NodeName { get; set; }
                public string OwnerId { get; set; }
                public string ParamValues { get; set; }
                public int? Priority { get; set; }
                public string ProgramType { get; set; }
                public long? ProjectId { get; set; }
                public long? RelatedFlowId { get; set; }
                public long? RepeatInterval { get; set; }
                public bool? Repeatability { get; set; }
                public string ResGroupName { get; set; }
                public string SchedulerType { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
