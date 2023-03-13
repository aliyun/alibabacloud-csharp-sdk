// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateVideoPlaylistResponseBody : TeaModel {
        [NameInMap("AudioPlaylist")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistResponseBodyAudioPlaylist> AudioPlaylist { get; set; }
        public class GenerateVideoPlaylistResponseBodyAudioPlaylist : TeaModel {
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubtitlePlaylist")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistResponseBodySubtitlePlaylist> SubtitlePlaylist { get; set; }
        public class GenerateVideoPlaylistResponseBodySubtitlePlaylist : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

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

        [NameInMap("VideoPlaylist")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistResponseBodyVideoPlaylist> VideoPlaylist { get; set; }
        public class GenerateVideoPlaylistResponseBodyVideoPlaylist : TeaModel {
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

    }

}
