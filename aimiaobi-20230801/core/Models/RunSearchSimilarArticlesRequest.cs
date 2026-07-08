// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunSearchSimilarArticlesRequest : TeaModel {
        /// <summary>
        /// <para>Communication configuration parameters.</para>
        /// </summary>
        [NameInMap("ChatConfig")]
        [Validation(Required=false)]
        public RunSearchSimilarArticlesRequestChatConfig ChatConfig { get; set; }
        public class RunSearchSimilarArticlesRequestChatConfig : TeaModel {
            /// <summary>
            /// <para>Search configuration parameters.</para>
            /// </summary>
            [NameInMap("SearchParam")]
            [Validation(Required=false)]
            public RunSearchSimilarArticlesRequestChatConfigSearchParam SearchParam { get; set; }
            public class RunSearchSimilarArticlesRequestChatConfigSearchParam : TeaModel {
                /// <summary>
                /// <para>Category UUID</para>
                /// </summary>
                [NameInMap("CategoryUuids")]
                [Validation(Required=false)]
                public List<string> CategoryUuids { get; set; }

                /// <summary>
                /// <para>Creation Time cutoff, in UNIX timestamp format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("CreateTimeEnd")]
                [Validation(Required=false)]
                public long? CreateTimeEnd { get; set; }

                /// <summary>
                /// <para>Start Creation Time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("CreateTimeStart")]
                [Validation(Required=false)]
                public long? CreateTimeStart { get; set; }

                /// <summary>
                /// <para>Document ID</para>
                /// </summary>
                [NameInMap("DocIds")]
                [Validation(Required=false)]
                public List<string> DocIds { get; set; }

                /// <summary>
                /// <para>Document types: text, image, video, audio, pdf, word, ppt, etc.</para>
                /// </summary>
                [NameInMap("DocTypes")]
                [Validation(Required=false)]
                public List<string> DocTypes { get; set; }

                /// <summary>
                /// <para>Document UUID</para>
                /// </summary>
                [NameInMap("DocUuids")]
                [Validation(Required=false)]
                public List<string> DocUuids { get; set; }

                /// <summary>
                /// <para>End Time</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>Extension Field 1</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Extend1")]
                [Validation(Required=false)]
                public string Extend1 { get; set; }

                /// <summary>
                /// <para>Extension Field 2</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Extend2")]
                [Validation(Required=false)]
                public string Extend2 { get; set; }

                /// <summary>
                /// <para>Extension Field 3</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Extend3")]
                [Validation(Required=false)]
                public string Extend3 { get; set; }

                /// <summary>
                /// <para>Search sources.</para>
                /// </summary>
                [NameInMap("SearchSources")]
                [Validation(Required=false)]
                public List<RunSearchSimilarArticlesRequestChatConfigSearchParamSearchSources> SearchSources { get; set; }
                public class RunSearchSimilarArticlesRequestChatConfigSearchParamSearchSources : TeaModel {
                    /// <summary>
                    /// <para>Search source type:</para>
                    /// <list type="bullet">
                    /// <item><description><para>SystemSearch: Built-in system search.</para>
                    /// </description></item>
                    /// <item><description><para>CustomSemanticSearch: Custom semantic index search.</para>
                    /// </description></item>
                    /// <item><description><para>ThirdSearch: Third-party API search.</para>
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
                    /// <para>Unique identifier of the search source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>QuarkCommonNews</para>
                    /// </summary>
                    [NameInMap("DatasetName")]
                    [Validation(Required=false)]
                    public string DatasetName { get; set; }

                    /// <summary>
                    /// <para>Search source name (optional).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>互联网搜索</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>Start Time</para>
                /// 
                /// <b>Example:</b>
                /// <para>1725983999999</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>Tag Name</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

            }

        }

        /// <summary>
        /// <para>Document type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>html</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>Article title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>Article URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx/xxx">https://xxx/xxx</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <para>Unique identifier of the Alibaba Cloud Model Studio workspace. To get this ID, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get the workspace ID</a>.</para>
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
