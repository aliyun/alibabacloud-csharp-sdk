// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class GrantRevokeFailureEntry : TeaModel {
        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public ErrorDetail ErrorDetail { get; set; }

        [NameInMap("GrantRevokeEntry")]
        [Validation(Required=false)]
        public GrantRevokeEntry GrantRevokeEntry { get; set; }

    }

}
