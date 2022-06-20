// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ModifyFlowForWebRequest : TeaModel {
        [NameInMap("AlertConf")]
        [Validation(Required=false)]
        public string AlertConf { get; set; }

        [NameInMap("AlertDingDingGroupBizId")]
        [Validation(Required=false)]
        public string AlertDingDingGroupBizId { get; set; }

        [NameInMap("AlertUserGroupBizId")]
        [Validation(Required=false)]
        public string AlertUserGroupBizId { get; set; }

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

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("ParentCategory")]
        [Validation(Required=false)]
        public string ParentCategory { get; set; }

        [NameInMap("ParentFlowList")]
        [Validation(Required=false)]
        public string ParentFlowList { get; set; }

        [NameInMap("Periodic")]
        [Validation(Required=false)]
        public bool? Periodic { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StartSchedule")]
        [Validation(Required=false)]
        public long? StartSchedule { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
