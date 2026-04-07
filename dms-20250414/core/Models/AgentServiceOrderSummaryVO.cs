// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgentServiceOrderSummaryVO : TeaModel {
        [NameInMap("AgentService")]
        [Validation(Required=false)]
        public string AgentService { get; set; }

        [NameInMap("DeepResearchQuota")]
        [Validation(Required=false)]
        public long? DeepResearchQuota { get; set; }

        [NameInMap("ModelCallQuota")]
        [Validation(Required=false)]
        public long? ModelCallQuota { get; set; }

        [NameInMap("OrderCount")]
        [Validation(Required=false)]
        public int? OrderCount { get; set; }

        [NameInMap("ServiceNumTotal")]
        [Validation(Required=false)]
        public int? ServiceNumTotal { get; set; }

        [NameInMap("SkillPlanCallQuota")]
        [Validation(Required=false)]
        public long? SkillPlanCallQuota { get; set; }

    }

}
