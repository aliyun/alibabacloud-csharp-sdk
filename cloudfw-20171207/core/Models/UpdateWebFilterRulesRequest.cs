// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class UpdateWebFilterRulesRequest : TeaModel {
        /// <summary>
        /// <para>The list of web filtering rules to be modified. You can specify up to 20 rules at a time, and the rule IDs in the list must be unique.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdateWebFilterRulesRequestRules> Rules { get; set; }
        public class UpdateWebFilterRulesRequestRules : TeaModel {
            /// <summary>
            /// <para>The list of match conditions for the rule. The list must contain exactly one condition. After the modification, URLs within the same template must be unique.</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<UpdateWebFilterRulesRequestRulesConditions> Conditions { get; set; }
            public class UpdateWebFilterRulesRequestRulesConditions : TeaModel {
                /// <summary>
                /// <para>The type of the match condition. Only <b>URL</b> is supported, which indicates matching by URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>URL</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The URL to match. It cannot be empty and must not exceed 240 bytes in length (each Chinese character counts as 3 bytes). It must contain at least one forward slash (/), and the first segment must contain letters, digits, or Chinese characters. It cannot contain a protocol header, query parameters, or fragment identifiers. A single asterisk (<em>) indicates matching all URLs. When a wildcard is used, a maximum of one wildcard is allowed and it must end with /</em>. URLs within the same template must be unique.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com/login">www.example.com/login</a></para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public string Values { get; set; }

            }

            /// <summary>
            /// <para>The action to perform when the rule is matched. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Allow</b>: allows the request.</description></item>
            /// <item><description><b>Alert</b>: monitors the request.</description></item>
            /// <item><description><b>Deny</b>: blocks the request.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Alert</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public string RuleAction { get; set; }

            /// <summary>
            /// <para>The ID of the web filtering rule to be modified. The rule must exist within the current Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wfr-8c1d2e3f4a5b6c7d</para>
            /// </summary>
            [NameInMap("WebFilterRuleId")]
            [Validation(Required=false)]
            public string WebFilterRuleId { get; set; }

        }

    }

}
