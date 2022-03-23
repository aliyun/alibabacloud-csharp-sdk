// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class KickRoomUserRequest : TeaModel {
        /// <summary>
        /// 应用唯一标识，由6位小写字母、数字组成。
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("BlockTime")]
        [Validation(Required=false)]
        public long? BlockTime { get; set; }

        /// <summary>
        /// 被踢出房间的用户ID。
        /// </summary>
        [NameInMap("KickUser")]
        [Validation(Required=false)]
        public string KickUser { get; set; }

        /// <summary>
        /// 房间唯一标识，由字母、数字、符号.和-组成，最大长度36位，传空则随机生成一个房间id。
        /// </summary>
        [NameInMap("RoomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        /// <summary>
        /// 操作人的用户ID，用于表示谁执行了踢人操作。
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
