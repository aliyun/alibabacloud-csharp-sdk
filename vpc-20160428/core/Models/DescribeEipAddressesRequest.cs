// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipAddressesRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeEipAddressesRequestFilter> Filter { get; set; }
        public class DescribeEipAddressesRequestFilter : TeaModel {
            /// <summary>
            /// The filter key used to query resources. Set the value to **CreationStartTime**, which specifies the time when the system started to create the resource.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The filter value used to query resources. Specify the time in the ISO 8601 standard in the `YYYY-MM-DDThh:mmZ` format. The time must be in Coordinated Universal Time (UTC).
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the EIP that you want to query.
        /// 
        /// You can specify up to 50 EIP IDs. Separate multiple IDs with commas (,).
        /// 
        /// >  If both **EipAddress** and **AllocationId** are specified, you can specify up to 50 EIP IDs for **AllocationId**, and specify up to 50 EIPs for **EipAddress**.
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// The ID of the instance associated with the EIP.
        /// </summary>
        [NameInMap("AssociatedInstanceId")]
        [Validation(Required=false)]
        public string AssociatedInstanceId { get; set; }

        /// <summary>
        /// The type of the cloud resource with which you want to associate the EIP. Valid values:
        /// 
        /// *   **EcsInstance** (default): an Elastic Compute Service (ECS) instance in a virtual private cloud (VPC).
        /// *   **SlbInstance**: a Server Load Balancer (SLB) instance in a VPC.
        /// *   **Nat**: a NAT gateway.
        /// *   **HaVip**: a high-availability virtual IP address (HAVIP).
        /// *   **NetworkInterface**: a secondary elastic network interface (ENI).
        /// *   **IpAddress**: an IP address.
        /// 
        /// >  You can associate only one EIP with each ECS instance, SLB instance, HAVIP, or IP address. You can associate multiple EIPs with each NAT gateway. The number of EIPs that you can associate with a secondary ENI depends on the association mode. For more information, see [Associate EIPs with and disassociate EIPs from cloud resources](~~72125~~).
        /// </summary>
        [NameInMap("AssociatedInstanceType")]
        [Validation(Required=false)]
        public string AssociatedInstanceType { get; set; }

        /// <summary>
        /// The billing method of the EIP. Valid values:
        /// 
        /// *   **PostPaid**: pay-as-you-go.
        /// *   **PrePaid**: subscription.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The EIP that you want to query.
        /// 
        /// You can specify up to 50 EIPs. Separate multiple EIPs with commas (,).
        /// 
        /// >  If both **EipAddress** and **AllocationId** are specified, you can specify up to 50 EIPs for **EipAddress**, and specify up to 50 EIP IDs for **AllocationId**.
        /// </summary>
        [NameInMap("EipAddress")]
        [Validation(Required=false)]
        public string EipAddress { get; set; }

        /// <summary>
        /// The name of the EIP.
        /// 
        /// The name must be 1 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("EipName")]
        [Validation(Required=false)]
        public string EipName { get; set; }

        /// <summary>
        /// The line type. Valid values:
        /// 
        /// *   **BGP** (default): Border Gateway Protocol (BGP) (Multi-ISP) lines. All regions support BGP (Multi-ISP) EIPs.
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines. Only the following regions support BGP (Multi-ISP) Pro lines: China (Hong Kong), Singapore, Japan (Tokyo), Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok).
        /// 
        /// For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro, see the [Line types](~~32321~~) section of the "What is EIP?" topic.
        /// 
        /// If you are allowed to use single-ISP bandwidth, you can also use one of the following values:
        /// 
        /// *   **ChinaTelecom**
        /// *   **ChinaUnicom**
        /// *   **ChinaMobile**
        /// *   **ChinaTelecom_L2**
        /// *   **ChinaUnicom_L2**
        /// *   **ChinaMobile_L2**
        /// 
        /// If your services are deployed in China East 1 Finance, this parameter is required and you must set the value to **BGP_FinanceCloud**.
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// Specifies whether to return information about pending orders. Valid values:
        /// 
        /// *   **false** (default)
        /// *   **true**
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        /// <summary>
        /// The reason why the EIP is locked. Valid values:
        /// 
        /// *   **financial**: The EIP is locked due to overdue payments.
        /// *   **security**: The EIP is locked for security reasons.
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to **100**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The IP address pool to which the EIP that you want to query belongs.
        /// </summary>
        [NameInMap("PublicIpAddressPoolId")]
        [Validation(Required=false)]
        public string PublicIpAddressPoolId { get; set; }

        /// <summary>
        /// The region ID of the EIP.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the EIP belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to enable Anti-DDoS Pro/Premium. Valid values:
        /// 
        /// *   **false** (default)
        /// *   **true**
        /// </summary>
        [NameInMap("SecurityProtectionEnabled")]
        [Validation(Required=false)]
        public bool? SecurityProtectionEnabled { get; set; }

        /// <summary>
        /// The ID of the contiguous EIP group.
        /// </summary>
        [NameInMap("SegmentInstanceId")]
        [Validation(Required=false)]
        public string SegmentInstanceId { get; set; }

        /// <summary>
        /// The state of the EIP. Valid values:
        /// 
        /// *   **Associating**
        /// *   **Unassociating**
        /// *   **InUse**
        /// *   **Available**
        /// *   **Releasing**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags used to filter EIPs.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeEipAddressesRequestTag> Tag { get; set; }
        public class DescribeEipAddressesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag. You can specify up to 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The tag key can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. You can specify up to 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag value cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
