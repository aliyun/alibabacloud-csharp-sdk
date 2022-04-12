/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class AppConfig : TeaModel {
        /// <summary>
        /// 启动命令
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// 启动参数
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public List<string> CommandArgs { get; set; }

        /// <summary>
        /// 配置项挂载配置
        /// </summary>
        [NameInMap("ConfigMountDescs")]
        [Validation(Required=false)]
        public List<AppConfigConfigMountDescs> ConfigMountDescs { get; set; }
        public class AppConfigConfigMountDescs : TeaModel {
            /// <summary>
            /// 挂载条目
            /// </summary>
            [NameInMap("MountItems")]
            [Validation(Required=false)]
            public List<AppConfigConfigMountDescsMountItems> MountItems { get; set; }
            public class AppConfigConfigMountDescsMountItems : TeaModel {
                /// <summary>
                /// 配置项
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// 路径
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// 挂载路径
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 类型
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 是否尽量多节点部署
        /// </summary>
        [NameInMap("DeployAcrossNodes")]
        [Validation(Required=false)]
        public bool? DeployAcrossNodes { get; set; }

        /// <summary>
        /// 是否尽量多可用区部署
        /// </summary>
        [NameInMap("DeployAcrossZones")]
        [Validation(Required=false)]
        public bool? DeployAcrossZones { get; set; }

        /// <summary>
        /// EmptyDir挂载配置
        /// </summary>
        [NameInMap("EmptyDirs")]
        [Validation(Required=false)]
        public List<AppConfigEmptyDirs> EmptyDirs { get; set; }
        public class AppConfigEmptyDirs : TeaModel {
            /// <summary>
            /// 挂载路径
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// 容器名称
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 是否只读
            /// </summary>
            [NameInMap("ReadOnly")]
            [Validation(Required=false)]
            public bool? ReadOnly { get; set; }

            /// <summary>
            /// 子路径表达式
            /// </summary>
            [NameInMap("SubPathExpr")]
            [Validation(Required=false)]
            public string SubPathExpr { get; set; }

        }

        /// <summary>
        /// 是否开启限流降级
        /// </summary>
        [NameInMap("EnableAhas")]
        [Validation(Required=false)]
        public bool? EnableAhas { get; set; }

        /// <summary>
        /// 环境变量引用
        /// </summary>
        [NameInMap("EnvFroms")]
        [Validation(Required=false)]
        public List<AppConfigEnvFroms> EnvFroms { get; set; }
        public class AppConfigEnvFroms : TeaModel {
            /// <summary>
            /// 配置项引用
            /// </summary>
            [NameInMap("ConfigMapRef")]
            [Validation(Required=false)]
            public string ConfigMapRef { get; set; }

            /// <summary>
            /// 保密字典引用
            /// </summary>
            [NameInMap("SecretRef")]
            [Validation(Required=false)]
            public string SecretRef { get; set; }

        }

        /// <summary>
        /// 环境变量
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public List<AppConfigEnvs> Envs { get; set; }
        public class AppConfigEnvs : TeaModel {
            /// <summary>
            /// 变量名
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 变量值
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// 变量引用
            /// </summary>
            [NameInMap("ValueFrom")]
            [Validation(Required=false)]
            public string ValueFrom { get; set; }

        }

        /// <summary>
        /// 镜像配置
        /// </summary>
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
        };

        /// <summary>
        /// 是否多语言应用
        /// </summary>
        [NameInMap("IsMultilingualApp")]
        [Validation(Required=false)]
        public bool? IsMultilingualApp { get; set; }

        /// <summary>
        /// Java启动参数配置
        /// </summary>
        [NameInMap("JavaStartUpConfig")]
        [Validation(Required=false)]
        public string JavaStartUpConfig { get; set; }

        /// <summary>
        /// CPU限制
        /// </summary>
        [NameInMap("LimitCpu")]
        [Validation(Required=false)]
        public string LimitCpu { get; set; }

        /// <summary>
        /// 内存限制
        /// </summary>
        [NameInMap("LimitMem")]
        [Validation(Required=false)]
        public string LimitMem { get; set; }

        /// <summary>
        /// liveness探针配置
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
        /// 本地磁盘挂载配置
        /// </summary>
        [NameInMap("LocalVolumes")]
        [Validation(Required=false)]
        public List<AppConfigLocalVolumes> LocalVolumes { get; set; }
        public class AppConfigLocalVolumes : TeaModel {
            /// <summary>
            /// 容器挂载路径
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 节点路径
            /// </summary>
            [NameInMap("NodePath")]
            [Validation(Required=false)]
            public string NodePath { get; set; }

            /// <summary>
            /// 权限类型
            /// </summary>
            [NameInMap("OpsAuth")]
            [Validation(Required=false)]
            public long? OpsAuth { get; set; }

            /// <summary>
            /// 类型
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// NAS实例ID
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        /// <summary>
        /// NAS挂载配置
        /// </summary>
        [NameInMap("NasMountDescs")]
        [Validation(Required=false)]
        public List<AppConfigNasMountDescs> NasMountDescs { get; set; }
        public class AppConfigNasMountDescs : TeaModel {
            /// <summary>
            /// NAS挂载路径
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// NAS文件路径
            /// </summary>
            [NameInMap("NasPath")]
            [Validation(Required=false)]
            public string NasPath { get; set; }

        }

        /// <summary>
        /// NAS存储类型
        /// </summary>
        [NameInMap("NasStorageType")]
        [Validation(Required=false)]
        public string NasStorageType { get; set; }

        /// <summary>
        /// 部署包配置
        /// </summary>
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
        };

        /// <summary>
        /// postStart挂钩配置
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// preStop挂钩配置
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// 持久化存储挂载配置
        /// </summary>
        [NameInMap("PvcMountDescs")]
        [Validation(Required=false)]
        public List<AppConfigPvcMountDescs> PvcMountDescs { get; set; }
        public class AppConfigPvcMountDescs : TeaModel {
            /// <summary>
            /// 持久化存储挂载路径列表
            /// </summary>
            [NameInMap("MountPaths")]
            [Validation(Required=false)]
            public List<AppConfigPvcMountDescsMountPaths> MountPaths { get; set; }
            public class AppConfigPvcMountDescsMountPaths : TeaModel {
                /// <summary>
                /// 挂载路径
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// 是否只读
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// 子路径表达式
                /// </summary>
                [NameInMap("SubPathExpr")]
                [Validation(Required=false)]
                public string SubPathExpr { get; set; }

            }

            /// <summary>
            /// 持久化存储名称
            /// </summary>
            [NameInMap("PvcName")]
            [Validation(Required=false)]
            public string PvcName { get; set; }

        }

        /// <summary>
        /// readiness探针配置
        /// </summary>
        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        /// <summary>
        /// 应用实例数
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public long? Replicas { get; set; }

        /// <summary>
        /// CPU需求
        /// </summary>
        [NameInMap("RequestCpu")]
        [Validation(Required=false)]
        public string RequestCpu { get; set; }

        /// <summary>
        /// 内存需求
        /// </summary>
        [NameInMap("RequestMem")]
        [Validation(Required=false)]
        public string RequestMem { get; set; }

        /// <summary>
        /// 运行时类型
        /// </summary>
        [NameInMap("RuntimeClassName")]
        [Validation(Required=false)]
        public string RuntimeClassName { get; set; }

        /// <summary>
        /// 日志采集配置
        /// </summary>
        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public List<AppConfigSlsConfigs> SlsConfigs { get; set; }
        public class AppConfigSlsConfigs : TeaModel {
            /// <summary>
            /// 日志目录
            /// </summary>
            [NameInMap("LogDir")]
            [Validation(Required=false)]
            public string LogDir { get; set; }

            /// <summary>
            /// 日志存储
            /// </summary>
            [NameInMap("Logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// 日志项目
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// 类型
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// Tomcat配置
        /// </summary>
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
        };

    }

}
