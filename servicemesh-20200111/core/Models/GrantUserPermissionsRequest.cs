// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GrantUserPermissionsRequest : TeaModel {
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public string Permissions { get; set; }

        [NameInMap("SubAccountUserId")]
        [Validation(Required=false)]
        public string SubAccountUserId { get; set; }

    }

}
