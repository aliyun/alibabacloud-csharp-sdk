// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateRoleRequest : TeaModel {
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public int? RoleId { get; set; }

        [NameInMap("ActionData")]
        [Validation(Required=false)]
        public string ActionData { get; set; }

    }

}
