// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetAlbumDetailByIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A0B7CACD-485B-14E2-854F-39EACB09E45B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetAlbumDetailByIdResponseBodyResult Result { get; set; }
        public class GetAlbumDetailByIdResponseBodyResult : TeaModel {
            [NameInMap("AlbumContentList")]
            [Validation(Required=false)]
            public List<GetAlbumDetailByIdResponseBodyResultAlbumContentList> AlbumContentList { get; set; }
            public class GetAlbumDetailByIdResponseBodyResultAlbumContentList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3分24秒</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>468009044</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("OrderIndex")]
                [Validation(Required=false)]
                public string OrderIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>001为什么肚子饿时会咕咕叫</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://ailabs.alibabausercontent.com/images/8838/1600839452498.jpg">https://ailabs.alibabausercontent.com/images/8838/1600839452498.jpg</a></para>
            /// </summary>
            [NameInMap("AlbumCoverUrl")]
            [Validation(Required=false)]
            public string AlbumCoverUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>每次一个百科知识或者故事\n丰富孩子的视野，拓展眼界和知识面，培养和孩子的探究能力和好奇心\n\n</para>
            /// </summary>
            [NameInMap("AlbumDescription")]
            [Validation(Required=false)]
            public string AlbumDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>51999575</para>
            /// </summary>
            [NameInMap("AlbumId")]
            [Validation(Required=false)]
            public string AlbumId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小科学家探索</para>
            /// </summary>
            [NameInMap("AlbumTitle")]
            [Validation(Required=false)]
            public string AlbumTitle { get; set; }

        }

    }

}
