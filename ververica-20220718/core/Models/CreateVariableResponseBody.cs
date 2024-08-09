// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class CreateVariableResponseBody : TeaModel {
        /// <summary>
        /// *   If the value of success was true, the variable that you created was returned.
        /// *   If the value of success was false, a null value was returned.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Variable Data { get; set; }

        /// <summary>
        /// *   If the value of success was false, an error code was returned.
        /// *   If the value of success was true, a null value was returned.
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// *   If the value of success was false, an error message was returned.
        /// *   If the value of success was true, a null value was returned.
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The value was fixed to 200.
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
