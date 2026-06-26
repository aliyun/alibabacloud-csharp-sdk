// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListTokenVaultsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TokenVaults")]
        [Validation(Required=false)]
        public List<ListTokenVaultsResponseBodyTokenVaults> TokenVaults { get; set; }
        public class ListTokenVaultsResponseBodyTokenVaults : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EncryptionConfig")]
            [Validation(Required=false)]
            public ListTokenVaultsResponseBodyTokenVaultsEncryptionConfig EncryptionConfig { get; set; }
            public class ListTokenVaultsResponseBodyTokenVaultsEncryptionConfig : TeaModel {
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

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
