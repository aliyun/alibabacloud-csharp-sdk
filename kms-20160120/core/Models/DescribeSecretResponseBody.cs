// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeSecretResponseBody : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        [NameInMap("LastRotationDate")]
        [Validation(Required=false)]
        public string LastRotationDate { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("AutomaticRotation")]
        [Validation(Required=false)]
        public string AutomaticRotation { get; set; }

        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        [NameInMap("NextRotationDate")]
        [Validation(Required=false)]
        public string NextRotationDate { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public string ExtendedConfig { get; set; }

        [NameInMap("PlannedDeleteTime")]
        [Validation(Required=false)]
        public string PlannedDeleteTime { get; set; }

        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeSecretResponseBodyTags Tags { get; set; }
        public class DescribeSecretResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeSecretResponseBodyTagsTag> Tag { get; set; }
            public class DescribeSecretResponseBodyTagsTag : TeaModel {
                public string TagValue { get; set; }
                public string TagKey { get; set; }
            }
        };

        [NameInMap("EncryptionKeyId")]
        [Validation(Required=false)]
        public string EncryptionKeyId { get; set; }

    }

}
