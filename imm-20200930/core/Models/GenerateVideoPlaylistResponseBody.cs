// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateVideoPlaylistResponseBody : TeaModel {
        /// <summary>
        /// 转码文件列表。
        /// </summary>
        [NameInMap("AudioPlaylist")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistResponseBodyAudioPlaylist> AudioPlaylist { get; set; }
        public class GenerateVideoPlaylistResponseBodyAudioPlaylist : TeaModel {
            /// <summary>
            /// 转码生成的Token。用于LiveTranscoding访问的参数。
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// 输出m3u8的OSS地址。地址规则为 Target.URI + ".m3u8“， 其中Target.URI为输入参数中视频转码输出地址前缀。
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 转码文件列表。
        /// </summary>
        [NameInMap("SubtitlePlaylist")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistResponseBodySubtitlePlaylist> SubtitlePlaylist { get; set; }
        public class GenerateVideoPlaylistResponseBodySubtitlePlaylist : TeaModel {
            /// <summary>
            /// 字幕流编号，从0开始。
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// 视频源中字幕流的语言。
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// 转码生成的Token。用于LiveTranscoding访问的参数。
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// 输出m3u8的OSS地址。地址规则为 Target.URI + “_” + Index + ".m3u8“， 其中Target.URI为输入参数中视频转码输出地址前缀。
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

        /// <summary>
        /// 转码文件列表。
        /// </summary>
        [NameInMap("VideoPlaylist")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistResponseBodyVideoPlaylist> VideoPlaylist { get; set; }
        public class GenerateVideoPlaylistResponseBodyVideoPlaylist : TeaModel {
            /// <summary>
            /// 转码生成的Token。用于LiveTranscoding访问的参数。
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// 输出m3u8的OSS地址。地址规则为 Target.URI + ".m3u8“， 其中Target.URI为输入参数中视频转码输出地址前缀。
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

    }

}
