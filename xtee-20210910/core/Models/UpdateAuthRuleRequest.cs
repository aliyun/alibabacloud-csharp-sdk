// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class UpdateAuthRuleRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("consoleRuleId")]
        [Validation(Required=false)]
        public long? ConsoleRuleId { get; set; }

        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("ruleActions")]
        [Validation(Required=false)]
        public string RuleActions { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ruleExpressions")]
        [Validation(Required=false)]
        public string RuleExpressions { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        [NameInMap("ruleVersionId")]
        [Validation(Required=false)]
        public long? RuleVersionId { get; set; }

    }

}
