// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CreatePlayingListOAuth2ResponseBody : TeaModel {
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
        /// <para>10002398812</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreatePlayingListOAuth2ResponseBodyResult Result { get; set; }
        public class CreatePlayingListOAuth2ResponseBodyResult : TeaModel {
            [NameInMap("AlbumName")]
            [Validation(Required=false)]
            public string AlbumName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>260744</para>
            /// </summary>
            [NameInMap("AlbumRawId")]
            [Validation(Required=false)]
            public string AlbumRawId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>190</para>
            /// </summary>
            [NameInMap("AudioLength")]
            [Validation(Required=false)]
            public int? AudioLength { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Copyright")]
            [Validation(Required=false)]
            public int? Copyright { get; set; }

            [NameInMap("Cover")]
            [Validation(Required=false)]
            public CreatePlayingListOAuth2ResponseBodyResultCover Cover { get; set; }
            public class CreatePlayingListOAuth2ResponseBodyResultCover : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("CanResize")]
                [Validation(Required=false)]
                public bool? CanResize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718285.jpg">http://pic.qtfm.cn/2017/0207/2017020718285.jpg</a></para>
                /// </summary>
                [NameInMap("Img")]
                [Validation(Required=false)]
                public string Img { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718285.jpg">http://pic.qtfm.cn/2017/0207/2017020718285.jpg</a></para>
                /// </summary>
                [NameInMap("Large")]
                [Validation(Required=false)]
                public string Large { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718285.jpg">http://pic.qtfm.cn/2017/0207/2017020718285.jpg</a></para>
                /// </summary>
                [NameInMap("Mediam")]
                [Validation(Required=false)]
                public string Mediam { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718285.jpg">http://pic.qtfm.cn/2017/0207/2017020718285.jpg</a></para>
                /// </summary>
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://pic.qtfm.cn/2017/0207/2017020718285.jpg">http://pic.qtfm.cn/2017/0207/2017020718285.jpg</a></para>
                /// </summary>
                [NameInMap("Small")]
                [Validation(Required=false)]
                public string Small { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DefaultPlayOrder")]
            [Validation(Required=false)]
            public int? DefaultPlayOrder { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://openaudio.cos.tx.xmcdn.com/storages/587f-audiofreehighqps/15/CE/GKwRIJIGnb11ABc6SwF59DNb.mp3">https://openaudio.cos.tx.xmcdn.com/storages/587f-audiofreehighqps/15/CE/GKwRIJIGnb11ABc6SwF59DNb.mp3</a></para>
            /// </summary>
            [NameInMap("ItemUrl")]
            [Validation(Required=false)]
            public string ItemUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Liked")]
            [Validation(Required=false)]
            public bool? Liked { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://aicontent.alibabausercontent.com/lyric/thirdsource/6f4c8408073db134b0d097c122b5a1a1.lrc">https://aicontent.alibabausercontent.com/lyric/thirdsource/6f4c8408073db134b0d097c122b5a1a1.lrc</a></para>
            /// </summary>
            [NameInMap("LyricUrl")]
            [Validation(Required=false)]
            public string LyricUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Repeat</para>
            /// </summary>
            [NameInMap("PlayMode")]
            [Validation(Required=false)]
            public string PlayMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Pos")]
            [Validation(Required=false)]
            public int? Pos { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>96.0</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123123</para>
            /// </summary>
            [NameInMap("RawId")]
            [Validation(Required=false)]
            public string RawId { get; set; }

            [NameInMap("Singer")]
            [Validation(Required=false)]
            public string Singer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qignting</para>
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
