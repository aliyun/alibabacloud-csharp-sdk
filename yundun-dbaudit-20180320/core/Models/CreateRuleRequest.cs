// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class CreateRuleRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RuleInfo")]
        [Validation(Required=false)]
        public string RuleInfo { get; set; }

        [NameInMap("RuleDbRelation")]
        [Validation(Required=false)]
        public string RuleDbRelation { get; set; }

        [NameInMap("RuleGroup")]
        [Validation(Required=false)]
        public string RuleGroup { get; set; }

        [NameInMap("EffectCurrentDBStatus")]
        [Validation(Required=false)]
        public string EffectCurrentDBStatus { get; set; }

    }

}
