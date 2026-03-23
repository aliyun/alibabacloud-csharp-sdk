// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceEncryptionKeyResponseBody : TeaModel {
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("DeleteDate")]
        [Validation(Required=false)]
        public string DeleteDate { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        [NameInMap("EncryptionKeyList")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceEncryptionKeyResponseBodyEncryptionKeyList> EncryptionKeyList { get; set; }
        public class DescribeDBInstanceEncryptionKeyResponseBodyEncryptionKeyList : TeaModel {
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EncryptionKey")]
            [Validation(Required=false)]
            public string EncryptionKey { get; set; }

            [NameInMap("EncryptionKeyStatus")]
            [Validation(Required=false)]
            public string EncryptionKeyStatus { get; set; }

            [NameInMap("KeyType")]
            [Validation(Required=false)]
            public string KeyType { get; set; }

            [NameInMap("KeyUsage")]
            [Validation(Required=false)]
            public string KeyUsage { get; set; }

            [NameInMap("MaterialExpireTime")]
            [Validation(Required=false)]
            public string MaterialExpireTime { get; set; }

            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            [NameInMap("UsedBy")]
            [Validation(Required=false)]
            public string UsedBy { get; set; }

        }

        [NameInMap("EncryptionKeyStatus")]
        [Validation(Required=false)]
        public string EncryptionKeyStatus { get; set; }

        [NameInMap("KeyUsage")]
        [Validation(Required=false)]
        public string KeyUsage { get; set; }

        [NameInMap("MaterialExpireTime")]
        [Validation(Required=false)]
        public string MaterialExpireTime { get; set; }

        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
