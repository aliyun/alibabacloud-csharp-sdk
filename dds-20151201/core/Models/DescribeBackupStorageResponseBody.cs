// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupStorageResponseBody : TeaModel {
        [NameInMap("FreeSize")]
        [Validation(Required=false)]
        public long? FreeSize { get; set; }

        [NameInMap("FullStorageSize")]
        [Validation(Required=false)]
        public long? FullStorageSize { get; set; }

        [NameInMap("LogStorageSize")]
        [Validation(Required=false)]
        public long? LogStorageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
