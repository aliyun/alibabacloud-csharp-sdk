// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListApplicationCustomRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of application custom rules, sorted by priority in ascending order.</para>
        /// </summary>
        [NameInMap("ApplicationCustomRules")]
        [Validation(Required=false)]
        public List<ListApplicationCustomRulesResponseBodyApplicationCustomRules> ApplicationCustomRules { get; set; }
        public class ListApplicationCustomRulesResponseBodyApplicationCustomRules : TeaModel {
            /// <summary>
            /// <para>The ID of the application custom rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acr-7d2e4f6a8b0c1d3e</para>
            /// </summary>
            [NameInMap("ApplicationCustomRuleId")]
            [Validation(Required=false)]
            public string ApplicationCustomRuleId { get; set; }

            /// <summary>
            /// <para>The name of the custom rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom rule 01</para>
            /// </summary>
            [NameInMap("ApplicationCustomRuleName")]
            [Validation(Required=false)]
            public string ApplicationCustomRuleName { get; set; }

            /// <summary>
            /// <para>The ID of the application template to which the rule belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ati-4f0691c56b8d4f06</para>
            /// </summary>
            [NameInMap("ApplicationTemplateId")]
            [Validation(Required=false)]
            public string ApplicationTemplateId { get; set; }

            /// <summary>
            /// <para>The list of applications associated with the rule.</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationCustomRulesResponseBodyApplicationCustomRulesApplications> Applications { get; set; }
            public class ListApplicationCustomRulesResponseBodyApplicationCustomRulesApplications : TeaModel {
                /// <summary>
                /// <para>The ID of the application in the built-in application signature library.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10012150000</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public long? ApplicationId { get; set; }

                /// <summary>
                /// <para>The name of the application. The name is returned in Chinese or English based on the Lang parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DingTalk</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

            }

            /// <summary>
            /// <para>The priority of the rule. Valid values: integers from 1 to 200. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>The action performed after the rule is matched. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Allow</b>: allows the traffic.</description></item>
            /// <item><description><b>Alert</b>: monitors the traffic.</description></item>
            /// <item><description><b>Deny</b>: blocks the traffic.</description></item>
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
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of application custom rules that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
