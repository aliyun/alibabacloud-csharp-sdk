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
