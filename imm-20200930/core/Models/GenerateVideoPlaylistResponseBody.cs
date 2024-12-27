// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateVideoPlaylistResponseBody : TeaModel {
        /// <summary>
        /// <para>The audio media playlist files.</para>
        /// </summary>
        [NameInMap("AudioPlaylist")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistResponseBodyAudioPlaylist> AudioPlaylist { get; set; }
        public class GenerateVideoPlaylistResponseBodyAudioPlaylist : TeaModel {
            /// <summary>
            /// <para>The number of audio channels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Channels")]
            [Validation(Required=false)]
            public int? Channels { get; set; }

            /// <summary>
            /// <para>The token of the audio media playlist. You can use this parameter to generate the path of a TS file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>affe0c6042f09722fec95a21b8b******</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The OSS path of the audio media playlist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://imm-test/testcases/video.m3u8</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>The total duration of the generated video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1082</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public float? Duration { get; set; }

        /// <summary>
        /// <para>The OSS path of the master playlist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object/master.m3u8</para>
        /// </summary>
        [NameInMap("MasterURI")]
        [Validation(Required=false)]
        public string MasterURI { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA995EFD-083D-4F40-BE8A-BDF75FFF*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The subtitle media playlist files.</para>
        /// </summary>
        [NameInMap("SubtitlePlaylist")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistResponseBodySubtitlePlaylist> SubtitlePlaylist { get; set; }
        public class GenerateVideoPlaylistResponseBodySubtitlePlaylist : TeaModel {
            /// <summary>
            /// <para>The serial number of the subtitle stream. The value starts from 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The language of the subtitle stream.</para>
            /// <remarks>
            /// <para> The language is derived from the subtitle stream information in the OSS path specified by the SourceURI parameter for a source video. If no language information exists in the source video, null is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>en</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The token of the subtitle media playlist. You can use this parameter to generate the path of a subtitle file.</para>
            /// <remarks>
            /// <para> You can generate the path of a transcoded subtitle file based on the returned token value. The path must be in the oss://${Bucket}/${Object}-${Token}_${Index}.ts format. oss://${Bucket}/${Object} specifies the URI specified by input parameters for output files. ${Token} specifies the returned token value, and ${Index} specifies the serial number of a subtitle file.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>affe0c6042f09722fec95a21b8b******</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The OSS path of the subtitle media playlist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://imm-test/testcases/vide_0.m3u8</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>The token of the master playlist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92376fbb-171f-4259-913f-705f7ee0****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The video media playlist files.</para>
        /// </summary>
        [NameInMap("VideoPlaylist")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistResponseBodyVideoPlaylist> VideoPlaylist { get; set; }
        public class GenerateVideoPlaylistResponseBodyVideoPlaylist : TeaModel {
            /// <summary>
            /// <para>The video frame rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25/1</para>
            /// </summary>
            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public string FrameRate { get; set; }

            /// <summary>
            /// <para>The video resolution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>640x480</para>
            /// </summary>
            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

            /// <summary>
            /// <para>The token of the video media playlist. You can use this parameter to generate the path of a TS file.</para>
            /// <remarks>
            /// <para> You can generate the path of a transcoded TS file based on the value of this parameter. The path must be in the oss://${Bucket}/${Object}-${Token}-${Index}.ts format. oss://${Bucket}/${Object} specifies the URI specified by input parameters for output files. ${Token} specifies the returned token, and ${Index} specifies the serial number of a TS file.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>affe0c6042f09722fec95a21b8b******</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The OSS path of the video media playlist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://imm-test/testcases/video.m3u8</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

    }

}
