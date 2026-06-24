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
            /// <para>The total number of returned records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

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
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListEcsInstancesResponseBodyResult> Result { get; set; }
        public class ListEcsInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The installation status of Cloud Assistant. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Installed.</description></item>
            /// <item><description>false: Not installed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cloudAssistantStatus")]
            [Validation(Required=false)]
            public string CloudAssistantStatus { get; set; }

            /// <summary>
            /// <para>The list of collectors deployed on the ECS instance.</para>
            /// </summary>
            [NameInMap("collectors")]
            [Validation(Required=false)]
            public List<ListEcsInstancesResponseBodyResultCollectors> Collectors { get; set; }
            public class ListEcsInstancesResponseBodyResultCollectors : TeaModel {
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
                /// <para>Indicates whether the collector is only validated without being created. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Only validates without creating.</description></item>
                /// <item><description>false: Validates and creates.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("dryRun")]
                [Validation(Required=false)]
                public bool? DryRun { get; set; }

                /// <summary>
                /// <para>The extended configuration information.</para>
                /// </summary>
                [NameInMap("extendConfigs")]
                [Validation(Required=false)]
                public List<ListEcsInstancesResponseBodyResultCollectorsExtendConfigs> ExtendConfigs { get; set; }
                public class ListEcsInstancesResponseBodyResultCollectorsExtendConfigs : TeaModel {
                    /// <summary>
                    /// <para>The configuration type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>collectorTargetInstance: the collector Output.</description></item>
                    /// <item><description>collectorDeployMachine: the deployment machine of the collector.</description></item>
                    /// <item><description>collectorElasticsearchForKibana: the Elasticsearch instance information that supports Kibana dashboards.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>collectorDeployMachine</para>
                    /// </summary>
                    [NameInMap("configType")]
                    [Validation(Required=false)]
                    public string ConfigType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether Monitoring is enabled. This parameter is displayed when configType is set to collectorTargetInstance and instanceType is set to elasticsearch. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Enabled.</description></item>
                    /// <item><description>false: Not enabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableMonitoring")]
                    [Validation(Required=false)]
                    public bool? EnableMonitoring { get; set; }

                    /// <summary>
                    /// <para>The machine group ID. This parameter is displayed when configType is set to collectorDeployMachine.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default_ct-cn-5i2l75bz4776****</para>
                    /// </summary>
                    [NameInMap("groupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("hosts")]
                    [Validation(Required=false)]
                    public List<string> Hosts { get; set; }

                    /// <summary>
                    /// <para>The ID of the instance associated with the collector. When configType is set to collectorTargetInstance, this is the instance ID of the collector Output. When configType is set to collectorDeployMachines and type is set to ACKCluster, this is the ACK (Container Service for Kubernetes) cluster ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>es-cn-nif1z89fz003i****</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The type of the instance specified by the collector Output. Valid values: elasticsearch and logstash. This parameter is displayed when configType is set to collectorTargetInstance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>elasticsearch</para>
                    /// </summary>
                    [NameInMap("instanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>The list of ECS machines on which the collector is deployed. This parameter is displayed when configType is set to collectorDeployMachines and type is set to ECSInstanceId.</para>
                    /// </summary>
                    [NameInMap("machines")]
                    [Validation(Required=false)]
                    public List<ListEcsInstancesResponseBodyResultCollectorsExtendConfigsMachines> Machines { get; set; }
                    public class ListEcsInstancesResponseBodyResultCollectorsExtendConfigsMachines : TeaModel {
                        /// <summary>
                        /// <para>The status of each collector on the ECS instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>heartOk: The heartbeat is normal.</description></item>
                        /// <item><description>heartLost: The heartbeat is abnormal.</description></item>
                        /// <item><description>uninstalled: Not installed.</description></item>
                        /// <item><description>failed: Installation failed.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>heartOk</para>
                        /// </summary>
                        [NameInMap("agentStatus")]
                        [Validation(Required=false)]
                        public string AgentStatus { get; set; }

                        /// <summary>
                        /// <para>The list of ECS machine IDs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-bp13y63575oypr9d****</para>
                        /// </summary>
                        [NameInMap("instanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The transmission protocol, which must be consistent with the access protocol of the instance specified by the collector Output. Valid values: HTTP and HTTPS. This parameter is displayed when configType is set to collectorTargetInstance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The type of machine on which the collector is deployed. This parameter is displayed when configType is set to collectorDeployMachine. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ECSInstanceId: ECS</description></item>
                    /// <item><description>ACKCluster: Container Service for Kubernetes.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ECSInstanceId</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The username used to access the instance specified by the collector Output. Default value: elastic. This parameter is displayed when configType is set to collectorTargetInstance or collectorElasticsearchForKibana.</para>
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
                /// <para>The time when the collector was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-20T07:26:47.000+0000</para>
                /// </summary>
                [NameInMap("gmtUpdateTime")]
                [Validation(Required=false)]
                public string GmtUpdateTime { get; set; }

                /// <summary>
                /// <para>The collector name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ct-testAbc</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The account ID.</para>
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
                /// <para>The collector type. Valid values: fileBeat, metricBeat, heartBeat, and auditBeat.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fileBeat</para>
                /// </summary>
                [NameInMap("resType")]
                [Validation(Required=false)]
                public string ResType { get; set; }

                /// <summary>
                /// <para>The collector version. When the machine type for collector deployment is ECS, only <b>6.8.5_with_community</b> is supported.</para>
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
                /// <item><description>activing: Taking effect.</description></item>
                /// <item><description>active: Active.</description></item>
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
                /// <para>The IP address type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>public: public IP address.</description></item>
                /// <item><description>private: private network address.</description></item>
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
            /// <item><description>windows: Windows operating system.</description></item>
            /// <item><description>linux: Linux operating system.</description></item>
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
            /// <item><description>running: Running.</description></item>
            /// <item><description>starting: Starting.</description></item>
            /// <item><description>stopping: Stopping.</description></item>
            /// <item><description>stopped: Stopped.</description></item>
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
