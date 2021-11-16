// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListServiceGroupsRequest : TeaModel {
        /// <summary>
        /// 幂等号
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 是否已经排班
        /// </summary>
        [NameInMap("isScheduled")]
        [Validation(Required=false)]
        public bool? IsScheduled { get; set; }

        /// <summary>
        /// 是否根据排班状态排序
        /// </summary>
        [NameInMap("orderByScheduleStatus")]
        [Validation(Required=false)]
        public bool? OrderByScheduleStatus { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 搜索名称
        /// </summary>
        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// 搜索类型。USER用户 SERVICEGROUP服务组
        /// </summary>
        [NameInMap("queryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
