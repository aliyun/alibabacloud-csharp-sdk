// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20210416.Models
{
    public class DescribeInstanceStorageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceStorages")]
        [Validation(Required=false)]
        public List<DescribeInstanceStorageResponseBodyInstanceStorages> InstanceStorages { get; set; }
        public class DescribeInstanceStorageResponseBodyInstanceStorages : TeaModel {
            [NameInMap("StorageTime")]
            [Validation(Required=false)]
            public long? StorageTime { get; set; }

            [NameInMap("StorageCapacity")]
            [Validation(Required=false)]
            public long? StorageCapacity { get; set; }

            [NameInMap("StorageCategory")]
            [Validation(Required=false)]
            public string StorageCategory { get; set; }

            [NameInMap("StorageSpace")]
            [Validation(Required=false)]
            public string StorageSpace { get; set; }

            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public long? StorageUsed { get; set; }

        }

    }

}
