// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FilePermissionMember : TeaModel {
        [NameInMap("action_list")]
        [Validation(Required=false)]
        public List<string> ActionList { get; set; }

        [NameInMap("disinherit_sub_group")]
        [Validation(Required=false)]
        public bool? DisinheritSubGroup { get; set; }

        [NameInMap("expire_time")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        [NameInMap("identity")]
        [Validation(Required=false)]
        public Identity Identity { get; set; }

        [NameInMap("role_id")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

    }

}
