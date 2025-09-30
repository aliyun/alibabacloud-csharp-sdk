// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ChatWithKnowledgeBaseResponseBody : TeaModel {
        [NameInMap("ChatCompletion")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseResponseBodyChatCompletion ChatCompletion { get; set; }
        public class ChatWithKnowledgeBaseResponseBodyChatCompletion : TeaModel {
            [NameInMap("Choices")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseResponseBodyChatCompletionChoices> Choices { get; set; }
            public class ChatWithKnowledgeBaseResponseBodyChatCompletionChoices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>finish</para>
                /// </summary>
                [NameInMap("FinishReason")]
                [Validation(Required=false)]
                public string FinishReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessage Message { get; set; }
                public class ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessage : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>user</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    [NameInMap("ToolCalls")]
                    [Validation(Required=false)]
                    public List<ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessageToolCalls> ToolCalls { get; set; }
                    public class ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessageToolCalls : TeaModel {
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessageToolCallsFunction Function { get; set; }
                        public class ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessageToolCallsFunction : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>{&quot;city&quot;:&quot;hangzhou&quot;}</para>
                            /// </summary>
                            [NameInMap("Arguments")]
                            [Validation(Required=false)]
                            public string Arguments { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>&quot;get_weather&quot;</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>&quot;chatcmpl-c1bebafa-cc48-44e2-88c6-1a3572952f8e&quot;</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public long? Index { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1758529748</para>
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>273e3fc7-8f56-4167-a1bb-d35d2f3b9043</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseResponseBodyChatCompletionUsage Usage { get; set; }
            public class ChatWithKnowledgeBaseResponseBodyChatCompletionUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("CompletionTokens")]
                [Validation(Required=false)]
                public long? CompletionTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("PromptTokens")]
                [Validation(Required=false)]
                public long? PromptTokens { get; set; }

                [NameInMap("PromptTokensDetails")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseResponseBodyChatCompletionUsagePromptTokensDetails PromptTokensDetails { get; set; }
                public class ChatWithKnowledgeBaseResponseBodyChatCompletionUsagePromptTokensDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>24</para>
                    /// </summary>
                    [NameInMap("CachedTokens")]
                    [Validation(Required=false)]
                    public long? CachedTokens { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("MultiCollectionRecallResult")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResult MultiCollectionRecallResult { get; set; }
        public class ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResult : TeaModel {
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<string> Entities { get; set; }

            [NameInMap("Matches")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultMatches> Matches { get; set; }
            public class ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultMatches : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>process_info_19b9df4dc9ad4bf2b30eb2faa4a9a987.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://viapi-customer-pop.oss-cn-shanghai.aliyuncs.com/b4d8_207196811002111319_570c0e199f03428f812ab21fcc00dd6a">http://viapi-customer-pop.oss-cn-shanghai.aliyuncs.com/b4d8_207196811002111319_570c0e199f03428f812ab21fcc00dd6a</a></para>
                /// </summary>
                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>273e3fc7-8f56-4167-a1bb-d35d2f3b9043</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;page&quot;:1}</para>
                /// </summary>
                [NameInMap("LoaderMetadata")]
                [Validation(Required=false)]
                public object LoaderMetadata { get; set; }

                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultMatchesMetadata Metadata { get; set; }
                public class ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultMatchesMetadata : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public long? Source { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("RerankScore")]
                [Validation(Required=false)]
                public double? RerankScore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RetrievalSource")]
                [Validation(Required=false)]
                public long? RetrievalSource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("Vector")]
                [Validation(Required=false)]
                public List<double?> Vector { get; set; }

            }

            [NameInMap("Relations")]
            [Validation(Required=false)]
            public List<string> Relations { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6B9E3255-4543-5B3B-9E00-6490CA64742B</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("Tokens")]
            [Validation(Required=false)]
            public long? Tokens { get; set; }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultUsage Usage { get; set; }
            public class ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("EmbeddingTokens")]
                [Validation(Required=false)]
                public long? EmbeddingTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
