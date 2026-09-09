// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateComputeQuotaScheduleResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QUOTA_PLAN_NOT_FOUND</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan \&quot;***\&quot; does not exist</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para>1xx: an informational response. The request was received and is being processed.</para>
        /// </description></item>
        /// <item><description><para>2xx: a success response. The request was successfully received, understood, and accepted by the server.</para>
        /// </description></item>
        /// <item><description><para>3xx: a redirection response. The request was redirected. You must take further action to complete the request.</para>
        /// </description></item>
        /// <item><description><para>4xx: a client error. The request contains invalid request parameters or syntax, or cannot be fulfilled for a specific reason.</para>
        /// </description></item>
        /// <item><description><para>5xx: a server error. The server cannot fulfill the request for other reasons.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0be3e0aa16667684362147582e038f</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
