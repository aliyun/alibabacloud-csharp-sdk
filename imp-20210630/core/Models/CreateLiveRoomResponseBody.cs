// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CreateLiveRoomResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 创建场景化直播返回的结果。
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateLiveRoomResponseBodyResult Result { get; set; }
        public class CreateLiveRoomResponseBodyResult : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }
            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }
            [NameInMap("ChatId")]
            [Validation(Required=false)]
            public string ChatId { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("Notice")]
            [Validation(Required=false)]
            public string Notice { get; set; }
            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }
            [NameInMap("AnchorId")]
            [Validation(Required=false)]
            public string AnchorId { get; set; }
            [NameInMap("PlaybackUrl")]
            [Validation(Required=false)]
            public string PlaybackUrl { get; set; }
            [NameInMap("PushUrl")]
            [Validation(Required=false)]
            public string PushUrl { get; set; }
            [NameInMap("LiveUrl")]
            [Validation(Required=false)]
            public string LiveUrl { get; set; }
            [NameInMap("PluginInstanceInfoList")]
            [Validation(Required=false)]
            public List<CreateLiveRoomResponseBodyResultPluginInstanceInfoList> PluginInstanceInfoList { get; set; }
            public class CreateLiveRoomResponseBodyResultPluginInstanceInfoList : TeaModel {
                public string PluginType { get; set; }
                public string PluginId { get; set; }
                public long? CreateTime { get; set; }
                public Dictionary<string, string> Extension { get; set; }
            }
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }
            [NameInMap("AnchorNick")]
            [Validation(Required=false)]
            public string AnchorNick { get; set; }
        };

    }

}
