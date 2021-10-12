// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeInstanceStoragePerformanceRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("DbInstanceName")]
        [Validation(Required=false)]
        public string DbInstanceName { get; set; }

        [NameInMap("StorageInstanceId")]
        [Validation(Required=false)]
        public string StorageInstanceId { get; set; }

        [NameInMap("Keys")]
        [Validation(Required=false)]
        public string Keys { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

    }

}
