// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOpSensitiveDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the access records of the sensitive data. The information includes totalCount and opRiskDatas. opRiskDatas includes the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>sensType: the type of the sensitive data.</description></item>
        /// <item><description>sensLevel: the sensitivity level of the sensitive data. A larger value indicates a higher sensitivity level.</description></item>
        /// <item><description>opType: the type of the operation.</description></item>
        /// <item><description>sql: the SQL statement that is executed.</description></item>
        /// <item><description>opAccount: the account that is used to perform the operation.</description></item>
        /// <item><description>opTime: the time when the operation was performed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("OpSensitiveData")]
        [Validation(Required=false)]
        public string OpSensitiveData { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
