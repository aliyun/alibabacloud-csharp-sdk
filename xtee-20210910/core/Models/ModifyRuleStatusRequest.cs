// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class ModifyRuleStatusRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("applyUserId")]
        [Validation(Required=false)]
        public string ApplyUserId { get; set; }

        [NameInMap("applyUserName")]
        [Validation(Required=false)]
        public string ApplyUserName { get; set; }

        [NameInMap("auditRemark")]
        [Validation(Required=false)]
        public string AuditRemark { get; set; }

        [NameInMap("auditUserId")]
        [Validation(Required=false)]
        public string AuditUserId { get; set; }

        [NameInMap("auditUserName")]
        [Validation(Required=false)]
        public string AuditUserName { get; set; }

        [NameInMap("consoleRuleId")]
        [Validation(Required=false)]
        public long? ConsoleRuleId { get; set; }

        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("ruleAuditType")]
        [Validation(Required=false)]
        public string RuleAuditType { get; set; }

        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        [NameInMap("ruleVersionId")]
        [Validation(Required=false)]
        public long? RuleVersionId { get; set; }

    }

}
