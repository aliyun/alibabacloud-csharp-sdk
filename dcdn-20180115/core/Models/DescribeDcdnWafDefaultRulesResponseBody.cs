// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDefaultRulesResponseBody : TeaModel {
        /// <summary>
        /// The rule configurations.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafDefaultRulesResponseBodyContent> Content { get; set; }
        public class DescribeDcdnWafDefaultRulesResponseBodyContent : TeaModel {
            /// <summary>
            /// The protection scenario. Valid values:
            /// 
            /// *   **waf_group**: basic web protection.
            /// *   **anti_scan**: scan protection.
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// The rules.
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafDefaultRulesResponseBodyContentRules> Rules { get; set; }
            public class DescribeDcdnWafDefaultRulesResponseBodyContentRules : TeaModel {
                /// <summary>
                /// The default action of the rule. Valid values:
                /// 
                /// *   **monitor**
                /// *   **deny**
                /// *   **block**
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The default configuration of the rule.
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// The default name of the rule.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The default status of the rule. Valid values:
                /// 
                /// *   **on**
                /// *   **off**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the rule. Valid values:
                /// 
                /// *   **waf_group**: basic web protection.
                /// *   **high_frequency**: high-frequency scanning blocking.
                /// *   **directory_traversal**: directory traversal blocking.
                /// *   **scan_tools**: scanner blocking.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
