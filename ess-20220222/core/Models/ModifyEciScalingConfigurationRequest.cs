// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyEciScalingConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The information about ACR Enterprise Edition instances.</para>
        /// </summary>
        [NameInMap("AcrRegistryInfos")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestAcrRegistryInfos> AcrRegistryInfos { get; set; }
        public class ModifyEciScalingConfigurationRequestAcrRegistryInfos : TeaModel {
            /// <summary>
            /// <para>The domain names of the ACR Enterprise Edition instance. By default, all domain names of the instance are used. You can specify individual domain names and separate multiple domain names with commas (,).</para>
            /// </summary>
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }

            /// <summary>
            /// <para>The ID of the ACR Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-nwj395hgf6f3****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the ACR Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acr-test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The region ID of the ACR Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The validity period. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ActiveDeadlineSeconds")]
        [Validation(Required=false)]
        public long? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// <para>Specifies whether automatic creation of an elastic IP address (EIP) is enabled and the EIP is attached to the ECI instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoCreateEip")]
        [Validation(Required=false)]
        public bool? AutoCreateEip { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically match an image cache.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoMatchImageCache")]
        [Validation(Required=false)]
        public bool? AutoMatchImageCache { get; set; }

        /// <summary>
        /// <para>The name of the ECI, which is the name of the container group. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name can contain lowercase letters, digits, and hyphens (-), and cannot start or end with a hyphen (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>nginx-test</para>
        /// </summary>
        [NameInMap("ContainerGroupName")]
        [Validation(Required=false)]
        public string ContainerGroupName { get; set; }

        /// <summary>
        /// <para>The list of containers.</para>
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
                    /// <summary>
                    /// <para>The command executed in the container when the exec action is used for health checks.</para>
                    /// </summary>
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

                /// <summary>
                /// <para>The minimum consecutive failures for the liveness check to be considered failed after having succeeded.</para>
                /// <para>Default value: 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersLivenessProbeHttpGet HttpGet { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersLivenessProbeHttpGet : TeaModel {
                    /// <summary>
                    /// <para>The path to which the HTTP GET request is sent when HTTP GET is used for health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/healthyz</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The port number to which the HTTP GET request is sent when HTTP GET is used for health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8888</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The protocol type of the HTTP GET request when HTTP GET is used for health checks. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>HTTP</description></item>
                    /// <item><description>HTTPS</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("Scheme")]
                    [Validation(Required=false)]
                    public string Scheme { get; set; }

                }

                /// <summary>
                /// <para>The number of seconds after the container has started before the readiness check is initiated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                /// <summary>
                /// <para>The period for executing the liveness check, in seconds. Default value: 10. Minimum value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                /// <summary>
                /// <para>The minimum consecutive successes for the liveness check to be considered successful after having failed. Default value: 1. The value must be 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                [NameInMap("TcpSocket")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersLivenessProbeTcpSocket TcpSocket { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersLivenessProbeTcpSocket : TeaModel {
                    /// <summary>
                    /// <para>The port number on which the TCP socket check is performed when TCP socket is used for health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }

                /// <summary>
                /// <para>The timeout period for the readiness check, in seconds. Default value: 1. Minimum value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
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
                    /// <summary>
                    /// <para>The command executed in the container when the exec action is used for health checks.</para>
                    /// </summary>
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

                /// <summary>
                /// <para>The minimum consecutive failures for the liveness check to be considered failed after having succeeded.</para>
                /// <para>Default value: 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersReadinessProbeHttpGet HttpGet { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersReadinessProbeHttpGet : TeaModel {
                    /// <summary>
                    /// <para>The path to which the HTTP GET request is sent when HTTP GET is used for health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/healthz</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The port number to which the HTTP GET request is sent when HTTP GET is used for health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8080</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The protocol type of the HTTP GET request when HTTP GET is used for health checks. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>HTTP</description></item>
                    /// <item><description>HTTPS</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("Scheme")]
                    [Validation(Required=false)]
                    public string Scheme { get; set; }

                }

                /// <summary>
                /// <para>The number of seconds after the container has started before the readiness check is initiated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                /// <summary>
                /// <para>The period for executing the liveness check, in seconds. Default value: 10. Minimum value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                /// <summary>
                /// <para>The minimum consecutive successes for the readiness check to be considered successful after having failed. Default value: 1. The value must be 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                [NameInMap("TcpSocket")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersReadinessProbeTcpSocket TcpSocket { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersReadinessProbeTcpSocket : TeaModel {
                    /// <summary>
                    /// <para>The port number on which the TCP socket check is performed when TCP socket is used for health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8000</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }

                /// <summary>
                /// <para>The timeout period for the readiness check, in seconds. Default value: 1. Minimum value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
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
                    /// <summary>
                    /// <para>Grants specific privileges to processes in the container. Valid values: NET_ADMIN and NET_RAW.</para>
                    /// <remarks>
                    /// <para>NET_RAW is not supported by default. To use NET_RAW, submit a ticket.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Adds")]
                    [Validation(Required=false)]
                    public List<string> Adds { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether the root file system of the container is read-only. Only true is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? ReadOnlyRootFilesystem { get; set; }

                /// <summary>
                /// <para>The user ID to run the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("RunAsUser")]
                [Validation(Required=false)]
                public long? RunAsUser { get; set; }

            }

            /// <summary>
            /// <para>The arguments for the container startup command. A maximum of 10 arguments are supported.</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public List<string> Args { get; set; }

            /// <summary>
            /// <para>The startup commands for the container. A maximum of 20 commands are supported. Each command can contain up to 256 characters.</para>
            /// </summary>
            [NameInMap("Commands")]
            [Validation(Required=false)]
            public List<string> Commands { get; set; }

            /// <summary>
            /// <para>The number of vCPUs allocated to the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// <para>The environment variable information.</para>
            /// </summary>
            [NameInMap("EnvironmentVars")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestContainersEnvironmentVars> EnvironmentVars { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersEnvironmentVars : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestContainersEnvironmentVarsFieldRef FieldRef { get; set; }
                public class ModifyEciScalingConfigurationRequestContainersEnvironmentVarsFieldRef : TeaModel {
                    /// <summary>
                    /// <remarks>
                    /// <para>This parameter is not available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>path</para>
                    /// </summary>
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }

                }

                /// <summary>
                /// <para>The name of the environment variable. The name must be 1 to 128 characters in length, match the <c>[0-9a-zA-Z]</c> format, and can contain underscores (_). It cannot start with a digit.</para>
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
            /// <para>The number of GPUs allocated to the container.</para>
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
            /// <para>The image pull policy for the container. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Always: Always pulls the image.</description></item>
            /// <item><description>IfNotPresent: Pulls the image only if it is not present locally.</description></item>
            /// <item><description>Never: Never pulls the image. Only local images are used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Always</para>
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// <para>The command executed in the container when the command line is used for the postStart callback function Settings.</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerExecs")]
            [Validation(Required=false)]
            public List<string> LifecyclePostStartHandlerExecs { get; set; }

            /// <summary>
            /// <para>The host address that accepts the HTTP GET request when the HTTP request method is used for the postStart callback function Settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetHost { get; set; }

            /// <summary>
            /// <para>The path to which the HTTP GET request is sent when the HTTP request method is used for the postStart callback function Settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthyz</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetPath { get; set; }

            /// <summary>
            /// <para>The port number to which the HTTP GET request is sent when the HTTP request method is used for the postStart callback function Settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5050</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerHttpGetPort { get; set; }

            /// <summary>
            /// <para>The protocol type of the HTTP GET request when the HTTP request method is used for the postStart callback function Settings. Valid values:</para>
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
            /// <para>The host address on which the TCP socket check is performed when the TCP socket method is used for the postStart callback function Settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// <para>The port number on which the TCP socket check is performed when the TCP socket method is used for the postStart callback function Settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// <para>The command executed in the container when the command line is used for the preStop callback function Settings.</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerExecs")]
            [Validation(Required=false)]
            public List<string> LifecyclePreStopHandlerExecs { get; set; }

            /// <summary>
            /// <para>The host address that accepts the HTTP GET request when the HTTP request method is used for the preStop callback function Settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetHost { get; set; }

            /// <summary>
            /// <para>The path to which the HTTP GET request is sent when the HTTP request method is used for the preStop callback function Settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthyz</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetPath { get; set; }

            /// <summary>
            /// <para>The port number to which the HTTP GET request is sent when the HTTP request method is used for the preStop callback function Settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerHttpGetPort { get; set; }

            /// <summary>
            /// <para>The protocol type of the HTTP GET request when the HTTP request method is used for the preStop callback function Settings. Valid values:</para>
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
            /// <para>The host address on which the TCP socket check is performed when the TCP socket method is used for the preStop callback function Settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// <para>The port number on which the TCP socket check is performed when the TCP socket method is used for the preStop callback function Settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// <para>The memory size of the container, in GiB.</para>
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
            /// <para>The port information.</para>
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
            /// <para>Specifies whether to allocate a buffer for standard input while the container is running. If this parameter is not set, a read from standard input results in an EOF.</para>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Stdin")]
            [Validation(Required=false)]
            public bool? Stdin { get; set; }

            /// <summary>
            /// <para>Specifies whether the standard input stream maintains the enabling status across multiple attached sessions when standard input is true.</para>
            /// <para>If StdinOnce is set to true, standard input is opened when the container starts, remains empty until the first client attaches to it, and then maintains the enabling status to accept data until the client disconnects. After the client disconnects, standard input enters shutdown and remains in shutdown until the container is restarted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("StdinOnce")]
            [Validation(Required=false)]
            public bool? StdinOnce { get; set; }

            /// <summary>
            /// <para>Specifies whether to allocate a TTY for the container. Default value: false.</para>
            /// <para>Set this parameter to true when the Command parameter is set to /bin/bash.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Tty")]
            [Validation(Required=false)]
            public bool? Tty { get; set; }

            /// <summary>
            /// <para>The volume mount information for the container.</para>
            /// </summary>
            [NameInMap("VolumeMounts")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestContainersVolumeMounts> VolumeMounts { get; set; }
            public class ModifyEciScalingConfigurationRequestContainersVolumeMounts : TeaModel {
                /// <summary>
                /// <para>The directory where the volume is mounted in the container.</para>
                /// <remarks>
                /// <para>The contents of the mount path in the container are directly overwritten by the contents of the volume. Use this parameter with caution.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>/pod/data</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The mount propagation settings for the volume. Mount propagation allows volumes mounted by a container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>None: The volume does not receive any subsequent mounts that are performed on the volume or its subdirectories.</description></item>
                /// <item><description>HostToCotainer: The volume receives all subsequent mounts that are performed on the volume or its subdirectories.</description></item>
                /// <item><description>Bidirectional: Similar to HostToContainer, the volume receives all subsequent mounts. In addition, all mounts created by the container are propagated back to the host and to all containers of all pods that use the same volume.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("MountPropagation")]
                [Validation(Required=false)]
                public string MountPropagation { get; set; }

                /// <summary>
                /// <para>The name of the volume. The value must be the same as the Name parameter in Volume.</para>
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
                /// <para>The subpath of the volume.</para>
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
        /// <para>The control parameter for the update method of the Containers parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RenewUpdate: full update. The Containers parameter in the update request prevails and overwrites the original Containers parameter configuration.</description></item>
        /// <item><description>IncrementalUpdate: incremental update. Containers are matched based on Container.name, and only the parameters specified in the request are updated.</description></item>
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
        /// <para>Specifies whether to enable cost optimization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
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
        /// <para>The number of vCPUs for the instance. Unit: cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The number of physical CPU cores. Only specific instance types support custom settings. For more information, see <a href="https://help.aliyun.com/document_detail/197781.html">Customize CPU options</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CpuOptionsCore")]
        [Validation(Required=false)]
        public int? CpuOptionsCore { get; set; }

        /// <summary>
        /// <para>The number of threads per core. Only specific instance types support custom settings. A value of 1 indicates that hyper-threading is disabled. For more information, see <a href="https://help.aliyun.com/document_detail/197781.html">Customize CPU options</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CpuOptionsThreadsPerCore")]
        [Validation(Required=false)]
        public int? CpuOptionsThreadsPerCore { get; set; }

        /// <summary>
        /// <para>The data cache bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("DataCacheBucket")]
        [Validation(Required=false)]
        public string DataCacheBucket { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the burst feature for the ESSD AutoPL cloud disk used for data caching. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>For more information about ESSD AutoPL cloud disks, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DataCacheBurstingEnabled")]
        [Validation(Required=false)]
        public bool? DataCacheBurstingEnabled { get; set; }

        /// <summary>
        /// <para>The performance level of the cloud disk used for data caching. Use ESSDs. Valid values for the performance level of an ESSD:</para>
        /// <list type="bullet">
        /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
        /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
        /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// <para>Default value: PL1.</para>
        /// <remarks>
        /// <para>For more information about ESSDs, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("DataCachePL")]
        [Validation(Required=false)]
        public string DataCachePL { get; set; }

        /// <summary>
        /// <para>The provisioned read and write IOPS of the ESSD AutoPL cloud disk used for data caching. Valid values: 0 to min{50000, 1000 × capacity - baseline performance}, where baseline performance = min{1800 + 50 × capacity, 50000}.</para>
        /// <remarks>
        /// <para>For more information about ESSD AutoPL cloud disks, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
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
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of IP addresses of DNS servers.</para>
        /// </summary>
        [NameInMap("DnsConfigNameServers")]
        [Validation(Required=false)]
        public List<string> DnsConfigNameServers { get; set; }

        /// <summary>
        /// <para>The list of object options. Each object consists of a Name and an optional Value.</para>
        /// </summary>
        [NameInMap("DnsConfigOptions")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestDnsConfigOptions> DnsConfigOptions { get; set; }
        public class ModifyEciScalingConfigurationRequestDnsConfigOptions : TeaModel {
            /// <summary>
            /// <para>The name of the object variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The value of the object variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The list of DNS search domains.</para>
        /// </summary>
        [NameInMap("DnsConfigSearchs")]
        [Validation(Required=false)]
        public List<string> DnsConfigSearchs { get; set; }

        /// <summary>
        /// <para>The DNS policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>None: uses the DNS settings specified in the DnsConfig field.</para>
        /// </description></item>
        /// <item><description><para>Default: inherits the DNS settings from the runtime environment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("DnsPolicy")]
        [Validation(Required=false)]
        public string DnsPolicy { get; set; }

        /// <summary>
        /// <para>The outbound bandwidth limit. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024000</para>
        /// </summary>
        [NameInMap("EgressBandwidth")]
        [Validation(Required=false)]
        public long? EgressBandwidth { get; set; }

        /// <summary>
        /// <para>The bandwidth of the EIP.</para>
        /// <para>Default value: 5 Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("EipBandwidth")]
        [Validation(Required=false)]
        public int? EipBandwidth { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSls")]
        [Validation(Required=false)]
        public bool? EnableSls { get; set; }

        /// <summary>
        /// <para>The size of the temporary storage space. By default, PL1 ESSDs are used. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("EphemeralStorage")]
        [Validation(Required=false)]
        public int? EphemeralStorage { get; set; }

        /// <summary>
        /// <para>The specified GPU driver version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tesla=470.82.01 (default)</description></item>
        /// <item><description>tesla=525.85.12</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only specific instance types support switching the GPU driver version. For more information, see <a href="https://help.aliyun.com/document_detail/2579486.html">Create an instance by specifying a GPU instance type</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tesla=525.85.12</para>
        /// </summary>
        [NameInMap("GpuDriverVersion")]
        [Validation(Required=false)]
        public string GpuDriverVersion { get; set; }

        /// <summary>
        /// <para>The host-related information.</para>
        /// </summary>
        [NameInMap("HostAliases")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestHostAliases> HostAliases { get; set; }
        public class ModifyEciScalingConfigurationRequestHostAliases : TeaModel {
            /// <summary>
            /// <para>The hostname to be added.</para>
            /// </summary>
            [NameInMap("Hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            /// <summary>
            /// <para>The IP address to be added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        /// <summary>
        /// <para>The hostname, which is the name of the container group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The details of the image registry.</para>
        /// </summary>
        [NameInMap("ImageRegistryCredentials")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestImageRegistryCredentials> ImageRegistryCredentials { get; set; }
        public class ModifyEciScalingConfigurationRequestImageRegistryCredentials : TeaModel {
            /// <summary>
            /// <para>The password for the image registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourpaasword</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The address of the image registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// <para>The username for the image registry.</para>
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
        /// <para>The inbound bandwidth limit. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024000</para>
        /// </summary>
        [NameInMap("IngressBandwidth")]
        [Validation(Required=false)]
        public long? IngressBandwidth { get; set; }

        /// <summary>
        /// <para>The list of init containers.</para>
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
                    /// <summary>
                    /// <para>Grants specific privileges to processes in the container. Valid values: NET_ADMIN and NET_RAW.</para>
                    /// <remarks>
                    /// <para>NET_RAW is not supported by default. To use NET_RAW, submit a ticket.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Adds")]
                    [Validation(Required=false)]
                    public List<string> Adds { get; set; }

                }

                /// <summary>
                /// <remarks>
                /// <para>This parameter is not available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? ReadOnlyRootFilesystem { get; set; }

                /// <summary>
                /// <para>The user ID to run the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>587</para>
                /// </summary>
                [NameInMap("RunAsUser")]
                [Validation(Required=false)]
                public long? RunAsUser { get; set; }

            }

            /// <summary>
            /// <para>The startup arguments for the container.</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public List<string> Args { get; set; }

            /// <summary>
            /// <para>The startup commands for the container.</para>
            /// </summary>
            [NameInMap("Commands")]
            [Validation(Required=false)]
            public List<string> Commands { get; set; }

            /// <summary>
            /// <para>The number of vCPUs allocated to the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// <para>The number of GPUs allocated to the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            /// <summary>
            /// <para>The image used by the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nginx</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The image pull policy for the container. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Always: Always pulls the image.</description></item>
            /// <item><description>IfNotPresent: Pulls the image only if it is not present locally.</description></item>
            /// <item><description>Never: Never pulls the image. Only local images are used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Always</para>
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// <para>The environment variable information of the init container.</para>
            /// </summary>
            [NameInMap("InitContainerEnvironmentVars")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVars> InitContainerEnvironmentVars { get; set; }
            public class ModifyEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVars : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=false)]
                public ModifyEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVarsFieldRef FieldRef { get; set; }
                public class ModifyEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVarsFieldRef : TeaModel {
                    /// <summary>
                    /// <remarks>
                    /// <para>This parameter is not available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>path</para>
                    /// </summary>
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }

                }

                /// <summary>
                /// <para>The name of the environment variable. The name must be 1 to 128 characters in length. It can contain letters, digits, and underscores (_), and cannot start with a digit.</para>
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
            /// <para>The port information of the init container.</para>
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
            /// <para>The array of mount point information for the init container.</para>
            /// </summary>
            [NameInMap("InitContainerVolumeMounts")]
            [Validation(Required=false)]
            public List<ModifyEciScalingConfigurationRequestInitContainersInitContainerVolumeMounts> InitContainerVolumeMounts { get; set; }
            public class ModifyEciScalingConfigurationRequestInitContainersInitContainerVolumeMounts : TeaModel {
                /// <summary>
                /// <para>The directory where the volume is mounted in the container.</para>
                /// <remarks>
                /// <para>The contents of the mount path in the container are directly overwritten by the contents of the volume. Use this parameter with caution.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/share/</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The mount propagation settings for the volume. Mount propagation allows a volume mounted to a container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>None: The volume is not aware of any subsequent mount operations performed on the volume or its subdirectories.</description></item>
                /// <item><description>HostToCotainer: The volume is aware of subsequent mount operations performed on the volume or its subdirectories.</description></item>
                /// <item><description>Bidirectional: Similar to HostToCotainer, the volume is aware of mount operations. In addition, the volume is propagated back to the host and to all containers of all pods that use the same volume.</description></item>
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
                /// <para>The name of the mounted volume.</para>
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
                /// <para>The subdirectory under the volume. This allows a pod to mount different directories under the same volume to different directories in the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Always</para>
                /// </summary>
                [NameInMap("SubPath")]
                [Validation(Required=false)]
                public string SubPath { get; set; }

            }

            /// <summary>
            /// <para>The memory size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The name of the container.</para>
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
        /// <para>The level of the instance family. This parameter is used to filter instance types that meet your requirements and takes effect only when CostOptimization is set to true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EntryLevel: shared instance types. Shared instance types are more cost-effective but cannot guarantee stable computing performance. They are suitable for business scenarios with low CPU utilization. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
        /// <item><description>EnterpriseLevel: enterprise-level instance types. Enterprise-level instance types provide stable performance and dedicated resources. They are suitable for business scenarios that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</description></item>
        /// <item><description>CreditEntryLevel: burstable instance types. Burstable instance types use CPU credits to ensure computing performance. They are suitable for business scenarios with low CPU utilization but occasional CPU usage spikes. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseLevel</para>
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <para>The specified ECS instance types. You can specify up to five instance types.</para>
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
        /// <para>The weight of the backend server. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("LoadBalancerWeight")]
        [Validation(Required=false)]
        public int? LoadBalancerWeight { get; set; }

        /// <summary>
        /// <para>The memory size for the instance. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The NTP server.</para>
        /// </summary>
        [NameInMap("NtpServers")]
        [Validation(Required=false)]
        public List<string> NtpServers { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Overwrite.</description></item>
        /// <item><description>false: Do not overwrite.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Override")]
        [Validation(Required=false)]
        public bool? Override { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the RAM role for the instance. ECIs and ECS instances share the same instance RAM roles. For more information, see <a href="https://help.aliyun.com/document_detail/61178.html">Use an instance RAM role by calling API operations</a>.</para>
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
        /// <para>The restart policy of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Always: always restarts the instance.</description></item>
        /// <item><description>Never: never restarts the instance.</description></item>
        /// <item><description>OnFailure: restarts the instance when it fails.</description></item>
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
        /// <para>The ID of the scaling configuration to be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc-bp16har3jpj6fjbx****</para>
        /// </summary>
        [NameInMap("ScalingConfigurationId")]
        [Validation(Required=false)]
        public string ScalingConfigurationId { get; set; }

        /// <summary>
        /// <para>The name of the scaling configuration. The name must be 2 to 64 characters in length, and can contain digits, letters, and Chinese characters. It must start with a digit, a letter, or a Chinese character, and can contain digits, underscores (_), hyphens (-), and periods (.).</para>
        /// <para>The name of a scaling configuration must be unique within a scaling group in a region. If you do not specify this parameter, the ID of the scaling configuration is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-modify</para>
        /// </summary>
        [NameInMap("ScalingConfigurationName")]
        [Validation(Required=false)]
        public string ScalingConfigurationName { get; set; }

        /// <summary>
        /// <para>The system information of the contextual security context in which the instance runs.</para>
        /// </summary>
        [NameInMap("SecurityContextSysCtls")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestSecurityContextSysCtls> SecurityContextSysCtls { get; set; }
        public class ModifyEciScalingConfigurationRequestSecurityContextSysCtls : TeaModel {
            /// <summary>
            /// <para>The system name of the security context in which the instance runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kernel.msgmax</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The variable value of the contextual security context in which the instance runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65536</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the security group to which the ECI instance belongs. ECI instances in the same security group can access each other.</para>
        /// <para>If you do not specify a security group, the system automatically uses the default security group in the selected region. You must ensure that the inbound rules of the security group include the protocols and ports that the containers need to expose. If no default security group exists in the region, the system performs automatic creation of a default security group and adds the declared container protocols and ports to the inbound rules of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The maximum hourly price for the spot instance. The value can be accurate to three decimal places.</para>
        /// <para>This parameter is required when SpotStrategy is set to SpotWithPriceLimit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.025</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The preemption policy for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: applies to regular pay-as-you-go instances.</description></item>
        /// <item><description>SpotWithPriceLimit: applies to spot instances that have maximum hourly prices.</description></item>
        /// <item><description>SpotAsPriceGo: applies to spot instances whose prices are automatically set by the system based on the current market price.</description></item>
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
        /// <para>The buffer time for the program to handle operations before shutdown. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public long? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// <para>The volume information.</para>
        /// </summary>
        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public List<ModifyEciScalingConfigurationRequestVolumes> Volumes { get; set; }
        public class ModifyEciScalingConfigurationRequestVolumes : TeaModel {
            [NameInMap("DiskVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesDiskVolume DiskVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesDiskVolume : TeaModel {
                /// <summary>
                /// <para>The ID of the disk volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-xx</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>The size of the disk volume. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// <para>This file system type is deprecated. Use the FlexVolume.FsType parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xfs</para>
                /// </summary>
                [NameInMap("FsType")]
                [Validation(Required=false)]
                public string FsType { get; set; }

            }

            [NameInMap("EmptyDirVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesEmptyDirVolume EmptyDirVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesEmptyDirVolume : TeaModel {
                /// <summary>
                /// <para>The storage medium of the EmptyDirVolume. The default value is empty, which indicates that the node file system is used. If this parameter is set to memory, the memory is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>memory</para>
                /// </summary>
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                /// <summary>
                /// <para>The size of the EmptyDir volume. Specify a unit for the value, such as Gi or Mi.</para>
                /// 
                /// <b>Example:</b>
                /// <para>256Mi</para>
                /// </summary>
                [NameInMap("SizeLimit")]
                [Validation(Required=false)]
                public string SizeLimit { get; set; }

            }

            [NameInMap("FlexVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesFlexVolume FlexVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesFlexVolume : TeaModel {
                /// <summary>
                /// <para>The name of the driver used for the FlexVolume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flexvolume</para>
                /// </summary>
                [NameInMap("Driver")]
                [Validation(Required=false)]
                public string Driver { get; set; }

                /// <summary>
                /// <para>The type of the file system to be mounted. The default value depends on the script of the FlexVolume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ext4</para>
                /// </summary>
                [NameInMap("FsType")]
                [Validation(Required=false)]
                public string FsType { get; set; }

                /// <summary>
                /// <para>The list of options for the FlexVolume object. The options are passed as key-value pairs in JSON format.</para>
                /// <para>Example: When you mount a cloud disk by using FlexVolume, the format of Options is <c>{&quot;volumeId&quot;:&quot;d-2zehdahrwoa7srg****&quot;,&quot;performanceLevel&quot;: &quot;PL2&quot;}</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;volumeId&quot;:&quot;d-2zehdahrwoa7srg****&quot;,&quot;performanceLevel&quot;: &quot;PL2&quot;}</para>
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

            }

            [NameInMap("HostPathVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesHostPathVolume HostPathVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesHostPathVolume : TeaModel {
                /// <summary>
                /// <para>The absolute path on the host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/xx/xx/name</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The type of the host directory, such as File, Directory, or Socket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Directory</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("NFSVolume")]
            [Validation(Required=false)]
            public ModifyEciScalingConfigurationRequestVolumesNFSVolume NFSVolume { get; set; }
            public class ModifyEciScalingConfigurationRequestVolumesNFSVolume : TeaModel {
                /// <summary>
                /// <para>The path of the NFS volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/share</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the NFS volume is read-only.</para>
                /// <para>Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The address of the NFS server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3f9cd4a596-n****.cn-shanghai.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The list of configuration file paths.</para>
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
                /// <para>The directory permissions for the ConfigFileVolume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0644</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public int? Mode { get; set; }

                /// <summary>
                /// <para>The relative file path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/bin/</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// <para>The default permissions for the ConfigFileVolume.</para>
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
            /// <para>The volume type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EmptyDirVolume</description></item>
            /// <item><description>NFSVolume</description></item>
            /// <item><description>ConfigFileVolume</description></item>
            /// <item><description>FlexVolume</description></item>
            /// </list>
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
