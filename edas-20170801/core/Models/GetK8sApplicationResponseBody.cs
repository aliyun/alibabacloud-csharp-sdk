// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sApplicationResponseBody : TeaModel {
        [NameInMap("Applcation")]
        [Validation(Required=false)]
        public GetK8sApplicationResponseBodyApplcation Applcation { get; set; }
        public class GetK8sApplicationResponseBodyApplcation : TeaModel {
            [NameInMap("App")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationApp App { get; set; }
            public class GetK8sApplicationResponseBodyApplcationApp : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                [NameInMap("BuildpackId")]
                [Validation(Required=false)]
                public int? BuildpackId { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("Cmd")]
                [Validation(Required=false)]
                public string Cmd { get; set; }

                [NameInMap("CmdArgs")]
                [Validation(Required=false)]
                public GetK8sApplicationResponseBodyApplcationAppCmdArgs CmdArgs { get; set; }
                public class GetK8sApplicationResponseBodyApplcationAppCmdArgs : TeaModel {
                    [NameInMap("CmdArg")]
                    [Validation(Required=false)]
                    public List<string> CmdArg { get; set; }
                };

                [NameInMap("CsClusterId")]
                [Validation(Required=false)]
                public string CsClusterId { get; set; }

                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                [NameInMap("DevelopType")]
                [Validation(Required=false)]
                public string DevelopType { get; set; }

                [NameInMap("EdasContainerVersion")]
                [Validation(Required=false)]
                public string EdasContainerVersion { get; set; }

                [NameInMap("EnvList")]
                [Validation(Required=false)]
                public GetK8sApplicationResponseBodyApplcationAppEnvList EnvList { get; set; }
                public class GetK8sApplicationResponseBodyApplcationAppEnvList : TeaModel {
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public List<GetK8sApplicationResponseBodyApplcationAppEnvListEnv> Env { get; set; }
                    public class GetK8sApplicationResponseBodyApplcationAppEnvListEnv : TeaModel {
                        public string Name { get; set; }
                        public string Value { get; set; }
                    }
                };

                [NameInMap("Instances")]
                [Validation(Required=false)]
                public int? Instances { get; set; }

                [NameInMap("InstancesBeforeScaling")]
                [Validation(Required=false)]
                public int? InstancesBeforeScaling { get; set; }

                [NameInMap("K8sNamespace")]
                [Validation(Required=false)]
                public string K8sNamespace { get; set; }

                [NameInMap("LimitCpuM")]
                [Validation(Required=false)]
                public int? LimitCpuM { get; set; }

                [NameInMap("LimitMem")]
                [Validation(Required=false)]
                public int? LimitMem { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RequestCpuM")]
                [Validation(Required=false)]
                public int? RequestCpuM { get; set; }

                [NameInMap("RequestMem")]
                [Validation(Required=false)]
                public int? RequestMem { get; set; }

                [NameInMap("TomcatVersion")]
                [Validation(Required=false)]
                public string TomcatVersion { get; set; }

            }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("Conf")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationConf Conf { get; set; }
            public class GetK8sApplicationResponseBodyApplcationConf : TeaModel {
                [NameInMap("Affinity")]
                [Validation(Required=false)]
                public string Affinity { get; set; }

                [NameInMap("AhasEnabled")]
                [Validation(Required=false)]
                public bool? AhasEnabled { get; set; }

                [NameInMap("DeployAcrossNodes")]
                [Validation(Required=false)]
                public string DeployAcrossNodes { get; set; }

                [NameInMap("DeployAcrossZones")]
                [Validation(Required=false)]
                public string DeployAcrossZones { get; set; }

                [NameInMap("JarStartArgs")]
                [Validation(Required=false)]
                public string JarStartArgs { get; set; }

                [NameInMap("JarStartOptions")]
                [Validation(Required=false)]
                public string JarStartOptions { get; set; }

                [NameInMap("K8sCmd")]
                [Validation(Required=false)]
                public string K8sCmd { get; set; }

                [NameInMap("K8sCmdArgs")]
                [Validation(Required=false)]
                public string K8sCmdArgs { get; set; }

                [NameInMap("K8sLocalvolumeInfo")]
                [Validation(Required=false)]
                public string K8sLocalvolumeInfo { get; set; }

                [NameInMap("K8sNasInfo")]
                [Validation(Required=false)]
                public string K8sNasInfo { get; set; }

                [NameInMap("K8sVolumeInfo")]
                [Validation(Required=false)]
                public string K8sVolumeInfo { get; set; }

                [NameInMap("Liveness")]
                [Validation(Required=false)]
                public string Liveness { get; set; }

                [NameInMap("PostStart")]
                [Validation(Required=false)]
                public string PostStart { get; set; }

                [NameInMap("PreStop")]
                [Validation(Required=false)]
                public string PreStop { get; set; }

                [NameInMap("Readiness")]
                [Validation(Required=false)]
                public string Readiness { get; set; }

                [NameInMap("RuntimeClassName")]
                [Validation(Required=false)]
                public string RuntimeClassName { get; set; }

                [NameInMap("Tolerations")]
                [Validation(Required=false)]
                public string Tolerations { get; set; }

            }
            [NameInMap("DeployGroups")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationDeployGroups DeployGroups { get; set; }
            public class GetK8sApplicationResponseBodyApplcationDeployGroups : TeaModel {
                [NameInMap("DeployGroup")]
                [Validation(Required=false)]
                public List<GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroup> DeployGroup { get; set; }
                public class GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroup : TeaModel {
                    [NameInMap("Components")]
                    [Validation(Required=false)]
                    public GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponents Components { get; set; }
                    public class GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponents : TeaModel {
                        [NameInMap("Components")]
                        [Validation(Required=false)]
                        public List<GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponentsComponents> Components { get; set; }
                        public class GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponentsComponents : TeaModel {
                            public string ComponentId { get; set; }
                            public string ComponentKey { get; set; }
                            public string Type { get; set; }
                        }
                    };

                }

            }
            [NameInMap("ImageInfo")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationImageInfo ImageInfo { get; set; }
            public class GetK8sApplicationResponseBodyApplcationImageInfo : TeaModel {
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public string RepoId { get; set; }

                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                [NameInMap("RepoNamespace")]
                [Validation(Required=false)]
                public string RepoNamespace { get; set; }

                [NameInMap("RepoOriginType")]
                [Validation(Required=false)]
                public string RepoOriginType { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationLatestVersion LatestVersion { get; set; }
            public class GetK8sApplicationResponseBodyApplcationLatestVersion : TeaModel {
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("WarUrl")]
                [Validation(Required=false)]
                public string WarUrl { get; set; }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
