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
            /// The name of the EIP.
            /// 
            /// The name must be 1 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The IP address pool to which the EIP that you want to query belongs.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The filter value used to query resources. Specify the time in the ISO 8601 standard in `YYYY-MM-DDThh:mmZ` format. The time must be in UTC.
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("AssociatedInstanceId")]
        [Validation(Required=false)]
        public string AssociatedInstanceId { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("AssociatedInstanceType")]
        [Validation(Required=false)]
        public string AssociatedInstanceType { get; set; }

        /// <summary>
        /// The details about the EIP.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The time when the renewal takes effect. The time is displayed in `YYYY-MM-DDThh:mm:ssZ` format.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The filter value used to query resources. Specify the time in the ISO 8601 standard in `YYYY-MM-DDThh:mmZ` format. The time must be in UTC.
        /// </summary>
        [NameInMap("EipAddress")]
        [Validation(Required=false)]
        public string EipAddress { get; set; }

        /// <summary>
        /// The status of the EIP. Valid values:
        /// 
        /// *   **Associating**: being associated
        /// *   **Unassociating**: being disassociated
        /// *   **InUse**: allocated
        /// *   **Available**: available
        /// *   **Releasing**: being released
        /// </summary>
        [NameInMap("EipName")]
        [Validation(Required=false)]
        public string EipName { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and sends the request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// The filter key used to query resources. Set the value to **CreationStartTime**, which indicates the time when the system started to create the resource.
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        /// <summary>
        /// The ID of the request.
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
        /// The ID of the cloud resource.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The billing method of the EIP. Valid values:
        /// 
        /// *   **PostPaid**: pay-as-you-go
        /// *   **PrePaid**: subscription
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The time when the EIP was created. The time is displayed in `YYYY-MM-DDThh:mm:ssZ` format.
        /// </summary>
        [NameInMap("PublicIpAddressPoolId")]
        [Validation(Required=false)]
        public string PublicIpAddressPoolId { get; set; }

        /// <summary>
        /// The line type. Valid values:
        /// 
        /// *   **BGP** (default): BGP (Multi-ISP) lines. All regions support BGP (Multi-ISP) EIPs.
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines. Only the following regions support BGP (Multi-ISP) Pro lines: China (Hong Kong), Singapore, Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok).
        /// 
        /// For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro, see [EIP line types](~~32321~~).
        /// 
        /// If you are allowed to use single-ISP bandwidth, you can also choose one of the following values:
        /// 
        /// *   **ChinaTelecom**: China Telecom
        /// *   **ChinaUnicom**: China Unicom
        /// *   **ChinaMobile**: China Mobile
        /// *   **ChinaTelecom_L2**: China Telecom L2
        /// *   **ChinaUnicom_L2**: China Unicom L2
        /// *   **ChinaMobile_L2**: China Mobile L2
        /// 
        /// If your services are deployed in China East 1 Finance, you must set this parameter to **BGP_FinanceCloud**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the cloud resource with which you want to associate the EIP. Valid values:
        /// 
        /// *   **EcsInstance** (default): an Elastic Compute Service (ECS) instance in a virtual private cloud (VPC)
        /// *   **SlbInstance**: a Server Load Balancer (SLB) instance in a VPC
        /// *   **Nat**: a NAT gateway
        /// *   **HaVip**: a high-availability virtual IP address (HAVIP)
        /// *   **NetworkInterface**: a secondary ENI
        /// *   **IpAddress**: an IP address
        /// 
        /// >  You can associate only one EIP with each ECS instance, SLB instance, HAVIP, or IP address. You can associate multiple EIPs with each NAT gateway. The number of EIPs that you can associate with a secondary ENI depends on the association mode. For more information, see [EIP overview](~~72125~~).
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
        /// The type of the renewal order. Valid values:
        /// 
        /// *   **RENEWCHANGE**: renewal with an upgrade or a downgrade
        /// *   **TEMP_UPGRADE**: temporary upgrade
        /// *   **UPGRADE**: upgrade
        /// </summary>
        [NameInMap("SecurityProtectionEnabled")]
        [Validation(Required=false)]
        public bool? SecurityProtectionEnabled { get; set; }

        /// <summary>
        /// The reason why the EIP is locked. Valid values:
        /// 
        /// *   **financial**: The EIP is locked due to overdue payments.
        /// *   **security**: The EIP is locked for security reasons.
        /// </summary>
        [NameInMap("SegmentInstanceId")]
        [Validation(Required=false)]
        public string SegmentInstanceId { get; set; }

        /// <summary>
        /// The filter key used to query resources. Set the value to **CreationEndTime**, which indicates the time when the system completed creating the resource.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
