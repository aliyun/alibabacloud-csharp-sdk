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
        /// </summary>
        [NameInMap("RiskData")]
        [Validation(Required=false)]
        public string RiskData { get; set; }

    }

}
