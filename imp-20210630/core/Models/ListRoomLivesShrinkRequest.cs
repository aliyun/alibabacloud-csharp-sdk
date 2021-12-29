// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListRoomLivesShrinkRequest : TeaModel {
        /// <summary>
        /// 应用唯一标识，可以包含小写字母、数字，长度为6个字符。
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 拉取在这个时间戳之前创建的直播，单位毫秒，不传则默认拉取最新创建的。
        /// </summary>
        [NameInMap("QueryTimestamp")]
        [Validation(Required=false)]
        public long? QueryTimestamp { get; set; }

        /// <summary>
        /// 房间ID，最大长度36个字符。
        /// </summary>
        [NameInMap("RoomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        /// <summary>
        /// 房间ID列表，可指定多个房间id，过滤优先级高于RoomId。
        /// </summary>
        [NameInMap("RoomIdList")]
        [Validation(Required=false)]
        public string RoomIdListShrink { get; set; }

        /// <summary>
        /// 拉取直播数量。
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// 直播状态筛选条件，0-直播 1-下播，不传则返回全部状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
