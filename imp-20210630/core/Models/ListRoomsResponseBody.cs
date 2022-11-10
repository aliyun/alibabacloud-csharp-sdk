// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListRoomsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListRoomsResponseBodyResult Result { get; set; }
        public class ListRoomsResponseBodyResult : TeaModel {
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }

            [NameInMap("RoomInfoList")]
            [Validation(Required=false)]
            public List<ListRoomsResponseBodyResultRoomInfoList> RoomInfoList { get; set; }
            public class ListRoomsResponseBodyResultRoomInfoList : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

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
                public List<ListRoomsResponseBodyResultRoomInfoListPluginInstanceInfoList> PluginInstanceInfoList { get; set; }
                public class ListRoomsResponseBodyResultRoomInfoListPluginInstanceInfoList : TeaModel {
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

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
