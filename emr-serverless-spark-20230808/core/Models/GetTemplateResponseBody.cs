// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Template Data { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If the value of success was false, an error code was returned.</description></item>
        /// <item><description>If the value of success was true, a null value was returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>040003</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If the value of success was false, an error message was returned.</description></item>
        /// <item><description>If the value of success was true, a null value was returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidUser.NotFound</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>484D9DDA-300D-525E-AF7A-0CCCA5C64A7A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
