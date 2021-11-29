// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeFlowResponseBody : TeaModel {
        [NameInMap("AlertConf")]
        [Validation(Required=false)]
        public string AlertConf { get; set; }

        [NameInMap("AlertDingDingGroupBizId")]
        [Validation(Required=false)]
        public string AlertDingDingGroupBizId { get; set; }

        [NameInMap("AlertUserGroupBizId")]
        [Validation(Required=false)]
        public string AlertUserGroupBizId { get; set; }

        [NameInMap("Application")]
        [Validation(Required=false)]
        public string Application { get; set; }

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

        [NameInMap("EditLockDetail")]
        [Validation(Required=false)]
        public string EditLockDetail { get; set; }

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

        [NameInMap("Lifecycle")]
        [Validation(Required=false)]
        public string Lifecycle { get; set; }

        [NameInMap("LogArchiveLocation")]
        [Validation(Required=false)]
        public string LogArchiveLocation { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("ParentFlowList")]
        [Validation(Required=false)]
        public DescribeFlowResponseBodyParentFlowList ParentFlowList { get; set; }
        public class DescribeFlowResponseBodyParentFlowList : TeaModel {
            [NameInMap("ParentFlow")]
            [Validation(Required=false)]
            public List<DescribeFlowResponseBodyParentFlowListParentFlow> ParentFlow { get; set; }
            public class DescribeFlowResponseBodyParentFlowListParentFlow : TeaModel {
                public string ParentFlowId { get; set; }
                public string ParentFlowName { get; set; }
                public string ProjectId { get; set; }
                public string ProjectName { get; set; }
            }
        };

        [NameInMap("Periodic")]
        [Validation(Required=false)]
        public bool? Periodic { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
