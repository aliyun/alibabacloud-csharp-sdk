// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreatePrePayInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The Confluent component configurations.</para>
        /// <remarks>
        /// <para>This parameter is required when you create a Confluent instance.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfluentConfig")]
        [Validation(Required=false)]
        public CreatePrePayInstanceRequestConfluentConfig ConfluentConfig { get; set; }
        public class CreatePrePayInstanceRequestConfluentConfig : TeaModel {
            [NameInMap("ConfluentVersion")]
            [Validation(Required=false)]
            public string ConfluentVersion { get; set; }

            /// <summary>
            /// <para>The number of CPU cores for the Connect component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ConnectCU")]
            [Validation(Required=false)]
            public int? ConnectCU { get; set; }

            /// <summary>
            /// <para>The number of Connect component replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ConnectReplica")]
            [Validation(Required=false)]
            public int? ConnectReplica { get; set; }

            /// <summary>
            /// <para>The number of CPU cores for the ControlCenter component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ControlCenterCU")]
            [Validation(Required=false)]
            public int? ControlCenterCU { get; set; }

            /// <summary>
            /// <para>The number of ControlCenter component replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ControlCenterReplica")]
            [Validation(Required=false)]
            public int? ControlCenterReplica { get; set; }

            /// <summary>
            /// <para>The disk capacity of the ControlCenter component. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("ControlCenterStorage")]
            [Validation(Required=false)]
            public int? ControlCenterStorage { get; set; }

            /// <summary>
            /// <para>The number of CPU cores for Kafka Broker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("KafkaCU")]
            [Validation(Required=false)]
            public int? KafkaCU { get; set; }

            /// <summary>
            /// <para>The number of Kafka Broker replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("KafkaReplica")]
            [Validation(Required=false)]
            public int? KafkaReplica { get; set; }

            /// <summary>
            /// <para>The number of CPU cores for the KafkaRestProxy component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("KafkaRestProxyCU")]
            [Validation(Required=false)]
            public int? KafkaRestProxyCU { get; set; }

            /// <summary>
            /// <para>The number of KafkaRestProxy component replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("KafkaRestProxyReplica")]
            [Validation(Required=false)]
            public int? KafkaRestProxyReplica { get; set; }

            /// <summary>
            /// <para>The disk capacity of Kafka Broker. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("KafkaStorage")]
            [Validation(Required=false)]
            public int? KafkaStorage { get; set; }

            [NameInMap("KraftControllerCU")]
            [Validation(Required=false)]
            public int? KraftControllerCU { get; set; }

            [NameInMap("KraftControllerReplica")]
            [Validation(Required=false)]
            public int? KraftControllerReplica { get; set; }

            [NameInMap("KraftControllerStorage")]
            [Validation(Required=false)]
            public int? KraftControllerStorage { get; set; }

            /// <summary>
            /// <para>The number of CPU cores for the KsqlDB component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("KsqlCU")]
            [Validation(Required=false)]
            public int? KsqlCU { get; set; }

            [NameInMap("KsqlList")]
            [Validation(Required=false)]
            public List<CreatePrePayInstanceRequestConfluentConfigKsqlList> KsqlList { get; set; }
            public class CreatePrePayInstanceRequestConfluentConfigKsqlList : TeaModel {
                [NameInMap("InternalId")]
                [Validation(Required=false)]
                public string InternalId { get; set; }

                [NameInMap("cu")]
                [Validation(Required=false)]
                public int? Cu { get; set; }

                [NameInMap("replica")]
                [Validation(Required=false)]
                public int? Replica { get; set; }

                [NameInMap("storage")]
                [Validation(Required=false)]
                public int? Storage { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The number of KsqlDB component replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("KsqlReplica")]
            [Validation(Required=false)]
            public int? KsqlReplica { get; set; }

            /// <summary>
            /// <para>The disk capacity of the KsqlDB component. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("KsqlStorage")]
            [Validation(Required=false)]
            public int? KsqlStorage { get; set; }

            /// <summary>
            /// <para>The number of CPU cores for the SchemaRegistry component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SchemaRegistryCU")]
            [Validation(Required=false)]
            public int? SchemaRegistryCU { get; set; }

            /// <summary>
            /// <para>The number of SchemaRegistry component replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SchemaRegistryReplica")]
            [Validation(Required=false)]
            public int? SchemaRegistryReplica { get; set; }

            /// <summary>
            /// <para>The number of CPU cores for the ZooKeeper component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ZooKeeperCU")]
            [Validation(Required=false)]
            public int? ZooKeeperCU { get; set; }

            /// <summary>
            /// <para>The number of ZooKeeper component replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ZooKeeperReplica")]
            [Validation(Required=false)]
            public int? ZooKeeperReplica { get; set; }

            /// <summary>
            /// <para>The disk capacity of the ZooKeeper component. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ZooKeeperStorage")]
            [Validation(Required=false)]
            public int? ZooKeeperStorage { get; set; }

        }

        /// <summary>
        /// <para>The deployment type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b>: Internet- and VPC-connected instance</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: VPC-connected instance</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When you create a Confluent instance, you cannot select the deployment type. Only the value 5 is allowed. After the purchase, you can configure whether to enable public access for each component.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public int? DeployType { get; set; }

        /// <summary>
        /// <para>The disk capacity. Unit: GB.</para>
        /// <para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para>This parameter is not required when you create a Confluent instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>The disk type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: ultra cloud disk</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: SSD</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not required when you create a Confluent instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The subscription duration. Unit: months. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Confluent instances: 1 or 12</b></description></item>
        /// <item><description><b>ApsaraMQ for Kafka instances: 1</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The Internet traffic.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if <b>DeployType</b> is set to <b>4</b>.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/72142.html">Pay-as-you-go billing method</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not required when you create a Confluent instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// <para>The traffic specification.</para>
        /// <list type="bullet">
        /// <item><description>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.<remarks>
        /// <para>This parameter is not required when you create a Confluent instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka.hw.2xlarge</para>
        /// </summary>
        [NameInMap("IoMaxSpec")]
        [Validation(Required=false)]
        public string IoMaxSpec { get; set; }

        /// <summary>
        /// <para>The billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: subscription</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: Confluent subscription</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PaidType")]
        [Validation(Required=false)]
        public int? PaidType { get; set; }

        /// <summary>
        /// <para>The number of partitions to purchase.</para>
        /// <list type="bullet">
        /// <item><description>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.<remarks>
        /// <para>This parameter is not required when you create a Confluent instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public int? PartitionNum { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>If you do not specify this parameter, the instance is placed in the default resource group. You can view the resource group ID in the Resource Management console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ac***********7q</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The edition type.</para>
        /// <para>Valid values for ApsaraMQ for Kafka instances:</para>
        /// <list type="bullet">
        /// <item><description><para><b>normal</b>: Standard Edition (shared throughput for writes)</para>
        /// </description></item>
        /// <item><description><para><b>professional</b>: Professional Edition (shared throughput for writes)</para>
        /// </description></item>
        /// <item><description><para><b>professionalForHighRead</b>: Professional Edition (shared throughput for reads)</para>
        /// </description></item>
        /// </list>
        /// <para>Valid values for Confluent instances:</para>
        /// <list type="bullet">
        /// <item><description><para><b>professional</b>: Professional Edition</para>
        /// </description></item>
        /// <item><description><para><b>enterprise</b>: Enterprise Edition</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>professional</para>
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePrePayInstanceRequestTag> Tag { get; set; }
        public class CreatePrePayInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <list type="bullet">
            /// <item><description><para>N ranges from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is left empty, all tag keys are matched.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <list type="bullet">
            /// <item><description><para>N ranges from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>This parameter can be left empty.</para>
            /// </description></item>
            /// <item><description><para>The tag value can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
