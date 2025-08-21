// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListCateContentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
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

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListCateContentResponseBodyResult Result { get; set; }
        public class ListCateContentResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            [NameInMap("OpenDataItemList")]
            [Validation(Required=false)]
            public List<ListCateContentResponseBodyResultOpenDataItemList> OpenDataItemList { get; set; }
            public class ListCateContentResponseBodyResultOpenDataItemList : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public List<string> Alias { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Audition")]
                [Validation(Required=false)]
                public bool? Audition { get; set; }

                [NameInMap("Authors")]
                [Validation(Required=false)]
                public List<ListCateContentResponseBodyResultOpenDataItemListAuthors> Authors { get; set; }
                public class ListCateContentResponseBodyResultOpenDataItemListAuthors : TeaModel {
                    [NameInMap("AuthorTypes")]
                    [Validation(Required=false)]
                    public List<string> AuthorTypes { get; set; }

                    [NameInMap("Cover")]
                    [Validation(Required=false)]
                    public ListCateContentResponseBodyResultOpenDataItemListAuthorsCover Cover { get; set; }
                    public class ListCateContentResponseBodyResultOpenDataItemListAuthorsCover : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("CanResize")]
                        [Validation(Required=false)]
                        public bool? CanResize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://a.jpg">https://a.jpg</a></para>
                        /// </summary>
                        [NameInMap("Img")]
                        [Validation(Required=false)]
                        public string Img { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://a.jpg">https://a.jpg</a></para>
                        /// </summary>
                        [NameInMap("Large")]
                        [Validation(Required=false)]
                        public string Large { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://a.jpg">https://a.jpg</a></para>
                        /// </summary>
                        [NameInMap("Mediam")]
                        [Validation(Required=false)]
                        public string Mediam { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://a.jpg">https://a.jpg</a></para>
                        /// </summary>
                        [NameInMap("Medium")]
                        [Validation(Required=false)]
                        public string Medium { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://a.jpg">https://a.jpg</a></para>
                        /// </summary>
                        [NameInMap("Small")]
                        [Validation(Required=false)]
                        public string Small { get; set; }

                    }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MALE</para>
                    /// </summary>
                    [NameInMap("Gender")]
                    [Validation(Required=false)]
                    public string Gender { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>13597709</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Online")]
                    [Validation(Required=false)]
                    public bool? Online { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123123</para>
                    /// </summary>
                    [NameInMap("RawId")]
                    [Validation(Required=false)]
                    public string RawId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>qingting</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>audio</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Charge")]
                [Validation(Required=false)]
                public bool? Charge { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80012017</para>
                /// </summary>
                [NameInMap("CommCateId")]
                [Validation(Required=false)]
                public string CommCateId { get; set; }

                [NameInMap("Cover")]
                [Validation(Required=false)]
                public ListCateContentResponseBodyResultOpenDataItemListCover Cover { get; set; }
                public class ListCateContentResponseBodyResultOpenDataItemListCover : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718285.jpg">http://pic.qtfm.cn/2017/0207/2017020718285.jpg</a></para>
                    /// </summary>
                    [NameInMap("Img")]
                    [Validation(Required=false)]
                    public string Img { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718275.jpg">http://pic.qtfm.cn/2017/0207/2017020718275.jpg</a></para>
                    /// </summary>
                    [NameInMap("Large")]
                    [Validation(Required=false)]
                    public string Large { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718275.jpg">http://pic.qtfm.cn/2017/0207/2017020718275.jpg</a></para>
                    /// </summary>
                    [NameInMap("Mediam")]
                    [Validation(Required=false)]
                    public string Mediam { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://pic.qtfm.cn/2017/0207/20170207175.jpg">http://pic.qtfm.cn/2017/0207/20170207175.jpg</a></para>
                    /// </summary>
                    [NameInMap("Medium")]
                    [Validation(Required=false)]
                    public string Medium { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020675.jpg">http://pic.qtfm.cn/2017/0207/2017020675.jpg</a></para>
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

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HotScore")]
                [Validation(Required=false)]
                public double? HotScore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ALBUM</para>
                /// </summary>
                [NameInMap("ItemType")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>206775</para>
                /// </summary>
                [NameInMap("RawId")]
                [Validation(Required=false)]
                public string RawId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qingting</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>program</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VALID</para>
                /// </summary>
                [NameInMap("Valid")]
                [Validation(Required=false)]
                public string Valid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>26152778</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12002</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

    }

}
