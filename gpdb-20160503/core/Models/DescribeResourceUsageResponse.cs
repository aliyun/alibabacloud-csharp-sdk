// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeResourceUsageResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=true)]
        public string DBInstanceId { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=true)]
        public string Engine { get; set; }

        [NameInMap("DiskUsed")]
        [Validation(Required=true)]
        public long? DiskUsed { get; set; }

        [NameInMap("DataSize")]
        [Validation(Required=true)]
        public long? DataSize { get; set; }

        [NameInMap("LogSize")]
        [Validation(Required=true)]
        public long? LogSize { get; set; }

        [NameInMap("BackupSize")]
        [Validation(Required=true)]
        public long? BackupSize { get; set; }

    }

}
