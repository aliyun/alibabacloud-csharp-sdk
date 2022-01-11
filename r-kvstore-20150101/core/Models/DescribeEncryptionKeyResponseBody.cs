// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeEncryptionKeyResponseBody : TeaModel {
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
