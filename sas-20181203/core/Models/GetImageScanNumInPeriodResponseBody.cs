// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetImageScanNumInPeriodResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("ImageScanData")]
        [Validation(Required=false)]
        public GetImageScanNumInPeriodResponseBodyImageScanData ImageScanData { get; set; }
        public class GetImageScanNumInPeriodResponseBodyImageScanData : TeaModel {
            /// <summary>
            /// The number of image scans.
            /// </summary>
            [NameInMap("ImageScanCount")]
            [Validation(Required=false)]
            public int? ImageScanCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
