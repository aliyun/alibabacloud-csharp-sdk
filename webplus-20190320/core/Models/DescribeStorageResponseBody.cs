// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeStorageResponseBody : TeaModel {
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public DescribeStorageResponseBodyStorage Storage { get; set; }
        public class DescribeStorageResponseBodyStorage : TeaModel {
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("KeyPrefix")]
            [Validation(Required=false)]
            public string KeyPrefix { get; set; }
            [NameInMap("PkgKeyPrefix")]
            [Validation(Required=false)]
            public string PkgKeyPrefix { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
