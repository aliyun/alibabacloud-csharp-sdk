// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgentServiceOrderSummaryVO : TeaModel {
        /// <summary>
        /// <para>The name of the agent service.</para>
        /// </summary>
        [NameInMap("AgentService")]
        [Validation(Required=false)]
        public string AgentService { get; set; }

        /// <summary>
        /// <para>The deep research quota for the service.</para>
        /// </summary>
        [NameInMap("DeepResearchQuota")]
        [Validation(Required=false)]
        public long? DeepResearchQuota { get; set; }

        /// <summary>
        /// <para>The model call quota for the service.</para>
        /// </summary>
        [NameInMap("ModelCallQuota")]
        [Validation(Required=false)]
        public long? ModelCallQuota { get; set; }

        /// <summary>
        /// <para>The order count for the agent service.</para>
        /// </summary>
        [NameInMap("OrderCount")]
        [Validation(Required=false)]
        public int? OrderCount { get; set; }

        /// <summary>
        /// <para>The total number of services.</para>
        /// </summary>
        [NameInMap("ServiceNumTotal")]
        [Validation(Required=false)]
        public int? ServiceNumTotal { get; set; }

        /// <summary>
        /// <para>The skill plan call quota for the service.</para>
        /// </summary>
        [NameInMap("SkillPlanCallQuota")]
        [Validation(Required=false)]
        public long? SkillPlanCallQuota { get; set; }

    }

}
