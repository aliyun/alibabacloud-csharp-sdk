// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateCollectorNameResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateCollectorNameResponseBodyResult Result { get; set; }
        public class UpdateCollectorNameResponseBodyResult : TeaModel {
            [NameInMap("collectorPaths")]
            [Validation(Required=false)]
            public List<string> CollectorPaths { get; set; }

            /// <summary>
            /// The information about the configuration file of the shipper.
            /// </summary>
            [NameInMap("configs")]
            [Validation(Required=false)]
            public List<UpdateCollectorNameResponseBodyResultConfigs> Configs { get; set; }
            public class UpdateCollectorNameResponseBodyResultConfigs : TeaModel {
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
            /// Indicates whether a dry run is performed. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("dryRun")]
            [Validation(Required=false)]
            public bool? DryRun { get; set; }

            /// <summary>
            /// The extended configurations of the shipper.
            /// </summary>
            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<UpdateCollectorNameResponseBodyResultExtendConfigs> ExtendConfigs { get; set; }
            public class UpdateCollectorNameResponseBodyResultExtendConfigs : TeaModel {
                /// <summary>
                /// The configuration type. Valid values:
                /// 
                /// *   collectorTargetInstance
                /// *   collectorDeployMachine
                /// *   collectorElasticsearchForKibana
                /// </summary>
                [NameInMap("configType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

                /// <summary>
                /// Indicates whether monitoring is enabled. This parameter is returned if the value of **configType** is **collectorTargetInstance** and the value of **instanceType** is **elasticsearch**. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("enableMonitoring")]
                [Validation(Required=false)]
                public bool? EnableMonitoring { get; set; }

                /// <summary>
                /// The ID of the machine group. This parameter is returned if the value of **configType** is **collectorDeployMachine**.
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The private endpoint of Kibana after you enable the Kibana dashboard. This parameter is returned if the value of **configType** is **collectorElasticsearchForKibana**.
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("hosts")]
                [Validation(Required=false)]
                public List<string> Hosts { get; set; }

                /// <summary>
                /// The ID of the resource that is associated with the shipper. If the value of **configType** is **collectorTargetInstance**, the value of this parameter is the ID of the resource specified in the output configuration part of the shipper. If the value of **configType** is **collectorDeployMachine** and the value of **type** is **ACKCluster**, the value of this parameter is the ID of the ACK cluster.
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The type of the cluster specified in the output configuration part of the shipper. Valid values: elasticsearch and logstash. This parameter is returned if the value of **configType** is **collectorTargetInstance**.
                /// </summary>
                [NameInMap("instanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The public endpoint of Kibana after you enable the Kibana dashboard. This parameter is returned if the value of **configType** is **collectorElasticsearchForKibana**.
                /// </summary>
                [NameInMap("kibanaHost")]
                [Validation(Required=false)]
                public string KibanaHost { get; set; }

                /// <summary>
                /// The information about the ECS instances on which the shipper is deployed. This parameter is returned if the value of **configType** is **collectorDeployMachine** and the value of **type** is **ECSInstanceId**.
                /// </summary>
                [NameInMap("machines")]
                [Validation(Required=false)]
                public List<UpdateCollectorNameResponseBodyResultExtendConfigsMachines> Machines { get; set; }
                public class UpdateCollectorNameResponseBodyResultExtendConfigsMachines : TeaModel {
                    /// <summary>
                    /// The status of the shipper on the ECS instance. Valid values: **heartOk**, **heartLost**, **uninstalled**, and **failed**.
                    /// </summary>
                    [NameInMap("agentStatus")]
                    [Validation(Required=false)]
                    public string AgentStatus { get; set; }

                    /// <summary>
                    /// The IDs of the ECS instances.
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

                /// <summary>
                /// The transmission protocol. Valid values: **HTTP** and **HTTPS**.
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The number of pods from which data is successfully collected in the ACK cluster. This parameter is returned if the value of **configType** is **collectorDeployMachine** and the value of **type** is **ACKCluster**.
                /// </summary>
                [NameInMap("successPodsCount")]
                [Validation(Required=false)]
                public string SuccessPodsCount { get; set; }

                /// <summary>
                /// The total number of pods from which data is collected in the ACK cluster. This parameter is returned if the value of **configType** is **collectorDeployMachine** and the value of **type** is **ACKCluster**.
                /// </summary>
                [NameInMap("totalPodsCount")]
                [Validation(Required=false)]
                public string TotalPodsCount { get; set; }

                /// <summary>
                /// The type of the machine on which the shipper is deployed. This parameter is returned if the value of **configType** is **collectorDeployMachine**. Valid values:
                /// 
                /// *   ECSInstanceId
                /// *   ACKCluster
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The username that is used to access the resource specified in the output configuration part of the shipper. The default value is elastic. This parameter is returned if the value of **configType** is **collectorTargetInstance** or **collectorElasticsearchForKibana**.
                /// </summary>
                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// The time when the shipper was created.
            /// </summary>
            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }

            /// <summary>
            /// The time when the shipper was updated.
            /// </summary>
            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }

            /// <summary>
            /// The name of the shipper.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The account ID.
            /// </summary>
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// The ID of the shipper.
            /// </summary>
            [NameInMap("resId")]
            [Validation(Required=false)]
            public string ResId { get; set; }

            /// <summary>
            /// The type of the shipper. Valid values: fileBeat, metricBeat, heartBeat, and audiBeat.
            /// </summary>
            [NameInMap("resType")]
            [Validation(Required=false)]
            public string ResType { get; set; }

            /// <summary>
            /// The version of the shipper. The version of a shipper depends on the type of the machine on which the shipper is deployed.
            /// 
            /// *   Elastic Compute Service (ECS) instance: 6.8.5\_with_community
            /// *   Container Service for Kubernetes (ACK) cluster: 6.8.13\_with_community
            /// </summary>
            [NameInMap("resVersion")]
            [Validation(Required=false)]
            public string ResVersion { get; set; }

            /// <summary>
            /// The status of the shipper. Valid values: activating and active.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) where the shipper resides.
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
