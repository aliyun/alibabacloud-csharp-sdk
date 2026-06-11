// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OpenClawInstanceQuotaVO : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account UID.</para>
        /// </summary>
        [NameInMap("AliyunAccountUid")]
        [Validation(Required=false)]
        public string AliyunAccountUid { get; set; }

        /// <summary>
        /// <para>The total quota for deep research calls.</para>
        /// </summary>
        [NameInMap("DeepResearchCallQuota")]
        [Validation(Required=false)]
        public string DeepResearchCallQuota { get; set; }

        /// <summary>
        /// <para>The number of deep research calls used.</para>
        /// </summary>
        [NameInMap("DeepResearchCallUsed")]
        [Validation(Required=false)]
        public string DeepResearchCallUsed { get; set; }

        /// <summary>
        /// <para>The instance creation time.</para>
        /// </summary>
        [NameInMap("InstanceGmtCreate")]
        [Validation(Required=false)]
        public string InstanceGmtCreate { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The timestamp of the last metering event.</para>
        /// </summary>
        [NameInMap("LastMeteringTime")]
        [Validation(Required=false)]
        public string LastMeteringTime { get; set; }

        /// <summary>
        /// <para>The total quota for model calls.</para>
        /// </summary>
        [NameInMap("ModelCallQuota")]
        [Validation(Required=false)]
        public string ModelCallQuota { get; set; }

        /// <summary>
        /// <para>The number of model calls used.</para>
        /// </summary>
        [NameInMap("ModelCallUsed")]
        [Validation(Required=false)]
        public string ModelCallUsed { get; set; }

        /// <summary>
        /// <para>The day of the month on which the quota refreshes.</para>
        /// </summary>
        [NameInMap("RefreshDay")]
        [Validation(Required=false)]
        public string RefreshDay { get; set; }

        /// <summary>
        /// <para>The total quota for skill plan calls.</para>
        /// </summary>
        [NameInMap("SkillPlanCallQuota")]
        [Validation(Required=false)]
        public string SkillPlanCallQuota { get; set; }

        /// <summary>
        /// <para>The number of skill plan calls used.</para>
        /// </summary>
        [NameInMap("SkillPlanCallUsed")]
        [Validation(Required=false)]
        public string SkillPlanCallUsed { get; set; }

    }

}
