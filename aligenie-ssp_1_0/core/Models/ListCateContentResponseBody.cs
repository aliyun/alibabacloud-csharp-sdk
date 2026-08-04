// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListCateContentResponseBody : TeaModel {
        /// <summary>
        /// <para>code encoding</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>message information</para>
        /// 
        /// <b>Example:</b>
        /// <para>sucess</para>
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
        public ListCateContentResponseBodyResult Result { get; set; }
        public class ListCateContentResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Current page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            /// <summary>
            /// <para>Data information</para>
            /// </summary>
            [NameInMap("OpenDataItemList")]
            [Validation(Required=false)]
            public List<ListCateContentResponseBodyResultOpenDataItemList> OpenDataItemList { get; set; }
            public class ListCateContentResponseBodyResultOpenDataItemList : TeaModel {
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
                /// <para>true</para>
                /// </summary>
                [NameInMap("Audition")]
                [Validation(Required=false)]
                public bool? Audition { get; set; }

                /// <summary>
                /// <para>author information</para>
                /// </summary>
                [NameInMap("Authors")]
                [Validation(Required=false)]
                public List<ListCateContentResponseBodyResultOpenDataItemListAuthors> Authors { get; set; }
                public class ListCateContentResponseBodyResultOpenDataItemListAuthors : TeaModel {
                    /// <summary>
                    /// <para>Author type</para>
                    /// </summary>
                    [NameInMap("AuthorTypes")]
                    [Validation(Required=false)]
                    public List<string> AuthorTypes { get; set; }

                    /// <summary>
                    /// <para>profile picture</para>
                    /// </summary>
                    [NameInMap("Cover")]
                    [Validation(Required=false)]
                    public ListCateContentResponseBodyResultOpenDataItemListAuthorsCover Cover { get; set; }
                    public class ListCateContentResponseBodyResultOpenDataItemListAuthorsCover : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the image can be cropped using OSS rules.</para>
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
                        /// <para><a href="https://a.jpg">https://a.jpg</a></para>
                        /// </summary>
                        [NameInMap("Img")]
                        [Validation(Required=false)]
                        public string Img { get; set; }

                        /// <summary>
                        /// <para>Large image</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://a.jpg">https://a.jpg</a></para>
                        /// </summary>
                        [NameInMap("Large")]
                        [Validation(Required=false)]
                        public string Large { get; set; }

                        /// <summary>
                        /// <para>Medium image (Deprecated)</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://a.jpg">https://a.jpg</a></para>
                        /// </summary>
                        [NameInMap("Mediam")]
                        [Validation(Required=false)]
                        public string Mediam { get; set; }

                        /// <summary>
                        /// <para>medium image</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://a.jpg">https://a.jpg</a></para>
                        /// </summary>
                        [NameInMap("Medium")]
                        [Validation(Required=false)]
                        public string Medium { get; set; }

                        /// <summary>
                        /// <para>small image</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://a.jpg">https://a.jpg</a></para>
                        /// </summary>
                        [NameInMap("Small")]
                        [Validation(Required=false)]
                        public string Small { get; set; }

                    }

                    /// <summary>
                    /// <para>Author description</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>播音呆瓜小贼</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

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
                    /// <para>Primary key ID of the author information</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>13597709</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>Whether it is online</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Online")]
                    [Validation(Required=false)]
                    public bool? Online { get; set; }

                    /// <summary>
                    /// <para>third-party author ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123123</para>
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
                /// <para>Transform controlType based on the assigned public category</para>
                /// 
                /// <b>Example:</b>
                /// <para>audio</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Whether it is charged</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Charge")]
                [Validation(Required=false)]
                public bool? Charge { get; set; }

                /// <summary>
                /// <para>Category ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>80012017</para>
                /// </summary>
                [NameInMap("CommCateId")]
                [Validation(Required=false)]
                public string CommCateId { get; set; }

                /// <summary>
                /// <para>Album thumbnail image</para>
                /// </summary>
                [NameInMap("Cover")]
                [Validation(Required=false)]
                public ListCateContentResponseBodyResultOpenDataItemListCover Cover { get; set; }
                public class ListCateContentResponseBodyResultOpenDataItemListCover : TeaModel {
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
                    /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718275.jpg">http://pic.qtfm.cn/2017/0207/2017020718275.jpg</a></para>
                    /// </summary>
                    [NameInMap("Large")]
                    [Validation(Required=false)]
                    public string Large { get; set; }

                    /// <summary>
                    /// <para>Medium image (Deprecated)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718275.jpg">http://pic.qtfm.cn/2017/0207/2017020718275.jpg</a></para>
                    /// </summary>
                    [NameInMap("Mediam")]
                    [Validation(Required=false)]
                    public string Mediam { get; set; }

                    /// <summary>
                    /// <para>Medium image</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://pic.qtfm.cn/2017/0207/20170207175.jpg">http://pic.qtfm.cn/2017/0207/20170207175.jpg</a></para>
                    /// </summary>
                    [NameInMap("Medium")]
                    [Validation(Required=false)]
                    public string Medium { get; set; }

                    /// <summary>
                    /// <para>Small image</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020675.jpg">http://pic.qtfm.cn/2017/0207/2017020675.jpg</a></para>
                    /// </summary>
                    [NameInMap("Small")]
                    [Validation(Required=false)]
                    public string Small { get; set; }

                    /// <summary>
                    /// <para>Indicates whether cropping can be performed using OSS rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("canResize")]
                    [Validation(Required=false)]
                    public bool? CanResize { get; set; }

                }

                /// <summary>
                /// <para>Content description</para>
                /// 
                /// <b>Example:</b>
                /// <para>作者：月不醉 简介：啥，假冒你男友？退役兵王回归都市后做了一名小保安，机缘巧合下却被冷艳女总拉去客串男友，从此之后，他与冷艳老总开始纠缠不清···拳打恶一代，脚踩高富帅，哥哥我专治各种不服。面对各类的阴谋阳谋，面对各种黑恶势力，且看哥如何称霸都市，踏上巅峰！</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Popularity score</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HotScore")]
                [Validation(Required=false)]
                public double? HotScore { get; set; }

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
                /// <para>Third-party ID of the album</para>
                /// 
                /// <b>Example:</b>
                /// <para>206775</para>
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
                /// <para>Title</para>
                /// 
                /// <b>Example:</b>
                /// <para>超能狂少在都市</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Transform favoriteType based on the associated public category.</para>
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

                /// <summary>
                /// <para>Primary key ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>26152778</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            /// <summary>
            /// <para>Number of records per page</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of records</para>
            /// 
            /// <b>Example:</b>
            /// <para>12002</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

    }

}
