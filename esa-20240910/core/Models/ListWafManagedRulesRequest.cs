// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafManagedRulesRequest : TeaModel {
        /// <summary>
        /// <para>The attack type of the vulnerability prevention event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SQL injection</description></item>
        /// <item><description>cross-site scripting (XSS)</description></item>
        /// <item><description>code execute</description></item>
        /// <item><description>CRLF</description></item>
        /// <item><description>local file inclusion (LFI)</description></item>
        /// <item><description>remote file inclusion (RFI)</description></item>
        /// <item><description>webshell</description></item>
        /// <item><description>cross-site request forgery</description></item>
        /// <item><description>Others</description></item>
        /// <item><description>SEMA</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public int? AttackType { get; set; }

        /// <summary>
        /// <para>The ID of the WAF rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The WAF instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-awmmx25y2igw</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language type. The response is returned in the specified language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The managed ruleset configuration in JSON string format.</para>
        /// <para>Contains the AttackType, ProtectionLevel, Action, and ManagedRules subfields. When ProtectionLevel is set to -1 (custom mode), specify the status and action for each rule through the ManagedRules array.</para>
        /// </summary>
        [NameInMap("ManagedRuleset")]
        [Validation(Required=false)]
        public ListWafManagedRulesRequestManagedRuleset ManagedRuleset { get; set; }
        public class ListWafManagedRulesRequestManagedRuleset : TeaModel {
            /// <summary>
            /// <para>The unified action when ProtectionLevel is greater than 0. This parameter cannot be empty in this case.</para>
            /// <para>Common valid values: monitor, deny, js, captcha. The actual available values depend on the instance quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>monitor</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The attack type encoding. The value cannot be 0.</para>
            /// <para>Example values: 11 (SQL injection), 12 (XSS), 13 (code execute), 14 (CRLF), 15 (local file inclusion (LFI)), 16 (remote file inclusion (RFI)), 17 (WebShell), 22 (command injection), 26 (SSRF), 27 (path traversal), 28 (protocol violation), 31 (scanner behavior).</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public int? AttackType { get; set; }

            /// <summary>
            /// <para>The rule configuration list in custom mode. This parameter is used only when ProtectionLevel is set to -1.</para>
            /// <para>Each element contains Id, Status, and Action, which are used to specify the enabled status and action for each managed rule.</para>
            /// </summary>
            [NameInMap("ManagedRules")]
            [Validation(Required=false)]
            public List<ListWafManagedRulesRequestManagedRulesetManagedRules> ManagedRules { get; set; }
            public class ListWafManagedRulesRequestManagedRulesetManagedRules : TeaModel {
                /// <summary>
                /// <para>The action for a single rule. This parameter takes effect only in custom mode (ProtectionLevel = -1).</para>
                /// <para>Common valid values: monitor, deny, js, captcha. The actual available values depend on the instance quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>js</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The unique ID of a single managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20611349</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The rule enabled status.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: enabled.</description></item>
                /// <item><description>off: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The protection level within the ruleset.</para>
            /// <para>Valid values: -1 (custom mode, specify each rule through ManagedRules), 1 (loose), 2 (medium), 3 (strict), 4 (super strict).</para>
            /// <para>When the value is -1, ManagedRules cannot be empty. When the value is greater than 0, Action cannot be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public int? ProtectionLevel { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The currently saved protection level, which represents the existing configuration state in the database.</para>
        /// <para>Valid values: -1 (custom mode), 1 (loose), 2 (medium), 3 (strict), 4 (super strict).</para>
        /// <para>Difference from ManagedRuleset.ProtectionLevel: this parameter indicates the currently effective configuration, while ManagedRuleset.ProtectionLevel indicates the target value being passed in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProtectionLevel")]
        [Validation(Required=false)]
        public int? ProtectionLevel { get; set; }

        /// <summary>
        /// <para>The query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Status\&quot;:\&quot;\&quot;,\&quot;ProtectionLevels\&quot;:[2,1],\&quot;Action\&quot;:\&quot;\&quot;,\&quot;IdNameLike\&quot;:\&quot;\&quot;}</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public ListWafManagedRulesRequestQueryArgs QueryArgs { get; set; }
        public class ListWafManagedRulesRequestQueryArgs : TeaModel {
            /// <summary>
            /// <para>The action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>Fuzzy match by rule ID or rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("IdNameLike")]
            [Validation(Required=false)]
            public string IdNameLike { get; set; }

            /// <summary>
            /// <para>The list of rule protection levels.</para>
            /// </summary>
            [NameInMap("ProtectionLevels")]
            [Validation(Required=false)]
            public List<int?> ProtectionLevels { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The site ID. You can obtain the site ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
