// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcProbeScanResultListResponseBody : TeaModel {
        /// <summary>
        /// The instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeIdcProbeScanResultListResponseBodyInstances> Instances { get; set; }
        public class DescribeIdcProbeScanResultListResponseBodyInstances : TeaModel {
            /// <summary>
            /// The status of the client of the instance on which the probe is installed. Valid values:
            /// 
            /// *   **online**: The Security Center agent on the asset is **enabled**.
            /// *   **offline**: The Security Center agent on the asset is **disabled**.
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// The name of the IDC.
            /// </summary>
            [NameInMap("IdcName")]
            [Validation(Required=false)]
            public string IdcName { get; set; }

            /// <summary>
            /// The CIDR blocks.
            /// </summary>
            [NameInMap("IpSegment")]
            [Validation(Required=false)]
            public string IpSegment { get; set; }

            /// <summary>
            /// The timestamp when the last scan was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// The operating system type of the asset. Valid values:
            /// 
            /// *   **windows**
            /// *   **linux**
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// The private IP address of the associated instance.
            /// </summary>
            [NameInMap("ProbeInternetIp")]
            [Validation(Required=false)]
            public string ProbeInternetIp { get; set; }

            /// <summary>
            /// The private IP address of the associated instance.
            /// </summary>
            [NameInMap("ProbeIntranetIp")]
            [Validation(Required=false)]
            public string ProbeIntranetIp { get; set; }

            /// <summary>
            /// The name of the associated instance.
            /// </summary>
            [NameInMap("ProbeMachineName")]
            [Validation(Required=false)]
            public string ProbeMachineName { get; set; }

            /// <summary>
            /// The UUID of the associated instance.
            /// </summary>
            [NameInMap("ProbeUuid")]
            [Validation(Required=false)]
            public string ProbeUuid { get; set; }

            /// <summary>
            /// The ID of the scan result.
            /// </summary>
            [NameInMap("ScanResultId")]
            [Validation(Required=false)]
            public long? ScanResultId { get; set; }

            /// <summary>
            /// The IP address that is scanned.
            /// </summary>
            [NameInMap("ScannedIp")]
            [Validation(Required=false)]
            public string ScannedIp { get; set; }

            /// <summary>
            /// The port that is scanned.
            /// </summary>
            [NameInMap("ValidPort")]
            [Validation(Required=false)]
            public string ValidPort { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeIdcProbeScanResultListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeIdcProbeScanResultListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
