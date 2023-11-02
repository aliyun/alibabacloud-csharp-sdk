// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostRuleStatusChangeRequest : TeaModel {
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        [NameInMap("InUse")]
        [Validation(Required=false)]
        public bool? InUse { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
