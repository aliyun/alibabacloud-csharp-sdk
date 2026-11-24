// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102.Models
{
    public class CreateEduProblemSolveResponseBody : TeaModel {
        /// <summary>
        /// <para>The API data identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>change_batch</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Specifies whether the response is the final full snapshot. This value is fixed to true in the complete event.</para>
        /// </summary>
        [NameInMap("finished")]
        [Validation(Required=false)]
        public bool? Finished { get; set; }

        /// <summary>
        /// <para>The current list of complete question results.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<CreateEduProblemSolveResponseBodyItems> Items { get; set; }
        public class CreateEduProblemSolveResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The complete question resolution content in Markdown format, including the deduction process and the final result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The URL of the unique image for the current question. The URL may be time-sensitive. If the question is not associated with an image resource and no request URL is available for fallback, an empty string is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.jpg">https://xxx.jpg</a></para>
            /// </summary>
            [NameInMap("imageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The question identifier. The value is the question title, such as Question 1. The server does not return a separate title field. If the downstream service does not provide a question title, which is always the case in single-question scenarios, titles such as Question 1 and Question 2 are generated in the order of the questions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50a10e43a33e36179e355556d319ebd5</para>
            /// </summary>
            [NameInMap("questionId")]
            [Validation(Required=false)]
            public string QuestionId { get; set; }

            /// <summary>
            /// <para>The current question status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>processing: The question is being processed.</description></item>
            /// <item><description>complete: The question processing is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The thinking process. This field is returned only when result_type is single. It is not returned for multiple questions.</para>
            /// </summary>
            [NameInMap("thinking")]
            [Validation(Required=false)]
            public CreateEduProblemSolveResponseBodyItemsThinking Thinking { get; set; }
            public class CreateEduProblemSolveResponseBodyItemsThinking : TeaModel {
                /// <summary>
                /// <para>The current thinking content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8ci7nsj9WPYXvQb9MJfA</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The thinking status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>processing: The thinking process is in progress.</description></item>
                /// <item><description>complete: The thinking process is complete.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The actual message returned by the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Echo request ID echoed from echo request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>098E23F7-A74C-5584-87A1-39734D5B83CE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the question resolution result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>single: A single question.</description></item>
        /// <item><description>multiple: Multiple questions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>single</para>
        /// </summary>
        [NameInMap("resultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// <para>Specifies whether the error is retryable. Default value: true.</para>
        /// </summary>
        [NameInMap("retryable")]
        [Validation(Required=false)]
        public bool? Retryable { get; set; }

        /// <summary>
        /// <para>The token usage. Only the complete event carries the final value. This field is not returned in message events.</para>
        /// </summary>
        [NameInMap("usage")]
        [Validation(Required=false)]
        public CreateEduProblemSolveResponseBodyUsage Usage { get; set; }
        public class CreateEduProblemSolveResponseBodyUsage : TeaModel {
            /// <summary>
            /// <para>The number of output tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("completionTokens")]
            [Validation(Required=false)]
            public int? CompletionTokens { get; set; }

            /// <summary>
            /// <para>The number of input tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("promptTokens")]
            [Validation(Required=false)]
            public int? PromptTokens { get; set; }

        }

    }

}
