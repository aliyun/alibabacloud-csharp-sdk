// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sApplicationResponseBody : TeaModel {
        /// <summary>
        /// The information about the application.
        /// </summary>
        [NameInMap("Applcation")]
        [Validation(Required=false)]
        public GetK8sApplicationResponseBodyApplcation Applcation { get; set; }
        public class GetK8sApplicationResponseBodyApplcation : TeaModel {
            /// <summary>
            /// The basic information about the application.
            /// </summary>
            [NameInMap("App")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationApp App { get; set; }
            public class GetK8sApplicationResponseBodyApplcationApp : TeaModel {
                /// <summary>
                /// The annotation of an application pod.
                /// </summary>
                [NameInMap("Annotations")]
                [Validation(Required=false)]
                public string Annotations { get; set; }

                /// <summary>
                /// The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see [ListApplication](~~149390~~).
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// The type of the application.
                /// </summary>
                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                /// <summary>
                /// The build package number of Enterprise Distributed Application Service (EDAS) Container.
                /// </summary>
                [NameInMap("BuildpackId")]
                [Validation(Required=false)]
                public int? BuildpackId { get; set; }

                /// <summary>
                /// The ID of the cluster.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The startup command.
                /// </summary>
                [NameInMap("Cmd")]
                [Validation(Required=false)]
                public string Cmd { get; set; }

                /// <summary>
                /// The list of commands.
                /// </summary>
                [NameInMap("CmdArgs")]
                [Validation(Required=false)]
                public GetK8sApplicationResponseBodyApplcationAppCmdArgs CmdArgs { get; set; }
                public class GetK8sApplicationResponseBodyApplcationAppCmdArgs : TeaModel {
                    [NameInMap("CmdArg")]
                    [Validation(Required=false)]
                    public List<string> CmdArg { get; set; }

                }

                /// <summary>
                /// The ID of the cluster to which the container belongs.
                /// </summary>
                [NameInMap("CsClusterId")]
                [Validation(Required=false)]
                public string CsClusterId { get; set; }

                /// <summary>
                /// The deployment type of the application. Example: Image.
                /// </summary>
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                /// <summary>
                /// The application type. Valid values:
                /// 
                /// *   General: native Java application
                /// *   Pandora: Pandora application
                /// *   Multilingual: multilingual application
                /// </summary>
                [NameInMap("DevelopType")]
                [Validation(Required=false)]
                public string DevelopType { get; set; }

                /// <summary>
                /// The version of EDAS Container.
                /// </summary>
                [NameInMap("EdasContainerVersion")]
                [Validation(Required=false)]
                public string EdasContainerVersion { get; set; }

                /// <summary>
                /// Indicates whether the Empty List Protection feature is enabled for the application.
                /// </summary>
                [NameInMap("EnableEmptyPushReject")]
                [Validation(Required=false)]
                public bool? EnableEmptyPushReject { get; set; }

                /// <summary>
                /// Indicates whether the Graceful Release feature is enabled for the application.
                /// </summary>
                [NameInMap("EnableLosslessRule")]
                [Validation(Required=false)]
                public bool? EnableLosslessRule { get; set; }

                /// <summary>
                /// The list of environment variables.
                /// </summary>
                [NameInMap("EnvList")]
                [Validation(Required=false)]
                public GetK8sApplicationResponseBodyApplcationAppEnvList EnvList { get; set; }
                public class GetK8sApplicationResponseBodyApplcationAppEnvList : TeaModel {
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public List<GetK8sApplicationResponseBodyApplcationAppEnvListEnv> Env { get; set; }
                    public class GetK8sApplicationResponseBodyApplcationAppEnvListEnv : TeaModel {
                        /// <summary>
                        /// The name of the environment variable.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The value of the environment variable.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The feature annotations. Possible values:
                /// 
                /// *   base.combination.edas: enables EDAS integrated management solution.
                /// *   base.combination.arms: enables ARMS monitoring.
                /// *   base.combination.mse: enables MSE microservices governance.
                /// *   base.combination.none: enables lifecycle management.
                /// </summary>
                [NameInMap("FeatureAnnotations")]
                [Validation(Required=false)]
                public string FeatureAnnotations { get; set; }

                /// <summary>
                /// The number of application instances.
                /// </summary>
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public int? Instances { get; set; }

                /// <summary>
                /// The number of application instances before the last auto scaling operation.
                /// </summary>
                [NameInMap("InstancesBeforeScaling")]
                [Validation(Required=false)]
                public int? InstancesBeforeScaling { get; set; }

                /// <summary>
                /// The namespace of the Kubernetes cluster.
                /// </summary>
                [NameInMap("K8sNamespace")]
                [Validation(Required=false)]
                public string K8sNamespace { get; set; }

                /// <summary>
                /// The label of an application pod.
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// The maximum number of CPU cores allowed. Unit: millicores. 1,000 millicores equal one CPU core.
                /// </summary>
                [NameInMap("LimitCpuM")]
                [Validation(Required=false)]
                public int? LimitCpuM { get; set; }

                /// <summary>
                /// The maximum size of space required by ephemeral storage. Unit: GB. Value 0 indicates that no limit is set on the space size.
                /// </summary>
                [NameInMap("LimitEphemeralStorage")]
                [Validation(Required=false)]
                public string LimitEphemeralStorage { get; set; }

                /// <summary>
                /// The maximum size of the memory allowed. Unit: MiB.
                /// </summary>
                [NameInMap("LimitMem")]
                [Validation(Required=false)]
                public int? LimitMem { get; set; }

                /// <summary>
                /// Indicates whether the Graceful Rolling Release and Configure Complete Service Registration before Readiness Probing feature is enabled for the application.
                /// </summary>
                [NameInMap("LosslessRuleAligned")]
                [Validation(Required=false)]
                public bool? LosslessRuleAligned { get; set; }

                /// <summary>
                /// The delay of service registration. Unit: seconds.
                /// </summary>
                [NameInMap("LosslessRuleDelayTime")]
                [Validation(Required=false)]
                public int? LosslessRuleDelayTime { get; set; }

                /// <summary>
                /// The number of prefetching curves.
                /// </summary>
                [NameInMap("LosslessRuleFuncType")]
                [Validation(Required=false)]
                public int? LosslessRuleFuncType { get; set; }

                /// <summary>
                /// Indicates whether the Graceful Rolling Release and Configure Complete Service Prefetching before Readiness Probing feature is enabled for the application.
                /// </summary>
                [NameInMap("LosslessRuleRelated")]
                [Validation(Required=false)]
                public bool? LosslessRuleRelated { get; set; }

                /// <summary>
                /// The service prefetching duration. Unit: seconds.
                /// </summary>
                [NameInMap("LosslessRuleWarmupTime")]
                [Validation(Required=false)]
                public int? LosslessRuleWarmupTime { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The number of requested CPU cores. Unit: millicores. 1,000 millicores equal one CPU core.
                /// </summary>
                [NameInMap("RequestCpuM")]
                [Validation(Required=false)]
                public int? RequestCpuM { get; set; }

                /// <summary>
                /// The size of space reserved for ephemeral storage resources. Unit: GB. Value 0 indicates that no limit is set on the space size.
                /// </summary>
                [NameInMap("RequestEphemeralStorage")]
                [Validation(Required=false)]
                public string RequestEphemeralStorage { get; set; }

                /// <summary>
                /// The size of the reserved memory. Unit: MiB.
                /// </summary>
                [NameInMap("RequestMem")]
                [Validation(Required=false)]
                public int? RequestMem { get; set; }

                /// <summary>
                /// The configuration information about the Server Load Balancer (SLB).
                /// </summary>
                [NameInMap("SlbInfo")]
                [Validation(Required=false)]
                public string SlbInfo { get; set; }

                /// <summary>
                /// The version of Apache Tomcat.
                /// </summary>
                [NameInMap("TomcatVersion")]
                [Validation(Required=false)]
                public string TomcatVersion { get; set; }

                /// <summary>
                /// The workload type. Valid values: Deployment and StatefulSet. If you do not specify this parameter, Deployment is used.
                /// </summary>
                [NameInMap("WorkloadType")]
                [Validation(Required=false)]
                public string WorkloadType { get; set; }

            }

            /// <summary>
            /// The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see [ListApplication](~~149390~~).
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The configurations.
            /// </summary>
            [NameInMap("Conf")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationConf Conf { get; set; }
            public class GetK8sApplicationResponseBodyApplcationConf : TeaModel {
                /// <summary>
                /// The affinity configuration of the pod.
                /// </summary>
                [NameInMap("Affinity")]
                [Validation(Required=false)]
                public string Affinity { get; set; }

                /// <summary>
                /// Indicates whether the application is connected to Application High Availability Service (AHAS).
                /// </summary>
                [NameInMap("AhasEnabled")]
                [Validation(Required=false)]
                public bool? AhasEnabled { get; set; }

                /// <summary>
                /// Indicates whether the application instances are deployed across nodes.
                /// 
                /// *   Value `true` indicates that the application instances are deployed across nodes.
                /// *   Other values indicate that the application instances are not deployed across nodes.
                /// </summary>
                [NameInMap("DeployAcrossNodes")]
                [Validation(Required=false)]
                public string DeployAcrossNodes { get; set; }

                /// <summary>
                /// Indicates whether the application instances are deployed across zones.
                /// 
                /// *   Value `true` indicates that the application instances are deployed across zones.
                /// *   Other values indicate that the application instances are not deployed across zones.
                /// </summary>
                [NameInMap("DeployAcrossZones")]
                [Validation(Required=false)]
                public string DeployAcrossZones { get; set; }

                /// <summary>
                /// The startup parameters for a JAR application. This parameter is deprecated.
                /// </summary>
                [NameInMap("JarStartArgs")]
                [Validation(Required=false)]
                public string JarStartArgs { get; set; }

                /// <summary>
                /// The startup options for a JAR application. This parameter is deprecated.
                /// </summary>
                [NameInMap("JarStartOptions")]
                [Validation(Required=false)]
                public string JarStartOptions { get; set; }

                /// <summary>
                /// The startup command.
                /// </summary>
                [NameInMap("K8sCmd")]
                [Validation(Required=false)]
                public string K8sCmd { get; set; }

                /// <summary>
                /// The parameters of the startup command.
                /// </summary>
                [NameInMap("K8sCmdArgs")]
                [Validation(Required=false)]
                public string K8sCmdArgs { get; set; }

                /// <summary>
                /// The information about the local storage.
                /// </summary>
                [NameInMap("K8sLocalvolumeInfo")]
                [Validation(Required=false)]
                public string K8sLocalvolumeInfo { get; set; }

                /// <summary>
                /// The information about the Apsara File Storage NAS (NAS) storage.
                /// </summary>
                [NameInMap("K8sNasInfo")]
                [Validation(Required=false)]
                public string K8sNasInfo { get; set; }

                /// <summary>
                /// The information about the storage.
                /// </summary>
                [NameInMap("K8sVolumeInfo")]
                [Validation(Required=false)]
                public string K8sVolumeInfo { get; set; }

                /// <summary>
                /// The information about the liveness check on the container.
                /// </summary>
                [NameInMap("Liveness")]
                [Validation(Required=false)]
                public string Liveness { get; set; }

                /// <summary>
                /// The script executed after the container is started.
                /// </summary>
                [NameInMap("PostStart")]
                [Validation(Required=false)]
                public string PostStart { get; set; }

                /// <summary>
                /// The script executed before the container is stopped.
                /// </summary>
                [NameInMap("PreStop")]
                [Validation(Required=false)]
                public string PreStop { get; set; }

                /// <summary>
                /// The information about the readiness check on the container.
                /// </summary>
                [NameInMap("Readiness")]
                [Validation(Required=false)]
                public string Readiness { get; set; }

                /// <summary>
                /// The type of the container runtime. This parameter is applicable only to clusters that use sandboxed containers.
                /// </summary>
                [NameInMap("RuntimeClassName")]
                [Validation(Required=false)]
                public string RuntimeClassName { get; set; }

                /// <summary>
                /// The scheduling tolerance configuration of the pod.
                /// </summary>
                [NameInMap("Tolerations")]
                [Validation(Required=false)]
                public string Tolerations { get; set; }

                /// <summary>
                /// The URL of the base image. If you use a custom Java Development Kit (JDK) runtime, you must specify this parameter.
                /// </summary>
                [NameInMap("UserBaseImageUrl")]
                [Validation(Required=false)]
                public string UserBaseImageUrl { get; set; }

            }

            /// <summary>
            /// The information about the instance group in which the application is deployed.
            /// </summary>
            [NameInMap("DeployGroups")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationDeployGroups DeployGroups { get; set; }
            public class GetK8sApplicationResponseBodyApplcationDeployGroups : TeaModel {
                [NameInMap("DeployGroup")]
                [Validation(Required=false)]
                public List<GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroup> DeployGroup { get; set; }
                public class GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroup : TeaModel {
                    /// <summary>
                    /// The information about the component.
                    /// </summary>
                    [NameInMap("Components")]
                    [Validation(Required=false)]
                    public GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponents Components { get; set; }
                    public class GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponents : TeaModel {
                        [NameInMap("Components")]
                        [Validation(Required=false)]
                        public List<GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponentsComponents> Components { get; set; }
                        public class GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponentsComponents : TeaModel {
                            /// <summary>
                            /// The component ID.
                            /// </summary>
                            [NameInMap("ComponentId")]
                            [Validation(Required=false)]
                            public string ComponentId { get; set; }

                            /// <summary>
                            /// The keyword that is included in the component name.
                            /// </summary>
                            [NameInMap("ComponentKey")]
                            [Validation(Required=false)]
                            public string ComponentKey { get; set; }

                            /// <summary>
                            /// The component type. Valid values:
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                    /// <summary>
                    /// The environment variable. This parameter is different from the EnvList parameter. This parameter specifies the referenced configuration of the ConfigMap or Secret.
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// The source of the environment variable.
                    /// </summary>
                    [NameInMap("EnvFrom")]
                    [Validation(Required=false)]
                    public string EnvFrom { get; set; }

                }

            }

            /// <summary>
            /// The information about the image.
            /// </summary>
            [NameInMap("ImageInfo")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationImageInfo ImageInfo { get; set; }
            public class GetK8sApplicationResponseBodyApplcationImageInfo : TeaModel {
                /// <summary>
                /// The URL of the image.
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// The region ID of the image repository.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the image repository.
                /// </summary>
                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public string RepoId { get; set; }

                /// <summary>
                /// The name of the image repository.
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// The namespace to which the image repository belongs.
                /// </summary>
                [NameInMap("RepoNamespace")]
                [Validation(Required=false)]
                public string RepoNamespace { get; set; }

                /// <summary>
                /// The source type of the image repository.
                /// </summary>
                [NameInMap("RepoOriginType")]
                [Validation(Required=false)]
                public string RepoOriginType { get; set; }

                /// <summary>
                /// The tag of the image.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// The information about the latest version.
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationLatestVersion LatestVersion { get; set; }
            public class GetK8sApplicationResponseBodyApplcationLatestVersion : TeaModel {
                /// <summary>
                /// The version of the deployment package.
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// The URL of the deployment package. This parameter is required if you use a FatJar or WAR package to deploy the application.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// The URL of the deployment package. This parameter is required if you use a FatJar or WAR package to deploy the application.
                /// </summary>
                [NameInMap("WarUrl")]
                [Validation(Required=false)]
                public string WarUrl { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
