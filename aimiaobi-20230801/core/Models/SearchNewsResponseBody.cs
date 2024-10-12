// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SearchNewsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SearchNewsResponseBodyData> Data { get; set; }
        public class SearchNewsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>作者</para>
            /// </summary>
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>文章内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9a598b44c6444da5907b8ea68a5f82c4</para>
            /// </summary>
            [NameInMap("DocUuid")]
            [Validation(Required=false)]
            public string DocUuid { get; set; }

            [NameInMap("ImageUrls")]
            [Validation(Required=false)]
            public List<string> ImageUrls { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-18 06:46:22</para>
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
            /// <para>夸克检索</para>
            /// </summary>
            [NameInMap("SearchSourceName")]
            [Validation(Required=false)]
            public string SearchSourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>央视网</para>
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
            /// <para>文章标签</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>文章标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-18 06:46:22</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>文章URL</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

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
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

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
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
