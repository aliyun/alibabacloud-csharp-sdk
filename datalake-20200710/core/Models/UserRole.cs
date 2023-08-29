// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class UserRole : TeaModel {
        [NameInMap("GrantTime")]
        [Validation(Required=false)]
        public long? GrantTime { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public Role Role { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public Principal User { get; set; }

    }

}
