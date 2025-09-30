// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ChatWithKnowledgeBaseStreamResponseBody : TeaModel {
        [NameInMap("ChatCompletion")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseStreamResponseBodyChatCompletion ChatCompletion { get; set; }
        public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletion : TeaModel {
            [NameInMap("Choices")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoices> Choices { get; set; }
            public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoices : TeaModel {
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
                public ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessage Message { get; set; }
                public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessage : TeaModel {
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
                    public List<ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessageToolCalls> ToolCalls { get; set; }
                    public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessageToolCalls : TeaModel {
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessageToolCallsFunction Function { get; set; }
                        public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessageToolCallsFunction : TeaModel {
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
            public ChatWithKnowledgeBaseStreamResponseBodyChatCompletionUsage Usage { get; set; }
            public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionUsage : TeaModel {
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
                public ChatWithKnowledgeBaseStreamResponseBodyChatCompletionUsagePromptTokensDetails PromptTokensDetails { get; set; }
                public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionUsagePromptTokensDetails : TeaModel {
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
        public ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResult MultiCollectionRecallResult { get; set; }
        public class ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResult : TeaModel {
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<string> Entities { get; set; }

            [NameInMap("Matches")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultMatches> Matches { get; set; }
            public class ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultMatches : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a14b0221-e3f2-4cf2-96cd-b3c293510770.jpg</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://dailyshort-sh.oss-cn-shanghai.aliyuncs.com/vod-8efba5/f06147795c6c71f080605420848d0302/0ca34d5743a84bf7c68f489a60715dac-ld.mp4">http://dailyshort-sh.oss-cn-shanghai.aliyuncs.com/vod-8efba5/f06147795c6c71f080605420848d0302/0ca34d5743a84bf7c68f489a60715dac-ld.mp4</a></para>
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
                public ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultMatchesMetadata Metadata { get; set; }
                public class ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultMatchesMetadata : TeaModel {
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
                /// <para>0.12</para>
                /// </summary>
                [NameInMap("RerankScore")]
                [Validation(Required=false)]
                public double? RerankScore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.12</para>
                /// </summary>
                [NameInMap("RetrievalSource")]
                [Validation(Required=false)]
                public long? RetrievalSource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("Tokens")]
            [Validation(Required=false)]
            public long? Tokens { get; set; }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultUsage Usage { get; set; }
            public class ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>158</para>
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
