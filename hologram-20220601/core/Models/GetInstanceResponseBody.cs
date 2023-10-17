// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// The details of the instance.
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstance Instance { get; set; }
        public class GetInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// Indicates whether auto-renewal is enabled.
            /// 
            /// Valid values:
            /// 
            /// *   true
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   false
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("AutoRenewal")]
            [Validation(Required=false)]
            public string AutoRenewal { get; set; }

            /// <summary>
            /// The cold storage capacity of the instance. Unit: GB. Standard SSD is used for hot storage, and HDD is used for cold storage.
            /// </summary>
            [NameInMap("ColdStorage")]
            [Validation(Required=false)]
            public long? ColdStorage { get; set; }

            /// <summary>
            /// The commodity code.
            /// 
            /// Valid values:
            /// 
            /// *   hologram_maxcomputeAccelerate_public_cn
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     China site/Lakehouse Acceleration Edition
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   hologram_combo_public_cn
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     China site/Subscription
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   hologram_prepay_public_intl
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     International site/Subscription
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   hologram_storage_dp_cn
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     China site/Storage plan
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   hologram_postpay_public_cn
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     China site/Pay-as-you-go
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   hologram_postpay_public_intl
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     International site/Pay-as-you-go
            /// 
            ///     <!-- -->
            /// 
            /// *   hologram_maxcomputeAccelerate_public_intl
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     International site/Lakehouse Acceleration Edition
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   hologram_cu_dp_cn
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     China site/Compute plan
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The number of compute nodes. In a typical configuration, a node has 16 vCPUs and 32 GB of memory.
            /// </summary>
            [NameInMap("ComputeNodeCount")]
            [Validation(Required=false)]
            public long? ComputeNodeCount { get; set; }

            /// <summary>
            /// The number of vCPUs.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public long? Cpu { get; set; }

            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The amount of data that can be stored in the disk of the Standard storage class. Unit: GB.
            /// </summary>
            [NameInMap("Disk")]
            [Validation(Required=false)]
            public string Disk { get; set; }

            /// <summary>
            /// Indicates whether data lake acceleration is enabled.
            /// </summary>
            [NameInMap("EnableHiveAccess")]
            [Validation(Required=false)]
            public string EnableHiveAccess { get; set; }

            /// <summary>
            /// The list of endpoints.
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyInstanceEndpoints> Endpoints { get; set; }
            public class GetInstanceResponseBodyInstanceEndpoints : TeaModel {
                /// <summary>
                /// The endpoint. This parameter is returned if both the AnyTunnel and SingleTunnel modes are enabled for an instance, and the instance is switched from the AnyTunnel mode to the SingleTunnel mode. In this case, two endpoints are returned.
                /// </summary>
                [NameInMap("AlternativeEndpoints")]
                [Validation(Required=false)]
                public string AlternativeEndpoints { get; set; }

                /// <summary>
                /// Indicates whether the network is enabled.
                /// 
                /// Valid values:
                /// 
                /// *   true
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   false
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// The endpoint.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The network type.
                /// 
                /// Valid values:
                /// 
                /// *   VPCSingleTunnel
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     virtual private cloud (VPC)
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// 
                /// *   Intranet
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     internal network
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// 
                /// *   VPCAnyTunnel
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     not supported by new instances
                /// 
                ///     <!-- -->
                /// 
                /// *   Internet
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     Internet
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The VPC ID.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The ID of VPC to which the instance belongs.
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

            /// <summary>
            /// The expiration time. This parameter is invalid for pay-as-you-go instances.
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// 网关节点数量。
            /// </summary>
            [NameInMap("GatewayCount")]
            [Validation(Required=false)]
            public long? GatewayCount { get; set; }

            /// <summary>
            /// 网关cpu资源。
            /// 单位：core。
            /// </summary>
            [NameInMap("GatewayCpu")]
            [Validation(Required=false)]
            public long? GatewayCpu { get; set; }

            /// <summary>
            /// 网关内存资源。
            /// 单位：GB。
            /// </summary>
            [NameInMap("GatewayMemory")]
            [Validation(Required=false)]
            public long? GatewayMemory { get; set; }

            /// <summary>
            /// The billing method of the instance.
            /// 
            /// Valid values:
            /// 
            /// *   PostPaid
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     pay-as-you-go
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   PrePaid
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     subscription
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The instance name. The instance name must be 2 to 64 characters in length.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The owner of the instance.
            /// </summary>
            [NameInMap("InstanceOwner")]
            [Validation(Required=false)]
            public string InstanceOwner { get; set; }

            /// <summary>
            /// The status of the instance.
            /// 
            /// Valid values:
            /// 
            /// *   Creating
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Running
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Suspended
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Allocating
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// The type of the instance.
            /// 
            /// Valid values:
            /// 
            /// *   Follower
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     read-only secondary instance
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   Standard
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     normal instance
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The ID of the primary instance.
            /// </summary>
            [NameInMap("LeaderInstanceId")]
            [Validation(Required=false)]
            public string LeaderInstanceId { get; set; }

            /// <summary>
            /// The memory size. Unit: GB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The reason for the suspension.
            /// </summary>
            [NameInMap("SuspendReason")]
            [Validation(Required=false)]
            public string SuspendReason { get; set; }

            /// <summary>
            /// The instance tag.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyInstanceTags> Tags { get; set; }
            public class GetInstanceResponseBodyInstanceTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The instance version.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// The ID of the zone where the instance resides.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The request result, which indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
