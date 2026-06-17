// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ChatWithKnowledgeBaseStreamResponseBody : TeaModel {
        /// <summary>
        /// <para>The model response.</para>
        /// </summary>
        [NameInMap("ChatCompletion")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseStreamResponseBodyChatCompletion ChatCompletion { get; set; }
        public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletion : TeaModel {
            /// <summary>
            /// <para>The streaming output content.</para>
            /// </summary>
            [NameInMap("Choices")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoices> Choices { get; set; }
            public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoices : TeaModel {
                /// <summary>
                /// <para>The reason the model stopped generating output.</para>
                /// 
                /// <b>Example:</b>
                /// <para>finish</para>
                /// </summary>
                [NameInMap("FinishReason")]
                [Validation(Required=false)]
                public string FinishReason { get; set; }

                /// <summary>
                /// <para>The index of the choice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

                /// <summary>
                /// <para>The response from the large language model (LLM).</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessage Message { get; set; }
                public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessage : TeaModel {
                    /// <summary>
                    /// <para>The message content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The weather in Hangzhou is sunny.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The model\&quot;s chain of thought (CoT) content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Logical reasoning process</para>
                    /// </summary>
                    [NameInMap("ReasoningContent")]
                    [Validation(Required=false)]
                    public string ReasoningContent { get; set; }

                    /// <summary>
                    /// <para>The role of the message author. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>system</c></para>
                    /// </description></item>
                    /// <item><description><para><c>user</c></para>
                    /// </description></item>
                    /// <item><description><para><c>assistant</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <para>The tool call responses.</para>
                    /// </summary>
                    [NameInMap("ToolCalls")]
                    [Validation(Required=false)]
                    public List<ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessageToolCalls> ToolCalls { get; set; }
                    public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessageToolCalls : TeaModel {
                        /// <summary>
                        /// <para>Details of the function that the model wants to call.</para>
                        /// </summary>
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessageToolCallsFunction Function { get; set; }
                        public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessageToolCallsFunction : TeaModel {
                            /// <summary>
                            /// <para>The arguments for the function call, generated by the model in JSON format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;city&quot;:&quot;hangzhou&quot;}</para>
                            /// </summary>
                            [NameInMap("Arguments")]
                            [Validation(Required=false)]
                            public string Arguments { get; set; }

                            /// <summary>
                            /// <para>The name of the function to call.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>&quot;get_weather&quot;</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The ID of the tool call.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>&quot;chatcmpl-c1bebafa-cc48-44e2-88c6-1a3572952f8e&quot;</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The index of the tool in the <c>Input</c> parameter of the request, starting from 0.</para>
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
            /// <para>The creation time, in Unix timestamp format.</para>
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
            /// <para>The token usage statistics for the completion.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseStreamResponseBodyChatCompletionUsage Usage { get; set; }
            public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionUsage : TeaModel {
                /// <summary>
                /// <para>The number of tokens in the generated response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("CompletionTokens")]
                [Validation(Required=false)]
                public long? CompletionTokens { get; set; }

                /// <summary>
                /// <para>The number of tokens in the input prompt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("PromptTokens")]
                [Validation(Required=false)]
                public long? PromptTokens { get; set; }

                /// <summary>
                /// <para>Details about the prompt token usage.</para>
                /// </summary>
                [NameInMap("PromptTokensDetails")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseStreamResponseBodyChatCompletionUsagePromptTokensDetails PromptTokensDetails { get; set; }
                public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionUsagePromptTokensDetails : TeaModel {
                    /// <summary>
                    /// <para>The number of prompt tokens served from the cache.</para>
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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The retrieval results from multiple knowledge bases.</para>
        /// </summary>
        [NameInMap("MultiCollectionRecallResult")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResult MultiCollectionRecallResult { get; set; }
        public class ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResult : TeaModel {
            /// <summary>
            /// <para>A list of retrieved entities.</para>
            /// </summary>
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<string> Entities { get; set; }

            /// <summary>
            /// <para>A list of retrieved matches.</para>
            /// </summary>
            [NameInMap("Matches")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultMatches> Matches { get; set; }
            public class ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultMatches : TeaModel {
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
                /// <para>a14b0221-e3f2-4cf2-96cd-b3c293510770.jpg</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The public URL of the retrieved image. By default, the URL is valid for 2 hours.</para>
                /// <para>You can use the <c>UrlExpiration</c> parameter to specify a custom validity period.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://dailyshort-sh.oss-cn-shanghai.aliyuncs.com/vod-8efba5/f06147795c6c71f080605420848d0302/0ca34d5743a84bf7c68f489a60715dac-ld.mp4">http://dailyshort-sh.oss-cn-shanghai.aliyuncs.com/vod-8efba5/f06147795c6c71f080605420848d0302/0ca34d5743a84bf7c68f489a60715dac-ld.mp4</a></para>
                /// </summary>
                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                /// <summary>
                /// <para>The unique ID of the vector record.</para>
                /// <remarks>
                /// <para>If this parameter is left empty, the database automatically generates a UUID. If you provide an ID that conflicts with an existing one, the existing record is updated with the data from the request.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>273e3fc7-8f56-4167-a1bb-d35d2f3b9043</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Metadata from the document loader, captured during document ingestion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;page&quot;:1}</para>
                /// </summary>
                [NameInMap("LoaderMetadata")]
                [Validation(Required=false)]
                public object LoaderMetadata { get; set; }

                /// <summary>
                /// <para>The user-defined metadata.</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// <para>The rerank score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.12</para>
                /// </summary>
                [NameInMap("RerankScore")]
                [Validation(Required=false)]
                public double? RerankScore { get; set; }

                /// <summary>
                /// <para>The source of the match. <c>1</c> indicates vector search, <c>2</c> indicates full-text search, and <c>3</c> indicates hybrid recall.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.12</para>
                /// </summary>
                [NameInMap("RetrievalSource")]
                [Validation(Required=false)]
                public long? RetrievalSource { get; set; }

                /// <summary>
                /// <para>The similarity score. The score is calculated based on the distance metric specified when the index was created (<c>l2/ip/cosine</c>).</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
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
            /// <para>A list of relationship edges.</para>
            /// </summary>
            [NameInMap("Relations")]
            [Validation(Required=false)]
            public List<string> Relations { get; set; }

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
            /// <para>The status of the API call. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>success</b>: The call succeeded.</para>
            /// </description></item>
            /// <item><description><para><b>fail</b>: The call failed.</para>
            /// </description></item>
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
            /// <para>The number of tokens consumed for embedding.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultUsage Usage { get; set; }
            public class ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultUsage : TeaModel {
                /// <summary>
                /// <para>The number of tokens used for embedding.</para>
                /// <remarks>
                /// <para>A token is the smallest unit created by splitting the input text. A token can be a unit such as a word, a phrase, a punctuation mark, or a character.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>158</para>
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
        /// <para>The status of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>success</b>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>fail</b>: The request failed.</para>
        /// </description></item>
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
