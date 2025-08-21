// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ScgSearchResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>73C67BD9-175A-1324-8202-9FAABBB3E6FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ScgSearchResponseBodyResult> Result { get; set; }
        public class ScgSearchResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Album")]
            [Validation(Required=false)]
            public bool? Album { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1795716629</para>
            /// </summary>
            [NameInMap("AlbumRawId")]
            [Validation(Required=false)]
            public string AlbumRawId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlbumType")]
            [Validation(Required=false)]
            public int? AlbumType { get; set; }

            [NameInMap("Alias")]
            [Validation(Required=false)]
            public List<string> Alias { get; set; }

            [NameInMap("AuthorIds")]
            [Validation(Required=false)]
            public List<long?> AuthorIds { get; set; }

            [NameInMap("AuthorNames")]
            [Validation(Required=false)]
            public List<string> AuthorNames { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>audio</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MUSIC_CONTENT</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("Cover")]
            [Validation(Required=false)]
            public ScgSearchResponseBodyResultCover Cover { get; set; }
            public class ScgSearchResponseBodyResultCover : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg">http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg</a></para>
                /// </summary>
                [NameInMap("Img")]
                [Validation(Required=false)]
                public string Img { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg">http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg</a></para>
                /// </summary>
                [NameInMap("Large")]
                [Validation(Required=false)]
                public string Large { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg">http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg</a></para>
                /// </summary>
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg">http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg</a></para>
                /// </summary>
                [NameInMap("Small")]
                [Validation(Required=false)]
                public string Small { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("canResize")]
                [Validation(Required=false)]
                public bool? CanResize { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsAudition")]
            [Validation(Required=false)]
            public bool? IsAudition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsCharge")]
            [Validation(Required=false)]
            public string IsCharge { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedCharge")]
            [Validation(Required=false)]
            public bool? NeedCharge { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1795716629</para>
            /// </summary>
            [NameInMap("RawId")]
            [Validation(Required=false)]
            public string RawId { get; set; }

            [NameInMap("Singers")]
            [Validation(Required=false)]
            public string Singers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xiami</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportAudition")]
            [Validation(Required=false)]
            public bool? SupportAudition { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>music</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
