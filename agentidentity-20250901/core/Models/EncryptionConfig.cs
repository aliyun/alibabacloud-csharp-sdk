// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class EncryptionConfig : TeaModel {
        [NameInMap("KeyType")]
        [Validation(Required=false)]
        public string KeyType { get; set; }

        [NameInMap("KmsKeyArn")]
        [Validation(Required=false)]
        public string KmsKeyArn { get; set; }

    }

}
