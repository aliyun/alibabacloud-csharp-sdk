// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class DeleteServiceGroupUserRequest : TeaModel {
        /// <summary>
        /// 幂等号
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 新的用户
        /// </summary>
        [NameInMap("newUserId")]
        [Validation(Required=false)]
        public long? NewUserId { get; set; }

        /// <summary>
        /// 老的用户ID
        /// </summary>
        [NameInMap("oldUserId")]
        [Validation(Required=false)]
        public long? OldUserId { get; set; }

        /// <summary>
        /// 删除服务组成员
        /// </summary>
        [NameInMap("removeUser")]
        [Validation(Required=false)]
        public bool? RemoveUser { get; set; }

        /// <summary>
        /// 服务组ID
        /// </summary>
        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public long? ServiceGroupId { get; set; }

    }

}
