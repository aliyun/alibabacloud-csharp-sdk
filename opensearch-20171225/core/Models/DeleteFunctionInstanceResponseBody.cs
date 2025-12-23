// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DeleteFunctionInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. If no error occurs, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Instance.NotExist&quot;</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public long? HttpCode { get; set; }

        /// <summary>
        /// <para>The time consumed for the request, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Latency")]
        [Validation(Required=false)]
        public long? Latency { get; set; }

        /// <summary>
        /// <para>The error message. If no error occurs, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;instance not exist.&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;1081EB05-473C-5BF4-95BE-6D7CAD5E2213&quot;</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OK: The request is successful.</description></item>
        /// <item><description>FAIL: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;OK&quot;</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
