// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafManagedRulesRequest : TeaModel {
        /// <summary>
        /// <para>The attack type to filter the results by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SQL injection</para>
        /// </description></item>
        /// <item><description><para>cross-site scripting</para>
        /// </description></item>
        /// <item><description><para>code execution</para>
        /// </description></item>
        /// <item><description><para>CRLF</para>
        /// </description></item>
        /// <item><description><para>local file inclusion</para>
        /// </description></item>
        /// <item><description><para>remote file inclusion</para>
        /// </description></item>
        /// <item><description><para>webshell</para>
        /// </description></item>
        /// <item><description><para>cross-site request forgery</para>
        /// </description></item>
        /// <item><description><para>Other</para>
        /// </description></item>
        /// <item><description><para>SEMA</para>
        /// </description></item>
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

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The response language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// <item><description><para><b>zh</b>: Chinese.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("ManagedRuleset")]
        [Validation(Required=false)]
        public ListWafManagedRulesRequestManagedRuleset ManagedRuleset { get; set; }
        public class ListWafManagedRulesRequestManagedRuleset : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public int? AttackType { get; set; }

            [NameInMap("ManagedRules")]
            [Validation(Required=false)]
            public List<ListWafManagedRulesRequestManagedRulesetManagedRules> ManagedRules { get; set; }
            public class ListWafManagedRulesRequestManagedRulesetManagedRules : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public int? ProtectionLevel { get; set; }

        }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProtectionLevel")]
        [Validation(Required=false)]
        public int? ProtectionLevel { get; set; }

        /// <summary>
        /// <para>The query conditions.</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public ListWafManagedRulesRequestQueryArgs QueryArgs { get; set; }
        public class ListWafManagedRulesRequestQueryArgs : TeaModel {
            /// <summary>
            /// <para>The rule action to filter by.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The keyword for a fuzzy search on the rule ID or rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("IdNameLike")]
            [Validation(Required=false)]
            public string IdNameLike { get; set; }

            /// <summary>
            /// <para>The rule protection levels to filter the results by.</para>
            /// </summary>
            [NameInMap("ProtectionLevels")]
            [Validation(Required=false)]
            public List<int?> ProtectionLevels { get; set; }

            /// <summary>
            /// <para>The rule status to filter by.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the site. Call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
