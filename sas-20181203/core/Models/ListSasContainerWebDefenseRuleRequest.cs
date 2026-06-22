// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSasContainerWebDefenseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The conditions for searching assets. This parameter is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: The search item.</description></item>
        /// <item><description><b>value</b>: The value of the search item.</description></item>
        /// <item><description><b>logicalExp</b>: The logical relationship among multiple search item values. Valid values:<list type="bullet">
        /// <item><description><b>OR</b>: The search item values are evaluated by using the OR operator.</description></item>
        /// <item><description><b>AND</b>: The search item values are evaluated by using the AND operator.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;ruleName\&quot;,\&quot;value\&quot;:\&quot;test-1818\&quot;,\&quot;logicalExp\&quot;:\&quot;AND\&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The logical relationship among multiple search conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: The search conditions are evaluated by using the OR operator.</description></item>
        /// <item><description><b>AND</b>: The search conditions are evaluated by using the AND operator.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Default value: <b>20</b>, which indicates that 20 entries are displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
