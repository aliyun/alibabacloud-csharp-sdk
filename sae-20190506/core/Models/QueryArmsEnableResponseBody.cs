// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class QueryArmsEnableResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code or error code. Valid values: 2xx: The request was successful. 3xx: The request was redirected. 4xx: The request was invalid. 5xx: A server error occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryArmsEnableResponseBodyData Data { get; set; }
        public class QueryArmsEnableResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates if enabled. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>The error code. Value description:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, this field is not returned.</description></item>
        /// <item><description>For more information, see the <b>Error codes</b> section of this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidApplication.NotFound</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The additional information. Value description:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>success</b> is returned.</description></item>
        /// <item><description>If the request failed, an error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01CF26C7-00A3-4AA6-BA76-7E95F2A3****</para>
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
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace, which is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
