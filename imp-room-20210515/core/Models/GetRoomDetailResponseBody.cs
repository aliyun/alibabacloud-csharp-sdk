// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp_room20210515.Models
{
    public class GetRoomDetailResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetRoomDetailResponseBodyResult Result { get; set; }
        public class GetRoomDetailResponseBodyResult : TeaModel {
            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("Notice")]
            [Validation(Required=false)]
            public string Notice { get; set; }
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }
            [NameInMap("Uv")]
            [Validation(Required=false)]
            public long? Uv { get; set; }
            [NameInMap("OnlineCount")]
            [Validation(Required=false)]
            public long? OnlineCount { get; set; }
            [NameInMap("PluginInstanceInfoList")]
            [Validation(Required=false)]
            public List<GetRoomDetailResponseBodyResultPluginInstanceInfoList> PluginInstanceInfoList { get; set; }
            public class GetRoomDetailResponseBodyResultPluginInstanceInfoList : TeaModel {
                public string PluginId { get; set; }
                public string InstanceId { get; set; }
                public long? CreateTime { get; set; }
                public Dictionary<string, string> Extension { get; set; }
            }
        };

        [NameInMap("ResponseSuccess")]
        [Validation(Required=false)]
        public bool? ResponseSuccess { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

    }

}
