// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgentServiceOrderVO : TeaModel {
        /// <summary>
        /// <para>The agent service.</para>
        /// </summary>
        [NameInMap("AgentService")]
        [Validation(Required=false)]
        public string AgentService { get; set; }

        /// <summary>
        /// <para>The deep research quota.</para>
        /// </summary>
        [NameInMap("DeepResearchQuota")]
        [Validation(Required=false)]
        public int? DeepResearchQuota { get; set; }

        /// <summary>
        /// <para>The quantity of deep research used.</para>
        /// </summary>
        [NameInMap("DeepResearchUsed")]
        [Validation(Required=false)]
        public int? DeepResearchUsed { get; set; }

        /// <summary>
        /// <para>The service expiration time, specified in UTC.</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The order creation time, specified in UTC.</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The order modification time, specified in UTC.</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The model call quota.</para>
        /// </summary>
        [NameInMap("ModelCallQuota")]
        [Validation(Required=false)]
        public int? ModelCallQuota { get; set; }

        /// <summary>
        /// <para>The number of model calls used.</para>
        /// </summary>
        [NameInMap("ModelCallUsed")]
        [Validation(Required=false)]
        public int? ModelCallUsed { get; set; }

        /// <summary>
        /// <para>The order instance ID.</para>
        /// </summary>
        [NameInMap("OrderInstanceId")]
        [Validation(Required=false)]
        public string OrderInstanceId { get; set; }

        /// <summary>
        /// <para>The number of services.</para>
        /// </summary>
        [NameInMap("ServiceNum")]
        [Validation(Required=false)]
        public int? ServiceNum { get; set; }

        /// <summary>
        /// <para>The skill plan call quota.</para>
        /// </summary>
        [NameInMap("SkillPlanCallQuota")]
        [Validation(Required=false)]
        public int? SkillPlanCallQuota { get; set; }

        /// <summary>
        /// <para>The number of skill plan calls used.</para>
        /// </summary>
        [NameInMap("SkillPlanCallUsed")]
        [Validation(Required=false)]
        public int? SkillPlanCallUsed { get; set; }

        /// <summary>
        /// <para>The order status.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
