// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterSaveFlowConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ModelRouterSaveFlowConfigResponseBodyData Data { get; set; }
        public class ModelRouterSaveFlowConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-27T18:28:57.987356+08:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-27T18:28:57.987356+08:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the flow control configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The model ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>607</para>
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public int? ModelId { get; set; }

            /// <summary>
            /// <para>The configured RPM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("rpm")]
            [Validation(Required=false)]
            public int? Rpm { get; set; }

            /// <summary>
            /// <para>Indicates whether smooth flow control is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("smoothFlowEnabled")]
            [Validation(Required=false)]
            public bool? SmoothFlowEnabled { get; set; }

            /// <summary>
            /// <para>The configured TPM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("tpm")]
            [Validation(Required=false)]
            public int? Tpm { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>未知错误</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
