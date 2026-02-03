// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunSearchSimilarArticlesRequest : TeaModel {
        [NameInMap("ChatConfig")]
        [Validation(Required=false)]
        public RunSearchSimilarArticlesRequestChatConfig ChatConfig { get; set; }
        public class RunSearchSimilarArticlesRequestChatConfig : TeaModel {
            [NameInMap("SearchParam")]
            [Validation(Required=false)]
            public RunSearchSimilarArticlesRequestChatConfigSearchParam SearchParam { get; set; }
            public class RunSearchSimilarArticlesRequestChatConfigSearchParam : TeaModel {
                [NameInMap("CategoryUuids")]
                [Validation(Required=false)]
                public List<string> CategoryUuids { get; set; }

                [NameInMap("CreateTimeEnd")]
                [Validation(Required=false)]
                public long? CreateTimeEnd { get; set; }

                [NameInMap("CreateTimeStart")]
                [Validation(Required=false)]
                public long? CreateTimeStart { get; set; }

                [NameInMap("DocIds")]
                [Validation(Required=false)]
                public List<string> DocIds { get; set; }

                [NameInMap("DocTypes")]
                [Validation(Required=false)]
                public List<string> DocTypes { get; set; }

                [NameInMap("DocUuids")]
                [Validation(Required=false)]
                public List<string> DocUuids { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("Extend1")]
                [Validation(Required=false)]
                public string Extend1 { get; set; }

                [NameInMap("Extend2")]
                [Validation(Required=false)]
                public string Extend2 { get; set; }

                [NameInMap("Extend3")]
                [Validation(Required=false)]
                public string Extend3 { get; set; }

                [NameInMap("SearchSources")]
                [Validation(Required=false)]
                public List<RunSearchSimilarArticlesRequestChatConfigSearchParamSearchSources> SearchSources { get; set; }
                public class RunSearchSimilarArticlesRequestChatConfigSearchParamSearchSources : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SystemSearch</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("DatasetName")]
                    [Validation(Required=false)]
                    public string DatasetName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>html</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx/xxx">https://xxx/xxx</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
