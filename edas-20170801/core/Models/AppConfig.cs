// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class AppConfig : TeaModel {
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public List<string> CommandArgs { get; set; }

        [NameInMap("ConfigMountDescs")]
        [Validation(Required=false)]
        public List<AppConfigConfigMountDescs> ConfigMountDescs { get; set; }
        public class AppConfigConfigMountDescs : TeaModel {
            [NameInMap("MountItems")]
            [Validation(Required=false)]
            public List<AppConfigConfigMountDescsMountItems> MountItems { get; set; }
            public class AppConfigConfigMountDescsMountItems : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("DeployAcrossNodes")]
        [Validation(Required=false)]
        public bool? DeployAcrossNodes { get; set; }

        [NameInMap("DeployAcrossZones")]
        [Validation(Required=false)]
        public bool? DeployAcrossZones { get; set; }

        [NameInMap("EmptyDirs")]
        [Validation(Required=false)]
        public List<AppConfigEmptyDirs> EmptyDirs { get; set; }
        public class AppConfigEmptyDirs : TeaModel {
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ReadOnly")]
            [Validation(Required=false)]
            public bool? ReadOnly { get; set; }

            [NameInMap("SubPathExpr")]
            [Validation(Required=false)]
            public string SubPathExpr { get; set; }

        }

        [NameInMap("EnableAhas")]
        [Validation(Required=false)]
        public bool? EnableAhas { get; set; }

        [NameInMap("EnvFroms")]
        [Validation(Required=false)]
        public List<AppConfigEnvFroms> EnvFroms { get; set; }
        public class AppConfigEnvFroms : TeaModel {
            [NameInMap("ConfigMapRef")]
            [Validation(Required=false)]
            public string ConfigMapRef { get; set; }

            [NameInMap("SecretRef")]
            [Validation(Required=false)]
            public string SecretRef { get; set; }

        }

        [NameInMap("Envs")]
        [Validation(Required=false)]
        public List<AppConfigEnvs> Envs { get; set; }
        public class AppConfigEnvs : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("ValueFrom")]
            [Validation(Required=false)]
            public string ValueFrom { get; set; }

        }

        [NameInMap("ImageConfig")]
        [Validation(Required=false)]
        public AppConfigImageConfig ImageConfig { get; set; }
        public class AppConfigImageConfig : TeaModel {
            [NameInMap("ContainerRegistryId")]
            [Validation(Required=false)]
            public string ContainerRegistryId { get; set; }

            [NameInMap("CrInstanceId")]
            [Validation(Required=false)]
            public string CrInstanceId { get; set; }

            [NameInMap("CrRegionId")]
            [Validation(Required=false)]
            public string CrRegionId { get; set; }

            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

        }

        [NameInMap("IsMultilingualApp")]
        [Validation(Required=false)]
        public bool? IsMultilingualApp { get; set; }

        [NameInMap("JavaStartUpConfig")]
        [Validation(Required=false)]
        public string JavaStartUpConfig { get; set; }

        [NameInMap("LimitCpu")]
        [Validation(Required=false)]
        public string LimitCpu { get; set; }

        [NameInMap("LimitMem")]
        [Validation(Required=false)]
        public string LimitMem { get; set; }

        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        [NameInMap("LocalVolumes")]
        [Validation(Required=false)]
        public List<AppConfigLocalVolumes> LocalVolumes { get; set; }
        public class AppConfigLocalVolumes : TeaModel {
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NodePath")]
            [Validation(Required=false)]
            public string NodePath { get; set; }

            [NameInMap("OpsAuth")]
            [Validation(Required=false)]
            public long? OpsAuth { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        [NameInMap("NasMountDescs")]
        [Validation(Required=false)]
        public List<AppConfigNasMountDescs> NasMountDescs { get; set; }
        public class AppConfigNasMountDescs : TeaModel {
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            [NameInMap("NasPath")]
            [Validation(Required=false)]
            public string NasPath { get; set; }

        }

        [NameInMap("NasStorageType")]
        [Validation(Required=false)]
        public string NasStorageType { get; set; }

        [NameInMap("PackageConfig")]
        [Validation(Required=false)]
        public AppConfigPackageConfig PackageConfig { get; set; }
        public class AppConfigPackageConfig : TeaModel {
            [NameInMap("EdasContainerVersion")]
            [Validation(Required=false)]
            public string EdasContainerVersion { get; set; }

            [NameInMap("Jdk")]
            [Validation(Required=false)]
            public string Jdk { get; set; }

            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }

            [NameInMap("Timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            [NameInMap("UriEncoding")]
            [Validation(Required=false)]
            public string UriEncoding { get; set; }

            [NameInMap("UseBodyEncoding")]
            [Validation(Required=false)]
            public bool? UseBodyEncoding { get; set; }

            [NameInMap("WebContainer")]
            [Validation(Required=false)]
            public string WebContainer { get; set; }

        }

        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        [NameInMap("PvcMountDescs")]
        [Validation(Required=false)]
        public List<AppConfigPvcMountDescs> PvcMountDescs { get; set; }
        public class AppConfigPvcMountDescs : TeaModel {
            [NameInMap("MountPaths")]
            [Validation(Required=false)]
            public List<AppConfigPvcMountDescsMountPaths> MountPaths { get; set; }
            public class AppConfigPvcMountDescsMountPaths : TeaModel {
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                [NameInMap("SubPathExpr")]
                [Validation(Required=false)]
                public string SubPathExpr { get; set; }

            }

            [NameInMap("PvcName")]
            [Validation(Required=false)]
            public string PvcName { get; set; }

        }

        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public long? Replicas { get; set; }

        [NameInMap("RequestCpu")]
        [Validation(Required=false)]
        public string RequestCpu { get; set; }

        [NameInMap("RequestMem")]
        [Validation(Required=false)]
        public string RequestMem { get; set; }

        [NameInMap("RuntimeClassName")]
        [Validation(Required=false)]
        public string RuntimeClassName { get; set; }

        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public List<AppConfigSlsConfigs> SlsConfigs { get; set; }
        public class AppConfigSlsConfigs : TeaModel {
            [NameInMap("LogDir")]
            [Validation(Required=false)]
            public string LogDir { get; set; }

            [NameInMap("Logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("WebContainerConfig")]
        [Validation(Required=false)]
        public AppConfigWebContainerConfig WebContainerConfig { get; set; }
        public class AppConfigWebContainerConfig : TeaModel {
            [NameInMap("ConnectorType")]
            [Validation(Required=false)]
            public string ConnectorType { get; set; }

            [NameInMap("ContextInputType")]
            [Validation(Required=false)]
            public string ContextInputType { get; set; }

            [NameInMap("ContextPath")]
            [Validation(Required=false)]
            public string ContextPath { get; set; }

            [NameInMap("HttpPort")]
            [Validation(Required=false)]
            public long? HttpPort { get; set; }

            [NameInMap("MaxThreads")]
            [Validation(Required=false)]
            public long? MaxThreads { get; set; }

            [NameInMap("ServerXml")]
            [Validation(Required=false)]
            public string ServerXml { get; set; }

            [NameInMap("UriEncoding")]
            [Validation(Required=false)]
            public string UriEncoding { get; set; }

            [NameInMap("UseAdvancedServerXml")]
            [Validation(Required=false)]
            public bool? UseAdvancedServerXml { get; set; }

            [NameInMap("UseBodyEncoding")]
            [Validation(Required=false)]
            public bool? UseBodyEncoding { get; set; }

            [NameInMap("UseDefaultConfig")]
            [Validation(Required=false)]
            public bool? UseDefaultConfig { get; set; }

        }

    }

}
