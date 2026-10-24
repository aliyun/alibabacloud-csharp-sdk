// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class ListSystemConfigRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of system rule category IDs.</para>
        /// </summary>
        [NameInMap("AggregationIds")]
        [Validation(Required=false)]
        public string AggregationIdsShrink { get; set; }

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
        /// <para>The language used for the rule name and description. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page during paging in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Process startup</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The list of rule types for filtering.</para>
        /// </summary>
        [NameInMap("RuleTypes")]
        [Validation(Required=false)]
        public string RuleTypesShrink { get; set; }

        /// <summary>
        /// <para>The key for the switch configuration of rules associated with a policy. Use the SelectionKey saved for the same policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7efed2db-cc8c-4704-a1c3-d448c5d41e74</para>
        /// </summary>
        [NameInMap("SelectionKey")]
        [Validation(Required=false)]
        public string SelectionKey { get; set; }

        /// <summary>
        /// <para>The system platform identifier used for filtering. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Linux.</description></item>
        /// <item><description><b>2</b>: Windows.</description></item>
        /// <item><description><b>3</b>: Mac.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SystemType")]
        [Validation(Required=false)]
        public int? SystemType { get; set; }

    }

}
