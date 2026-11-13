// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListWebFilterRulesRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: integers greater than or equal to 1. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The rule action for exact matching. Valid values:</para>
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
        /// <para>The ID of the web filtering rule for exact matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wfr-8c1d2e3f4a5b6c7d</para>
        /// </summary>
        [NameInMap("WebFilterRuleId")]
        [Validation(Required=false)]
        public string WebFilterRuleId { get; set; }

        /// <summary>
        /// <para>The ID of the web filtering template for exact matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wft-3f2a9c1d4b5e6f70</para>
        /// </summary>
        [NameInMap("WebFilterTemplateId")]
        [Validation(Required=false)]
        public string WebFilterTemplateId { get; set; }

    }

}
