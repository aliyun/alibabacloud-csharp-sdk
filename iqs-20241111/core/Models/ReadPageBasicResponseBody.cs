// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ReadPageBasicResponseBody : TeaModel {
        /// <summary>
        /// <para>The parsing result of the destination URL.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ReadPageItem Data { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID. Provide this ID for troubleshooting.</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
