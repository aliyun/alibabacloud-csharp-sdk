// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageScanAuthCountResponseBody : TeaModel {
        /// <summary>
        /// The details about the quota for container image scan.
        /// </summary>
        [NameInMap("ImageScan")]
        [Validation(Required=false)]
        public DescribeImageScanAuthCountResponseBodyImageScan ImageScan { get; set; }
        public class DescribeImageScanAuthCountResponseBodyImageScan : TeaModel {
            /// <summary>
            /// The quota for container image scan.
            /// </summary>
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public long? ImageScanCapacity { get; set; }

            /// <summary>
            /// The instance ID of Security Center.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The consumed quota for container image scan.
            /// </summary>
            [NameInMap("ScanCount")]
            [Validation(Required=false)]
            public long? ScanCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
