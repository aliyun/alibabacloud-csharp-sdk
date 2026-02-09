// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListSearchTaskDialoguesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSearchTaskDialoguesResponseBodyData> Data { get; set; }
        public class ListSearchTaskDialoguesResponseBodyData : TeaModel {
            [NameInMap("ChatConfig")]
            [Validation(Required=false)]
            public ListSearchTaskDialoguesResponseBodyDataChatConfig ChatConfig { get; set; }
            public class ListSearchTaskDialoguesResponseBodyDataChatConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("DialogueType")]
                [Validation(Required=false)]
                public int? DialogueType { get; set; }

                [NameInMap("EndToEnd")]
                [Validation(Required=false)]
                public bool? EndToEnd { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>concise</para>
                /// </summary>
                [NameInMap("GenerateLevel")]
                [Validation(Required=false)]
                public string GenerateLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>copilotReference</para>
                /// </summary>
                [NameInMap("GenerateTechnology")]
                [Validation(Required=false)]
                public string GenerateTechnology { get; set; }

                [NameInMap("SearchModels")]
                [Validation(Required=false)]
                public List<string> SearchModels { get; set; }

                [NameInMap("SearchParam")]
                [Validation(Required=false)]
                public ListSearchTaskDialoguesResponseBodyDataChatConfigSearchParam SearchParam { get; set; }
                public class ListSearchTaskDialoguesResponseBodyDataChatConfigSearchParam : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("MultimodalSearchTypes")]
                    [Validation(Required=false)]
                    public List<string> MultimodalSearchTypes { get; set; }

                    [NameInMap("SearchSources")]
                    [Validation(Required=false)]
                    public List<ListSearchTaskDialoguesResponseBodyDataChatConfigSearchParamSearchSources> SearchSources { get; set; }
                    public class ListSearchTaskDialoguesResponseBodyDataChatConfigSearchParamSearchSources : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>x\&quot;x</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("DatasetName")]
                        [Validation(Required=false)]
                        public string DatasetName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>x</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-25 13:33:01</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("DialogueType")]
            [Validation(Required=false)]
            public int? DialogueType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("GoodText")]
            [Validation(Required=false)]
            public string GoodText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("OriginSessionId")]
            [Validation(Required=false)]
            public string OriginSessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>thumbsUp</para>
            /// </summary>
            [NameInMap("Rating")]
            [Validation(Required=false)]
            public string Rating { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ResponseBodyStr")]
            [Validation(Required=false)]
            public string ResponseBodyStr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
