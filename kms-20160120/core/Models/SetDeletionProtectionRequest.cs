// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class SetDeletionProtectionRequest : TeaModel {
        [NameInMap("DeletionProtectionDescription")]
        [Validation(Required=false)]
        public string DeletionProtectionDescription { get; set; }

        [NameInMap("EnableDeletionProtection")]
        [Validation(Required=false)]
        public bool? EnableDeletionProtection { get; set; }

        [NameInMap("ProtectedResourceArn")]
        [Validation(Required=false)]
        public string ProtectedResourceArn { get; set; }

    }

}
