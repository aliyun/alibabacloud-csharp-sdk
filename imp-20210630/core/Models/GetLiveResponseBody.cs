// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetLiveResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetLiveResponseBodyResult Result { get; set; }
        public class GetLiveResponseBodyResult : TeaModel {
            [NameInMap("AnchorId")]
            [Validation(Required=false)]
            public string AnchorId { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("ArtcInfo")]
            [Validation(Required=false)]
            public GetLiveResponseBodyResultArtcInfo ArtcInfo { get; set; }
            public class GetLiveResponseBodyResultArtcInfo : TeaModel {
                [NameInMap("ArtcH5Url")]
                [Validation(Required=false)]
                public string ArtcH5Url { get; set; }

                [NameInMap("ArtcUrl")]
                [Validation(Required=false)]
                public string ArtcUrl { get; set; }

            }

            [NameInMap("CodeLevel")]
            [Validation(Required=false)]
            public int? CodeLevel { get; set; }

            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("HlsUrl")]
            [Validation(Required=false)]
            public string HlsUrl { get; set; }

            [NameInMap("Introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }

            [NameInMap("LiveUrl")]
            [Validation(Required=false)]
            public string LiveUrl { get; set; }

            [NameInMap("PlayUrlInfoList")]
            [Validation(Required=false)]
            public List<GetLiveResponseBodyResultPlayUrlInfoList> PlayUrlInfoList { get; set; }
            public class GetLiveResponseBodyResultPlayUrlInfoList : TeaModel {
                [NameInMap("CodeLevel")]
                [Validation(Required=false)]
                public int? CodeLevel { get; set; }

                [NameInMap("FlvUrl")]
                [Validation(Required=false)]
                public string FlvUrl { get; set; }

                [NameInMap("HlsUrl")]
                [Validation(Required=false)]
                public string HlsUrl { get; set; }

                [NameInMap("RtmpUrl")]
                [Validation(Required=false)]
                public string RtmpUrl { get; set; }

            }

            [NameInMap("PlaybackUrl")]
            [Validation(Required=false)]
            public string PlaybackUrl { get; set; }

            [NameInMap("PushUrl")]
            [Validation(Required=false)]
            public string PushUrl { get; set; }

            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("UserDefineField")]
            [Validation(Required=false)]
            public string UserDefineField { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
