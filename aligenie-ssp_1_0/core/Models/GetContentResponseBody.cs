// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetContentResponseBody : TeaModel {
        /// <summary>
        /// <para>Code encoding</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Message information</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>F12B6147-5925-19E5-A3AD-E1EE1360F34E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return Result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetContentResponseBodyResult Result { get; set; }
        public class GetContentResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>ID of the corresponding album</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231</para>
            /// </summary>
            [NameInMap("AlbumId")]
            [Validation(Required=false)]
            public string AlbumId { get; set; }

            /// <summary>
            /// <para>Alias</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public List<string> Alias { get; set; }

            /// <summary>
            /// <para>Is audition available</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Audition")]
            [Validation(Required=false)]
            public bool? Audition { get; set; }

            /// <summary>
            /// <para>Content authors</para>
            /// </summary>
            [NameInMap("Authors")]
            [Validation(Required=false)]
            public List<GetContentResponseBodyResultAuthors> Authors { get; set; }
            public class GetContentResponseBodyResultAuthors : TeaModel {
                /// <summary>
                /// <para>author type</para>
                /// </summary>
                [NameInMap("AuthorTypes")]
                [Validation(Required=false)]
                public List<string> AuthorTypes { get; set; }

                /// <summary>
                /// <para>Gender</para>
                /// 
                /// <b>Example:</b>
                /// <para>MALE</para>
                /// </summary>
                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                /// <summary>
                /// <para>Author primary key ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Is online</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Online")]
                [Validation(Required=false)]
                public bool? Online { get; set; }

                /// <summary>
                /// <para>Source</para>
                /// 
                /// <b>Example:</b>
                /// <para>qingting</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>Author title</para>
                /// 
                /// <b>Example:</b>
                /// <para>播音呆瓜小贼</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Transform controlType based on the associated public category</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>is charged</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Charge")]
            [Validation(Required=false)]
            public bool? Charge { get; set; }

            /// <summary>
            /// <para>ID of the corresponding category</para>
            /// 
            /// <b>Example:</b>
            /// <para>80012017</para>
            /// </summary>
            [NameInMap("CommCateId")]
            [Validation(Required=false)]
            public long? CommCateId { get; set; }

            /// <summary>
            /// <para>album thumbnail image</para>
            /// </summary>
            [NameInMap("Cover")]
            [Validation(Required=false)]
            public GetContentResponseBodyResultCover Cover { get; set; }
            public class GetContentResponseBodyResultCover : TeaModel {
                /// <summary>
                /// <para>Indicates whether OSS rules can be used to crop the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("CanResize")]
                [Validation(Required=false)]
                public bool? CanResize { get; set; }

                /// <summary>
                /// <para>default image</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718285.jpg">http://pic.qtfm.cn/2017/0207/2017020718285.jpg</a></para>
                /// </summary>
                [NameInMap("Img")]
                [Validation(Required=false)]
                public string Img { get; set; }

                /// <summary>
                /// <para>Large image</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718285.jpg">http://pic.qtfm.cn/2017/0207/2017020718285.jpg</a></para>
                /// </summary>
                [NameInMap("Large")]
                [Validation(Required=false)]
                public string Large { get; set; }

                /// <summary>
                /// <para>Medium image</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718285.jpg">http://pic.qtfm.cn/2017/0207/2017020718285.jpg</a></para>
                /// </summary>
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                /// <summary>
                /// <para>Small image</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718285.jpg">http://pic.qtfm.cn/2017/0207/2017020718285.jpg</a></para>
                /// </summary>
                [NameInMap("Small")]
                [Validation(Required=false)]
                public string Small { get; set; }

            }

            /// <summary>
            /// <para>Content description</para>
            /// 
            /// <b>Example:</b>
            /// <para>内容描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>duration information</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>Popularity score</para>
            /// 
            /// <b>Example:</b>
            /// <para>内容描述</para>
            /// </summary>
            [NameInMap("HotScore")]
            [Validation(Required=false)]
            public double? HotScore { get; set; }

            /// <summary>
            /// <para>Content ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>13597709</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Type of content, such as music, audio, radio, jokes, etc.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALBUM</para>
            /// </summary>
            [NameInMap("ItemType")]
            [Validation(Required=false)]
            public string ItemType { get; set; }

            /// <summary>
            /// <para>Lyric information</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://1231.lrc">http://1231.lrc</a></para>
            /// </summary>
            [NameInMap("Lyric")]
            [Validation(Required=false)]
            public string Lyric { get; set; }

            /// <summary>
            /// <para>third-party ID of the content</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231231</para>
            /// </summary>
            [NameInMap("RawId")]
            [Validation(Required=false)]
            public string RawId { get; set; }

            /// <summary>
            /// <para>Source</para>
            /// 
            /// <b>Example:</b>
            /// <para>qingting</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>Genre</para>
            /// </summary>
            [NameInMap("Styles")]
            [Validation(Required=false)]
            public List<string> Styles { get; set; }

            /// <summary>
            /// <para>title</para>
            /// 
            /// <b>Example:</b>
            /// <para>超能狂少在都市</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>Transform to favoriteType based on the associated public category</para>
            /// 
            /// <b>Example:</b>
            /// <para>program</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Indicates whether the content is playable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("Valid")]
            [Validation(Required=false)]
            public string Valid { get; set; }

        }

    }

}
