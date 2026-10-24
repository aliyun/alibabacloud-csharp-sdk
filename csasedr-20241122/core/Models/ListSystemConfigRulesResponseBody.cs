// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class ListSystemConfigRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The rule list.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListSystemConfigRulesResponseBodyList> List { get; set; }
        public class ListSystemConfigRulesResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>204</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The platform name of the system rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Linux.</description></item>
            /// <item><description><b>2</b>: Windows.</description></item>
            /// <item><description><b>3</b>: Mac.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Host defense link test</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public int? RuleType { get; set; }

            /// <summary>
            /// <para>The switch status of the rule under the specified SelectionKey. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>add</b>: Enabled.</description></item>
            /// <item><description><b>del</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The switch identifier of the system rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER-ENABLE-SWITCH-TYPE_1</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

        }

        /// <summary>
        /// <para>The paging information displayed during a paged query.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListSystemConfigRulesResponseBodyPageInfo PageInfo { get; set; }
        public class ListSystemConfigRulesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries to return on each page during paging in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request, which is used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5B1AACF9-E87B-577A-9B12-655A2E0C96FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
