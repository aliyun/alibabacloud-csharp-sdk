// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetListResponseBody : TeaModel {
        /// <summary>
        /// The details about the assets that are protected by Cloud Firewall.
        /// </summary>
        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<DescribeAssetListResponseBodyAssets> Assets { get; set; }
        public class DescribeAssetListResponseBodyAssets : TeaModel {
            /// <summary>
            /// The UID of the Alibaba Cloud account.
            /// 
            /// >  The value of this parameter indicates the management account to which the member is added.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// The instance ID of the asset that is bound to Cloud Firewall.
            /// </summary>
            [NameInMap("BindInstanceId")]
            [Validation(Required=false)]
            public string BindInstanceId { get; set; }

            /// <summary>
            /// The instance name of the asset that is bound to Cloud Firewall.
            /// </summary>
            [NameInMap("BindInstanceName")]
            [Validation(Required=false)]
            public string BindInstanceName { get; set; }

            [NameInMap("CreateTimeStamp")]
            [Validation(Required=false)]
            public string CreateTimeStamp { get; set; }

            /// <summary>
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("InternetAddress")]
            [Validation(Required=false)]
            public string InternetAddress { get; set; }

            /// <summary>
            /// The internal IP address of the server.
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// The IP version of the asset that is protected by Cloud Firewall.
            /// 
            /// Valid values:
            /// 
            /// *   **4**: IPv4
            /// *   **6**: IPv6
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            /// <summary>
            /// The UID of the member that is added in Cloud Firewall.
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

            /// <summary>
            /// The instance name of the asset that is protected by Cloud Firewall.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NewResourceTag")]
            [Validation(Required=false)]
            public string NewResourceTag { get; set; }

            /// <summary>
            /// The remarks of the asset. Valid values:
            /// 
            /// *   **REGION\_NOT\_SUPPORT**: The region is not supported.
            /// *   **NETWORK\_NOT\_SUPPORT**: The network is not supported.
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// The status of the firewall. Valid values:
            /// 
            /// *   **open**: The firewall is enabled.
            /// *   **opening**: The firewall is being enabled.
            /// *   **closed**: The firewall is disabled.
            /// *   **closing**: The firewall is being disabled.
            /// </summary>
            [NameInMap("ProtectStatus")]
            [Validation(Required=false)]
            public string ProtectStatus { get; set; }

            /// <summary>
            /// The ID of the region in which the asset resides.
            /// </summary>
            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            /// <summary>
            /// Indicates whether the firewall is supported in the region in which the asset resides. Valid values:
            /// 
            /// *   **enable**: supported
            /// *   **disable**: unsupported
            /// </summary>
            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            /// <summary>
            /// The instance ID of the asset.
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            /// <summary>
            /// The type of the asset. Valid values:
            /// 
            /// *   **BastionHostEgressIP**: the egress IP address of a bastion host
            /// *   **BastionHostIngressIP**: the ingress IP address of a bastion host
            /// *   **EcsEIP**: the EIP of an ECS instance
            /// *   **EcsPublicIP**: the public IP address of an ECS instance
            /// *   **EIP**: the EIP
            /// *   **EniEIP**: the EIP of an ENI
            /// *   **NatEIP**: the EIP of a NAT gateway
            /// *   **SlbEIP**: the EIP of an SLB instance
            /// *   **SlbPublicIP**: the public IP address of an SLB instance
            /// *   **NatPublicIP**: the public IP address of a NAT gateway
            /// *   **HAVIP**: the HAVIP
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The risk level of the asset. Valid values:
            /// 
            /// *   **low**: low
            /// *   **middle**: medium
            /// *   **hight**: high
            /// 
            /// >  The value of this parameter is returned only when the UserType parameter is set to free.
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// The status of the security group policy. Valid values:
            /// 
            /// *   **pass**: delivered
            /// *   **block**: undelivered
            /// *   **unsupport**: unsupported
            /// </summary>
            [NameInMap("SgStatus")]
            [Validation(Required=false)]
            public string SgStatus { get; set; }

            /// <summary>
            /// The time when the status of the security group was last checked. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("SgStatusTime")]
            [Validation(Required=false)]
            public long? SgStatusTime { get; set; }

            /// <summary>
            /// The status of traffic redirection for the asset. Valid values:
            /// 
            /// *   **enable**: Traffic redirection is enabled.
            /// *   **disable**: Traffic redirection is disabled.
            /// </summary>
            [NameInMap("SyncStatus")]
            [Validation(Required=false)]
            public string SyncStatus { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the assets that are protected by Cloud Firewall.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
