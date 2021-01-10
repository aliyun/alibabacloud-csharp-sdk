// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetAKSContainerservicesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAKSContainerservicesResponseBodyData Data { get; set; }
        public class GetAKSContainerservicesResponseBodyData : TeaModel {
            [NameInMap("DisplayedRevision")]
            [Validation(Required=false)]
            public string DisplayedRevision { get; set; }
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }
            [NameInMap("PodCount")]
            [Validation(Required=false)]
            public long? PodCount { get; set; }
            [NameInMap("ProcessingPodCount")]
            [Validation(Required=false)]
            public long? ProcessingPodCount { get; set; }
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public long? Replicas { get; set; }
            [NameInMap("RunningPodCount")]
            [Validation(Required=false)]
            public long? RunningPodCount { get; set; }
            [NameInMap("ContainerService")]
            [Validation(Required=false)]
            public GetAKSContainerservicesResponseBodyDataContainerService ContainerService { get; set; }
            public class GetAKSContainerservicesResponseBodyDataContainerService : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AppSvcId")]
                [Validation(Required=false)]
                public string AppSvcId { get; set; }

                [NameInMap("AppSvcName")]
                [Validation(Required=false)]
                public string AppSvcName { get; set; }

                [NameInMap("ContainerServiceType")]
                [Validation(Required=false)]
                public string ContainerServiceType { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DraftedRevision")]
                [Validation(Required=false)]
                public string DraftedRevision { get; set; }

                [NameInMap("DraftedTime")]
                [Validation(Required=false)]
                public string DraftedTime { get; set; }

                [NameInMap("EnableBizMonitor")]
                [Validation(Required=false)]
                public bool? EnableBizMonitor { get; set; }

                [NameInMap("EnableMesh")]
                [Validation(Required=false)]
                public bool? EnableMesh { get; set; }

                [NameInMap("EnableSofaMesh")]
                [Validation(Required=false)]
                public bool? EnableSofaMesh { get; set; }

                [NameInMap("OperatorId")]
                [Validation(Required=false)]
                public string OperatorId { get; set; }

                [NameInMap("OperatorName")]
                [Validation(Required=false)]
                public string OperatorName { get; set; }

                [NameInMap("RuntimeRevision")]
                [Validation(Required=false)]
                public string RuntimeRevision { get; set; }

                [NameInMap("UseHostNetwork")]
                [Validation(Required=false)]
                public bool? UseHostNetwork { get; set; }

                [NameInMap("LogConfigs")]
                [Validation(Required=false)]
                public List<GetAKSContainerservicesResponseBodyDataContainerServiceLogConfigs> LogConfigs { get; set; }
                public class GetAKSContainerservicesResponseBodyDataContainerServiceLogConfigs : TeaModel {
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public bool? Created { get; set; }

                    [NameInMap("FilePattern")]
                    [Validation(Required=false)]
                    public string FilePattern { get; set; }

                    [NameInMap("LogConfigPath")]
                    [Validation(Required=false)]
                    public string LogConfigPath { get; set; }

                    [NameInMap("LogPath")]
                    [Validation(Required=false)]
                    public string LogPath { get; set; }

                    [NameInMap("LogStore")]
                    [Validation(Required=false)]
                    public string LogStore { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Published")]
                    [Validation(Required=false)]
                    public bool? Published { get; set; }

                }

                [NameInMap("LifecycleState")]
                [Validation(Required=false)]
                public GetAKSContainerservicesResponseBodyDataContainerServiceLifecycleState LifecycleState { get; set; }
                public class GetAKSContainerservicesResponseBodyDataContainerServiceLifecycleState : TeaModel {
                    [NameInMap("DeploymentState")]
                    [Validation(Required=false)]
                    public string DeploymentState { get; set; }
                    [NameInMap("MetadataState")]
                    [Validation(Required=false)]
                    public string MetadataState { get; set; }
                    [NameInMap("RuntimeState")]
                    [Validation(Required=false)]
                    public string RuntimeState { get; set; }
                };

                [NameInMap("NamespaceScopedEntity")]
                [Validation(Required=false)]
                public GetAKSContainerservicesResponseBodyDataContainerServiceNamespaceScopedEntity NamespaceScopedEntity { get; set; }
                public class GetAKSContainerservicesResponseBodyDataContainerServiceNamespaceScopedEntity : TeaModel {
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }
                    [NameInMap("EnvEntity")]
                    [Validation(Required=false)]
                    public GetAKSContainerservicesResponseBodyDataContainerServiceNamespaceScopedEntityEnvEntity EnvEntity { get; set; }
                    public class GetAKSContainerservicesResponseBodyDataContainerServiceNamespaceScopedEntityEnvEntity : TeaModel {
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("RunEnv")]
                        [Validation(Required=false)]
                        public string RunEnv { get; set; }

                        [NameInMap("TenantId")]
                        [Validation(Required=false)]
                        public string TenantId { get; set; }

                        [NameInMap("WorkspaceId")]
                        [Validation(Required=false)]
                        public string WorkspaceId { get; set; }

                        [NameInMap("Entity")]
                        [Validation(Required=false)]
                        public GetAKSContainerservicesResponseBodyDataContainerServiceNamespaceScopedEntityEnvEntityEntity Entity { get; set; }
                        public class GetAKSContainerservicesResponseBodyDataContainerServiceNamespaceScopedEntityEnvEntityEntity : TeaModel {
                            [NameInMap("CreatedTime")]
                            [Validation(Required=false)]
                            public string CreatedTime { get; set; }
                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }
                            [NameInMap("ModifiedTime")]
                            [Validation(Required=false)]
                            public string ModifiedTime { get; set; }
                        };

                    }
                };

                [NameInMap("PodTemplate")]
                [Validation(Required=false)]
                public GetAKSContainerservicesResponseBodyDataContainerServicePodTemplate PodTemplate { get; set; }
                public class GetAKSContainerservicesResponseBodyDataContainerServicePodTemplate : TeaModel {
                    [NameInMap("ContainerServiceId")]
                    [Validation(Required=false)]
                    public string ContainerServiceId { get; set; }
                    [NameInMap("DnsPolicy")]
                    [Validation(Required=false)]
                    public string DnsPolicy { get; set; }
                    [NameInMap("HostNameTemplate")]
                    [Validation(Required=false)]
                    public string HostNameTemplate { get; set; }
                    [NameInMap("UseHostNetwork")]
                    [Validation(Required=false)]
                    public bool? UseHostNetwork { get; set; }
                    [NameInMap("NamespaceScopedEntity")]
                    [Validation(Required=false)]
                    public GetAKSContainerservicesResponseBodyDataContainerServicePodTemplateNamespaceScopedEntity NamespaceScopedEntity { get; set; }
                    public class GetAKSContainerservicesResponseBodyDataContainerServicePodTemplateNamespaceScopedEntity : TeaModel {
                        [NameInMap("ClusterId")]
                        [Validation(Required=false)]
                        public string ClusterId { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Namespace")]
                        [Validation(Required=false)]
                        public string Namespace { get; set; }

                        [NameInMap("EnvEntity")]
                        [Validation(Required=false)]
                        public GetAKSContainerservicesResponseBodyDataContainerServicePodTemplateNamespaceScopedEntityEnvEntity EnvEntity { get; set; }
                        public class GetAKSContainerservicesResponseBodyDataContainerServicePodTemplateNamespaceScopedEntityEnvEntity : TeaModel {
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }
                            [NameInMap("RunEnv")]
                            [Validation(Required=false)]
                            public string RunEnv { get; set; }
                            [NameInMap("TenantId")]
                            [Validation(Required=false)]
                            public string TenantId { get; set; }
                            [NameInMap("WorkspaceId")]
                            [Validation(Required=false)]
                            public string WorkspaceId { get; set; }
                            [NameInMap("Entity")]
                            [Validation(Required=false)]
                            public GetAKSContainerservicesResponseBodyDataContainerServicePodTemplateNamespaceScopedEntityEnvEntityEntity Entity { get; set; }
                            public class GetAKSContainerservicesResponseBodyDataContainerServicePodTemplateNamespaceScopedEntityEnvEntityEntity : TeaModel {
                                [NameInMap("CreatedTime")]
                                [Validation(Required=false)]
                                public string CreatedTime { get; set; }

                                [NameInMap("Id")]
                                [Validation(Required=false)]
                                public string Id { get; set; }

                                [NameInMap("ModifiedTime")]
                                [Validation(Required=false)]
                                public string ModifiedTime { get; set; }

                            }
                        };

                    }
                };

            }
            [NameInMap("ImageSource")]
            [Validation(Required=false)]
            public GetAKSContainerservicesResponseBodyDataImageSource ImageSource { get; set; }
            public class GetAKSContainerservicesResponseBodyDataImageSource : TeaModel {
                [NameInMap("AppBuildId")]
                [Validation(Required=false)]
                public string AppBuildId { get; set; }

                [NameInMap("BinaryLocalPath")]
                [Validation(Required=false)]
                public string BinaryLocalPath { get; set; }

                [NameInMap("Branch")]
                [Validation(Required=false)]
                public string Branch { get; set; }

                [NameInMap("BuildNumber")]
                [Validation(Required=false)]
                public long? BuildNumber { get; set; }

                [NameInMap("PullSecret")]
                [Validation(Required=false)]
                public string PullSecret { get; set; }

                [NameInMap("Revision")]
                [Validation(Required=false)]
                public string Revision { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("TechStackName")]
                [Validation(Required=false)]
                public string TechStackName { get; set; }

                [NameInMap("TechStackVersionImage")]
                [Validation(Required=false)]
                public string TechStackVersionImage { get; set; }

                [NameInMap("TechStackVersionName")]
                [Validation(Required=false)]
                public string TechStackVersionName { get; set; }

                [NameInMap("TechStackVersionNumber")]
                [Validation(Required=false)]
                public string TechStackVersionNumber { get; set; }

                [NameInMap("BaseImage")]
                [Validation(Required=false)]
                public GetAKSContainerservicesResponseBodyDataImageSourceBaseImage BaseImage { get; set; }
                public class GetAKSContainerservicesResponseBodyDataImageSourceBaseImage : TeaModel {
                    [NameInMap("Digest")]
                    [Validation(Required=false)]
                    public string Digest { get; set; }
                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }
                    [NameInMap("Repository")]
                    [Validation(Required=false)]
                    public string Repository { get; set; }
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }
                };

                [NameInMap("BinaryRemotePath")]
                [Validation(Required=false)]
                public GetAKSContainerservicesResponseBodyDataImageSourceBinaryRemotePath BinaryRemotePath { get; set; }
                public class GetAKSContainerservicesResponseBodyDataImageSourceBinaryRemotePath : TeaModel {
                    [NameInMap("Endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }
                };

                [NameInMap("BuiltImage")]
                [Validation(Required=false)]
                public GetAKSContainerservicesResponseBodyDataImageSourceBuiltImage BuiltImage { get; set; }
                public class GetAKSContainerservicesResponseBodyDataImageSourceBuiltImage : TeaModel {
                    [NameInMap("Digest")]
                    [Validation(Required=false)]
                    public string Digest { get; set; }
                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }
                    [NameInMap("Repository")]
                    [Validation(Required=false)]
                    public string Repository { get; set; }
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }
                };

                [NameInMap("CurrentImage")]
                [Validation(Required=false)]
                public GetAKSContainerservicesResponseBodyDataImageSourceCurrentImage CurrentImage { get; set; }
                public class GetAKSContainerservicesResponseBodyDataImageSourceCurrentImage : TeaModel {
                    [NameInMap("Digest")]
                    [Validation(Required=false)]
                    public string Digest { get; set; }
                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }
                    [NameInMap("Repository")]
                    [Validation(Required=false)]
                    public string Repository { get; set; }
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }
                };

            }
        };

    }

}
