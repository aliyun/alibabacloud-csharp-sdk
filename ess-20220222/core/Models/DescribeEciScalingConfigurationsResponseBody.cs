// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeEciScalingConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scaling configurations.</para>
        /// </summary>
        [NameInMap("ScalingConfigurations")]
        [Validation(Required=false)]
        public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurations> ScalingConfigurations { get; set; }
        public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurations : TeaModel {
            /// <summary>
            /// <para>The information about the ACR Enterprise instance.</para>
            /// </summary>
            [NameInMap("AcrRegistryInfos")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsAcrRegistryInfos> AcrRegistryInfos { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsAcrRegistryInfos : TeaModel {
                /// <summary>
                /// <para>The domain names of the ACR Enterprise instance. By default, all domain names of the instance are used. You can specify one or more domain names. Separate multiple domain names with commas (,).</para>
                /// </summary>
                [NameInMap("Domains")]
                [Validation(Required=false)]
                public List<string> Domains { get; set; }

                /// <summary>
                /// <para>The instance ID of the ACR Enterprise instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cri-nwj395hgf6f3****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the ACR Enterprise instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acr-test</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The region where the ACR Enterprise instance resides.</para>
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
            public int? ActiveDeadlineSeconds { get; set; }

            /// <summary>
            /// <para>Specifies whether the automatic creation of an elastic IP address (EIP) and attaching it to the ECI instance is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoCreateEip")]
            [Validation(Required=false)]
            public bool? AutoCreateEip { get; set; }

            /// <summary>
            /// <para>Specifies whether to automatically match an image cache.
            /// Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoMatchImageCache")]
            [Validation(Required=false)]
            public bool? AutoMatchImageCache { get; set; }

            /// <summary>
            /// <para>The name of the ECI instance, which is also the name of the pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ContainerGroupName")]
            [Validation(Required=false)]
            public string ContainerGroupName { get; set; }

            /// <summary>
            /// <para>The list of containers included in the ECI instance.</para>
            /// </summary>
            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainers> Containers { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainers : TeaModel {
                /// <summary>
                /// <para>The list of arguments for the container startup commands. A maximum of 10 arguments can be specified.</para>
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// <para>The list of startup commands for the container. A maximum of 20 commands can be specified. Each command can contain up to 256 characters.</para>
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

                /// <summary>
                /// <para>The number of vCPUs for the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The list of environment variables.</para>
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersEnvironmentVars : TeaModel {
                    /// <summary>
                    /// <para>This parameter is unavailable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>path</para>
                    /// </summary>
                    [NameInMap("FieldRefFieldPath")]
                    [Validation(Required=false)]
                    public string FieldRefFieldPath { get; set; }

                    /// <summary>
                    /// <para>The name of the environment variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PATH</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the environment variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/bin/</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The number of GPUs.</para>
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
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The image pull policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Alway: The image is always pulled.</description></item>
                /// <item><description>IfNotPresent: The image is pulled on demand. The local image is used first. If no local image is available, the image is pulled.</description></item>
                /// <item><description>Never: The image is never pulled. The local image is used.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Always</para>
                /// </summary>
                [NameInMap("ImagePullPolicy")]
                [Validation(Required=false)]
                public string ImagePullPolicy { get; set; }

                /// <summary>
                /// <para>The command executed in the container when the postStart callback function is configured by using the command line.</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerExecs")]
                [Validation(Required=false)]
                public List<string> LifecyclePostStartHandlerExecs { get; set; }

                /// <summary>
                /// <para>The host address that receives the HTTP GET request when the postStart callback function is configured by using an HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.XX.XX</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerHttpGetHost")]
                [Validation(Required=false)]
                public string LifecyclePostStartHandlerHttpGetHost { get; set; }

                /// <summary>
                /// <para>The path checked by the HTTP GET request when the postStart callback function is configured by using an HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/healthyz</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerHttpGetPath")]
                [Validation(Required=false)]
                public string LifecyclePostStartHandlerHttpGetPath { get; set; }

                /// <summary>
                /// <para>The port number checked by the HTTP GET request when the postStart callback function is configured by using an HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerHttpGetPort")]
                [Validation(Required=false)]
                public int? LifecyclePostStartHandlerHttpGetPort { get; set; }

                /// <summary>
                /// <para>The protocol type used for the HTTP GET request when the postStart callback function is configured by using an HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerHttpGetScheme")]
                [Validation(Required=false)]
                public string LifecyclePostStartHandlerHttpGetScheme { get; set; }

                /// <summary>
                /// <para>The host address checked by the TCP socket when the postStart callback function is configured by using a TCP socket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.XX.XX</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerTcpSocketHost")]
                [Validation(Required=false)]
                public string LifecyclePostStartHandlerTcpSocketHost { get; set; }

                /// <summary>
                /// <para>The port checked by the TCP socket when the postStart callback function is configured by using a TCP socket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerTcpSocketPort")]
                [Validation(Required=false)]
                public int? LifecyclePostStartHandlerTcpSocketPort { get; set; }

                /// <summary>
                /// <para>The command executed in the container when the preStop callback function is configured by using the command line.</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerExecs")]
                [Validation(Required=false)]
                public List<string> LifecyclePreStopHandlerExecs { get; set; }

                /// <summary>
                /// <para>The host address that receives the HTTP GET request when the preStop callback function is configured by using an HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.XX.XX</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerHttpGetHost")]
                [Validation(Required=false)]
                public string LifecyclePreStopHandlerHttpGetHost { get; set; }

                /// <summary>
                /// <para>The path checked by the HTTP GET request when the preStop callback function is configured by using an HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/healthyz</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerHttpGetPath")]
                [Validation(Required=false)]
                public string LifecyclePreStopHandlerHttpGetPath { get; set; }

                /// <summary>
                /// <para>The port number checked by the HTTP GET request when the preStop callback function is configured by using an HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerHttpGetPort")]
                [Validation(Required=false)]
                public int? LifecyclePreStopHandlerHttpGetPort { get; set; }

                /// <summary>
                /// <para>The protocol type used for the HTTP GET request when the preStop callback function is configured by using an HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerHttpGetScheme")]
                [Validation(Required=false)]
                public string LifecyclePreStopHandlerHttpGetScheme { get; set; }

                /// <summary>
                /// <para>The host address checked by the TCP socket when the preStop callback function is configured by using a TCP socket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.XX.XX</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerTcpSocketHost")]
                [Validation(Required=false)]
                public string LifecyclePreStopHandlerTcpSocketHost { get; set; }

                /// <summary>
                /// <para>The port checked by the TCP socket when the preStop callback function is configured by using a TCP socket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerTcpSocketPort")]
                [Validation(Required=false)]
                public int? LifecyclePreStopHandlerTcpSocketPort { get; set; }

                /// <summary>
                /// <para>The list of commands executed in the container for command-line-based health checks.</para>
                /// </summary>
                [NameInMap("LivenessProbeExecCommands")]
                [Validation(Required=false)]
                public List<string> LivenessProbeExecCommands { get; set; }

                /// <summary>
                /// <para>The minimum consecutive failures for the readiness probe to be considered failed after having succeeded.
                /// Default value: 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("LivenessProbeFailureThreshold")]
                [Validation(Required=false)]
                public int? LivenessProbeFailureThreshold { get; set; }

                /// <summary>
                /// <para>The path for the HTTP GET readiness probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/nginx/</para>
                /// </summary>
                [NameInMap("LivenessProbeHttpGetPath")]
                [Validation(Required=false)]
                public string LivenessProbeHttpGetPath { get; set; }

                /// <summary>
                /// <para>The port for the HTTP GET liveness probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("LivenessProbeHttpGetPort")]
                [Validation(Required=false)]
                public int? LivenessProbeHttpGetPort { get; set; }

                /// <summary>
                /// <para>The protocol type for the HTTP GET request when HTTP requests are used for health checks. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>HTTP</description></item>
                /// <item><description>HTTPS</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("LivenessProbeHttpGetScheme")]
                [Validation(Required=false)]
                public string LivenessProbeHttpGetScheme { get; set; }

                /// <summary>
                /// <para>The delay before the readiness probe is initiated after the container starts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("LivenessProbeInitialDelaySeconds")]
                [Validation(Required=false)]
                public int? LivenessProbeInitialDelaySeconds { get; set; }

                /// <summary>
                /// <para>The execution period of the liveness probe. Default value: 10 seconds. Minimum value: 1 second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("LivenessProbePeriodSeconds")]
                [Validation(Required=false)]
                public int? LivenessProbePeriodSeconds { get; set; }

                /// <summary>
                /// <para>The minimum consecutive successes for the readiness probe to be considered successful after having failed. Default value: 1. The current value must be 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LivenessProbeSuccessThreshold")]
                [Validation(Required=false)]
                public int? LivenessProbeSuccessThreshold { get; set; }

                /// <summary>
                /// <para>The port number for the TCP socket liveness probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("LivenessProbeTcpSocketPort")]
                [Validation(Required=false)]
                public int? LivenessProbeTcpSocketPort { get; set; }

                /// <summary>
                /// <para>The timeout period for the liveness probe. Default value: 1 second. Minimum value: 1 second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("LivenessProbeTimeoutSeconds")]
                [Validation(Required=false)]
                public int? LivenessProbeTimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The memory size of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// <para>The custom name of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nginx</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of exposed ports and protocols.</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersPorts> Ports { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersPorts : TeaModel {
                    /// <summary>
                    /// <para>The port number. Valid values: 1 to 65535.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8888</para>
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
                /// <para>The list of commands executed in the container for command-line-based health checks.</para>
                /// </summary>
                [NameInMap("ReadinessProbeExecCommands")]
                [Validation(Required=false)]
                public List<string> ReadinessProbeExecCommands { get; set; }

                /// <summary>
                /// <para>The minimum consecutive failures for the readiness probe to be considered failed after having succeeded.
                /// Default value: 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ReadinessProbeFailureThreshold")]
                [Validation(Required=false)]
                public int? ReadinessProbeFailureThreshold { get; set; }

                /// <summary>
                /// <para>The path for the HTTP GET readiness probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/local</para>
                /// </summary>
                [NameInMap("ReadinessProbeHttpGetPath")]
                [Validation(Required=false)]
                public string ReadinessProbeHttpGetPath { get; set; }

                /// <summary>
                /// <para>The path for the HTTP GET readiness probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/nginx/</para>
                /// </summary>
                [NameInMap("ReadinessProbeHttpGetPort")]
                [Validation(Required=false)]
                public int? ReadinessProbeHttpGetPort { get; set; }

                /// <summary>
                /// <para>The protocol type for the HTTP GET request when HTTP requests are used for health checks. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>HTTP</description></item>
                /// <item><description>HTTPS</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("ReadinessProbeHttpGetScheme")]
                [Validation(Required=false)]
                public string ReadinessProbeHttpGetScheme { get; set; }

                /// <summary>
                /// <para>The delay before the readiness probe is initiated after the container starts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ReadinessProbeInitialDelaySeconds")]
                [Validation(Required=false)]
                public int? ReadinessProbeInitialDelaySeconds { get; set; }

                /// <summary>
                /// <para>The execution period of the readiness probe. Default value: 10 seconds. Minimum value: 1 second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReadinessProbePeriodSeconds")]
                [Validation(Required=false)]
                public int? ReadinessProbePeriodSeconds { get; set; }

                /// <summary>
                /// <para>The minimum consecutive successes for the readiness probe to be considered successful after having failed. Default value: 1. The current value must be 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReadinessProbeSuccessThreshold")]
                [Validation(Required=false)]
                public int? ReadinessProbeSuccessThreshold { get; set; }

                /// <summary>
                /// <para>The port number for the TCP socket liveness probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8888</para>
                /// </summary>
                [NameInMap("ReadinessProbeTcpSocketPort")]
                [Validation(Required=false)]
                public int? ReadinessProbeTcpSocketPort { get; set; }

                /// <summary>
                /// <para>The timeout period for the readiness probe. Default value: 1 second. Minimum value: 1 second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ReadinessProbeTimeoutSeconds")]
                [Validation(Required=false)]
                public int? ReadinessProbeTimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The specific permissions granted to processes in the container. Currently, only NET_ADMIN and NET_RAW are supported.</para>
                /// <remarks>
                /// <para>By default, NET_RAW is not supported. To use NET_RAW, submit a ticket.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("SecurityContextCapabilityAdds")]
                [Validation(Required=false)]
                public List<string> SecurityContextCapabilityAdds { get; set; }

                /// <summary>
                /// <para>Specifies whether the root file system is read-only. Only true is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SecurityContextReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? SecurityContextReadOnlyRootFilesystem { get; set; }

                /// <summary>
                /// <para>The UID used to run the entrypoint of the container process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("SecurityContextRunAsUser")]
                [Validation(Required=false)]
                public long? SecurityContextRunAsUser { get; set; }

                /// <summary>
                /// <para>Specifies whether to allocate a buffer for standard input during container runtime. If this parameter is not set, reading from standard input in the container results in an EOF. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Stdin")]
                [Validation(Required=false)]
                public bool? Stdin { get; set; }

                /// <summary>
                /// <para>Specifies whether the standard input stream remains in the enabling status across multiple attached sessions when standard input is set to true.</para>
                /// <para>If StdinOnce is set to true, standard input is opened when the container starts, remains empty until the first client attaches to it, and then stays in the enabling status to accept data until the client connection is disconnected. At this point, standard input is shutdown and remains shutdown until the container is restarted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("StdinOnce")]
                [Validation(Required=false)]
                public bool? StdinOnce { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable interaction. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: enabled</description></item>
                /// <item><description>false: disabled
                /// For example, if Command is set to /bin/bash, you must set this parameter to true.
                /// Default value: false.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Tty")]
                [Validation(Required=false)]
                public bool? Tty { get; set; }

                /// <summary>
                /// <para>The list of volume mounts.</para>
                /// </summary>
                [NameInMap("VolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersVolumeMounts> VolumeMounts { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersVolumeMounts : TeaModel {
                    /// <summary>
                    /// <para>The directory where the container mounts the data volume.</para>
                    /// <remarks>
                    /// <para>Notice: The content in the mount directory of the container is directly overwritten by the content of the volume. Use this parameter with caution.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/pod/data</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>The mount propagation settings for the data volume. Mount propagation allows volumes mounted by a container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>None: The volume is not aware of any subsequent mount operations performed on the volume or its subdirectories.</description></item>
                    /// <item><description>HostToCotainer: The volume is aware of subsequent mount operations performed on the volume or its subdirectories.</description></item>
                    /// <item><description>Bidirectional: Similar to HostToCotainer, the volume is aware of mount operations. In addition, the volume is propagated back to the host and to all containers of all pods that use the same volume.
                    /// Default value: None.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("MountPropagation")]
                    [Validation(Required=false)]
                    public string MountPropagation { get; set; }

                    /// <summary>
                    /// <para>The name of the data volume. This name must be the same as the Name parameter in Volume.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default-volume1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the data volume is read-only.
                    /// Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// <para>The subpath of the data volume.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>data2/</para>
                    /// </summary>
                    [NameInMap("SubPath")]
                    [Validation(Required=false)]
                    public string SubPath { get; set; }

                }

                /// <summary>
                /// <para>The working directory in the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/local/nginx</para>
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
            /// <para>The number of vCPUs for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
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
            /// <para>The time when the scaling configuration was created. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mmZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-08-14T10:58Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The bucket for data caching.</para>
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
            /// <item><description>false: Disabled.<remarks>
            /// <para>For more information about ESSD AutoPL cloud disks, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DataCacheBurstingEnabled")]
            [Validation(Required=false)]
            public bool? DataCacheBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The performance level of the cloud disk used for data caching. We recommend using ESSD (standard SSD). Valid values for the performance level of an ESSD (standard SSD):</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD (standard SSD) can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD (standard SSD) can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD (standard SSD) can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD (standard SSD) can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about ESSD (standard SSD), see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD (standard SSD)</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("DataCachePL")]
            [Validation(Required=false)]
            public string DataCachePL { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL cloud disk used for data caching. Valid values: 0 to min{50000, 1000 × capacity - baseline performance}. The baseline performance is calculated by using the following formula: min{1800 + 50 × capacity, 50000}.</para>
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
            /// <para>This parameter is unavailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is an example.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of IP addresses of the DNS servers.</para>
            /// </summary>
            [NameInMap("DnsConfigNameServers")]
            [Validation(Required=false)]
            public List<string> DnsConfigNameServers { get; set; }

            /// <summary>
            /// <para>The list of DNS configuration options. Each option consists of a name and an optional value.</para>
            /// </summary>
            [NameInMap("DnsConfigOptions")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsDnsConfigOptions> DnsConfigOptions { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsDnsConfigOptions : TeaModel {
                /// <summary>
                /// <para>The name of the option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the option.</para>
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
            [NameInMap("DnsConfigSearches")]
            [Validation(Required=false)]
            public List<string> DnsConfigSearches { get; set; }

            /// <summary>
            /// <para>The DNS policy.</para>
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
            /// <para>The size of the ephemeral storage space. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EphemeralStorage")]
            [Validation(Required=false)]
            public int? EphemeralStorage { get; set; }

            /// <summary>
            /// <para>The specified GPU driver version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tesla=470.82.01</para>
            /// </summary>
            [NameInMap("GpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

            /// <summary>
            /// <para>The custom hostname mappings for a container in the instance.</para>
            /// </summary>
            [NameInMap("HostAliases")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsHostAliases> HostAliases { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsHostAliases : TeaModel {
                /// <summary>
                /// <para>The hostnames to add.</para>
                /// </summary>
                [NameInMap("Hostnames")]
                [Validation(Required=false)]
                public List<string> Hostnames { get; set; }

                /// <summary>
                /// <para>The IP address to add.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.XX.XX</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;hehe.com\&quot;, \&quot;haha.com\&quot;]</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The image registry information.</para>
            /// </summary>
            [NameInMap("ImageRegistryCredentials")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsImageRegistryCredentials> ImageRegistryCredentials { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsImageRegistryCredentials : TeaModel {
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
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainers> InitContainers { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainers : TeaModel {
                /// <summary>
                /// <para>The CPU size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The number of GPUs used by the container.</para>
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
                /// <para>The startup arguments for the container.</para>
                /// </summary>
                [NameInMap("InitContainerArgs")]
                [Validation(Required=false)]
                public List<string> InitContainerArgs { get; set; }

                /// <summary>
                /// <para>The startup commands for the container.</para>
                /// </summary>
                [NameInMap("InitContainerCommands")]
                [Validation(Required=false)]
                public List<string> InitContainerCommands { get; set; }

                /// <summary>
                /// <para>The information about the environment variable.</para>
                /// </summary>
                [NameInMap("InitContainerEnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerEnvironmentVars> InitContainerEnvironmentVars { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerEnvironmentVars : TeaModel {
                    /// <summary>
                    /// <para>This parameter is unavailable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>path</para>
                    /// </summary>
                    [NameInMap("FieldRefFieldPath")]
                    [Validation(Required=false)]
                    public string FieldRefFieldPath { get; set; }

                    /// <summary>
                    /// <para>The name of the environment variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PATH</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the environment variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/local/bin</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The collection of port information for the init container.</para>
                /// </summary>
                [NameInMap("InitContainerPorts")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerPorts> InitContainerPorts { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerPorts : TeaModel {
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
                    /// <item><description>TCP.</description></item>
                    /// <item><description>UDP.</description></item>
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
                /// <para>The data volume mounts.</para>
                /// </summary>
                [NameInMap("InitContainerVolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerVolumeMounts> InitContainerVolumeMounts { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerVolumeMounts : TeaModel {
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
                    /// <para>The mount propagation settings for the data volume. Mount propagation allows volumes mounted by a container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>None: The volume is not aware of any subsequent mount operations performed on the volume or its subdirectories.</description></item>
                    /// <item><description>HostToCotainer: The volume is aware of subsequent mount operations performed on the volume or its subdirectories.</description></item>
                    /// <item><description>Bidirectional: Similar to HostToCotainer, the volume is aware of mount operations. In addition, the volume is propagated back to the host and to all containers of all pods that use the same volume.
                    /// Default value: None.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("MountPropagation")]
                    [Validation(Required=false)]
                    public string MountPropagation { get; set; }

                    /// <summary>
                    /// <para>The name of the mounted data volume.</para>
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
                    /// <para>The subdirectory in the data volume. This allows a pod to mount different directories in the same volume to different directories in the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/sub/</para>
                    /// </summary>
                    [NameInMap("SubPath")]
                    [Validation(Required=false)]
                    public string SubPath { get; set; }

                }

                /// <summary>
                /// <para>The memory size.</para>
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
                /// <para>The specific permissions granted to processes in the container. Currently, only NET_ADMIN and NET_RAW are supported.</para>
                /// <remarks>
                /// <para>By default, NET_RAW is not supported. To use NET_RAW, submit a ticket.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("SecurityContextCapabilityAdds")]
                [Validation(Required=false)]
                public List<string> SecurityContextCapabilityAdds { get; set; }

                /// <summary>
                /// <para>Specifies whether the root file system where the container runs is read-only. Currently, only true is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SecurityContextReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? SecurityContextReadOnlyRootFilesystem { get; set; }

                /// <summary>
                /// <para>The user ID used to run the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>587</para>
                /// </summary>
                [NameInMap("SecurityContextRunAsUser")]
                [Validation(Required=false)]
                public string SecurityContextRunAsUser { get; set; }

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
            /// <para>The level of the instance family. This parameter is used to filter instance types that meet the requirements and takes effect only when <c>CostOptimization</c> is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EntryLevel: shared instance types. These instance types are more cost-effective but cannot guarantee stable computing performance. They are suitable for workloads with low CPU utilization. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
            /// <item><description>EnterpriseLevel: enterprise-level instance types. These instance types provide stable performance and dedicated resources, and are suitable for workloads that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</description></item>
            /// <item><description>CreditEntryLevel: burstable instance types. These instance types use CPU credits to ensure computing performance and are suitable for workloads that have low CPU utilization but occasionally experience CPU usage spikes. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
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
            /// <para>The state of the scaling configuration in the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active: The scaling configuration is active. The scaling group uses active scaling configurations for the automatic creation of ECS instances.</description></item>
            /// <item><description>Inacitve: The scaling configuration is inactive. Inactive scaling configurations exist in the scaling group, but the scaling group does not use them for the automatic creation of ECS instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// <para>The weight of the ECI instance when it serves as a backend server. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LoadBalancerWeight")]
            [Validation(Required=false)]
            public int? LoadBalancerWeight { get; set; }

            /// <summary>
            /// <para>The memory size.
            /// You can specify both CPU and Memory to define a range of instance types. For example, if you set CPU to 2 and Memory to 16, all instance types that have 2 vCPUs and 16 GiB of memory are matched. Auto Scaling determines the available instance types based on factors such as I/O optimization and zone, and creates the instance type that has the lowest price.</para>
            /// <remarks>
            /// <para>This configuration takes effect only when the cost optimization mode is used and no instance types are specified in the scaling configuration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The NTP servers.</para>
            /// </summary>
            [NameInMap("NtpServers")]
            [Validation(Required=false)]
            public List<string> NtpServers { get; set; }

            /// <summary>
            /// <para>The name of the instance RAM role. ECI and ECS share the same instance RAM role. For more information, see <a href="https://help.aliyun.com/document_detail/61178.html">Use an instance RAM role by calling API operations</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ram:PassRole</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The region ID of the ECI instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-8db03793gfrz****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The restart policy for the pod. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Never: The pod is not restarted.</description></item>
            /// <item><description>Always: The pod is always restarted.</description></item>
            /// <item><description>OnFailure: The pod is restarted upon failure.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Never</para>
            /// </summary>
            [NameInMap("RestartPolicy")]
            [Validation(Required=false)]
            public string RestartPolicy { get; set; }

            /// <summary>
            /// <para>The ID of the scaling configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asc-bp1ezrfgoyn5kijl****</para>
            /// </summary>
            [NameInMap("ScalingConfigurationId")]
            [Validation(Required=false)]
            public string ScalingConfigurationId { get; set; }

            /// <summary>
            /// <para>The name of the scaling configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scalingconfi****</para>
            /// </summary>
            [NameInMap("ScalingConfigurationName")]
            [Validation(Required=false)]
            public string ScalingConfigurationName { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group to which the scaling configuration belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp17pelvl720x3v7****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The system info of the contextual security for the running instance.</para>
            /// </summary>
            [NameInMap("SecurityContextSysCtls")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsSecurityContextSysCtls> SecurityContextSysCtls { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsSecurityContextSysCtls : TeaModel {
                /// <summary>
                /// <para>The name of the system control parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kernel.msgmax</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The variable value of the contextual security for the running instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65536</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the security group to which the Elastic Container Instance (ECI) belongs. ECI instances in the same security group can access each other.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp18kz60mefs****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>This parameter is unavailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("SlsEnable")]
            [Validation(Required=false)]
            public bool? SlsEnable { get; set; }

            /// <summary>
            /// <para>The maximum hourly price for the spot instance.
            /// This parameter is returned only when SpotStrategy is set to SpotWithPriceLimit.</para>
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
            /// <item><description>NoSpot: regular pay-as-you-go instance</description></item>
            /// <item><description>SpotWithPriceLimit: spot instance with a maximum price</description></item>
            /// <item><description>SpotAsPriceGo: spot instance with a price automatically offered by the system based on the current market price</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>The tag key-value pairs of the instance.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsTags> Tags { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsTags : TeaModel {
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
            /// <para>The grace period for the program to handle operations before termination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("TerminationGracePeriodSeconds")]
            [Validation(Required=false)]
            public int? TerminationGracePeriodSeconds { get; set; }

            /// <summary>
            /// <para>The data volume information.</para>
            /// </summary>
            [NameInMap("Volumes")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumes> Volumes { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumes : TeaModel {
                /// <summary>
                /// <para>The list of configuration file paths.</para>
                /// </summary>
                [NameInMap("ConfigFileVolumeConfigFileToPaths")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumesConfigFileVolumeConfigFileToPaths> ConfigFileVolumeConfigFileToPaths { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumesConfigFileVolumeConfigFileToPaths : TeaModel {
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
                /// <para>The default permissions of the ConfigFileVolume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0644</para>
                /// </summary>
                [NameInMap("ConfigFileVolumeDefaultMode")]
                [Validation(Required=false)]
                public int? ConfigFileVolumeDefaultMode { get; set; }

                /// <summary>
                /// <para>The size of the disk volume. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("DiskVolumeDiskId")]
                [Validation(Required=false)]
                public string DiskVolumeDiskId { get; set; }

                /// <summary>
                /// <para>The size of the disk volume. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("DiskVolumeDiskSize")]
                [Validation(Required=false)]
                public int? DiskVolumeDiskSize { get; set; }

                /// <summary>
                /// <para>The file system type of the disk volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xfs</para>
                /// </summary>
                [NameInMap("DiskVolumeFsType")]
                [Validation(Required=false)]
                public string DiskVolumeFsType { get; set; }

                /// <summary>
                /// <para>The storage medium of the EmptyDirVolume. The default value is empty, which indicates that the node file system is used. A value of memory indicates that memory is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>memory</para>
                /// </summary>
                [NameInMap("EmptyDirVolumeMedium")]
                [Validation(Required=false)]
                public string EmptyDirVolumeMedium { get; set; }

                /// <summary>
                /// <para>The size of the EmptyDir data volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>256Mi</para>
                /// </summary>
                [NameInMap("EmptyDirVolumeSizeLimit")]
                [Validation(Required=false)]
                public string EmptyDirVolumeSizeLimit { get; set; }

                /// <summary>
                /// <para>The name of the driver used for FlexVolume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flexvolume</para>
                /// </summary>
                [NameInMap("FlexVolumeDriver")]
                [Validation(Required=false)]
                public string FlexVolumeDriver { get; set; }

                /// <summary>
                /// <para>The file system type to be mounted. The default value depends on the script of the FlexVolume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ext4</para>
                /// </summary>
                [NameInMap("FlexVolumeFsType")]
                [Validation(Required=false)]
                public string FlexVolumeFsType { get; set; }

                /// <summary>
                /// <para>The list of options for the FlexVolume object. The options are passed in JSON format as key-value pairs.
                /// For example, when you mount a cloud disk by using FlexVolume, the options are in the following format: <c>{&quot;volumeId&quot;:&quot;d-2zehdahrwoa7srg****&quot;,&quot;performanceLevel&quot;: &quot;PL2&quot;}</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;volumeId&quot;:&quot;d-2zehdahrwoa7srg****&quot;,&quot;performanceLevel&quot;: &quot;PL2&quot;}</para>
                /// </summary>
                [NameInMap("FlexVolumeOptions")]
                [Validation(Required=false)]
                public string FlexVolumeOptions { get; set; }

                /// <summary>
                /// <para>The directory path of the HostPath volume on the host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/pod/data</para>
                /// </summary>
                [NameInMap("HostPathVolumePath")]
                [Validation(Required=false)]
                public string HostPathVolumePath { get; set; }

                /// <summary>
                /// <para>The type of the HostPath volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Directory</para>
                /// </summary>
                [NameInMap("HostPathVolumeType")]
                [Validation(Required=false)]
                public string HostPathVolumeType { get; set; }

                /// <summary>
                /// <para>The path of the NFS volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/share</para>
                /// </summary>
                [NameInMap("NFSVolumePath")]
                [Validation(Required=false)]
                public string NFSVolumePath { get; set; }

                /// <summary>
                /// <para>Specifies whether the NFS volume is read-only.</para>
                /// <para>Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("NFSVolumeReadOnly")]
                [Validation(Required=false)]
                public bool? NFSVolumeReadOnly { get; set; }

                /// <summary>
                /// <para>The address of the NFS server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3f9cd4a596-naw76.cn-shanghai.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("NFSVolumeServer")]
                [Validation(Required=false)]
                public string NFSVolumeServer { get; set; }

                /// <summary>
                /// <para>The name of the data volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default-volume1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The data volume type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>EmptyDirVolume.</description></item>
                /// <item><description>NFSVolume.</description></item>
                /// <item><description>ConfigFileVolume.</description></item>
                /// <item><description>FlexVolume.</description></item>
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

        /// <summary>
        /// <para>The total number of scaling configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
