// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class GetDocTranslateTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDocTranslateTaskResponseBodyData Data { get; set; }
        public class GetDocTranslateTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The character count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("charactersCount")]
            [Validation(Required=false)]
            public int? CharactersCount { get; set; }

            /// <summary>
            /// <para>The page count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("pageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            /// <summary>
            /// <para>The translation status. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>translated</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The document translation task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d3a2397bc2c14ab4a2e40a4f5b46241b</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The translation result URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://translate-ai-data-dev.oss-cn-hangzhou.aliyuncs.com/tongyiTranslate/123456789/a7630164ce894c799cca0f0822c36f84_merge.md">http://translate-ai-data-dev.oss-cn-hangzhou.aliyuncs.com/tongyiTranslate/123456789/a7630164ce894c799cca0f0822c36f84_merge.md</a></para>
            /// </summary>
            [NameInMap("translateFileUrl")]
            [Validation(Required=false)]
            public string TranslateFileUrl { get; set; }

        }

        /// <summary>
        /// <para>The HTTP response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC642EEB-C29D-54DF-8F52-622565BBB78A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
