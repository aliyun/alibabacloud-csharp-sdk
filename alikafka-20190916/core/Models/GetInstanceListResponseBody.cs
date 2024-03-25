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
        /// The instances.
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
                /// The configurations of the deployed ApsaraMQ for Kafka instance.
                /// </summary>
                [NameInMap("AllConfig")]
                [Validation(Required=false)]
                public string AllConfig { get; set; }

                [NameInMap("ConfluentConfig")]
                [Validation(Required=false)]
                public GetInstanceListResponseBodyInstanceListInstanceVOConfluentConfig ConfluentConfig { get; set; }
                public class GetInstanceListResponseBodyInstanceListInstanceVOConfluentConfig : TeaModel {
                    [NameInMap("ConnectCU")]
                    [Validation(Required=false)]
                    public int? ConnectCU { get; set; }

                    [NameInMap("ConnectReplica")]
                    [Validation(Required=false)]
                    public int? ConnectReplica { get; set; }

                    [NameInMap("ControlCenterCU")]
                    [Validation(Required=false)]
                    public int? ControlCenterCU { get; set; }

                    [NameInMap("ControlCenterReplica")]
                    [Validation(Required=false)]
                    public int? ControlCenterReplica { get; set; }

                    [NameInMap("ControlCenterStorage")]
                    [Validation(Required=false)]
                    public int? ControlCenterStorage { get; set; }

                    [NameInMap("KafkaCU")]
                    [Validation(Required=false)]
                    public int? KafkaCU { get; set; }

                    [NameInMap("KafkaReplica")]
                    [Validation(Required=false)]
                    public int? KafkaReplica { get; set; }

                    [NameInMap("KafkaRestProxyCU")]
                    [Validation(Required=false)]
                    public int? KafkaRestProxyCU { get; set; }

                    [NameInMap("KafkaRestProxyReplica")]
                    [Validation(Required=false)]
                    public int? KafkaRestProxyReplica { get; set; }

                    [NameInMap("KafkaStorage")]
                    [Validation(Required=false)]
                    public int? KafkaStorage { get; set; }

                    [NameInMap("KsqlCU")]
                    [Validation(Required=false)]
                    public int? KsqlCU { get; set; }

                    [NameInMap("KsqlReplica")]
                    [Validation(Required=false)]
                    public int? KsqlReplica { get; set; }

                    [NameInMap("KsqlStorage")]
                    [Validation(Required=false)]
                    public int? KsqlStorage { get; set; }

                    [NameInMap("SchemaRegistryCU")]
                    [Validation(Required=false)]
                    public int? SchemaRegistryCU { get; set; }

                    [NameInMap("SchemaRegistryReplica")]
                    [Validation(Required=false)]
                    public int? SchemaRegistryReplica { get; set; }

                    [NameInMap("ZooKeeperCU")]
                    [Validation(Required=false)]
                    public int? ZooKeeperCU { get; set; }

                    [NameInMap("ZooKeeperReplica")]
                    [Validation(Required=false)]
                    public int? ZooKeeperReplica { get; set; }

                    [NameInMap("ZooKeeperStorage")]
                    [Validation(Required=false)]
                    public int? ZooKeeperStorage { get; set; }

                }

                /// <summary>
                /// The time when the instance was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The type of the network in which the instance is deployed. Valid values:
                /// 
                /// *   **4**: Internet and VPC
                /// *   **5**: VPC
                /// </summary>
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public int? DeployType { get; set; }

                /// <summary>
                /// The disk size. Unit: GB.
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// The disk type. Valid values:
                /// 
                /// *   **0**: ultra disk
                /// *   **1**: standard SSD
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public int? DiskType { get; set; }

                /// <summary>
                /// The default endpoint of the instance in domain name mode. ApsaraMQ for Kafka instances support endpoints in domain name mode and IP address mode.
                /// 
                /// *   Endpoints in domain name mode: An endpoint in this mode consists of the domain name of the instance and a port number. The format of an endpoint in this mode is `{Instance domain name}:{Port number}`.
                /// *   Endpoints in IP address mode: An endpoint in this mode consists of the IP address of the broker and a port number. The format of an endpoint in this mode is `{Broker IP address}:{Port number}`.
                /// </summary>
                [NameInMap("DomainEndpoint")]
                [Validation(Required=false)]
                public string DomainEndpoint { get; set; }

                /// <summary>
                /// The peak Internet traffic allowed for the instance.
                /// </summary>
                [NameInMap("EipMax")]
                [Validation(Required=false)]
                public int? EipMax { get; set; }

                /// <summary>
                /// The default endpoint of the instance in IP address mode. ApsaraMQ for Kafka instances support endpoints in domain name mode and IP address mode.
                /// 
                /// *   Endpoints in domain name mode: An endpoint in this mode consists of the domain name of the instance and a port number. The format of an endpoint in this mode is `{Instance domain name}:{Port number}`.
                /// *   Endpoints in IP address mode: An endpoint in this mode consists of the IP address of the broker and a port number. The format of an endpoint in this mode is `{Broker IP address}:{Port number}`.
                /// </summary>
                [NameInMap("EndPoint")]
                [Validation(Required=false)]
                public string EndPoint { get; set; }

                /// <summary>
                /// The time when the instance expires. Unit: milliseconds.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public long? ExpiredTime { get; set; }

                /// <summary>
                /// The instance ID.
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

                /// <summary>
                /// The traffic specification.
                /// </summary>
                [NameInMap("IoMaxSpec")]
                [Validation(Required=false)]
                public string IoMaxSpec { get; set; }

                /// <summary>
                /// The ID of the key that is used for disk encryption in the region where the instance is deployed.
                /// </summary>
                [NameInMap("KmsKeyId")]
                [Validation(Required=false)]
                public string KmsKeyId { get; set; }

                /// <summary>
                /// The retention period of messages in the instance. Unit: hours.
                /// </summary>
                [NameInMap("MsgRetain")]
                [Validation(Required=false)]
                public int? MsgRetain { get; set; }

                /// <summary>
                /// The instance name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The billing method of the instance. Valid values:
                /// 
                /// *   **0**: subscription
                /// *   **1**: pay-as-you-go
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

                [NameInMap("ReservedPublishCapacity")]
                [Validation(Required=false)]
                public int? ReservedPublishCapacity { get; set; }

                [NameInMap("ReservedSubscribeCapacity")]
                [Validation(Required=false)]
                public int? ReservedSubscribeCapacity { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The Simple Authentication and Security Layer (SASL) endpoint of the instance in domain name mode. ApsaraMQ for Kafka instances support endpoints in domain name mode and IP address mode.
                /// 
                /// *   Endpoints in domain name mode: An endpoint in this mode consists of the domain name of the instance and a port number. The format of an endpoint in this mode is `{Instance domain name}:{Port number}`.
                /// *   Endpoints in IP address mode: An endpoint in this mode consists of the IP address of the broker and a port number. The format of an endpoint in this mode is `{Broker IP address}:{Port number}`.
                /// </summary>
                [NameInMap("SaslDomainEndpoint")]
                [Validation(Required=false)]
                public string SaslDomainEndpoint { get; set; }

                /// <summary>
                /// The security group of the instance.
                /// 
                /// *   If the instance is deployed by using the ApsaraMQ for Kafka console or calling the [StartInstance](~~157786~~) operation without a security group configured, no value is returned.
                /// *   If the instance is deployed by calling the [StartInstance](~~157786~~) operation with a security group configured, the returned value is the configured security group.
                /// </summary>
                [NameInMap("SecurityGroup")]
                [Validation(Required=false)]
                public string SecurityGroup { get; set; }

                /// <summary>
                /// The instance status. Valid values:
                /// 
                /// *   **0**: pending
                /// *   **1**: preparing hardware resources
                /// *   **2**: initializing
                /// *   **3**: starting
                /// *   **5**: running
                /// *   **6**: migrating
                /// *   **7**: ready for upgrade
                /// *   **8**: upgrading
                /// *   **9**: ready for changes
                /// *   **10**: released
                /// *   **11**: changing
                /// *   **15**: expired
                /// </summary>
                [NameInMap("ServiceStatus")]
                [Validation(Required=false)]
                public int? ServiceStatus { get; set; }

                /// <summary>
                /// The instance edition. Valid values:
                /// 
                /// *   **professional**: Professional Edition (High Write)
                /// *   **professionalForHighRead**: Professional Edition (High Read)
                /// *   **normal**: Standard Edition
                /// </summary>
                [NameInMap("SpecType")]
                [Validation(Required=false)]
                public string SpecType { get; set; }

                /// <summary>
                /// The SSL endpoint of the instance in domain name mode. ApsaraMQ for Kafka instances support endpoints in domain name mode and IP address mode.
                /// 
                /// *   Endpoints in domain name mode: An endpoint in this mode consists of the domain name of the instance and a port number. The format of an endpoint in this mode is `{Instance domain name}:{Port number}`.
                /// *   Endpoints in IP address mode: An endpoint in this mode consists of the IP address of the broker and a port number. The format of an endpoint in this mode is `{Broker IP address}:{Port number}`.
                /// </summary>
                [NameInMap("SslDomainEndpoint")]
                [Validation(Required=false)]
                public string SslDomainEndpoint { get; set; }

                /// <summary>
                /// The Secure Sockets Layer (SSL) endpoint of the instance in IP address mode. ApsaraMQ for Kafka instances support endpoints in domain name mode and IP address mode.
                /// 
                /// *   Endpoints in domain name mode: An endpoint in this mode consists of the domain name of the instance and a port number. The format of an endpoint in this mode is `{Instance domain name}:{Port number}`.
                /// *   Endpoints in IP address mode: An endpoint in this mode consists of the IP address of the broker and a port number. The format of an endpoint in this mode is `{Broker IP address}:{Port number}`.
                /// </summary>
                [NameInMap("SslEndPoint")]
                [Validation(Required=false)]
                public string SslEndPoint { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("StandardZoneId")]
                [Validation(Required=false)]
                public string StandardZoneId { get; set; }

                /// <summary>
                /// The tags.
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

                }

                /// <summary>
                /// The maximum number of topics on the instance.
                /// </summary>
                [NameInMap("TopicNumLimit")]
                [Validation(Required=false)]
                public int? TopicNumLimit { get; set; }

                /// <summary>
                /// The upgrade information of the instance.
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
                /// The vSwitch ID of the instance.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("ViewInstanceStatusCode")]
                [Validation(Required=false)]
                public int? ViewInstanceStatusCode { get; set; }

                /// <summary>
                /// The virtual private cloud (VPC) ID.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone ID.
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
