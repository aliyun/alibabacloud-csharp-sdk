// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListContainerDefenseRuleRequest : TeaModel {
        /// <summary>
        /// The details of the condition.
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<ListContainerDefenseRuleRequestConditions> Conditions { get; set; }
        public class ListContainerDefenseRuleRequestConditions : TeaModel {
            /// <summary>
            /// The condition type. Valid values:
            /// 
            /// *   **ruleName**: the rule name
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The rule content.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether to query system rules.
        /// 
        /// >  This parameter is deprecated.
        /// </summary>
        [NameInMap("IsDefaultRule")]
        [Validation(Required=false)]
        public int? IsDefaultRule { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese.
        /// *   **en**: English.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The rule type. Valid values:
        /// 
        /// *   1: system rule
        /// *   2: user-defined rule
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

    }

}
