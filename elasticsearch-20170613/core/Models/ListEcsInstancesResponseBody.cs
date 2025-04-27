// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListEcsInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of returned records.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListEcsInstancesResponseBodyHeaders Headers { get; set; }
        public class ListEcsInstancesResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// <para>The header of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Cloud Assistant the installation status, support:</para>
        /// <list type="bullet">
        /// <item><description>true: The Prometheus agent was installed.</description></item>
        /// <item><description>false: The Prometheus agent was not installed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListEcsInstancesResponseBodyResult> Result { get; set; }
        public class ListEcsInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The name of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cloudAssistantStatus")]
            [Validation(Required=false)]
            public string CloudAssistantStatus { get; set; }

            /// <summary>
            /// <para>The ID of the collector instance.</para>
            /// </summary>
            [NameInMap("collectors")]
            [Validation(Required=false)]
            public List<ListEcsInstancesResponseBodyResultCollectors> Collectors { get; set; }
            public class ListEcsInstancesResponseBodyResultCollectors : TeaModel {
                [NameInMap("collectorPaths")]
                [Validation(Required=false)]
                public List<string> CollectorPaths { get; set; }

                /// <summary>
                /// <para>The content of the file.</para>
                /// </summary>
                [NameInMap("configs")]
                [Validation(Required=false)]
                public List<ListEcsInstancesResponseBodyResultCollectorsConfigs> Configs { get; set; }
                public class ListEcsInstancesResponseBodyResultCollectorsConfigs : TeaModel {
                    /// <summary>
                    /// <para>The name of the file.</para>
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
                    /// <para>The information about the extended parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fields.yml</para>
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("dryRun")]
                [Validation(Required=false)]
                public bool? DryRun { get; set; }

                /// <summary>
                /// <para>Whether Monitoring is enabled. This field is displayed when the <b>configType</b> is <b>collectorTargetInstance</b> and the <b>instanceType</b> is <b>Elasticsearch</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// </summary>
                [NameInMap("extendConfigs")]
                [Validation(Required=false)]
                public List<ListEcsInstancesResponseBodyResultCollectorsExtendConfigs> ExtendConfigs { get; set; }
                public class ListEcsInstancesResponseBodyResultCollectorsExtendConfigs : TeaModel {
                    /// <summary>
                    /// <para>The instance type specified by Collector Output. Supports Elasticsearch and Logstash. Displayed when the <b>configType</b> is <b>collectorTargetInstance</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>collectorDeployMachine</para>
                    /// </summary>
                    [NameInMap("configType")]
                    [Validation(Required=false)]
                    public string ConfigType { get; set; }

                    /// <summary>
                    /// <para>The ID of the host group. Displayed when the <b>configType</b> is <b>collectorDeployMachine</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableMonitoring")]
                    [Validation(Required=false)]
                    public bool? EnableMonitoring { get; set; }

                    /// <summary>
                    /// <para>The configuration type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>collectorTargetInstance: Collector Output</description></item>
                    /// <item><description>collectorDeployMachine: Collector Deployment Machine</description></item>
                    /// <item><description>Collector Elasticsearch ForKibana: Elasticsearch instance information that supports the Kibana dashboard</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default_ct-cn-5i2l75bz4776****</para>
                    /// </summary>
                    [NameInMap("groupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// <para>The path in which Filebeat is collected.</para>
                    /// </summary>
                    [NameInMap("hosts")]
                    [Validation(Required=false)]
                    public List<string> Hosts { get; set; }

                    /// <summary>
                    /// <para>The list of ECS instances on which the collector is deployed. Displayed when the <b>configType</b> is <b>collectorDeployMachines</b> and the <b>type</b> is <b>ECSInstanceId</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>es-cn-nif1z89fz003i****</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The transmission protocol, which must be the same as the access protocol of the instance specified by Output. HTTP and HTTPS. Displayed when the <b>configType</b> is <b>collectorTargetInstance</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>elasticsearch</para>
                    /// </summary>
                    [NameInMap("instanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>The status of each crawl on the ECS instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>heartOk: The heartbeat is normal.</description></item>
                    /// <item><description>heartLost: The heartbeat is abnormal.</description></item>
                    /// <item><description>uninstalled</description></item>
                    /// <item><description>failed: The installation failed.</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("machines")]
                    [Validation(Required=false)]
                    public List<ListEcsInstancesResponseBodyResultCollectorsExtendConfigsMachines> Machines { get; set; }
                    public class ListEcsInstancesResponseBodyResultCollectorsExtendConfigsMachines : TeaModel {
                        /// <summary>
                        /// <para>The IDs of ECS instances.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>heartOk</para>
                        /// </summary>
                        [NameInMap("agentStatus")]
                        [Validation(Required=false)]
                        public string AgentStatus { get; set; }

                        /// <summary>
                        /// <para>The list of access addresses of the specified instance for the output of the collector. Displayed when the <b>configType</b> is <b>collectorTargetInstance</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-bp13y63575oypr9d****</para>
                        /// </summary>
                        [NameInMap("instanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The username that is used to access the instance. The default value is elastic. Displayed when the <b>configType</b> is <b>collectorTargetInstance</b> or <b>collectorElasticsearchForKibana</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The ID of the instance that is associated with the crawker. If the <b>configType</b> parameter is set to <b>collectorTargetInstance</b>, the value of this parameter is the ID of the output collector. If the <b>configType</b> parameter is set to <b>collectorDeployMachines</b> and the <b>type</b> parameter is set to <b>ACKCluster</b>, the value of this parameter is the ID of the ACK cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ECSInstanceId</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The type of the machine on which the Collector is deployed. This parameter is displayed when the <b>configType</b> is <b>collectorDeployMachine</b>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ECSInstanceId:ECS</description></item>
                    /// <item><description>ACKCluster: Container Kubernetes</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>elastic</para>
                    /// </summary>
                    [NameInMap("userName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

                /// <summary>
                /// <para>The status of the collector. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>activating: The project is taking effect.</description></item>
                /// <item><description>active: The instance has taken effect.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-20T07:26:47.000+0000</para>
                /// </summary>
                [NameInMap("gmtCreatedTime")]
                [Validation(Required=false)]
                public string GmtCreatedTime { get; set; }

                /// <summary>
                /// <para>Specifies whether to verify and create a crawer. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: only verifies and does not create a</description></item>
                /// <item><description>false: verifies and creates a</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-20T07:26:47.000+0000</para>
                /// </summary>
                [NameInMap("gmtUpdateTime")]
                [Validation(Required=false)]
                public string GmtUpdateTime { get; set; }

                /// <summary>
                /// <para>The configuration file information of the collector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ct-testAbc</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the Virtual Private Cloud to which the collector belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16852<em><b>488</b></em>**</para>
                /// </summary>
                [NameInMap("ownerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The time when the collector was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ct-cn-0v3xj86085dvq****</para>
                /// </summary>
                [NameInMap("resId")]
                [Validation(Required=false)]
                public string ResId { get; set; }

                /// <summary>
                /// <para>The version of the collector. If the machine type of the collector is ECS, only <b>6.8.5_with_community</b> is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fileBeat</para>
                /// </summary>
                [NameInMap("resType")]
                [Validation(Required=false)]
                public string ResType { get; set; }

                /// <summary>
                /// <para>The time when the crawl collector was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6.8.5_with_community</para>
                /// </summary>
                [NameInMap("resVersion")]
                [Validation(Required=false)]
                public string ResVersion { get; set; }

                /// <summary>
                /// <para>The name of the collector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>activing</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the collector. FileBeat, metricBeat, heartBeat, and auditBeat are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp16k1dvzxtm******</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The tags of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp14ncqge8wy3l3d****</para>
            /// </summary>
            [NameInMap("ecsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecsTestName</para>
            /// </summary>
            [NameInMap("ecsInstanceName")]
            [Validation(Required=false)]
            public string EcsInstanceName { get; set; }

            /// <summary>
            /// <para>The type of the IP address that is used by the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>public: public endpoint</description></item>
            /// <item><description>private: private network address</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ipAddress")]
            [Validation(Required=false)]
            public List<ListEcsInstancesResponseBodyResultIpAddress> IpAddress { get; set; }
            public class ListEcsInstancesResponseBodyResultIpAddress : TeaModel {
                /// <summary>
                /// <para>The information about the collectors on the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.xx.xx</para>
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The IP address of the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>private</para>
                /// </summary>
                [NameInMap("ipType")]
                [Validation(Required=false)]
                public string IpType { get; set; }

            }

            /// <summary>
            /// <para>The status of the ECS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>running: The master instance is running</description></item>
            /// <item><description>starting</description></item>
            /// <item><description>stopping: The task is being stopped.</description></item>
            /// <item><description>stopped: The node is stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("osType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The IP address of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The operating system type of the ECS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>windows:Windows operating system</description></item>
            /// <item><description>linux:Linux operating system</description></item>
            /// </list>
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
