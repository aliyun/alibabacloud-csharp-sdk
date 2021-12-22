// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class ListHistoryContainerStatusResponseBody : TeaModel {
        /// <summary>
        /// 容器状态信息集合
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListHistoryContainerStatusResponseBodyDataList> DataList { get; set; }
        public class ListHistoryContainerStatusResponseBodyDataList : TeaModel {
            /// <summary>
            /// 主机账号ID
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// 容器退出时间（Linux时间戳，单位毫秒）
            /// </summary>
            [NameInMap("ContainerQuitTime")]
            [Validation(Required=false)]
            public long? ContainerQuitTime { get; set; }

            /// <summary>
            /// 容器启动时间（Linux时间戳，单位毫秒）
            /// </summary>
            [NameInMap("ContainerStartTime")]
            [Validation(Required=false)]
            public long? ContainerStartTime { get; set; }

            /// <summary>
            /// 容器状态
            /// </summary>
            [NameInMap("ContainerState")]
            [Validation(Required=false)]
            public string ContainerState { get; set; }

            /// <summary>
            /// 游戏ID
            /// </summary>
            [NameInMap("GameId")]
            [Validation(Required=false)]
            public string GameId { get; set; }

            /// <summary>
            /// 游戏会话ID
            /// </summary>
            [NameInMap("GameSessionId")]
            [Validation(Required=false)]
            public string GameSessionId { get; set; }

            /// <summary>
            /// 玩家信息集合
            /// </summary>
            [NameInMap("PlayerDetailList")]
            [Validation(Required=false)]
            public List<ListHistoryContainerStatusResponseBodyDataListPlayerDetailList> PlayerDetailList { get; set; }
            public class ListHistoryContainerStatusResponseBodyDataListPlayerDetailList : TeaModel {
                /// <summary>
                /// 账号ID
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// 是否主机
                /// </summary>
                [NameInMap("IsInitiator")]
                [Validation(Required=false)]
                public bool? IsInitiator { get; set; }

                /// <summary>
                /// 玩家进入游戏时间
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// 项目ID
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// 自定义标识
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// 系统时间戳
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
