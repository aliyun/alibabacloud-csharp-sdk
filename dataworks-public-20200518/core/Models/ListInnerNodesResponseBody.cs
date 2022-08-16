// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInnerNodesResponseBody : TeaModel {
        [NameInMap("Paging")]
        [Validation(Required=false)]
        public ListInnerNodesResponseBodyPaging Paging { get; set; }
        public class ListInnerNodesResponseBodyPaging : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ListInnerNodesResponseBodyPagingNodes> Nodes { get; set; }
            public class ListInnerNodesResponseBodyPagingNodes : TeaModel {
                public long? BaselineId { get; set; }
                public long? BusinessId { get; set; }
                public string Connection { get; set; }
                public string CronExpress { get; set; }
                public string Description { get; set; }
                public string DqcDescription { get; set; }
                public string DqcType { get; set; }
                public long? NodeId { get; set; }
                public string NodeName { get; set; }
                public string OwnerId { get; set; }
                public string ParamValues { get; set; }
                public int? Priority { get; set; }
                public string ProgramType { get; set; }
                public long? ProjectId { get; set; }
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
