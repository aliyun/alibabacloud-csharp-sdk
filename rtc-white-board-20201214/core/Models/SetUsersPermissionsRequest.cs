// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class SetUsersPermissionsRequest : TeaModel {
        /// <summary>
        /// 需要设置权限的用户ID，多个用英文逗号（,）分隔，最多30个，每个ID由纯数字组成
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

        /// <summary>
        /// 白板文档唯一标识符
        /// </summary>
        [NameInMap("DocKey")]
        [Validation(Required=false)]
        public string DocKey { get; set; }

        /// <summary>
        /// 白板应用唯一标识符
        /// </summary>
        [NameInMap("AppID")]
        [Validation(Required=false)]
        public string AppID { get; set; }

        /// <summary>
        /// 用户白板权限类型，可选值：ban/read/edit
        /// </summary>
        [NameInMap("PermissionType")]
        [Validation(Required=false)]
        public string PermissionType { get; set; }

    }

}
