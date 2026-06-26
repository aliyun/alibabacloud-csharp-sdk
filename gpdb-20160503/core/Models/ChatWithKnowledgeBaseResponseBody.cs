// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ChatWithKnowledgeBaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The model response.</para>
        /// </summary>
        [NameInMap("ChatCompletion")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseResponseBodyChatCompletion ChatCompletion { get; set; }
        public class ChatWithKnowledgeBaseResponseBodyChatCompletion : TeaModel {
            /// <summary>
            /// <para>The real-time generated text content.</para>
            /// </summary>
            [NameInMap("Choices")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseResponseBodyChatCompletionChoices> Choices { get; set; }
            public class ChatWithKnowledgeBaseResponseBodyChatCompletionChoices : TeaModel {
                /// <summary>
                /// <para>The stop reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>finish</para>
                /// </summary>
                [NameInMap("FinishReason")]
                [Validation(Required=false)]
                public string FinishReason { get; set; }

                /// <summary>
                /// <para>The reply sequence number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

                /// <summary>
                /// <para>The large model reply response.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessage Message { get; set; }
                public class ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessage : TeaModel {
                    /// <summary>
                    /// <para>The document content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The weather in Hangzhou is sunny.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The model reasoning content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Logical reasoning process</para>
                    /// </summary>
                    [NameInMap("ReasoningContent")]
                    [Validation(Required=false)]
                    public string ReasoningContent { get; set; }

                    /// <summary>
                    /// <para>The message role:</para>
                    /// <list type="bullet">
                    /// <item><description>system</description></item>
                    /// <item><description>user</description></item>
                    /// <item><description>assistant</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <para>The tool call response list.</para>
                    /// </summary>
                    [NameInMap("ToolCalls")]
                    [Validation(Required=false)]
                    public List<ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessageToolCalls> ToolCalls { get; set; }
                    public class ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessageToolCalls : TeaModel {
                        /// <summary>
                        /// <para>The called function information.</para>
                        /// </summary>
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessageToolCallsFunction Function { get; set; }
                        public class ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessageToolCallsFunction : TeaModel {
                            /// <summary>
                            /// <para>The called function parameters.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;city&quot;:&quot;hangzhou&quot;}</para>
                            /// </summary>
                            [NameInMap("Arguments")]
                            [Validation(Required=false)]
                            public string Arguments { get; set; }

                            /// <summary>
                            /// <para>The called function name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>&quot;get_weather&quot;</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>&quot;chatcmpl-c1bebafa-cc48-44e2-88c6-1a3572952f8e&quot;</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The tool call sequence number.</para>
                        /// 
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
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758529748</para>
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            /// <summary>
            /// <para>The response ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>273e3fc7-8f56-4167-a1bb-d35d2f3b9043</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The model name used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The token usage of the large model output.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseResponseBodyChatCompletionUsage Usage { get; set; }
            public class ChatWithKnowledgeBaseResponseBodyChatCompletionUsage : TeaModel {
                /// <summary>
                /// <para>The number of tokens consumed for generating content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("CompletionTokens")]
                [Validation(Required=false)]
                public long? CompletionTokens { get; set; }

                /// <summary>
                /// <para>The number of tokens consumed by the input prompt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("PromptTokens")]
                [Validation(Required=false)]
                public long? PromptTokens { get; set; }

                /// <summary>
                /// <para>The prompt token details.</para>
                /// </summary>
                [NameInMap("PromptTokensDetails")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseResponseBodyChatCompletionUsagePromptTokensDetails PromptTokensDetails { get; set; }
                public class ChatWithKnowledgeBaseResponseBodyChatCompletionUsagePromptTokensDetails : TeaModel {
                    /// <summary>
                    /// <para>The number of tokens that hit the cache.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24</para>
                    /// </summary>
                    [NameInMap("CachedTokens")]
                    [Validation(Required=false)]
                    public long? CachedTokens { get; set; }

                }

                /// <summary>
                /// <para>The total number of tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The multi-knowledge base recall information.</para>
        /// </summary>
        [NameInMap("MultiCollectionRecallResult")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResult MultiCollectionRecallResult { get; set; }
        public class ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResult : TeaModel {
            /// <summary>
            /// <para>The entity details.</para>
            /// </summary>
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<string> Entities { get; set; }

            /// <summary>
            /// <para>The recall items.</para>
            /// </summary>
            [NameInMap("Matches")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultMatches> Matches { get; set; }
            public class ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultMatches : TeaModel {
                /// <summary>
                /// <para>The document content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AnalyticDB PostgreSQL vector database.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>process_info_19b9df4dc9ad4bf2b30eb2faa4a9a987.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The public URL of the query result image, valid for 2 hours by default.</para>
                /// <para>You can specify the validity period using the UrlExpiration input parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://viapi-customer-pop.oss-cn-shanghai.aliyuncs.com/b4d8_207196811002111319_570c0e199f03428f812ab21fcc00dd6a">http://viapi-customer-pop.oss-cn-shanghai.aliyuncs.com/b4d8_207196811002111319_570c0e199f03428f812ab21fcc00dd6a</a></para>
                /// </summary>
                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                /// <summary>
                /// <para>The unique ID of the vector data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>273e3fc7-8f56-4167-a1bb-d35d2f3b9043</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The metadata information loaded by the document loader.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;page&quot;:1}</para>
                /// </summary>
                [NameInMap("LoaderMetadata")]
                [Validation(Required=false)]
                public object LoaderMetadata { get; set; }

                /// <summary>
                /// <para>The metadata.</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// <para>The reranking score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("RerankScore")]
                [Validation(Required=false)]
                public double? RerankScore { get; set; }

                /// <summary>
                /// <para>The source of the retrieval result. 1 indicates vector retrieval, 2 indicates full-text retrieval, and 3 indicates dual-path recall.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RetrievalSource")]
                [Validation(Required=false)]
                public long? RetrievalSource { get; set; }

                /// <summary>
                /// <para>The similarity score of this data entry. The scoring algorithm is related to the algorithm specified when creating the index (l2/ip/cosine).</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <para>The vector data.</para>
                /// </summary>
                [NameInMap("Vector")]
                [Validation(Required=false)]
                public List<double?> Vector { get; set; }

            }

            /// <summary>
            /// <para>The relationship edge details.</para>
            /// </summary>
            [NameInMap("Relations")]
            [Validation(Required=false)]
            public List<string> Relations { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6B9E3255-4543-5B3B-9E00-6490CA64742B</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The API execution status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b>: Execution succeeded.</description></item>
            /// <item><description><b>fail</b>: Execution failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of tokens consumed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("Tokens")]
            [Validation(Required=false)]
            public long? Tokens { get; set; }

            /// <summary>
            /// <para>The tokens or items consumed by document understanding or embedding.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultUsage Usage { get; set; }
            public class ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultUsage : TeaModel {
                /// <summary>
                /// <para>The number of tokens used for vectorization.</para>
                /// <remarks>
                /// <para>A token is the smallest unit into which input text is divided. A token can be a word, a phrase, a punctuation mark, a character, etc.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("EmbeddingTokens")]
                [Validation(Required=false)]
                public long? EmbeddingTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: Succeeded.</description></item>
        /// <item><description><b>fail</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
