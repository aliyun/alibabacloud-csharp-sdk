// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeEciScalingConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
            /// <para>The Container Registry Enterprise Edition instances.</para>
            /// </summary>
            [NameInMap("AcrRegistryInfos")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsAcrRegistryInfos> AcrRegistryInfos { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsAcrRegistryInfos : TeaModel {
                /// <summary>
                /// <para>The domain names of the Container Registry Enterprise Edition instance. By default, all domain names of the instance are displayed. Multiple domain names are separated by commas (,).</para>
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
            public int? ActiveDeadlineSeconds { get; set; }

            /// <summary>
            /// <para>Indicates whether elastic IP addresses (EIPs) are automatically created and bound to elastic container instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoCreateEip")]
            [Validation(Required=false)]
            public bool? AutoCreateEip { get; set; }

            /// <summary>
            /// <para>Indicates whether the image cache is automatically matched. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoMatchImageCache")]
            [Validation(Required=false)]
            public bool? AutoMatchImageCache { get; set; }

            /// <summary>
            /// <para>The name series of elastic container instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ContainerGroupName")]
            [Validation(Required=false)]
            public string ContainerGroupName { get; set; }

            /// <summary>
            /// <para>The containers in an elastic container instance.</para>
            /// </summary>
            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainers> Containers { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainers : TeaModel {
                /// <summary>
                /// <para>The container startup arguments. You can specify up to 10 arguments.</para>
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// <para>The container startup commands. You can specify up to 20 commands. Each command can contain up to 256 characters.</para>
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

                /// <summary>
                /// <para>The number of vCPUs per container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The environment variables.</para>
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersEnvironmentVars : TeaModel {
                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is not available for use.</para>
                    /// </remarks>
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
                /// <para>The image pulling policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Always: Each time image pulling is performed.</description></item>
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
                /// <para>The commands that are run for configuring the postStart callback function by using the CLI within the container.</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerExecs")]
                [Validation(Required=false)]
                public List<string> LifecyclePostStartHandlerExecs { get; set; }

                /// <summary>
                /// <para>The IP address of the host to which HTTP GET requests for configuring the postStart callback function are sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.XX.XX</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerHttpGetHost")]
                [Validation(Required=false)]
                public string LifecyclePostStartHandlerHttpGetHost { get; set; }

                /// <summary>
                /// <para>The path to which HTTP GET requests for configuring the postStart callback function are sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/healthyz</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerHttpGetPath")]
                [Validation(Required=false)]
                public string LifecyclePostStartHandlerHttpGetPath { get; set; }

                /// <summary>
                /// <para>The port over which HTTP GET requests for configuring the postStart callback function are sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerHttpGetPort")]
                [Validation(Required=false)]
                public int? LifecyclePostStartHandlerHttpGetPort { get; set; }

                /// <summary>
                /// <para>The protocol type of the HTTP GET requests that are sent for configuring the postStart callback function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerHttpGetScheme")]
                [Validation(Required=false)]
                public string LifecyclePostStartHandlerHttpGetScheme { get; set; }

                /// <summary>
                /// <para>The IP address of the host detected by the TCP sockets used for configuring the postStart callback function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.XX.XX</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerTcpSocketHost")]
                [Validation(Required=false)]
                public string LifecyclePostStartHandlerTcpSocketHost { get; set; }

                /// <summary>
                /// <para>The port detected by the TCP sockets used for configuring the postStart callback function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerTcpSocketPort")]
                [Validation(Required=false)]
                public int? LifecyclePostStartHandlerTcpSocketPort { get; set; }

                /// <summary>
                /// <para>The commands that are run for configuring the preStop callback function by using the CLI within the container.</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerExecs")]
                [Validation(Required=false)]
                public List<string> LifecyclePreStopHandlerExecs { get; set; }

                /// <summary>
                /// <para>The IP address of the host to which HTTP GET requests for configuring the preStop callback function are sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.XX.XX</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerHttpGetHost")]
                [Validation(Required=false)]
                public string LifecyclePreStopHandlerHttpGetHost { get; set; }

                /// <summary>
                /// <para>The path to which HTTP GET requests for configuring the preStop callback function are sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/healthyz</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerHttpGetPath")]
                [Validation(Required=false)]
                public string LifecyclePreStopHandlerHttpGetPath { get; set; }

                /// <summary>
                /// <para>The port over which HTTP GET requests for configuring the preStop callback function are sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerHttpGetPort")]
                [Validation(Required=false)]
                public int? LifecyclePreStopHandlerHttpGetPort { get; set; }

                /// <summary>
                /// <para>The protocol type of the HTTP Get requests that are sent for configuring the preStop callback function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerHttpGetScheme")]
                [Validation(Required=false)]
                public string LifecyclePreStopHandlerHttpGetScheme { get; set; }

                /// <summary>
                /// <para>The IP address of the host detected by the TCP sockets used for configuring the preStop callback function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.XX.XX</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerTcpSocketHost")]
                [Validation(Required=false)]
                public string LifecyclePreStopHandlerTcpSocketHost { get; set; }

                /// <summary>
                /// <para>The port detected by the TCP sockets used for configuring the preStop callback function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerTcpSocketPort")]
                [Validation(Required=false)]
                public int? LifecyclePreStopHandlerTcpSocketPort { get; set; }

                /// <summary>
                /// <para>The commands that are run in the container when you use the CLI to perform liveness probes.</para>
                /// </summary>
                [NameInMap("LivenessProbeExecCommands")]
                [Validation(Required=false)]
                public List<string> LivenessProbeExecCommands { get; set; }

                /// <summary>
                /// <para>The minimum number of consecutive failures before a successful liveness probe is considered failed.</para>
                /// <para>Default value: 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("LivenessProbeFailureThreshold")]
                [Validation(Required=false)]
                public int? LivenessProbeFailureThreshold { get; set; }

                /// <summary>
                /// <para>The path to which HTTP GET requests are sent when you use the HTTP GET requests to perform liveness probes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/nginx/</para>
                /// </summary>
                [NameInMap("LivenessProbeHttpGetPath")]
                [Validation(Required=false)]
                public string LivenessProbeHttpGetPath { get; set; }

                /// <summary>
                /// <para>The port to which HTTP GET requests are sent to perform liveness probes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("LivenessProbeHttpGetPort")]
                [Validation(Required=false)]
                public int? LivenessProbeHttpGetPort { get; set; }

                /// <summary>
                /// <para>The protocol type of HTTP GET requests when you use the HTTP GET requests to perform liveness probes. Valid values:</para>
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
                /// <para>The number of seconds that elapses from the startup of the container to the start time of a liveness probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("LivenessProbeInitialDelaySeconds")]
                [Validation(Required=false)]
                public int? LivenessProbeInitialDelaySeconds { get; set; }

                /// <summary>
                /// <para>The interval at which liveness probes are performed. Unit: seconds. Default value: 10. Minimum value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("LivenessProbePeriodSeconds")]
                [Validation(Required=false)]
                public int? LivenessProbePeriodSeconds { get; set; }

                /// <summary>
                /// <para>The minimum number of consecutive successes before a failed liveness probe is considered successful. Default value: 1. Valid value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LivenessProbeSuccessThreshold")]
                [Validation(Required=false)]
                public int? LivenessProbeSuccessThreshold { get; set; }

                /// <summary>
                /// <para>The port detected by TCP sockets when you use the TCP sockets to perform liveness probes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("LivenessProbeTcpSocketPort")]
                [Validation(Required=false)]
                public int? LivenessProbeTcpSocketPort { get; set; }

                /// <summary>
                /// <para>The timeout period of a liveness probe. Default value: 1. Minimum value: 1. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("LivenessProbeTimeoutSeconds")]
                [Validation(Required=false)]
                public int? LivenessProbeTimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The memory size per container.</para>
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
                /// <para>The exposed ports and protocols.</para>
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
                /// <para>The commands that are run in the container when you use the CLI to perform readiness probes.</para>
                /// </summary>
                [NameInMap("ReadinessProbeExecCommands")]
                [Validation(Required=false)]
                public List<string> ReadinessProbeExecCommands { get; set; }

                /// <summary>
                /// <para>The minimum number of consecutive failures before a successful readiness probe is considered failed.</para>
                /// <para>Default value: 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ReadinessProbeFailureThreshold")]
                [Validation(Required=false)]
                public int? ReadinessProbeFailureThreshold { get; set; }

                /// <summary>
                /// <para>The path to which HTTP GET requests are sent when you use the HTTP GET requests to perform readiness probes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/local</para>
                /// </summary>
                [NameInMap("ReadinessProbeHttpGetPath")]
                [Validation(Required=false)]
                public string ReadinessProbeHttpGetPath { get; set; }

                /// <summary>
                /// <para>The path to which HTTP GET requests are sent when you use the HTTP GET requests to perform readiness probes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/nginx/</para>
                /// </summary>
                [NameInMap("ReadinessProbeHttpGetPort")]
                [Validation(Required=false)]
                public int? ReadinessProbeHttpGetPort { get; set; }

                /// <summary>
                /// <para>The protocol type of HTTP GET requests when you use the HTTP requests to perform readiness probes. Valid values:</para>
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
                /// <para>The number of seconds that elapses from the startup of the container to the start time of a readiness probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ReadinessProbeInitialDelaySeconds")]
                [Validation(Required=false)]
                public int? ReadinessProbeInitialDelaySeconds { get; set; }

                /// <summary>
                /// <para>The interval at which readiness probes are performed. Unit: seconds. Default value: 10. Minimum value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReadinessProbePeriodSeconds")]
                [Validation(Required=false)]
                public int? ReadinessProbePeriodSeconds { get; set; }

                /// <summary>
                /// <para>The minimum number of consecutive successes before a failed readiness probe is considered successful. Default value: 1. Valid value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReadinessProbeSuccessThreshold")]
                [Validation(Required=false)]
                public int? ReadinessProbeSuccessThreshold { get; set; }

                /// <summary>
                /// <para>The port detected by TCP sockets when you use the TCP sockets to perform readiness probes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8888</para>
                /// </summary>
                [NameInMap("ReadinessProbeTcpSocketPort")]
                [Validation(Required=false)]
                public int? ReadinessProbeTcpSocketPort { get; set; }

                /// <summary>
                /// <para>The timeout period of a readiness probe. Default value: 1. Minimum value: 1. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ReadinessProbeTimeoutSeconds")]
                [Validation(Required=false)]
                public int? ReadinessProbeTimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The permissions that are granted to the processes in the container. Valid values: NET_ADMIN and NET_RAW.</para>
                /// <remarks>
                /// <para> To use NET_RAW, you must submit a ticket.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("SecurityContextCapabilityAdds")]
                [Validation(Required=false)]
                public List<string> SecurityContextCapabilityAdds { get; set; }

                /// <summary>
                /// <para>Indicates whether the root file system on which the container runs is read-only. Valid value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SecurityContextReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? SecurityContextReadOnlyRootFilesystem { get; set; }

                /// <summary>
                /// <para>The ID of the user that runs the entry point of the container process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("SecurityContextRunAsUser")]
                [Validation(Required=false)]
                public long? SecurityContextRunAsUser { get; set; }

                /// <summary>
                /// <para>Indicates whether the container allocates buffer resources to standard input streams when the container is running. If this parameter is not specified, an end-of-file (EOF) error may occur when standard input streams in the container are read. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Stdin")]
                [Validation(Required=false)]
                public bool? Stdin { get; set; }

                /// <summary>
                /// <para>Indicates whether standard input streams are disconnected after a client is disconnected. If Stdin is set to true, standard input streams remain connected among multiple sessions.</para>
                /// <para>If StdinOnce is set to true, standard input streams are connected after the container is started, and remain idle until a client is connected to receive data. After the client is disconnected, streams are also disconnected, and remain disconnected until the container restarts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("StdinOnce")]
                [Validation(Required=false)]
                public bool? StdinOnce { get; set; }

                /// <summary>
                /// <para>Indicates whether the Interaction feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <para>If the command is a /bin/bash command, the value of this parameter is true.</para>
                /// <para>Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Tty")]
                [Validation(Required=false)]
                public bool? Tty { get; set; }

                /// <summary>
                /// <para>The mounted volumes.</para>
                /// </summary>
                [NameInMap("VolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersVolumeMounts> VolumeMounts { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersVolumeMounts : TeaModel {
                    /// <summary>
                    /// <para>The directory to which the volume is mounted.</para>
                    /// <remarks>
                    /// <para> Data in this directory is overwritten by the data on the volume. Proceed with caution if you specify this parameter.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/pod/data</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>The mount propagation settings. Mount propagation enables volumes mounted on one container to be shared among other containers within the same pod or across distinct pods residing on the same node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>None: Subsequent mounts executed either on the volume itself or its subdirectories do not propagate to the already established volume mount.</description></item>
                    /// <item><description>HostToCotainer: Subsequent mounts executed either on the volume itself or its subdirectories propagate to the already established volume mount.</description></item>
                    /// <item><description>Bidirectional: This value is similar to HostToCotainer. Subsequent mounts executed either on the volume itself or its subdirectories propagate to the already established volume mount. In addition, any volume mounts executed on a container not only propagate back to the underlying host but also to all containers across every pod that uses the same volume.</description></item>
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
                    /// <para>The volume name. The value of this parameter is the same as the name of the volume that is mounted to containers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default-volume1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the volume is read-only.</para>
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
                /// <para>The working directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/local/nginx</para>
                /// </summary>
                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the Cost Optimization feature is enabled. Valid values:</para>
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
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// <para>The number of physical CPU cores. This parameter can be specified for only specific instance types. For more information, see <a href="https://help.aliyun.com/document_detail/197781.html">Specify CPU options</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CpuOptionsCore")]
            [Validation(Required=false)]
            public int? CpuOptionsCore { get; set; }

            /// <summary>
            /// <para>The number of threads per core. This parameter can be specified for only specific instance types. A value of 1 indicates that Hyper-Threading is disabled. For more information, see <a href="https://help.aliyun.com/document_detail/197781.html">Specify CPU options</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CpuOptionsThreadsPerCore")]
            [Validation(Required=false)]
            public int? CpuOptionsThreadsPerCore { get; set; }

            /// <summary>
            /// <para>The time at which the scaling configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-08-14T10:58Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The bucket that stores the data cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("DataCacheBucket")]
            [Validation(Required=false)]
            public string DataCacheBucket { get; set; }

            /// <summary>
            /// <para>Indicates whether the Performance Burst feature is enabled for the ESSD AutoPL disk that stores the data cache. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
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
            /// <para>The performance level (PL) of the cloud disk that stores the data cache. We recommend that you use enterprise SSDs (ESSDs). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: An ESSD can provide up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: An ESSD can provide up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: An ESSD can provide up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: An ESSD can provide up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
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
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk that stores the data cache. Valid values: 0 to min{50,000, 1000 x <em>Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50</em> x Capacity, 50,000}.</para>
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
            /// <para> This parameter is not available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>This is an example.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The IP addresses of the Domain Name Service (DNS) server.</para>
            /// </summary>
            [NameInMap("DnsConfigNameServers")]
            [Validation(Required=false)]
            public List<string> DnsConfigNameServers { get; set; }

            /// <summary>
            /// <para>The options. Each option is a name-value pair. The value in the name-value pair is optional.</para>
            /// </summary>
            [NameInMap("DnsConfigOptions")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsDnsConfigOptions> DnsConfigOptions { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsDnsConfigOptions : TeaModel {
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
            [NameInMap("DnsConfigSearches")]
            [Validation(Required=false)]
            public List<string> DnsConfigSearches { get; set; }

            /// <summary>
            /// <para>The Domain Name System (DNS) policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("DnsPolicy")]
            [Validation(Required=false)]
            public string DnsPolicy { get; set; }

            /// <summary>
            /// <para>The maximum outbound public bandwidth. Unit: bit/s.</para>
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
            /// <para>The capacity of the ephemeral storage. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EphemeralStorage")]
            [Validation(Required=false)]
            public int? EphemeralStorage { get; set; }

            [NameInMap("GpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

            /// <summary>
            /// <para>The hostnames and IP addresses for a container that are added to the hosts file of the elastic container instance.</para>
            /// </summary>
            [NameInMap("HostAliases")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsHostAliases> HostAliases { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsHostAliases : TeaModel {
                /// <summary>
                /// <para>The added hostnames.</para>
                /// </summary>
                [NameInMap("Hostnames")]
                [Validation(Required=false)]
                public List<string> Hostnames { get; set; }

                /// <summary>
                /// <para>The added IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.XX.XX</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// <para>The hostname series.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;hehe.com\&quot;, \&quot;haha.com\&quot;]</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The information about the image repository.</para>
            /// </summary>
            [NameInMap("ImageRegistryCredentials")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsImageRegistryCredentials> ImageRegistryCredentials { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsImageRegistryCredentials : TeaModel {
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
                /// <para>The domain name of the image repository.</para>
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
            /// <para>The maximum inbound public bandwidth. Unit: bit/s.</para>
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
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainers> InitContainers { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainers : TeaModel {
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
                /// <para>The container startup arguments.</para>
                /// </summary>
                [NameInMap("InitContainerArgs")]
                [Validation(Required=false)]
                public List<string> InitContainerArgs { get; set; }

                /// <summary>
                /// <para>The container startup commands.</para>
                /// </summary>
                [NameInMap("InitContainerCommands")]
                [Validation(Required=false)]
                public List<string> InitContainerCommands { get; set; }

                /// <summary>
                /// <para>The environment variables.</para>
                /// </summary>
                [NameInMap("InitContainerEnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerEnvironmentVars> InitContainerEnvironmentVars { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerEnvironmentVars : TeaModel {
                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is not available for use.</para>
                    /// </remarks>
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
                /// <para>The ports of the init container.</para>
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
                /// <para>The volumes that are mounted to the init container.</para>
                /// </summary>
                [NameInMap("InitContainerVolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerVolumeMounts> InitContainerVolumeMounts { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerVolumeMounts : TeaModel {
                    /// <summary>
                    /// <para>The directory to which the volume is mounted. Data under this directory is overwritten by the data on the volume.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/share/</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>The mount propagation setting. Mount propagation enables volumes mounted on one container to be shared among other containers within the same pod or across distinct pods residing on the same node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>None: Subsequent mounts executed either on the volume itself or its subdirectories do not propagate to the already established volume mount.</description></item>
                    /// <item><description>HostToCotainer: Subsequent mounts executed either on the volume itself or its subdirectories propagate to the already established volume mount.</description></item>
                    /// <item><description>Bidirectional: This value is similar to HostToCotainer. Subsequent mounts executed either on the volume itself or its subdirectories propagate to the already established volume mount. In addition, any volume mounts executed on a container not only propagate back to the underlying host but also to all containers across every pod that uses the same volume.</description></item>
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
                    /// <para>The volume name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-empty</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the mount directory is read-only.</para>
                    /// <para>Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// <para>The volume subdirectory. A pod can mount different directories of the same volume to different directories of the init container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/usr/sub/</para>
                    /// </summary>
                    [NameInMap("SubPath")]
                    [Validation(Required=false)]
                    public string SubPath { get; set; }

                }

                /// <summary>
                /// <para>The memory size per init container.</para>
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
                /// <para>The permissions that are granted to the processes in the init container. Valid values: NET_ADMIN and NET_RAW.</para>
                /// <remarks>
                /// <para> To use NET_RAW, you must submit a ticket.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("SecurityContextCapabilityAdds")]
                [Validation(Required=false)]
                public List<string> SecurityContextCapabilityAdds { get; set; }

                /// <summary>
                /// <para>Indicates whether the root file system is read-only. Valid value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SecurityContextReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? SecurityContextReadOnlyRootFilesystem { get; set; }

                /// <summary>
                /// <para>The ID of the user that runs the init container.</para>
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
            /// <para>The level of the instance family, which is used to filter the available instance types that meet the specified requirements. This parameter takes effect only if <c>CostOptimization</c> is set to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EntryLevel: entry level (shared instance types). Instance types of this level are the most cost-effective but may not provide stable computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
            /// <item><description>EnterpriseLevel: enterprise level. Instance types of this level provide stable performance and dedicated resources, and are suitable for business scenarios that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</description></item>
            /// <item><description>CreditEntryLevel: credit-based entry level (burstable instance types). CPU credits are used to ensure computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
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
            /// <para>The status of the scaling configuration in the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active: The scaling configuration is active in the scaling group. Auto Scaling uses the scaling configuration that is in the Active state to create instances during scale-out events.</description></item>
            /// <item><description>Inactive: The scaling configuration is inactive in the scaling group. Scaling configurations that are in the Inactive state are still contained in the scaling group, but Auto Scaling does not use the inactive scaling configurations to create instances during scale-out events.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// <para>The load balancing weight of each elastic container instance as a backend server. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LoadBalancerWeight")]
            [Validation(Required=false)]
            public int? LoadBalancerWeight { get; set; }

            /// <summary>
            /// <para>The memory size.</para>
            /// <para>You can specify CPU and Memory to define the range of instance types. For example, if you set CPU to 2 and Memory to 16, the instance types that have 2 vCPUs and 16 GiB are returned. After you specify CPU and Memory, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones and preferentially creates instances by using the lowest-priced instance type.</para>
            /// <remarks>
            /// <para> You can specify CPU and Memory to define instance types only if you set Scaling Policy to Cost Optimization and no instance type is specified in the scaling configuration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The endpoints of the Network Time Protocol (NTP) server.</para>
            /// </summary>
            [NameInMap("NtpServers")]
            [Validation(Required=false)]
            public List<string> NtpServers { get; set; }

            /// <summary>
            /// <para>The Resource Access Management (RAM) role of elastic container instances. Elastic container instances and Elastic Compute Service (ECS) instances can share the same RAM role. For more information, see <a href="https://help.aliyun.com/document_detail/61178.html">Use an instance RAM role by calling API operations</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ram:PassRole</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The region ID of elastic container instances.</para>
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
            /// <para>The restart policy of elastic container instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Never: Elastic container instances are never restarted.</description></item>
            /// <item><description>Always: Elastic container instances are always restarted.</description></item>
            /// <item><description>OnFailure: Elastic container instances are restarted upon failures.</description></item>
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
            /// <para>The system information of the security context in which the elastic container instance runs.</para>
            /// </summary>
            [NameInMap("SecurityContextSysCtls")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsSecurityContextSysCtls> SecurityContextSysCtls { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsSecurityContextSysCtls : TeaModel {
                /// <summary>
                /// <para>The system name of the security context in which the elastic container instance runs.</para>
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
            /// <para>The ID of the security group with which elastic container instances are associated. Elastic container instances that are associated with the same security group can communicate with each other.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp18kz60mefs****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("SlsEnable")]
            [Validation(Required=false)]
            public bool? SlsEnable { get; set; }

            /// <summary>
            /// <para>The maximum hourly price for preemptible elastic container instances.</para>
            /// <para>This parameter is returned only if you set SpotStrategy to SpotWithPriceLimit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.025</para>
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

            /// <summary>
            /// <para>The bidding policy for elastic container instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoSpot: The instances are created as regular pay-as-you-go instances.</description></item>
            /// <item><description>SpotWithPriceLimit: The instances are created as preemptible instances with a user-defined maximum hourly price.</description></item>
            /// <item><description>SpotAsPriceGo: The instances are created as preemptible instances for which the market price at the time of purchase is automatically used as the bid price.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>The tags of elastic container instances. Tags are specified in the key-value format.</para>
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
            /// <para>The buffer time during which a program handles operations before the program stops.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("TerminationGracePeriodSeconds")]
            [Validation(Required=false)]
            public int? TerminationGracePeriodSeconds { get; set; }

            /// <summary>
            /// <para>The volumes.</para>
            /// </summary>
            [NameInMap("Volumes")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumes> Volumes { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumes : TeaModel {
                /// <summary>
                /// <para>The paths to configuration files.</para>
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
                /// <para>The system type of the disk volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xfs</para>
                /// </summary>
                [NameInMap("DiskVolumeFsType")]
                [Validation(Required=false)]
                public string DiskVolumeFsType { get; set; }

                /// <summary>
                /// <para>The storage medium of the emptyDir volume. If you do not specify a storage medium for the emptyDir volume, the volume stores data in the file system of a node by default. We recommend that you set this parameter to memory. In this case, the emptyDir volume stores data in the specified memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>memory</para>
                /// </summary>
                [NameInMap("EmptyDirVolumeMedium")]
                [Validation(Required=false)]
                public string EmptyDirVolumeMedium { get; set; }

                /// <summary>
                /// <para>The storage size of the emptyDir volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>256Mi</para>
                /// </summary>
                [NameInMap("EmptyDirVolumeSizeLimit")]
                [Validation(Required=false)]
                public string EmptyDirVolumeSizeLimit { get; set; }

                /// <summary>
                /// <para>The name of the FlexVolume driver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flexvolume</para>
                /// </summary>
                [NameInMap("FlexVolumeDriver")]
                [Validation(Required=false)]
                public string FlexVolumeDriver { get; set; }

                /// <summary>
                /// <para>The type of the mounted file system. The default value is determined by the script of FlexVolume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ext4</para>
                /// </summary>
                [NameInMap("FlexVolumeFsType")]
                [Validation(Required=false)]
                public string FlexVolumeFsType { get; set; }

                /// <summary>
                /// <para>The FlexVolume options. Each option is a key-value pair in a JSON string.</para>
                /// <para>For example, if you use FlexVolume to mount a disk, the format of Options is <c>{&quot;volumeId&quot;:&quot;d-2zehdahrwoa7srg****&quot;,&quot;performanceLevel&quot;: &quot;PL2&quot;}</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;volumeId&quot;:&quot;d-2zehdahrwoa7srg****&quot;,&quot;performanceLevel&quot;: &quot;PL2&quot;}</para>
                /// </summary>
                [NameInMap("FlexVolumeOptions")]
                [Validation(Required=false)]
                public string FlexVolumeOptions { get; set; }

                /// <summary>
                /// <para>The path to the HostPath volume on the host.</para>
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
                /// <para>The path to the Network File System (NFS) volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/share</para>
                /// </summary>
                [NameInMap("NFSVolumePath")]
                [Validation(Required=false)]
                public string NFSVolumePath { get; set; }

                /// <summary>
                /// <para>Indicates whether the NFS volume is read-only.</para>
                /// <para>Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("NFSVolumeReadOnly")]
                [Validation(Required=false)]
                public bool? NFSVolumeReadOnly { get; set; }

                /// <summary>
                /// <para>The endpoint of the NFS server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3f9cd4a596-naw76.cn-shanghai.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("NFSVolumeServer")]
                [Validation(Required=false)]
                public string NFSVolumeServer { get; set; }

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
