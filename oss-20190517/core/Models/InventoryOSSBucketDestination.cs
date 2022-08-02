// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class InventoryOSSBucketDestination : TeaModel {
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        [NameInMap("Encryption")]
        [Validation(Required=false)]
        public InventoryEncryption Encryption { get; set; }

        [NameInMap("Format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
