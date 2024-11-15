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

        /// <summary>
        /// <para>The instances.</para>
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
                /// <para>The configurations of the deployed ApsaraMQ for Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;enable.vpc_sasl_ssl\&quot;:\&quot;false\&quot;,\&quot;kafka.log.retention.hours\&quot;:\&quot;66\&quot;,\&quot;enable.acl\&quot;:\&quot;false\&quot;,\&quot;kafka.message.max.bytes\&quot;:\&quot;6291456\&quot;}</para>
                /// </summary>
                [NameInMap("AllConfig")]
                [Validation(Required=false)]
                public string AllConfig { get; set; }

                [NameInMap("AutoCreateGroupEnable")]
                [Validation(Required=false)]
                public bool? AutoCreateGroupEnable { get; set; }

                [NameInMap("AutoCreateTopicEnable")]
                [Validation(Required=false)]
                public bool? AutoCreateTopicEnable { get; set; }

                /// <summary>
                /// <para>The parameters that are returned for the ApsaraMQ for Confluent instance.</para>
                /// </summary>
                [NameInMap("ConfluentConfig")]
                [Validation(Required=false)]
                public GetInstanceListResponseBodyInstanceListInstanceVOConfluentConfig ConfluentConfig { get; set; }
                public class GetInstanceListResponseBodyInstanceListInstanceVOConfluentConfig : TeaModel {
                    /// <summary>
                    /// <para>The number of CPU cores of Connect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("ConnectCU")]
                    [Validation(Required=false)]
                    public int? ConnectCU { get; set; }

                    /// <summary>
                    /// <para>The number of replicas of Connect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("ConnectReplica")]
                    [Validation(Required=false)]
                    public int? ConnectReplica { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores of Control Center.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("ControlCenterCU")]
                    [Validation(Required=false)]
                    public int? ControlCenterCU { get; set; }

                    /// <summary>
                    /// <para>The number of replicas of Control Center.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ControlCenterReplica")]
                    [Validation(Required=false)]
                    public int? ControlCenterReplica { get; set; }

                    /// <summary>
                    /// <para>The disk capacity of Control Center. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("ControlCenterStorage")]
                    [Validation(Required=false)]
                    public int? ControlCenterStorage { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores of the Kafka broker.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("KafkaCU")]
                    [Validation(Required=false)]
                    public int? KafkaCU { get; set; }

                    /// <summary>
                    /// <para>The number of replicas of the Kafka broker.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("KafkaReplica")]
                    [Validation(Required=false)]
                    public int? KafkaReplica { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores of Kafka Rest Proxy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("KafkaRestProxyCU")]
                    [Validation(Required=false)]
                    public int? KafkaRestProxyCU { get; set; }

                    /// <summary>
                    /// <para>The number of replicas of Kafka Rest Proxy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("KafkaRestProxyReplica")]
                    [Validation(Required=false)]
                    public int? KafkaRestProxyReplica { get; set; }

                    /// <summary>
                    /// <para>The disk capacity of the Kafka broker. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>800</para>
                    /// </summary>
                    [NameInMap("KafkaStorage")]
                    [Validation(Required=false)]
                    public int? KafkaStorage { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores of ksqlDB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("KsqlCU")]
                    [Validation(Required=false)]
                    public int? KsqlCU { get; set; }

                    /// <summary>
                    /// <para>The number of replicas of ksqlDB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("KsqlReplica")]
                    [Validation(Required=false)]
                    public int? KsqlReplica { get; set; }

                    /// <summary>
                    /// <para>The disk capacity of ksqlDB. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("KsqlStorage")]
                    [Validation(Required=false)]
                    public int? KsqlStorage { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores of Schema Registry.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("SchemaRegistryCU")]
                    [Validation(Required=false)]
                    public int? SchemaRegistryCU { get; set; }

                    /// <summary>
                    /// <para>The number of replicas of Schema Registry.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("SchemaRegistryReplica")]
                    [Validation(Required=false)]
                    public int? SchemaRegistryReplica { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores of ZooKeeper.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("ZooKeeperCU")]
                    [Validation(Required=false)]
                    public int? ZooKeeperCU { get; set; }

                    /// <summary>
                    /// <para>The number of replicas of ZooKeeper.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("ZooKeeperReplica")]
                    [Validation(Required=false)]
                    public int? ZooKeeperReplica { get; set; }

                    /// <summary>
                    /// <para>The disk capacity of ZooKeeper. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("ZooKeeperStorage")]
                    [Validation(Required=false)]
                    public int? ZooKeeperStorage { get; set; }

                }

                /// <summary>
                /// <para>The time when the instance was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1577961819000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DefaultPartitionNum")]
                [Validation(Required=false)]
                public int? DefaultPartitionNum { get; set; }

                /// <summary>
                /// <para>The type of the network in which the instance is deployed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>4</b>: Internet and VPC</description></item>
                /// <item><description><b>5</b>: VPC</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public int? DeployType { get; set; }

                /// <summary>
                /// <para>The disk size. Unit: GB</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// <para>The disk type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: ultra disk</description></item>
                /// <item><description><b>1</b>: standard SSD</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public int? DiskType { get; set; }

                /// <summary>
                /// <para>The default endpoint of the instance in domain name mode. ApsaraMQ for Kafka instances support endpoints in domain name mode and IP address mode.</para>
                /// <list type="bullet">
                /// <item><description>Endpoints in domain name mode: An endpoint in this mode consists of the domain name of the instance and a port number. The format of an endpoint in this mode is <c>{Instance domain name}:{Port number}</c>.</description></item>
                /// <item><description>Endpoints in IP address mode: An endpoint in this mode consists of the IP address of the broker and a port number. The format of an endpoint in this mode is <c>{Broker IP address}:{Port number}</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>alikafka-pre-cn-zv**********-1-vpc.alikafka.aliyuncs.com:9092,alikafka-pre-cn-zv**********-2-vpc.alikafka.aliyuncs.com:9092,alikafka-pre-cn-zv**********-3-vpc.alikafka.aliyuncs.com:9092</para>
                /// </summary>
                [NameInMap("DomainEndpoint")]
                [Validation(Required=false)]
                public string DomainEndpoint { get; set; }

                /// <summary>
                /// <para>The maximum Internet traffic in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("EipMax")]
                [Validation(Required=false)]
                public int? EipMax { get; set; }

                /// <summary>
                /// <para>The default endpoint of the instance in IP address mode. ApsaraMQ for Kafka instances support endpoints in domain name mode and IP address mode.</para>
                /// <list type="bullet">
                /// <item><description>Endpoints in domain name mode: An endpoint in this mode consists of the domain name of the instance and a port number. The format of an endpoint in this mode is <c>{Instance domain name}:{Port number}</c>.</description></item>
                /// <item><description>Endpoints in IP address mode: An endpoint in this mode consists of the IP address of the broker and a port number. The format of an endpoint in this mode is <c>{Broker IP address}:{Port number}</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX:9092,192.168.XX.XX:9092,192.168.XX.XX:9092</para>
                /// </summary>
                [NameInMap("EndPoint")]
                [Validation(Required=false)]
                public string EndPoint { get; set; }

                /// <summary>
                /// <para>The time when the instance expires. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1893581018000</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public long? ExpiredTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alikafka_pre-cn-mp919o4v****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The maximum traffic in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("IoMax")]
                [Validation(Required=false)]
                public int? IoMax { get; set; }

                /// <summary>
                /// <para>The maximum read traffic in the instance. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("IoMaxRead")]
                [Validation(Required=false)]
                public int? IoMaxRead { get; set; }

                /// <summary>
                /// <para>The traffic specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alikafka.hw.2xlarge</para>
                /// </summary>
                [NameInMap("IoMaxSpec")]
                [Validation(Required=false)]
                public string IoMaxSpec { get; set; }

                /// <summary>
                /// <para>The maximum write traffic. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("IoMaxWrite")]
                [Validation(Required=false)]
                public int? IoMaxWrite { get; set; }

                /// <summary>
                /// <para>The ID of the key that is used for disk encryption in the region where the instance is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0d24xxxx-da7b-4786-b981-9a164dxxxxxx</para>
                /// </summary>
                [NameInMap("KmsKeyId")]
                [Validation(Required=false)]
                public string KmsKeyId { get; set; }

                /// <summary>
                /// <para>The retention period of messages in the instance. Unit: hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("MsgRetain")]
                [Validation(Required=false)]
                public int? MsgRetain { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alikafka_post-cn-mp91gnw0****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The billing method of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: the subscription billing method</description></item>
                /// <item><description><b>1</b>: the pay-as-you-go billing method</description></item>
                /// <item><description><b>3</b>: the pay-as-you-go billing method for serverless ApsaraMQ for Kafka V3 instances</description></item>
                /// <item><description><b>4</b>: the pay-as-you-go billing method for ApsaraMQ for Confluent instances</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PaidType")]
                [Validation(Required=false)]
                public int? PaidType { get; set; }

                /// <summary>
                /// <para>The ID of the region where the instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The traffic reserved for message publishing. Unit: MB/s.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the instance is a serverless ApsaraMQ for Kafka V3 instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("ReservedPublishCapacity")]
                [Validation(Required=false)]
                public int? ReservedPublishCapacity { get; set; }

                /// <summary>
                /// <para>The traffic reserved for message subscription. Unit: MB/s.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the instance is a serverless ApsaraMQ for Kafka V3 instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("ReservedSubscribeCapacity")]
                [Validation(Required=false)]
                public int? ReservedSubscribeCapacity { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-ac***********7q</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The Simple Authentication and Security Layer (SASL) endpoint of the instance in domain name mode. ApsaraMQ for Kafka instances support endpoints in domain name mode and IP address mode.</para>
                /// <list type="bullet">
                /// <item><description>Endpoints in domain name mode: An endpoint in this mode consists of the domain name of the instance and a port number. The format of an endpoint in this mode is <c>{Instance domain name}:{Port number}</c>.</description></item>
                /// <item><description>Endpoints in IP address mode: An endpoint in this mode consists of the IP address of the broker and a port number. The format of an endpoint in this mode is <c>{Broker IP address}:{Port number}</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>alikafka-pre-cn-zv**********-1-vpc.alikafka.aliyuncs.com:9094,alikafka-pre-cn-zv**********-2-vpc.alikafka.aliyuncs.com:9094,alikafka-pre-cn-zv**********-3-vpc.alikafka.aliyuncs.com:9094</para>
                /// </summary>
                [NameInMap("SaslDomainEndpoint")]
                [Validation(Required=false)]
                public string SaslDomainEndpoint { get; set; }

                /// <summary>
                /// <para>The security group to which the instance belongs.</para>
                /// <list type="bullet">
                /// <item><description>If the instance is deployed in the ApsaraMQ for Kafka console or by calling the <a href="https://help.aliyun.com/document_detail/157786.html">StartInstance</a> operation without a security group configured, no value is returned.</description></item>
                /// <item><description>If the instance is deployed by calling the <a href="https://help.aliyun.com/document_detail/157786.html">StartInstance</a> operation with a security group configured, the returned value is the configured security group.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp13wfx7kz9pkow****</para>
                /// </summary>
                [NameInMap("SecurityGroup")]
                [Validation(Required=false)]
                public string SecurityGroup { get; set; }

                /// <summary>
                /// <para>The instance version. Valid values: v2, v3, and confluent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v3</para>
                /// </summary>
                [NameInMap("Series")]
                [Validation(Required=false)]
                public string Series { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is out of date. We recommend that you refer to the ViewInstanceStatusCode parameter.</para>
                /// </remarks>
                /// <para>The instance status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: pending</description></item>
                /// <item><description><b>1</b>: preparing hardware resources</description></item>
                /// <item><description><b>2</b>: initializing</description></item>
                /// <item><description><b>3</b>: starting</description></item>
                /// <item><description><b>5</b>: running</description></item>
                /// <item><description><b>6</b>: migrating</description></item>
                /// <item><description><b>7</b>: ready for upgrade</description></item>
                /// <item><description><b>8</b>: upgrading</description></item>
                /// <item><description><b>9</b>: ready for change</description></item>
                /// <item><description><b>10</b>: released</description></item>
                /// <item><description><b>11</b>: changing</description></item>
                /// <item><description><b>15</b>: expired</description></item>
                /// <item><description><b>30</b>: scaling</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ServiceStatus")]
                [Validation(Required=false)]
                public int? ServiceStatus { get; set; }

                /// <summary>
                /// <para>The instance edition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>professional</b>: Professional Edition (High Write)</description></item>
                /// <item><description><b>professionalForHighRead</b>: Professional Edition (High Read)</description></item>
                /// <item><description><b>normal</b>: Standard Edition</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>professional</para>
                /// </summary>
                [NameInMap("SpecType")]
                [Validation(Required=false)]
                public string SpecType { get; set; }

                /// <summary>
                /// <para>The SSL endpoint of the instance in domain name mode. ApsaraMQ for Kafka instances support endpoints in domain name mode and IP address mode.</para>
                /// <list type="bullet">
                /// <item><description>Endpoints in domain name mode: An endpoint in this mode consists of the domain name of the instance and a port number. The format of an endpoint in this mode is <c>{Instance domain name}:{Port number}</c>.</description></item>
                /// <item><description>Endpoints in IP address mode: An endpoint in this mode consists of the IP address of the broker and a port number. The format of an endpoint in this mode is <c>{Broker IP address}:{Port number}</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>alikafka-pre-cn-zv**********-1.alikafka.aliyuncs.com:9093,alikafka-pre-cn-zv**********-2.alikafka.aliyuncs.com:9093,alikafka-pre-cn-zv**********-3.alikafka.aliyuncs.com:9093</para>
                /// </summary>
                [NameInMap("SslDomainEndpoint")]
                [Validation(Required=false)]
                public string SslDomainEndpoint { get; set; }

                /// <summary>
                /// <para>The Secure Sockets Layer (SSL) endpoint of the instance in IP address mode. ApsaraMQ for Kafka instances support endpoints in domain name mode and IP address mode.</para>
                /// <list type="bullet">
                /// <item><description>Endpoints in domain name mode: An endpoint in this mode consists of the domain name of the instance and a port number. The format of an endpoint in this mode is <c>{Instance domain name}:{Port number}</c>.</description></item>
                /// <item><description>Endpoints in IP address mode: An endpoint in this mode consists of the IP address of the broker and a port number. The format of an endpoint in this mode is <c>{Broker IP address}:{Port number}</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.XX.XX:9093,198.51.XX.XX:9093,203.0.XX.XX:9093</para>
                /// </summary>
                [NameInMap("SslEndPoint")]
                [Validation(Required=false)]
                public string SslEndPoint { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-k</para>
                /// </summary>
                [NameInMap("StandardZoneId")]
                [Validation(Required=false)]
                public string StandardZoneId { get; set; }

                /// <summary>
                /// <para>The tags.</para>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The maximum number of topics on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("TopicNumLimit")]
                [Validation(Required=false)]
                public int? TopicNumLimit { get; set; }

                /// <summary>
                /// <para>The upgrade information about the instance.</para>
                /// </summary>
                [NameInMap("UpgradeServiceDetailInfo")]
                [Validation(Required=false)]
                public GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfo UpgradeServiceDetailInfo { get; set; }
                public class GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfo : TeaModel {
                    /// <summary>
                    /// <para>The open source Apache Kafka version that corresponds to the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.2.0</para>
                    /// </summary>
                    [NameInMap("Current2OpenSourceVersion")]
                    [Validation(Required=false)]
                    public string Current2OpenSourceVersion { get; set; }

                }

                /// <summary>
                /// <para>The number of used groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("UsedGroupCount")]
                [Validation(Required=false)]
                public int? UsedGroupCount { get; set; }

                /// <summary>
                /// <para>The number of used partitions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("UsedPartitionCount")]
                [Validation(Required=false)]
                public int? UsedPartitionCount { get; set; }

                /// <summary>
                /// <para>The number of used topics.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("UsedTopicCount")]
                [Validation(Required=false)]
                public int? UsedTopicCount { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1fvuw0ljd7vzmo3****</para>
                /// </summary>
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

                /// <summary>
                /// <para>The instance status. The valid values are consistent with the values displayed in the ApsaraMQ for Kafka console. This parameter is used in the new version of ApsaraMQ for Kafka.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: pending</description></item>
                /// <item><description><b>1</b>: deploying</description></item>
                /// <item><description><b>2</b>: running</description></item>
                /// <item><description><b>3</b>: stopped</description></item>
                /// <item><description><b>4</b>: expiring</description></item>
                /// <item><description><b>5</b>: expired</description></item>
                /// <item><description><b>6</b>: released</description></item>
                /// <item><description><b>7</b>: upgrading</description></item>
                /// <item><description><b>8</b>: migrating</description></item>
                /// <item><description><b>21</b>: stopping</description></item>
                /// <item><description><b>22</b>: starting</description></item>
                /// <item><description><b>23</b>: releasing</description></item>
                /// <item><description><b>30</b>: auto scaling</description></item>
                /// <item><description><b>101</b>: deployment failed</description></item>
                /// <item><description><b>102</b>: upgrade failed</description></item>
                /// <item><description><b>103</b>: migration failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ViewInstanceStatusCode")]
                [Validation(Required=false)]
                public int? ViewInstanceStatusCode { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1ojac7bv448nifj****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zonei</para>
                /// </summary>
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
