// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class UpdateDataCacheRequest : TeaModel {
        /// <summary>
        /// The bucket in which the data cache is stored. Default value: default.
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate a token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure the idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The data cache ID.
        /// </summary>
        [NameInMap("DataCacheId")]
        [Validation(Required=false)]
        public string DataCacheId { get; set; }

        /// <summary>
        /// The information about the data source.
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public UpdateDataCacheRequestDataSource DataSource { get; set; }
        public class UpdateDataCacheRequestDataSource : TeaModel {
            /// <summary>
            /// The parameters that are configured for the data source.
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public Dictionary<string, string> Options { get; set; }

            /// <summary>
            /// The type of the data source. Valid values:
            /// 
            /// *   URL
            /// *   NAS
            /// *   OSS
            /// *   SNAPSHOT
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The elastic IP address (EIP) to be created and associated. If no NAT gateway is configured for the virtual private cloud (VPC), you can associate an EIP to pull data from the Internet.
        /// </summary>
        [NameInMap("EipCreateParam")]
        [Validation(Required=false)]
        public UpdateDataCacheRequestEipCreateParam EipCreateParam { get; set; }
        public class UpdateDataCacheRequestEipCreateParam : TeaModel {
            /// <summary>
            /// The bandwidth of the EIP. Unit: Mbit/s. Default value: 5.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The EIP bandwidth plan to be associated.
            /// </summary>
            [NameInMap("CommonBandwidthPackage")]
            [Validation(Required=false)]
            public string CommonBandwidthPackage { get; set; }

            /// <summary>
            /// The line type of the EIP. Valid values:
            /// 
            /// *   BGP (default): BGP (Multi-ISP) line
            /// *   BGP_PRO: BGP (Multi-ISP) Pro line
            /// </summary>
            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            /// <summary>
            /// The metering method of the EIP. Valid values:
            /// 
            /// *   PayByBandwidth: pay-by-bandwidth
            /// *   PayByTraffic: pay-by-data-transfer
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// The ID of the IP address pool. The EIP is allocated from the IP address pool. You cannot use the IP address pool feature by default. To use this feature, you must apply for the privilege in the Quota Center console.
            /// </summary>
            [NameInMap("PublicIpAddressPoolId")]
            [Validation(Required=false)]
            public string PublicIpAddressPoolId { get; set; }

        }

        /// <summary>
        /// The ID of the elastic IP address (EIP). If no NAT gateway is configured for the virtual private cloud (VPC), you can bind an EIP to the elastic container instance to pull data from the Internet.
        /// </summary>
        [NameInMap("EipInstanceId")]
        [Validation(Required=false)]
        public string EipInstanceId { get; set; }

        /// <summary>
        /// The data cache name.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
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
        /// The retention period for the data cache. The data cache is deleted after the retention period expires. By default, the data cache does not expire.
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// The ID of the security group.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The data cache size.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// The tags that are added to the data cache.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UpdateDataCacheRequestTag> Tag { get; set; }
        public class UpdateDataCacheRequestTag : TeaModel {
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
        /// The vSwitch ID.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
