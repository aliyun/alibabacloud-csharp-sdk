// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class InsertTmMonitorRuleRequest : TeaModel {
        [NameInMap("Classification")]
        [Validation(Required=false)]
        public Dictionary<string, object> Classification { get; set; }

        [NameInMap("EndApplyDate")]
        [Validation(Required=false)]
        public string EndApplyDate { get; set; }

        [NameInMap("NotifyStatus")]
        [Validation(Required=false)]
        public Dictionary<string, object> NotifyStatus { get; set; }

        [NameInMap("RuleKeyword")]
        [Validation(Required=false)]
        public string RuleKeyword { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("RuleSource")]
        [Validation(Required=false)]
        public string RuleSource { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        [NameInMap("StartApplyDate")]
        [Validation(Required=false)]
        public string StartApplyDate { get; set; }

    }

}
