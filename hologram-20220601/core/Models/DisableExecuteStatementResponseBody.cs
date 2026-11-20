// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class DisableExecuteStatementResponseBody : TeaModel {
        /// <summary>
        /// <para>Valid values: true: Successful. false: Failed.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// <para><b>The error code. This parameter is empty if the request is successful.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameterValue</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is empty if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid parameter value.</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para><b>The request ID.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>E3F4B2A7-1234-5678-9ABC-DEF012345678</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para><b>Indicates whether the request is successful.</b></para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
