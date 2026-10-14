// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgentServiceOrderVO : TeaModel {
        [NameInMap("AgentService")]
        [Validation(Required=false)]
        public string AgentService { get; set; }

        [NameInMap("DeepResearchQuota")]
        [Validation(Required=false)]
        public int? DeepResearchQuota { get; set; }

        [NameInMap("DeepResearchUsed")]
        [Validation(Required=false)]
        public int? DeepResearchUsed { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("ModelCallQuota")]
        [Validation(Required=false)]
        public int? ModelCallQuota { get; set; }

        [NameInMap("ModelCallUsed")]
        [Validation(Required=false)]
        public int? ModelCallUsed { get; set; }

        [NameInMap("OrderInstanceId")]
        [Validation(Required=false)]
        public string OrderInstanceId { get; set; }

        [NameInMap("ServiceNum")]
        [Validation(Required=false)]
        public int? ServiceNum { get; set; }

        [NameInMap("SkillPlanCallQuota")]
        [Validation(Required=false)]
        public int? SkillPlanCallQuota { get; set; }

        [NameInMap("SkillPlanCallUsed")]
        [Validation(Required=false)]
        public int? SkillPlanCallUsed { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
