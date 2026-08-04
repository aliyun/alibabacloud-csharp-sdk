// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CreatePlayingListResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code of the invocation</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Additional information, typically used to briefly describe a failed invocation to help the caller troubleshoot the issue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>10002398812</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Actual return result of the service</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreatePlayingListResponseBodyResult Result { get; set; }
        public class CreatePlayingListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Third-party album name</para>
            /// 
            /// <b>Example:</b>
            /// <para>晚安妈妈睡前故事</para>
            /// </summary>
            [NameInMap("AlbumName")]
            [Validation(Required=false)]
            public string AlbumName { get; set; }

            /// <summary>
            /// <para>Third-party album ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>260744</para>
            /// </summary>
            [NameInMap("AlbumRawId")]
            [Validation(Required=false)]
            public string AlbumRawId { get; set; }

            /// <summary>
            /// <para>Length</para>
            /// 
            /// <b>Example:</b>
            /// <para>190</para>
            /// </summary>
            [NameInMap("AudioLength")]
            [Validation(Required=false)]
            public int? AudioLength { get; set; }

            /// <summary>
            /// <para>The copyright field is upgraded to indicate whether the content is playable: 0 means playable, 1 or 2 means not playable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Copyright")]
            [Validation(Required=false)]
            public int? Copyright { get; set; }

            /// <summary>
            /// <para>thumbnail image object</para>
            /// </summary>
            [NameInMap("Cover")]
            [Validation(Required=false)]
            public CreatePlayingListResponseBodyResultCover Cover { get; set; }
            public class CreatePlayingListResponseBodyResultCover : TeaModel {
                /// <summary>
                /// <para>Indicates whether OSS rules can be used for cropping.</para>
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
                /// <para><a href="http://imgopen.xmcdn.com/group58/M06/08/9B/wKgLglzTyTjiOy0oAAcOTv16ohg815.jpg!op_type=3&columns=640&rows=640">http://imgopen.xmcdn.com/group58/M06/08/9B/wKgLglzTyTjiOy0oAAcOTv16ohg815.jpg!op_type=3&amp;columns=640&amp;rows=640</a></para>
                /// </summary>
                [NameInMap("Img")]
                [Validation(Required=false)]
                public string Img { get; set; }

                /// <summary>
                /// <para>Large image</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://imgopen.xmcdn.com/group58/M06/08/9B/wKgLglzTyTjiOy0oAAcOTv16ohg815.jpg!op_type=3&columns=640&rows=640">http://imgopen.xmcdn.com/group58/M06/08/9B/wKgLglzTyTjiOy0oAAcOTv16ohg815.jpg!op_type=3&amp;columns=640&amp;rows=640</a></para>
                /// </summary>
                [NameInMap("Large")]
                [Validation(Required=false)]
                public string Large { get; set; }

                /// <summary>
                /// <para>Medium image</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://imgopen.xmcdn.com/group58/M06/08/9B/wKgLglzTyTjiOy0oAAcOTv16ohg815.jpg!op_type=3&columns=640&rows=640">http://imgopen.xmcdn.com/group58/M06/08/9B/wKgLglzTyTjiOy0oAAcOTv16ohg815.jpg!op_type=3&amp;columns=640&amp;rows=640</a></para>
                /// </summary>
                [NameInMap("Mediam")]
                [Validation(Required=false)]
                public string Mediam { get; set; }

                /// <summary>
                /// <para>medium image</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://imgopen.xmcdn.com/group58/M06/08/9B/wKgLglzTyTjiOy0oAAcOTv16ohg815.jpg!op_type=3&columns=640&rows=640">http://imgopen.xmcdn.com/group58/M06/08/9B/wKgLglzTyTjiOy0oAAcOTv16ohg815.jpg!op_type=3&amp;columns=640&amp;rows=640</a></para>
                /// </summary>
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                /// <summary>
                /// <para>small image</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://imgopen.xmcdn.com/group58/M06/08/9B/wKgLglzTyTjiOy0oAAcOTv16ohg815.jpg!op_type=3&columns=640&rows=640">http://imgopen.xmcdn.com/group58/M06/08/9B/wKgLglzTyTjiOy0oAAcOTv16ohg815.jpg!op_type=3&amp;columns=640&amp;rows=640</a></para>
                /// </summary>
                [NameInMap("Small")]
                [Validation(Required=false)]
                public string Small { get; set; }

            }

            /// <summary>
            /// <para>Default playback order of the package: 0 for sequential, 1 for reverse.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DefaultPlayOrder")]
            [Validation(Required=false)]
            public int? DefaultPlayOrder { get; set; }

            /// <summary>
            /// <para>Playback URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://openaudio.cos.tx.xmcdn.com/storages/587f-audiofreehighqps/15/CE/GKwRIJIGnb11ABc6SwF59DNb.mp3">https://openaudio.cos.tx.xmcdn.com/storages/587f-audiofreehighqps/15/CE/GKwRIJIGnb11ABc6SwF59DNb.mp3</a></para>
            /// </summary>
            [NameInMap("ItemUrl")]
            [Validation(Required=false)]
            public string ItemUrl { get; set; }

            /// <summary>
            /// <para>is collected</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Liked")]
            [Validation(Required=false)]
            public bool? Liked { get; set; }

            /// <summary>
            /// <para>Lyrics URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://aicontent.alibabausercontent.com/lyric/thirdsource/6f4c8408073db134b0d097c122b5a1a1.lrc">https://aicontent.alibabausercontent.com/lyric/thirdsource/6f4c8408073db134b0d097c122b5a1a1.lrc</a></para>
            /// </summary>
            [NameInMap("LyricUrl")]
            [Validation(Required=false)]
            public string LyricUrl { get; set; }

            /// <summary>
            /// <para>Playback pattern (Repeat, Shuffle, RepeatOne, Normal)</para>
            /// 
            /// <b>Example:</b>
            /// <para>Repeat</para>
            /// </summary>
            [NameInMap("PlayMode")]
            [Validation(Required=false)]
            public string PlayMode { get; set; }

            /// <summary>
            /// <para>Position of the item in the playlist</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Pos")]
            [Validation(Required=false)]
            public int? Pos { get; set; }

            /// <summary>
            /// <para>Playback progress of the song</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>third-party ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>550144364</para>
            /// </summary>
            [NameInMap("RawId")]
            [Validation(Required=false)]
            public string RawId { get; set; }

            /// <summary>
            /// <para>Author</para>
            /// 
            /// <b>Example:</b>
            /// <para>晚安妈妈</para>
            /// </summary>
            [NameInMap("Singer")]
            [Validation(Required=false)]
            public string Singer { get; set; }

            /// <summary>
            /// <para>Source</para>
            /// 
            /// <b>Example:</b>
            /// <para>ximalayav2</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>title</para>
            /// 
            /// <b>Example:</b>
            /// <para>足球鞋赛车 晚安妈妈</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>type (such as music, program, joke, news, children_song, radio, etc.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>story</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Playback availability: VALID(10), UNKNOWN(20), NOT_VALID(30)</para>
            /// 
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("Valid")]
            [Validation(Required=false)]
            public string Valid { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the invocation succeeded. true indicates success, and false indicates failure. When the value is false, check the Message field for details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
