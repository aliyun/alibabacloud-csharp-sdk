// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeCollectorResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeCollectorResponseBodyResult Result { get; set; }
        public class DescribeCollectorResponseBodyResult : TeaModel {
            [NameInMap("collectorPaths")]
            [Validation(Required=false)]
            public List<string> CollectorPaths { get; set; }

            /// <summary>
            /// <para>The information about the configuration file of the shipper.</para>
            /// </summary>
            [NameInMap("configs")]
            [Validation(Required=false)]
            public List<DescribeCollectorResponseBodyResultConfigs> Configs { get; set; }
            public class DescribeCollectorResponseBodyResultConfigs : TeaModel {
                /// <summary>
                /// <para>The content of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fileBeat.inputs:xxx</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>filebeat.yml</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether a dry run is performed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("dryRun")]
            [Validation(Required=false)]
            public bool? DryRun { get; set; }

            /// <summary>
            /// <para>The extended configurations of the shipper.</para>
            /// </summary>
            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<DescribeCollectorResponseBodyResultExtendConfigs> ExtendConfigs { get; set; }
            public class DescribeCollectorResponseBodyResultExtendConfigs : TeaModel {
                /// <summary>
                /// <para>The configuration type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>collectorTargetInstance</description></item>
                /// <item><description>collectorDeployMachine</description></item>
                /// <item><description>collectorElasticsearchForKibana</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>collectorDeployMachine</para>
                /// </summary>
                [NameInMap("configType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

                /// <summary>
                /// <para>Indicates whether monitoring is enabled. This parameter is returned if the value of <b>configType</b> is <b>collectorTargetInstance</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableMonitoring")]
                [Validation(Required=false)]
                public bool? EnableMonitoring { get; set; }

                /// <summary>
                /// <para>The ID of the machine group. This parameter is returned if the value of <b>configType</b> is <b>collectorDeployMachine</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default_ct-cn-5i2l75bz4776****</para>
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The private endpoint of Kibana after you enable the Kibana dashboard. This parameter is returned if the value of <b>configType</b> is <b>collectorElasticsearchForKibana</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>es-cn-n6w1o1x0w001c****-kibana.internal.elasticsearch.aliyuncs.com:5601</para>
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("hosts")]
                [Validation(Required=false)]
                public List<string> Hosts { get; set; }

                /// <summary>
                /// <para>The ID of the resource that is associated with the shipper. If the value of <b>configType</b> is <b>collectorTargetInstance</b>, the value of this parameter is the ID of the resource specified in the output configuration part of the shipper. If the value of <b>configType</b> is <b>collectorDeployMachines</b> and the value of <b>type</b> is <b>ACKCluster</b>, the value of this parameter is the ID of the ACK cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>es-cn-n6w1o1****</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The type of the cluster specified in the output configuration part of the shipper. Valid values: elasticsearch and logstash. This parameter is returned if the value of <b>configType</b> is <b>collectorTargetInstance</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch</para>
                /// </summary>
                [NameInMap("instanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The public endpoint of Kibana after you enable the Kibana dashboard. This parameter is returned if the value of <b>configType</b> is <b>collectorElasticsearchForKibana</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://es-cn-nif1z89fz003i****.kibana.elasticsearch.aliyuncs.com:5601">https://es-cn-nif1z89fz003i****.kibana.elasticsearch.aliyuncs.com:5601</a></para>
                /// </summary>
                [NameInMap("kibanaHost")]
                [Validation(Required=false)]
                public string KibanaHost { get; set; }

                /// <summary>
                /// <para>The information about the Elastic Compute Service (ECS) instances on which the shipper is deployed. This parameter is returned if the value of <b>configType</b> is <b>collectorDeployMachines</b> and the value of <b>type</b> is <b>ECSInstanceId</b>.</para>
                /// </summary>
                [NameInMap("machines")]
                [Validation(Required=false)]
                public List<DescribeCollectorResponseBodyResultExtendConfigsMachines> Machines { get; set; }
                public class DescribeCollectorResponseBodyResultExtendConfigsMachines : TeaModel {
                    /// <summary>
                    /// <para>The status of the shipper on the ECS instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>heartOk: The heartbeat is normal.</description></item>
                    /// <item><description>heartLost: The heartbeat is abnormal.</description></item>
                    /// <item><description>uninstalled: The shipper is not installed.</description></item>
                    /// <item><description>failed: The shipper fails to be installed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>heartOk</para>
                    /// </summary>
                    [NameInMap("agentStatus")]
                    [Validation(Required=false)]
                    public string AgentStatus { get; set; }

                    /// <summary>
                    /// <para>The IDs of the ECS instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-bp1gyhphjaj73jsr****</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

                /// <summary>
                /// <para>The transmission protocol, which must be the same as the access protocol of the resource specified in the output configuration part of the shipper. Valid values: HTTP and HTTPS. This parameter is returned if the value of <b>configType</b> is <b>collectorTargetInstance</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The number of pods from which data is succcessfully collected in the Container Service for Kubernetes (ACK) cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("successPodsCount")]
                [Validation(Required=false)]
                public string SuccessPodsCount { get; set; }

                /// <summary>
                /// <para>The total number of pods from which data is collected in the ACK cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("totalPodsCount")]
                [Validation(Required=false)]
                public string TotalPodsCount { get; set; }

                /// <summary>
                /// <para>The type of the machine on which the shipper is deployed. This parameter is returned if the value of <b>configType</b> is <b>collectorDeployMachine</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ECSInstanceId</description></item>
                /// <item><description>ACKCluster</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ECSInstanceId</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The username that is used to access the resource specified in the output configuration part of the shipper. The default value is elastic. This parameter is returned if the value of <b>configType</b> is <b>collectorTargetInstance</b> or <b>collectorElasticsearchForKibana</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elastic</para>
                /// </summary>
                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The time when the shipper was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-20T07:26:47.000+0000</para>
            /// </summary>
            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }

            /// <summary>
            /// <para>The time when the shipper was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-20T07:26:47.000+0000</para>
            /// </summary>
            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }

            /// <summary>
            /// <para>The name of the shipper.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ct-cn-4135is2tj194p****</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16852099488*****</para>
            /// </summary>
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The ID of the shipper.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ct-cn-rg31ahn82m0qd****</para>
            /// </summary>
            [NameInMap("resId")]
            [Validation(Required=false)]
            public string ResId { get; set; }

            /// <summary>
            /// <para>The type of the shipper. Valid values: fileBeat, metricBeat, heartBeat, and auditBeat.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fileBeat</para>
            /// </summary>
            [NameInMap("resType")]
            [Validation(Required=false)]
            public string ResType { get; set; }

            /// <summary>
            /// <para>The version of the shipper.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6.8.5_with_community</para>
            /// </summary>
            [NameInMap("resVersion")]
            [Validation(Required=false)]
            public string ResVersion { get; set; }

            /// <summary>
            /// <para>The status of the shipper. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>activating</description></item>
            /// <item><description>active</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) where the shipper resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp16k1dvzxtma*****</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
