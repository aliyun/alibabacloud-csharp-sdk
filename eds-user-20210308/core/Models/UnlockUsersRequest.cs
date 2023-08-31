// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UnlockUsersRequest : TeaModel {
        [NameInMap("AutoLockTime")]
        [Validation(Required=false)]
        public string AutoLockTime { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
