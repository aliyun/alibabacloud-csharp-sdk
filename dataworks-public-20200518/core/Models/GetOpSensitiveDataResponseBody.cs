// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOpSensitiveDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned sensitive data record information. This includes totalCount (the total number of sensitive data records) and opRiskDatas (the risk data list).
        /// The opRiskDatas list includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description>sensType: The sensitivity type.</description></item>
        /// <item><description>sensLevel: The sensitivity level. A larger value indicates a higher sensitivity level.</description></item>
        /// <item><description>opType: The operation type.</description></item>
        /// <item><description>sql: The SQL statement executed for the operation.</description></item>
        /// <item><description>opAccount: The account that performed the operation.</description></item>
        /// <item><description>opTime: The time when the operation was performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;opSensDatas&quot;: [       {         &quot;sensLevel&quot;: &quot;L4&quot;,         &quot;opTime&quot;: &quot;2021-02-07 00:14:51&quot;,         &quot;opAccount&quot;: &quot;ALIYUN$dsg_test&quot;,         &quot;sensType&quot;: &quot;Mobile phone number&quot;,         &quot;sql&quot;: &quot;select * from dsg_demo.tbl_phonebook where phone_no = &#39;1331111****&#39;;&quot;       }     ],     &quot;totalCount&quot;: 6</para>
        /// </summary>
        [NameInMap("OpSensitiveData")]
        [Validation(Required=false)]
        public string OpSensitiveData { get; set; }

        /// <summary>
        /// <para>The request ID, which uniquely identifies the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
