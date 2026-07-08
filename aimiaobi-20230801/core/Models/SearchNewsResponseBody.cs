// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SearchNewsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SearchNewsResponseBodyData> Data { get; set; }
        public class SearchNewsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The author of the article. This parameter may not be returned for some articles.</para>
            /// 
            /// <b>Example:</b>
            /// <para>作者</para>
            /// </summary>
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }

            /// <summary>
            /// <para>The content of the article. This parameter is always returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The unique ID of the internal document. This parameter is always returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9a598b44c6444da5907b8ea68a5f82c4</para>
            /// </summary>
            [NameInMap("DocUuid")]
            [Validation(Required=false)]
            public string DocUuid { get; set; }

            /// <summary>
            /// <para>The URLs of the images. This parameter is deprecated and is no longer returned. Do not use it.</para>
            /// </summary>
            [NameInMap("ImageUrls")]
            [Validation(Required=false)]
            public List<string> ImageUrls { get; set; }

            /// <summary>
            /// <para>The time when the article was published. This parameter is always returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-18 06:46:22</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            /// <summary>
            /// <para>The ID of the internal search source. This parameter is always returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QuarkCommonNews</para>
            /// </summary>
            [NameInMap("SearchSource")]
            [Validation(Required=false)]
            public string SearchSource { get; set; }

            /// <summary>
            /// <para>The name of the internal search source. This parameter is always returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>夸克检索</para>
            /// </summary>
            [NameInMap("SearchSourceName")]
            [Validation(Required=false)]
            public string SearchSourceName { get; set; }

            /// <summary>
            /// <para>The source of the article. This parameter may not be returned for some articles.</para>
            /// 
            /// <b>Example:</b>
            /// <para>央视网</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The summary of the article. This parameter may not be returned for some articles.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章摘要</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The tag of the article. This parameter may not be returned for some articles.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章标签</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The title of the article. This parameter is always returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The time when the system was updated. This parameter is deprecated and is no longer returned. Do not use it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-18 06:46:22</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The URL of the article. This parameter is always returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文章URL</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of records on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of \<c>true\\</c> indicates success and a value of \<c>false\\</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
