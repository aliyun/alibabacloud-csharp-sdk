// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListUsersResponseBodyData> Data { get; set; }
        public class ListUsersResponseBodyData : TeaModel {
            /// <summary>
            /// 用户id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// 子账号ramId
            /// </summary>
            [NameInMap("ramId")]
            [Validation(Required=false)]
            public long? RamId { get; set; }

            /// <summary>
            /// 用户名
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// 手机
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// 邮箱
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// 是否可编辑
            /// </summary>
            [NameInMap("isEditableUser")]
            [Validation(Required=false)]
            public long? IsEditableUser { get; set; }

            /// <summary>
            /// 账户类型
            /// </summary>
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public long? AccountType { get; set; }

            /// <summary>
            /// 移动应用账户
            /// </summary>
            [NameInMap("appAccount")]
            [Validation(Required=false)]
            public string AppAccount { get; set; }

            /// <summary>
            /// 移动应用协同渠道
            /// </summary>
            [NameInMap("synergyChannel")]
            [Validation(Required=false)]
            public string SynergyChannel { get; set; }

            /// <summary>
            /// 是否关联
            /// </summary>
            [NameInMap("isRelated")]
            [Validation(Required=false)]
            public string IsRelated { get; set; }

        }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 分页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
