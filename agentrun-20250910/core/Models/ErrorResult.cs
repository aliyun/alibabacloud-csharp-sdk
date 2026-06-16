// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ErrorResult : TeaModel {
        /// <summary>
        /// <para>The error code. SUCCESS indicates the request was successful. Otherwise, a specific error code is returned, such as ERR_BAD_REQUEST, ERR_VALIDATION_FAILED, or ERR_INTERNAL_SERVER_ERROR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A human-readable description of the error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Conflict Transaction, process failed</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request identifier, used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55D4BE40-2811-5CFB-8482-E0E98D575B1E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
