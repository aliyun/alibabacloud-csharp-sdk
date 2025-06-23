// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunSearchGenerationRequest : TeaModel {
        [NameInMap("AgentContext")]
        [Validation(Required=false)]
        public RunSearchGenerationRequestAgentContext AgentContext { get; set; }
        public class RunSearchGenerationRequestAgentContext : TeaModel {
            [NameInMap("BizContext")]
            [Validation(Required=false)]
            public RunSearchGenerationRequestAgentContextBizContext BizContext { get; set; }
            public class RunSearchGenerationRequestAgentContextBizContext : TeaModel {
                [NameInMap("AskUser")]
                [Validation(Required=false)]
                public string AskUser { get; set; }

                [NameInMap("AskUserKeywords")]
                [Validation(Required=false)]
                public List<string> AskUserKeywords { get; set; }

                [NameInMap("CurrentStep")]
                [Validation(Required=false)]
                public string CurrentStep { get; set; }

                [NameInMap("MultimodalMediaSelection")]
                [Validation(Required=false)]
                public RunSearchGenerationRequestAgentContextBizContextMultimodalMediaSelection MultimodalMediaSelection { get; set; }
                public class RunSearchGenerationRequestAgentContextBizContextMultimodalMediaSelection : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>原始会话唯一标识：搜索结果取这个会话中的全量，目前仅媒资搜索场景需要</para>
                    /// </summary>
                    [NameInMap("OriginalSessionId")]
                    [Validation(Required=false)]
                    public string OriginalSessionId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TextGenerate</para>
                    /// </summary>
                    [NameInMap("SearchModel")]
                    [Validation(Required=false)]
                    public string SearchModel { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>分类1</para>
                    /// </summary>
                    [NameInMap("SearchModelDataValue")]
                    [Validation(Required=false)]
                    public string SearchModelDataValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>all</para>
                    /// </summary>
                    [NameInMap("SelectionType")]
                    [Validation(Required=false)]
                    public string SelectionType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
                    /// </summary>
                    [NameInMap("SessionId")]
                    [Validation(Required=false)]
                    public string SessionId { get; set; }

                    [NameInMap("TextSearchResult")]
                    [Validation(Required=false)]
                    public RunSearchGenerationRequestAgentContextBizContextMultimodalMediaSelectionTextSearchResult TextSearchResult { get; set; }
                    public class RunSearchGenerationRequestAgentContextBizContextMultimodalMediaSelectionTextSearchResult : TeaModel {
                        [NameInMap("SearchResult")]
                        [Validation(Required=false)]
                        public List<RunSearchGenerationRequestAgentContextBizContextMultimodalMediaSelectionTextSearchResultSearchResult> SearchResult { get; set; }
                        public class RunSearchGenerationRequestAgentContextBizContextMultimodalMediaSelectionTextSearchResultSearchResult : TeaModel {
                            [NameInMap("Chunks")]
                            [Validation(Required=false)]
                            public List<string> Chunks { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>文章内容</para>
                            /// </summary>
                            [NameInMap("Content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>文档-自定义的唯一ID</para>
                            /// </summary>
                            [NameInMap("DocId")]
                            [Validation(Required=false)]
                            public string DocId { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>xxx</para>
                            /// </summary>
                            [NameInMap("DocUuid")]
                            [Validation(Required=false)]
                            public string DocUuid { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2024-11-25 14:25:59</para>
                            /// </summary>
                            [NameInMap("PubTime")]
                            [Validation(Required=false)]
                            public string PubTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Score")]
                            [Validation(Required=false)]
                            public float? Score { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>QuarkCommonNews</para>
                            /// </summary>
                            [NameInMap("SearchSource")]
                            [Validation(Required=false)]
                            public string SearchSource { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>互联网搜索</para>
                            /// </summary>
                            [NameInMap("SearchSourceName")]
                            [Validation(Required=false)]
                            public string SearchSourceName { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>SystemSearch</para>
                            /// </summary>
                            [NameInMap("SearchSourceType")]
                            [Validation(Required=false)]
                            public string SearchSourceType { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>新华社</para>
                            /// </summary>
                            [NameInMap("Source")]
                            [Validation(Required=false)]
                            public string Source { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>文章摘要</para>
                            /// </summary>
                            [NameInMap("Summary")]
                            [Validation(Required=false)]
                            public string Summary { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>文章标题</para>
                            /// </summary>
                            [NameInMap("Title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para><a href="https://www.example.com/aaa.docx">https://www.example.com/aaa.docx</a></para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                }

                [NameInMap("NextStep")]
                [Validation(Required=false)]
                public string NextStep { get; set; }

                [NameInMap("SkipCurrentSupplement")]
                [Validation(Required=false)]
                public bool? SkipCurrentSupplement { get; set; }

                [NameInMap("SupplementDataType")]
                [Validation(Required=false)]
                public string SupplementDataType { get; set; }

                [NameInMap("SupplementEnable")]
                [Validation(Required=false)]
                public bool? SupplementEnable { get; set; }

                [NameInMap("UserBack")]
                [Validation(Required=false)]
                public string UserBack { get; set; }

                [NameInMap("UserBackKeywords")]
                [Validation(Required=false)]
                public List<string> UserBackKeywords { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ChatConfig")]
        [Validation(Required=false)]
        public RunSearchGenerationRequestChatConfig ChatConfig { get; set; }
        public class RunSearchGenerationRequestChatConfig : TeaModel {
            [NameInMap("EnableThinking")]
            [Validation(Required=false)]
            public bool? EnableThinking { get; set; }

            [NameInMap("ExcludeGenerateOptions")]
            [Validation(Required=false)]
            public List<string> ExcludeGenerateOptions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>concise</para>
            /// </summary>
            [NameInMap("GenerateLevel")]
            [Validation(Required=false)]
            public string GenerateLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>copilotPrecise</para>
            /// </summary>
            [NameInMap("GenerateTechnology")]
            [Validation(Required=false)]
            public string GenerateTechnology { get; set; }

            [NameInMap("SearchModels")]
            [Validation(Required=false)]
            public List<string> SearchModels { get; set; }

            [NameInMap("SearchParam")]
            [Validation(Required=false)]
            public RunSearchGenerationRequestChatConfigSearchParam SearchParam { get; set; }
            public class RunSearchGenerationRequestChatConfigSearchParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1725983999999</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("MultimodalSearchTypes")]
                [Validation(Required=false)]
                public List<string> MultimodalSearchTypes { get; set; }

                [NameInMap("SearchSources")]
                [Validation(Required=false)]
                public List<RunSearchGenerationRequestChatConfigSearchParamSearchSources> SearchSources { get; set; }
                public class RunSearchGenerationRequestChatConfigSearchParamSearchSources : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SystemSearch</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>QuarkCommonNews</para>
                    /// </summary>
                    [NameInMap("DatasetName")]
                    [Validation(Required=false)]
                    public string DatasetName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1725983999999</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-max-latest</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("OriginalSessionId")]
        [Validation(Required=false)]
        public string OriginalSessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7AA2AE16-D873-5C5F-9708-15396C382EB1</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
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
