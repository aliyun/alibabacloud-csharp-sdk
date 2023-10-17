// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListInstancesResponseBody : TeaModel {
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
        /// The list of queried instances.
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstanceList> InstanceList { get; set; }
        public class ListInstancesResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// The commodity code, which is the same as that on the Billing Management page.
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The time when the cluster was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// Indicates whether lakehouse acceleration is enabled.
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
            [NameInMap("EnableHiveAccess")]
            [Validation(Required=false)]
            public string EnableHiveAccess { get; set; }

            /// <summary>
            /// The list of endpoints.
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstanceListEndpoints> Endpoints { get; set; }
            public class ListInstancesResponseBodyInstanceListEndpoints : TeaModel {
                /// <summary>
                /// Indicates whether the endpoint is enabled.
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
                /// *   VPCAnyTunnel
                /// 
                ///     <!-- -->
                /// 
                ///     : This value is not supported by new instances
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     .
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
                /// The vSwitch ID.
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
                /// The ID of the VPC to which the instance belongs.
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

            /// <summary>
            /// The time when the cluster expires.
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// The billing method of the instance. Valid values:
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
            /// The name of the instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

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
            /// The tags that are added to the resource.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstanceListTags> Tags { get; set; }
            public class ListInstancesResponseBodyInstanceListTags : TeaModel {
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
            /// The version of the cluster.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

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
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
