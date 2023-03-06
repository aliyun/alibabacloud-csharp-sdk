// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListEcsInstancesResponseBody : TeaModel {
        /// <summary>
        /// The header of the response.
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListEcsInstancesResponseBodyHeaders Headers { get; set; }
        public class ListEcsInstancesResponseBodyHeaders : TeaModel {
            /// <summary>
            /// The number of returned records.
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListEcsInstancesResponseBodyResult> Result { get; set; }
        public class ListEcsInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// Cloud Assistant the installation status, support:
            /// 
            /// *   true: The Prometheus agent was installed.
            /// *   false: The Prometheus agent was not installed.
            /// </summary>
            [NameInMap("cloudAssistantStatus")]
            [Validation(Required=false)]
            public string CloudAssistantStatus { get; set; }

            /// <summary>
            /// The information about the collectors on the ECS instance.
            /// </summary>
            [NameInMap("collectors")]
            [Validation(Required=false)]
            public List<ListEcsInstancesResponseBodyResultCollectors> Collectors { get; set; }
            public class ListEcsInstancesResponseBodyResultCollectors : TeaModel {
                /// <summary>
                /// The path in which Filebeat is collected.
                /// </summary>
                [NameInMap("collectorPaths")]
                [Validation(Required=false)]
                public List<string> CollectorPaths { get; set; }

                /// <summary>
                /// The configuration file information of the collector.
                /// </summary>
                [NameInMap("configs")]
                [Validation(Required=false)]
                public List<ListEcsInstancesResponseBodyResultCollectorsConfigs> Configs { get; set; }
                public class ListEcsInstancesResponseBodyResultCollectorsConfigs : TeaModel {
                    /// <summary>
                    /// The content of the file.
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The name of the file.
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                }

                /// <summary>
                /// Specifies whether to verify and create a crawer. Valid values:
                /// 
                /// *   true: only verifies and does not create a
                /// *   false: verifies and creates a
                /// </summary>
                [NameInMap("dryRun")]
                [Validation(Required=false)]
                public bool? DryRun { get; set; }

                /// <summary>
                /// The information about the extended parameter.
                /// </summary>
                [NameInMap("extendConfigs")]
                [Validation(Required=false)]
                public List<ListEcsInstancesResponseBodyResultCollectorsExtendConfigs> ExtendConfigs { get; set; }
                public class ListEcsInstancesResponseBodyResultCollectorsExtendConfigs : TeaModel {
                    /// <summary>
                    /// The configuration type. Valid values:
                    /// 
                    /// *   collectorTargetInstance: Collector Output
                    /// *   collectorDeployMachine: Collector Deployment Machine
                    /// *   Collector Elasticsearch ForKibana: Elasticsearch instance information that supports the Kibana dashboard
                    /// </summary>
                    [NameInMap("configType")]
                    [Validation(Required=false)]
                    public string ConfigType { get; set; }

                    /// <summary>
                    /// Whether Monitoring is enabled. This field is displayed when the **configType** is **collectorTargetInstance** and the **instanceType** is **Elasticsearch**. Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// </summary>
                    [NameInMap("enableMonitoring")]
                    [Validation(Required=false)]
                    public bool? EnableMonitoring { get; set; }

                    /// <summary>
                    /// The ID of the host group. Displayed when the **configType** is **collectorDeployMachine**.
                    /// </summary>
                    [NameInMap("groupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// The list of access addresses of the specified instance for the output of the collector. Displayed when the **configType** is **collectorTargetInstance**.
                    /// </summary>
                    [NameInMap("hosts")]
                    [Validation(Required=false)]
                    public List<string> Hosts { get; set; }

                    /// <summary>
                    /// The ID of the instance that is associated with the crawker. If the **configType** parameter is set to **collectorTargetInstance**, the value of this parameter is the ID of the output collector. If the **configType** parameter is set to **collectorDeployMachines** and the **type** parameter is set to **ACKCluster**, the value of this parameter is the ID of the ACK cluster.
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The instance type specified by Collector Output. Supports Elasticsearch and Logstash. Displayed when the **configType** is **collectorTargetInstance**.
                    /// </summary>
                    [NameInMap("instanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// The list of ECS instances on which the collector is deployed. Displayed when the **configType** is **collectorDeployMachines** and the **type** is **ECSInstanceId**.
                    /// </summary>
                    [NameInMap("machines")]
                    [Validation(Required=false)]
                    public List<ListEcsInstancesResponseBodyResultCollectorsExtendConfigsMachines> Machines { get; set; }
                    public class ListEcsInstancesResponseBodyResultCollectorsExtendConfigsMachines : TeaModel {
                        /// <summary>
                        /// The status of each crawl on the ECS instance. Valid values:
                        /// 
                        /// *   heartOk: The heartbeat is normal.
                        /// *   heartLost: The heartbeat is abnormal.
                        /// *   uninstalled
                        /// *   failed: The installation failed.
                        /// </summary>
                        [NameInMap("agentStatus")]
                        [Validation(Required=false)]
                        public string AgentStatus { get; set; }

                        /// <summary>
                        /// The IDs of ECS instances.
                        /// </summary>
                        [NameInMap("instanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                    /// <summary>
                    /// The transmission protocol, which must be the same as the access protocol of the instance specified by Output. HTTP and HTTPS. Displayed when the **configType** is **collectorTargetInstance**.
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// The type of the machine on which the Collector is deployed. This parameter is displayed when the **configType** is **collectorDeployMachine**. Valid values:
                    /// 
                    /// *   ECSInstanceId:ECS
                    /// *   ACKCluster: Container Kubernetes
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The username that is used to access the instance. The default value is elastic. Displayed when the **configType** is **collectorTargetInstance** or **collectorElasticsearchForKibana**.
                    /// </summary>
                    [NameInMap("userName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

                /// <summary>
                /// The time when the crawl collector was created.
                /// </summary>
                [NameInMap("gmtCreatedTime")]
                [Validation(Required=false)]
                public string GmtCreatedTime { get; set; }

                /// <summary>
                /// The time when the collector was updated.
                /// </summary>
                [NameInMap("gmtUpdateTime")]
                [Validation(Required=false)]
                public string GmtUpdateTime { get; set; }

                /// <summary>
                /// The name of the collector.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("ownerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// The ID of the collector instance.
                /// </summary>
                [NameInMap("resId")]
                [Validation(Required=false)]
                public string ResId { get; set; }

                /// <summary>
                /// The type of the collector. FileBeat, metricBeat, heartBeat, and auditBeat are supported.
                /// </summary>
                [NameInMap("resType")]
                [Validation(Required=false)]
                public string ResType { get; set; }

                /// <summary>
                /// The version of the collector. If the machine type of the collector is ECS, only **6.8.5\_with_community** is supported.
                /// </summary>
                [NameInMap("resVersion")]
                [Validation(Required=false)]
                public string ResVersion { get; set; }

                /// <summary>
                /// The status of the collector. Valid values:
                /// 
                /// *   activating: The project is taking effect.
                /// *   active: The instance has taken effect.
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the Virtual Private Cloud to which the collector belongs.
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// The ID of the ECS instance.
            /// </summary>
            [NameInMap("ecsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// The name of the ECS instance.
            /// </summary>
            [NameInMap("ecsInstanceName")]
            [Validation(Required=false)]
            public string EcsInstanceName { get; set; }

            /// <summary>
            /// The IP address of the ECS instance.
            /// </summary>
            [NameInMap("ipAddress")]
            [Validation(Required=false)]
            public List<ListEcsInstancesResponseBodyResultIpAddress> IpAddress { get; set; }
            public class ListEcsInstancesResponseBodyResultIpAddress : TeaModel {
                /// <summary>
                /// The IP address of the endpoint.
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The type of the IP address that is used by the instance. Valid values:
                /// 
                /// *   public: public endpoint
                /// *   private: private network address
                /// </summary>
                [NameInMap("ipType")]
                [Validation(Required=false)]
                public string IpType { get; set; }

            }

            /// <summary>
            /// The operating system type of the ECS instance. Valid values:
            /// 
            /// *   windows:Windows operating system
            /// *   linux:Linux operating system
            /// </summary>
            [NameInMap("osType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// The status of the ECS instance. Valid values:
            /// 
            /// *   running: The master instance is running
            /// *   starting
            /// *   stopping: The task is being stopped.
            /// *   stopped: The node is stopped.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags of the ECS instance.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

        }

    }

}
