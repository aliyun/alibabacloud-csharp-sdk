// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class GetDocTranslateTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDocTranslateTaskResponseBodyData Data { get; set; }
        public class GetDocTranslateTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("charactersCount")]
            [Validation(Required=false)]
            public int? CharactersCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("pageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>translated</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d3a2397bc2c14ab4a2e40a4f5b46241b</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://translate-ai-data-dev.oss-cn-hangzhou.aliyuncs.com/tongyiTranslate/123456789/a7630164ce894c799cca0f0822c36f84_merge.md?Expires=1756700753&OSSAccessKeyId=LTAI5tRmTwxU5YoHUyrF93Jv&Signature=qB03ldVmRa%2FRwWgJ2wSi7ylayMA%3D">http://translate-ai-data-dev.oss-cn-hangzhou.aliyuncs.com/tongyiTranslate/123456789/a7630164ce894c799cca0f0822c36f84_merge.md?Expires=1756700753&amp;OSSAccessKeyId=LTAI5tRmTwxU5YoHUyrF93Jv&amp;Signature=qB03ldVmRa%2FRwWgJ2wSi7ylayMA%3D</a></para>
            /// </summary>
            [NameInMap("translateFileUrl")]
            [Validation(Required=false)]
            public string TranslateFileUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AC642EEB-C29D-54DF-8F52-622565BBB78A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
