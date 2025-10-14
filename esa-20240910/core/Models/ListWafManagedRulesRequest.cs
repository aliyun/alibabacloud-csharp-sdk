// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafManagedRulesRequest : TeaModel {
        /// <summary>
        /// <para>Attack type of the vulnerability protection event. Values:</para>
        /// <list type="bullet">
        /// <item><description>SQL injection</description></item>
        /// <item><description>Cross-site scripting</description></item>
        /// <item><description>Code execution</description></item>
        /// <item><description>CRLF</description></item>
        /// <item><description>Local file inclusion</description></item>
        /// <item><description>Remote file inclusion</description></item>
        /// <item><description>Webshell</description></item>
        /// <item><description>Cross-site request forgery</description></item>
        /// <item><description>Other</description></item>
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
        /// <para>ID of the WAF rule.</para>
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
        /// <para>Language type, which will be used to return the response. Value range:</para>
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
        /// <para>Query page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Query page size.</para>
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
        /// <para>Query conditions.</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public ListWafManagedRulesRequestQueryArgs QueryArgs { get; set; }
        public class ListWafManagedRulesRequestQueryArgs : TeaModel {
            /// <summary>
            /// <para>Action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>Fuzzy search for rule ID or rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("IdNameLike")]
            [Validation(Required=false)]
            public string IdNameLike { get; set; }

            /// <summary>
            /// <para>List of rule protection levels.</para>
            /// </summary>
            [NameInMap("ProtectionLevels")]
            [Validation(Required=false)]
            public List<int?> ProtectionLevels { get; set; }

            /// <summary>
            /// <para>Status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
