// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListRoomsResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// API请求的返回结果结构体。
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListRoomsResponseBodyResult Result { get; set; }
        public class ListRoomsResponseBodyResult : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("RoomInfoList")]
            [Validation(Required=false)]
            public List<ListRoomsResponseBodyResultRoomInfoList> RoomInfoList { get; set; }
            public class ListRoomsResponseBodyResultRoomInfoList : TeaModel {
                public string RoomId { get; set; }
                public string Title { get; set; }
                public string RoomOwnerId { get; set; }
                public string Notice { get; set; }
                public long? Uv { get; set; }
                public long? OnlineCount { get; set; }
                public List<ListRoomsResponseBodyResultRoomInfoListPluginInstanceInfoList> PluginInstanceInfoList { get; set; }
                public class ListRoomsResponseBodyResultRoomInfoListPluginInstanceInfoList : TeaModel {
                    public string PluginType { get; set; }
                    public string PluginId { get; set; }
                    public long? CreateTime { get; set; }
                    public Dictionary<string, string> Extension { get; set; }
                }
                public string CreateTime { get; set; }
                public string AppId { get; set; }
                public string TemplateId { get; set; }
                public Dictionary<string, string> Extension { get; set; }
            }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

    }

}
