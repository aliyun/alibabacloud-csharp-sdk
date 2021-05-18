// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class EditQualityRuleRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RuleTag")]
        [Validation(Required=false)]
        public int? RuleTag { get; set; }

        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public int? MatchType { get; set; }

        [NameInMap("QualityRuleId")]
        [Validation(Required=false)]
        public long? QualityRuleId { get; set; }

        [NameInMap("KeyWords")]
        [Validation(Required=false)]
        public List<string> KeyWords { get; set; }

    }

}
