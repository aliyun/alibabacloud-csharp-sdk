// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class PushLDCFlowRuleRequest : TeaModel {
        [NameInMap("AppsRepeatList")]
        [Validation(Required=false)]
        public List<string> AppsRepeatList { get; set; }

        [NameInMap("Gray")]
        [Validation(Required=false)]
        public bool? Gray { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("Override")]
        [Validation(Required=false)]
        public bool? Override { get; set; }

        [NameInMap("PushAll")]
        [Validation(Required=false)]
        public bool? PushAll { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        [NameInMap("RuleValue")]
        [Validation(Required=false)]
        public string RuleValue { get; set; }

        [NameInMap("TargetsRepeatList")]
        [Validation(Required=false)]
        public List<string> TargetsRepeatList { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

    }

}
