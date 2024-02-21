// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListFlowResponseBody : TeaModel {
        [NameInMap("Flow")]
        [Validation(Required=false)]
        public ListFlowResponseBodyFlow Flow { get; set; }
        public class ListFlowResponseBodyFlow : TeaModel {
            [NameInMap("Flow")]
            [Validation(Required=false)]
            public List<ListFlowResponseBodyFlowFlow> Flow { get; set; }
            public class ListFlowResponseBodyFlowFlow : TeaModel {
                [NameInMap("AlertConf")]
                [Validation(Required=false)]
                public string AlertConf { get; set; }

                [NameInMap("AlertDingDingGroupBizId")]
                [Validation(Required=false)]
                public string AlertDingDingGroupBizId { get; set; }

                [NameInMap("AlertUserGroupBizId")]
                [Validation(Required=false)]
                public string AlertUserGroupBizId { get; set; }

                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public string CategoryId { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("CreateCluster")]
                [Validation(Required=false)]
                public bool? CreateCluster { get; set; }

                [NameInMap("CronExpr")]
                [Validation(Required=false)]
                public string CronExpr { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EndSchedule")]
                [Validation(Required=false)]
                public long? EndSchedule { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("Graph")]
                [Validation(Required=false)]
                public string Graph { get; set; }

                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Periodic")]
                [Validation(Required=false)]
                public bool? Periodic { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                [NameInMap("StartSchedule")]
                [Validation(Required=false)]
                public long? StartSchedule { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

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

    }

}
