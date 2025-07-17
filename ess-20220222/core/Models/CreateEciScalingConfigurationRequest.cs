// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateEciScalingConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The Container Registry Enterprise Edition instances.</para>
        /// </summary>
        [NameInMap("AcrRegistryInfos")]
        [Validation(Required=false)]
        public List<CreateEciScalingConfigurationRequestAcrRegistryInfos> AcrRegistryInfos { get; set; }
        public class CreateEciScalingConfigurationRequestAcrRegistryInfos : TeaModel {
            /// <summary>
            /// <para>The domain names of the Container Registry Enterprise Edition instances. By default, all domain names are displayed. Separate multiple domain names with commas (,).</para>
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
            /// <para>cn-beijing</para>
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
        /// <para>Specifies whether to automatically match the image cache. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoMatchImageCache")]
        [Validation(Required=false)]
        public bool? AutoMatchImageCache { get; set; }

        /// <summary>
        /// <para>The name series of elastic container instances.</para>
        /// <para>If you want to use an ordered instance name, specify the value for this parameter in the following format: name_prefix[begin_number,bits]name_suffix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nginx-test</para>
        /// </summary>
        [NameInMap("ContainerGroupName")]
        [Validation(Required=false)]
        public string ContainerGroupName { get; set; }

        /// <summary>
        /// <para>The containers per elastic container instance.</para>
        /// </summary>
        [NameInMap("Containers")]
        [Validation(Required=false)]
        public List<CreateEciScalingConfigurationRequestContainers> Containers { get; set; }
        public class CreateEciScalingConfigurationRequestContainers : TeaModel {
            [NameInMap("LivenessProbe")]
            [Validation(Required=false)]
            public CreateEciScalingConfigurationRequestContainersLivenessProbe LivenessProbe { get; set; }
            public class CreateEciScalingConfigurationRequestContainersLivenessProbe : TeaModel {
                [NameInMap("Exec")]
                [Validation(Required=false)]
                public CreateEciScalingConfigurationRequestContainersLivenessProbeExec Exec { get; set; }
                public class CreateEciScalingConfigurationRequestContainersLivenessProbeExec : TeaModel {
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public CreateEciScalingConfigurationRequestContainersLivenessProbeHttpGet HttpGet { get; set; }
                public class CreateEciScalingConfigurationRequestContainersLivenessProbeHttpGet : TeaModel {
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
                public CreateEciScalingConfigurationRequestContainersLivenessProbeTcpSocket TcpSocket { get; set; }
                public class CreateEciScalingConfigurationRequestContainersLivenessProbeTcpSocket : TeaModel {
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
            public CreateEciScalingConfigurationRequestContainersReadinessProbe ReadinessProbe { get; set; }
            public class CreateEciScalingConfigurationRequestContainersReadinessProbe : TeaModel {
                [NameInMap("Exec")]
                [Validation(Required=false)]
                public CreateEciScalingConfigurationRequestContainersReadinessProbeExec Exec { get; set; }
                public class CreateEciScalingConfigurationRequestContainersReadinessProbeExec : TeaModel {
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public CreateEciScalingConfigurationRequestContainersReadinessProbeHttpGet HttpGet { get; set; }
                public class CreateEciScalingConfigurationRequestContainersReadinessProbeHttpGet : TeaModel {
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
                public CreateEciScalingConfigurationRequestContainersReadinessProbeTcpSocket TcpSocket { get; set; }
                public class CreateEciScalingConfigurationRequestContainersReadinessProbeTcpSocket : TeaModel {
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
            public CreateEciScalingConfigurationRequestContainersSecurityContext SecurityContext { get; set; }
            public class CreateEciScalingConfigurationRequestContainersSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=false)]
                public CreateEciScalingConfigurationRequestContainersSecurityContextCapability Capability { get; set; }
                public class CreateEciScalingConfigurationRequestContainersSecurityContextCapability : TeaModel {
                    [NameInMap("Add")]
                    [Validation(Required=false)]
                    public List<string> Add { get; set; }

                }

                [NameInMap("ReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? ReadOnlyRootFilesystem { get; set; }

                [NameInMap("RunAsUser")]
                [Validation(Required=false)]
                public long? RunAsUser { get; set; }

            }

            /// <summary>
            /// <para>The startup arguments of the container. You can specify up to 10 arguments.</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public List<string> Args { get; set; }

            /// <summary>
            /// <para>The commands that you want to run by using the CLI for liveness probing within the container.</para>
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
            public List<CreateEciScalingConfigurationRequestContainersEnvironmentVars> EnvironmentVars { get; set; }
            public class CreateEciScalingConfigurationRequestContainersEnvironmentVars : TeaModel {
                /// <summary>
                /// <remarks>
                /// <para> This parameter is unavailable for use.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>fieldPath</para>
                /// </summary>
                [NameInMap("FieldRefFieldPath")]
                [Validation(Required=false)]
                public string FieldRefFieldPath { get; set; }

                /// <summary>
                /// <para>The name of the environment variable. The name can be 1 to 128 characters in length and can contain letters, underscores (_), and digits. It cannot start with a digit. Specify the value in the [0-9a-zA-Z] format.</para>
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
            /// <para>The image in the container.</para>
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
            /// <item><description>Always: Each time instances are created, image pulling is performed.</description></item>
            /// <item><description>IfNotPresent: Image pulling is performed based on your business requirements. On-premises images are used by default. If no on-premises images are available, images are pulled from remote sources.</description></item>
            /// <item><description>Never: Image pulling is not performed. On-premises images are always used. Image pulling is not performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Always</para>
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// <para>The commands that you want to run by using the CLI to configure the postStart callback function within the container.</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerExecs")]
            [Validation(Required=false)]
            public List<string> LifecyclePostStartHandlerExecs { get; set; }

            /// <summary>
            /// <para>The IP address of the host to which you want to send HTTP GET requests to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetHost { get; set; }

            /// <summary>
            /// <para>The path to which you want to send HTTP GET requests to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthyz</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetPath { get; set; }

            /// <summary>
            /// <para>The port over which you want to send HTTP GET requests to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5050</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerHttpGetPort { get; set; }

            /// <summary>
            /// <para>The protocol type of HTTP GET requests that you want to send to configure the postStart callback function. Valid values:</para>
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
            /// <para>The IP address of the host detected by the TCP sockets that you want to use to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// <para>The port detected by the TCP sockets that you want to use to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// <para>The commands that you want to run by using the CLI to configure the preStop callback function within the container.</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerExecs")]
            [Validation(Required=false)]
            public List<string> LifecyclePreStopHandlerExecs { get; set; }

            /// <summary>
            /// <para>The IP address of the host to which you want to send HTTP GET requests to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetHost { get; set; }

            /// <summary>
            /// <para>The path to which you want to send HTTP GET requests to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthyz</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetPath { get; set; }

            /// <summary>
            /// <para>The port over which you want to send HTTP GET requests to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerHttpGetPort { get; set; }

            /// <summary>
            /// <para>The protocol type of the HTTP GET requests that you want to send to configure the preStop callback function. Valid values:</para>
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
            /// <para>The IP address of the host detected by the TCP sockets that you want to use to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// <para>The port detected by the TCP sockets that you want to use to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// <para>The memory size that you want to allocate to the container. Unit: GiB.</para>
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
            public List<CreateEciScalingConfigurationRequestContainersPorts> Ports { get; set; }
            public class CreateEciScalingConfigurationRequestContainersPorts : TeaModel {
                /// <summary>
                /// <para>The port. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The type of the protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TCP.</description></item>
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
            /// <para>Specifies whether standard input streams remain connected during multiple sessions if Stdin is set to true.</para>
            /// <para>If you set StdinOnce to true, standard input streams are connected after the container is started, and remain idle until a client is connected to receive data. After the client is disconnected, streams are also disconnected and remain disconnected until the container is restarted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("StdinOnce")]
            [Validation(Required=false)]
            public bool? StdinOnce { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable interaction. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>If the command is a /bin/bash command, set the value to true.</para>
            /// <para>Default value: false.</para>
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
            public List<CreateEciScalingConfigurationRequestContainersVolumeMounts> VolumeMounts { get; set; }
            public class CreateEciScalingConfigurationRequestContainersVolumeMounts : TeaModel {
                /// <summary>
                /// <para>The directory in which the container mounts the volume.</para>
                /// <remarks>
                /// <para> Data in this directory is overwritten by data on the volume. Specify this parameter with caution.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>/pod/data</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The mount propagation setting. Mount propagation enables volume sharing from one container to other containers within the same pod or to containers across separate pods on the same node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>None: Subsequent mounts executed on the volume or its subdirectories are not propagated to the volume.</description></item>
                /// <item><description>HostToCotainer: Subsequent mounts executed on the volume or its subdirectories are propagated to the volume.</description></item>
                /// <item><description>Bidirectional: This value is similar to HostToCotainer. Subsequent mounts executed on the volume or its subdirectories are propagated to the volume. All volume mounts executed on the container are not only propagate back to the underlying host but also to all containers across every pod that uses the same volume.</description></item>
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
                /// <para>The volume name. The value of this parameter is the same as the value of Volumes.Name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default-volume1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Specifies whether the volume is read-only. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
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
        /// <para>Specifies whether to enable the Cost Optimization feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
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
        /// <para>The number of physical CPU cores. You can specify this parameter for specific instance types. For more information, see <a href="https://help.aliyun.com/document_detail/197781.html">Specify CPU options</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CpuOptionsCore")]
        [Validation(Required=false)]
        public int? CpuOptionsCore { get; set; }

        /// <summary>
        /// <para>The number of threads per core. You can specify this parameter for specific instance types. A value of 1 specifies that Hyper-Threading is disabled. For more information, see <a href="https://help.aliyun.com/document_detail/197781.html">Specify CPU options</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CpuOptionsThreadsPerCore")]
        [Validation(Required=false)]
        public int? CpuOptionsThreadsPerCore { get; set; }

        /// <summary>
        /// <para>The bucket that you want to use to store data caches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("DataCacheBucket")]
        [Validation(Required=false)]
        public string DataCacheBucket { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the performance burst feature when ESSD AutoPL disks are used to store data caches. Valid values:</para>
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
        /// <para>The PL of the cloud disk that you want to use to store data caches. We recommend that you use ESSDs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: An ESSD can provide up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: An ESSD can provide up to 50,000 random read/write IOPS.</description></item>
        /// <item><description>PL2: An ESSD can provide up to 100,000 random read/write IOPS.</description></item>
        /// <item><description>PL3: An ESSD can provide up to 1,000,000 random read/write IOPS.</description></item>
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
        /// <para>The provisioned IOPS of the ESSD AutoPL disk that you want to use to store data caches. Valid values: 0 to min{50,000, 1,000 × *Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × *Capacity, 50,000}.</para>
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
        /// <para> This parameter is unavailable for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IP addresses of the DNS servers.</para>
        /// </summary>
        [NameInMap("DnsConfigNameServers")]
        [Validation(Required=false)]
        public List<string> DnsConfigNameServers { get; set; }

        /// <summary>
        /// <para>The options. Each option is a name-value pair. The value in the name-value pair is optional.</para>
        /// </summary>
        [NameInMap("DnsConfigOptions")]
        [Validation(Required=false)]
        public List<CreateEciScalingConfigurationRequestDnsConfigOptions> DnsConfigOptions { get; set; }
        public class CreateEciScalingConfigurationRequestDnsConfigOptions : TeaModel {
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
        /// <para>The search domains of the DNS servers.</para>
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
        /// <para>The EIP bandwidth. Default value: 5. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("EipBandwidth")]
        [Validation(Required=false)]
        public int? EipBandwidth { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is unavailable for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSls")]
        [Validation(Required=false)]
        public bool? EnableSls { get; set; }

        /// <summary>
        /// <para>The size of the temporary storage space. By default, an Enterprise SSD (ESSD) of performance level 1 (PL1) is used. Unit: GiB.</para>
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
        /// <para>The custom hostnames of the containers.</para>
        /// </summary>
        [NameInMap("HostAliases")]
        [Validation(Required=false)]
        public List<CreateEciScalingConfigurationRequestHostAliases> HostAliases { get; set; }
        public class CreateEciScalingConfigurationRequestHostAliases : TeaModel {
            /// <summary>
            /// <para>The hostnames of the containers that you want to add.</para>
            /// </summary>
            [NameInMap("Hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            /// <summary>
            /// <para>The IP address of the container that you want to add.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
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
        public List<CreateEciScalingConfigurationRequestImageRegistryCredentials> ImageRegistryCredentials { get; set; }
        public class CreateEciScalingConfigurationRequestImageRegistryCredentials : TeaModel {
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
            /// <para>The endpoint of the image repository.</para>
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
        public List<CreateEciScalingConfigurationRequestInitContainers> InitContainers { get; set; }
        public class CreateEciScalingConfigurationRequestInitContainers : TeaModel {
            [NameInMap("SecurityContext")]
            [Validation(Required=false)]
            public CreateEciScalingConfigurationRequestInitContainersSecurityContext SecurityContext { get; set; }
            public class CreateEciScalingConfigurationRequestInitContainersSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=false)]
                public CreateEciScalingConfigurationRequestInitContainersSecurityContextCapability Capability { get; set; }
                public class CreateEciScalingConfigurationRequestInitContainersSecurityContextCapability : TeaModel {
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
            /// <para>The startup arguments of the init container. You can specify up to 10 arguments.</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public List<string> Args { get; set; }

            /// <summary>
            /// <para>The startup commands of the init container.</para>
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
            /// <para>The image pulling policy.</para>
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
            public List<CreateEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVars> InitContainerEnvironmentVars { get; set; }
            public class CreateEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVars : TeaModel {
                /// <summary>
                /// <remarks>
                /// <para> This parameter is unavailable for use.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>path</para>
                /// </summary>
                [NameInMap("FieldRefFieldPath")]
                [Validation(Required=false)]
                public string FieldRefFieldPath { get; set; }

                /// <summary>
                /// <para>The name of the environment variable. The name can be 1 to 128 characters in length and can contain letters, underscores (_), and digits. It cannot start with a digit. Specify the value in the <c>[0-9a-zA-Z]</c> format.</para>
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
            /// <para>The ports of init containers.</para>
            /// </summary>
            [NameInMap("InitContainerPorts")]
            [Validation(Required=false)]
            public List<CreateEciScalingConfigurationRequestInitContainersInitContainerPorts> InitContainerPorts { get; set; }
            public class CreateEciScalingConfigurationRequestInitContainersInitContainerPorts : TeaModel {
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
            public List<CreateEciScalingConfigurationRequestInitContainersInitContainerVolumeMounts> InitContainerVolumeMounts { get; set; }
            public class CreateEciScalingConfigurationRequestInitContainersInitContainerVolumeMounts : TeaModel {
                /// <summary>
                /// <para>The directory to which the init container mounts the volume. The data stored in this directory is overwritten by the data on the volume. Specify this parameter with caution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/share/</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The mount propagation settings of the volume. Mount propagation enables volume sharing from one container to other containers within the same pod or to containers across separate pods on the same node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>None: Subsequent mounts executed on the volume or its subdirectories do not propagate to the volume.</description></item>
                /// <item><description>HostToCotainer: Subsequent mounts executed on the volume or its subdirectories propagate to the volume.</description></item>
                /// <item><description>Bidirectional: This value is similar to HostToCotainer. Subsequent mounts executed on the volume or its subdirectories propagate to the volume. All volume mounts executed on the container not only propagate back to the underlying host but also to all containers across every pod that uses the same volume.</description></item>
                /// </list>
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
                /// <para>The subdirectory of the volume. The pod can mount different directories of the same volume to different subdirectories of init containers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/sub/</para>
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
            /// <para>The working directory of the init container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local</para>
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// <para>The level of the instance family. You can specify this parameter to match the available instance types. This parameter takes effect only if you set <c>CostOptimization</c> to true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EntryLevel: entry level (shared instance types). Instance types of this level are the most cost-effective, but may not ensure stable computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
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
        /// <para>The ECS instance types that you want to use to create elastic container instances. You can specify up to five ECS instance types.</para>
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
        /// <para>The load balancing weight of each elastic container instance. Valid values: 1 to 100.</para>
        /// <para>Default value: 50.</para>
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
        /// <para>The endpoints of the Network Time Protocol (NTP) servers.</para>
        /// </summary>
        [NameInMap("NtpServers")]
        [Validation(Required=false)]
        public List<string> NtpServers { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the instance Resource Access Management (RAM) role. Elastic container instances and Elastic Compute Service (ECS) instances can share the same RAM role. For more information, see <a href="https://help.aliyun.com/document_detail/61175.html">RAM roles</a>.</para>
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
        /// <para>The restart policy of elastic container instances. Valid values:</para>
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
        /// <para>The name of the scaling configuration. The name must be 2 to 64 characters in length and can contain letters, digits, underscores (_), hyphens (-), and periods (.). It must start with a letter or a digit.</para>
        /// <para>The name of the scaling configuration must be unique in a scaling group within a region. If you do not specify this parameter, the value of ScalingConfigurationId is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scalingconfig****</para>
        /// </summary>
        [NameInMap("ScalingConfigurationName")]
        [Validation(Required=false)]
        public string ScalingConfigurationName { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group to which the scaling configuration belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp14wlu85wrpchm0****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The system information of the security context in which the elastic container instance runs.</para>
        /// </summary>
        [NameInMap("SecurityContextSysctls")]
        [Validation(Required=false)]
        public List<CreateEciScalingConfigurationRequestSecurityContextSysctls> SecurityContextSysctls { get; set; }
        public class CreateEciScalingConfigurationRequestSecurityContextSysctls : TeaModel {
            /// <summary>
            /// <para>The variable name of the security context in which the container group runs.</para>
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
        /// <para>If you do not specify a security group, the system uses the default security group in the region that you selected. Make sure that the inbound rules of the security group contain the protocols and port numbers of the containers that you want to expose. If you do not have a default security group in the region, the system creates a default security group, and then adds the container protocols and port numbers that you specified to the inbound rules of the security group.</para>
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
        /// <para>The tags of elastic container instances. Tags must be specified as key-value pairs. You can specify up to 20 tags for each elastic container instance. When you specify Key and Value, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>A tag key can be up to 64 characters in length. The key cannot start with acs: or aliyun or contain <c>http://</c> or <c>https://</c>. You cannot specify an empty string as a tag key.</description></item>
        /// <item><description>A tag value can be up to 128 characters in length. The value cannot start with acs: or aliyun or contain <c>http://</c> or <c>https://</c>. You can specify an empty string as a tag value.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateEciScalingConfigurationRequestTags> Tags { get; set; }
        public class CreateEciScalingConfigurationRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the elastic container instance.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with <c>acs:</c> or <c>aliyun</c> or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>version</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the elastic container instance.</para>
            /// <para>The tag value can be an empty string. The tag value can be up to 128 characters in length. It cannot start with <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The buffer time during which a program handles operations before the program stops. Unit: seconds.</para>
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
        public List<CreateEciScalingConfigurationRequestVolumes> Volumes { get; set; }
        public class CreateEciScalingConfigurationRequestVolumes : TeaModel {
            [NameInMap("DiskVolume")]
            [Validation(Required=false)]
            public CreateEciScalingConfigurationRequestVolumesDiskVolume DiskVolume { get; set; }
            public class CreateEciScalingConfigurationRequestVolumesDiskVolume : TeaModel {
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
            public CreateEciScalingConfigurationRequestVolumesEmptyDirVolume EmptyDirVolume { get; set; }
            public class CreateEciScalingConfigurationRequestVolumesEmptyDirVolume : TeaModel {
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                [NameInMap("SizeLimit")]
                [Validation(Required=false)]
                public string SizeLimit { get; set; }

            }

            [NameInMap("FlexVolume")]
            [Validation(Required=false)]
            public CreateEciScalingConfigurationRequestVolumesFlexVolume FlexVolume { get; set; }
            public class CreateEciScalingConfigurationRequestVolumesFlexVolume : TeaModel {
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
            public CreateEciScalingConfigurationRequestVolumesHostPathVolume HostPathVolume { get; set; }
            public class CreateEciScalingConfigurationRequestVolumesHostPathVolume : TeaModel {
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("NFSVolume")]
            [Validation(Required=false)]
            public CreateEciScalingConfigurationRequestVolumesNFSVolume NFSVolume { get; set; }
            public class CreateEciScalingConfigurationRequestVolumesNFSVolume : TeaModel {
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
            [NameInMap("ConfigFileVolumeConfigFileToPaths")]
            [Validation(Required=false)]
            public List<CreateEciScalingConfigurationRequestVolumesConfigFileVolumeConfigFileToPaths> ConfigFileVolumeConfigFileToPaths { get; set; }
            public class CreateEciScalingConfigurationRequestVolumesConfigFileVolumeConfigFileToPaths : TeaModel {
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
                /// <para>The permissions on the configuration file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0644</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public int? Mode { get; set; }

                /// <summary>
                /// <para>The name of the environment variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PATH</para>
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
            /// <para>The name of the volume.</para>
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
            /// <para>ConfigFileVolume</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
