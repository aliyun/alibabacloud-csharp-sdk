// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetInstanceListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned. The HTTP status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the instances.
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public GetInstanceListResponseBodyInstanceList InstanceList { get; set; }
        public class GetInstanceListResponseBodyInstanceList : TeaModel {
            [NameInMap("InstanceVO")]
            [Validation(Required=false)]
            public List<GetInstanceListResponseBodyInstanceListInstanceVO> InstanceVO { get; set; }
            public class GetInstanceListResponseBodyInstanceListInstanceVO : TeaModel {
                /// <summary>
                /// The configurations of the instance.
                /// </summary>
                [NameInMap("AllConfig")]
                [Validation(Required=false)]
                public string AllConfig { get; set; }

                /// <summary>
                /// The time when the instance was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The type of the network in which the instance is deployed. Valid values:
                /// 
                /// *   **4**: the Internet and virtual private clouds (VPCs).
                /// *   **5**: VPCs.
                /// </summary>
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public int? DeployType { get; set; }

                /// <summary>
                /// The size of the disk.
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// The type of the disk. Unit: GB. Valid values:
                /// 
                /// *   **0**: ultra disk
                /// *   **1**: standard SSD
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public int? DiskType { get; set; }

                /// <summary>
                /// The default endpoint of the instance in domain name mode. The default endpoint of an instance can be in domain name mode or IP address mode.
                /// 
                /// *   Domain name mode: A default endpoint in this mode consists of a domain name of the instance and a port number. The format of a default endpoint in this mode is `{Instance domain name}:{Port number}`.
                /// *   IP address mode: A default endpoint in this mode consists of the IP address of a broker and a port number. The format of a default endpoint in this mode is `{Broker IP address}:{Port number}`.
                /// </summary>
                [NameInMap("DomainEndpoint")]
                [Validation(Required=false)]
                public string DomainEndpoint { get; set; }

                /// <summary>
                /// The peak public traffic allowed for the instance.
                /// </summary>
                [NameInMap("EipMax")]
                [Validation(Required=false)]
                public int? EipMax { get; set; }

                /// <summary>
                /// The default endpoint of the instance in IP address mode. The default endpoint of an instance can be in domain name mode or IP address mode.
                /// 
                /// *   Domain name mode: A default endpoint in this mode consists of a domain name of the instance and a port number. The format of a default endpoint in this mode is `{Instance domain name}:{Port number}`.
                /// *   IP address mode: A default endpoint in this mode consists of the IP address of a broker and a port number. The format of a default endpoint in this mode is `{Broker IP address}:{Port number}`.
                /// </summary>
                [NameInMap("EndPoint")]
                [Validation(Required=false)]
                public string EndPoint { get; set; }

                /// <summary>
                /// The expiration time. Unit: milliseconds.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public long? ExpiredTime { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The peak traffic allowed for the instance.
                /// </summary>
                [NameInMap("IoMax")]
                [Validation(Required=false)]
                public int? IoMax { get; set; }

                [NameInMap("IoMaxSpec")]
                [Validation(Required=false)]
                public string IoMaxSpec { get; set; }

                /// <summary>
                /// The ID of the key that is used for disk encryption in the region where the instance resides.
                /// </summary>
                [NameInMap("KmsKeyId")]
                [Validation(Required=false)]
                public string KmsKeyId { get; set; }

                /// <summary>
                /// The retention period of messages on the instance. Unit: hours.
                /// </summary>
                [NameInMap("MsgRetain")]
                [Validation(Required=false)]
                public int? MsgRetain { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The billing method of the instance. Valid values:
                /// 
                /// *   **0**: the subscription billing method
                /// *   **1**: the pay-as-you-go billing method
                /// </summary>
                [NameInMap("PaidType")]
                [Validation(Required=false)]
                public int? PaidType { get; set; }

                /// <summary>
                /// The ID of the region where the instance resides.
                /// </summary>
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
                /// The Simple Authentication and Security Layer (SASL) endpoint of the instance in domain name mode. The SASL endpoint of an instance can be in domain name mode or IP address mode.
                /// 
                /// *   Domain name mode: An SASL endpoint in this mode consists of a domain name of the instance and a port number. The format of an SASL endpoint in this mode is `{Instance domain name}:{Port number}`.
                /// *   IP address mode: An SASL endpoint in this mode consists of the IP address of the broker and a port number. The format of an SASL endpoint in this mode is `{Broker IP address}:{Port number}`.
                /// </summary>
                [NameInMap("SaslDomainEndpoint")]
                [Validation(Required=false)]
                public string SaslDomainEndpoint { get; set; }

                /// <summary>
                /// The security group of the instance.
                /// 
                /// *   If the instance is deployed in the Message Queue for Apache Kafka console or by calling the [StartInstance](~~157786~~) operation without configuring a security group, no value is returned for this parameter.
                /// *   If the instance is deployed by calling the [StartInstance](~~157786~~) operation and a security group is configured, the return value is the configured security group.
                /// </summary>
                [NameInMap("SecurityGroup")]
                [Validation(Required=false)]
                public string SecurityGroup { get; set; }

                /// <summary>
                /// The status of the instance. Valid values:
                /// 
                /// *   **0**: pending
                /// *   **1**: deploying
                /// *   **5**: running
                /// *   **15**: expired
                /// </summary>
                [NameInMap("ServiceStatus")]
                [Validation(Required=false)]
                public int? ServiceStatus { get; set; }

                /// <summary>
                /// The edition of the instance. Valid values:
                /// 
                /// *   **professional**: Professional Edition (High Write)
                /// *   **professionalForHighRead**: Professional Edition (High Read)
                /// *   **normal**: Standard Edition
                /// </summary>
                [NameInMap("SpecType")]
                [Validation(Required=false)]
                public string SpecType { get; set; }

                /// <summary>
                /// The SSL endpoint of the instance in domain name mode. The SSL endpoint of an instance can be in domain name mode or IP address mode.
                /// 
                /// *   Domain name mode: An SSL endpoint in this mode consists of a domain name of the instance and a port number. The format of an SSL endpoint in this mode is `{Instance domain name}:{Port number}`.
                /// *   IP address mode: An SSL endpoint in this mode consists of the IP address of the broker and a port number. The format of an SSL endpoint in this mode is `{Broker IP address}:{Port number}`.
                /// </summary>
                [NameInMap("SslDomainEndpoint")]
                [Validation(Required=false)]
                public string SslDomainEndpoint { get; set; }

                /// <summary>
                /// The Secure Sockets Layer (SSL) endpoint of the instance in IP address mode. The SSL endpoint of an instance can be in domain name mode or IP address mode.
                /// 
                /// *   Domain name mode: An SSL endpoint in this mode consists of a domain name of the instance and a port number. The format of an SSL endpoint in this mode is `{Instance domain name}:{Port number}`.
                /// *   IP address mode: An SSL endpoint in this mode consists of the IP address of the broker and a port number. The format of an SSL endpoint in this mode is `{Broker IP address}:{Port number}`.
                /// </summary>
                [NameInMap("SslEndPoint")]
                [Validation(Required=false)]
                public string SslEndPoint { get; set; }

                /// <summary>
                /// The ID of the zone.
                /// </summary>
                [NameInMap("StandardZoneId")]
                [Validation(Required=false)]
                public string StandardZoneId { get; set; }

                /// <summary>
                /// The tags that are attached to the instance.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public GetInstanceListResponseBodyInstanceListInstanceVOTags Tags { get; set; }
                public class GetInstanceListResponseBodyInstanceListInstanceVOTags : TeaModel {
                    [NameInMap("TagVO")]
                    [Validation(Required=false)]
                    public List<GetInstanceListResponseBodyInstanceListInstanceVOTagsTagVO> TagVO { get; set; }
                    public class GetInstanceListResponseBodyInstanceListInstanceVOTagsTagVO : TeaModel {
                        /// <summary>
                        /// The key of the tag.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The maximum number of topics that can be created on the instance.
                /// </summary>
                [NameInMap("TopicNumLimit")]
                [Validation(Required=false)]
                public int? TopicNumLimit { get; set; }

                /// <summary>
                /// The upgrade information about the instance.
                /// </summary>
                [NameInMap("UpgradeServiceDetailInfo")]
                [Validation(Required=false)]
                public GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfo UpgradeServiceDetailInfo { get; set; }
                public class GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfo : TeaModel {
                    /// <summary>
                    /// The open source Apache Kafka version that corresponds to the instance.
                    /// </summary>
                    [NameInMap("Current2OpenSourceVersion")]
                    [Validation(Required=false)]
                    public string Current2OpenSourceVersion { get; set; }

                }

                /// <summary>
                /// The number of used groups.
                /// </summary>
                [NameInMap("UsedGroupCount")]
                [Validation(Required=false)]
                public int? UsedGroupCount { get; set; }

                /// <summary>
                /// The number of used partitions.
                /// </summary>
                [NameInMap("UsedPartitionCount")]
                [Validation(Required=false)]
                public int? UsedPartitionCount { get; set; }

                /// <summary>
                /// The number of used topics.
                /// </summary>
                [NameInMap("UsedTopicCount")]
                [Validation(Required=false)]
                public int? UsedTopicCount { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The ID of the zone.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
