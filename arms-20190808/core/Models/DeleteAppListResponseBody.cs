// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteAppListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. 2XX indicates that the request was successful. 3XX indicates that the request was redirected. 4XX indicates that a request error occurred. 5XX indicates that a server error occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;code\&quot;:200,\&quot;data\&quot;:\&quot;{\\\&quot;code\\\&quot;:200,\\\&quot;data\\\&quot;:true,\\\&quot;errorCode\\ \&quot;:\\\&quot;Deletion of application successful\\\&quot;,\\\&quot;Message\\\&quot;:\\\&quot;Deletion of application successful\\\&quot;,\\\&quot;Successful\\\&quot;:true,\ \\&quot;traceId\\\&quot;:\\\&quot;0bc1667516940677164677396d0088\\\&quot;}\&quot;,\&quot;errorCode\&quot;:\&quot;Batch deletion of applications successful\&quot;,\&quot;message\&quot;:\&quot;Batch deletion of applications successful\ &quot;,\&quot;Success\&quot;:true,\&quot;traceId\&quot;:\&quot;210f470416940677161213505e0e7a\&quot;}&quot;</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The error message returned for invalid request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Deletion of application successful&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B446DF2-3DDD-4B5B-8E3F-D5225120****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the specified applications are deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The applications are deleted.</description></item>
        /// <item><description><c>false</c>: The applications failed to be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
