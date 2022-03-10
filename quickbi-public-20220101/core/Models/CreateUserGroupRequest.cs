// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CreateUserGroupRequest : TeaModel {
        [NameInMap("ParentUserGroupId")]
        [Validation(Required=false)]
        public string ParentUserGroupId { get; set; }

        [NameInMap("UserGroupDescription")]
        [Validation(Required=false)]
        public string UserGroupDescription { get; set; }

        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        [NameInMap("UserGroupName")]
        [Validation(Required=false)]
        public string UserGroupName { get; set; }

    }

}
