// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOpRiskDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the high-risk sensitive data. The information includes totalCount and opRiskDatas. opRiskDatas includes the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>sensType: the type of the sensitive data</description></item>
        /// <item><description>sensLevel: the sensitivity level of the sensitive data</description></item>
        /// <item><description>opType: the type of the operation</description></item>
        /// <item><description>sql: the SQL statement that is executed</description></item>
        /// <item><description>opAccount: the account that is used to perform the operation</description></item>
        /// <item><description>opTime: the time when the operation was performed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;opRiskDatas&quot;: [
        ///             {
        ///                   &quot;riskType&quot;: &quot;Hierarchical dimension, EMR engine dimension and project dimension, EMR engine project dimension operation data, export method dimension, EMR engine&quot;,
        ///                   &quot;opTime&quot;: &quot;2021-01-04 23:39:13&quot;,
        ///                   &quot;opType&quot;: &quot;SQL_SELECT&quot;,
        ///                   &quot;opAccount&quot;: &quot;user&quot;,
        ///                   &quot;sensType&quot;: &quot;Email/name/mobile phone number&quot;,
        ///                   &quot;sql&quot;: &quot;SELECT * FROM default.jiade_1219_test_create LIMIT 20&quot;
        ///             }
        ///       ],
        ///       &quot;totalCount&quot;: 499
        /// }</para>
        /// </summary>
        [NameInMap("RiskData")]
        [Validation(Required=false)]
        public string RiskData { get; set; }

    }

}
