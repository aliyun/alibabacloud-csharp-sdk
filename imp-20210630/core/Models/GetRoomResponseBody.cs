// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetRoomResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetRoomResponseBodyResult Result { get; set; }
        public class GetRoomResponseBodyResult : TeaModel {
            [NameInMap("RoomInfo")]
            [Validation(Required=false)]
            public GetRoomResponseBodyResultRoomInfo RoomInfo { get; set; }
            public class GetRoomResponseBodyResultRoomInfo : TeaModel {
                [NameInMap("AdminIdList")]
                [Validation(Required=false)]
                public List<string> AdminIdList { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Extension")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extension { get; set; }

                [NameInMap("Notice")]
                [Validation(Required=false)]
                public string Notice { get; set; }

                [NameInMap("OnlineCount")]
                [Validation(Required=false)]
                public long? OnlineCount { get; set; }

                [NameInMap("PluginInstanceInfoList")]
                [Validation(Required=false)]
                public List<GetRoomResponseBodyResultRoomInfoPluginInstanceInfoList> PluginInstanceInfoList { get; set; }
                public class GetRoomResponseBodyResultRoomInfoPluginInstanceInfoList : TeaModel {
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

                [NameInMap("Pv")]
                [Validation(Required=false)]
                public long? Pv { get; set; }

                [NameInMap("RoomId")]
                [Validation(Required=false)]
                public string RoomId { get; set; }

                [NameInMap("RoomOwnerId")]
                [Validation(Required=false)]
                public string RoomOwnerId { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Uv")]
                [Validation(Required=false)]
                public long? Uv { get; set; }

            }

        }

    }

}
