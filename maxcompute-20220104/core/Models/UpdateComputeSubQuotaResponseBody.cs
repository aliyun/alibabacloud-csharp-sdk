// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateComputeSubQuotaResponseBody : TeaModel {
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
        /// <para>OBJECT_NOT_EXIST</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this quota is not exist.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>1xx: informational response. The request is received and is being processed.</description></item>
        /// <item><description>2xx: success. The request is successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: redirection. The request is redirected, and further actions are required to complete the request.</description></item>
        /// <item><description>4xx: client error. The request contains invalid request parameters or syntaxes, or specific request conditions cannot be met.</description></item>
        /// <item><description>5xx: server error. The server cannot meet requirements due to other reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b57ff7616612271051086500ea3ce</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
