// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// Details of the instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyInstances Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class ListInstancesResponseBodyInstancesInstance : TeaModel {
                /// <summary>
                /// Indicates whether auto-renewal is enabled. This parameter takes effect only for subscription instances.
                /// </summary>
                [NameInMap("AutoRenew")]
                [Validation(Required=false)]
                public bool? AutoRenew { get; set; }

                /// <summary>
                /// The billing method of the instance.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The time when the image was created. The time follows the ISO 8601 standard.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The instance description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The information about the elastic IP address (EIP) of the instance.
                /// </summary>
                [NameInMap("EipAddress")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstancesInstanceEipAddress EipAddress { get; set; }
                public class ListInstancesResponseBodyInstancesInstanceEipAddress : TeaModel {
                    /// <summary>
                    /// The ID of the EIP that is used by the instance.
                    /// </summary>
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    /// <summary>
                    /// The bandwidth of the EIP.
                    /// </summary>
                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public int? Bandwidth { get; set; }

                    /// <summary>
                    /// The billing method of the EIP.
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

                }

                /// <summary>
                /// The time when the subscription instance expires.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The image ID.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The instance name.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The instance type.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The name of the key pair for the instance.
                /// </summary>
                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

                /// <summary>
                /// The display name of the OS in Chinese.
                /// </summary>
                [NameInMap("OsName")]
                [Validation(Required=false)]
                public string OsName { get; set; }

                /// <summary>
                /// The display name of the OS in English.
                /// </summary>
                [NameInMap("OsNameEn")]
                [Validation(Required=false)]
                public string OsNameEn { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The resolution of the instance.
                /// </summary>
                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public string Resolution { get; set; }

                /// <summary>
                /// The ID of the security group that the instance uses. The security group is the same as that of the Elastic Compute Service (ECS) instance that you use.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// The instance state. Valid values:
                /// 
                /// *   Pending: The instance is being created.
                /// *   Running: The instance is running.
                /// *   Starting: The instance is being started.
                /// *   Stopping: The instance is being stopped.
                /// *   Stopped: The instance is stopped.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags of the instance.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstancesInstanceTags Tags { get; set; }
                public class ListInstancesResponseBodyInstancesInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListInstancesResponseBodyInstancesInstanceTagsTag> Tag { get; set; }
                    public class ListInstancesResponseBodyInstancesInstanceTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key of the instance.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value of the instance.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The information about the virtual private cloud (VPC) in which the instance is deployed.
                /// </summary>
                [NameInMap("VpcAttributes")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstancesInstanceVpcAttributes VpcAttributes { get; set; }
                public class ListInstancesResponseBodyInstancesInstanceVpcAttributes : TeaModel {
                    /// <summary>
                    /// The private IP address.
                    /// </summary>
                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public string PrivateIpAddress { get; set; }

                    /// <summary>
                    /// The vSwitch ID.
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                /// <summary>
                /// The information about webRtcToken.
                /// </summary>
                [NameInMap("WebRtcToken")]
                [Validation(Required=false)]
                public string WebRtcToken { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The maximum number of entries returned on each page. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries that is returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
