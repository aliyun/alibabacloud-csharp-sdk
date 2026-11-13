// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateWebFilterRulesRequest : TeaModel {
        /// <summary>
        /// <para>The list of web filtering rules. You can specify a maximum of 100 rules at a time, and the total number of rules in the template after creation cannot exceed 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreateWebFilterRulesRequestRules> Rules { get; set; }
        public class CreateWebFilterRulesRequestRules : TeaModel {
            /// <summary>
            /// <para>The list of matching conditions for the rule. The list must contain exactly one condition.</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<CreateWebFilterRulesRequestRulesConditions> Conditions { get; set; }
            public class CreateWebFilterRulesRequestRulesConditions : TeaModel {
                /// <summary>
                /// <para>The type of the matching condition. Only <b>URL</b> is supported, which indicates matching by URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>URL</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The URL to match. It cannot be empty and must not exceed 240 bytes in length (each Chinese character counts as 3 bytes). It must contain at least one forward slash (/), and the first segment must contain letters, digits, or Chinese characters. It cannot contain a protocol header, query parameters, or fragment identifiers. A single asterisk (<em>) indicates matching all URLs. When a wildcard is used, a maximum of one wildcard is allowed and it must end with /</em>. URLs within the same template cannot be duplicated.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com/login">www.example.com/login</a></para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public string Values { get; set; }

            }

            /// <summary>
            /// <para>The action to perform when a rule is matched. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Allow</b>: allows the request.</description></item>
            /// <item><description><b>Alert</b>: monitors the request.</description></item>
            /// <item><description><b>Deny</b>: blocks the request.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Deny</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public string RuleAction { get; set; }

        }

        /// <summary>
        /// <para>The ID of the web filtering template to which the web filtering rules belong. The template must exist under the current Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wft-3f2a9c1d4b5e6f70</para>
        /// </summary>
        [NameInMap("WebFilterTemplateId")]
        [Validation(Required=false)]
        public string WebFilterTemplateId { get; set; }

    }

}
