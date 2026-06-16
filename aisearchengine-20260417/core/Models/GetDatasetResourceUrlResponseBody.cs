// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiSearchEngine20260417.Models
{
    public class GetDatasetResourceUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of <c>200</c> indicates a successful request. Other values indicate an exception. For more information, see error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The business data body.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDatasetResourceUrlResponseBodyData Data { get; set; }
        public class GetDatasetResourceUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The temporary OSS access URL with a signature and expiration time (valid for 24 hours). The URL can be used directly for frontend display or download.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://maas-ai-search-center-raw.oss-cn-hangzhou.aliyuncs.com/.../sample.mp4">https://maas-ai-search-center-raw.oss-cn-hangzhou.aliyuncs.com/.../sample.mp4</a>...</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The status description. The value is &quot;success&quot; for successful requests and a specific error message for failed requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID, used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a0f40dd17774641794394269ec0e9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
