// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOpRiskDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which uniquely identifies the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned information about risky sensitive data. This includes totalCount (the total number of sensitive data entries) and opRiskDatas (the list of risky data).
        /// The opRiskDatas list includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description>sensType: The sensitivity type.</description></item>
        /// <item><description>sensLevel: The sensitivity level.</description></item>
        /// <item><description>opType: The operation type.</description></item>
        /// <item><description>sql: The SQL statement executed for the operation.</description></item>
        /// <item><description>opAccount: The account that performed the operation.</description></item>
        /// <item><description>opTime: The time when the operation was performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;opRiskDatas&quot;: [       {         &quot;riskType&quot;: &quot;Hierarchical dimension, EMR engine dimension and project dimension, EMR engine project dimension operation data, export method dimension, EMR engine&quot;,         &quot;opTime&quot;: &quot;2021-01-04 23:39:13&quot;,         &quot;opType&quot;: &quot;SQL_SELECT&quot;,         &quot;opAccount&quot;: &quot;user&quot;,         &quot;sensType&quot;: &quot;Email/name/mobile phone number&quot;,         &quot;sql&quot;: &quot;SELECT * FROM default.jiade_1219_test_create LIMIT 20&quot;       }     ],     &quot;totalCount&quot;: 499   }</para>
        /// </summary>
        [NameInMap("RiskData")]
        [Validation(Required=false)]
        public string RiskData { get; set; }

    }

}
