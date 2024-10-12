// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListHotNewsWithTypeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListHotNewsWithTypeResponseBodyData> Data { get; set; }
        public class ListHotNewsWithTypeResponseBodyData : TeaModel {
            [NameInMap("News")]
            [Validation(Required=false)]
            public List<ListHotNewsWithTypeResponseBodyDataNews> News { get; set; }
            public class ListHotNewsWithTypeResponseBodyDataNews : TeaModel {
                [NameInMap("Author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
                /// </summary>
                [NameInMap("DocUuid")]
                [Validation(Required=false)]
                public string DocUuid { get; set; }

                [NameInMap("ImageUrls")]
                [Validation(Required=false)]
                public List<string> ImageUrls { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-04-11 06:14:07</para>
                /// </summary>
                [NameInMap("PubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                [NameInMap("SearchSource")]
                [Validation(Required=false)]
                public string SearchSource { get; set; }

                [NameInMap("SearchSourceName")]
                [Validation(Required=false)]
                public string SearchSourceName { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-10-14 14:30:00</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxxxx/xxx">http://xxxxx/xxx</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>society</para>
            /// </summary>
            [NameInMap("NewsType")]
            [Validation(Required=false)]
            public string NewsType { get; set; }

            [NameInMap("NewsTypeName")]
            [Validation(Required=false)]
            public string NewsTypeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>77</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

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
        /// <para>数据不存在</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
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

    }

}
