// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateCollectorNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
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
        public UpdateCollectorNameResponseBodyResult Result { get; set; }
        public class UpdateCollectorNameResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The collection path of Filebeat. This parameter is displayed when the collector is deployed on an ECS instance.</para>
            /// </summary>
            [NameInMap("collectorPaths")]
            [Validation(Required=false)]
            public List<string> CollectorPaths { get; set; }

            /// <summary>
            /// <para>The configuration file information of the collector.</para>
            /// </summary>
            [NameInMap("configs")]
            [Validation(Required=false)]
            public List<UpdateCollectorNameResponseBodyResultConfigs> Configs { get; set; }
            public class UpdateCollectorNameResponseBodyResultConfigs : TeaModel {
                /// <summary>
                /// <para>The content of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description>key: log\n title: Log file content\n description: &gt;\n Contains log file lines.\n ....</description></item>
                /// </list>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fields.yml</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to verify and update the collector. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: only verifies the request without updating the collector.</description></item>
            /// <item><description>false: verifies and updates the collector.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("dryRun")]
            [Validation(Required=false)]
            public bool? DryRun { get; set; }

            /// <summary>
            /// <para>The extended configurations of the collector.</para>
            /// </summary>
            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<UpdateCollectorNameResponseBodyResultExtendConfigs> ExtendConfigs { get; set; }
            public class UpdateCollectorNameResponseBodyResultExtendConfigs : TeaModel {
                /// <summary>
                /// <para>The configuration type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>collectorTargetInstance: the output of the collector</description></item>
                /// <item><description>collectorDeployMachine: the machine where the collector is deployed</description></item>
                /// <item><description>collectorElasticsearchForKibana: the information about the Elasticsearch instance that supports Kibana Dashboard</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>collectorDeployMachine</para>
                /// </summary>
                [NameInMap("configType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable monitoring. This parameter is displayed when <b>configType</b> is set to <b>collectorTargetInstance</b> and <b>instanceType</b> is set to <b>elasticsearch</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: enables monitoring.</description></item>
                /// <item><description>false: disables monitoring.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableMonitoring")]
                [Validation(Required=false)]
                public bool? EnableMonitoring { get; set; }

                /// <summary>
                /// <para>The ID of the machine group. This parameter is displayed when <b>configType</b> is set to <b>collectorDeployMachine</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default_ct-cn-5i2l75bz4776****</para>
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The internal-facing access address of Kibana on the private network after Kibana Dashboard is enabled. This parameter is displayed when <b>configType</b> is set to <b>collectorElasticsearchForKibana</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>es-cn-4591jumei000u****-kibana.internal.elasticsearch.aliyuncs.com:5601</para>
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The access endpoints of the instance specified by the collector output. This parameter is displayed when <b>configType</b> is set to <b>collectorTargetInstance</b>.</para>
                /// </summary>
                [NameInMap("hosts")]
                [Validation(Required=false)]
                public List<string> Hosts { get; set; }

                /// <summary>
                /// <para>Instance ID of the instance associated with the collector. If <b>configType</b> is set to <b>collectorTargetInstance</b>, this parameter indicates instance ID of the instance specified by the collector output. If <b>configType</b> is set to <b>collectorDeployMachines</b> and <b>type</b> is set to <b>ACKCluster</b>, this parameter indicates instance ID of the ACK cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>es-cn-n6w1o1****</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The type of the instance specified by the collector output. Valid values: elasticsearch and logstash. This parameter is displayed when <b>configType</b> is set to <b>collectorTargetInstance</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch</para>
                /// </summary>
                [NameInMap("instanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The public network access address of Kibana after Kibana Dashboard is enabled. This parameter is displayed when <b>configType</b> is set to <b>collectorElasticsearchForKibana</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://es-cn-4591jumei000u****.kibana.elasticsearch.aliyuncs.com:5601">https://es-cn-4591jumei000u****.kibana.elasticsearch.aliyuncs.com:5601</a></para>
                /// </summary>
                [NameInMap("kibanaHost")]
                [Validation(Required=false)]
                public string KibanaHost { get; set; }

                /// <summary>
                /// <para>The information about the ECS instances where the collector is deployed. This parameter is displayed when <b>configType</b> is set to <b>collectorDeployMachines</b> and <b>type</b> is set to <b>ECSInstanceId</b>.</para>
                /// </summary>
                [NameInMap("machines")]
                [Validation(Required=false)]
                public List<UpdateCollectorNameResponseBodyResultExtendConfigsMachines> Machines { get; set; }
                public class UpdateCollectorNameResponseBodyResultExtendConfigsMachines : TeaModel {
                    /// <summary>
                    /// <para>The status of each collector on the ECS instance. Valid values: <b>heartOk</b> (heartbeat normal), <b>heartLost</b> (heartbeat abnormal), <b>uninstalled</b> (not installed), and <b>failed</b> (installation failed).</para>
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
                    /// <para>c1b9fde5172b84f82b9928e825a7b8988</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

                /// <summary>
                /// <para>The transmission protocol. Valid values: <b>HTTP</b> and <b>HTTPS</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The number of pods from which data is successfully collected in the ACK cluster. This parameter is displayed when <b>configType</b> is set to <b>collectorDeployMachines</b> and <b>type</b> is set to <b>ACKCluster</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("successPodsCount")]
                [Validation(Required=false)]
                public string SuccessPodsCount { get; set; }

                /// <summary>
                /// <para>The total number of pods from which data is collected in the ACK cluster. This parameter is displayed when <b>configType</b> is set to <b>collectorDeployMachines</b> and <b>type</b> is set to <b>ACKCluster</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("totalPodsCount")]
                [Validation(Required=false)]
                public string TotalPodsCount { get; set; }

                /// <summary>
                /// <para>The type of the machine where the collector is deployed. This parameter is displayed when <b>configType</b> is set to <b>collectorDeployMachine</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ECSInstanceId: ECS instance</description></item>
                /// <item><description>ACKCluster: Container Service for Kubernetes (ACK) cluster</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ECSInstanceId</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The username used to access the instance specified by the collector output. Default value: elastic. This parameter is displayed when <b>configType</b> is set to <b>collectorTargetInstance</b> or <b>collectorElasticsearchForKibana</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elastic</para>
                /// </summary>
                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The time when the collector was created. The time is in the YYYY-MM-DDTHH:mm:ss.SSS+HHMM format, where the suffix indicates the time zone offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-20T07:26:47.000+0000</para>
            /// </summary>
            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }

            /// <summary>
            /// <para>The time when the collector was updated. The time is in the YYYY-MM-DDTHH:mm:ss.SSS+HHMM format, where the suffix indicates the time zone offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-20T07:26:47.000+0000</para>
            /// </summary>
            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }

            /// <summary>
            /// <para>The name of the collector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ct-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16852099488*****</para>
            /// </summary>
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The instance ID of the collector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ct-cn-77uqof2s7rg5c****</para>
            /// </summary>
            [NameInMap("resId")]
            [Validation(Required=false)]
            public string ResId { get; set; }

            /// <summary>
            /// <para>The type of the collector. Valid values: fileBeat, metricBeat, heartBeat, and audiBeat.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fileBeat</para>
            /// </summary>
            [NameInMap("resType")]
            [Validation(Required=false)]
            public string ResType { get; set; }

            /// <summary>
            /// <para>The version of the collector. The supported versions vary based on the type of the machine where the collector is deployed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ECS: 6.8.5_with_community</description></item>
            /// <item><description>ACK: 6.8.13_with_community</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>6.8.5_with_community</para>
            /// </summary>
            [NameInMap("resVersion")]
            [Validation(Required=false)]
            public string ResVersion { get; set; }

            /// <summary>
            /// <para>The status of the collector. Valid values: activing (activating) and active (activated).</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) where the collector resides.</para>
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
