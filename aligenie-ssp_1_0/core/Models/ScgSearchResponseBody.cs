// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ScgSearchResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

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
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>73C67BD9-175A-1324-8202-9FAABBB3E6FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Detailed returned information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sourceId&quot;:0,&quot;copyright&quot;:0,&quot;releaseTime&quot;:1196438400000,&quot;hotScore&quot;:0.9546929544543479,&quot;tppExtendInfo&quot;:&quot;{\&quot;userEvent\&quot;:\&quot;前台投放\&quot;,\&quot;scgTopicName\&quot;:\&quot;inside民族中国风曲风音乐库\&quot;,\&quot;scgTopicId\&quot;:\&quot;MC201132\&quot;}&quot;,&quot;source&quot;:&quot;xiami&quot;,&quot;title&quot;:&quot;题帕三绝&quot;,&quot;type&quot;:&quot;music&quot;,&quot;x1Pv30d&quot;:10307,&quot;valid&quot;:10,&quot;cover&quot;:{&quot;img&quot;:&quot;<a href="http://img.xiami.net/qianxun/07d8ec1a38a5462c3afbfac41413b8af/47244c25fcf3a8f67442d02e3127d023-500x432.jpg%22,%22canResize%22:false%7D,%22duration%22:0,%22rawId%22:%221771626071%22,%22albumType%22:0,%22alias%22:%5B%22%E9%A2%98%E5%B8%95%E4%B8%89%E7%BB%9D%22%5D,%22id%22:268033175,%22supportAudition%22:false,%22contentType%22:%22MUSIC_CONTENT%22,%22authorIds%22:%5B%5D,%22singers%22:%22%E9%99%88%E5%8A%9B%22,%22albumRawId%22:%221771626071%22,%22album%22:false,%22x1PvTotal%22:14676,%22commCateId%22:80021001,%22finished%22:0,%22isAudition%22:false,%22appIds%22:%5B%5D,%22authorNames%22:%5B%22%E9%99%88%E5%8A%9B%22,%22%E7%8E%8B%E7%AB%8B%E5%B9%B3%22,%22%E6%9B%B9%E9%9B%AA%E8%8A%B9%22%5D,%22needCharge%22:false,%22isCharge%22:false,%22category%22:%22audio%22%7D">http://img.xiami.net/qianxun/07d8ec1a38a5462c3afbfac41413b8af/47244c25fcf3a8f67442d02e3127d023-500x432.jpg&quot;,&quot;canResize&quot;:false},&quot;duration&quot;:0,&quot;rawId&quot;:&quot;1771626071&quot;,&quot;albumType&quot;:0,&quot;alias&quot;:[&quot;题帕三绝&quot;],&quot;id&quot;:268033175,&quot;supportAudition&quot;:false,&quot;contentType&quot;:&quot;MUSIC_CONTENT&quot;,&quot;authorIds&quot;:[],&quot;singers&quot;:&quot;陈力&quot;,&quot;albumRawId&quot;:&quot;1771626071&quot;,&quot;album&quot;:false,&quot;x1PvTotal&quot;:14676,&quot;commCateId&quot;:80021001,&quot;finished&quot;:0,&quot;isAudition&quot;:false,&quot;appIds&quot;:[],&quot;authorNames&quot;:[&quot;陈力&quot;,&quot;王立平&quot;,&quot;曹雪芹&quot;],&quot;needCharge&quot;:false,&quot;isCharge&quot;:false,&quot;category&quot;:&quot;audio&quot;}</a></para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ScgSearchResponseBodyResult> Result { get; set; }
        public class ScgSearchResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Whether it is an album</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Album")]
            [Validation(Required=false)]
            public bool? Album { get; set; }

            /// <summary>
            /// <para>Album ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1795716629</para>
            /// </summary>
            [NameInMap("AlbumRawId")]
            [Validation(Required=false)]
            public string AlbumRawId { get; set; }

            /// <summary>
            /// <para>Album type</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlbumType")]
            [Validation(Required=false)]
            public int? AlbumType { get; set; }

            /// <summary>
            /// <para>Alias</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public List<string> Alias { get; set; }

            /// <summary>
            /// <para>Author ID</para>
            /// </summary>
            [NameInMap("AuthorIds")]
            [Validation(Required=false)]
            public List<long?> AuthorIds { get; set; }

            /// <summary>
            /// <para>Author names</para>
            /// </summary>
            [NameInMap("AuthorNames")]
            [Validation(Required=false)]
            public List<string> AuthorNames { get; set; }

            /// <summary>
            /// <para>Category</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Content type</para>
            /// 
            /// <b>Example:</b>
            /// <para>MUSIC_CONTENT</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>Thumbnail</para>
            /// </summary>
            [NameInMap("Cover")]
            [Validation(Required=false)]
            public ScgSearchResponseBodyResultCover Cover { get; set; }
            public class ScgSearchResponseBodyResultCover : TeaModel {
                /// <summary>
                /// <para>Thumbnail image (Img, Large, Medium, and Small may not appear simultaneously; only one of them may be present)</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg">http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg</a></para>
                /// </summary>
                [NameInMap("Img")]
                [Validation(Required=false)]
                public string Img { get; set; }

                /// <summary>
                /// <para>Large graph</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg">http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg</a></para>
                /// </summary>
                [NameInMap("Large")]
                [Validation(Required=false)]
                public string Large { get; set; }

                /// <summary>
                /// <para>Medium image</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg">http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg</a></para>
                /// </summary>
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                /// <summary>
                /// <para>Small image</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg">http://img.xiami.net/images/album/img59/56/58da2153e3133_2826959_1490690387.jpg</a></para>
                /// </summary>
                [NameInMap("Small")]
                [Validation(Required=false)]
                public string Small { get; set; }

                /// <summary>
                /// <para>Whether scaling is supported</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("canResize")]
                [Validation(Required=false)]
                public bool? CanResize { get; set; }

            }

            /// <summary>
            /// <para>Whether audition is available</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsAudition")]
            [Validation(Required=false)]
            public bool? IsAudition { get; set; }

            /// <summary>
            /// <para>Is charged</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsCharge")]
            [Validation(Required=false)]
            public string IsCharge { get; set; }

            /// <summary>
            /// <para>Whether charging is required</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedCharge")]
            [Validation(Required=false)]
            public bool? NeedCharge { get; set; }

            /// <summary>
            /// <para>Third-party content ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1795716629</para>
            /// </summary>
            [NameInMap("RawId")]
            [Validation(Required=false)]
            public string RawId { get; set; }

            /// <summary>
            /// <para>Singer name</para>
            /// 
            /// <b>Example:</b>
            /// <para>黎偌天</para>
            /// </summary>
            [NameInMap("Singers")]
            [Validation(Required=false)]
            public string Singers { get; set; }

            /// <summary>
            /// <para>Content source</para>
            /// 
            /// <b>Example:</b>
            /// <para>xiami</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>Whether audition is supported</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportAudition")]
            [Validation(Required=false)]
            public bool? SupportAudition { get; set; }

            /// <summary>
            /// <para>Content title</para>
            /// 
            /// <b>Example:</b>
            /// <para>那个人</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>Content type</para>
            /// 
            /// <b>Example:</b>
            /// <para>music</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
