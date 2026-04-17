// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned. The HTTP status code 200 indicates that the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public GetInstanceListResponseBodyInstanceList InstanceList { get; set; }
        public class GetInstanceListResponseBodyInstanceList : TeaModel {
            [NameInMap("InstanceVO")]
            [Validation(Required=false)]
            public List<GetInstanceListResponseBodyInstanceListInstanceVO> InstanceVO { get; set; }
            public class GetInstanceListResponseBodyInstanceListInstanceVO : TeaModel {
                [NameInMap("AllConfig")]
                [Validation(Required=false)]
                public string AllConfig { get; set; }

                [NameInMap("AutoCreateGroupEnable")]
                [Validation(Required=false)]
                public bool? AutoCreateGroupEnable { get; set; }

                [NameInMap("AutoCreateTopicEnable")]
                [Validation(Required=false)]
                public bool? AutoCreateTopicEnable { get; set; }

                [NameInMap("BackupZoneId")]
                [Validation(Required=false)]
                public string BackupZoneId { get; set; }

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

                    [NameInMap("KsqlList")]
                    [Validation(Required=false)]
                    public GetInstanceListResponseBodyInstanceListInstanceVOConfluentConfigKsqlList KsqlList { get; set; }
                    public class GetInstanceListResponseBodyInstanceListInstanceVOConfluentConfigKsqlList : TeaModel {
                        [NameInMap("ConfluentInstanceComponentResourceVO")]
                        [Validation(Required=false)]
                        public List<GetInstanceListResponseBodyInstanceListInstanceVOConfluentConfigKsqlListConfluentInstanceComponentResourceVO> ConfluentInstanceComponentResourceVO { get; set; }
                        public class GetInstanceListResponseBodyInstanceListInstanceVOConfluentConfigKsqlListConfluentInstanceComponentResourceVO : TeaModel {
                            [NameInMap("Cu")]
                            [Validation(Required=false)]
                            public int? Cu { get; set; }

                            [NameInMap("InternalId")]
                            [Validation(Required=false)]
                            public string InternalId { get; set; }

                            [NameInMap("Replica")]
                            [Validation(Required=false)]
                            public int? Replica { get; set; }

                            [NameInMap("Storage")]
                            [Validation(Required=false)]
                            public int? Storage { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

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

                [NameInMap("ConfluentInstanceComponents")]
                [Validation(Required=false)]
                public GetInstanceListResponseBodyInstanceListInstanceVOConfluentInstanceComponents ConfluentInstanceComponents { get; set; }
                public class GetInstanceListResponseBodyInstanceListInstanceVOConfluentInstanceComponents : TeaModel {
                    [NameInMap("ConfluentInstanceComponentVO")]
                    [Validation(Required=false)]
                    public List<GetInstanceListResponseBodyInstanceListInstanceVOConfluentInstanceComponentsConfluentInstanceComponentVO> ConfluentInstanceComponentVO { get; set; }
                    public class GetInstanceListResponseBodyInstanceListInstanceVOConfluentInstanceComponentsConfluentInstanceComponentVO : TeaModel {
                        [NameInMap("ComponentType")]
                        [Validation(Required=false)]
                        public string ComponentType { get; set; }

                        [NameInMap("DeployModule")]
                        [Validation(Required=false)]
                        public string DeployModule { get; set; }

                        [NameInMap("PubEndpoint")]
                        [Validation(Required=false)]
                        public string PubEndpoint { get; set; }

                        [NameInMap("VpcEndpoint")]
                        [Validation(Required=false)]
                        public string VpcEndpoint { get; set; }

                        [NameInMap("internalId")]
                        [Validation(Required=false)]
                        public string InternalId { get; set; }

                    }

                }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DefaultPartitionNum")]
                [Validation(Required=false)]
                public int? DefaultPartitionNum { get; set; }

                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public int? DeployType { get; set; }

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public int? DiskType { get; set; }

                [NameInMap("DomainEndpoint")]
                [Validation(Required=false)]
                public string DomainEndpoint { get; set; }

                [NameInMap("EipMax")]
                [Validation(Required=false)]
                public int? EipMax { get; set; }

                [NameInMap("EndPoint")]
                [Validation(Required=false)]
                public string EndPoint { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public long? ExpiredTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("IoMax")]
                [Validation(Required=false)]
                public int? IoMax { get; set; }

                [NameInMap("IoMaxRead")]
                [Validation(Required=false)]
                public int? IoMaxRead { get; set; }

                [NameInMap("IoMaxSpec")]
                [Validation(Required=false)]
                public string IoMaxSpec { get; set; }

                [NameInMap("IoMaxWrite")]
                [Validation(Required=false)]
                public int? IoMaxWrite { get; set; }

                [NameInMap("KmsKeyId")]
                [Validation(Required=false)]
                public string KmsKeyId { get; set; }

                [NameInMap("MsgRetain")]
                [Validation(Required=false)]
                public int? MsgRetain { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PaidType")]
                [Validation(Required=false)]
                public int? PaidType { get; set; }

                [NameInMap("RecommendedPartitionCount")]
                [Validation(Required=false)]
                public int? RecommendedPartitionCount { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ReservedPublishCapacity")]
                [Validation(Required=false)]
                public int? ReservedPublishCapacity { get; set; }

                [NameInMap("ReservedSubscribeCapacity")]
                [Validation(Required=false)]
                public int? ReservedSubscribeCapacity { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SaslDomainEndpoint")]
                [Validation(Required=false)]
                public string SaslDomainEndpoint { get; set; }

                [NameInMap("SaslEndPoint")]
                [Validation(Required=false)]
                public string SaslEndPoint { get; set; }

                [NameInMap("ScheduledRetirement")]
                [Validation(Required=false)]
                public bool? ScheduledRetirement { get; set; }

                [NameInMap("SecurityGroup")]
                [Validation(Required=false)]
                public string SecurityGroup { get; set; }

                [NameInMap("Series")]
                [Validation(Required=false)]
                public string Series { get; set; }

                [NameInMap("ServiceStatus")]
                [Validation(Required=false)]
                public int? ServiceStatus { get; set; }

                [NameInMap("SpecType")]
                [Validation(Required=false)]
                public string SpecType { get; set; }

                [NameInMap("SslDomainEndpoint")]
                [Validation(Required=false)]
                public string SslDomainEndpoint { get; set; }

                [NameInMap("SslEndPoint")]
                [Validation(Required=false)]
                public string SslEndPoint { get; set; }

                [NameInMap("StandardZoneId")]
                [Validation(Required=false)]
                public string StandardZoneId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public GetInstanceListResponseBodyInstanceListInstanceVOTags Tags { get; set; }
                public class GetInstanceListResponseBodyInstanceListInstanceVOTags : TeaModel {
                    [NameInMap("TagVO")]
                    [Validation(Required=false)]
                    public List<GetInstanceListResponseBodyInstanceListInstanceVOTagsTagVO> TagVO { get; set; }
                    public class GetInstanceListResponseBodyInstanceListInstanceVOTagsTagVO : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("TopicNumLimit")]
                [Validation(Required=false)]
                public int? TopicNumLimit { get; set; }

                [NameInMap("UpgradeServiceDetailInfo")]
                [Validation(Required=false)]
                public GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfo UpgradeServiceDetailInfo { get; set; }
                public class GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfo : TeaModel {
                    [NameInMap("Current2OpenSourceVersion")]
                    [Validation(Required=false)]
                    public string Current2OpenSourceVersion { get; set; }

                }

                [NameInMap("UsedGroupCount")]
                [Validation(Required=false)]
                public int? UsedGroupCount { get; set; }

                [NameInMap("UsedPartitionCount")]
                [Validation(Required=false)]
                public int? UsedPartitionCount { get; set; }

                [NameInMap("UsedTopicCount")]
                [Validation(Required=false)]
                public int? UsedTopicCount { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public GetInstanceListResponseBodyInstanceListInstanceVOVSwitchIds VSwitchIds { get; set; }
                public class GetInstanceListResponseBodyInstanceListInstanceVOVSwitchIds : TeaModel {
                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public List<string> VSwitchIds { get; set; }

                }

                [NameInMap("ViewInstanceStatusCode")]
                [Validation(Required=false)]
                public int? ViewInstanceStatusCode { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcSaslDomainEndpoint")]
                [Validation(Required=false)]
                public string VpcSaslDomainEndpoint { get; set; }

                [NameInMap("VpcSaslEndPoint")]
                [Validation(Required=false)]
                public string VpcSaslEndPoint { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B6D821D-7F67-4CAA-9E13-A5A997C3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
