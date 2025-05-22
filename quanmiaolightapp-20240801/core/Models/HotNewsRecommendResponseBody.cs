// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class HotNewsRecommendResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public HotNewsRecommendResponseBodyData Data { get; set; }
        public class HotNewsRecommendResponseBodyData : TeaModel {
            [NameInMap("news")]
            [Validation(Required=false)]
            public List<HotNewsRecommendResponseBodyDataNews> News { get; set; }
            public class HotNewsRecommendResponseBodyDataNews : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("imageUrls")]
                [Validation(Required=false)]
                public List<string> ImageUrls { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-09-10 15:32:00</para>
                /// </summary>
                [NameInMap("pubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                [NameInMap("searchSource")]
                [Validation(Required=false)]
                public string SearchSource { get; set; }

                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxx">http://xxx</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>575D5893-01DB-5C81-A899-74F67616762A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
