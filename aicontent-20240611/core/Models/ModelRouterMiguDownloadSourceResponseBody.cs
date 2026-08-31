// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterMiguDownloadSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The data object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public MiguSourceDownloadDTO Data { get; set; }

        /// <summary>
        /// <para>The business error code. This value is passed through as-is from the console and is not mapped to platform standard error codes. Valid values: ERROR_PARAMETERS: Missing or invalid parameters. ERROR_NOT_FOUND: The source file does not exist or does not belong to the current account. ERROR_SOURCE_TRANSFERRING: The source file is being transferred. ERROR_SOURCE_EXPIRED: The source file has expired. ERROR_SERVER_INTERNAL: Internal error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR_NOT_FOUND</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unknown error</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The business status code. Valid values: 0: Success. 400/403/404/409/410/500: Business error. Refer to errCode for details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
