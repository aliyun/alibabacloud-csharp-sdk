// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OpenClawInstanceQuotaVO : TeaModel {
        [NameInMap("AliyunAccountUid")]
        [Validation(Required=false)]
        public string AliyunAccountUid { get; set; }

        [NameInMap("DeepResearchCallQuota")]
        [Validation(Required=false)]
        public string DeepResearchCallQuota { get; set; }

        [NameInMap("DeepResearchCallUsed")]
        [Validation(Required=false)]
        public string DeepResearchCallUsed { get; set; }

        [NameInMap("InstanceGmtCreate")]
        [Validation(Required=false)]
        public string InstanceGmtCreate { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("LastMeteringTime")]
        [Validation(Required=false)]
        public string LastMeteringTime { get; set; }

        [NameInMap("ModelCallQuota")]
        [Validation(Required=false)]
        public string ModelCallQuota { get; set; }

        [NameInMap("ModelCallUsed")]
        [Validation(Required=false)]
        public string ModelCallUsed { get; set; }

        [NameInMap("RefreshDay")]
        [Validation(Required=false)]
        public string RefreshDay { get; set; }

        [NameInMap("SkillPlanCallQuota")]
        [Validation(Required=false)]
        public string SkillPlanCallQuota { get; set; }

        [NameInMap("SkillPlanCallUsed")]
        [Validation(Required=false)]
        public string SkillPlanCallUsed { get; set; }

    }

}
