// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyContainerDefenseRuleSwitchRequest : TeaModel {
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<long?> RuleIds { get; set; }

        [NameInMap("RuleSwitch")]
        [Validation(Required=false)]
        public int? RuleSwitch { get; set; }

    }

}
