// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// 用户ramId
        /// </summary>
        [NameInMap("ramId")]
        [Validation(Required=false)]
        public long? RamId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// 邮件
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// 幂等号
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
