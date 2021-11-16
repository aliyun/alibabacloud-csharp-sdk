// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// clientToken
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 人员手机号
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// ramID
        /// </summary>
        [NameInMap("ramId")]
        [Validation(Required=false)]
        public string RamId { get; set; }

        /// <summary>
        /// USER_LIST列表 ALL_USERS下拉
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public long? Scene { get; set; }

        /// <summary>
        /// 移动应用协同渠道
        /// </summary>
        [NameInMap("synergyChannel")]
        [Validation(Required=false)]
        public string SynergyChannel { get; set; }

        /// <summary>
        /// 人员名称
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
