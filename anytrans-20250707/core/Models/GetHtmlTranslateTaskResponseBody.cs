// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class GetHtmlTranslateTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetHtmlTranslateTaskResponseBodyData Data { get; set; }
        public class GetHtmlTranslateTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <!DOCTYPE html>
            /// 
            /// <html lang="zh-CN">
            /// <head>
            /// <meta charset="utf-8"/>
            /// <meta content="width=device-width, initial-scale=1.0" name="viewport"/>
            /// <title>My First Webpage</title>
            /// </head>
            /// <body>
            /// <h1>Welcome to my webpage!</h1>
            /// <para>This is a simple HTML page.</para>
            /// <para>Learning HTML is the first step to entering web development.</para>
            /// <a href="https://www.example.com">Click here to visit the sample website</a>
            /// </body>
            /// </html>
            /// </summary>
            [NameInMap("translation")]
            [Validation(Required=false)]
            public string Translation { get; set; }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public GetHtmlTranslateTaskResponseBodyDataUsage Usage { get; set; }
            public class GetHtmlTranslateTaskResponseBodyDataUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>495</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>444</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>939</para>
                /// </summary>
                [NameInMap("totalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

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
        /// <para>64191A87-C480-53AD-AEA2-2E847D4DFA66</para>
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
