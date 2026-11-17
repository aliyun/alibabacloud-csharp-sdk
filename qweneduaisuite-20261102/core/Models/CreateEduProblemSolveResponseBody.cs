// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102.Models
{
    public class CreateEduProblemSolveResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateEduProblemSolveResponseBodyData Data { get; set; }
        public class CreateEduProblemSolveResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>change_batch</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<CreateEduProblemSolveResponseBodyDataItems> Items { get; set; }
            public class CreateEduProblemSolveResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("questionId")]
                [Validation(Required=false)]
                public string QuestionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("thinking")]
                [Validation(Required=false)]
                public CreateEduProblemSolveResponseBodyDataItemsThinking Thinking { get; set; }
                public class CreateEduProblemSolveResponseBodyDataItemsThinking : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8ci7nsj9WPYXvQb9MJfA</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>098E23F7-A74C-5584-87A1-39734D5B83CE</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("resultType")]
            [Validation(Required=false)]
            public string ResultType { get; set; }

            [NameInMap("retryable")]
            [Validation(Required=false)]
            public bool? Retryable { get; set; }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public CreateEduProblemSolveResponseBodyDataUsage Usage { get; set; }
            public class CreateEduProblemSolveResponseBodyDataUsage : TeaModel {
                [NameInMap("completionTokens")]
                [Validation(Required=false)]
                public int? CompletionTokens { get; set; }

                [NameInMap("promptTokens")]
                [Validation(Required=false)]
                public int? PromptTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public string Event { get; set; }

    }

}
