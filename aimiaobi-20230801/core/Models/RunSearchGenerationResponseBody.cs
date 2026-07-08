// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunSearchGenerationResponseBody : TeaModel {
        /// <summary>
        /// <para>Response header.</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunSearchGenerationResponseBodyHeader Header { get; set; }
        public class RunSearchGenerationResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>Error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccessForbid</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>Error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>SSE event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-failed</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>Event description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <para>Source session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("OriginSessionId")]
            [Validation(Required=false)]
            public string OriginSessionId { get; set; }

            /// <summary>
            /// <para>Response time, in milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResponseTime")]
            [Validation(Required=false)]
            public long? ResponseTime { get; set; }

            /// <summary>
            /// <para>Conversation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Full link ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>Response body.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunSearchGenerationResponseBodyPayload Payload { get; set; }
        public class RunSearchGenerationResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>Outputs.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunSearchGenerationResponseBodyPayloadOutput Output { get; set; }
            public class RunSearchGenerationResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>Context data.</para>
                /// </summary>
                [NameInMap("AgentContext")]
                [Validation(Required=false)]
                public RunSearchGenerationResponseBodyPayloadOutputAgentContext AgentContext { get; set; }
                public class RunSearchGenerationResponseBodyPayloadOutputAgentContext : TeaModel {
                    /// <summary>
                    /// <para>Business context.</para>
                    /// </summary>
                    [NameInMap("BizContext")]
                    [Validation(Required=false)]
                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContext BizContext { get; set; }
                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContext : TeaModel {
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
                        /// <para>Current step in the task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>start</para>
                        /// </summary>
                        [NameInMap("CurrentStep")]
                        [Validation(Required=false)]
                        public string CurrentStep { get; set; }

                        /// <summary>
                        /// <para>Generated content.</para>
                        /// </summary>
                        [NameInMap("GeneratedContent")]
                        [Validation(Required=false)]
                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContent GeneratedContent { get; set; }
                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContent : TeaModel {
                            /// <summary>
                            /// <para>Voice search result.</para>
                            /// </summary>
                            [NameInMap("AudioSearchResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResult AudioSearchResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResult : TeaModel {
                                /// <summary>
                                /// <para>Voice search result.</para>
                                /// </summary>
                                [NameInMap("SearchResult")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResultSearchResult> SearchResult { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResultSearchResult : TeaModel {
                                    /// <summary>
                                    /// <para>Associated document.</para>
                                    /// </summary>
                                    [NameInMap("Article")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResultSearchResultArticle Article { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResultSearchResultArticle : TeaModel {
                                        /// <summary>
                                        /// <para>Unique category identifier.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("CategoryUuid")]
                                        [Validation(Required=false)]
                                        public string CategoryUuid { get; set; }

                                        /// <summary>
                                        /// <para>ID.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocId")]
                                        [Validation(Required=false)]
                                        public string DocId { get; set; }

                                        /// <summary>
                                        /// <para>UUID.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocUuid")]
                                        [Validation(Required=false)]
                                        public string DocUuid { get; set; }

                                        /// <summary>
                                        /// <para>Extension field 1.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Extend1")]
                                        [Validation(Required=false)]
                                        public string Extend1 { get; set; }

                                        /// <summary>
                                        /// <para>Extension field 2.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Extend2")]
                                        [Validation(Required=false)]
                                        public string Extend2 { get; set; }

                                        /// <summary>
                                        /// <para>Extension field 3.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Extend3")]
                                        [Validation(Required=false)]
                                        public string Extend3 { get; set; }

                                        /// <summary>
                                        /// <para>Search source.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("SearchSourceName")]
                                        [Validation(Required=false)]
                                        public string SearchSourceName { get; set; }

                                        /// <summary>
                                        /// <para>Summary.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xxx</para>
                                        /// </summary>
                                        [NameInMap("Summary")]
                                        [Validation(Required=false)]
                                        public string Summary { get; set; }

                                        /// <summary>
                                        /// <para>List of tags.</para>
                                        /// </summary>
                                        [NameInMap("Tags")]
                                        [Validation(Required=false)]
                                        public List<string> Tags { get; set; }

                                        /// <summary>
                                        /// <para>Title.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Title")]
                                        [Validation(Required=false)]
                                        public string Title { get; set; }

                                        /// <summary>
                                        /// <para>URL.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para><a href="http://xxx">http://xxx</a></para>
                                        /// </summary>
                                        [NameInMap("Url")]
                                        [Validation(Required=false)]
                                        public string Url { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>List of matching segments.</para>
                                    /// </summary>
                                    [NameInMap("ClipInfos")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResultSearchResultClipInfos> ClipInfos { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentAudioSearchResultSearchResultClipInfos : TeaModel {
                                        /// <summary>
                                        /// <para>Start position.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("From")]
                                        [Validation(Required=false)]
                                        public double? From { get; set; }

                                        /// <summary>
                                        /// <para>Threshold.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>0.9</para>
                                        /// </summary>
                                        [NameInMap("Score")]
                                        [Validation(Required=false)]
                                        public double? Score { get; set; }

                                        /// <summary>
                                        /// <para>Text content.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Text")]
                                        [Validation(Required=false)]
                                        public string Text { get; set; }

                                        /// <summary>
                                        /// <para>End position.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>2</para>
                                        /// </summary>
                                        [NameInMap("To")]
                                        [Validation(Required=false)]
                                        public double? To { get; set; }

                                        /// <summary>
                                        /// <para>Text type.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>asr</para>
                                        /// </summary>
                                        [NameInMap("Type")]
                                        [Validation(Required=false)]
                                        public string Type { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>URL.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para><a href="http://xxx">http://xxx</a></para>
                                    /// </summary>
                                    [NameInMap("FileUrl")]
                                    [Validation(Required=false)]
                                    public string FileUrl { get; set; }

                                    /// <summary>
                                    /// <para>ID.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xxx</para>
                                    /// </summary>
                                    [NameInMap("MediaId")]
                                    [Validation(Required=false)]
                                    public string MediaId { get; set; }

                                    /// <summary>
                                    /// <para>Unique traceability identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public string TraceabilityId { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>Clustering result.</para>
                            /// </summary>
                            [NameInMap("ClusterTopicResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResult ClusterTopicResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResult : TeaModel {
                                /// <summary>
                                /// <para>List of clusters.</para>
                                /// </summary>
                                [NameInMap("ClusterTopics")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopics> ClusterTopics { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopics : TeaModel {
                                    /// <summary>
                                    /// <para>Audio result</para>
                                    /// </summary>
                                    [NameInMap("AudioSearchResult")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResult AudioSearchResult { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResult : TeaModel {
                                        /// <summary>
                                        /// <para>Current page</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Current")]
                                        [Validation(Required=false)]
                                        public int? Current { get; set; }

                                        /// <summary>
                                        /// <para>Audio search results</para>
                                        /// </summary>
                                        [NameInMap("SearchResult")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResultSearchResult SearchResult { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResultSearchResult : TeaModel {
                                            /// <summary>
                                            /// <para>Corresponding document</para>
                                            /// </summary>
                                            [NameInMap("Article")]
                                            [Validation(Required=false)]
                                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResultSearchResultArticle Article { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResultSearchResultArticle : TeaModel {
                                                /// <summary>
                                                /// <para>Category identity</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("CategoryUuid")]
                                                [Validation(Required=false)]
                                                public string CategoryUuid { get; set; }

                                                /// <summary>
                                                /// <para>docId</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocId")]
                                                [Validation(Required=false)]
                                                public string DocId { get; set; }

                                                /// <summary>
                                                /// <para>docUuid</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocUuid")]
                                                [Validation(Required=false)]
                                                public string DocUuid { get; set; }

                                                /// <summary>
                                                /// <para>Extension field 1</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Extend1")]
                                                [Validation(Required=false)]
                                                public string Extend1 { get; set; }

                                                /// <summary>
                                                /// <para>Extension field 2</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Extend2")]
                                                [Validation(Required=false)]
                                                public string Extend2 { get; set; }

                                                /// <summary>
                                                /// <para>Extension field 3</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Extend3")]
                                                [Validation(Required=false)]
                                                public string Extend3 { get; set; }

                                                /// <summary>
                                                /// <para>Unique identifier of the dataset</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("SearchSource")]
                                                [Validation(Required=false)]
                                                public string SearchSource { get; set; }

                                                /// <summary>
                                                /// <para>Search source</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("SearchSourceName")]
                                                [Validation(Required=false)]
                                                public string SearchSourceName { get; set; }

                                                /// <summary>
                                                /// <para>The type of the dataset.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("SearchSourceType")]
                                                [Validation(Required=false)]
                                                public string SearchSourceType { get; set; }

                                                /// <summary>
                                                /// <para>Summary</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Summary")]
                                                [Validation(Required=false)]
                                                public string Summary { get; set; }

                                                /// <summary>
                                                /// <para>Tag name</para>
                                                /// </summary>
                                                [NameInMap("Tags")]
                                                [Validation(Required=false)]
                                                public List<string> Tags { get; set; }

                                                /// <summary>
                                                /// <para>Title</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Title")]
                                                [Validation(Required=false)]
                                                public string Title { get; set; }

                                                /// <summary>
                                                /// <para>The URL of the article.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para><a href="http://xx">http://xx</a></para>
                                                /// </summary>
                                                [NameInMap("Url")]
                                                [Validation(Required=false)]
                                                public string Url { get; set; }

                                            }

                                            /// <summary>
                                            /// <para>List of matching information</para>
                                            /// </summary>
                                            [NameInMap("ClipInfos")]
                                            [Validation(Required=false)]
                                            public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResultSearchResultClipInfos> ClipInfos { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsAudioSearchResultSearchResultClipInfos : TeaModel {
                                                /// <summary>
                                                /// <para>Start position</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>1</para>
                                                /// </summary>
                                                [NameInMap("From")]
                                                [Validation(Required=false)]
                                                public double? From { get; set; }

                                                /// <summary>
                                                /// <para>The threshold.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>1</para>
                                                /// </summary>
                                                [NameInMap("Score")]
                                                [Validation(Required=false)]
                                                public double? Score { get; set; }

                                                /// <summary>
                                                /// <para>Text content</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Text")]
                                                [Validation(Required=false)]
                                                public string Text { get; set; }

                                                /// <summary>
                                                /// <para>The end position.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>1</para>
                                                /// </summary>
                                                [NameInMap("To")]
                                                [Validation(Required=false)]
                                                public double? To { get; set; }

                                                /// <summary>
                                                /// <para>Type</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>asr</para>
                                                /// </summary>
                                                [NameInMap("Type")]
                                                [Validation(Required=false)]
                                                public string Type { get; set; }

                                            }

                                            /// <summary>
                                            /// <para>URL</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para><a href="http://xx">http://xx</a></para>
                                            /// </summary>
                                            [NameInMap("FileUrl")]
                                            [Validation(Required=false)]
                                            public string FileUrl { get; set; }

                                            /// <summary>
                                            /// <para>The ID.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xxx</para>
                                            /// </summary>
                                            [NameInMap("MediaId")]
                                            [Validation(Required=false)]
                                            public string MediaId { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>Size</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Size")]
                                        [Validation(Required=false)]
                                        public int? Size { get; set; }

                                        /// <summary>
                                        /// <para>Total count</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Total")]
                                        [Validation(Required=false)]
                                        public int? Total { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>Image search result.</para>
                                    /// </summary>
                                    [NameInMap("ImageSearchResult")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsImageSearchResult ImageSearchResult { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsImageSearchResult : TeaModel {
                                        /// <summary>
                                        /// <para>Current page number.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Current")]
                                        [Validation(Required=false)]
                                        public int? Current { get; set; }

                                        /// <summary>
                                        /// <para>List of search results.</para>
                                        /// </summary>
                                        [NameInMap("SearchResult")]
                                        [Validation(Required=false)]
                                        public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsImageSearchResultSearchResult> SearchResult { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsImageSearchResultSearchResult : TeaModel {
                                            /// <summary>
                                            /// <para>Article.</para>
                                            /// </summary>
                                            [NameInMap("Article")]
                                            [Validation(Required=false)]
                                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsImageSearchResultSearchResultArticle Article { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsImageSearchResultSearchResultArticle : TeaModel {
                                                /// <summary>
                                                /// <para>Unique category identifier.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("CategoryUuid")]
                                                [Validation(Required=false)]
                                                public string CategoryUuid { get; set; }

                                                /// <summary>
                                                /// <para>Custom unique document ID.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocId")]
                                                [Validation(Required=false)]
                                                public string DocId { get; set; }

                                                /// <summary>
                                                /// <para>Internal unique document identifier.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocUuid")]
                                                [Validation(Required=false)]
                                                public string DocUuid { get; set; }

                                                /// <summary>
                                                /// <para>Extension field 1.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Extend1")]
                                                [Validation(Required=false)]
                                                public string Extend1 { get; set; }

                                                /// <summary>
                                                /// <para>Extension field 2.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Extend2")]
                                                [Validation(Required=false)]
                                                public string Extend2 { get; set; }

                                                /// <summary>
                                                /// <para>Extension field 3.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Extend3")]
                                                [Validation(Required=false)]
                                                public string Extend3 { get; set; }

                                                /// <summary>
                                                /// <para>Dataset unique identifier.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("SearchSource")]
                                                [Validation(Required=false)]
                                                public string SearchSource { get; set; }

                                                /// <summary>
                                                /// <para>Search source name.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>互联网搜索</para>
                                                /// </summary>
                                                [NameInMap("SearchSourceName")]
                                                [Validation(Required=false)]
                                                public string SearchSourceName { get; set; }

                                                /// <summary>
                                                /// <para>Dataset type.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("SearchSourceType")]
                                                [Validation(Required=false)]
                                                public string SearchSourceType { get; set; }

                                                /// <summary>
                                                /// <para>Summary.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Summary")]
                                                [Validation(Required=false)]
                                                public string Summary { get; set; }

                                                /// <summary>
                                                /// <para>Tags.</para>
                                                /// </summary>
                                                [NameInMap("Tags")]
                                                [Validation(Required=false)]
                                                public List<string> Tags { get; set; }

                                                /// <summary>
                                                /// <para>Title.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Title")]
                                                [Validation(Required=false)]
                                                public string Title { get; set; }

                                                /// <summary>
                                                /// <para>Article URL.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Url")]
                                                [Validation(Required=false)]
                                                public string Url { get; set; }

                                            }

                                            /// <summary>
                                            /// <para>File URL.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("FileUrl")]
                                            [Validation(Required=false)]
                                            public string FileUrl { get; set; }

                                            /// <summary>
                                            /// <para>Unique multimodal data identifier.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("MediaId")]
                                            [Validation(Required=false)]
                                            public string MediaId { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>Records per page.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Size")]
                                        [Validation(Required=false)]
                                        public int? Size { get; set; }

                                        /// <summary>
                                        /// <para>Total records.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Total")]
                                        [Validation(Required=false)]
                                        public int? Total { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>Document search results</para>
                                    /// </summary>
                                    [NameInMap("TextSearchResult")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsTextSearchResult TextSearchResult { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsTextSearchResult : TeaModel {
                                        /// <summary>
                                        /// <para>Current page number</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Current")]
                                        [Validation(Required=false)]
                                        public int? Current { get; set; }

                                        /// <summary>
                                        /// <para>Search results list</para>
                                        /// </summary>
                                        [NameInMap("SearchResult")]
                                        [Validation(Required=false)]
                                        public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsTextSearchResultSearchResult> SearchResult { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsTextSearchResultSearchResult : TeaModel {
                                            /// <summary>
                                            /// <para>Category unique identifier</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("CategoryUuid")]
                                            [Validation(Required=false)]
                                            public string CategoryUuid { get; set; }

                                            /// <summary>
                                            /// <para>The custom unique ID of the document.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocId")]
                                            [Validation(Required=false)]
                                            public string DocId { get; set; }

                                            /// <summary>
                                            /// <para>Unique identifier for internal documents.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocUuid")]
                                            [Validation(Required=false)]
                                            public string DocUuid { get; set; }

                                            /// <summary>
                                            /// <para>Extension field 1</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Extend1")]
                                            [Validation(Required=false)]
                                            public string Extend1 { get; set; }

                                            /// <summary>
                                            /// <para>Extension field 2</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Extend2")]
                                            [Validation(Required=false)]
                                            public string Extend2 { get; set; }

                                            /// <summary>
                                            /// <para>Extension field 3</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Extend3")]
                                            [Validation(Required=false)]
                                            public string Extend3 { get; set; }

                                            /// <summary>
                                            /// <para>A list of multimodal information.</para>
                                            /// </summary>
                                            [NameInMap("MultimodalMedias")]
                                            [Validation(Required=false)]
                                            public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsTextSearchResultSearchResultMultimodalMedias> MultimodalMedias { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsTextSearchResultSearchResultMultimodalMedias : TeaModel {
                                                /// <summary>
                                                /// <para>The URL of the file.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("FileUrl")]
                                                [Validation(Required=false)]
                                                public string FileUrl { get; set; }

                                                /// <summary>
                                                /// <para>The unique ID of the multimodal data.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("MediaId")]
                                                [Validation(Required=false)]
                                                public string MediaId { get; set; }

                                                /// <summary>
                                                /// <para>Multimodal data file type. Valid values:</para>
                                                /// <list type="bullet">
                                                /// <item><description><para>video: Video.</para>
                                                /// </description></item>
                                                /// <item><description><para>image: Image.</para>
                                                /// </description></item>
                                                /// </list>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>image</para>
                                                /// </summary>
                                                [NameInMap("MediaType")]
                                                [Validation(Required=false)]
                                                public string MediaType { get; set; }

                                            }

                                            /// <summary>
                                            /// <para>Publication time, in the format yyyy-MM-dd HH:mm:ss</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>2023-04-04 08:39:09</para>
                                            /// </summary>
                                            [NameInMap("PubTime")]
                                            [Validation(Required=false)]
                                            public string PubTime { get; set; }

                                            /// <summary>
                                            /// <para>The unique identifier of the search source. This is the same as searchSource.datasetName.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>QuarkCommonNews</para>
                                            /// </summary>
                                            [NameInMap("SearchSource")]
                                            [Validation(Required=false)]
                                            public string SearchSource { get; set; }

                                            /// <summary>
                                            /// <para>The name of the search source.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>互联网搜索</para>
                                            /// </summary>
                                            [NameInMap("SearchSourceName")]
                                            [Validation(Required=false)]
                                            public string SearchSourceName { get; set; }

                                            /// <summary>
                                            /// <para>Search source type, same as searchSource.code.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>SystemSearch</para>
                                            /// </summary>
                                            [NameInMap("SearchSourceType")]
                                            [Validation(Required=false)]
                                            public string SearchSourceType { get; set; }

                                            /// <summary>
                                            /// <para>Summary</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Summary")]
                                            [Validation(Required=false)]
                                            public string Summary { get; set; }

                                            /// <summary>
                                            /// <para>Tags</para>
                                            /// </summary>
                                            [NameInMap("Tags")]
                                            [Validation(Required=false)]
                                            public List<string> Tags { get; set; }

                                            /// <summary>
                                            /// <para>Title</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Title")]
                                            [Validation(Required=false)]
                                            public string Title { get; set; }

                                            /// <summary>
                                            /// <para>Article URL</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Url")]
                                            [Validation(Required=false)]
                                            public string Url { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>Number of records per page</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Size")]
                                        [Validation(Required=false)]
                                        public int? Size { get; set; }

                                        /// <summary>
                                        /// <para>The total number of entries.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Total")]
                                        [Validation(Required=false)]
                                        public int? Total { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>Topic.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Topic")]
                                    [Validation(Required=false)]
                                    public string Topic { get; set; }

                                    /// <summary>
                                    /// <para>Video search results</para>
                                    /// </summary>
                                    [NameInMap("VideoSearchResult")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResult VideoSearchResult { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResult : TeaModel {
                                        /// <summary>
                                        /// <para>The current page number.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Current")]
                                        [Validation(Required=false)]
                                        public int? Current { get; set; }

                                        /// <summary>
                                        /// <para>Search results</para>
                                        /// </summary>
                                        [NameInMap("SearchResult")]
                                        [Validation(Required=false)]
                                        public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResultSearchResult> SearchResult { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResultSearchResult : TeaModel {
                                            /// <summary>
                                            /// <para>Article</para>
                                            /// </summary>
                                            [NameInMap("Article")]
                                            [Validation(Required=false)]
                                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResultSearchResultArticle Article { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResultSearchResultArticle : TeaModel {
                                                /// <summary>
                                                /// <para>Category</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("CategoryUuid")]
                                                [Validation(Required=false)]
                                                public string CategoryUuid { get; set; }

                                                /// <summary>
                                                /// <para>Document: a custom unique ID</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocId")]
                                                [Validation(Required=false)]
                                                public string DocId { get; set; }

                                                /// <summary>
                                                /// <para>The unique identifier of the internal document.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocUuid")]
                                                [Validation(Required=false)]
                                                public string DocUuid { get; set; }

                                                /// <summary>
                                                /// <para>Extension field 1</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Extend1")]
                                                [Validation(Required=false)]
                                                public string Extend1 { get; set; }

                                                /// <summary>
                                                /// <para>Extension field 2</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Extend2")]
                                                [Validation(Required=false)]
                                                public string Extend2 { get; set; }

                                                /// <summary>
                                                /// <para>Extension field 3</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>x</para>
                                                /// </summary>
                                                [NameInMap("Extend3")]
                                                [Validation(Required=false)]
                                                public string Extend3 { get; set; }

                                                /// <summary>
                                                /// <para>The unique identifier of the dataset.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("SearchSource")]
                                                [Validation(Required=false)]
                                                public string SearchSource { get; set; }

                                                /// <summary>
                                                /// <para>The name of the search source.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>互联网搜索</para>
                                                /// </summary>
                                                [NameInMap("SearchSourceName")]
                                                [Validation(Required=false)]
                                                public string SearchSourceName { get; set; }

                                                /// <summary>
                                                /// <para>Dataset type</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("SearchSourceType")]
                                                [Validation(Required=false)]
                                                public string SearchSourceType { get; set; }

                                                /// <summary>
                                                /// <para>Summary</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Summary")]
                                                [Validation(Required=false)]
                                                public string Summary { get; set; }

                                                /// <summary>
                                                /// <para>Tags</para>
                                                /// </summary>
                                                [NameInMap("Tags")]
                                                [Validation(Required=false)]
                                                public List<string> Tags { get; set; }

                                                /// <summary>
                                                /// <para>Title</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Title")]
                                                [Validation(Required=false)]
                                                public string Title { get; set; }

                                                /// <summary>
                                                /// <para>The URL of the article.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Url")]
                                                [Validation(Required=false)]
                                                public string Url { get; set; }

                                            }

                                            /// <summary>
                                            /// <para>A list of matching information.</para>
                                            /// </summary>
                                            [NameInMap("ClipInfos")]
                                            [Validation(Required=false)]
                                            public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResultSearchResultClipInfos> ClipInfos { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentClusterTopicResultClusterTopicsVideoSearchResultSearchResultClipInfos : TeaModel {
                                                /// <summary>
                                                /// <para>Start time</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>1</para>
                                                /// </summary>
                                                [NameInMap("From")]
                                                [Validation(Required=false)]
                                                public double? From { get; set; }

                                                /// <summary>
                                                /// <para>Reference confidence level</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>0.9</para>
                                                /// </summary>
                                                [NameInMap("Score")]
                                                [Validation(Required=false)]
                                                public double? Score { get; set; }

                                                /// <summary>
                                                /// <para>Corresponding text, such as ASR transcription results.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Text")]
                                                [Validation(Required=false)]
                                                public string Text { get; set; }

                                                /// <summary>
                                                /// <para>End time</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>1</para>
                                                /// </summary>
                                                [NameInMap("To")]
                                                [Validation(Required=false)]
                                                public double? To { get; set; }

                                                /// <summary>
                                                /// <para>Text type, such as ASR.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>asr</para>
                                                /// </summary>
                                                [NameInMap("Type")]
                                                [Validation(Required=false)]
                                                public string Type { get; set; }

                                            }

                                            /// <summary>
                                            /// <para>The URL of the file.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("FileUrl")]
                                            [Validation(Required=false)]
                                            public string FileUrl { get; set; }

                                            /// <summary>
                                            /// <para>Unique identifier for the multimodal data</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("MediaId")]
                                            [Validation(Required=false)]
                                            public string MediaId { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>Number of records per page</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Size")]
                                        [Validation(Required=false)]
                                        public int? Size { get; set; }

                                        /// <summary>
                                        /// <para>Total records</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Total")]
                                        [Validation(Required=false)]
                                        public int? Total { get; set; }

                                    }

                                }

                                /// <summary>
                                /// <para>Indicates whether the current agent has finished generating.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("GenerateFinished")]
                                [Validation(Required=false)]
                                public bool? GenerateFinished { get; set; }

                                /// <summary>
                                /// <para>Text result.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>xx</para>
                                /// </summary>
                                [NameInMap("TextGenerate")]
                                [Validation(Required=false)]
                                public string TextGenerate { get; set; }

                            }

                            /// <summary>
                            /// <para>Result of answering with original sentences.</para>
                            /// </summary>
                            [NameInMap("ExcerptResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResult ExcerptResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResult : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether the current agent has finished generating.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("GenerateFinished")]
                                [Validation(Required=false)]
                                public bool? GenerateFinished { get; set; }

                                /// <summary>
                                /// <para>Detailedness of the response:</para>
                                /// <list type="bullet">
                                /// <item><description><para>concise: Concise (default)</para>
                                /// </description></item>
                                /// <item><description><para>enhance: Enhanced</para>
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
                                /// <para>Deep thinking content.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>xx</para>
                                /// </summary>
                                [NameInMap("ReasonTextGenerate")]
                                [Validation(Required=false)]
                                public string ReasonTextGenerate { get; set; }

                                /// <summary>
                                /// <para>List of search results.</para>
                                /// </summary>
                                [NameInMap("SearchResult")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResult> SearchResult { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResult : TeaModel {
                                    /// <summary>
                                    /// <para>Unique category identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("CategoryUuid")]
                                    [Validation(Required=false)]
                                    public string CategoryUuid { get; set; }

                                    /// <summary>
                                    /// <para>List of chunks.</para>
                                    /// </summary>
                                    [NameInMap("Chunks")]
                                    [Validation(Required=false)]
                                    public List<string> Chunks { get; set; }

                                    /// <summary>
                                    /// <para>Body.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Content")]
                                    [Validation(Required=false)]
                                    public string Content { get; set; }

                                    /// <summary>
                                    /// <para>Custom unique document ID.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocId")]
                                    [Validation(Required=false)]
                                    public string DocId { get; set; }

                                    /// <summary>
                                    /// <para>Internal unique document identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocUuid")]
                                    [Validation(Required=false)]
                                    public string DocUuid { get; set; }

                                    /// <summary>
                                    /// <para>Content answered with original sentences.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Excerpt")]
                                    [Validation(Required=false)]
                                    public string Excerpt { get; set; }

                                    /// <summary>
                                    /// <para>Extension field 1.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Extend1")]
                                    [Validation(Required=false)]
                                    public string Extend1 { get; set; }

                                    /// <summary>
                                    /// <para>Extension field 2.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Extend2")]
                                    [Validation(Required=false)]
                                    public string Extend2 { get; set; }

                                    /// <summary>
                                    /// <para>Extension field 3.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Extend3")]
                                    [Validation(Required=false)]
                                    public string Extend3 { get; set; }

                                    /// <summary>
                                    /// <para>List of multimodal information items.</para>
                                    /// </summary>
                                    [NameInMap("MultimodalMedias")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultMultimodalMedias> MultimodalMedias { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultMultimodalMedias : TeaModel {
                                        /// <summary>
                                        /// <para>File URL.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("FileUrl")]
                                        [Validation(Required=false)]
                                        public string FileUrl { get; set; }

                                        /// <summary>
                                        /// <para>Unique multimodal data identifier.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("MediaId")]
                                        [Validation(Required=false)]
                                        public string MediaId { get; set; }

                                        /// <summary>
                                        /// <para>Multimodal file type. Valid values:</para>
                                        /// <list type="bullet">
                                        /// <item><description><para>video: video</para>
                                        /// </description></item>
                                        /// <item><description><para>image: image</para>
                                        /// </description></item>
                                        /// </list>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>image</para>
                                        /// </summary>
                                        [NameInMap("MediaType")]
                                        [Validation(Required=false)]
                                        public string MediaType { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>Publication time. Format: yyyy-MM-dd HH:mm:ss.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>2023-04-04 08:39:09</para>
                                    /// </summary>
                                    [NameInMap("PubTime")]
                                    [Validation(Required=false)]
                                    public string PubTime { get; set; }

                                    /// <summary>
                                    /// <para>Confidence score. For reference only.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0.99</para>
                                    /// </summary>
                                    [NameInMap("Score")]
                                    [Validation(Required=false)]
                                    public float? Score { get; set; }

                                    /// <summary>
                                    /// <para>Search source unique identifier. Same as searchSource.datasetName.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>QuarkCommonNews</para>
                                    /// </summary>
                                    [NameInMap("SearchSource")]
                                    [Validation(Required=false)]
                                    public string SearchSource { get; set; }

                                    /// <summary>
                                    /// <para>Search source name.</para>
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
                                    /// <para>Indicates whether it is a reference.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>true</para>
                                    /// </summary>
                                    [NameInMap("Select")]
                                    [Validation(Required=false)]
                                    public bool? Select { get; set; }

                                    /// <summary>
                                    /// <para>Summary.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Summary")]
                                    [Validation(Required=false)]
                                    public string Summary { get; set; }

                                    /// <summary>
                                    /// <para>Tag name.</para>
                                    /// </summary>
                                    [NameInMap("Tags")]
                                    [Validation(Required=false)]
                                    public List<string> Tags { get; set; }

                                    /// <summary>
                                    /// <para>List of accompanying images.</para>
                                    /// </summary>
                                    [NameInMap("TextGenerateMultimodalMediaList")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultTextGenerateMultimodalMediaList> TextGenerateMultimodalMediaList { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultTextGenerateMultimodalMediaList : TeaModel {
                                        /// <summary>
                                        /// <para>Internal unique document identifier.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocUuid")]
                                        [Validation(Required=false)]
                                        public string DocUuid { get; set; }

                                        /// <summary>
                                        /// <para>End position.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("End")]
                                        [Validation(Required=false)]
                                        public int? End { get; set; }

                                        /// <summary>
                                        /// <para>List of multimodal data.</para>
                                        /// </summary>
                                        [NameInMap("MultimodalMediaList")]
                                        [Validation(Required=false)]
                                        public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultTextGenerateMultimodalMediaListMultimodalMediaList> MultimodalMediaList { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultTextGenerateMultimodalMediaListMultimodalMediaList : TeaModel {
                                            /// <summary>
                                            /// <para>Article.</para>
                                            /// </summary>
                                            [NameInMap("Article")]
                                            [Validation(Required=false)]
                                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultTextGenerateMultimodalMediaListMultimodalMediaListArticle Article { get; set; }
                                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentExcerptResultSearchResultTextGenerateMultimodalMediaListMultimodalMediaListArticle : TeaModel {
                                                /// <summary>
                                                /// <para>Custom unique document ID.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocId")]
                                                [Validation(Required=false)]
                                                public string DocId { get; set; }

                                                /// <summary>
                                                /// <para>Internal unique document identifier.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("DocUuid")]
                                                [Validation(Required=false)]
                                                public string DocUuid { get; set; }

                                                /// <summary>
                                                /// <para>Search source name.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>互联网搜索</para>
                                                /// </summary>
                                                [NameInMap("SearchSourceName")]
                                                [Validation(Required=false)]
                                                public string SearchSourceName { get; set; }

                                                /// <summary>
                                                /// <para>Title.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Title")]
                                                [Validation(Required=false)]
                                                public string Title { get; set; }

                                                /// <summary>
                                                /// <para>Article URL.</para>
                                                /// 
                                                /// <b>Example:</b>
                                                /// <para>xx</para>
                                                /// </summary>
                                                [NameInMap("Url")]
                                                [Validation(Required=false)]
                                                public string Url { get; set; }

                                            }

                                            /// <summary>
                                            /// <para>File URL.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("FileUrl")]
                                            [Validation(Required=false)]
                                            public string FileUrl { get; set; }

                                            /// <summary>
                                            /// <para>Unique multimodal data identifier.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("MediaId")]
                                            [Validation(Required=false)]
                                            public string MediaId { get; set; }

                                            /// <summary>
                                            /// <para>Multimodal file type. Valid values: video, image.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>image</para>
                                            /// </summary>
                                            [NameInMap("MediaType")]
                                            [Validation(Required=false)]
                                            public string MediaType { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>Start position.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public int? Start { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>Title.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Title")]
                                    [Validation(Required=false)]
                                    public string Title { get; set; }

                                    /// <summary>
                                    /// <para>Traceability ID.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public int? TraceabilityId { get; set; }

                                    /// <summary>
                                    /// <para>Article URL.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Url")]
                                    [Validation(Required=false)]
                                    public string Url { get; set; }

                                }

                                /// <summary>
                                /// <para>Generated text.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>xx</para>
                                /// </summary>
                                [NameInMap("TextGenerate")]
                                [Validation(Required=false)]
                                public string TextGenerate { get; set; }

                            }

                            /// <summary>
                            /// <para>Image search result.</para>
                            /// </summary>
                            [NameInMap("ImageSearchResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentImageSearchResult ImageSearchResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentImageSearchResult : TeaModel {
                                /// <summary>
                                /// <para>List of search results.</para>
                                /// </summary>
                                [NameInMap("SearchResult")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentImageSearchResultSearchResult> SearchResult { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentImageSearchResultSearchResult : TeaModel {
                                    /// <summary>
                                    /// <para>Article.</para>
                                    /// </summary>
                                    [NameInMap("Article")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentImageSearchResultSearchResultArticle Article { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentImageSearchResultSearchResultArticle : TeaModel {
                                        /// <summary>
                                        /// <para>Unique category identifier.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("CategoryUuid")]
                                        [Validation(Required=false)]
                                        public string CategoryUuid { get; set; }

                                        /// <summary>
                                        /// <para>Custom unique document ID.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocId")]
                                        [Validation(Required=false)]
                                        public string DocId { get; set; }

                                        /// <summary>
                                        /// <para>Internal unique document identifier.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocUuid")]
                                        [Validation(Required=false)]
                                        public string DocUuid { get; set; }

                                        /// <summary>
                                        /// <para>Extension field 1.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Extend1")]
                                        [Validation(Required=false)]
                                        public string Extend1 { get; set; }

                                        /// <summary>
                                        /// <para>Extension field 2.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Extend2")]
                                        [Validation(Required=false)]
                                        public string Extend2 { get; set; }

                                        /// <summary>
                                        /// <para>Extension field 3.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Extend3")]
                                        [Validation(Required=false)]
                                        public string Extend3 { get; set; }

                                        /// <summary>
                                        /// <para>Search source name.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>互联网搜索</para>
                                        /// </summary>
                                        [NameInMap("SearchSourceName")]
                                        [Validation(Required=false)]
                                        public string SearchSourceName { get; set; }

                                        /// <summary>
                                        /// <para>Article summary.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Summary")]
                                        [Validation(Required=false)]
                                        public string Summary { get; set; }

                                        /// <summary>
                                        /// <para>Tag name.</para>
                                        /// </summary>
                                        [NameInMap("Tags")]
                                        [Validation(Required=false)]
                                        public List<string> Tags { get; set; }

                                        /// <summary>
                                        /// <para>Title.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Title")]
                                        [Validation(Required=false)]
                                        public string Title { get; set; }

                                        /// <summary>
                                        /// <para>Article URL.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Url")]
                                        [Validation(Required=false)]
                                        public string Url { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>File URL.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("FileUrl")]
                                    [Validation(Required=false)]
                                    public string FileUrl { get; set; }

                                    /// <summary>
                                    /// <para>Media data unique identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("MediaId")]
                                    [Validation(Required=false)]
                                    public string MediaId { get; set; }

                                    /// <summary>
                                    /// <para>Unique traceability identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public string TraceabilityId { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>News extraction result.</para>
                            /// </summary>
                            [NameInMap("NewsElementResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResult NewsElementResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResult : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether the current agent has finished generating.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("GenerateFinished")]
                                [Validation(Required=false)]
                                public bool? GenerateFinished { get; set; }

                                /// <summary>
                                /// <para>List of news extractions.</para>
                                /// </summary>
                                [NameInMap("NewsElementArticleList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleList> NewsElementArticleList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleList : TeaModel {
                                    /// <summary>
                                    /// <para>Article.</para>
                                    /// </summary>
                                    [NameInMap("Article")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleListArticle Article { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleListArticle : TeaModel {
                                        /// <summary>
                                        /// <para>Unique category identifier.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("CategoryUuid")]
                                        [Validation(Required=false)]
                                        public string CategoryUuid { get; set; }

                                        /// <summary>
                                        /// <para>Body.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Content")]
                                        [Validation(Required=false)]
                                        public string Content { get; set; }

                                        /// <summary>
                                        /// <para>Custom unique document ID.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocId")]
                                        [Validation(Required=false)]
                                        public string DocId { get; set; }

                                        /// <summary>
                                        /// <para>Internal unique document identifier.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocUuid")]
                                        [Validation(Required=false)]
                                        public string DocUuid { get; set; }

                                        /// <summary>
                                        /// <para>Extension field 1.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Extend1")]
                                        [Validation(Required=false)]
                                        public string Extend1 { get; set; }

                                        /// <summary>
                                        /// <para>Extension field 2.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Extend2")]
                                        [Validation(Required=false)]
                                        public string Extend2 { get; set; }

                                        /// <summary>
                                        /// <para>Extension field 3.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Extend3")]
                                        [Validation(Required=false)]
                                        public string Extend3 { get; set; }

                                        /// <summary>
                                        /// <para>Publication time. Format: yyyy-MM-dd HH:mm:ss.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>2023-04-04 08:39:09</para>
                                        /// </summary>
                                        [NameInMap("PubTime")]
                                        [Validation(Required=false)]
                                        public string PubTime { get; set; }

                                        /// <summary>
                                        /// <para>Confidence score. For reference only.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>0.99</para>
                                        /// </summary>
                                        [NameInMap("Score")]
                                        [Validation(Required=false)]
                                        public float? Score { get; set; }

                                        /// <summary>
                                        /// <para>Search source unique identifier. Same as searchSource.datasetName.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>QuarkCommonNews</para>
                                        /// </summary>
                                        [NameInMap("SearchSource")]
                                        [Validation(Required=false)]
                                        public string SearchSource { get; set; }

                                        /// <summary>
                                        /// <para>Search source name.</para>
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
                                        /// <para>Indicates whether it is a reference.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>true</para>
                                        /// </summary>
                                        [NameInMap("Select")]
                                        [Validation(Required=false)]
                                        public bool? Select { get; set; }

                                        /// <summary>
                                        /// <para>Summary.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Summary")]
                                        [Validation(Required=false)]
                                        public string Summary { get; set; }

                                        /// <summary>
                                        /// <para>Tag name.</para>
                                        /// </summary>
                                        [NameInMap("Tags")]
                                        [Validation(Required=false)]
                                        public List<string> Tags { get; set; }

                                        /// <summary>
                                        /// <para>Title.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Title")]
                                        [Validation(Required=false)]
                                        public string Title { get; set; }

                                        /// <summary>
                                        /// <para>Article URL.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Url")]
                                        [Validation(Required=false)]
                                        public string Url { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>List of news items.</para>
                                    /// </summary>
                                    [NameInMap("NewsElementList")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleListNewsElementList> NewsElementList { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleListNewsElementList : TeaModel {
                                        /// <summary>
                                        /// <para>Event.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>task-started</para>
                                        /// </summary>
                                        [NameInMap("Event")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleListNewsElementListEvent Event { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentNewsElementResultNewsElementArticleListNewsElementListEvent : TeaModel {
                                            /// <summary>
                                            /// <para>List of causes.</para>
                                            /// </summary>
                                            [NameInMap("CauseList")]
                                            [Validation(Required=false)]
                                            public List<string> CauseList { get; set; }

                                            /// <summary>
                                            /// <para>List of processes.</para>
                                            /// </summary>
                                            [NameInMap("ProcessList")]
                                            [Validation(Required=false)]
                                            public List<string> ProcessList { get; set; }

                                            /// <summary>
                                            /// <para>List of results.</para>
                                            /// </summary>
                                            [NameInMap("ResultList")]
                                            [Validation(Required=false)]
                                            public List<string> ResultList { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>Location.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Location")]
                                        [Validation(Required=false)]
                                        public string Location { get; set; }

                                        /// <summary>
                                        /// <para>People.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("People")]
                                        [Validation(Required=false)]
                                        public string People { get; set; }

                                        /// <summary>
                                        /// <para>Time.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>时间</para>
                                        /// </summary>
                                        [NameInMap("Time")]
                                        [Validation(Required=false)]
                                        public string Time { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>Generated text content.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("TextGenerate")]
                                    [Validation(Required=false)]
                                    public string TextGenerate { get; set; }

                                }

                                /// <summary>
                                /// <para>Generated text content.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>x</para>
                                /// </summary>
                                [NameInMap("TextGenerate")]
                                [Validation(Required=false)]
                                public string TextGenerate { get; set; }

                            }

                            /// <summary>
                            /// <para>Summarized answer.</para>
                            /// </summary>
                            [NameInMap("TextGenerateResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResult TextGenerateResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResult : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether the current agent has finished generating.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("GenerateFinished")]
                                [Validation(Required=false)]
                                public bool? GenerateFinished { get; set; }

                                /// <summary>
                                /// <para>Detailedness of the response:</para>
                                /// <list type="bullet">
                                /// <item><description><para>concise: Concise (default)</para>
                                /// </description></item>
                                /// <item><description><para>enhance: Enhanced</para>
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
                                /// <para>Traceability information.</para>
                                /// </summary>
                                [NameInMap("GenerateTraceability")]
                                [Validation(Required=false)]
                                public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceability GenerateTraceability { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceability : TeaModel {
                                    /// <summary>
                                    /// <para>List of traceability locations.</para>
                                    /// </summary>
                                    [NameInMap("Coordinates")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceabilityCoordinates> Coordinates { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceabilityCoordinates : TeaModel {
                                        /// <summary>
                                        /// <para>Coordinates of the generated document block.</para>
                                        /// </summary>
                                        [NameInMap("GenerateCoordinate")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceabilityCoordinatesGenerateCoordinate GenerateCoordinate { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceabilityCoordinatesGenerateCoordinate : TeaModel {
                                            /// <summary>
                                            /// <para>Number, starting from 1.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("X")]
                                            [Validation(Required=false)]
                                            public int? X { get; set; }

                                            /// <summary>
                                            /// <para>Start position.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Y")]
                                            [Validation(Required=false)]
                                            public int? Y { get; set; }

                                            /// <summary>
                                            /// <para>End position.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Z")]
                                            [Validation(Required=false)]
                                            public int? Z { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>Coordinates of the reference document block.</para>
                                        /// </summary>
                                        [NameInMap("NewsCoordinate")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceabilityCoordinatesNewsCoordinate NewsCoordinate { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultGenerateTraceabilityCoordinatesNewsCoordinate : TeaModel {
                                            /// <summary>
                                            /// <para>Media asset type.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>image</para>
                                            /// </summary>
                                            [NameInMap("MediaType")]
                                            [Validation(Required=false)]
                                            public string MediaType { get; set; }

                                            /// <summary>
                                            /// <para>Number, starting from 1.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("X")]
                                            [Validation(Required=false)]
                                            public int? X { get; set; }

                                            /// <summary>
                                            /// <para>Start position.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Y")]
                                            [Validation(Required=false)]
                                            public int? Y { get; set; }

                                            /// <summary>
                                            /// <para>End position.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Z")]
                                            [Validation(Required=false)]
                                            public int? Z { get; set; }

                                        }

                                    }

                                    /// <summary>
                                    /// <para>Overall traceability relevance.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0.9</para>
                                    /// </summary>
                                    [NameInMap("Duplicate")]
                                    [Validation(Required=false)]
                                    public double? Duplicate { get; set; }

                                }

                                /// <summary>
                                /// <para>List of multimodal search results.</para>
                                /// </summary>
                                [NameInMap("MultimodalSearchResultList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultList> MultimodalSearchResultList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultList : TeaModel {
                                    /// <summary>
                                    /// <para>Current page.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("Current")]
                                    [Validation(Required=false)]
                                    public int? Current { get; set; }

                                    /// <summary>
                                    /// <para>Search query.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("SearchQuery")]
                                    [Validation(Required=false)]
                                    public string SearchQuery { get; set; }

                                    /// <summary>
                                    /// <para>List of search results.</para>
                                    /// </summary>
                                    [NameInMap("SearchResult")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultListSearchResult> SearchResult { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultListSearchResult : TeaModel {
                                        /// <summary>
                                        /// <para>Article.</para>
                                        /// </summary>
                                        [NameInMap("Article")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultListSearchResultArticle Article { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultListSearchResultArticle : TeaModel {
                                            /// <summary>
                                            /// <para>Custom unique document ID.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocId")]
                                            [Validation(Required=false)]
                                            public string DocId { get; set; }

                                            /// <summary>
                                            /// <para>Internal unique document identifier.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocUuid")]
                                            [Validation(Required=false)]
                                            public string DocUuid { get; set; }

                                            /// <summary>
                                            /// <para>Search source name.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("SearchSourceName")]
                                            [Validation(Required=false)]
                                            public string SearchSourceName { get; set; }

                                            /// <summary>
                                            /// <para>Summary.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Summary")]
                                            [Validation(Required=false)]
                                            public string Summary { get; set; }

                                            /// <summary>
                                            /// <para>Title.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Title")]
                                            [Validation(Required=false)]
                                            public string Title { get; set; }

                                            /// <summary>
                                            /// <para>Article URL.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Url")]
                                            [Validation(Required=false)]
                                            public string Url { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>List of matching segments.</para>
                                        /// </summary>
                                        [NameInMap("ClipInfos")]
                                        [Validation(Required=false)]
                                        public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultListSearchResultClipInfos> ClipInfos { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultMultimodalSearchResultListSearchResultClipInfos : TeaModel {
                                            /// <summary>
                                            /// <para>Start time.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("From")]
                                            [Validation(Required=false)]
                                            public double? From { get; set; }

                                            /// <summary>
                                            /// <para>Confidence score. For reference only.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>0.1</para>
                                            /// </summary>
                                            [NameInMap("Score")]
                                            [Validation(Required=false)]
                                            public double? Score { get; set; }

                                            /// <summary>
                                            /// <para>Corresponding text, such as ASR transcription.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Text")]
                                            [Validation(Required=false)]
                                            public string Text { get; set; }

                                            /// <summary>
                                            /// <para>End time.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("To")]
                                            [Validation(Required=false)]
                                            public double? To { get; set; }

                                            /// <summary>
                                            /// <para>Type. Example: asr.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>asr</para>
                                            /// </summary>
                                            [NameInMap("Type")]
                                            [Validation(Required=false)]
                                            public string Type { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>File URL.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("FileUrl")]
                                        [Validation(Required=false)]
                                        public string FileUrl { get; set; }

                                        /// <summary>
                                        /// <para>Media asset ID.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("MediaId")]
                                        [Validation(Required=false)]
                                        public string MediaId { get; set; }

                                        /// <summary>
                                        /// <para>Multimodal file type. Valid values: video, image.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>image</para>
                                        /// </summary>
                                        [NameInMap("MediaType")]
                                        [Validation(Required=false)]
                                        public string MediaType { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>Search type.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>realtime</para>
                                    /// </summary>
                                    [NameInMap("SearchType")]
                                    [Validation(Required=false)]
                                    public string SearchType { get; set; }

                                    /// <summary>
                                    /// <para>Items per page.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("Size")]
                                    [Validation(Required=false)]
                                    public int? Size { get; set; }

                                    /// <summary>
                                    /// <para>Timeline date.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>时间脉络-时间</para>
                                    /// </summary>
                                    [NameInMap("TimelineDateStr")]
                                    [Validation(Required=false)]
                                    public string TimelineDateStr { get; set; }

                                    /// <summary>
                                    /// <para>Total items.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("Total")]
                                    [Validation(Required=false)]
                                    public int? Total { get; set; }

                                }

                                /// <summary>
                                /// <para>Deep thinking content.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>xx</para>
                                /// </summary>
                                [NameInMap("ReasonTextGenerate")]
                                [Validation(Required=false)]
                                public string ReasonTextGenerate { get; set; }

                                /// <summary>
                                /// <para>List of reference articles.</para>
                                /// </summary>
                                [NameInMap("ReferenceList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultReferenceList> ReferenceList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultReferenceList : TeaModel {
                                    /// <summary>
                                    /// <para>Category unique identifier</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("CategoryUuid")]
                                    [Validation(Required=false)]
                                    public string CategoryUuid { get; set; }

                                    /// <summary>
                                    /// <para>List of chunks.</para>
                                    /// </summary>
                                    [NameInMap("Chunks")]
                                    [Validation(Required=false)]
                                    public List<string> Chunks { get; set; }

                                    /// <summary>
                                    /// <para>Body.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Content")]
                                    [Validation(Required=false)]
                                    public string Content { get; set; }

                                    /// <summary>
                                    /// <para>Custom unique document ID.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocId")]
                                    [Validation(Required=false)]
                                    public string DocId { get; set; }

                                    /// <summary>
                                    /// <para>Internal unique document identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocUuid")]
                                    [Validation(Required=false)]
                                    public string DocUuid { get; set; }

                                    /// <summary>
                                    /// <para>Extension field 1.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Extend1")]
                                    [Validation(Required=false)]
                                    public string Extend1 { get; set; }

                                    /// <summary>
                                    /// <para>Extension field 2.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Extend2")]
                                    [Validation(Required=false)]
                                    public string Extend2 { get; set; }

                                    /// <summary>
                                    /// <para>Extension field 3.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Extend3")]
                                    [Validation(Required=false)]
                                    public string Extend3 { get; set; }

                                    /// <summary>
                                    /// <para>Publication time. Format: yyyy-MM-dd HH:mm:ss.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>2023-04-04 08:39:09</para>
                                    /// </summary>
                                    [NameInMap("PubTime")]
                                    [Validation(Required=false)]
                                    public string PubTime { get; set; }

                                    /// <summary>
                                    /// <para>Confidence score. For reference only.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0.99</para>
                                    /// </summary>
                                    [NameInMap("Score")]
                                    [Validation(Required=false)]
                                    public float? Score { get; set; }

                                    /// <summary>
                                    /// <para>Search source unique identifier. Same as searchSource.datasetName.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>QuarkCommonNews</para>
                                    /// </summary>
                                    [NameInMap("SearchSource")]
                                    [Validation(Required=false)]
                                    public string SearchSource { get; set; }

                                    /// <summary>
                                    /// <para>Search source name.</para>
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
                                    /// <para>Indicates whether it is a reference.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>true</para>
                                    /// </summary>
                                    [NameInMap("Select")]
                                    [Validation(Required=false)]
                                    public bool? Select { get; set; }

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
                                    /// <para>Summary.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Summary")]
                                    [Validation(Required=false)]
                                    public string Summary { get; set; }

                                    /// <summary>
                                    /// <para>Tag name.</para>
                                    /// </summary>
                                    [NameInMap("Tags")]
                                    [Validation(Required=false)]
                                    public List<string> Tags { get; set; }

                                    /// <summary>
                                    /// <para>Title.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Title")]
                                    [Validation(Required=false)]
                                    public string Title { get; set; }

                                    /// <summary>
                                    /// <para>Traceability ID.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public int? TraceabilityId { get; set; }

                                    /// <summary>
                                    /// <para>Article URL.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Url")]
                                    [Validation(Required=false)]
                                    public string Url { get; set; }

                                }

                                /// <summary>
                                /// <para>Text generation result.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>xx</para>
                                /// </summary>
                                [NameInMap("TextGenerate")]
                                [Validation(Required=false)]
                                public string TextGenerate { get; set; }

                                /// <summary>
                                /// <para>List of accompanying images.</para>
                                /// </summary>
                                [NameInMap("TextGenerateMultimodalMediaList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultTextGenerateMultimodalMediaList> TextGenerateMultimodalMediaList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultTextGenerateMultimodalMediaList : TeaModel {
                                    /// <summary>
                                    /// <para>End position.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("End")]
                                    [Validation(Required=false)]
                                    public int? End { get; set; }

                                    /// <summary>
                                    /// <para>List of multimodal data.</para>
                                    /// </summary>
                                    [NameInMap("MultimodalMediaList")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultTextGenerateMultimodalMediaListMultimodalMediaList> MultimodalMediaList { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultTextGenerateMultimodalMediaListMultimodalMediaList : TeaModel {
                                        /// <summary>
                                        /// <para>Article.</para>
                                        /// </summary>
                                        [NameInMap("Article")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultTextGenerateMultimodalMediaListMultimodalMediaListArticle Article { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextGenerateResultTextGenerateMultimodalMediaListMultimodalMediaListArticle : TeaModel {
                                            /// <summary>
                                            /// <para>Custom unique document ID.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocId")]
                                            [Validation(Required=false)]
                                            public string DocId { get; set; }

                                            /// <summary>
                                            /// <para>Internal unique document identifier.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocUuid")]
                                            [Validation(Required=false)]
                                            public string DocUuid { get; set; }

                                            /// <summary>
                                            /// <para>Search source name.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("SearchSourceName")]
                                            [Validation(Required=false)]
                                            public string SearchSourceName { get; set; }

                                            /// <summary>
                                            /// <para>Summary.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Summary")]
                                            [Validation(Required=false)]
                                            public string Summary { get; set; }

                                            /// <summary>
                                            /// <para>Title.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Title")]
                                            [Validation(Required=false)]
                                            public string Title { get; set; }

                                            /// <summary>
                                            /// <para>Article URL.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Url")]
                                            [Validation(Required=false)]
                                            public string Url { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>File URL.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("FileUrl")]
                                        [Validation(Required=false)]
                                        public string FileUrl { get; set; }

                                        /// <summary>
                                        /// <para>Media asset ID.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("MediaId")]
                                        [Validation(Required=false)]
                                        public string MediaId { get; set; }

                                        /// <summary>
                                        /// <para>Multimodal file type. Valid values: video, image.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>image</para>
                                        /// </summary>
                                        [NameInMap("MediaType")]
                                        [Validation(Required=false)]
                                        public string MediaType { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>Start position.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("Start")]
                                    [Validation(Required=false)]
                                    public int? Start { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>Text document search result.</para>
                            /// </summary>
                            [NameInMap("TextSearchResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextSearchResult TextSearchResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextSearchResult : TeaModel {
                                /// <summary>
                                /// <para>Current page.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Current")]
                                [Validation(Required=false)]
                                public int? Current { get; set; }

                                /// <summary>
                                /// <para>The structure of the search result.</para>
                                /// </summary>
                                [NameInMap("SearchResult")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextSearchResultSearchResult> SearchResult { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTextSearchResultSearchResult : TeaModel {
                                    /// <summary>
                                    /// <para>Unique category identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("CategoryUuid")]
                                    [Validation(Required=false)]
                                    public string CategoryUuid { get; set; }

                                    /// <summary>
                                    /// <para>Body.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Content")]
                                    [Validation(Required=false)]
                                    public string Content { get; set; }

                                    /// <summary>
                                    /// <para>Unique document business identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocId")]
                                    [Validation(Required=false)]
                                    public string DocId { get; set; }

                                    /// <summary>
                                    /// <para>System internal unique document identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocUuid")]
                                    [Validation(Required=false)]
                                    public string DocUuid { get; set; }

                                    /// <summary>
                                    /// <para>Extension field 1.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Extend1")]
                                    [Validation(Required=false)]
                                    public string Extend1 { get; set; }

                                    /// <summary>
                                    /// <para>Extension field 2.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Extend2")]
                                    [Validation(Required=false)]
                                    public string Extend2 { get; set; }

                                    /// <summary>
                                    /// <para>Extension field 3.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Extend3")]
                                    [Validation(Required=false)]
                                    public string Extend3 { get; set; }

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
                                    /// <para>Data source unique identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>QuarkCommonNews</para>
                                    /// </summary>
                                    [NameInMap("SearchSource")]
                                    [Validation(Required=false)]
                                    public string SearchSource { get; set; }

                                    /// <summary>
                                    /// <para>Data source description.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xxx</para>
                                    /// </summary>
                                    [NameInMap("SearchSourceName")]
                                    [Validation(Required=false)]
                                    public string SearchSourceName { get; set; }

                                    /// <summary>
                                    /// <para>Data source type.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>SystemSearch</para>
                                    /// </summary>
                                    [NameInMap("SearchSourceType")]
                                    [Validation(Required=false)]
                                    public string SearchSourceType { get; set; }

                                    /// <summary>
                                    /// <para>Summary.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Summary")]
                                    [Validation(Required=false)]
                                    public string Summary { get; set; }

                                    /// <summary>
                                    /// <para>Tag name.</para>
                                    /// </summary>
                                    [NameInMap("Tags")]
                                    [Validation(Required=false)]
                                    public List<string> Tags { get; set; }

                                    /// <summary>
                                    /// <para>Title.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Title")]
                                    [Validation(Required=false)]
                                    public string Title { get; set; }

                                    /// <summary>
                                    /// <para>Unique traceability identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public string TraceabilityId { get; set; }

                                    /// <summary>
                                    /// <para>URL.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Url")]
                                    [Validation(Required=false)]
                                    public string Url { get; set; }

                                }

                                /// <summary>
                                /// <para>Current page size.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Size")]
                                [Validation(Required=false)]
                                public int? Size { get; set; }

                                /// <summary>
                                /// <para>Total count.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Total")]
                                [Validation(Required=false)]
                                public int? Total { get; set; }

                            }

                            /// <summary>
                            /// <para>Result of summarizing by time.</para>
                            /// </summary>
                            [NameInMap("TimelineResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResult TimelineResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResult : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether the current agent has finished generating.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("GenerateFinished")]
                                [Validation(Required=false)]
                                public bool? GenerateFinished { get; set; }

                                /// <summary>
                                /// <para>Traceability information.</para>
                                /// </summary>
                                [NameInMap("GenerateTraceability")]
                                [Validation(Required=false)]
                                public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceability GenerateTraceability { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceability : TeaModel {
                                    /// <summary>
                                    /// <para>Traceability location.</para>
                                    /// </summary>
                                    [NameInMap("Coordinates")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceabilityCoordinates> Coordinates { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceabilityCoordinates : TeaModel {
                                        /// <summary>
                                        /// <para>Coordinates of the generated document block.</para>
                                        /// </summary>
                                        [NameInMap("GenerateCoordinate")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceabilityCoordinatesGenerateCoordinate GenerateCoordinate { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceabilityCoordinatesGenerateCoordinate : TeaModel {
                                            /// <summary>
                                            /// <para>Number, starting from 1.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("X")]
                                            [Validation(Required=false)]
                                            public int? X { get; set; }

                                            /// <summary>
                                            /// <para>Start position.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Y")]
                                            [Validation(Required=false)]
                                            public int? Y { get; set; }

                                            /// <summary>
                                            /// <para>End position.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Z")]
                                            [Validation(Required=false)]
                                            public int? Z { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>Coordinates of the reference article.</para>
                                        /// </summary>
                                        [NameInMap("NewsCoordinate")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceabilityCoordinatesNewsCoordinate NewsCoordinate { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultGenerateTraceabilityCoordinatesNewsCoordinate : TeaModel {
                                            /// <summary>
                                            /// <para>Media asset type.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>image</para>
                                            /// </summary>
                                            [NameInMap("MediaType")]
                                            [Validation(Required=false)]
                                            public string MediaType { get; set; }

                                            /// <summary>
                                            /// <para>Number, starting from 1.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("X")]
                                            [Validation(Required=false)]
                                            public int? X { get; set; }

                                            /// <summary>
                                            /// <para>Start position.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Y")]
                                            [Validation(Required=false)]
                                            public int? Y { get; set; }

                                            /// <summary>
                                            /// <para>End position.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("Z")]
                                            [Validation(Required=false)]
                                            public int? Z { get; set; }

                                        }

                                    }

                                    /// <summary>
                                    /// <para>Relevance score.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0.9</para>
                                    /// </summary>
                                    [NameInMap("Duplicate")]
                                    [Validation(Required=false)]
                                    public double? Duplicate { get; set; }

                                }

                                /// <summary>
                                /// <para>List of multimodal search results.</para>
                                /// </summary>
                                [NameInMap("MultimodalSearchResultList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultList> MultimodalSearchResultList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultList : TeaModel {
                                    /// <summary>
                                    /// <para>List of search results.</para>
                                    /// </summary>
                                    [NameInMap("SearchResult")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultListSearchResult> SearchResult { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultListSearchResult : TeaModel {
                                        /// <summary>
                                        /// <para>Article.</para>
                                        /// </summary>
                                        [NameInMap("Article")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultListSearchResultArticle Article { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultListSearchResultArticle : TeaModel {
                                            /// <summary>
                                            /// <para>Custom unique document ID.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocId")]
                                            [Validation(Required=false)]
                                            public string DocId { get; set; }

                                            /// <summary>
                                            /// <para>Internal unique document identifier.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocUuid")]
                                            [Validation(Required=false)]
                                            public string DocUuid { get; set; }

                                            /// <summary>
                                            /// <para>Search source name.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>互联网搜索</para>
                                            /// </summary>
                                            [NameInMap("SearchSourceName")]
                                            [Validation(Required=false)]
                                            public string SearchSourceName { get; set; }

                                            /// <summary>
                                            /// <para>Summary.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Summary")]
                                            [Validation(Required=false)]
                                            public string Summary { get; set; }

                                            /// <summary>
                                            /// <para>Title.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Title")]
                                            [Validation(Required=false)]
                                            public string Title { get; set; }

                                            /// <summary>
                                            /// <para>Article URL.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Url")]
                                            [Validation(Required=false)]
                                            public string Url { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>List of matching segments.</para>
                                        /// </summary>
                                        [NameInMap("ClipInfos")]
                                        [Validation(Required=false)]
                                        public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultListSearchResultClipInfos> ClipInfos { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultMultimodalSearchResultListSearchResultClipInfos : TeaModel {
                                            /// <summary>
                                            /// <para>Start time.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("From")]
                                            [Validation(Required=false)]
                                            public double? From { get; set; }

                                            /// <summary>
                                            /// <para>Confidence score. For reference only.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>0.99</para>
                                            /// </summary>
                                            [NameInMap("Score")]
                                            [Validation(Required=false)]
                                            public double? Score { get; set; }

                                            /// <summary>
                                            /// <para>Corresponding text, such as ASR transcription.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Text")]
                                            [Validation(Required=false)]
                                            public string Text { get; set; }

                                            /// <summary>
                                            /// <para>End time.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>1</para>
                                            /// </summary>
                                            [NameInMap("To")]
                                            [Validation(Required=false)]
                                            public double? To { get; set; }

                                            /// <summary>
                                            /// <para>Type. Example: asr.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>asr</para>
                                            /// </summary>
                                            [NameInMap("Type")]
                                            [Validation(Required=false)]
                                            public string Type { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>File URL.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("FileUrl")]
                                        [Validation(Required=false)]
                                        public string FileUrl { get; set; }

                                        /// <summary>
                                        /// <para>Unique multimodal data identifier.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("MediaId")]
                                        [Validation(Required=false)]
                                        public string MediaId { get; set; }

                                        /// <summary>
                                        /// <para>Multimodal file type. Valid values: video, image.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>image</para>
                                        /// </summary>
                                        [NameInMap("MediaType")]
                                        [Validation(Required=false)]
                                        public string MediaType { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>Date string.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>2024-09-11</para>
                                    /// </summary>
                                    [NameInMap("TimelineDateStr")]
                                    [Validation(Required=false)]
                                    public string TimelineDateStr { get; set; }

                                }

                                /// <summary>
                                /// <para>Deep thinking content.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>xx</para>
                                /// </summary>
                                [NameInMap("ReasonTextGenerate")]
                                [Validation(Required=false)]
                                public string ReasonTextGenerate { get; set; }

                                /// <summary>
                                /// <para>List of reference articles.</para>
                                /// </summary>
                                [NameInMap("ReferenceList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultReferenceList> ReferenceList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultReferenceList : TeaModel {
                                    /// <summary>
                                    /// <para>Unique category identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("CategoryUuid")]
                                    [Validation(Required=false)]
                                    public string CategoryUuid { get; set; }

                                    /// <summary>
                                    /// <para>List of chunks.</para>
                                    /// </summary>
                                    [NameInMap("Chunks")]
                                    [Validation(Required=false)]
                                    public List<string> Chunks { get; set; }

                                    /// <summary>
                                    /// <para>Body.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Content")]
                                    [Validation(Required=false)]
                                    public string Content { get; set; }

                                    /// <summary>
                                    /// <para>Custom unique document ID.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocId")]
                                    [Validation(Required=false)]
                                    public string DocId { get; set; }

                                    /// <summary>
                                    /// <para>Internal unique document identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("DocUuid")]
                                    [Validation(Required=false)]
                                    public string DocUuid { get; set; }

                                    /// <summary>
                                    /// <para>Extension field 1.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Extend1")]
                                    [Validation(Required=false)]
                                    public string Extend1 { get; set; }

                                    /// <summary>
                                    /// <para>Extension field 2.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Extend2")]
                                    [Validation(Required=false)]
                                    public string Extend2 { get; set; }

                                    /// <summary>
                                    /// <para>Extension field 3.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Extend3")]
                                    [Validation(Required=false)]
                                    public string Extend3 { get; set; }

                                    /// <summary>
                                    /// <para>Publication time. Format: yyyy-MM-dd HH:mm:ss.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>2023-04-04 08:39:09</para>
                                    /// </summary>
                                    [NameInMap("PubTime")]
                                    [Validation(Required=false)]
                                    public string PubTime { get; set; }

                                    /// <summary>
                                    /// <para>Confidence score. For reference only.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0.99</para>
                                    /// </summary>
                                    [NameInMap("Score")]
                                    [Validation(Required=false)]
                                    public float? Score { get; set; }

                                    /// <summary>
                                    /// <para>Search source unique identifier. Same as searchSource.datasetName.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>QuarkCommonNews</para>
                                    /// </summary>
                                    [NameInMap("SearchSource")]
                                    [Validation(Required=false)]
                                    public string SearchSource { get; set; }

                                    /// <summary>
                                    /// <para>Search source name.</para>
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
                                    /// <para>Selection status.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>true</para>
                                    /// </summary>
                                    [NameInMap("Select")]
                                    [Validation(Required=false)]
                                    public bool? Select { get; set; }

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
                                    /// <para>Summary.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Summary")]
                                    [Validation(Required=false)]
                                    public string Summary { get; set; }

                                    /// <summary>
                                    /// <para>Tag name.</para>
                                    /// </summary>
                                    [NameInMap("Tags")]
                                    [Validation(Required=false)]
                                    public List<string> Tags { get; set; }

                                    /// <summary>
                                    /// <para>Title.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Title")]
                                    [Validation(Required=false)]
                                    public string Title { get; set; }

                                    /// <summary>
                                    /// <para>Traceability ID.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public int? TraceabilityId { get; set; }

                                    /// <summary>
                                    /// <para>Article URL.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("Url")]
                                    [Validation(Required=false)]
                                    public string Url { get; set; }

                                }

                                /// <summary>
                                /// <para>Text generation result.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>xx</para>
                                /// </summary>
                                [NameInMap("TextGenerate")]
                                [Validation(Required=false)]
                                public string TextGenerate { get; set; }

                                /// <summary>
                                /// <para>List of accompanying images.</para>
                                /// </summary>
                                [NameInMap("TextGenerateMultimodalMediaList")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultTextGenerateMultimodalMediaList> TextGenerateMultimodalMediaList { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultTextGenerateMultimodalMediaList : TeaModel {
                                    /// <summary>
                                    /// <para>End position.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("End")]
                                    [Validation(Required=false)]
                                    public int? End { get; set; }

                                    /// <summary>
                                    /// <para>List of multimodal data.</para>
                                    /// </summary>
                                    [NameInMap("MultimodalMediaList")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultTextGenerateMultimodalMediaListMultimodalMediaList> MultimodalMediaList { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultTextGenerateMultimodalMediaListMultimodalMediaList : TeaModel {
                                        /// <summary>
                                        /// <para>Article.</para>
                                        /// </summary>
                                        [NameInMap("Article")]
                                        [Validation(Required=false)]
                                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultTextGenerateMultimodalMediaListMultimodalMediaListArticle Article { get; set; }
                                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentTimelineResultTextGenerateMultimodalMediaListMultimodalMediaListArticle : TeaModel {
                                            /// <summary>
                                            /// <para>Custom unique document ID.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocId")]
                                            [Validation(Required=false)]
                                            public string DocId { get; set; }

                                            /// <summary>
                                            /// <para>Internal unique document identifier.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("DocUuid")]
                                            [Validation(Required=false)]
                                            public string DocUuid { get; set; }

                                            /// <summary>
                                            /// <para>Search source name.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>互联网搜索</para>
                                            /// </summary>
                                            [NameInMap("SearchSourceName")]
                                            [Validation(Required=false)]
                                            public string SearchSourceName { get; set; }

                                            /// <summary>
                                            /// <para>Summary.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Summary")]
                                            [Validation(Required=false)]
                                            public string Summary { get; set; }

                                            /// <summary>
                                            /// <para>Title.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xxxx</para>
                                            /// </summary>
                                            [NameInMap("Title")]
                                            [Validation(Required=false)]
                                            public string Title { get; set; }

                                            /// <summary>
                                            /// <para>Article URL.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>xx</para>
                                            /// </summary>
                                            [NameInMap("Url")]
                                            [Validation(Required=false)]
                                            public string Url { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>File URL.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("FileUrl")]
                                        [Validation(Required=false)]
                                        public string FileUrl { get; set; }

                                        /// <summary>
                                        /// <para>Unique multimodal data identifier.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("MediaId")]
                                        [Validation(Required=false)]
                                        public string MediaId { get; set; }

                                        /// <summary>
                                        /// <para>Multimodal file type. Valid values: video, image.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>image</para>
                                        /// </summary>
                                        [NameInMap("MediaType")]
                                        [Validation(Required=false)]
                                        public string MediaType { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>Start position.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("Start")]
                                    [Validation(Required=false)]
                                    public int? Start { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>Video search result.</para>
                            /// </summary>
                            [NameInMap("VideoSearchResult")]
                            [Validation(Required=false)]
                            public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResult VideoSearchResult { get; set; }
                            public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResult : TeaModel {
                                /// <summary>
                                /// <para>List of search results.</para>
                                /// </summary>
                                [NameInMap("SearchResult")]
                                [Validation(Required=false)]
                                public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResultSearchResult> SearchResult { get; set; }
                                public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResultSearchResult : TeaModel {
                                    /// <summary>
                                    /// <para>Article.</para>
                                    /// </summary>
                                    [NameInMap("Article")]
                                    [Validation(Required=false)]
                                    public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResultSearchResultArticle Article { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResultSearchResultArticle : TeaModel {
                                        /// <summary>
                                        /// <para>Unique category identifier.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("CategoryUuid")]
                                        [Validation(Required=false)]
                                        public string CategoryUuid { get; set; }

                                        /// <summary>
                                        /// <para>Custom unique document ID.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocId")]
                                        [Validation(Required=false)]
                                        public string DocId { get; set; }

                                        /// <summary>
                                        /// <para>Internal unique document identifier.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("DocUuid")]
                                        [Validation(Required=false)]
                                        public string DocUuid { get; set; }

                                        /// <summary>
                                        /// <para>Extension field 1.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Extend1")]
                                        [Validation(Required=false)]
                                        public string Extend1 { get; set; }

                                        /// <summary>
                                        /// <para>Extension field 2.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Extend2")]
                                        [Validation(Required=false)]
                                        public string Extend2 { get; set; }

                                        /// <summary>
                                        /// <para>Extension field 3.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Extend3")]
                                        [Validation(Required=false)]
                                        public string Extend3 { get; set; }

                                        /// <summary>
                                        /// <para>Search source name.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>互联网搜索</para>
                                        /// </summary>
                                        [NameInMap("SearchSourceName")]
                                        [Validation(Required=false)]
                                        public string SearchSourceName { get; set; }

                                        /// <summary>
                                        /// <para>Summary.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Summary")]
                                        [Validation(Required=false)]
                                        public string Summary { get; set; }

                                        /// <summary>
                                        /// <para>Tags.</para>
                                        /// </summary>
                                        [NameInMap("Tags")]
                                        [Validation(Required=false)]
                                        public List<string> Tags { get; set; }

                                        /// <summary>
                                        /// <para>Title.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Title")]
                                        [Validation(Required=false)]
                                        public string Title { get; set; }

                                        /// <summary>
                                        /// <para>Article URL.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Url")]
                                        [Validation(Required=false)]
                                        public string Url { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>List of matching segments.</para>
                                    /// </summary>
                                    [NameInMap("ClipInfos")]
                                    [Validation(Required=false)]
                                    public List<RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResultSearchResultClipInfos> ClipInfos { get; set; }
                                    public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextGeneratedContentVideoSearchResultSearchResultClipInfos : TeaModel {
                                        /// <summary>
                                        /// <para>Start time of the segment.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("From")]
                                        [Validation(Required=false)]
                                        public double? From { get; set; }

                                        /// <summary>
                                        /// <para>Confidence score. For reference only.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>0.8</para>
                                        /// </summary>
                                        [NameInMap("Score")]
                                        [Validation(Required=false)]
                                        public double? Score { get; set; }

                                        /// <summary>
                                        /// <para>Corresponding text, such as ASR transcription.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>xx</para>
                                        /// </summary>
                                        [NameInMap("Text")]
                                        [Validation(Required=false)]
                                        public string Text { get; set; }

                                        /// <summary>
                                        /// <para>End time.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("To")]
                                        [Validation(Required=false)]
                                        public double? To { get; set; }

                                        /// <summary>
                                        /// <para>Type. Example: asr.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>asr</para>
                                        /// </summary>
                                        [NameInMap("Type")]
                                        [Validation(Required=false)]
                                        public string Type { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>File URL.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("FileUrl")]
                                    [Validation(Required=false)]
                                    public string FileUrl { get; set; }

                                    /// <summary>
                                    /// <para>Unique multimodal data identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>xx</para>
                                    /// </summary>
                                    [NameInMap("MediaId")]
                                    [Validation(Required=false)]
                                    public string MediaId { get; set; }

                                    /// <summary>
                                    /// <para>Unique traceability identifier.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("TraceabilityId")]
                                    [Validation(Required=false)]
                                    public string TraceabilityId { get; set; }

                                }

                            }

                        }

                        /// <summary>
                        /// <para>Model ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("ModelId")]
                        [Validation(Required=false)]
                        public string ModelId { get; set; }

                        /// <summary>
                        /// <para>Next step: think, search, or generate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>search</para>
                        /// </summary>
                        [NameInMap("NextStep")]
                        [Validation(Required=false)]
                        public string NextStep { get; set; }

                        /// <summary>
                        /// <para>Generation - list of recommendations.</para>
                        /// </summary>
                        [NameInMap("RecommendSearchQueryList")]
                        [Validation(Required=false)]
                        public List<string> RecommendSearchQueryList { get; set; }

                        /// <summary>
                        /// <para>Reasoning - list of query understanding keywords.</para>
                        /// </summary>
                        [NameInMap("SearchKeywords")]
                        [Validation(Required=false)]
                        public List<string> SearchKeywords { get; set; }

                        /// <summary>
                        /// <para>List of text search queries.</para>
                        /// </summary>
                        [NameInMap("SearchQueryList")]
                        [Validation(Required=false)]
                        public List<string> SearchQueryList { get; set; }

                        /// <summary>
                        /// <para>Reasoning - data type to supplement: searchQuery.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>searchQuery</para>
                        /// </summary>
                        [NameInMap("SupplementDataType")]
                        [Validation(Required=false)]
                        public string SupplementDataType { get; set; }

                        /// <summary>
                        /// <para>Reasoning - whether supplementation is needed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("SupplementEnable")]
                        [Validation(Required=false)]
                        public bool? SupplementEnable { get; set; }

                        /// <summary>
                        /// <para>Runtime performance statistics.</para>
                        /// </summary>
                        [NameInMap("TokenCalculate")]
                        [Validation(Required=false)]
                        public RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextTokenCalculate TokenCalculate { get; set; }
                        public class RunSearchGenerationResponseBodyPayloadOutputAgentContextBizContextTokenCalculate : TeaModel {
                            /// <summary>
                            /// <para>First token time.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("FirstTokenTime")]
                            [Validation(Required=false)]
                            public float? FirstTokenTime { get; set; }

                            /// <summary>
                            /// <para>Average number of tokens output per second.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("OutputAvgTime")]
                            [Validation(Required=false)]
                            public float? OutputAvgTime { get; set; }

                            /// <summary>
                            /// <para>Search time cost.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("SearchTime")]
                            [Validation(Required=false)]
                            public float? SearchTime { get; set; }

                            /// <summary>
                            /// <para>Total time cost.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Time")]
                            [Validation(Required=false)]
                            public float? Time { get; set; }

                            /// <summary>
                            /// <para>Total number of tokens.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("TotalTokens")]
                            [Validation(Required=false)]
                            public long? TotalTokens { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>List of messages in research mode.</para>
                /// </summary>
                [NameInMap("Messages")]
                [Validation(Required=false)]
                public List<RunSearchGenerationResponseBodyPayloadOutputMessages> Messages { get; set; }
                public class RunSearchGenerationResponseBodyPayloadOutputMessages : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether clarification is needed.</para>
                    /// </summary>
                    [NameInMap("Clarifications")]
                    [Validation(Required=false)]
                    public bool? Clarifications { get; set; }

                    /// <summary>
                    /// <para>Generated text.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the current node has finished.</para>
                    /// </summary>
                    [NameInMap("GenerateFinished")]
                    [Validation(Required=false)]
                    public bool? GenerateFinished { get; set; }

                    /// <summary>
                    /// <para>Node ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Node code:</para>
                    /// <list type="bullet">
                    /// <item><description><para>generateStartStatement</para>
                    /// </description></item>
                    /// <item><description><para>generateSearchQueries</para>
                    /// </description></item>
                    /// <item><description><para>multiSearch</para>
                    /// </description></item>
                    /// <item><description><para>readSearchResult</para>
                    /// </description></item>
                    /// <item><description><para>reflection</para>
                    /// </description></item>
                    /// <item><description><para>generate</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>generateStartStatement</para>
                    /// </summary>
                    [NameInMap("NodeCode")]
                    [Validation(Required=false)]
                    public string NodeCode { get; set; }

                    /// <summary>
                    /// <para>List of search queries.</para>
                    /// </summary>
                    [NameInMap("SearchQueries")]
                    [Validation(Required=false)]
                    public List<string> SearchQueries { get; set; }

                    /// <summary>
                    /// <para>Current node search query.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("SearchQuery")]
                    [Validation(Required=false)]
                    public string SearchQuery { get; set; }

                    /// <summary>
                    /// <para>Search result.</para>
                    /// </summary>
                    [NameInMap("SearchResult")]
                    [Validation(Required=false)]
                    public List<RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResult> SearchResult { get; set; }
                    public class RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResult : TeaModel {
                        /// <summary>
                        /// <para>List of audio results.</para>
                        /// </summary>
                        [NameInMap("Audios")]
                        [Validation(Required=false)]
                        public List<RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultAudios> Audios { get; set; }
                        public class RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultAudios : TeaModel {
                            /// <summary>
                            /// <para>ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>xx</para>
                            /// </summary>
                            [NameInMap("MediaId")]
                            [Validation(Required=false)]
                            public string MediaId { get; set; }

                        }

                        /// <summary>
                        /// <para>List of image searches.</para>
                        /// </summary>
                        [NameInMap("Images")]
                        [Validation(Required=false)]
                        public List<RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultImages> Images { get; set; }
                        public class RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultImages : TeaModel {
                            /// <summary>
                            /// <para>ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>xx</para>
                            /// </summary>
                            [NameInMap("MediaId")]
                            [Validation(Required=false)]
                            public string MediaId { get; set; }

                        }

                        /// <summary>
                        /// <para>Multimodal search query.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("MultimodalSearchQuery")]
                        [Validation(Required=false)]
                        public string MultimodalSearchQuery { get; set; }

                        /// <summary>
                        /// <para>List of text searches.</para>
                        /// </summary>
                        [NameInMap("Texts")]
                        [Validation(Required=false)]
                        public List<RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultTexts> Texts { get; set; }
                        public class RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultTexts : TeaModel {
                            /// <summary>
                            /// <para>ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>xx</para>
                            /// </summary>
                            [NameInMap("DocUuid")]
                            [Validation(Required=false)]
                            public string DocUuid { get; set; }

                        }

                        /// <summary>
                        /// <para>List of video results.</para>
                        /// </summary>
                        [NameInMap("Videos")]
                        [Validation(Required=false)]
                        public List<RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultVideos> Videos { get; set; }
                        public class RunSearchGenerationResponseBodyPayloadOutputMessagesSearchResultVideos : TeaModel {
                            /// <summary>
                            /// <para>ID.</para>
                            /// 
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

            /// <summary>
            /// <para>Token usage.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunSearchGenerationResponseBodyPayloadUsage Usage { get; set; }
            public class RunSearchGenerationResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>The number of input tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The number of output tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>Total token count</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>Unique request identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
