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
            /// <para>The text content generated in real time.</para>
            /// </summary>
            [NameInMap("Choices")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoices> Choices { get; set; }
            public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoices : TeaModel {
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
                /// <para>The index of the reply.</para>
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
                public ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessage Message { get; set; }
                public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessage : TeaModel {
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
                    /// <para>The model chain-of-thought content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Logical deduction process</para>
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
                    /// <para>The tool invoke response.</para>
                    /// </summary>
                    [NameInMap("ToolCalls")]
                    [Validation(Required=false)]
                    public List<ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessageToolCalls> ToolCalls { get; set; }
                    public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessageToolCalls : TeaModel {
                        /// <summary>
                        /// <para>The information about the called function.</para>
                        /// </summary>
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessageToolCallsFunction Function { get; set; }
                        public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionChoicesMessageToolCallsFunction : TeaModel {
                            /// <summary>
                            /// <para>The arguments of the called function.</para>
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
                        /// <para>The index of this tool in the Input request parameter, starting from 0.</para>
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
            public ChatWithKnowledgeBaseStreamResponseBodyChatCompletionUsage Usage { get; set; }
            public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionUsage : TeaModel {
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
                public ChatWithKnowledgeBaseStreamResponseBodyChatCompletionUsagePromptTokensDetails PromptTokensDetails { get; set; }
                public class ChatWithKnowledgeBaseStreamResponseBodyChatCompletionUsagePromptTokensDetails : TeaModel {
                    /// <summary>
                    /// <para>The number of cache hit tokens.</para>
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
        public ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResult MultiCollectionRecallResult { get; set; }
        public class ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResult : TeaModel {
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
            public List<ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultMatches> Matches { get; set; }
            public class ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultMatches : TeaModel {
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
                /// <para>a14b0221-e3f2-4cf2-96cd-b3c293510770.jpg</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The public URL of the query result image. The default validity period is 2 hours. You can specify the validity period by using the UrlExpiration request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://dailyshort-sh.oss-cn-shanghai.aliyuncs.com/vod-8efba5/f06147795c6c71f080605420848d0302/0ca34d5743a84bf7c68f489a60715dac-ld.mp4">http://dailyshort-sh.oss-cn-shanghai.aliyuncs.com/vod-8efba5/f06147795c6c71f080605420848d0302/0ca34d5743a84bf7c68f489a60715dac-ld.mp4</a></para>
                /// </summary>
                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                /// <summary>
                /// <para>The unique ID of this vector data entry.</para>
                /// <remarks>
                /// <para>If this parameter is empty, the ID is automatically generated by the database uuidgen function. If this parameter is not empty and conflicts with an existing ID in the database, the value in the database is updated with the data from the API.</para>
                /// </remarks>
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
                /// <para>{&quot;update_time&quot;:&quot;1754446789199&quot;,&quot;is_publish&quot;:&quot;1&quot;}</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// <para>The reranking score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.12</para>
                /// </summary>
                [NameInMap("RerankScore")]
                [Validation(Required=false)]
                public double? RerankScore { get; set; }

                /// <summary>
                /// <para>The source of the retrieve result. A value of 1 indicates AISearch. A value of 2 indicates full-text index. A value of 3 indicates dual-channel recall.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RetrievalSource")]
                [Validation(Required=false)]
                public long? RetrievalSource { get; set; }

                /// <summary>
                /// <para>The similarity score of this data entry. The scoring algorithm is related to the algorithm specified when the index is created, such as (l2/ip/cosine).</para>
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
            /// <para>The relation name.</para>
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
            /// <para>The API execution status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b>: The execution is successful.</description></item>
            /// <item><description><b>fail</b>: The execution fails.</description></item>
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
            /// <para>The number of tokens or entries consumed for document understanding or embedding.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultUsage Usage { get; set; }
            public class ChatWithKnowledgeBaseStreamResponseBodyMultiCollectionRecallResultUsage : TeaModel {
                /// <summary>
                /// <para>The number of tokens used for vectorization.</para>
                /// <remarks>
                /// <para>A token is the smallest unit into which the input text is divided. A token can be a word, a phrase, a punctuation mark, or a character.</para>
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
