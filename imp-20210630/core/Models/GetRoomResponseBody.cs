// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetRoomResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 查询房间信息返回结果。
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetRoomResponseBodyResult Result { get; set; }
        public class GetRoomResponseBodyResult : TeaModel {
            [NameInMap("RoomInfo")]
            [Validation(Required=false)]
            public GetRoomResponseBodyResultRoomInfo RoomInfo { get; set; }
            public class GetRoomResponseBodyResultRoomInfo : TeaModel {
                /// <summary>
                /// 应用唯一标识，由6位小写字母、数字组成。
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// 房间创建时间戳，单位：毫秒。
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// 房间拓展字段。
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extension { get; set; }

                /// <summary>
                /// 房间公告。
                /// </summary>
                [NameInMap("Notice")]
                [Validation(Required=false)]
                public string Notice { get; set; }

                /// <summary>
                /// 在线用户数。
                /// </summary>
                [NameInMap("OnlineCount")]
                [Validation(Required=false)]
                public long? OnlineCount { get; set; }

                /// <summary>
                /// 活跃插件列表。
                /// </summary>
                [NameInMap("PluginInstanceInfoList")]
                [Validation(Required=false)]
                public List<GetRoomResponseBodyResultRoomInfoPluginInstanceInfoList> PluginInstanceInfoList { get; set; }
                public class GetRoomResponseBodyResultRoomInfoPluginInstanceInfoList : TeaModel {
                    /// <summary>
                    /// 插件实例创建时间戳，单位：毫秒。
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// 插件拓展字段。
                    /// </summary>
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Extension { get; set; }

                    /// <summary>
                    /// 插件实例唯一标识。
                    /// </summary>
                    [NameInMap("PluginId")]
                    [Validation(Required=false)]
                    public string PluginId { get; set; }

                    /// <summary>
                    /// 插件唯一标识，取值：live-直播，wb-白板，chat-聊天，rtc。
                    /// </summary>
                    [NameInMap("PluginType")]
                    [Validation(Required=false)]
                    public string PluginType { get; set; }

                }

                /// <summary>
                /// 访问用户人次。
                /// </summary>
                [NameInMap("Pv")]
                [Validation(Required=false)]
                public long? Pv { get; set; }

                /// <summary>
                /// 房间唯一标识。
                /// </summary>
                [NameInMap("RoomId")]
                [Validation(Required=false)]
                public string RoomId { get; set; }

                /// <summary>
                /// 房主用户id。
                /// </summary>
                [NameInMap("RoomOwnerId")]
                [Validation(Required=false)]
                public string RoomOwnerId { get; set; }

                /// <summary>
                /// 创建房间使用的模板id。
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// 房间标题。
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// 访问用户数。
                /// </summary>
                [NameInMap("Uv")]
                [Validation(Required=false)]
                public long? Uv { get; set; }

            }
        };

    }

}
