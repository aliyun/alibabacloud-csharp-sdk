// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class InventoryEncryption : TeaModel {
        [NameInMap("SSE-KMS")]
        [Validation(Required=false)]
        public SSEKMS SSEKMS { get; set; }

        [NameInMap("SSE-OSS")]
        [Validation(Required=false)]
        public SSEOSS SSEOSS { get; set; }

    }

}
