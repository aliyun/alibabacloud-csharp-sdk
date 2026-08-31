// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterMiguUploadSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The data object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public MiguSourceUploadDTO Data { get; set; }

        /// <summary>
        /// <para>The business error code. The console passes through the original value without mapping to standard platform error codes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ERROR_PARAMETERS: Missing or invalid parameters.</description></item>
        /// <item><description>ERROR_SERVER_INTERNAL: Internal error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR_PARAMETERS</para>
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
        /// <para>The business status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Success.</description></item>
        /// <item><description>400/403/500: Business error. For details, see errCode.</description></item>
        /// </list>
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
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
