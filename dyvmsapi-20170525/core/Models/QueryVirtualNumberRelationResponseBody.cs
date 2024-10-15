// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryVirtualNumberRelationResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value 200 indicates that the request was successful.</description></item>
        /// <item><description>For more information about other response codes, see <a href="https://help.aliyun.com/document_detail/112502.html">API error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of associations between virtual numbers and real numbers. The following fields are returned:</para>
        /// <list type="bullet">
        /// <item><description><b>relatedNum</b>: the real number.</description></item>
        /// <item><description><b>createTime</b>: the time when the number was activated.</description></item>
        /// <item><description><b>pageNo</b>: the page number.</description></item>
        /// <item><description><b>pageSize</b>: the number of entries per page.</description></item>
        /// <item><description><b>total</b>: the total number of entries returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;data&quot;:[{&quot;relatedNum&quot;:&quot;1705559****&quot;,&quot;createTime&quot;:&quot;2021-03-26 12:34:08&quot;}],&quot;pageSize&quot;:20,&quot;total&quot;:1,&quot;pageNo&quot;:1}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FAD5988-B483-48A4-B251-6E8470A67371</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
