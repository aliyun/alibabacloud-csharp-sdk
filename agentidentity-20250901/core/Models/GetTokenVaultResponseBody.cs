// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetTokenVaultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TokenVault")]
        [Validation(Required=false)]
        public GetTokenVaultResponseBodyTokenVault TokenVault { get; set; }
        public class GetTokenVaultResponseBodyTokenVault : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EncryptionConfig")]
            [Validation(Required=false)]
            public GetTokenVaultResponseBodyTokenVaultEncryptionConfig EncryptionConfig { get; set; }
            public class GetTokenVaultResponseBodyTokenVaultEncryptionConfig : TeaModel {
                [NameInMap("KeyType")]
                [Validation(Required=false)]
                public string KeyType { get; set; }

                [NameInMap("KmsKeyArn")]
                [Validation(Required=false)]
                public string KmsKeyArn { get; set; }

            }

            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            [NameInMap("TokenVaultArn")]
            [Validation(Required=false)]
            public string TokenVaultArn { get; set; }

            [NameInMap("TokenVaultName")]
            [Validation(Required=false)]
            public string TokenVaultName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
