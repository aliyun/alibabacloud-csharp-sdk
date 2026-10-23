// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListCollectorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response headers.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListCollectorsResponseBodyHeaders Headers { get; set; }
        public class ListCollectorsResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The number of returned records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

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
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListCollectorsResponseBodyResult> Result { get; set; }
        public class ListCollectorsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The list of Filebeat collection paths.</para>
            /// </summary>
            [NameInMap("collectorPaths")]
            [Validation(Required=false)]
            public List<string> CollectorPaths { get; set; }

            /// <summary>
            /// <para>The configuration file information of the collector.</para>
            /// </summary>
            [NameInMap("configs")]
            [Validation(Required=false)]
            public List<ListCollectorsResponseBodyResultConfigs> Configs { get; set; }
            public class ListCollectorsResponseBodyResultConfigs : TeaModel {
                /// <summary>
                /// <para>The file content.</para>
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
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fields.yml</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to verify and create the collector. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: only verifies the collector without creating it</description></item>
            /// <item><description>false: verifies and creates the collector</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("dryRun")]
            [Validation(Required=false)]
            public bool? DryRun { get; set; }

            /// <summary>
            /// <para>The extended parameter information.</para>
            /// </summary>
            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<ListCollectorsResponseBodyResultExtendConfigs> ExtendConfigs { get; set; }
            public class ListCollectorsResponseBodyResultExtendConfigs : TeaModel {
                /// <summary>
                /// <para>The configuration type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>collectorTargetInstance: the collector output</description></item>
                /// <item><description>collectorDeployMachine: the machine on which the collector is deployed</description></item>
                /// <item><description>collectorElasticsearchForKibana: the information about the Elasticsearch instance that supports Kibana dashboards</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>collectorDeployMachine</para>
                /// </summary>
                [NameInMap("configType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable Monitoring. This parameter is displayed when <b>configType</b> is set to <b>collectorTargetInstance</b> and <b>instanceType</b> is set to <b>elasticsearch</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: enabled</para>
                /// </description></item>
                /// <item><description><para>false: disabled</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableMonitoring")]
                [Validation(Required=false)]
                public bool? EnableMonitoring { get; set; }

                /// <summary>
                /// <para>The machine group ID. This parameter is displayed when <b>configType</b> is set to <b>collectorDeployMachine</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default_ct-cn-5i2l75bz4776****</para>
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The private network access address of Kibana after Kibana Dashboard is enabled. This parameter is displayed when <b>configType</b> is set to <b>collectorElasticsearchForKibana</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>es-cn-n6w1o1x0w001c****-kibana.internal.elasticsearch.aliyuncs.com:5601</para>
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The list of host addresses of the target instance for the collector.</para>
                /// </summary>
                [NameInMap("hosts")]
                [Validation(Required=false)]
                public List<string> Hosts { get; set; }

                /// <summary>
                /// <para>Instance ID of the instance associated with the collector. When <b>configType</b> is set to <b>collectorTargetInstance</b>, this parameter indicates instance ID of the instance in the collector output. When <b>configType</b> is set to <b>collectorDeployMachines</b> and <b>type</b> is set to <b>ACKCluster</b>, this parameter indicates the ACK cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>es-cn-nif1z89fz003i****</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The type of the instance specified in the collector output. Valid values: elasticsearch and logstash. This parameter is displayed when <b>configType</b> is set to <b>collectorTargetInstance</b>.</para>
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
                /// <para><a href="https://es-cn-nif1z89fz003i****.kibana.elasticsearch.aliyuncs.com:5601">https://es-cn-nif1z89fz003i****.kibana.elasticsearch.aliyuncs.com:5601</a></para>
                /// </summary>
                [NameInMap("kibanaHost")]
                [Validation(Required=false)]
                public string KibanaHost { get; set; }

                /// <summary>
                /// <para>The list of ECS instances on which the collector is deployed. This parameter is displayed when <b>configType</b> is set to <b>collectorDeployMachines</b> and <b>type</b> is set to <b>ECSInstanceId</b>.</para>
                /// </summary>
                [NameInMap("machines")]
                [Validation(Required=false)]
                public List<ListCollectorsResponseBodyResultExtendConfigsMachines> Machines { get; set; }
                public class ListCollectorsResponseBodyResultExtendConfigsMachines : TeaModel {
                    /// <summary>
                    /// <para>The status of each collector on the ECS instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>heartOk: The heartbeat is normal.</description></item>
                    /// <item><description>heartLost: The heartbeat is abnormal.</description></item>
                    /// <item><description>uninstalled: The collector is not installed.</description></item>
                    /// <item><description>failed: The installation failed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>heartOk</para>
                    /// </summary>
                    [NameInMap("agentStatus")]
                    [Validation(Required=false)]
                    public string AgentStatus { get; set; }

                    /// <summary>
                    /// <para>The list of ECS instance IDs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-bp13y63575oypr9d****</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

                /// <summary>
                /// <para>The transmission protocol, which must be consistent with the access protocol of the instance specified in the collector output. Valid values: HTTP and HTTPS. This parameter is displayed when <b>configType</b> is set to <b>collectorTargetInstance</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The number of pods successfully collected in the ACK cluster. This parameter is displayed when <b>configType</b> is set to <b>collectorDeployMachines</b> and <b>type</b> is set to <b>ACKCluster</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("successPodsCount")]
                [Validation(Required=false)]
                public string SuccessPodsCount { get; set; }

                /// <summary>
                /// <para>The total number of pods collected in the ACK cluster. This parameter is displayed when <b>configType</b> is set to <b>collectorDeployMachines</b> and <b>type</b> is set to <b>ACKCluster</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("totalPodsCount")]
                [Validation(Required=false)]
                public string TotalPodsCount { get; set; }

                /// <summary>
                /// <para>The type of machine on which the collector is deployed. This parameter is displayed when <b>configType</b> is set to <b>collectorDeployMachine</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>ECSInstanceId: ECS</para>
                /// </description></item>
                /// <item><description><para>ACKCluster: ACK cluster</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ECSInstanceId</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The username used to access the instance specified in the collector output. Default value: elastic. This parameter is displayed when <b>configType</b> is set to <b>collectorTargetInstance</b> or <b>collectorElasticsearchForKibana</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elastic</para>
                /// </summary>
                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The time when the collector was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-08-18T02:06:12.000+0000</para>
            /// </summary>
            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }

            /// <summary>
            /// <para>The time when the collector was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-08-18T09:40:43.000+0000</para>
            /// </summary>
            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }

            /// <summary>
            /// <para>The collector name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FileBeat001</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>168520994880****</para>
            /// </summary>
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The collector instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ct-cn-0v3xj86085dvq****</para>
            /// </summary>
            [NameInMap("resId")]
            [Validation(Required=false)]
            public string ResId { get; set; }

            /// <summary>
            /// <para>The collector type. Valid values: fileBeat, metricBeat, heartBeat, and auditBeat.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fileBeat</para>
            /// </summary>
            [NameInMap("resType")]
            [Validation(Required=false)]
            public string ResType { get; set; }

            /// <summary>
            /// <para>The collector version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6.8.5_with_community</para>
            /// </summary>
            [NameInMap("resVersion")]
            [Validation(Required=false)]
            public string ResVersion { get; set; }

            /// <summary>
            /// <para>The collector status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>activing: taking effect</para>
            /// </description></item>
            /// <item><description><para>active: effective</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the VPC where the collector resides.</para>
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
