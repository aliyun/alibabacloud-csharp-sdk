// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedStatisticsDetailResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeExposedStatisticsDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeExposedStatisticsDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
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
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array consisting of the gateway assets, ports, system components, or public IP addresses that are exposed on the Internet and are returned.
        /// </summary>
        [NameInMap("StatisticsDetails")]
        [Validation(Required=false)]
        public List<DescribeExposedStatisticsDetailResponseBodyStatisticsDetails> StatisticsDetails { get; set; }
        public class DescribeExposedStatisticsDetailResponseBodyStatisticsDetails : TeaModel {
            /// <summary>
            /// The total number of system vulnerabilities that are detected on your server and are exposed on the Internet.
            /// </summary>
            [NameInMap("ExposedCount")]
            [Validation(Required=false)]
            public int? ExposedCount { get; set; }

            /// <summary>
            /// The system component that is exposed on the Internet.
            /// </summary>
            [NameInMap("ExposureComponent")]
            [Validation(Required=false)]
            public string ExposureComponent { get; set; }

            /// <summary>
            /// The public IP address that is exposed on the Internet.
            /// </summary>
            [NameInMap("ExposureIp")]
            [Validation(Required=false)]
            public string ExposureIp { get; set; }

            /// <summary>
            /// The port that is exposed on the Internet.
            /// </summary>
            [NameInMap("ExposurePort")]
            [Validation(Required=false)]
            public string ExposurePort { get; set; }

            /// <summary>
            /// The resource from which the asset is exposed. Valid values:
            /// 
            /// *   **INTERNET_IP**: the IP address of the Elastic Compute Service (ECS) instance
            /// *   **SLB**: the public IP address of the SLB instance
            /// *   **EIP**: the elastic IP address (EIP)
            /// *   **DNAT**: the NAT gateway that connects to the Internet by using the DNAT feature
            /// </summary>
            [NameInMap("ExposureType")]
            [Validation(Required=false)]
            public string ExposureType { get; set; }

            /// <summary>
            /// The ID of the instance to which the resource belongs. The valid values of this parameter vary based on the value of the ExposureType parameter.
            /// 
            /// *   If the value of the **ExposureType** parameter is **INTERNET_IP**, the value of this parameter is an empty string.
            /// *   If the value of the **ExposureType** parameter is **SLB**, the value of this parameter is the ID of the Internet-facing SLB instance.
            /// *   If the value of the **ExposureType** parameter is **EIP**, the value of this parameter is the ID of the EIP.
            /// *   If the value of the **ExposureType** parameter is **DNAT**, the value of this parameter is the ID of the NAT gateway.
            /// </summary>
            [NameInMap("ExposureTypeId")]
            [Validation(Required=false)]
            public string ExposureTypeId { get; set; }

            /// <summary>
            /// The name of the gateway asset that is exposed on the Internet.
            /// </summary>
            [NameInMap("ExposureTypeInstanceName")]
            [Validation(Required=false)]
            public string ExposureTypeInstanceName { get; set; }

            /// <summary>
            /// The region ID of the asset.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
