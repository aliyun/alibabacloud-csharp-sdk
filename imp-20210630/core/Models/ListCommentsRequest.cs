// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListCommentsRequest : TeaModel {
        /// <summary>
        /// 用户的应用ID，在控制台创建应用时生成。包含小写字母、数字，长度为6个字符。
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 查询弹幕消息列表的分页页数。应该从1开始，每次分页拉取时递增。
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// 查询弹幕消息列表的分页大小。最小不得小于1，最大不得超过100。如果超过100，会被截断为前100条。
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 房间的唯一标识，在调用CreateRoom时返回。
        /// </summary>
        [NameInMap("RoomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        /// <summary>
        /// 查询弹幕消息列表的排序方式。取值仅限0和1，其中0表示按照弹幕消息创建时间递增的顺序拉取，1表示按照弹幕消息创建时间递减的时间拉取。
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public int? SortType { get; set; }

        /// <summary>
        /// 操作人用户ID，表示谁执行了查询弹幕消息列表的操作。
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
