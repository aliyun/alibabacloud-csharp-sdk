// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunSearchGenerationRequest : TeaModel {
        /// <summary>
        /// <para>Context.</para>
        /// </summary>
        [NameInMap("AgentContext")]
        [Validation(Required=false)]
        public RunSearchGenerationRequestAgentContext AgentContext { get; set; }
        public class RunSearchGenerationRequestAgentContext : TeaModel {
            /// <summary>
            /// <para>Business context.</para>
            /// </summary>
            [NameInMap("BizContext")]
            [Validation(Required=false)]
            public RunSearchGenerationRequestAgentContextBizContext BizContext { get; set; }
            public class RunSearchGenerationRequestAgentContextBizContext : TeaModel {
                /// <summary>
                /// <para>Follow-up question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>您想了解关于xx的哪些信息？</para>
                /// </summary>
                [NameInMap("AskUser")]
                [Validation(Required=false)]
                public string AskUser { get; set; }

                /// <summary>
                /// <para>List of recommended keywords for follow-up questions.</para>
                /// </summary>
                [NameInMap("AskUserKeywords")]
                [Validation(Required=false)]
                public List<string> AskUserKeywords { get; set; }

                /// <summary>
                /// <para>Current step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>think</para>
                /// </summary>
                [NameInMap("CurrentStep")]
                [Validation(Required=false)]
                public string CurrentStep { get; set; }

                /// <summary>
                /// <para>User-provided or selected multimodal data.</para>
                /// </summary>
                [NameInMap("MultimodalMediaSelection")]
                [Validation(Required=false)]
                public RunSearchGenerationRequestAgentContextBizContextMultimodalMediaSelection MultimodalMediaSelection { get; set; }
                public class RunSearchGenerationRequestAgentContextBizContextMultimodalMediaSelection : TeaModel {
                    /// <summary>
                    /// <para>Unique identifier for the original session. Used to retrieve full results from that session. Required only for media asset search.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>原始会话唯一标识：搜索结果取这个会话中的全量，目前仅媒资搜索场景需要</para>
                    /// </summary>
                    [NameInMap("OriginalSessionId")]
                    [Validation(Required=false)]
                    public string OriginalSessionId { get; set; }

                    /// <summary>
                    /// <para>Used only for clustering. Pass ClusterGenerate when performing secondary clustering on cluster subtopics.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TextGenerate</para>
                    /// </summary>
                    [NameInMap("SearchModel")]
                    [Validation(Required=false)]
                    public string SearchModel { get; set; }

                    /// <summary>
                    /// <para>When SearchModel = ClusterGenerate, enter the topic name for the subtopic. Include quotation marks if the original value has them.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>分类1</para>
                    /// </summary>
                    [NameInMap("SearchModelDataValue")]
                    [Validation(Required=false)]
                    public string SearchModelDataValue { get; set; }

                    /// <summary>
                    /// <para>The type of referenced data source. Valid values: ‒ all: Retrieves the full data from historical sessions. This value is supported only in clustering scenarios. ‒ selected: Retrieves data from textSearchResult during generation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>all</para>
                    /// </summary>
                    [NameInMap("SelectionType")]
                    [Validation(Required=false)]
                    public string SelectionType { get; set; }

                    /// <summary>
                    /// <para>Unique identifier for the session used as reference during generation. Used for clustering in media asset search.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
                    /// </summary>
                    [NameInMap("SessionId")]
                    [Validation(Required=false)]
                    public string SessionId { get; set; }

                    /// <summary>
                    /// <para>Text search results.</para>
                    /// </summary>
                    [NameInMap("TextSearchResult")]
                    [Validation(Required=false)]
                    public RunSearchGenerationRequestAgentContextBizContextMultimodalMediaSelectionTextSearchResult TextSearchResult { get; set; }
                    public class RunSearchGenerationRequestAgentContextBizContextMultimodalMediaSelectionTextSearchResult : TeaModel {
                        /// <summary>
                        /// <para>List of text search results.</para>
                        /// </summary>
                        [NameInMap("SearchResult")]
                        [Validation(Required=false)]
                        public List<RunSearchGenerationRequestAgentContextBizContextMultimodalMediaSelectionTextSearchResultSearchResult> SearchResult { get; set; }
                        public class RunSearchGenerationRequestAgentContextBizContextMultimodalMediaSelectionTextSearchResultSearchResult : TeaModel {
                            /// <summary>
                            /// <para>Relevant chunks.</para>
                            /// </summary>
                            [NameInMap("Chunks")]
                            [Validation(Required=false)]
                            public List<string> Chunks { get; set; }

                            /// <summary>
                            /// <para>Content.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>文章内容</para>
                            /// </summary>
                            [NameInMap("Content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <para>Custom unique document ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>文档-自定义的唯一ID</para>
                            /// </summary>
                            [NameInMap("DocId")]
                            [Validation(Required=false)]
                            public string DocId { get; set; }

                            /// <summary>
                            /// <para>Internal unique document identifier.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>xxx</para>
                            /// </summary>
                            [NameInMap("DocUuid")]
                            [Validation(Required=false)]
                            public string DocUuid { get; set; }

                            /// <summary>
                            /// <para>Publication time.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2024-11-25 14:25:59</para>
                            /// </summary>
                            [NameInMap("PubTime")]
                            [Validation(Required=false)]
                            public string PubTime { get; set; }

                            /// <summary>
                            /// <para>Relevance score.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Score")]
                            [Validation(Required=false)]
                            public float? Score { get; set; }

                            /// <summary>
                            /// <para>Unique identifier for the search source. Same as searchSource.datasetName.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>QuarkCommonNews</para>
                            /// </summary>
                            [NameInMap("SearchSource")]
                            [Validation(Required=false)]
                            public string SearchSource { get; set; }

                            /// <summary>
                            /// <para>Name of the search source.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>互联网搜索</para>
                            /// </summary>
                            [NameInMap("SearchSourceName")]
                            [Validation(Required=false)]
                            public string SearchSourceName { get; set; }

                            /// <summary>
                            /// <para>Search source type. Same as searchSource.code.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SystemSearch</para>
                            /// </summary>
                            [NameInMap("SearchSourceType")]
                            [Validation(Required=false)]
                            public string SearchSourceType { get; set; }

                            /// <summary>
                            /// <para>Source.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>新华社</para>
                            /// </summary>
                            [NameInMap("Source")]
                            [Validation(Required=false)]
                            public string Source { get; set; }

                            /// <summary>
                            /// <para>Article summary.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>文章摘要</para>
                            /// </summary>
                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                            /// <summary>
                            /// <para>Title.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>文章标题</para>
                            /// </summary>
                            [NameInMap("Title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                            /// <summary>
                            /// <para>Article URL.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="https://www.example.com/aaa.docx">https://www.example.com/aaa.docx</a></para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>Next step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>generate</para>
                /// </summary>
                [NameInMap("NextStep")]
                [Validation(Required=false)]
                public string NextStep { get; set; }

                /// <summary>
                /// <para>Skip follow-up questions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SkipCurrentSupplement")]
                [Validation(Required=false)]
                public bool? SkipCurrentSupplement { get; set; }

                /// <summary>
                /// <para>Data type needed for reasoning: searchQuery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>searchQuery</para>
                /// </summary>
                [NameInMap("SupplementDataType")]
                [Validation(Required=false)]
                public string SupplementDataType { get; set; }

                /// <summary>
                /// <para>Specifies whether supplementation is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupplementEnable")]
                [Validation(Required=false)]
                public bool? SupplementEnable { get; set; }

                /// <summary>
                /// <para>User feedback to follow-up questions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>地点</para>
                /// </summary>
                [NameInMap("UserBack")]
                [Validation(Required=false)]
                public string UserBack { get; set; }

                /// <summary>
                /// <para>List of keywords from user feedback to follow-up questions.</para>
                /// </summary>
                [NameInMap("UserBackKeywords")]
                [Validation(Required=false)]
                public List<string> UserBackKeywords { get; set; }

            }

        }

        /// <summary>
        /// <para>Session configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ChatConfig")]
        [Validation(Required=false)]
        public RunSearchGenerationRequestChatConfig ChatConfig { get; set; }
        public class RunSearchGenerationRequestChatConfig : TeaModel {
            /// <summary>
            /// <para>Enable deep thinking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableThinking")]
            [Validation(Required=false)]
            public bool? EnableThinking { get; set; }

            /// <summary>
            /// <para>List of generation options to skip.</para>
            /// </summary>
            [NameInMap("ExcludeGenerateOptions")]
            [Validation(Required=false)]
            public List<string> ExcludeGenerateOptions { get; set; }

            /// <summary>
            /// <para>Detailedness of the response:</para>
            /// <list type="bullet">
            /// <item><description><para>concise: Concise (default)</para>
            /// </description></item>
            /// <item><description><para>enhance: Enhanced</para>
            /// </description></item>
            /// <item><description><para>free: Free-form</para>
            /// </description></item>
            /// <item><description><para>deepResearch: Research-level</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>concise</para>
            /// </summary>
            [NameInMap("GenerateLevel")]
            [Validation(Required=false)]
            public string GenerateLevel { get; set; }

            /// <summary>
            /// <para>Generation technology:</para>
            /// <list type="bullet">
            /// <item><description><para>copilotReference: Q\&amp;A-style search</para>
            /// </description></item>
            /// <item><description><para>copilotPrecise: Pure search</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>copilotReference</para>
            /// </summary>
            [NameInMap("GenerateTechnology")]
            [Validation(Required=false)]
            public string GenerateTechnology { get; set; }

            /// <summary>
            /// <para>Plain-text prompt template for Q\&amp;A-style search and summary generation. Must include variables {query} and {content}. Example:</para>
            /// <pre><code class="language-text"># Role
            /// You are an expert article retrieval and Q&amp;A assistant.
            /// 
            /// # Goal
            /// Answer or explain the user\\&quot;s question &quot;{query}&quot; using the retrieved articles.
            /// 
            /// # Constraints
            /// - Filter by knowledge date if the question mentions a specific date.
            /// - Structure responses clearly.
            /// - Keep responses concise.
            /// - Do not use external data or fabricate answers.
            /// - If unable to answer, respond in the appropriate language:
            ///   - Chinese: &quot;Unable to answer based on known information.&quot;
            ///   - English: &quot;Unable to answer based on the known information.&quot;
            /// 
            /// # Input
            /// ## Retrieved articles
            /// {content}
            /// </c></pre>
            /// 
            /// <b>Example:</b>
            /// <h1>角色</h1>
            /// <para>你是一个专业的文章检索和问答专家，擅长文章检索和回答用户问题。</para>
            /// <h1>任务目标</h1>
            /// <para>请你根据检索到的相关文章，回答或表述用户问题“{query}”。</para>
            /// <h1>任务限制</h1>
            /// <list type="bullet">
            /// <item><description>如果用户问题中提到具体日期，请考虑知识日期做筛选。</description></item>
            /// <item><description>生成内容结构条理。</description></item>
            /// <item><description>生成内容尽量精简。</description></item>
            /// <item><description>不要使用其他数据，不要杜撰。</description></item>
            /// <item><description>如果不能回答用户问题，请输出对应语言的拒识文案:<list type="bullet">
            /// <item><description>中文：&quot;根据已知信息无法回答。&quot;</description></item>
            /// <item><description>英文：&quot;Unable to answer based on the known information.&quot;</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <h1>输入数据</h1>
            /// <h2>检索到的相关文章</h2>
            /// <para>{content}</para>
            /// </summary>
            [NameInMap("ModelCustomPromptTemplate")]
            [Validation(Required=false)]
            public string ModelCustomPromptTemplate { get; set; }

            /// <summary>
            /// <para>Plain-text prompt template for Q\&amp;A-style search and summary generation. Must include variables {query} and {content}. Example:</para>
            /// <pre><code class="language-text"># Role
            /// You are an expert article retrieval and Q&amp;A assistant.
            /// 
            /// # Goal
            /// Answer or explain the user\\&quot;s question &quot;{query}&quot; using the retrieved articles and images.
            /// 
            /// # Constraints
            /// - Filter by knowledge date if the question mentions a specific date.
            /// - Structure responses clearly.
            /// - Keep responses concise.
            /// - Ignore article content if image content fully answers the question.
            /// - Do not use external data or fabricate answers.
            /// - If unable to answer, respond in the appropriate language:
            ///     - Chinese: &quot;Unable to answer based on known information.&quot;
            ///     - English: &quot;Unable to answer based on the known information.&quot;
            /// 
            /// # Input
            /// ## Retrieved articles
            /// {content}
            /// </c></pre>
            /// 
            /// <b>Example:</b>
            /// <h1>角色</h1>
            /// <para>你是一个专业的文章检索和问答专家，擅长文章检索和回答用户问题。</para>
            /// <h1>任务目标</h1>
            /// <para>请你根据检索到的相关文章和图片，回答或表述用户问题“{query}”。</para>
            /// <h1>任务限制</h1>
            /// <list type="bullet">
            /// <item><description>如果用户问题中提到具体日期，请考虑知识日期做筛选。</description></item>
            /// <item><description>生成内容结构条理。</description></item>
            /// <item><description>生成内容尽量精简。</description></item>
            /// <item><description>如果图片内容可以回答，可以忽略文章内容。</description></item>
            /// <item><description>不要使用其他数据，不要杜撰。</description></item>
            /// <item><description>如果不能回答用户问题，请输出对应语言的拒识文案:<list type="bullet">
            /// <item><description>中文：&quot;根据已知信息无法回答。&quot;</description></item>
            /// <item><description>英文：&quot;Unable to answer based on the known information.&quot;</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <h1>输入数据</h1>
            /// <h2>检索到的相关文章</h2>
            /// <para>{content}</para>
            /// </summary>
            [NameInMap("ModelCustomVlPromptTemplate")]
            [Validation(Required=false)]
            public string ModelCustomVlPromptTemplate { get; set; }

            /// <summary>
            /// <para>List of search types.</para>
            /// </summary>
            [NameInMap("SearchModels")]
            [Validation(Required=false)]
            public List<string> SearchModels { get; set; }

            /// <summary>
            /// <para>Search parameters.</para>
            /// </summary>
            [NameInMap("SearchParam")]
            [Validation(Required=false)]
            public RunSearchGenerationRequestChatConfigSearchParam SearchParam { get; set; }
            public class RunSearchGenerationRequestChatConfigSearchParam : TeaModel {
                /// <summary>
                /// <para>Unique category identifier.</para>
                /// </summary>
                [NameInMap("CategoryUuids")]
                [Validation(Required=false)]
                public List<string> CategoryUuids { get; set; }

                /// <summary>
                /// <para>End creation time, in UNIX timestamp format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111111111111</para>
                /// </summary>
                [NameInMap("CreateTimeEnd")]
                [Validation(Required=false)]
                public long? CreateTimeEnd { get; set; }

                /// <summary>
                /// <para>Start creation time, in UNIX timestamp format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111111111111</para>
                /// </summary>
                [NameInMap("CreateTimeStart")]
                [Validation(Required=false)]
                public long? CreateTimeStart { get; set; }

                /// <summary>
                /// <para>Array of document IDs.</para>
                /// </summary>
                [NameInMap("DocIds")]
                [Validation(Required=false)]
                public List<string> DocIds { get; set; }

                /// <summary>
                /// <para>Unique document identifier.</para>
                /// </summary>
                [NameInMap("DocUuids")]
                [Validation(Required=false)]
                public List<string> DocUuids { get; set; }

                /// <summary>
                /// <para>End time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1725983999999</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>Extension field 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Extend1")]
                [Validation(Required=false)]
                public string Extend1 { get; set; }

                /// <summary>
                /// <para>Extension field 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Extend2")]
                [Validation(Required=false)]
                public string Extend2 { get; set; }

                /// <summary>
                /// <para>Extension field 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Extend3")]
                [Validation(Required=false)]
                public string Extend3 { get; set; }

                /// <summary>
                /// <para>Search scope list.</para>
                /// </summary>
                [NameInMap("MultimodalSearchTypes")]
                [Validation(Required=false)]
                public List<string> MultimodalSearchTypes { get; set; }

                /// <summary>
                /// <para>Voice search threshold: Applies only to custom data sources (range: 0 to 1).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.66</para>
                /// </summary>
                [NameInMap("SearchAudioMinScore")]
                [Validation(Required=false)]
                public double? SearchAudioMinScore { get; set; }

                /// <summary>
                /// <para>Image search threshold: Applies only to custom data sources (range: 0 to 1).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.66</para>
                /// </summary>
                [NameInMap("SearchImageMinScore")]
                [Validation(Required=false)]
                public double? SearchImageMinScore { get; set; }

                /// <summary>
                /// <para>List of search sources.</para>
                /// </summary>
                [NameInMap("SearchSources")]
                [Validation(Required=false)]
                public List<RunSearchGenerationRequestChatConfigSearchParamSearchSources> SearchSources { get; set; }
                public class RunSearchGenerationRequestChatConfigSearchParamSearchSources : TeaModel {
                    /// <summary>
                    /// <para>Search source type:</para>
                    /// <list type="bullet">
                    /// <item><description><para>SystemSearch: Built-in system search</para>
                    /// </description></item>
                    /// <item><description><para>CustomSemanticSearch: Custom semantic index search</para>
                    /// </description></item>
                    /// <item><description><para>ThirdSearch: Third-party API search</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SystemSearch</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>Unique identifier for the search source: matches the dataset name shown in the console, such as 4cb0eda3fad841758262dbe8d61191.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>QuarkCommonNews</para>
                    /// </summary>
                    [NameInMap("DatasetName")]
                    [Validation(Required=false)]
                    public string DatasetName { get; set; }

                }

                /// <summary>
                /// <para>Text search threshold: Applies only to custom data sources (range: 0 to 1).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.66</para>
                /// </summary>
                [NameInMap("SearchTextMinScore")]
                [Validation(Required=false)]
                public double? SearchTextMinScore { get; set; }

                /// <summary>
                /// <para>Video search threshold: Applies only to custom data sources (range: 0 to 1).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.66</para>
                /// </summary>
                [NameInMap("SearchVideoMinScore")]
                [Validation(Required=false)]
                public double? SearchVideoMinScore { get; set; }

                /// <summary>
                /// <para>Start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1725983999999</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>Tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

            }

        }

        /// <summary>
        /// <para>Image URL. Used for image search and hybrid text-and-image (prompt) search generation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxx">http://xxxx</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>Model ID:</para>
        /// <list type="bullet">
        /// <item><description><para>quanmiao-max: Quanmiao-Max</para>
        /// </description></item>
        /// <item><description><para>quanmiao-plus: Quanmiao-Plus</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>quanmiao-max</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>Original session identifier. Usually empty. When non-empty, it indicates that the current conversation is based on the referenced session. The system loads parameters and search results from that session and replaces the generated result. Use this for re-generation, changing data sources, or adding new agents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("OriginalSessionId")]
        [Validation(Required=false)]
        public string OriginalSessionId { get; set; }

        /// <summary>
        /// <para>Search query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州亚运会吉祥物是什么</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>Unique identifier for the session task.</para>
        /// <remarks>
        /// <para>By default, you do not need to provide a TaskId. The system generates one automatically. If you specify the same TaskId in subsequent requests, those tasks are grouped into the same conversation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7AA2AE16-D873-5C5F-9708-15396C382EB1</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>ID of the Alibaba Cloud Model Studio workspace. To learn how to obtain this ID, see <a href="https://help.aliyun.com/document_detail/2782167.html">How to use workspaces</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
