// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateTemplateRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("createType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        [NameInMap("logicExpression")]
        [Validation(Required=false)]
        public string LogicExpression { get; set; }

        [NameInMap("memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("ruleActions")]
        [Validation(Required=false)]
        public string RuleActions { get; set; }

        [NameInMap("ruleExpressions")]
        [Validation(Required=false)]
        public string RuleExpressions { get; set; }

        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("ruleStatus")]
        [Validation(Required=false)]
        public string RuleStatus { get; set; }

    }

}
