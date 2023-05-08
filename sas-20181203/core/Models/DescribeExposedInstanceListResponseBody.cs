// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceListResponseBody : TeaModel {
        /// <summary>
        /// The port that is exposed on the Internet.
        /// </summary>
        [NameInMap("ExposedInstances")]
        [Validation(Required=false)]
        public List<DescribeExposedInstanceListResponseBodyExposedInstances> ExposedInstances { get; set; }
        public class DescribeExposedInstanceListResponseBodyExposedInstances : TeaModel {
            /// <summary>
            /// An array that consists of the details about the exposed asset.
            /// </summary>
            [NameInMap("AsapVulCount")]
            [Validation(Required=false)]
            public int? AsapVulCount { get; set; }

            [NameInMap("ExploitHealthCount")]
            [Validation(Required=false)]
            public int? ExploitHealthCount { get; set; }

            [NameInMap("ExposureComponent")]
            [Validation(Required=false)]
            public string ExposureComponent { get; set; }

            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("ExposureIp")]
            [Validation(Required=false)]
            public string ExposureIp { get; set; }

            /// <summary>
            /// Queries the information about the servers that are exposed on the Internet.
            /// </summary>
            [NameInMap("ExposurePort")]
            [Validation(Required=false)]
            public string ExposurePort { get; set; }

            /// <summary>
            /// Specifies whether the server has vulnerabilities. Valid values:
            /// 
            /// *   **true**: The server has vulnerabilities.
            /// *   **false**: The server does not have vulnerabilities.
            /// </summary>
            [NameInMap("ExposureType")]
            [Validation(Required=false)]
            public string ExposureType { get; set; }

            /// <summary>
            /// The ID of the request, which is used to locate and troubleshoot issues.
            /// </summary>
            [NameInMap("ExposureTypeId")]
            [Validation(Required=false)]
            public string ExposureTypeId { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("LaterVulCount")]
            [Validation(Required=false)]
            public int? LaterVulCount { get; set; }

            /// <summary>
            /// The private IP address of the server.
            /// </summary>
            [NameInMap("NntfVulCount")]
            [Validation(Required=false)]
            public int? NntfVulCount { get; set; }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the instance to which the resource belongs. The valid values of this parameter vary based on the ExposureType parameter.
            /// 
            /// *   If the value of the ExposureType parameter is **INTERNET_IP**, this parameter is empty.
            /// *   If the value of the ExposureType parameter is **SLB**, the value of this parameter is the ID of the SLB instance.
            /// *   If the value of the ExposureType parameter is **EIP**, the value of this parameter is the ID of the EIP.
            /// *   If the value of the ExposureType parameter is **DNAT**, the value of this parameter is the ID of the NAT gateway.
            /// </summary>
            [NameInMap("TotalVulCount")]
            [Validation(Required=false)]
            public int? TotalVulCount { get; set; }

            /// <summary>
            /// DescribeExposedInstanceList
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The public IP address of the server.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeExposedInstanceListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeExposedInstanceListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The ID of the server group.
            /// 
            /// > You can call the [DescribeAllGroups](~~DescribeAllGroups~~) operation to query the IDs of server groups.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The number of the page to return.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of low-severity vulnerabilities that are exposed on the Internet and can be exploited by attackers.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The number of medium-severity vulnerabilities that are exposed on the Internet and can be exploited by attackers.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The resource from which the asset is exposed. Valid values:
        /// 
        /// *   **INTERNET_IP**: the public IP address of an ECS instance
        /// *   **SLB**: the public IP address of a Server Load Balancer (SLB) instance
        /// *   **EIP**: an elastic IP address (EIP)
        /// *   **DNAT**: the NAT gateway that connects to the Internet by using the DNAT feature
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
