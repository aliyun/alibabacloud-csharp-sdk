// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListWebFilterRulesResponseBody : TeaModel {
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
        /// <para>The current number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of web filtering rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListWebFilterRulesResponseBodyRules> Rules { get; set; }
        public class ListWebFilterRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The matching conditions of the rule. The list contains only one condition.</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<ListWebFilterRulesResponseBodyRulesConditions> Conditions { get; set; }
            public class ListWebFilterRulesResponseBodyRulesConditions : TeaModel {
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
                /// <para>The URL to match. A single asterisk (<em>) matches all URLs. A value ending with /</em> indicates prefix wildcard matching.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com/login">www.example.com/login</a></para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public string Values { get; set; }

            }

            /// <summary>
            /// <para>The time when the web filtering rule was created. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731465600</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

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

            /// <summary>
            /// <para>The time when the web filtering rule was last modified. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731469200</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the web filtering rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wfr-8c1d2e3f4a5b6c7d</para>
            /// </summary>
            [NameInMap("WebFilterRuleId")]
            [Validation(Required=false)]
            public string WebFilterRuleId { get; set; }

            /// <summary>
            /// <para>The ID of the web filtering template to which the rule belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wft-3f2a9c1d4b5e6f70</para>
            /// </summary>
            [NameInMap("WebFilterTemplateId")]
            [Validation(Required=false)]
            public string WebFilterTemplateId { get; set; }

        }

        /// <summary>
        /// <para>The total number of web filtering rules that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
