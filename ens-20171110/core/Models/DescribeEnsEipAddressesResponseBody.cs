// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsEipAddressesResponseBody : TeaModel {
        /// <summary>
        /// Details about the EIP.
        /// </summary>
        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public DescribeEnsEipAddressesResponseBodyEipAddresses EipAddresses { get; set; }
        public class DescribeEnsEipAddressesResponseBodyEipAddresses : TeaModel {
            [NameInMap("EipAddress")]
            [Validation(Required=false)]
            public List<DescribeEnsEipAddressesResponseBodyEipAddressesEipAddress> EipAddress { get; set; }
            public class DescribeEnsEipAddressesResponseBodyEipAddressesEipAddress : TeaModel {
                /// <summary>
                /// The ID of the EIP.
                /// </summary>
                [NameInMap("AllocationId")]
                [Validation(Required=false)]
                public string AllocationId { get; set; }

                /// <summary>
                /// The time when the EIP was created.
                /// </summary>
                [NameInMap("AllocationTime")]
                [Validation(Required=false)]
                public string AllocationTime { get; set; }

                /// <summary>
                /// The peak bandwidth of the EIP. Default value: 5. Valid values: **5** to **10000**. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// The billing method of the EIP. Valid values:
                /// 
                /// *   **PrePaid**: subscription.
                /// *   **PostPaid**: pay-as-you-go
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The description of the EIP.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the ENS node.
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// The ID of the instance that is associated with the EIP.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The type of the instance that is associated with the EIP. Valid values:
                /// 
                /// *   **EnsInstance**: ENS instance in a VPC
                /// *   **SlbInstance**: SLB instance
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The metering method of the EIP.
                /// 
                /// *   **95BandwidthByMonth**: Pay by monthly 95th percentile bandwidth
                /// *   **PayByBandwidth**: Pay by bandwidth
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// The EIP.
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// The running status of the EIP. This parameter is returned if the EIP is a secondary EIP. Valid values:
                /// 
                /// *   **Stopped**
                /// *   **Running**
                /// *   **Starting**
                /// *   **Stopping**
                /// </summary>
                [NameInMap("IpStatus")]
                [Validation(Required=false)]
                public string IpStatus { get; set; }

                /// <summary>
                /// The Internet service provider (ISP). Valid values:
                /// 
                /// *   **cmcc**: China Mobile
                /// *   **unicom**: China Unicom
                /// *   **telecom**: China Telecom
                /// </summary>
                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                /// <summary>
                /// The name of the EIP.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Indicates whether the EIP is a secondary EIP.
                /// </summary>
                [NameInMap("Standby")]
                [Validation(Required=false)]
                public bool? Standby { get; set; }

                /// <summary>
                /// The status of the EIP. Valid values:
                /// 
                /// *   **Associating**
                /// *   **Unassociating**
                /// *   **InUse**
                /// *   **Available**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The page number. Valid values: an integer that is greater than 0. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Valid values: **10** to **100**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
