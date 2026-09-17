// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryAlertRulesResult : TeaModel {
        /// <summary>
        /// <para>The list of alert rules returned by the query. Each element contains the complete configuration information of an alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;uuid&quot;:&quot;a1b2c3d4-e5f6-7890-abcd-ef1234567890&quot;,&quot;displayName&quot;:&quot;CPU usage alert&quot;,&quot;status&quot;:&quot;OK&quot;}]</para>
        /// </summary>
        [NameInMap("alertRules")]
        [Validation(Required=false)]
        public List<AlertRuleV2> AlertRules { get; set; }

        /// <summary>
        /// <para>The total number of alert rules that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
