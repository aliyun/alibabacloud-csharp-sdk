// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageScanAuthCountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ImageScan")]
        [Validation(Required=false)]
        public DescribeImageScanAuthCountResponseBodyImageScan ImageScan { get; set; }
        public class DescribeImageScanAuthCountResponseBodyImageScan : TeaModel {
            [NameInMap("ScanCount")]
            [Validation(Required=false)]
            public long? ScanCount { get; set; }
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public long? ImageScanCapacity { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
        };

    }

}
