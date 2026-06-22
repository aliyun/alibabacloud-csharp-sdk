// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateVideoPlaylistResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of audio Media Playlist files.</para>
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
            /// <para>The token generated for the audio Media Playlist. You can use this parameter to construct the URI of the generated TS file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>affe0c6042f09722fec95a21b8b******</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The OSS URI of the audio Media Playlist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object/output-audio.m3u8</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>The total duration of the output video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1082</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public float? Duration { get; set; }

        /// <summary>
        /// <para>The OSS URI of the Master Playlist.</para>
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
        /// <para>The list of subtitle Media Playlist files.</para>
        /// </summary>
        [NameInMap("SubtitlePlaylist")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistResponseBodySubtitlePlaylist> SubtitlePlaylist { get; set; }
        public class GenerateVideoPlaylistResponseBodySubtitlePlaylist : TeaModel {
            /// <summary>
            /// <para>The sequence number of the subtitle stream, starting from 0.</para>
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
            /// <para>The language is obtained from the subtitle stream information of the source video specified by SourceURI. If the source video does not contain language information, this parameter is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>eng</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The token generated for the subtitle Media Playlist. You can use this parameter to construct the URI of the generated subtitle file.</para>
            /// <remarks>
            /// <para>You can use the returned token value to construct the URI of the transcoded subtitle file. The format is oss\://${Bucket}/${Object}-${Token}_${Index}.ts. oss\://${Bucket}/${Object} is the subtitle URI specified in the request parameters. ${Token} is the returned parameter. ${Index} is the sequence number of the subtitle.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>affe0c6042f09722fec95a21b8b******</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The OSS URI of the subtitle Media Playlist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object/output-subtitle.m3u8</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>The token of the Master Playlist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92376fbb-171f-4259-913f-705f7ee0****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The list of video Media Playlist files.</para>
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
            /// <para>The token generated for the video Media Playlist. You can use this parameter to construct the URI of the generated TS file.</para>
            /// <remarks>
            /// <para>You can use the returned token value to construct the URI of the transcoded TS file. The format is oss\://${Bucket}/${Object}-${Token}-${Index}.ts. oss\://${Bucket}/${Object} is the target URI specified in the request parameters. ${Token} is the returned parameter. ${Index} is the sequence number of the TS file.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>affe0c6042f09722fec95a21b8b******</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The OSS URI of the video Media Playlist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object/output-video.m3u8</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

    }

}
