// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyContainerPluginRuleRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public int? Mode { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public int? RuleId { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        [NameInMap("SelectedPolicy")]
        [Validation(Required=false)]
        public List<string> SelectedPolicy { get; set; }

        [NameInMap("WhiteImages")]
        [Validation(Required=false)]
        public List<string> WhiteImages { get; set; }

    }

}
