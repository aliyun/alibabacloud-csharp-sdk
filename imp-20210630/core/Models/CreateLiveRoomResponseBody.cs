// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CreateLiveRoomResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateLiveRoomResponseBodyResult Result { get; set; }
        public class CreateLiveRoomResponseBodyResult : TeaModel {
            [NameInMap("AnchorId")]
            [Validation(Required=false)]
            public string AnchorId { get; set; }

            [NameInMap("AnchorNick")]
            [Validation(Required=false)]
            public string AnchorNick { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("ArtcInfo")]
            [Validation(Required=false)]
            public CreateLiveRoomResponseBodyResultArtcInfo ArtcInfo { get; set; }
            public class CreateLiveRoomResponseBodyResultArtcInfo : TeaModel {
                [NameInMap("ArtcH5Url")]
                [Validation(Required=false)]
                public string ArtcH5Url { get; set; }

                [NameInMap("ArtcUrl")]
                [Validation(Required=false)]
                public string ArtcUrl { get; set; }

            }

            [NameInMap("ChatId")]
            [Validation(Required=false)]
            public string ChatId { get; set; }

            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            [NameInMap("Extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            [NameInMap("HlsUrl")]
            [Validation(Required=false)]
            public string HlsUrl { get; set; }

            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }

            [NameInMap("LiveUrl")]
            [Validation(Required=false)]
            public string LiveUrl { get; set; }

            [NameInMap("Notice")]
            [Validation(Required=false)]
            public string Notice { get; set; }

            [NameInMap("PlaybackUrl")]
            [Validation(Required=false)]
            public string PlaybackUrl { get; set; }

            [NameInMap("PluginInstanceInfoList")]
            [Validation(Required=false)]
            public List<CreateLiveRoomResponseBodyResultPluginInstanceInfoList> PluginInstanceInfoList { get; set; }
            public class CreateLiveRoomResponseBodyResultPluginInstanceInfoList : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Extension")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extension { get; set; }

                [NameInMap("PluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                [NameInMap("PluginType")]
                [Validation(Required=false)]
                public string PluginType { get; set; }

            }

            [NameInMap("PushUrl")]
            [Validation(Required=false)]
            public string PushUrl { get; set; }

            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
