// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateEciScalingConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The information about the Container Registry Enterprise instances.</para>
        /// </summary>
        [NameInMap("AcrRegistryInfos")]
        [Validation(Required=false)]
        public List<CreateEciScalingConfigurationRequestAcrRegistryInfos> AcrRegistryInfos { get; set; }
        public class CreateEciScalingConfigurationRequestAcrRegistryInfos : TeaModel {
            /// <summary>
            /// <para>The domain names of the Container Registry Enterprise instance. By default, all domain names of the instance are used. You can specify one or more domain names. Separate multiple domain names with commas (,).</para>
            /// </summary>
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }

            /// <summary>
            /// <para>The instance ID of the Container Registry Enterprise instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-nwj395hgf6f3****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the Container Registry Enterprise instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acr-test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The region where the Container Registry Enterprise instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
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
        /// <para>Specifies whether automatic creation of an elastic IP address (EIP) is performed and the EIP is attached to the ECI instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoCreateEip")]
        [Validation(Required=false)]
        public bool? AutoCreateEip { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically match an image cache. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
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
        /// <para>The name of the ECI instance, which is the name of the container group.</para>
        /// <para>To set a sequential instance name, use the following format: name_prefix(AUTO_INCREMENT)[begin_number,bits]name_suffix.</para>
        /// <list type="bullet">
        /// <item><description><para><b>name_prefix</b>: the prefix of the hostname.</para>
        /// </description></item>
        /// <item><description><para><b>(AUTO_INCREMENT)</b>: a fixed value that identifies this sorting method.</para>
        /// </description></item>
        /// <item><description><para><b>begin_number</b>: the start value of the sequential number. Valid values: 0 to 999999.</para>
        /// </description></item>
        /// <item><description><para><b>bits</b>: the number of digits of the sequential number. Valid values: 1 to 6. If the number of digits of the specified begin_number is greater than the value of bits, bits defaults to 6.
        /// <notice>We recommend that you set bits to at least 3. Otherwise, the upper limit of the sequential number is easily reached. After the upper limit is reached, if scale-out is still required, the scaling activity reports an error and stops. In this case, you must reset the rule for generating hostnames.</notice></para>
        /// </description></item>
        /// <item><description><para><b>name_suffix</b> (optional): the suffix of the hostname.</para>
        /// </description></item>
        /// </list>
        /// <para><notice>No spaces are allowed in [begin_number,bits]. The system increments the number sequentially by default. However, if an ECI instance created during scale-out fails to start, the instance is removed from the scaling group and a new ECI instance is created. Therefore, the hostnames of ECI instances in the scaling group may be incremented discontinuously.</notice></para>
        /// <para><b>Example:</b> If you set the value to nginx-test-(AUTO_INCREMENT)[0,3], the container group names are nginx-test-000, nginx-test-001, and nginx-test-002.</para>
        /// <para>The rules for setting sequential ECI instance names are the same as those for setting sequential ECS instance names in a scaling group. For more information, see <a href="https://help.aliyun.com/document_detail/203831.html">Set a rule for sequential and unique instance names or hostnames</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nginx-test-(AUTO_INCREMENT)[0,3]</para>
        /// </summary>
        [NameInMap("ContainerGroupName")]
        [Validation(Required=false)]
        public string ContainerGroupName { get; set; }

        /// <summary>
        /// <para>The list of containers included in the instance.</para>
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
                    /// <summary>
                    /// <para>The command executed in the container when the exec probe is used for health checks.</para>
                    /// </summary>
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

                /// <summary>
                /// <para>The minimum consecutive failures for the probe to be considered failed after having succeeded.</para>
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
                public CreateEciScalingConfigurationRequestContainersLivenessProbeHttpGet HttpGet { get; set; }
                public class CreateEciScalingConfigurationRequestContainersLivenessProbeHttpGet : TeaModel {
                    /// <summary>
                    /// <para>The path accessed by the HTTP GET request when the HTTP probe is used for health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/healthyz</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The port number on which the HTTP GET probe performs health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8888</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The protocol type used for the HTTP GET request when the HTTP probe is used for health checks. Valid values:</para>
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
                /// <para>The number of seconds after the container has started before the probe is initiated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                /// <summary>
                /// <para>The interval at which the probe is performed in seconds. Default value: 10. Minimum value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                /// <summary>
                /// <para>The minimum consecutive successes for the probe to be considered successful after having failed. Default value: 1. The current value must be 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                [NameInMap("TcpSocket")]
                [Validation(Required=false)]
                public CreateEciScalingConfigurationRequestContainersLivenessProbeTcpSocket TcpSocket { get; set; }
                public class CreateEciScalingConfigurationRequestContainersLivenessProbeTcpSocket : TeaModel {
                    /// <summary>
                    /// <para>The port number on which the TCP socket probe performs health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8000</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }

                /// <summary>
                /// <para>The timeout period for the probe in seconds. Default value: 1. Minimum value: 1.</para>
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
            public CreateEciScalingConfigurationRequestContainersReadinessProbe ReadinessProbe { get; set; }
            public class CreateEciScalingConfigurationRequestContainersReadinessProbe : TeaModel {
                [NameInMap("Exec")]
                [Validation(Required=false)]
                public CreateEciScalingConfigurationRequestContainersReadinessProbeExec Exec { get; set; }
                public class CreateEciScalingConfigurationRequestContainersReadinessProbeExec : TeaModel {
                    /// <summary>
                    /// <para>The command executed in the container when the exec probe is used for health checks.</para>
                    /// </summary>
                    [NameInMap("Commands")]
                    [Validation(Required=false)]
                    public List<string> Commands { get; set; }

                }

                /// <summary>
                /// <para>The minimum consecutive failures for the probe to be considered failed after having succeeded. Default value: 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public CreateEciScalingConfigurationRequestContainersReadinessProbeHttpGet HttpGet { get; set; }
                public class CreateEciScalingConfigurationRequestContainersReadinessProbeHttpGet : TeaModel {
                    /// <summary>
                    /// <para>The path accessed by the HTTP GET request when the HTTP probe is used for health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/healthz</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The port number on which the HTTP GET probe performs health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8080</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The protocol type used for the HTTP GET request when the HTTP probe is used for health checks. Valid values:</para>
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
                /// <para>The number of seconds after the container has started before the probe is initiated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                /// <summary>
                /// <para>The interval at which the probe is performed in seconds. Default value: 10. Minimum value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                /// <summary>
                /// <para>The minimum consecutive successes for the probe to be considered successful after having failed. Default value: 1. The current value must be 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                [NameInMap("TcpSocket")]
                [Validation(Required=false)]
                public CreateEciScalingConfigurationRequestContainersReadinessProbeTcpSocket TcpSocket { get; set; }
                public class CreateEciScalingConfigurationRequestContainersReadinessProbeTcpSocket : TeaModel {
                    /// <summary>
                    /// <para>The port number on which the TCP socket probe performs health checks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8000</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }

                /// <summary>
                /// <para>The timeout period for the probe in seconds. Default value: 1. Minimum value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
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
                    /// <summary>
                    /// <para>Grants specific privileges to processes in the container. Currently, only NET_ADMIN and NET_RAW are supported.</para>
                    /// <remarks>
                    /// <para>NET_RAW is not supported by default. To use NET_RAW, submit a ticket.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Add")]
                    [Validation(Required=false)]
                    public List<string> Add { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether the root file system of the container is read-only. Currently, only true is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? ReadOnlyRootFilesystem { get; set; }

                /// <summary>
                /// <para>The user ID used to run the container.</para>
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
            /// <para>The number of CPU cores allocated to the container.</para>
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
            public List<CreateEciScalingConfigurationRequestContainersEnvironmentVars> EnvironmentVars { get; set; }
            public class CreateEciScalingConfigurationRequestContainersEnvironmentVars : TeaModel {
                /// <summary>
                /// <remarks>
                /// <para>This parameter is unavailable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>fieldPath</para>
                /// </summary>
                [NameInMap("FieldRefFieldPath")]
                [Validation(Required=false)]
                public string FieldRefFieldPath { get; set; }

                /// <summary>
                /// <para>The name of the environment variable. The name must be 1 to 128 characters in length and can contain letters, digits, and underscores (_). It cannot start with a digit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PATH</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the environment variable. The value must be 0 to 256 characters in length.</para>
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
            /// <para>The container image. You can pull images from an image repository such as Docker Hub and Alibaba Cloud Container Registry (ACR). When you pull an image over the Internet, if no NAT gateway is created in the VPC, you must associate the ECI instance with an EIP.</para>
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
            /// <remarks>
            /// <para>If image caching is enabled, ImagePullPolicy is overridden to Always when the container is created.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Always</para>
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// <para>The command executed in the container when the command line method is used to configure the postStart callback function.</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerExecs")]
            [Validation(Required=false)]
            public List<string> LifecyclePostStartHandlerExecs { get; set; }

            /// <summary>
            /// <para>The host address that receives the HTTP GET request when the HTTP request method is used to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetHost { get; set; }

            /// <summary>
            /// <para>The path accessed by the HTTP GET request when the HTTP request method is used to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthyz</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetPath { get; set; }

            /// <summary>
            /// <para>The port number checked by the HTTP GET request when the HTTP request method is used to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5050</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerHttpGetPort { get; set; }

            /// <summary>
            /// <para>The protocol type used for the HTTP GET request when the HTTP request method is used to configure the postStart callback function. Valid values:</para>
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
            /// <para>The host address checked by the TCP socket when the TCP socket method is used to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// <para>The port checked by the TCP socket when the TCP socket method is used to configure the postStart callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// <para>The command executed in the container when the command line method is used to configure the preStop callback function.</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerExecs")]
            [Validation(Required=false)]
            public List<string> LifecyclePreStopHandlerExecs { get; set; }

            /// <summary>
            /// <para>The host address that receives the HTTP GET request when the HTTP request method is used to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetHost { get; set; }

            /// <summary>
            /// <para>The path accessed by the HTTP GET request when the HTTP request method is used to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthyz</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetPath { get; set; }

            /// <summary>
            /// <para>The port number checked by the HTTP GET request when the HTTP request method is used to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerHttpGetPort { get; set; }

            /// <summary>
            /// <para>The protocol type used for the HTTP GET request when the HTTP request method is used to configure the preStop callback function. Valid values:</para>
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
            /// <para>The host address checked by the TCP socket when the TCP socket method is used to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// <para>The port checked by the TCP socket when the TCP socket method is used to configure the preStop callback function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// <para>The memory size of the container. Unit: GiB.</para>
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
            /// <para>The list of ports.</para>
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public List<CreateEciScalingConfigurationRequestContainersPorts> Ports { get; set; }
            public class CreateEciScalingConfigurationRequestContainersPorts : TeaModel {
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
            /// <para>Specifies whether to allocate a buffer for standard input (stdin) during container runtime. If this parameter is not set, reads from stdin in the container result in an EOF.</para>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Stdin")]
            [Validation(Required=false)]
            public bool? Stdin { get; set; }

            /// <summary>
            /// <para>Specifies whether the standard input stream maintains the enabling status across multiple attached sessions when stdin is set to true.</para>
            /// <para>If StdinOnce is set to true, standard input is opened when the container starts and remains empty until the first client attaches to it. It then stays open to accept data until the client disconnects, at which point standard input is shutdown and remains shutdown until the container is restarted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("StdinOnce")]
            [Validation(Required=false)]
            public bool? StdinOnce { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable interactive mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// <para>For example, if Command is set to /bin/bash, set this parameter to true.</para>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Tty")]
            [Validation(Required=false)]
            public bool? Tty { get; set; }

            /// <summary>
            /// <para>The volume mount information of the container.</para>
            /// </summary>
            [NameInMap("VolumeMounts")]
            [Validation(Required=false)]
            public List<CreateEciScalingConfigurationRequestContainersVolumeMounts> VolumeMounts { get; set; }
            public class CreateEciScalingConfigurationRequestContainersVolumeMounts : TeaModel {
                /// <summary>
                /// <para>The directory where the volume is mounted in the container.</para>
                /// <remarks>
                /// <para>Notice: The contents of the container mount directory are directly overwritten by the contents of the volume. Proceed with caution.</para>
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
                /// <para>The name of the volume. The value must be the same as the Name value in Volumes.</para>
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
                /// <item><description><para>true: Yes.</para>
                /// </description></item>
                /// <item><description><para>false: No.</para>
                /// </description></item>
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
        /// <para>Specifies whether to enable cost optimization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
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
        /// <para>The performance level of the cloud disk used for data caching. ESSDs are recommended. Valid values for the performance level of an ESSD:</para>
        /// <list type="bullet">
        /// <item><description>PL0: An ESSD at PL0 delivers up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: An ESSD at PL1 delivers up to 50,000 random read/write IOPS.</description></item>
        /// <item><description>PL2: An ESSD at PL2 delivers up to 100,000 random read/write IOPS.</description></item>
        /// <item><description>PL3: An ESSD at PL3 delivers up to 1,000,000 random read/write IOPS.</description></item>
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
        /// <para>The provisioned read/write IOPS of the ESSD AutoPL cloud disk used for data caching. Valid values: 0 to min{50000, 1000 × capacity - baseline performance}, where baseline performance = min{1800 + 50 × capacity, 50000}.</para>
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
        /// <para>This parameter is unavailable.</para>
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
        public List<CreateEciScalingConfigurationRequestDnsConfigOptions> DnsConfigOptions { get; set; }
        public class CreateEciScalingConfigurationRequestDnsConfigOptions : TeaModel {
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
        /// <item><description><para>None: Uses the DNS settings specified in the DnsConfig field.</para>
        /// </description></item>
        /// <item><description><para>Default: Inherits the DNS settings of the runtime environment.</para>
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
        /// <para>The bandwidth of the EIP. Default value: 5 Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("EipBandwidth")]
        [Validation(Required=false)]
        public int? EipBandwidth { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is unavailable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSls")]
        [Validation(Required=false)]
        public bool? EnableSls { get; set; }

        /// <summary>
        /// <para>The size of the ephemeral storage space. By default, a PL1 ESSD cloud disk is used. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("EphemeralStorage")]
        [Validation(Required=false)]
        public int? EphemeralStorage { get; set; }

        /// <summary>
        /// <para>The GPU driver version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tesla=470.82.01 (default)</description></item>
        /// <item><description>tesla=525.85.12</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only specific instance types support switching the GPU driver version. For more information, see <a href="https://help.aliyun.com/document_detail/2579486.html">Create a GPU-accelerated instance</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tesla=525.85.12</para>
        /// </summary>
        [NameInMap("GpuDriverVersion")]
        [Validation(Required=false)]
        public string GpuDriverVersion { get; set; }

        /// <summary>
        /// <para>The custom hostname mappings for a container in the instance.</para>
        /// </summary>
        [NameInMap("HostAliases")]
        [Validation(Required=false)]
        public List<CreateEciScalingConfigurationRequestHostAliases> HostAliases { get; set; }
        public class CreateEciScalingConfigurationRequestHostAliases : TeaModel {
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
            /// <para>1.1.1.1</para>
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
        public List<CreateEciScalingConfigurationRequestImageRegistryCredentials> ImageRegistryCredentials { get; set; }
        public class CreateEciScalingConfigurationRequestImageRegistryCredentials : TeaModel {
            /// <summary>
            /// <para>The password of the image registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourpassword</para>
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
            /// <para>The username of the image registry.</para>
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
                    /// <summary>
                    /// <para>Grants specific permissions to processes in the container. Only NET_ADMIN and NET_RAW are supported.</para>
                    /// <remarks>
                    /// <para>NET_RAW is not supported by default. Submit a ticket to apply for this permission.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Adds")]
                    [Validation(Required=false)]
                    public List<string> Adds { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether the root file system where the container runs is read-only. Only true is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? ReadOnlyRootFilesystem { get; set; }

                /// <summary>
                /// <para>The user ID used to run the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>587</para>
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
            /// <para>The startup commands of the container.</para>
            /// </summary>
            [NameInMap("Commands")]
            [Validation(Required=false)]
            public List<string> Commands { get; set; }

            /// <summary>
            /// <para>The number of vCPUs for the container. Unit: cores.</para>
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
            /// <para>The image pull policy.</para>
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
            public List<CreateEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVars> InitContainerEnvironmentVars { get; set; }
            public class CreateEciScalingConfigurationRequestInitContainersInitContainerEnvironmentVars : TeaModel {
                /// <summary>
                /// <remarks>
                /// <para>This parameter is unavailable.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>path</para>
                /// </summary>
                [NameInMap("FieldRefFieldPath")]
                [Validation(Required=false)]
                public string FieldRefFieldPath { get; set; }

                /// <summary>
                /// <para>The name of the environment variable. The name must be 1 to 128 characters in length and can contain letters, digits, and underscores (_). It cannot start with a digit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Path</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the environment variable. The value must be 0 to 256 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/bin/</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The list of port mappings for the init container.</para>
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
            /// <para>The array of mount point information for the init container.</para>
            /// </summary>
            [NameInMap("InitContainerVolumeMounts")]
            [Validation(Required=false)]
            public List<CreateEciScalingConfigurationRequestInitContainersInitContainerVolumeMounts> InitContainerVolumeMounts { get; set; }
            public class CreateEciScalingConfigurationRequestInitContainersInitContainerVolumeMounts : TeaModel {
                /// <summary>
                /// <para>The mount directory. The content in the mount directory of the container is directly overwritten by the content of the volume. Use this parameter with caution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/share/</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The mount propagation settings of the volume. Mount propagation allows a volume mounted by a container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>None: The volume is not aware of any subsequent mount operations performed on this volume or its subdirectories.</description></item>
                /// <item><description>HostToCotainer: The volume is aware of subsequent mount operations performed on this volume or its subdirectories.</description></item>
                /// <item><description>Bidirectional: Similar to HostToCotainer, the volume is aware of mount operations. In addition, the volume is propagated back to the host and to all containers of all pods that use the same volume.</description></item>
                /// </list>
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
                /// <para>Specifies whether the mount path is read-only.
                /// Default value: false.</para>
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
                /// <para>/usr/sub/</para>
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
        /// <para>The instance family level, which is used to filter instance types that meet your requirements. This parameter takes effect only when CostOptimization is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EntryLevel: entry-level, which indicates shared instance types. Shared instance types are more cost-effective but cannot guarantee stable computing performance. They are suitable for business scenarios with low average CPU utilization. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
        /// <item><description>EnterpriseLevel: enterprise-level. Enterprise-level instance types provide stable performance and dedicated resources, and are suitable for business scenarios that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</description></item>
        /// <item><description>CreditEntryLevel: credit entry-level, which indicates burstable instances. Burstable instances use CPU credits to ensure computing performance and are suitable for business scenarios with low average CPU utilization but occasional CPU bursts. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
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
        /// <para>The weight of the ECI instance when it is used as a backend server for load balancing. Valid values: 1 to 100.</para>
        /// <para>Default value: 50.</para>
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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the instance RAM role. ECI and ECS share instance RAM roles. For more information, see <a href="https://help.aliyun.com/document_detail/61175.html">Instance RAM roles</a>.</para>
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
        /// <para>The restart policy of the ECI instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Always: Always restarts the instance.</description></item>
        /// <item><description>Never: Never restarts the instance.</description></item>
        /// <item><description>OnFailure: Restarts the instance upon failure.</description></item>
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
        /// <para>The name of the scaling configuration. The name must be 2 to 64 characters in length and start with a digit, letter, or Chinese character. It can contain digits, underscores (_), hyphens (-), and periods (.).</para>
        /// <para>The name must be unique within a scaling group in a region. If you do not specify this parameter, the ID of the scaling configuration is used by default.</para>
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
        /// <para>The security context system information for the instance.</para>
        /// </summary>
        [NameInMap("SecurityContextSysctls")]
        [Validation(Required=false)]
        public List<CreateEciScalingConfigurationRequestSecurityContextSysctls> SecurityContextSysctls { get; set; }
        public class CreateEciScalingConfigurationRequestSecurityContextSysctls : TeaModel {
            /// <summary>
            /// <para>The system name of the security context for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kernel.msgmax</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The contextual variable value of the security context for the instance.</para>
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
        /// <para>If you do not specify a security group, the system automatically uses the default security group in the selected region. You must ensure that the inbound rules of this security group include the protocols and ports that the containers need to expose. If no default security group exists in the region, the system performs automatic creation of a default security group and adds the declared container protocols and ports to the inbound rules of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The maximum hourly price for the spot instance. The value is accurate to three decimal places.</para>
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
        /// <item><description>NoSpot: Regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: Spot instance with a maximum price limit.</description></item>
        /// <item><description>SpotAsPriceGo: Spot instance whose price automatically follows the current market price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SpotWithPriceLimit</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The tags of the ECI instance. Tags are passed as key-value pairs. You can use up to 20 tags. The requirements for keys and values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>A key can be up to 64 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>. A key cannot be an empty string.</description></item>
        /// <item><description>A value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>. A value can be an empty string.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateEciScalingConfigurationRequestTags> Tags { get; set; }
        public class CreateEciScalingConfigurationRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance.</para>
            /// <para>If you specify this parameter, it cannot be an empty string. It can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>version</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance.</para>
            /// <para>If you specify this parameter, it can be an empty string. It can be up to 128 characters in length, and cannot start with <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
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
        public List<CreateEciScalingConfigurationRequestVolumes> Volumes { get; set; }
        public class CreateEciScalingConfigurationRequestVolumes : TeaModel {
            [NameInMap("DiskVolume")]
            [Validation(Required=false)]
            public CreateEciScalingConfigurationRequestVolumesDiskVolume DiskVolume { get; set; }
            public class CreateEciScalingConfigurationRequestVolumesDiskVolume : TeaModel {
                /// <summary>
                /// <para>The ID of the DiskVolume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-xx</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>The size of the DiskVolume. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// <para>This file system type is not recommended. Use the FlexVolume.FsType parameter instead.</para>
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
            public CreateEciScalingConfigurationRequestVolumesEmptyDirVolume EmptyDirVolume { get; set; }
            public class CreateEciScalingConfigurationRequestVolumesEmptyDirVolume : TeaModel {
                /// <summary>
                /// <para>The storage medium of the EmptyDirVolume. The default value is empty, which indicates that the node file system is used. The value memory is supported, which indicates that memory is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>memory</para>
                /// </summary>
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                /// <summary>
                /// <para>The size of the EmptyDir volume. Specify a unit for the value. Use Gi or Mi.</para>
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
            public CreateEciScalingConfigurationRequestVolumesFlexVolume FlexVolume { get; set; }
            public class CreateEciScalingConfigurationRequestVolumesFlexVolume : TeaModel {
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
                /// <para>The list of FlexVolume object options. The options are in key-value pairs and passed in JSON format.
                /// For example, when you mount a cloud disk by using FlexVolume, the format of Options is <c>{&quot;volumeId&quot;:&quot;d-2zehdahrwoa7srg****&quot;,&quot;performanceLevel&quot;: &quot;PL2&quot;}</c>.</para>
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
            public CreateEciScalingConfigurationRequestVolumesHostPathVolume HostPathVolume { get; set; }
            public class CreateEciScalingConfigurationRequestVolumesHostPathVolume : TeaModel {
                /// <summary>
                /// <para>The absolute path on the host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/xx/xx/path</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The type of the host directory. Examples: File, Directory, and Socket.</para>
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
            public CreateEciScalingConfigurationRequestVolumesNFSVolume NFSVolume { get; set; }
            public class CreateEciScalingConfigurationRequestVolumesNFSVolume : TeaModel {
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
                /// <para>Specifies whether the NFS volume is read-only. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Yes.</description></item>
                /// <item><description>false: No.
                /// Default value: false.</description></item>
                /// </list>
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
                /// <para>3f9cd4a596-naw76.cn-shanghai.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The list of configuration file paths.</para>
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
                /// <para>The directory permissions of the ConfigFileVolume.</para>
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
            /// <para>The default permissions of the ConfigFileVolume.</para>
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
            /// <item><description>EmptyDirVolume: the EmptyDir volume, which represents an empty directory.</description></item>
            /// <item><description>NFSVolume: the NFS volume, which represents a network file system.</description></item>
            /// <item><description>ConfigFileVolume: the ConfigFile volume, which represents a configuration file.</description></item>
            /// <item><description>FlexVolume: uses the FlexVolume plug-in to extend storage types and supports mounting cloud disks.</description></item>
            /// <item><description>HostPathVolume: the HostPath volume, which represents a file or directory on the host node.</description></item>
            /// <item><description>DiskVolume (not recommended): the cloud disk volume. Use FlexVolume to mount cloud disks instead.</description></item>
            /// </list>
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
