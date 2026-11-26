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
            /// <para>The text content generated in real time.</para>
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
                /// <para>The reply index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

                /// <summary>
                /// <para>The response message from the large language model.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessage Message { get; set; }
                public class ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessage : TeaModel {
                    /// <summary>
                    /// <para>The document content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The weather in Hangzhou is sunny</para>
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
                    /// <para>The message role. Valid values:</para>
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
                    /// <para>The list of tool calling invoke responses.</para>
                    /// </summary>
                    [NameInMap("ToolCalls")]
                    [Validation(Required=false)]
                    public List<ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessageToolCalls> ToolCalls { get; set; }
                    public class ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessageToolCalls : TeaModel {
                        /// <summary>
                        /// <para>The information about the called function.</para>
                        /// </summary>
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessageToolCallsFunction Function { get; set; }
                        public class ChatWithKnowledgeBaseResponseBodyChatCompletionChoicesMessageToolCallsFunction : TeaModel {
                            /// <summary>
                            /// <para>The arguments for the called function.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;city&quot;:&quot;hangzhou&quot;}</para>
                            /// </summary>
                            [NameInMap("Arguments")]
                            [Validation(Required=false)]
                            public string Arguments { get; set; }

                            /// <summary>
                            /// <para>The name of the called function.</para>
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
                        /// <para>The ordinal number of the tool calling invoke.</para>
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
            /// <para>The name of the model used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The number of tokens used for the large language model output.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseResponseBodyChatCompletionUsage Usage { get; set; }
            public class ChatWithKnowledgeBaseResponseBodyChatCompletionUsage : TeaModel {
                /// <summary>
                /// <para>The number of tokens consumed to generate the content.</para>
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
                /// <para>The details of the prompt tokens.</para>
                /// </summary>
                [NameInMap("PromptTokensDetails")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseResponseBodyChatCompletionUsagePromptTokensDetails PromptTokensDetails { get; set; }
                public class ChatWithKnowledgeBaseResponseBodyChatCompletionUsagePromptTokensDetails : TeaModel {
                    /// <summary>
                    /// <para>The number of cached tokens.</para>
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
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The recall information from multiple knowledge bases.</para>
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
            /// <para>The recalled items.</para>
            /// </summary>
            [NameInMap("Matches")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultMatches> Matches { get; set; }
            public class ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultMatches : TeaModel {
                /// <summary>
                /// <para>The document content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADBPG vector database</para>
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
                /// <para>The public URL of the query result image. The default validity period is 2 hours. You can specify the validity period by using the UrlExpiration request parameter.</para>
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
                /// <para>The metadata generated when the document loader loads the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;page&quot;:1}</para>
                /// </summary>
                [NameInMap("LoaderMetadata")]
                [Validation(Required=false)]
                public object LoaderMetadata { get; set; }

                /// <summary>
                /// <para>The metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;update_time&quot;:1749348435357,&quot;title&quot;:&quot;example&quot;}</para>
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
                /// <para>The source of the retrieve result. A value of 1 indicates AISearch. A value of 2 indicates full-text index. A value of 3 indicates dual-channel recall.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RetrievalSource")]
                [Validation(Required=false)]
                public long? RetrievalSource { get; set; }

                /// <summary>
                /// <para>The similarity score of this data entry. The scoring algorithm depends on the algorithm specified during index creation, such as l2, ip, or cosine.</para>
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
            /// <para>The file name.</para>
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
            /// <item><description><b>success</b>: The execution was successful.</description></item>
            /// <item><description><b>fail</b>: The execution failed.</description></item>
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
            /// <para>The number of tokens or items consumed for document understanding or embedding.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultUsage Usage { get; set; }
            public class ChatWithKnowledgeBaseResponseBodyMultiCollectionRecallResultUsage : TeaModel {
                /// <summary>
                /// <para>The number of tokens used for vectorization.</para>
                /// <remarks>
                /// <para>A token is the smallest unit into which input text is divided. A token can be a word, a phrase, a punctuation mark, or a character.</para>
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
        /// <item><description><b>success</b>: Successful.</description></item>
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
