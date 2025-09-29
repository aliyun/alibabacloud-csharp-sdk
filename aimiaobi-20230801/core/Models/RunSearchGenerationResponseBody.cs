// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunSearchGenerationResponseBody : TeaModel {
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunSearchGenerationResponseBodyHeader Header { get; set; }
        public class RunSearchGenerationResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AccessForbid</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-failed</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("OriginSessionId")]
            [Validation(Required=false)]
            public string OriginSessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResponseTime")]
            [Validation(Required=false)]
            public long? ResponseTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>x</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>x</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunSearchGenerationResponseBodyPayload Payload { get; set; }
        public class RunSearchGenerationResponseBodyPayload : TeaModel {
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunSearchGenerationResponseBodyPayloadOutput Output { get; set; }
            public class RunSearchGenerationResponseBodyPayloadOutput : TeaModel {
                [NameInMap("AgentContext")]
                [Validation(Required=false)]
                public RunSearchGenerationResponseBodyPayloadOutputAgentContext AgentContext { get; set; }
                public class RunSearchGenerationResponseBodyPayloadOutputAgentContext : TeaModel {
                    [NameInMap("BizContext")]
                    [Validation(Required=false)]
                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContext BizContext { get; set; }
                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContext : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>您想了解关于xx的哪些信息？</para>
                        /// </summary>
                        [NameInMap("AskUser")]
                        [Validation(Required=false)]
                        public string AskUser { get; set; }

                        [NameInMap("AskUserKeywords")]
                        [Validation(Required=false)]
                        public List<string> AskUserKeywords { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>start</para>
                        /// </summary>
                        [NameInMap("CurrentStep")]
                        [Validation(Required=false)]
                        public string CurrentStep { get; set; }

                        [NameInMap("GeneratedContent")]
                        [Validation(Required=false)]
                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContent GeneratedContent { get; set; }
                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContent : TeaModel {
                            [NameInMap("AudioSearchResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResult AudioSearchResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResult : TeaModel {
                                [NameInMap("SearchResult")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResultSearchResult> SearchResult { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResultSearchResult : TeaModel {
                                    [NameInMap("Article")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResultSearchResultArticle Article { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResultSearchResultArticle : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocId")]
                                        [Validation(Required=false)]
                                        public string DocId { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocUuid")]
                                        [Validation(Required=false)]
                                        public string DocUuid { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("SearchSourceName")]
                                        [Validation(Required=false)]
                                        public string SearchSourceName { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xxx</para>
                                        /// </summary>
                                        [NameInMap("Summary")]
                                        [Validation(Required=false)]
                                        public string Summary { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Title")]
                                        [Validation(Required=false)]
                                        public string Title { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para><a href="http://xxx">http://xxx</a></para>
                                        /// </summary>
                                        [NameInMap("Url")]
                                        [Validation(Required=false)]
                                        public string Url { get; set; }

                                    }

                                    [NameInMap("ClipInfos")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResultSearchResultClipInfos> ClipInfos { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResultSearchResultClipInfos : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("From")]
                                        [Validation(Required=false)]
                                        public double? From { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>0.9</para>
                                        /// </summary>
                                        [NameInMap("Score")]
                                        [Validation(Required=false)]
                                        public double? Score { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Text")]
                                        [Validation(Required=false)]
                                        public string Text { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>2</para>
                                        /// </summary>
                                        [NameInMap("To")]
                                        [Validation(Required=false)]
                                        public double? To { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>asr</para>
                                        /// </summary>
                                        [NameInMap("Type")]
                                        [Validation(Required=false)]
                                        public string Type { get; set; }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para><a href="http://xxx">http://xxx</a></para>
                                    /// </summary>
                                    [NameInMap("FileUrl")]
                                    [Validation(Required=false)]
                                    public string FileUrl { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xxx</para>
                                    /// </summary>
                                    [NameInMap("MediaId")]
                                    [Validation(Required=false)]
                                    public string MediaId { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public string TraceabilityId { get; set; }

                                }

                            }

                            [NameInMap("ClusterTopicResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResult ClusterTopicResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResult : TeaModel {
                                [NameInMap("ClusterTopics")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopics> ClusterTopics { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopics : TeaModel {
                                    [NameInMap("AudioSearchResult")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResult AudioSearchResult { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResult : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Current")]
                                        [Validation(Required=false)]
                                        public int? Current { get; set; }

                                        [NameInMap("SearchResult")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResultSearchResult SearchResult { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResultSearchResult : TeaModel {
                                            [NameInMap("Article")]
                                            [Validation(Required=false)]
                                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResultSearchResultArticle Article { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResultSearchResultArticle : TeaModel {
                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocId")]
                                                [Validation(Required=false)]
                                                public string DocId { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocUuid")]
                                                [Validation(Required=false)]
                                                public string DocUuid { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("SearchSourceName")]
                                                [Validation(Required=false)]
                                                public string SearchSourceName { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Summary")]
                                                [Validation(Required=false)]
                                                public string Summary { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Title")]
                                                [Validation(Required=false)]
                                                public string Title { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para><a href="http://xx">http://xx</a></para>
                                                /// </summary>
                                                [NameInMap("Url")]
                                                [Validation(Required=false)]
                                                public string Url { get; set; }

                                            }

                                            [NameInMap("ClipInfos")]
                                            [Validation(Required=false)]
                                            public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResultSearchResultClipInfos> ClipInfos { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResultSearchResultClipInfos : TeaModel {
                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>1</para>
                                                /// </summary>
                                                [NameInMap("From")]
                                                [Validation(Required=false)]
                                                public double? From { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>1</para>
                                                /// </summary>
                                                [NameInMap("Score")]
                                                [Validation(Required=false)]
                                                public double? Score { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Text")]
                                                [Validation(Required=false)]
                                                public string Text { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>1</para>
                                                /// </summary>
                                                [NameInMap("To")]
                                                [Validation(Required=false)]
                                                public double? To { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>asr</para>
                                                /// </summary>
                                                [NameInMap("Type")]
                                                [Validation(Required=false)]
                                                public string Type { get; set; }

                                            }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para><a href="http://xx">http://xx</a></para>
                                            /// </summary>
                                            [NameInMap("FileUrl")]
                                            [Validation(Required=false)]
                                            public string FileUrl { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xxx</para>
                                            /// </summary>
                                            [NameInMap("MediaId")]
                                            [Validation(Required=false)]
                                            public string MediaId { get; set; }

                                        }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Size")]
                                        [Validation(Required=false)]
                                        public int? Size { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Total")]
                                        [Validation(Required=false)]
                                        public int? Total { get; set; }

                                    }

                                    [NameInMap("ImageSearchResult")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsImageSearchResult ImageSearchResult { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsImageSearchResult : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Current")]
                                        [Validation(Required=false)]
                                        public int? Current { get; set; }

                                        [NameInMap("SearchResult")]
                                        [Validation(Required=false)]
                                        public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsImageSearchResultSearchResult> SearchResult { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsImageSearchResultSearchResult : TeaModel {
                                            [NameInMap("Article")]
                                            [Validation(Required=false)]
                                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsImageSearchResultSearchResultArticle Article { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsImageSearchResultSearchResultArticle : TeaModel {
                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocId")]
                                                [Validation(Required=false)]
                                                public string DocId { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocUuid")]
                                                [Validation(Required=false)]
                                                public string DocUuid { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>互联网搜索</para>
                                                /// </summary>
                                                [NameInMap("SearchSourceName")]
                                                [Validation(Required=false)]
                                                public string SearchSourceName { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Summary")]
                                                [Validation(Required=false)]
                                                public string Summary { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Title")]
                                                [Validation(Required=false)]
                                                public string Title { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Url")]
                                                [Validation(Required=false)]
                                                public string Url { get; set; }

                                            }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("FileUrl")]
                                            [Validation(Required=false)]
                                            public string FileUrl { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("MediaId")]
                                            [Validation(Required=false)]
                                            public string MediaId { get; set; }

                                        }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Size")]
                                        [Validation(Required=false)]
                                        public int? Size { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Total")]
                                        [Validation(Required=false)]
                                        public int? Total { get; set; }

                                    }

                                    [NameInMap("TextSearchResult")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsTextSearchResult TextSearchResult { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsTextSearchResult : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Current")]
                                        [Validation(Required=false)]
                                        public int? Current { get; set; }

                                        [NameInMap("SearchResult")]
                                        [Validation(Required=false)]
                                        public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsTextSearchResultSearchResult> SearchResult { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsTextSearchResultSearchResult : TeaModel {
                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocId")]
                                            [Validation(Required=false)]
                                            public string DocId { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocUuid")]
                                            [Validation(Required=false)]
                                            public string DocUuid { get; set; }

                                            [NameInMap("MultimodalMedias")]
                                            [Validation(Required=false)]
                                            public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsTextSearchResultSearchResultMultimodalMedias> MultimodalMedias { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsTextSearchResultSearchResultMultimodalMedias : TeaModel {
                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("FileUrl")]
                                                [Validation(Required=false)]
                                                public string FileUrl { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("MediaId")]
                                                [Validation(Required=false)]
                                                public string MediaId { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>image</para>
                                                /// </summary>
                                                [NameInMap("MediaType")]
                                                [Validation(Required=false)]
                                                public string MediaType { get; set; }

                                            }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>2023-04-04 08:39:09</para>
                                            /// </summary>
                                            [NameInMap("PubTime")]
                                            [Validation(Required=false)]
                                            public string PubTime { get; set; }

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
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Summary")]
                                            [Validation(Required=false)]
                                            public string Summary { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Title")]
                                            [Validation(Required=false)]
                                            public string Title { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Url")]
                                            [Validation(Required=false)]
                                            public string Url { get; set; }

                                        }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Size")]
                                        [Validation(Required=false)]
                                        public int? Size { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Total")]
                                        [Validation(Required=false)]
                                        public int? Total { get; set; }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Topic")]
                                    [Validation(Required=false)]
                                    public string Topic { get; set; }

                                    [NameInMap("VideoSearchResult")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResult VideoSearchResult { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResult : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Current")]
                                        [Validation(Required=false)]
                                        public int? Current { get; set; }

                                        [NameInMap("SearchResult")]
                                        [Validation(Required=false)]
                                        public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResultSearchResult> SearchResult { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResultSearchResult : TeaModel {
                                            [NameInMap("Article")]
                                            [Validation(Required=false)]
                                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResultSearchResultArticle Article { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResultSearchResultArticle : TeaModel {
                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocId")]
                                                [Validation(Required=false)]
                                                public string DocId { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocUuid")]
                                                [Validation(Required=false)]
                                                public string DocUuid { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>互联网搜索</para>
                                                /// </summary>
                                                [NameInMap("SearchSourceName")]
                                                [Validation(Required=false)]
                                                public string SearchSourceName { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Summary")]
                                                [Validation(Required=false)]
                                                public string Summary { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Title")]
                                                [Validation(Required=false)]
                                                public string Title { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Url")]
                                                [Validation(Required=false)]
                                                public string Url { get; set; }

                                            }

                                            [NameInMap("ClipInfos")]
                                            [Validation(Required=false)]
                                            public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResultSearchResultClipInfos> ClipInfos { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResultSearchResultClipInfos : TeaModel {
                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>1</para>
                                                /// </summary>
                                                [NameInMap("From")]
                                                [Validation(Required=false)]
                                                public double? From { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>0.9</para>
                                                /// </summary>
                                                [NameInMap("Score")]
                                                [Validation(Required=false)]
                                                public double? Score { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Text")]
                                                [Validation(Required=false)]
                                                public string Text { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>1</para>
                                                /// </summary>
                                                [NameInMap("To")]
                                                [Validation(Required=false)]
                                                public double? To { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>asr</para>
                                                /// </summary>
                                                [NameInMap("Type")]
                                                [Validation(Required=false)]
                                                public string Type { get; set; }

                                            }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("FileUrl")]
                                            [Validation(Required=false)]
                                            public string FileUrl { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("MediaId")]
                                            [Validation(Required=false)]
                                            public string MediaId { get; set; }

                                        }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Size")]
                                        [Validation(Required=false)]
                                        public int? Size { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Total")]
                                        [Validation(Required=false)]
                                        public int? Total { get; set; }

                                    }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("GenerateFinished")]
                                [Validation(Required=false)]
                                public bool? GenerateFinished { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>xx</para>
                                /// </summary>
                                [NameInMap("TextGenerate")]
                                [Validation(Required=false)]
                                public string TextGenerate { get; set; }

                            }

                            [NameInMap("ExcerptResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResult ExcerptResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResult : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("GenerateFinished")]
                                [Validation(Required=false)]
                                public bool? GenerateFinished { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>concise</para>
                                /// </summary>
                                [NameInMap("GenerateLevel")]
                                [Validation(Required=false)]
                                public string GenerateLevel { get; set; }

                                [NameInMap("ReasonTextGenerate")]
                                [Validation(Required=false)]
                                public string ReasonTextGenerate { get; set; }

                                [NameInMap("SearchResult")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResult> SearchResult { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResult : TeaModel {
                                    [NameInMap("Chunks")]
                                    [Validation(Required=false)]
                                    public List<string> Chunks { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Content")]
                                    [Validation(Required=false)]
                                    public string Content { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocId")]
                                    [Validation(Required=false)]
                                    public string DocId { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocUuid")]
                                    [Validation(Required=false)]
                                    public string DocUuid { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Excerpt")]
                                    [Validation(Required=false)]
                                    public string Excerpt { get; set; }

                                    [NameInMap("MultimodalMedias")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultMultimodalMedias> MultimodalMedias { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultMultimodalMedias : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("FileUrl")]
                                        [Validation(Required=false)]
                                        public string FileUrl { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("MediaId")]
                                        [Validation(Required=false)]
                                        public string MediaId { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>image</para>
                                        /// </summary>
                                        [NameInMap("MediaType")]
                                        [Validation(Required=false)]
                                        public string MediaType { get; set; }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>2023-04-04 08:39:09</para>
                                    /// </summary>
                                    [NameInMap("PubTime")]
                                    [Validation(Required=false)]
                                    public string PubTime { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>0.99</para>
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
                                    /// <para>true</para>
                                    /// </summary>
                                    [NameInMap("Select")]
                                    [Validation(Required=false)]
                                    public bool? Select { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Summary")]
                                    [Validation(Required=false)]
                                    public string Summary { get; set; }

                                    [NameInMap("TextGenerateMultimodalMediaList")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultTextGenerateMultimodalMediaList> TextGenerateMultimodalMediaList { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultTextGenerateMultimodalMediaList : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocUuid")]
                                        [Validation(Required=false)]
                                        public string DocUuid { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("End")]
                                        [Validation(Required=false)]
                                        public int? End { get; set; }

                                        [NameInMap("MultimodalMediaList")]
                                        [Validation(Required=false)]
                                        public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultTextGenerateMultimodalMediaListMultimodalMediaList> MultimodalMediaList { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultTextGenerateMultimodalMediaListMultimodalMediaList : TeaModel {
                                            [NameInMap("Article")]
                                            [Validation(Required=false)]
                                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultTextGenerateMultimodalMediaListMultimodalMediaListArticle Article { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultTextGenerateMultimodalMediaListMultimodalMediaListArticle : TeaModel {
                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocId")]
                                                [Validation(Required=false)]
                                                public string DocId { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocUuid")]
                                                [Validation(Required=false)]
                                                public string DocUuid { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xxx</para>
                                                /// </summary>
                                                [NameInMap("SearchSourceName")]
                                                [Validation(Required=false)]
                                                public string SearchSourceName { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Title")]
                                                [Validation(Required=false)]
                                                public string Title { get; set; }

                                                /// <summary>
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Url")]
                                                [Validation(Required=false)]
                                                public string Url { get; set; }

                                            }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("FileUrl")]
                                            [Validation(Required=false)]
                                            public string FileUrl { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("MediaId")]
                                            [Validation(Required=false)]
                                            public string MediaId { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>image</para>
                                            /// </summary>
                                            [NameInMap("MediaType")]
                                            [Validation(Required=false)]
                                            public string MediaType { get; set; }

                                        }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public int? Start { get; set; }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Title")]
                                    [Validation(Required=false)]
                                    public string Title { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public int? TraceabilityId { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Url")]
                                    [Validation(Required=false)]
                                    public string Url { get; set; }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>xx</para>
                                /// </summary>
                                [NameInMap("TextGenerate")]
                                [Validation(Required=false)]
                                public string TextGenerate { get; set; }

                            }

                            [NameInMap("ImageSearchResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentImageSearchResult ImageSearchResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentImageSearchResult : TeaModel {
                                [NameInMap("SearchResult")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentImageSearchResultSearchResult> SearchResult { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentImageSearchResultSearchResult : TeaModel {
                                    [NameInMap("Article")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentImageSearchResultSearchResultArticle Article { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentImageSearchResultSearchResultArticle : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocId")]
                                        [Validation(Required=false)]
                                        public string DocId { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocUuid")]
                                        [Validation(Required=false)]
                                        public string DocUuid { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>互联网搜索</para>
                                        /// </summary>
                                        [NameInMap("SearchSourceName")]
                                        [Validation(Required=false)]
                                        public string SearchSourceName { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Summary")]
                                        [Validation(Required=false)]
                                        public string Summary { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Title")]
                                        [Validation(Required=false)]
                                        public string Title { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Url")]
                                        [Validation(Required=false)]
                                        public string Url { get; set; }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("FileUrl")]
                                    [Validation(Required=false)]
                                    public string FileUrl { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("MediaId")]
                                    [Validation(Required=false)]
                                    public string MediaId { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public string TraceabilityId { get; set; }

                                }

                            }

                            [NameInMap("NewsElementResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResult NewsElementResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResult : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("GenerateFinished")]
                                [Validation(Required=false)]
                                public bool? GenerateFinished { get; set; }

                                [NameInMap("NewsElementArticleList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleList> NewsElementArticleList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleList : TeaModel {
                                    [NameInMap("Article")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleListArticle Article { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleListArticle : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Content")]
                                        [Validation(Required=false)]
                                        public string Content { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocId")]
                                        [Validation(Required=false)]
                                        public string DocId { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocUuid")]
                                        [Validation(Required=false)]
                                        public string DocUuid { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>2023-04-04 08:39:09</para>
                                        /// </summary>
                                        [NameInMap("PubTime")]
                                        [Validation(Required=false)]
                                        public string PubTime { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>0.99</para>
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
                                        /// <para>true</para>
                                        /// </summary>
                                        [NameInMap("Select")]
                                        [Validation(Required=false)]
                                        public bool? Select { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Summary")]
                                        [Validation(Required=false)]
                                        public string Summary { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Title")]
                                        [Validation(Required=false)]
                                        public string Title { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Url")]
                                        [Validation(Required=false)]
                                        public string Url { get; set; }

                                    }

                                    [NameInMap("NewsElementList")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleListNewsElementList> NewsElementList { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleListNewsElementList : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>task-started</para>
                                        /// </summary>
                                        [NameInMap("Event")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleListNewsElementListEvent Event { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleListNewsElementListEvent : TeaModel {
                                            [NameInMap("CauseList")]
                                            [Validation(Required=false)]
                                            public List<string> CauseList { get; set; }

                                            [NameInMap("ProcessList")]
                                            [Validation(Required=false)]
                                            public List<string> ProcessList { get; set; }

                                            [NameInMap("ResultList")]
                                            [Validation(Required=false)]
                                            public List<string> ResultList { get; set; }

                                        }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Location")]
                                        [Validation(Required=false)]
                                        public string Location { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("People")]
                                        [Validation(Required=false)]
                                        public string People { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>时间</para>
                                        /// </summary>
                                        [NameInMap("Time")]
                                        [Validation(Required=false)]
                                        public string Time { get; set; }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("TextGenerate")]
                                    [Validation(Required=false)]
                                    public string TextGenerate { get; set; }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>x</para>
                                /// </summary>
                                [NameInMap("TextGenerate")]
                                [Validation(Required=false)]
                                public string TextGenerate { get; set; }

                            }

                            [NameInMap("TextGenerateResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResult TextGenerateResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResult : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("GenerateFinished")]
                                [Validation(Required=false)]
                                public bool? GenerateFinished { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>concise</para>
                                /// </summary>
                                [NameInMap("GenerateLevel")]
                                [Validation(Required=false)]
                                public string GenerateLevel { get; set; }

                                [NameInMap("GenerateTraceability")]
                                [Validation(Required=false)]
                                public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceability GenerateTraceability { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceability : TeaModel {
                                    [NameInMap("Coordinates")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceabilityCoordinates> Coordinates { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceabilityCoordinates : TeaModel {
                                        [NameInMap("GenerateCoordinate")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceabilityCoordinatesGenerateCoordinate GenerateCoordinate { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceabilityCoordinatesGenerateCoordinate : TeaModel {
                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("X")]
                                            [Validation(Required=false)]
                                            public int? X { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Y")]
                                            [Validation(Required=false)]
                                            public int? Y { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Z")]
                                            [Validation(Required=false)]
                                            public int? Z { get; set; }

                                        }

                                        [NameInMap("NewsCoordinate")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceabilityCoordinatesNewsCoordinate NewsCoordinate { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceabilityCoordinatesNewsCoordinate : TeaModel {
                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>image</para>
                                            /// </summary>
                                            [NameInMap("MediaType")]
                                            [Validation(Required=false)]
                                            public string MediaType { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("X")]
                                            [Validation(Required=false)]
                                            public int? X { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Y")]
                                            [Validation(Required=false)]
                                            public int? Y { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Z")]
                                            [Validation(Required=false)]
                                            public int? Z { get; set; }

                                        }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>0.9</para>
                                    /// </summary>
                                    [NameInMap("Duplicate")]
                                    [Validation(Required=false)]
                                    public double? Duplicate { get; set; }

                                }

                                [NameInMap("MultimodalSearchResultList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultList> MultimodalSearchResultList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultList : TeaModel {
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("Current")]
                                    [Validation(Required=false)]
                                    public int? Current { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("SearchQuery")]
                                    [Validation(Required=false)]
                                    public string SearchQuery { get; set; }

                                    [NameInMap("SearchResult")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultListSearchResult> SearchResult { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultListSearchResult : TeaModel {
                                        [NameInMap("Article")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultListSearchResultArticle Article { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultListSearchResultArticle : TeaModel {
                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocId")]
                                            [Validation(Required=false)]
                                            public string DocId { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocUuid")]
                                            [Validation(Required=false)]
                                            public string DocUuid { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("SearchSourceName")]
                                            [Validation(Required=false)]
                                            public string SearchSourceName { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Summary")]
                                            [Validation(Required=false)]
                                            public string Summary { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Title")]
                                            [Validation(Required=false)]
                                            public string Title { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Url")]
                                            [Validation(Required=false)]
                                            public string Url { get; set; }

                                        }

                                        [NameInMap("ClipInfos")]
                                        [Validation(Required=false)]
                                        public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultListSearchResultClipInfos> ClipInfos { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultListSearchResultClipInfos : TeaModel {
                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("From")]
                                            [Validation(Required=false)]
                                            public double? From { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>0.1</para>
                                            /// </summary>
                                            [NameInMap("Score")]
                                            [Validation(Required=false)]
                                            public double? Score { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Text")]
                                            [Validation(Required=false)]
                                            public string Text { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("To")]
                                            [Validation(Required=false)]
                                            public double? To { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>asr</para>
                                            /// </summary>
                                            [NameInMap("Type")]
                                            [Validation(Required=false)]
                                            public string Type { get; set; }

                                        }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("FileUrl")]
                                        [Validation(Required=false)]
                                        public string FileUrl { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("MediaId")]
                                        [Validation(Required=false)]
                                        public string MediaId { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>image</para>
                                        /// </summary>
                                        [NameInMap("MediaType")]
                                        [Validation(Required=false)]
                                        public string MediaType { get; set; }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>realtime</para>
                                    /// </summary>
                                    [NameInMap("SearchType")]
                                    [Validation(Required=false)]
                                    public string SearchType { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("Size")]
                                    [Validation(Required=false)]
                                    public int? Size { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>时间脉络-时间</para>
                                    /// </summary>
                                    [NameInMap("TimelineDateStr")]
                                    [Validation(Required=false)]
                                    public string TimelineDateStr { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("Total")]
                                    [Validation(Required=false)]
                                    public int? Total { get; set; }

                                }

                                [NameInMap("ReasonTextGenerate")]
                                [Validation(Required=false)]
                                public string ReasonTextGenerate { get; set; }

                                [NameInMap("ReferenceList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultReferenceList> ReferenceList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultReferenceList : TeaModel {
                                    [NameInMap("Chunks")]
                                    [Validation(Required=false)]
                                    public List<string> Chunks { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Content")]
                                    [Validation(Required=false)]
                                    public string Content { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocId")]
                                    [Validation(Required=false)]
                                    public string DocId { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocUuid")]
                                    [Validation(Required=false)]
                                    public string DocUuid { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>2023-04-04 08:39:09</para>
                                    /// </summary>
                                    [NameInMap("PubTime")]
                                    [Validation(Required=false)]
                                    public string PubTime { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>0.99</para>
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
                                    /// <para>true</para>
                                    /// </summary>
                                    [NameInMap("Select")]
                                    [Validation(Required=false)]
                                    public bool? Select { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>新华社</para>
                                    /// </summary>
                                    [NameInMap("Source")]
                                    [Validation(Required=false)]
                                    public string Source { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Summary")]
                                    [Validation(Required=false)]
                                    public string Summary { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Title")]
                                    [Validation(Required=false)]
                                    public string Title { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public int? TraceabilityId { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Url")]
                                    [Validation(Required=false)]
                                    public string Url { get; set; }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>xx</para>
                                /// </summary>
                                [NameInMap("TextGenerate")]
                                [Validation(Required=false)]
                                public string TextGenerate { get; set; }

                                [NameInMap("TextGenerateMultimodalMediaList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultTextGenerateMultimodalMediaList> TextGenerateMultimodalMediaList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultTextGenerateMultimodalMediaList : TeaModel {
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("End")]
                                    [Validation(Required=false)]
                                    public int? End { get; set; }

                                    [NameInMap("MultimodalMediaList")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultTextGenerateMultimodalMediaListMultimodalMediaList> MultimodalMediaList { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultTextGenerateMultimodalMediaListMultimodalMediaList : TeaModel {
                                        [NameInMap("Article")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultTextGenerateMultimodalMediaListMultimodalMediaListArticle Article { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultTextGenerateMultimodalMediaListMultimodalMediaListArticle : TeaModel {
                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocId")]
                                            [Validation(Required=false)]
                                            public string DocId { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocUuid")]
                                            [Validation(Required=false)]
                                            public string DocUuid { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("SearchSourceName")]
                                            [Validation(Required=false)]
                                            public string SearchSourceName { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Summary")]
                                            [Validation(Required=false)]
                                            public string Summary { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Title")]
                                            [Validation(Required=false)]
                                            public string Title { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Url")]
                                            [Validation(Required=false)]
                                            public string Url { get; set; }

                                        }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("FileUrl")]
                                        [Validation(Required=false)]
                                        public string FileUrl { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("MediaId")]
                                        [Validation(Required=false)]
                                        public string MediaId { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>image</para>
                                        /// </summary>
                                        [NameInMap("MediaType")]
                                        [Validation(Required=false)]
                                        public string MediaType { get; set; }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("Start")]
                                    [Validation(Required=false)]
                                    public int? Start { get; set; }

                                }

                            }

                            [NameInMap("TextSearchResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextSearchResult TextSearchResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextSearchResult : TeaModel {
                                [NameInMap("Current")]
                                [Validation(Required=false)]
                                public int? Current { get; set; }

                                [NameInMap("SearchResult")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextSearchResultSearchResult> SearchResult { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextSearchResultSearchResult : TeaModel {
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Content")]
                                    [Validation(Required=false)]
                                    public string Content { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocId")]
                                    [Validation(Required=false)]
                                    public string DocId { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
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
                                    /// <para>QuarkCommonNews</para>
                                    /// </summary>
                                    [NameInMap("SearchSource")]
                                    [Validation(Required=false)]
                                    public string SearchSource { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xxx</para>
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
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Summary")]
                                    [Validation(Required=false)]
                                    public string Summary { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Title")]
                                    [Validation(Required=false)]
                                    public string Title { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public string TraceabilityId { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Url")]
                                    [Validation(Required=false)]
                                    public string Url { get; set; }

                                }

                                [NameInMap("Size")]
                                [Validation(Required=false)]
                                public int? Size { get; set; }

                                [NameInMap("Total")]
                                [Validation(Required=false)]
                                public int? Total { get; set; }

                            }

                            [NameInMap("TimelineResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResult TimelineResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResult : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("GenerateFinished")]
                                [Validation(Required=false)]
                                public bool? GenerateFinished { get; set; }

                                [NameInMap("GenerateTraceability")]
                                [Validation(Required=false)]
                                public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceability GenerateTraceability { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceability : TeaModel {
                                    [NameInMap("Coordinates")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceabilityCoordinates> Coordinates { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceabilityCoordinates : TeaModel {
                                        [NameInMap("GenerateCoordinate")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceabilityCoordinatesGenerateCoordinate GenerateCoordinate { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceabilityCoordinatesGenerateCoordinate : TeaModel {
                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("X")]
                                            [Validation(Required=false)]
                                            public int? X { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Y")]
                                            [Validation(Required=false)]
                                            public int? Y { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Z")]
                                            [Validation(Required=false)]
                                            public int? Z { get; set; }

                                        }

                                        [NameInMap("NewsCoordinate")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceabilityCoordinatesNewsCoordinate NewsCoordinate { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceabilityCoordinatesNewsCoordinate : TeaModel {
                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>image</para>
                                            /// </summary>
                                            [NameInMap("MediaType")]
                                            [Validation(Required=false)]
                                            public string MediaType { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("X")]
                                            [Validation(Required=false)]
                                            public int? X { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Y")]
                                            [Validation(Required=false)]
                                            public int? Y { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Z")]
                                            [Validation(Required=false)]
                                            public int? Z { get; set; }

                                        }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>0.9</para>
                                    /// </summary>
                                    [NameInMap("Duplicate")]
                                    [Validation(Required=false)]
                                    public double? Duplicate { get; set; }

                                }

                                [NameInMap("MultimodalSearchResultList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultList> MultimodalSearchResultList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultList : TeaModel {
                                    [NameInMap("SearchResult")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultListSearchResult> SearchResult { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultListSearchResult : TeaModel {
                                        [NameInMap("Article")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultListSearchResultArticle Article { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultListSearchResultArticle : TeaModel {
                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocId")]
                                            [Validation(Required=false)]
                                            public string DocId { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocUuid")]
                                            [Validation(Required=false)]
                                            public string DocUuid { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>互联网搜索</para>
                                            /// </summary>
                                            [NameInMap("SearchSourceName")]
                                            [Validation(Required=false)]
                                            public string SearchSourceName { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Summary")]
                                            [Validation(Required=false)]
                                            public string Summary { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Title")]
                                            [Validation(Required=false)]
                                            public string Title { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Url")]
                                            [Validation(Required=false)]
                                            public string Url { get; set; }

                                        }

                                        [NameInMap("ClipInfos")]
                                        [Validation(Required=false)]
                                        public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultListSearchResultClipInfos> ClipInfos { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultListSearchResultClipInfos : TeaModel {
                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("From")]
                                            [Validation(Required=false)]
                                            public double? From { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>0.99</para>
                                            /// </summary>
                                            [NameInMap("Score")]
                                            [Validation(Required=false)]
                                            public double? Score { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Text")]
                                            [Validation(Required=false)]
                                            public string Text { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("To")]
                                            [Validation(Required=false)]
                                            public double? To { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>asr</para>
                                            /// </summary>
                                            [NameInMap("Type")]
                                            [Validation(Required=false)]
                                            public string Type { get; set; }

                                        }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("FileUrl")]
                                        [Validation(Required=false)]
                                        public string FileUrl { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("MediaId")]
                                        [Validation(Required=false)]
                                        public string MediaId { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>image</para>
                                        /// </summary>
                                        [NameInMap("MediaType")]
                                        [Validation(Required=false)]
                                        public string MediaType { get; set; }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>2024-09-11</para>
                                    /// </summary>
                                    [NameInMap("TimelineDateStr")]
                                    [Validation(Required=false)]
                                    public string TimelineDateStr { get; set; }

                                }

                                [NameInMap("ReasonTextGenerate")]
                                [Validation(Required=false)]
                                public string ReasonTextGenerate { get; set; }

                                [NameInMap("ReferenceList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultReferenceList> ReferenceList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultReferenceList : TeaModel {
                                    [NameInMap("Chunks")]
                                    [Validation(Required=false)]
                                    public List<string> Chunks { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Content")]
                                    [Validation(Required=false)]
                                    public string Content { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocId")]
                                    [Validation(Required=false)]
                                    public string DocId { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocUuid")]
                                    [Validation(Required=false)]
                                    public string DocUuid { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>2023-04-04 08:39:09</para>
                                    /// </summary>
                                    [NameInMap("PubTime")]
                                    [Validation(Required=false)]
                                    public string PubTime { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>0.99</para>
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
                                    /// <para>true</para>
                                    /// </summary>
                                    [NameInMap("Select")]
                                    [Validation(Required=false)]
                                    public bool? Select { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>新华社</para>
                                    /// </summary>
                                    [NameInMap("Source")]
                                    [Validation(Required=false)]
                                    public string Source { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Summary")]
                                    [Validation(Required=false)]
                                    public string Summary { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Title")]
                                    [Validation(Required=false)]
                                    public string Title { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public int? TraceabilityId { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Url")]
                                    [Validation(Required=false)]
                                    public string Url { get; set; }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>xx</para>
                                /// </summary>
                                [NameInMap("TextGenerate")]
                                [Validation(Required=false)]
                                public string TextGenerate { get; set; }

                                [NameInMap("TextGenerateMultimodalMediaList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultTextGenerateMultimodalMediaList> TextGenerateMultimodalMediaList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultTextGenerateMultimodalMediaList : TeaModel {
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("End")]
                                    [Validation(Required=false)]
                                    public int? End { get; set; }

                                    [NameInMap("MultimodalMediaList")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultTextGenerateMultimodalMediaListMultimodalMediaList> MultimodalMediaList { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultTextGenerateMultimodalMediaListMultimodalMediaList : TeaModel {
                                        [NameInMap("Article")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultTextGenerateMultimodalMediaListMultimodalMediaListArticle Article { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultTextGenerateMultimodalMediaListMultimodalMediaListArticle : TeaModel {
                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocId")]
                                            [Validation(Required=false)]
                                            public string DocId { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocUuid")]
                                            [Validation(Required=false)]
                                            public string DocUuid { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>互联网搜索</para>
                                            /// </summary>
                                            [NameInMap("SearchSourceName")]
                                            [Validation(Required=false)]
                                            public string SearchSourceName { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Summary")]
                                            [Validation(Required=false)]
                                            public string Summary { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xxxx</para>
                                            /// </summary>
                                            [NameInMap("Title")]
                                            [Validation(Required=false)]
                                            public string Title { get; set; }

                                            /// <summary>
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Url")]
                                            [Validation(Required=false)]
                                            public string Url { get; set; }

                                        }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("FileUrl")]
                                        [Validation(Required=false)]
                                        public string FileUrl { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("MediaId")]
                                        [Validation(Required=false)]
                                        public string MediaId { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>image</para>
                                        /// </summary>
                                        [NameInMap("MediaType")]
                                        [Validation(Required=false)]
                                        public string MediaType { get; set; }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("Start")]
                                    [Validation(Required=false)]
                                    public int? Start { get; set; }

                                }

                            }

                            [NameInMap("VideoSearchResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResult VideoSearchResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResult : TeaModel {
                                [NameInMap("SearchResult")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResultSearchResult> SearchResult { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResultSearchResult : TeaModel {
                                    [NameInMap("Article")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResultSearchResultArticle Article { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResultSearchResultArticle : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocId")]
                                        [Validation(Required=false)]
                                        public string DocId { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocUuid")]
                                        [Validation(Required=false)]
                                        public string DocUuid { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>互联网搜索</para>
                                        /// </summary>
                                        [NameInMap("SearchSourceName")]
                                        [Validation(Required=false)]
                                        public string SearchSourceName { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Summary")]
                                        [Validation(Required=false)]
                                        public string Summary { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Title")]
                                        [Validation(Required=false)]
                                        public string Title { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Url")]
                                        [Validation(Required=false)]
                                        public string Url { get; set; }

                                    }

                                    [NameInMap("ClipInfos")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResultSearchResultClipInfos> ClipInfos { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResultSearchResultClipInfos : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("From")]
                                        [Validation(Required=false)]
                                        public double? From { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>0.8</para>
                                        /// </summary>
                                        [NameInMap("Score")]
                                        [Validation(Required=false)]
                                        public double? Score { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Text")]
                                        [Validation(Required=false)]
                                        public string Text { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("To")]
                                        [Validation(Required=false)]
                                        public double? To { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>asr</para>
                                        /// </summary>
                                        [NameInMap("Type")]
                                        [Validation(Required=false)]
                                        public string Type { get; set; }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("FileUrl")]
                                    [Validation(Required=false)]
                                    public string FileUrl { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("MediaId")]
                                    [Validation(Required=false)]
                                    public string MediaId { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public string TraceabilityId { get; set; }

                                }

                            }

                        }

                        [NameInMap("ModelId")]
                        [Validation(Required=false)]
                        public string ModelId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>search</para>
                        /// </summary>
                        [NameInMap("NextStep")]
                        [Validation(Required=false)]
                        public string NextStep { get; set; }

                        [NameInMap("RecommendSearchQueryList")]
                        [Validation(Required=false)]
                        public List<string> RecommendSearchQueryList { get; set; }

                        [NameInMap("SearchKeywords")]
                        [Validation(Required=false)]
                        public List<string> SearchKeywords { get; set; }

                        [NameInMap("SearchQueryList")]
                        [Validation(Required=false)]
                        public List<string> SearchQueryList { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>searchQuery</para>
                        /// </summary>
                        [NameInMap("SupplementDataType")]
                        [Validation(Required=false)]
                        public string SupplementDataType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("SupplementEnable")]
                        [Validation(Required=false)]
                        public bool? SupplementEnable { get; set; }

                        [NameInMap("TokenCalculate")]
                        [Validation(Required=false)]
                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextTokenCalculate TokenCalculate { get; set; }
                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextTokenCalculate : TeaModel {
                            [NameInMap("FirstTokenTime")]
                            [Validation(Required=false)]
                            public float? FirstTokenTime { get; set; }

                            [NameInMap("OutputAvgTime")]
                            [Validation(Required=false)]
                            public float? OutputAvgTime { get; set; }

                            [NameInMap("SearchTime")]
                            [Validation(Required=false)]
                            public float? SearchTime { get; set; }

                            [NameInMap("Time")]
                            [Validation(Required=false)]
                            public float? Time { get; set; }

                            [NameInMap("TotalTokens")]
                            [Validation(Required=false)]
                            public long? TotalTokens { get; set; }

                        }

                    }

                }

                [NameInMap("Messages")]
                [Validation(Required=false)]
                public List<RunSearchGenerationResponseBodyPayloadOutputMessages> Messages { get; set; }
                public class RunSearchGenerationResponseBodyPayloadOutputMessages : TeaModel {
                    [NameInMap("Clarifications")]
                    [Validation(Required=false)]
                    public bool? Clarifications { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("GenerateFinished")]
                    [Validation(Required=false)]
                    public bool? GenerateFinished { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>generateStartStatement</para>
                    /// </summary>
                    [NameInMap("NodeCode")]
                    [Validation(Required=false)]
                    public string NodeCode { get; set; }

                    [NameInMap("SearchQueries")]
                    [Validation(Required=false)]
                    public List<string> SearchQueries { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("SearchQuery")]
                    [Validation(Required=false)]
                    public string SearchQuery { get; set; }

                    [NameInMap("SearchResult")]
                    [Validation(Required=false)]
                    public List<RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResult> SearchResult { get; set; }
                    public class RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResult : TeaModel {
                        [NameInMap("Audios")]
                        [Validation(Required=false)]
                        public List<RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultAudios> Audios { get; set; }
                        public class RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultAudios : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>xx</para>
                            /// </summary>
                            [NameInMap("MediaId")]
                            [Validation(Required=false)]
                            public string MediaId { get; set; }

                        }

                        [NameInMap("Images")]
                        [Validation(Required=false)]
                        public List<RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultImages> Images { get; set; }
                        public class RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultImages : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>xx</para>
                            /// </summary>
                            [NameInMap("MediaId")]
                            [Validation(Required=false)]
                            public string MediaId { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("MultimodalSearchQuery")]
                        [Validation(Required=false)]
                        public string MultimodalSearchQuery { get; set; }

                        [NameInMap("Texts")]
                        [Validation(Required=false)]
                        public List<RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultTexts> Texts { get; set; }
                        public class RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultTexts : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>xx</para>
                            /// </summary>
                            [NameInMap("DocUuid")]
                            [Validation(Required=false)]
                            public string DocUuid { get; set; }

                        }

                        [NameInMap("Videos")]
                        [Validation(Required=false)]
                        public List<RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultVideos> Videos { get; set; }
                        public class RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultVideos : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("MediaId")]
                            [Validation(Required=false)]
                            public string MediaId { get; set; }

                        }

                    }

                }

            }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunSearchGenerationResponseBodyPayloadUsage Usage { get; set; }
            public class RunSearchGenerationResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
