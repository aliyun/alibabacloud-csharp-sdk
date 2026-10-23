// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListEcsInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response headers.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListEcsInstancesResponseBodyHeaders Headers { get; set; }
        public class ListEcsInstancesResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The number of returned records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListEcsInstancesResponseBodyResult> Result { get; set; }
        public class ListEcsInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The installation status of Cloud Assistant. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: installed</description></item>
            /// <item><description>false: not installed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cloudAssistantStatus")]
            [Validation(Required=false)]
            public string CloudAssistantStatus { get; set; }

            /// <summary>
            /// <para>The list of collectors on the ECS instance.</para>
            /// </summary>
            [NameInMap("collectors")]
            [Validation(Required=false)]
            public List<ListEcsInstancesResponseBodyResultCollectors> Collectors { get; set; }
            public class ListEcsInstancesResponseBodyResultCollectors : TeaModel {
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
                public List<ListEcsInstancesResponseBodyResultCollectorsConfigs> Configs { get; set; }
                public class ListEcsInstancesResponseBodyResultCollectorsConfigs : TeaModel {
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
                /// <para>Specifies whether to verify and create the collector. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Verifies the collector but does not create it.</description></item>
                /// <item><description>false: Verifies and creates the collector.</description></item>
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
                public List<ListEcsInstancesResponseBodyResultCollectorsExtendConfigs> ExtendConfigs { get; set; }
                public class ListEcsInstancesResponseBodyResultCollectorsExtendConfigs : TeaModel {
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
                    /// <para>Specifies whether to enable monitoring. This parameter is displayed when <b>configType</b> is set to <b>collectorTargetInstance</b> and <b>instanceType</b> is set to <b>elasticsearch</b>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Enables monitoring.</description></item>
                    /// <item><description>false: Disables monitoring.</description></item>
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
                    /// <para>The list of host addresses of the collector target instance.</para>
                    /// </summary>
                    [NameInMap("hosts")]
                    [Validation(Required=false)]
                    public List<string> Hosts { get; set; }

                    /// <summary>
                    /// <para>Instance ID of the instance associated with the collector. When <b>configType</b> is set to <b>collectorTargetInstance</b>, this parameter indicates instance ID of the collector output instance. When <b>configType</b> is set to <b>collectorDeployMachines</b> and <b>type</b> is set to <b>ACKCluster</b>, this parameter indicates instance ID of the ACK cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>es-cn-nif1z89fz003i****</para>
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
                    /// <para>The list of ECS instances on which the collector is deployed. This parameter is displayed when <b>configType</b> is set to <b>collectorDeployMachines</b> and <b>type</b> is set to <b>ECSInstanceId</b>.</para>
                    /// </summary>
                    [NameInMap("machines")]
                    [Validation(Required=false)]
                    public List<ListEcsInstancesResponseBodyResultCollectorsExtendConfigsMachines> Machines { get; set; }
                    public class ListEcsInstancesResponseBodyResultCollectorsExtendConfigsMachines : TeaModel {
                        /// <summary>
                        /// <para>The status of each collector on the ECS instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>heartOk: normal heartbeat</description></item>
                        /// <item><description>heartLost: abnormal heartbeat</description></item>
                        /// <item><description>uninstalled: not installed</description></item>
                        /// <item><description>failed: installation failed</description></item>
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
                    /// <para>The transmission protocol, which must be consistent with the access protocol of the instance specified by the collector output. Valid values: HTTP and HTTPS. This parameter is displayed when <b>configType</b> is set to <b>collectorTargetInstance</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The type of the machine on which the collector is deployed. This parameter is displayed when <b>configType</b> is set to <b>collectorDeployMachine</b>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ECSInstanceId: ECS instance</description></item>
                    /// <item><description>ACKCluster: ACK cluster</description></item>
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
                /// <para>The time when the collector was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-20T07:26:47.000+0000</para>
                /// </summary>
                [NameInMap("gmtCreatedTime")]
                [Validation(Required=false)]
                public string GmtCreatedTime { get; set; }

                /// <summary>
                /// <para>The time when the collector was updated.</para>
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
                /// <para>ct-testAbc</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16852<em><b>488</b></em>**</para>
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
                /// <para>The type of the collector. Valid values: fileBeat, metricBeat, heartBeat, and auditBeat.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fileBeat</para>
                /// </summary>
                [NameInMap("resType")]
                [Validation(Required=false)]
                public string ResType { get; set; }

                /// <summary>
                /// <para>The version of the collector. When the machine type is ECS, only <b>6.8.5_with_community</b> is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6.8.5_with_community</para>
                /// </summary>
                [NameInMap("resVersion")]
                [Validation(Required=false)]
                public string ResVersion { get; set; }

                /// <summary>
                /// <para>The status of the collector. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>activing: taking effect</description></item>
                /// <item><description>active: effective</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>activing</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the VPC where the collector resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp16k1dvzxtm******</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The ECS instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp14ncqge8wy3l3d****</para>
            /// </summary>
            [NameInMap("ecsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecsTestName</para>
            /// </summary>
            [NameInMap("ecsInstanceName")]
            [Validation(Required=false)]
            public string EcsInstanceName { get; set; }

            /// <summary>
            /// <para>The IP address information of the ECS instance.</para>
            /// </summary>
            [NameInMap("ipAddress")]
            [Validation(Required=false)]
            public List<ListEcsInstancesResponseBodyResultIpAddress> IpAddress { get; set; }
            public class ListEcsInstancesResponseBodyResultIpAddress : TeaModel {
                /// <summary>
                /// <para>The IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.xx.xx</para>
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The type of the IP address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>public: public IP address</description></item>
                /// <item><description>private: private network IP address</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>private</para>
                /// </summary>
                [NameInMap("ipType")]
                [Validation(Required=false)]
                public string IpType { get; set; }

            }

            /// <summary>
            /// <para>The operating system type of the ECS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>windows: Windows operating system</description></item>
            /// <item><description>linux: Linux operating system</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("osType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The status of the ECS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>running: running</description></item>
            /// <item><description>starting: starting</description></item>
            /// <item><description>stopping: stopping</description></item>
            /// <item><description>stopped: stopped</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag information of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[ { &quot;tagKey&quot;: &quot;a&quot;, &quot;tagValue&quot;: &quot;b&quot; } ]</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

        }

    }

}
