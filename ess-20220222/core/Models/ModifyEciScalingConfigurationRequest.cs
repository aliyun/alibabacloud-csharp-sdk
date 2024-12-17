// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyEciScalingConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The Container Registry Enterprise Edition instances.</para>
        /// </summary>
        [NameInMap("AcrRegistryInfos")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestAcrRegistryInfos> AcrRegistryInfos { get; set; }
        public class ModifyEciScalingConfigurationRequestAcrRegistryInfos : TeaModel {
            /// <summary>
            /// <para>The domain names of the Container Registry Enterprise Edition instance. By default, all domain names of the instance are displayed. Separate multiple domain names with commas (,).</para>
            /// </summary>
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }

            /// <summary>
            /// <para>The ID of the Container Registry Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-nwj395hgf6f3****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the Container Registry Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acr-test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The region ID of the Container Registry Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The validity period of the scaling configuration. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ActiveDeadlineSeconds")]
        [Validation(Required=false)]
        public long? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create elastic IP addresses (EIPs) and bind the EIPs to elastic container instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoCreateEip")]
        [Validation(Required=false)]
        public bool? AutoCreateEip { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically match image caches.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoMatchImageCache")]
        [Validation(Required=false)]
        public bool? AutoMatchImageCache { get; set; }

        /// <summary>
        /// <para>The name series of elastic container instances. Naming conventions:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name can contain only lowercase letters, digits, and hyphens (-). The name cannot start or end with a hyphen (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>nginx-test</para>
        /// </summary>
        [NameInMap("ContainerGroupName")]
        [Validation(Required=false)]
        public string ContainerGroupName { get; set; }

        /// <summary>
        /// <para>The containers.</para>
        /// </summary>
        [NameInMap("Containers")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestContainers> Containers { get; set; }
        public class ModifyEciScalingConfigurationRequestContainers : TeaModel {
            [NameInMap("LivenessProbe")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestContainersLivenessProbe LivenessProbe { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersLivenessProbe : TeaModel {
                [NameInMap("Exec")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersLivenessProbeExec Exec { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersLivenessProbeExec : TeaModel {
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersLivenessProbeHttpGet HttpGet { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersLivenessProbeHttpGet : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("Scheme")]
                    [Validation(Required=false)]
                    public string Scheme { get; set; }

                }

                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                [NameInMap("TcpSocket")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersLivenessProbeTcpSocket TcpSocket { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersLivenessProbeTcpSocket : TeaModel {
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }

                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

            }

            [NameInMap("ReadinessProbe")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestContainersReadinessProbe ReadinessProbe { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersReadinessProbe : TeaModel {
                [NameInMap("Exec")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersReadinessProbeExec Exec { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersReadinessProbeExec : TeaModel {
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersReadinessProbeHttpGet HttpGet { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersReadinessProbeHttpGet : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("Scheme")]
                    [Validation(Required=false)]
                    public string Scheme { get; set; }

                }

                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                [NameInMap("TcpSocket")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersReadinessProbeTcpSocket TcpSocket { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersReadinessProbeTcpSocket : TeaModel {
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }

                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

            }

            [NameInMap("SecurityContext")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestContainersSecurityContext SecurityContext { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersSecurityContextCapability Capability { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersSecurityContextCapability : TeaModel {
                    [NameInMap("Adds")]
                    [Validation(Required=false)]
                    public List<string> Adds { get; set; }

                }

                [NameInMap("ReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? ReadOnlyRootFilesystem { get; set; }

                [NameInMap("RunAsUser")]
                [Validation(Required=false)]
                public long? RunAsUser { get; set; }

            }

            /// <summary>
            /// <para>The container startup arguments. You can specify up to 10 arguments.</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public List<string> Args { get; set; }

            /// <summary>
            /// <para>The commands that you can run in the container when you use the CLI to perform a liveness probe.</para>
            /// </summary>
            [NameInMap("Commands")]
            [Validation(Required=false)]
            public List<string> Commands { get; set; }

            /// <summary>
            /// <para>The number of vCPUs per container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// <para>The environment variables.</para>
            /// </summary>
            [NameInMap("EnvironmentVars")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestContainersEnvironmentVars> EnvironmentVars { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersEnvironmentVars : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersEnvironmentVarsFieldRef FieldRef { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersEnvironmentVarsFieldRef : TeaModel {
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }

                }

                /// <summary>
                /// <para>The name of the environment variable. The name can be 1 to 128 characters in length, and can contain letters, underscores (_), and digits. The name cannot start with a digit. Specify the value in the <c>[0-9a-zA-Z]</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PATH</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the environment variable. The value can be up to 256 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/local/bin</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The number of GPUs per container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            /// <summary>
            /// <para>The container image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/eci_open/nginx:latest</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The image pulling policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Always: Image pulling is performed each time instances are created.</description></item>
            /// <item><description>IfNotPresent: Image pulling is performed as needed. On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.</description></item>
            /// <item><description>Never: On-premises images are always used. Image pulling is not performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Always</para>
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// <para>The commands that you can run within the container to configure the postStart callback function.</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerExecs")]
            [Validation(Required=false)]
            public List<string> LifecyclePostStartHandlerExecs { get; set; }

            /// <summary>
            /// <para>The IP address of the host to which you want to send the HTTP GET request to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetHost { get; set; }

            /// <summary>
            /// <para>The path to which you want to send the HTTP GET request to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthyz</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetPath { get; set; }

            /// <summary>
            /// <para>The port over which you want to send the HTTP GET request to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5050</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerHttpGetPort { get; set; }

            /// <summary>
            /// <para>The protocol type of the HTTP GET request that you want to send to configure the postStart callback function. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HTTP</description></item>
            /// <item><description>HTTPS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTPS</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetScheme { get; set; }

            /// <summary>
            /// <para>The IP address of the host detected by the TCP socket that you want to use to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// <para>The port detected by the TCP socket that you want to use to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// <para>The commands that you can run within the container to configure the preStop callback function.</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerExecs")]
            [Validation(Required=false)]
            public List<string> LifecyclePreStopHandlerExecs { get; set; }

            /// <summary>
            /// <para>The IP address of the host to which you want to send the HTTP GET request to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetHost { get; set; }

            /// <summary>
            /// <para>The path to which you want to send the HTTP GET request to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthyz</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetPath { get; set; }

            /// <summary>
            /// <para>The port over which you want to send the HTTP GET request to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerHttpGetPort { get; set; }

            /// <summary>
            /// <para>The protocol type of the HTTP GET request that you want to send to configure the preStop callback function. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HTTP</description></item>
            /// <item><description>HTTPS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetScheme { get; set; }

            /// <summary>
            /// <para>The IP address of the host detected by the TCP socket that you want to use to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// <para>The port detected by the TCP socket that you want to use to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// <para>The memory size per container. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The name of the container image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nginx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ports.</para>
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestContainersPorts> Ports { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersPorts : TeaModel {
                /// <summary>
                /// <para>The port number. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TCP</description></item>
                /// <item><description>UDP</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the container allocates buffer resources to standard input streams during its active runtime. If you do not specify this parameter, an end-of-file (EOF) error occurs when standard input streams in the container are read.</para>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Stdin")]
            [Validation(Required=false)]
            public bool? Stdin { get; set; }

            /// <summary>
            /// <para>Specifies whether standard input streams remain connected during multiple sessions when StdinOnce is set to true.</para>
            /// <para>If you set StdinOnce to true, standard input streams are connected after the container is started, and remain idle until a client is connected to receive data. After the client is disconnected, streams are also disconnected and remain disconnected until the container is restarted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("StdinOnce")]
            [Validation(Required=false)]
            public bool? StdinOnce { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable Interaction. Default value: false.</para>
            /// <para>If the command is a /bin/bash command, set this parameter to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Tty")]
            [Validation(Required=false)]
            public bool? Tty { get; set; }

            /// <summary>
            /// <para>The volume mounts of the container.</para>
            /// </summary>
            [NameInMap("VolumeMounts")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestContainersVolumeMounts> VolumeMounts { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersVolumeMounts : TeaModel {
                /// <summary>
                /// <para>The directory within the container onto which you want to mount the volume.</para>
                /// <remarks>
                /// <para> The information stored within this directory is overwritten by the data on the mounted volume. Exercise caution when you specify this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>/pod/data</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The mount propagation settings of the volume. Mount propagation enables volumes mounted on one container to be shared among other containers within the same pod or across distinct pods residing on the same node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>None: Subsequent mounts executed on the volume or its subdirectories do not propagate to the volume.</description></item>
                /// <item><description>HostToCotainer: Subsequent mounts executed on the volume or its subdirectories propagate to the volume.</description></item>
                /// <item><description>Bidirectional: This value is similar to HostToCotainer. Subsequent mounts executed on the volume or its subdirectories propagate to the volume. In addition, volume mounts executed on the container propagate back to the underlying instance and to all containers across every pod that uses the same volume.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("MountPropagation")]
                [Validation(Required=false)]
                public string MountPropagation { get; set; }

                /// <summary>
                /// <para>The volume name. The value of this parameter is the same as the name of the volume that is mounted to containers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default-volume1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Specifies whether the volume is read-only.</para>
                /// <para>Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The volume subdirectory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data2/</para>
                /// </summary>
                [NameInMap("SubPath")]
                [Validation(Required=false)]
                public string SubPath { get; set; }

            }

            /// <summary>
            /// <para>The working directory of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local/</para>
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// <para>The update mode of containers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RenewUpdate: full update mode. This value takes effect based on the value of Containers in an update request. This value indicates that the previous setting of Containers is overwritten.</description></item>
        /// <item><description>IncrementalUpdate: incremental update mode. Container matching is performed based on the Container.name value. Only the parameters that are included in the request parameters are updated.</description></item>
        /// </list>
        /// <para>Default value: RenewUpdate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RenewUpdate</para>
        /// </summary>
        [NameInMap("ContainersUpdateType")]
        [Validation(Required=false)]
        public string ContainersUpdateType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Cost Optimization feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CostOptimization")]
        [Validation(Required=false)]
        public bool? CostOptimization { get; set; }

        /// <summary>
        /// <para>The number of vCPUs per elastic container instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The number of physical CPU cores. You can specify this parameter for only specific ECS instance types. For more information, see <a href="https://help.aliyun.com/document_detail/197781.html">Specify CPU options</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CpuOptionsCore")]
        [Validation(Required=false)]
        public int? CpuOptionsCore { get; set; }

        /// <summary>
        /// <para>The number of threads per core. You can specify this parameter for only specific instance types. A value of 1 specifies that Hyper-Threading is disabled. For more information, see <a href="https://help.aliyun.com/document_detail/197781.html">Specify CPU options</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CpuOptionsThreadsPerCore")]
        [Validation(Required=false)]
        public int? CpuOptionsThreadsPerCore { get; set; }

        /// <summary>
        /// <para>The bucket in which data caches are stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("DataCacheBucket")]
        [Validation(Required=false)]
        public string DataCacheBucket { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Performance Burst feature for the ESSD AutoPL disk in which data caches are stored. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para> For more information about ESSD AutoPL disks, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DataCacheBurstingEnabled")]
        [Validation(Required=false)]
        public bool? DataCacheBurstingEnabled { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the cloud disk in which data caches are stored. We recommend that you use Enterprise SSDs (ESSDs). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: An ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: An ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
        /// <item><description>PL2: An ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
        /// <item><description>PL3: An ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// <para>Default value: PL1.</para>
        /// <remarks>
        /// <para> For more information about ESSDs, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("DataCachePL")]
        [Validation(Required=false)]
        public string DataCachePL { get; set; }

        /// <summary>
        /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk in which data caches are stored. Valid values: 0 to min{50,000, 1,000 × *Capacity - Baseline IOPS}. Baseline IOPS = min{1,800+50 x *Capacity, 50,000}.</para>
        /// <remarks>
        /// <para> For more information about ESSD AutoPL disks, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>40000</para>
        /// </summary>
        [NameInMap("DataCacheProvisionedIops")]
        [Validation(Required=false)]
        public int? DataCacheProvisionedIops { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is unavailable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IP addresses of DNS servers.</para>
        /// </summary>
        [NameInMap("DnsConfigNameServers")]
        [Validation(Required=false)]
        public List<string> DnsConfigNameServers { get; set; }

        /// <summary>
        /// <para>The options. Each option is a name-value pair. The value in the name-value pair is optional.</para>
        /// </summary>
        [NameInMap("DnsConfigOptions")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestDnsConfigOptions> DnsConfigOptions { get; set; }
        public class ModifyEciScalingConfigurationRequestDnsConfigOptions : TeaModel {
            /// <summary>
            /// <para>The variable name of the option.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The variable value of the option.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The search domains of DNS servers.</para>
        /// </summary>
        [NameInMap("DnsConfigSearchs")]
        [Validation(Required=false)]
        public List<string> DnsConfigSearchs { get; set; }

        /// <summary>
        /// <para>The Domain Name System (DNS) policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None: uses the DNS that is specified by DnsConfig.</description></item>
        /// <item><description>Default: uses the DNS that is specified for the runtime environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("DnsPolicy")]
        [Validation(Required=false)]
        public string DnsPolicy { get; set; }

        /// <summary>
        /// <para>The maximum outbound bandwidth. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024000</para>
        /// </summary>
        [NameInMap("EgressBandwidth")]
        [Validation(Required=false)]
        public long? EgressBandwidth { get; set; }

        /// <summary>
        /// <para>The EIP bandwidth.</para>
        /// <para>Default value: 5. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("EipBandwidth")]
        [Validation(Required=false)]
        public int? EipBandwidth { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is not available for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSls")]
        [Validation(Required=false)]
        public bool? EnableSls { get; set; }

        /// <summary>
        /// <para>The size of the temporary storage space. By default, an Enterprise SSD (ESSD) of the PL1 type is used. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("EphemeralStorage")]
        [Validation(Required=false)]
        public int? EphemeralStorage { get; set; }

        /// <summary>
        /// <para>The version of the GPU driver. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tesla=470.82.01 (default)</description></item>
        /// <item><description>tesla=525.85.12</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can switch the GPU driver version only for a few Elastic Compute Service (ECS) instance types. For more information, see <a href="https://help.aliyun.com/document_detail/2579486.html">Specify GPU-accelerated ECS instance types to create an elastic container instance</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tesla=525.85.12</para>
        /// </summary>
        [NameInMap("GpuDriverVersion")]
        [Validation(Required=false)]
        public string GpuDriverVersion { get; set; }

        /// <summary>
        /// <para>The hosts.</para>
        /// </summary>
        [NameInMap("HostAliases")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestHostAliases> HostAliases { get; set; }
        public class ModifyEciScalingConfigurationRequestHostAliases : TeaModel {
            /// <summary>
            /// <para>The names of the hosts that you want to add.</para>
            /// </summary>
            [NameInMap("Hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            /// <summary>
            /// <para>The IP address that you want to add.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        /// <summary>
        /// <para>The hostname series of elastic container instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The image repositories.</para>
        /// </summary>
        [NameInMap("ImageRegistryCredentials")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestImageRegistryCredentials> ImageRegistryCredentials { get; set; }
        public class ModifyEciScalingConfigurationRequestImageRegistryCredentials : TeaModel {
            /// <summary>
            /// <para>The password of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourpaasword</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The address of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// <para>The username of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourusername</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the image cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imc-2zebxkiifuyzzlhl****</para>
        /// </summary>
        [NameInMap("ImageSnapshotId")]
        [Validation(Required=false)]
        public string ImageSnapshotId { get; set; }

        /// <summary>
        /// <para>The maximum inbound bandwidth. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024000</para>
        /// </summary>
        [NameInMap("IngressBandwidth")]
        [Validation(Required=false)]
        public long? IngressBandwidth { get; set; }

        /// <summary>
        /// <para>The init containers.</para>
        /// </summary>
        [NameInMap("InitContainers")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestInitContainers> InitContainers { get; set; }
        public class ModifyEciScalingConfigurationRequestInitContainers : TeaModel {
            [NameInMap("SecurityContext")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestInitContainersSecurityContext SecurityContext { get; set; }
            public class ModifyEciScalingConfigurationRequestInitContainersSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestInitContainersSecurityContextCapability Capability { get; set; }
                public class ModifyEciScalingConfigurationRequestInitContainersSecurityContextCapability : TeaModel {
                    [NameInMap("Adds")]
                    [Validation(Required=false)]
                    public List<string> Adds { get; set; }

                }

                [NameInMap("ReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? ReadOnlyRootFilesystem { get; set; }

                [NameInMap("RunAsUser")]
                [Validation(Required=false)]
                public long? RunAsUser { get; set; }

            }

            /// <summary>
            /// <para>The container startup arguments.</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public List<string> Args { get; set; }

            /// <summary>
            /// <para>The commands that you can run to start the init container.</para>
            /// </summary>
            [NameInMap("Commands")]
            [Validation(Required=false)]
            public List<string> Commands { get; set; }

            /// <summary>
            /// <para>The number of vCPUs per init container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// <para>The number of GPUs per init container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            /// <summary>
            /// <para>The image of the init container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nginx</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The image pulling policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Always: Image pulling is performed each time instances are created.</description></item>
            /// <item><description>IfNotPresent: Image pulling is performed as needed. On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.</description></item>
            /// <item><description>Never: On-premises images are always used. Image pulling is not performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Always</para>
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// <para>The environment variables of the init container.</para>
            /// </summary>
            [NameInMap("InitContainerEnvironmentVars")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVars> InitContainerEnvironmentVars { get; set; }
            public class ModifyEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVars : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVarsFieldRef FieldRef { get; set; }
                public class ModifyEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVarsFieldRef : TeaModel {
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }

                }

                /// <summary>
                /// <para>The name of the environment variable. The name can be 1 to 128 characters in length, and can contain letters, underscores (_), and digits. The name cannot start with a digit. Specify the value in the <c>[0-9a-zA-Z]</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Path</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the environment variable. The value can be up to 256 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/bin/</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ports of the init container.</para>
            /// </summary>
            [NameInMap("InitContainerPorts")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestInitContainersInitContainerPorts> InitContainerPorts { get; set; }
            public class ModifyEciScalingConfigurationRequestInitContainersInitContainerPorts : TeaModel {
                /// <summary>
                /// <para>The port number. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TCP</description></item>
                /// <item><description>UDP</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>The volume mounts of the init container.</para>
            /// </summary>
            [NameInMap("InitContainerVolumeMounts")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestInitContainersInitContainerVolumeMounts> InitContainerVolumeMounts { get; set; }
            public class ModifyEciScalingConfigurationRequestInitContainersInitContainerVolumeMounts : TeaModel {
                /// <summary>
                /// <para>The directory within the init container onto which you want to mount the volume.</para>
                /// <remarks>
                /// <para> The information stored within this directory is overwritten by the data on the mounted volume. Exercise caution when you specify this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/share/</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The mount propagation settings of the volume. Mount propagation enables volumes mounted on one container to be shared among other containers within the same pod or across distinct pods residing on the same node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>None: Subsequent mounts executed on the volume or its subdirectories do not propagate to the volume.</description></item>
                /// <item><description>HostToCotainer: Subsequent mounts executed on the volume or its subdirectories propagate to the volume.</description></item>
                /// <item><description>Bidirectional: This value is similar to HostToCotainer. Subsequent mounts executed on the volume or its subdirectories propagate to the volume. In addition, volume mounts executed on the container propagate back to the underlying instance and to all containers across every pod that uses the same volume.</description></item>
                /// </list>
                /// <para>Default value: None.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("MountPropagation")]
                [Validation(Required=false)]
                public string MountPropagation { get; set; }

                /// <summary>
                /// <para>The name of the volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-empty</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount path is read-only.</para>
                /// <para>Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The volume subdirectory. The pod can mount different directories of the same volume to different subdirectories of init containers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Always</para>
                /// </summary>
                [NameInMap("SubPath")]
                [Validation(Required=false)]
                public string SubPath { get; set; }

            }

            /// <summary>
            /// <para>The memory size per init container. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The name of the init container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-init</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The working directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local</para>
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// <para>The level of the instance family, which is used to filter instance types that meet the specified criteria. This parameter takes effect only if you set <c>CostOptimization</c> to true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EntryLevel: entry level (shared instance type). Instance types of this level are the most cost-effective but may not provide stable computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
        /// <item><description>EnterpriseLevel: enterprise level. Instance types of this level provide stable performance and dedicated resources, and are suitable for business scenarios that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</description></item>
        /// <item><description>CreditEntryLevel: credit-based entry level (burstable instance types). CPU credits are used to ensure computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview</a> of burstable instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseLevel</para>
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <para>The ECS instance types. You can specify up to five instance types.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The number of IPv6 addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>The load balancing weight of each backend server. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("LoadBalancerWeight")]
        [Validation(Required=false)]
        public int? LoadBalancerWeight { get; set; }

        /// <summary>
        /// <para>The memory size per elastic container instance. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The endpoints of Network Time Protocol (NTP) servers.</para>
        /// </summary>
        [NameInMap("NtpServers")]
        [Validation(Required=false)]
        public List<string> NtpServers { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the instance Resource Access Management (RAM) role. You can use the same RAM role to access elastic container instances and Elastic Compute Service (ECS) instances. For more information, see <a href="https://help.aliyun.com/document_detail/61178.html">Use an instance RAM role by calling API operations</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RamTestRole</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The instance restart policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Always: always restarts elastic container instances.</description></item>
        /// <item><description>Never: never restarts elastic container instances.</description></item>
        /// <item><description>OnFailure: restarts elastic container instances upon failures.</description></item>
        /// </list>
        /// <para>Default value: Always.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Always</para>
        /// </summary>
        [NameInMap("RestartPolicy")]
        [Validation(Required=false)]
        public string RestartPolicy { get; set; }

        /// <summary>
        /// <para>The ID of the scaling configuration that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc-bp16har3jpj6fjbx****</para>
        /// </summary>
        [NameInMap("ScalingConfigurationId")]
        [Validation(Required=false)]
        public string ScalingConfigurationId { get; set; }

        /// <summary>
        /// <para>The name of the scaling configuration. The name must be 2 to 64 characters in length, and can contain letters, digits, underscores (_), hyphens (-), and periods (.). The name must start with a letter or a digit.</para>
        /// <para>The name of a scaling configuration must be unique in the specified region. If you do not specify this parameter, the value of ScalingConfigurationId is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-modify</para>
        /// </summary>
        [NameInMap("ScalingConfigurationName")]
        [Validation(Required=false)]
        public string ScalingConfigurationName { get; set; }

        /// <summary>
        /// <para>The security contexts in which the elastic container instance runs.</para>
        /// </summary>
        [NameInMap("SecurityContextSysCtls")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestSecurityContextSysCtls> SecurityContextSysCtls { get; set; }
        public class ModifyEciScalingConfigurationRequestSecurityContextSysCtls : TeaModel {
            /// <summary>
            /// <para>The variable name of the security context in which the elastic container instance runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kernel.msgmax</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The variable value of the security context in which the elastic container instance runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65536</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the security group to which elastic container instances belong. Elastic container instances that belong to the same security group can communicate with each other.</para>
        /// <para>If you do not specify a security group, the system uses the default security group in the region that you selected. Make sure that the inbound rules of the security group contain the protocols and port numbers of the containers that you want to expose. If you do not have a default security group in the region, the system creates a default security group and then adds the container protocols and port numbers that you specified to the inbound rules of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The maximum hourly price of preemptible elastic container instances. The value can be accurate to three decimal places.</para>
        /// <para>If you set SpotStrategy to SpotWithPriceLimit, you must specify SpotPriceLimit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.025</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The instance bidding policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instances are created as pay-as-you-go instances.</description></item>
        /// <item><description>SpotWithPriceLimit: The instances are preemptible instances for which you can specify the maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instances are created as preemptible instances for which the market price at the time of purchase is used as the bid price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SpotPriceLimit</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestTags> Tags { get; set; }
        public class ModifyEciScalingConfigurationRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>version</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The buffer period during which the program handles operations before the program is stopped. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public long? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// <para>The volumes.</para>
        /// </summary>
        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestVolumes> Volumes { get; set; }
        public class ModifyEciScalingConfigurationRequestVolumes : TeaModel {
            [NameInMap("DiskVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesDiskVolume DiskVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesDiskVolume : TeaModel {
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                [NameInMap("FsType")]
                [Validation(Required=false)]
                public string FsType { get; set; }

            }

            [NameInMap("EmptyDirVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesEmptyDirVolume EmptyDirVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesEmptyDirVolume : TeaModel {
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                [NameInMap("SizeLimit")]
                [Validation(Required=false)]
                public string SizeLimit { get; set; }

            }

            [NameInMap("FlexVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesFlexVolume FlexVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesFlexVolume : TeaModel {
                [NameInMap("Driver")]
                [Validation(Required=false)]
                public string Driver { get; set; }

                [NameInMap("FsType")]
                [Validation(Required=false)]
                public string FsType { get; set; }

                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

            }

            [NameInMap("HostPathVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesHostPathVolume HostPathVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesHostPathVolume : TeaModel {
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("NFSVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesNFSVolume NFSVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesNFSVolume : TeaModel {
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The paths to the configuration files.</para>
            /// </summary>
            [NameInMap("ConfigFileVolumeConfigFileToPath")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestVolumesConfigFileVolumeConfigFileToPath> ConfigFileVolumeConfigFileToPath { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesConfigFileVolumeConfigFileToPath : TeaModel {
                /// <summary>
                /// <para>The content of the configuration file (32 KB).</para>
                /// 
                /// <b>Example:</b>
                /// <para>bGl1bWk=</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The permissions on the ConfigFile volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0644</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public int? Mode { get; set; }

                /// <summary>
                /// <para>The relative path to the configuration file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/bin/</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// <para>The default permissions on the ConfigFile volume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0644</para>
            /// </summary>
            [NameInMap("ConfigFileVolumeDefaultMode")]
            [Validation(Required=false)]
            public int? ConfigFileVolumeDefaultMode { get; set; }

            /// <summary>
            /// <para>The volume name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-volume1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the Host directory. Examples: File, Directory, and Socket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EmptyDirVolume</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
