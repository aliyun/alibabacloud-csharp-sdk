// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutonomousNotifyEventContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the notification events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;taskId\&quot;:\&quot;7e1ba595-0889-48ff-a6ff-010f54991d****\&quot;,\&quot;taskType\&quot;:\&quot;SQL_OPTIMIZE\&quot;,\&quot;advisorId\&quot;:\&quot;636dc5f34664dd56ff0****\&quot;,\&quot;sqlId\&quot;:\&quot;e2b1d6c1ee1bb29555a828b59f16****\&quot;,\&quot;indexAdviceCount\&quot;:1,\&quot;indexAdvices\&quot;:[{\&quot;schemaName\&quot;:\&quot;das\&quot;,\&quot;tableName\&quot;:\&quot;students\&quot;,\&quot;indexName\&quot;:\&quot;idx_name\&quot;,\&quot;columns\&quot;:[\&quot;name\&quot;],\&quot;unique\&quot;:false,\&quot;ddlAddIndex\&quot;:\&quot;ALTER TABLE <c>das</c>.<c>students</c> ADD INDEX <c>idx_name</c> (<c>name</c>)\&quot;,\&quot;priority\&quot;:0,\&quot;optimizeId\&quot;:\&quot;96232794517277511\&quot;}],\&quot;tuningAdvices\&quot;:[],\&quot;improvement\&quot;:8127.25,\&quot;supportLevel\&quot;:3,\&quot;priority\&quot;:\&quot;HIGH\&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, Successful is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
