// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListFlowsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Flow")]
        [Validation(Required=false)]
        public ListFlowsResponseBodyFlow Flow { get; set; }
        public class ListFlowsResponseBodyFlow : TeaModel {
            [NameInMap("Flow")]
            [Validation(Required=false)]
            public List<ListFlowsResponseBodyFlowFlow> Flow { get; set; }
            public class ListFlowsResponseBodyFlowFlow : TeaModel {
                public string Type { get; set; }
                public string Status { get; set; }
                public string AlertUserGroupBizId { get; set; }
                public bool? Periodic { get; set; }
                public string ProjectId { get; set; }
                public string HostName { get; set; }
                public long? GmtModified { get; set; }
                public string Description { get; set; }
                public long? StartSchedule { get; set; }
                public bool? CreateCluster { get; set; }
                public long? EndSchedule { get; set; }
                public string Graph { get; set; }
                public long? GmtCreate { get; set; }
                public string AlertDingDingGroupBizId { get; set; }
                public string CronExpr { get; set; }
                public string CategoryId { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
                public string ClusterId { get; set; }
                public string AlertConf { get; set; }
            }
        };

    }

}
