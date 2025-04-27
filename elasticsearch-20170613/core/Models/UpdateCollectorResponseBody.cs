// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateCollectorResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateCollectorResponseBodyResult Result { get; set; }
        public class UpdateCollectorResponseBodyResult : TeaModel {
            [NameInMap("collectorPaths")]
            [Validation(Required=false)]
            public List<string> CollectorPaths { get; set; }

            /// <summary>
            /// <para>The information about the configuration file for the shipper.</para>
            /// </summary>
            [NameInMap("configs")]
            [Validation(Required=false)]
            public List<UpdateCollectorResponseBodyResultConfigs> Configs { get; set; }
            public class UpdateCollectorResponseBodyResultConfigs : TeaModel {
                /// <summary>
                /// <para>The content of the configuration file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>filebeat.inputs:xxx</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The name of the configuration file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>filebeat.yml</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the shipper is checked and updated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The shipper is only checked.</description></item>
            /// <item><description>false: The shipper is checked and updated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("dryRun")]
            [Validation(Required=false)]
            public bool? DryRun { get; set; }

            /// <summary>
            /// <para>The extended parameters that are configured for the shipper.</para>
            /// </summary>
            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<UpdateCollectorResponseBodyResultExtendConfigs> ExtendConfigs { get; set; }
            public class UpdateCollectorResponseBodyResultExtendConfigs : TeaModel {
                /// <summary>
                /// <para>The type of the configuration items. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>collectorTargetInstance: indicates the information about the output of the shipper.</description></item>
                /// <item><description>collectorDeployMachine: indicates the information about the machine on which the shipper is installed.</description></item>
                /// <item><description>collectorElasticsearchForKibana: indicates the information about the Elasticsearch cluster for which Kibana Dashboard is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>collectorDeployMachine</para>
                /// </summary>
                [NameInMap("configType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

                /// <summary>
                /// <para>Indicates whether Kibana Monitoring is enabled. This parameter is returned only when <b>configType</b> is set to <b>collectorTargetInstance</b> and <b>instanceType</b> is set to <b>elasticsearch</b>. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableMonitoring")]
                [Validation(Required=false)]
                public bool? EnableMonitoring { get; set; }

                /// <summary>
                /// <para>The machine group ID. This parameter is returned only when <b>configType</b> is set to <b>collectorDeployMachine</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default_ct-cn-5i2l75bz4776****</para>
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The address that is used to access Kibana over an internal network after you enable Kibana Dashboard. This parameter is returned only when <b>configType</b> is set to <b>collectorElasticsearchForKibana</b>.</para>
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
                /// <para>The ID of the object that is associated with the shipper. If <b>configType</b> is set to <b>collectorTargetInstance</b>, the value of this parameter is the ID of the output of the shipper. If <b>configType</b> is set to <b>collectorDeployMachines</b> and <b>type</b> is set to <b>ACKCluster</b>, the value of this parameter is the ID of an ACK cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>es-cn-nif1z89fz003i****</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The type of the output of the shipper. Valid values: elasticsearch and logstash. This parameter is returned only when <b>configType</b> is set to <b>collectorTargetInstance</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch</para>
                /// </summary>
                [NameInMap("instanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The address that is used to access Kibana over the Internet after you enable Kibana Dashboard. This parameter is returned only when <b>configType</b> is set to <b>collectorElasticsearchForKibana</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://es-cn-nif1z89fz003i****.kibana.elasticsearch.aliyuncs.com:5601">https://es-cn-nif1z89fz003i****.kibana.elasticsearch.aliyuncs.com:5601</a></para>
                /// </summary>
                [NameInMap("kibanaHost")]
                [Validation(Required=false)]
                public string KibanaHost { get; set; }

                /// <summary>
                /// <para>This parameter is returned only when configType is set to collectorDeployMachine.</para>
                /// <para>This parameter indicates the information about the ECS instances or ACK clusters on which the shipper is installed.</para>
                /// </summary>
                [NameInMap("machines")]
                [Validation(Required=false)]
                public List<UpdateCollectorResponseBodyResultExtendConfigsMachines> Machines { get; set; }
                public class UpdateCollectorResponseBodyResultExtendConfigsMachines : TeaModel {
                    /// <summary>
                    /// <para>The installation status of the shipper on an ECS instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>heartOk</description></item>
                    /// <item><description>heartLost</description></item>
                    /// <item><description>uninstalled</description></item>
                    /// <item><description>failed</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>heartOk</para>
                    /// </summary>
                    [NameInMap("agentStatus")]
                    [Validation(Required=false)]
                    public string AgentStatus { get; set; }

                    /// <summary>
                    /// <para>The ID of the ECS instance on which the shipper is installed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-bp13y63575oypr9d****</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

                /// <summary>
                /// <para>The transfer protocol that is used. It is the same as the protocol over which you can access the output of the shipper. Valid values: HTTP and HTTPS. This parameter is returned only when <b>configType</b> is set to <b>collectorTargetInstance</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The number of pods from which logs are successfully collected in the ACK cluster. This parameter is returned only when <b>configType</b> is set to <b>collectorDeployMachines</b> and <b>type</b> is set to <b>ACKCluster</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("successPodsCount")]
                [Validation(Required=false)]
                public string SuccessPodsCount { get; set; }

                /// <summary>
                /// <para>The number of pods from which logs needed to be collected in the ACK cluster. This parameter is returned only when <b>configType</b> is set to <b>collectorDeployMachines</b> and <b>type</b> is set to <b>ACKCluster</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("totalPodsCount")]
                [Validation(Required=false)]
                public string TotalPodsCount { get; set; }

                /// <summary>
                /// <para>The type of the machine on which the shipper is installed. This parameter is returned only when <b>configType</b> is set to <b>collectorDeployMachine</b>. Valid values:</para>
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
                /// <para>The username that is used to access the output of the shipper. Default value: elastic. This parameter is returned only when <b>configType</b> is set to <b>collectorTargetInstance</b> or <b>collectorElasticsearchForKibana</b>.</para>
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
            /// <para>ct-test</para>
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
            /// <para>The shipper ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ct-cn-0v3xj86085dvq****</para>
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
            /// <item><description>activing: The shipper is being initialized.</description></item>
            /// <item><description>active: The shipper is in effect.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the VPC in which the shipper resides.</para>
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
