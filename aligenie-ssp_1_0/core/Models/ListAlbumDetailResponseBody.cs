// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListAlbumDetailResponseBody : TeaModel {
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
        /// <para>Id of the request</para>
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
        public ListAlbumDetailResponseBodyResult Result { get; set; }
        public class ListAlbumDetailResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Current page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public long? CurrentPageNum { get; set; }

            /// <summary>
            /// <para>Data information</para>
            /// </summary>
            [NameInMap("OpenDataItemList")]
            [Validation(Required=false)]
            public List<ListAlbumDetailResponseBodyResultOpenDataItemList> OpenDataItemList { get; set; }
            public class ListAlbumDetailResponseBodyResultOpenDataItemList : TeaModel {
                /// <summary>
                /// <para>Alias</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public List<string> Alias { get; set; }

                /// <summary>
                /// <para>Indicates whether the content is available for audition</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Audition")]
                [Validation(Required=false)]
                public bool? Audition { get; set; }

                /// <summary>
                /// <para>Author of the content</para>
                /// </summary>
                [NameInMap("Authors")]
                [Validation(Required=false)]
                public List<ListAlbumDetailResponseBodyResultOpenDataItemListAuthors> Authors { get; set; }
                public class ListAlbumDetailResponseBodyResultOpenDataItemListAuthors : TeaModel {
                    /// <summary>
                    /// <para>Author type</para>
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
                    /// <para>Primary key ID of the author</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12314</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>Whether the author is online</para>
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
                /// <para>Is charged</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Charge")]
                [Validation(Required=false)]
                public bool? Charge { get; set; }

                /// <summary>
                /// <para>category ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>80012017</para>
                /// </summary>
                [NameInMap("CommCateId")]
                [Validation(Required=false)]
                public long? CommCateId { get; set; }

                /// <summary>
                /// <para>Content thumbnail</para>
                /// </summary>
                [NameInMap("Cover")]
                [Validation(Required=false)]
                public ListAlbumDetailResponseBodyResultOpenDataItemListCover Cover { get; set; }
                public class ListAlbumDetailResponseBodyResultOpenDataItemListCover : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether OSS rules can be used for cropping</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("CanResize")]
                    [Validation(Required=false)]
                    public bool? CanResize { get; set; }

                    /// <summary>
                    /// <para>Default image</para>
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
                /// <para>Duration</para>
                /// 
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>popularity score</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("HotScore")]
                [Validation(Required=false)]
                public double? HotScore { get; set; }

                /// <summary>
                /// <para>content ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1231231</para>
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
                /// <para>OrderIndex sequence</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OrderIndex")]
                [Validation(Required=false)]
                public long? OrderIndex { get; set; }

                /// <summary>
                /// <para>Third-party ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>12323423</para>
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
                /// <para>style</para>
                /// </summary>
                [NameInMap("Styles")]
                [Validation(Required=false)]
                public List<string> Styles { get; set; }

                /// <summary>
                /// <para>Title</para>
                /// 
                /// <b>Example:</b>
                /// <para>超能狂少在都市</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Transform favoriteType based on the associated public category</para>
                /// 
                /// <b>Example:</b>
                /// <para>program</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Indicates whether the content is playable</para>
                /// 
                /// <b>Example:</b>
                /// <para>VALID</para>
                /// </summary>
                [NameInMap("Valid")]
                [Validation(Required=false)]
                public string Valid { get; set; }

            }

            /// <summary>
            /// <para>Number of records per page</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>total number of records</para>
            /// 
            /// <b>Example:</b>
            /// <para>21421</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

    }

}
