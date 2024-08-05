// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeEciScalingConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The scaling configurations.
        /// </summary>
        [NameInMap("ScalingConfigurations")]
        [Validation(Required=false)]
        public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurations> ScalingConfigurations { get; set; }
        public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurations : TeaModel {
            /// <summary>
            /// The Container Registry Enterprise Edition instances.
            /// </summary>
            [NameInMap("AcrRegistryInfos")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsAcrRegistryInfos> AcrRegistryInfos { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsAcrRegistryInfos : TeaModel {
                /// <summary>
                /// The domain names of the Container Registry Enterprise Edition instance. By default, all domain names of the instance are displayed. Multiple domain names are separated by commas (,).
                /// </summary>
                [NameInMap("Domains")]
                [Validation(Required=false)]
                public List<string> Domains { get; set; }

                /// <summary>
                /// The ID of the Container Registry Enterprise Edition instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the Container Registry Enterprise Edition instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The region ID of the Container Registry Enterprise Edition instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// The validity period of the scaling configuration. Unit: seconds.
            /// </summary>
            [NameInMap("ActiveDeadlineSeconds")]
            [Validation(Required=false)]
            public int? ActiveDeadlineSeconds { get; set; }

            /// <summary>
            /// Indicates whether elastic IP addresses (EIPs) are automatically created and bound to elastic container instances.
            /// </summary>
            [NameInMap("AutoCreateEip")]
            [Validation(Required=false)]
            public bool? AutoCreateEip { get; set; }

            /// <summary>
            /// Indicates whether the image cache is automatically matched. Default value: false.
            /// </summary>
            [NameInMap("AutoMatchImageCache")]
            [Validation(Required=false)]
            public bool? AutoMatchImageCache { get; set; }

            /// <summary>
            /// The name series of elastic container instances.
            /// </summary>
            [NameInMap("ContainerGroupName")]
            [Validation(Required=false)]
            public string ContainerGroupName { get; set; }

            /// <summary>
            /// The containers in an elastic container instance.
            /// </summary>
            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainers> Containers { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainers : TeaModel {
                /// <summary>
                /// The container startup arguments. You can specify up to 10 arguments.
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// The container startup commands. You can specify up to 20 commands. Each command can contain up to 256 characters.
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

                /// <summary>
                /// The number of vCPUs per container.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// The environment variables.
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersEnvironmentVars : TeaModel {
                    /// <summary>
                    /// >  This parameter is not available for use.
                    /// </summary>
                    [NameInMap("FieldRefFieldPath")]
                    [Validation(Required=false)]
                    public string FieldRefFieldPath { get; set; }

                    /// <summary>
                    /// The name of the environment variable.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the environment variable.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The number of GPUs.
                /// </summary>
                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }

                /// <summary>
                /// The container image.
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// The image pulling policy. Valid values:
                /// 
                /// *   Always: Each time image pulling is performed.
                /// *   IfNotPresent: Image pulling is performed as needed. On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.
                /// *   Never: On-premises images are always used. Image pulling is not performed.
                /// </summary>
                [NameInMap("ImagePullPolicy")]
                [Validation(Required=false)]
                public string ImagePullPolicy { get; set; }

                /// <summary>
                /// The commands that are run for configuring the postStart callback function by using the CLI within the container.
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerExecs")]
                [Validation(Required=false)]
                public List<string> LifecyclePostStartHandlerExecs { get; set; }

                /// <summary>
                /// The IP address of the host to which HTTP GET requests for configuring the postStart callback function are sent.
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerHttpGetHost")]
                [Validation(Required=false)]
                public string LifecyclePostStartHandlerHttpGetHost { get; set; }

                /// <summary>
                /// The path to which HTTP GET requests for configuring the postStart callback function are sent.
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerHttpGetPath")]
                [Validation(Required=false)]
                public string LifecyclePostStartHandlerHttpGetPath { get; set; }

                /// <summary>
                /// The port over which HTTP GET requests for configuring the postStart callback function are sent.
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerHttpGetPort")]
                [Validation(Required=false)]
                public int? LifecyclePostStartHandlerHttpGetPort { get; set; }

                /// <summary>
                /// The protocol type of the HTTP GET requests that are sent for configuring the postStart callback function.
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerHttpGetScheme")]
                [Validation(Required=false)]
                public string LifecyclePostStartHandlerHttpGetScheme { get; set; }

                /// <summary>
                /// The IP address of the host detected by the TCP sockets used for configuring the postStart callback function.
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerTcpSocketHost")]
                [Validation(Required=false)]
                public string LifecyclePostStartHandlerTcpSocketHost { get; set; }

                /// <summary>
                /// The port detected by the TCP sockets used for configuring the postStart callback function.
                /// </summary>
                [NameInMap("LifecyclePostStartHandlerTcpSocketPort")]
                [Validation(Required=false)]
                public int? LifecyclePostStartHandlerTcpSocketPort { get; set; }

                /// <summary>
                /// The commands that are run for configuring the preStop callback function by using the CLI within the container.
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerExecs")]
                [Validation(Required=false)]
                public List<string> LifecyclePreStopHandlerExecs { get; set; }

                /// <summary>
                /// The IP address of the host to which HTTP GET requests for configuring the preStop callback function are sent.
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerHttpGetHost")]
                [Validation(Required=false)]
                public string LifecyclePreStopHandlerHttpGetHost { get; set; }

                /// <summary>
                /// The path to which HTTP GET requests for configuring the preStop callback function are sent.
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerHttpGetPath")]
                [Validation(Required=false)]
                public string LifecyclePreStopHandlerHttpGetPath { get; set; }

                /// <summary>
                /// The port over which HTTP GET requests for configuring the preStop callback function are sent.
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerHttpGetPort")]
                [Validation(Required=false)]
                public int? LifecyclePreStopHandlerHttpGetPort { get; set; }

                /// <summary>
                /// The protocol type of the HTTP Get requests that are sent for configuring the preStop callback function.
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerHttpGetScheme")]
                [Validation(Required=false)]
                public string LifecyclePreStopHandlerHttpGetScheme { get; set; }

                /// <summary>
                /// The IP address of the host detected by the TCP sockets used for configuring the preStop callback function.
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerTcpSocketHost")]
                [Validation(Required=false)]
                public string LifecyclePreStopHandlerTcpSocketHost { get; set; }

                /// <summary>
                /// The port detected by the TCP sockets used for configuring the preStop callback function.
                /// </summary>
                [NameInMap("LifecyclePreStopHandlerTcpSocketPort")]
                [Validation(Required=false)]
                public int? LifecyclePreStopHandlerTcpSocketPort { get; set; }

                /// <summary>
                /// The commands that are run in the container when you use the CLI to perform liveness probes.
                /// </summary>
                [NameInMap("LivenessProbeExecCommands")]
                [Validation(Required=false)]
                public List<string> LivenessProbeExecCommands { get; set; }

                /// <summary>
                /// The minimum number of consecutive failures before a successful liveness probe is considered failed.
                /// 
                /// Default value: 3.
                /// </summary>
                [NameInMap("LivenessProbeFailureThreshold")]
                [Validation(Required=false)]
                public int? LivenessProbeFailureThreshold { get; set; }

                /// <summary>
                /// The path to which HTTP GET requests are sent when you use the HTTP GET requests to perform liveness probes.
                /// </summary>
                [NameInMap("LivenessProbeHttpGetPath")]
                [Validation(Required=false)]
                public string LivenessProbeHttpGetPath { get; set; }

                /// <summary>
                /// The port to which HTTP GET requests are sent to perform liveness probes.
                /// </summary>
                [NameInMap("LivenessProbeHttpGetPort")]
                [Validation(Required=false)]
                public int? LivenessProbeHttpGetPort { get; set; }

                /// <summary>
                /// The protocol type of HTTP GET requests when you use the HTTP GET requests to perform liveness probes. Valid values:
                /// 
                /// *   HTTP
                /// *   HTTPS
                /// </summary>
                [NameInMap("LivenessProbeHttpGetScheme")]
                [Validation(Required=false)]
                public string LivenessProbeHttpGetScheme { get; set; }

                /// <summary>
                /// The number of seconds that elapses from the startup of the container to the start time of a liveness probe.
                /// </summary>
                [NameInMap("LivenessProbeInitialDelaySeconds")]
                [Validation(Required=false)]
                public int? LivenessProbeInitialDelaySeconds { get; set; }

                /// <summary>
                /// The interval at which liveness probes are performed. Unit: seconds. Default value: 10. Minimum value: 1.
                /// </summary>
                [NameInMap("LivenessProbePeriodSeconds")]
                [Validation(Required=false)]
                public int? LivenessProbePeriodSeconds { get; set; }

                /// <summary>
                /// The minimum number of consecutive successes before a failed liveness probe is considered successful. Default value: 1. Valid value: 1.
                /// </summary>
                [NameInMap("LivenessProbeSuccessThreshold")]
                [Validation(Required=false)]
                public int? LivenessProbeSuccessThreshold { get; set; }

                /// <summary>
                /// The port detected by TCP sockets when you use the TCP sockets to perform liveness probes.
                /// </summary>
                [NameInMap("LivenessProbeTcpSocketPort")]
                [Validation(Required=false)]
                public int? LivenessProbeTcpSocketPort { get; set; }

                /// <summary>
                /// The timeout period of a liveness probe. Default value: 1. Minimum value: 1. Unit: seconds.
                /// </summary>
                [NameInMap("LivenessProbeTimeoutSeconds")]
                [Validation(Required=false)]
                public int? LivenessProbeTimeoutSeconds { get; set; }

                /// <summary>
                /// The memory size per container.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// The custom name of the container.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The exposed ports and protocols.
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersPorts> Ports { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersPorts : TeaModel {
                    /// <summary>
                    /// The port number. Valid values: 1 to 65535.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The protocol type. Valid values:
                    /// 
                    /// *   TCP
                    /// *   UDP
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// The commands that are run in the container when you use the CLI to perform readiness probes.
                /// </summary>
                [NameInMap("ReadinessProbeExecCommands")]
                [Validation(Required=false)]
                public List<string> ReadinessProbeExecCommands { get; set; }

                /// <summary>
                /// The minimum number of consecutive failures before a successful readiness probe is considered failed.
                /// 
                /// Default value: 3.
                /// </summary>
                [NameInMap("ReadinessProbeFailureThreshold")]
                [Validation(Required=false)]
                public int? ReadinessProbeFailureThreshold { get; set; }

                /// <summary>
                /// The path to which HTTP GET requests are sent when you use the HTTP GET requests to perform readiness probes.
                /// </summary>
                [NameInMap("ReadinessProbeHttpGetPath")]
                [Validation(Required=false)]
                public string ReadinessProbeHttpGetPath { get; set; }

                /// <summary>
                /// The path to which HTTP GET requests are sent when you use the HTTP GET requests to perform readiness probes.
                /// </summary>
                [NameInMap("ReadinessProbeHttpGetPort")]
                [Validation(Required=false)]
                public int? ReadinessProbeHttpGetPort { get; set; }

                /// <summary>
                /// The protocol type of HTTP GET requests when you use the HTTP requests to perform readiness probes. Valid values:
                /// 
                /// *   HTTP
                /// *   HTTPS
                /// </summary>
                [NameInMap("ReadinessProbeHttpGetScheme")]
                [Validation(Required=false)]
                public string ReadinessProbeHttpGetScheme { get; set; }

                /// <summary>
                /// The number of seconds that elapses from the startup of the container to the start time of a readiness probe.
                /// </summary>
                [NameInMap("ReadinessProbeInitialDelaySeconds")]
                [Validation(Required=false)]
                public int? ReadinessProbeInitialDelaySeconds { get; set; }

                /// <summary>
                /// The interval at which readiness probes are performed. Unit: seconds. Default value: 10. Minimum value: 1.
                /// </summary>
                [NameInMap("ReadinessProbePeriodSeconds")]
                [Validation(Required=false)]
                public int? ReadinessProbePeriodSeconds { get; set; }

                /// <summary>
                /// The minimum number of consecutive successes before a failed readiness probe is considered successful. Default value: 1. Valid value: 1.
                /// </summary>
                [NameInMap("ReadinessProbeSuccessThreshold")]
                [Validation(Required=false)]
                public int? ReadinessProbeSuccessThreshold { get; set; }

                /// <summary>
                /// The port detected by TCP sockets when you use the TCP sockets to perform readiness probes.
                /// </summary>
                [NameInMap("ReadinessProbeTcpSocketPort")]
                [Validation(Required=false)]
                public int? ReadinessProbeTcpSocketPort { get; set; }

                /// <summary>
                /// The timeout period of a readiness probe. Default value: 1. Minimum value: 1. Unit: seconds.
                /// </summary>
                [NameInMap("ReadinessProbeTimeoutSeconds")]
                [Validation(Required=false)]
                public int? ReadinessProbeTimeoutSeconds { get; set; }

                /// <summary>
                /// The permissions that are granted to the processes in the container. Valid values: NET_ADMIN and NET_RAW.
                /// 
                /// >  To use NET_RAW, you must submit a ticket.
                /// </summary>
                [NameInMap("SecurityContextCapabilityAdds")]
                [Validation(Required=false)]
                public List<string> SecurityContextCapabilityAdds { get; set; }

                /// <summary>
                /// Indicates whether the root file system on which the container runs is read-only. Valid value: true.
                /// </summary>
                [NameInMap("SecurityContextReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? SecurityContextReadOnlyRootFilesystem { get; set; }

                /// <summary>
                /// The ID of the user that runs the entry point of the container process.
                /// </summary>
                [NameInMap("SecurityContextRunAsUser")]
                [Validation(Required=false)]
                public long? SecurityContextRunAsUser { get; set; }

                /// <summary>
                /// Indicates whether the container allocates buffer resources to standard input streams when the container is running. If this parameter is not specified, an end-of-file (EOF) error may occur when standard input streams in the container are read. Default value: false.
                /// </summary>
                [NameInMap("Stdin")]
                [Validation(Required=false)]
                public bool? Stdin { get; set; }

                /// <summary>
                /// Indicates whether standard input streams are disconnected after a client is disconnected. If Stdin is set to true, standard input streams remain connected among multiple sessions.
                /// 
                /// If StdinOnce is set to true, standard input streams are connected after the container is started, and remain idle until a client is connected to receive data. After the client is disconnected, streams are also disconnected, and remain disconnected until the container restarts.
                /// </summary>
                [NameInMap("StdinOnce")]
                [Validation(Required=false)]
                public bool? StdinOnce { get; set; }

                /// <summary>
                /// Indicates whether the Interaction feature is enabled. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// If the command is a /bin/bash command, the value of this parameter is true.
                /// 
                /// Default value: false.
                /// </summary>
                [NameInMap("Tty")]
                [Validation(Required=false)]
                public bool? Tty { get; set; }

                /// <summary>
                /// The mounted volumes.
                /// </summary>
                [NameInMap("VolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersVolumeMounts> VolumeMounts { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersVolumeMounts : TeaModel {
                    /// <summary>
                    /// The directory to which the volume is mounted.
                    /// 
                    /// >  Data in this directory is overwritten by the data on the volume. Proceed with caution if you specify this parameter.
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// The mount propagation settings. Mount propagation enables volumes mounted on one container to be shared among other containers within the same pod or across distinct pods residing on the same node. Valid values:
                    /// 
                    /// *   None: Subsequent mounts executed either on the volume itself or its subdirectories do not propagate to the already established volume mount.
                    /// *   HostToCotainer: Subsequent mounts executed either on the volume itself or its subdirectories propagate to the already established volume mount.
                    /// *   Bidirectional: This value is similar to HostToCotainer. Subsequent mounts executed either on the volume itself or its subdirectories propagate to the already established volume mount. In addition, any volume mounts executed on a container not only propagate back to the underlying host but also to all containers across every pod that uses the same volume.
                    /// 
                    /// Default value: None.
                    /// </summary>
                    [NameInMap("MountPropagation")]
                    [Validation(Required=false)]
                    public string MountPropagation { get; set; }

                    /// <summary>
                    /// The volume name. The value of this parameter is the same as the name of the volume that is mounted to containers.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// Indicates whether the volume is read-only.
                    /// 
                    /// Default value: false.
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// The volume subdirectory.
                    /// </summary>
                    [NameInMap("SubPath")]
                    [Validation(Required=false)]
                    public string SubPath { get; set; }

                }

                /// <summary>
                /// The working directory.
                /// </summary>
                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

            /// <summary>
            /// Indicates whether the Cost Optimization feature is enabled. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("CostOptimization")]
            [Validation(Required=false)]
            public bool? CostOptimization { get; set; }

            /// <summary>
            /// The number of vCPUs per elastic container instance.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// The number of physical CPU cores. This parameter can be specified for only specific instance types. For more information, see [Specify CPU options](https://help.aliyun.com/document_detail/197781.html).
            /// </summary>
            [NameInMap("CpuOptionsCore")]
            [Validation(Required=false)]
            public int? CpuOptionsCore { get; set; }

            /// <summary>
            /// The number of threads per core. This parameter can be specified for only specific instance types. A value of 1 indicates that Hyper-Threading is disabled. For more information, see [Specify CPU options](https://help.aliyun.com/document_detail/197781.html).
            /// </summary>
            [NameInMap("CpuOptionsThreadsPerCore")]
            [Validation(Required=false)]
            public int? CpuOptionsThreadsPerCore { get; set; }

            /// <summary>
            /// The time at which the scaling configuration was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The bucket that stores the data cache.
            /// </summary>
            [NameInMap("DataCacheBucket")]
            [Validation(Required=false)]
            public string DataCacheBucket { get; set; }

            /// <summary>
            /// Indicates whether the Performance Burst feature is enabled for the ESSD AutoPL disk that stores the data cache. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// >  For more information about ESSD AutoPL disks, see [ESSD AutoPL disks](https://help.aliyun.com/document_detail/368372.html).
            /// </summary>
            [NameInMap("DataCacheBurstingEnabled")]
            [Validation(Required=false)]
            public bool? DataCacheBurstingEnabled { get; set; }

            /// <summary>
            /// The performance level (PL) of the cloud disk that stores the data cache. We recommend that you use enterprise SSDs (ESSDs). Valid values:
            /// 
            /// *   PL0: An ESSD can provide up to 10,000 random read/write IOPS.
            /// *   PL1: An ESSD can provide up to 50,000 random read/write IOPS.
            /// *   PL2: An ESSD can provide up to 100,000 random read/write IOPS.
            /// *   PL3: An ESSD can provide up to 1,000,000 random read/write IOPS.
            /// 
            /// >  For more information about ESSDs, see [ESSDs](https://help.aliyun.com/document_detail/122389.html).
            /// </summary>
            [NameInMap("DataCachePL")]
            [Validation(Required=false)]
            public string DataCachePL { get; set; }

            /// <summary>
            /// The provisioned read/write IOPS of the ESSD AutoPL disk that stores the data cache. Valid values: 0 to min{50,000, 1000 x *Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50* x Capacity, 50,000}.
            /// 
            /// >  For more information about ESSD AutoPL disks, see [ESSD AutoPL disks](https://help.aliyun.com/document_detail/368372.html).
            /// </summary>
            [NameInMap("DataCacheProvisionedIops")]
            [Validation(Required=false)]
            public int? DataCacheProvisionedIops { get; set; }

            /// <summary>
            /// >  This parameter is not available for use.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The IP addresses of the Domain Name Service (DNS) server.
            /// </summary>
            [NameInMap("DnsConfigNameServers")]
            [Validation(Required=false)]
            public List<string> DnsConfigNameServers { get; set; }

            /// <summary>
            /// The options. Each option is a name-value pair. The value in the name-value pair is optional.
            /// </summary>
            [NameInMap("DnsConfigOptions")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsDnsConfigOptions> DnsConfigOptions { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsDnsConfigOptions : TeaModel {
                /// <summary>
                /// The variable name of the option.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The variable value of the option.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The search domains of the DNS servers.
            /// </summary>
            [NameInMap("DnsConfigSearches")]
            [Validation(Required=false)]
            public List<string> DnsConfigSearches { get; set; }

            /// <summary>
            /// The Domain Name System (DNS) policy.
            /// </summary>
            [NameInMap("DnsPolicy")]
            [Validation(Required=false)]
            public string DnsPolicy { get; set; }

            /// <summary>
            /// The maximum outbound public bandwidth. Unit: bit/s.
            /// </summary>
            [NameInMap("EgressBandwidth")]
            [Validation(Required=false)]
            public long? EgressBandwidth { get; set; }

            /// <summary>
            /// The EIP bandwidth. Default value: 5. Unit: Mbit/s.
            /// </summary>
            [NameInMap("EipBandwidth")]
            [Validation(Required=false)]
            public int? EipBandwidth { get; set; }

            /// <summary>
            /// The capacity of the ephemeral storage. Unit: GiB.
            /// </summary>
            [NameInMap("EphemeralStorage")]
            [Validation(Required=false)]
            public int? EphemeralStorage { get; set; }

            /// <summary>
            /// The hostnames and IP addresses for a container that are added to the hosts file of the elastic container instance.
            /// </summary>
            [NameInMap("HostAliases")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsHostAliases> HostAliases { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsHostAliases : TeaModel {
                /// <summary>
                /// The added hostnames.
                /// </summary>
                [NameInMap("Hostnames")]
                [Validation(Required=false)]
                public List<string> Hostnames { get; set; }

                /// <summary>
                /// The added IP address.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// The hostname series.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The information about the image repository.
            /// </summary>
            [NameInMap("ImageRegistryCredentials")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsImageRegistryCredentials> ImageRegistryCredentials { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsImageRegistryCredentials : TeaModel {
                /// <summary>
                /// The password of the image repository.
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// The domain name of the image repository.
                /// </summary>
                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

                /// <summary>
                /// The username of the image repository.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// The ID of the image cache.
            /// </summary>
            [NameInMap("ImageSnapshotId")]
            [Validation(Required=false)]
            public string ImageSnapshotId { get; set; }

            /// <summary>
            /// The maximum inbound public bandwidth. Unit: bit/s.
            /// </summary>
            [NameInMap("IngressBandwidth")]
            [Validation(Required=false)]
            public long? IngressBandwidth { get; set; }

            /// <summary>
            /// The init containers.
            /// </summary>
            [NameInMap("InitContainers")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainers> InitContainers { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainers : TeaModel {
                /// <summary>
                /// The number of vCPUs per init container.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// The number of GPUs per init container.
                /// </summary>
                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }

                /// <summary>
                /// The image of the init container.
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// The image pulling policy.
                /// </summary>
                [NameInMap("ImagePullPolicy")]
                [Validation(Required=false)]
                public string ImagePullPolicy { get; set; }

                /// <summary>
                /// The container startup arguments.
                /// </summary>
                [NameInMap("InitContainerArgs")]
                [Validation(Required=false)]
                public List<string> InitContainerArgs { get; set; }

                /// <summary>
                /// The container startup commands.
                /// </summary>
                [NameInMap("InitContainerCommands")]
                [Validation(Required=false)]
                public List<string> InitContainerCommands { get; set; }

                /// <summary>
                /// The environment variables.
                /// </summary>
                [NameInMap("InitContainerEnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerEnvironmentVars> InitContainerEnvironmentVars { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerEnvironmentVars : TeaModel {
                    /// <summary>
                    /// >  This parameter is not available for use.
                    /// </summary>
                    [NameInMap("FieldRefFieldPath")]
                    [Validation(Required=false)]
                    public string FieldRefFieldPath { get; set; }

                    /// <summary>
                    /// The name of the environment variable.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the environment variable.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The ports of the init container.
                /// </summary>
                [NameInMap("InitContainerPorts")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerPorts> InitContainerPorts { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerPorts : TeaModel {
                    /// <summary>
                    /// The port number. Valid values: 1 to 65535.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The protocol type. Valid values:
                    /// 
                    /// *   TCP
                    /// *   UDP
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// The volumes that are mounted to the init container.
                /// </summary>
                [NameInMap("InitContainerVolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerVolumeMounts> InitContainerVolumeMounts { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerVolumeMounts : TeaModel {
                    /// <summary>
                    /// The directory to which the volume is mounted. Data under this directory is overwritten by the data on the volume.
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// The mount propagation setting. Mount propagation enables volumes mounted on one container to be shared among other containers within the same pod or across distinct pods residing on the same node. Valid values:
                    /// 
                    /// *   None: Subsequent mounts executed either on the volume itself or its subdirectories do not propagate to the already established volume mount.
                    /// *   HostToCotainer: Subsequent mounts executed either on the volume itself or its subdirectories propagate to the already established volume mount.
                    /// *   Bidirectional: This value is similar to HostToCotainer. Subsequent mounts executed either on the volume itself or its subdirectories propagate to the already established volume mount. In addition, any volume mounts executed on a container not only propagate back to the underlying host but also to all containers across every pod that uses the same volume.
                    /// 
                    /// Default value: None.
                    /// </summary>
                    [NameInMap("MountPropagation")]
                    [Validation(Required=false)]
                    public string MountPropagation { get; set; }

                    /// <summary>
                    /// The volume name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// Indicates whether the mount directory is read-only.
                    /// 
                    /// Default value: false.
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// The volume subdirectory. A pod can mount different directories of the same volume to different directories of the init container.
                    /// </summary>
                    [NameInMap("SubPath")]
                    [Validation(Required=false)]
                    public string SubPath { get; set; }

                }

                /// <summary>
                /// The memory size per init container.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// The name of the init container.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The permissions that are granted to the processes in the init container. Valid values: NET_ADMIN and NET_RAW.
                /// 
                /// >  To use NET_RAW, you must submit a ticket.
                /// </summary>
                [NameInMap("SecurityContextCapabilityAdds")]
                [Validation(Required=false)]
                public List<string> SecurityContextCapabilityAdds { get; set; }

                /// <summary>
                /// Indicates whether the root file system is read-only. Valid value: true.
                /// </summary>
                [NameInMap("SecurityContextReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? SecurityContextReadOnlyRootFilesystem { get; set; }

                /// <summary>
                /// The ID of the user that runs the init container.
                /// </summary>
                [NameInMap("SecurityContextRunAsUser")]
                [Validation(Required=false)]
                public string SecurityContextRunAsUser { get; set; }

                /// <summary>
                /// The working directory.
                /// </summary>
                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

            /// <summary>
            /// The level of the instance family, which is used to filter the available instance types that meet the specified requirements. This parameter takes effect only if `CostOptimization` is set to true. Valid values:
            /// 
            /// *   EntryLevel: entry level (shared instance types). Instance types of this level are the most cost-effective but may not provide stable computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low. For more information, see [Shared instance families](https://help.aliyun.com/document_detail/108489.html).
            /// *   EnterpriseLevel: enterprise level. Instance types of this level provide stable performance and dedicated resources, and are suitable for business scenarios that require high stability. For more information, see [Overview of instance families](https://help.aliyun.com/document_detail/25378.html).
            /// *   CreditEntryLevel: credit-based entry level (burstable instance types). CPU credits are used to ensure computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For more information, see [Overview of burstable instances](https://help.aliyun.com/document_detail/59977.html).
            /// </summary>
            [NameInMap("InstanceFamilyLevel")]
            [Validation(Required=false)]
            public string InstanceFamilyLevel { get; set; }

            /// <summary>
            /// The specified ECS instance types. You can specify up to five instance types.
            /// </summary>
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// The number of IPv6 addresses.
            /// </summary>
            [NameInMap("Ipv6AddressCount")]
            [Validation(Required=false)]
            public int? Ipv6AddressCount { get; set; }

            /// <summary>
            /// The status of the scaling configuration in the scaling group. Valid values:
            /// 
            /// *   Active: The scaling configuration is active in the scaling group. Auto Scaling uses the scaling configuration that is in the Active state to create instances during scale-out events.
            /// *   Inactive: The scaling configuration is inactive in the scaling group. Scaling configurations that are in the Inactive state are still contained in the scaling group, but Auto Scaling does not use the inactive scaling configurations to create instances during scale-out events.
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// The load balancing weight of each elastic container instance as a backend server. Valid values: 1 to 100.
            /// </summary>
            [NameInMap("LoadBalancerWeight")]
            [Validation(Required=false)]
            public int? LoadBalancerWeight { get; set; }

            /// <summary>
            /// The memory size.
            /// 
            /// You can specify CPU and Memory to define the range of instance types. For example, if you set CPU to 2 and Memory to 16, the instance types that have 2 vCPUs and 16 GiB are returned. After you specify CPU and Memory, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones and preferentially creates instances by using the lowest-priced instance type.
            /// 
            /// >  You can specify CPU and Memory to define instance types only if you set Scaling Policy to Cost Optimization and no instance type is specified in the scaling configuration.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// The endpoints of the Network Time Protocol (NTP) server.
            /// </summary>
            [NameInMap("NtpServers")]
            [Validation(Required=false)]
            public List<string> NtpServers { get; set; }

            /// <summary>
            /// The Resource Access Management (RAM) role of elastic container instances. Elastic container instances and Elastic Compute Service (ECS) instances can share the same RAM role. For more information, see [Use an instance RAM role by calling API operations](https://help.aliyun.com/document_detail/61178.html).
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// The region ID of elastic container instances.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The restart policy of elastic container instances. Valid values:
            /// 
            /// *   Never: Elastic container instances are never restarted.
            /// *   Always: Elastic container instances are always restarted.
            /// *   OnFailure: Elastic container instances are restarted upon failures.
            /// </summary>
            [NameInMap("RestartPolicy")]
            [Validation(Required=false)]
            public string RestartPolicy { get; set; }

            /// <summary>
            /// The ID of the scaling configuration.
            /// </summary>
            [NameInMap("ScalingConfigurationId")]
            [Validation(Required=false)]
            public string ScalingConfigurationId { get; set; }

            /// <summary>
            /// The name of the scaling configuration.
            /// </summary>
            [NameInMap("ScalingConfigurationName")]
            [Validation(Required=false)]
            public string ScalingConfigurationName { get; set; }

            /// <summary>
            /// The ID of the scaling group to which the scaling configuration belongs.
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// The system information of the security context in which the elastic container instance runs.
            /// </summary>
            [NameInMap("SecurityContextSysCtls")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsSecurityContextSysCtls> SecurityContextSysCtls { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsSecurityContextSysCtls : TeaModel {
                /// <summary>
                /// The system name of the security context in which the elastic container instance runs.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The variable value of the security context in which the elastic container instance runs.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the security group with which elastic container instances are associated. Elastic container instances that are associated with the same security group can communicate with each other.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// >  This parameter is not available for use.
            /// </summary>
            [NameInMap("SlsEnable")]
            [Validation(Required=false)]
            public bool? SlsEnable { get; set; }

            /// <summary>
            /// The maximum hourly price for preemptible elastic container instances.
            /// 
            /// This parameter is returned only if you set SpotStrategy to SpotWithPriceLimit.
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

            /// <summary>
            /// The bidding policy for elastic container instances. Valid values:
            /// 
            /// *   NoSpot: The instances are created as regular pay-as-you-go instances.
            /// *   SpotWithPriceLimit: The instances are created as preemptible instances with a user-defined maximum hourly price.
            /// *   SpotAsPriceGo: The instances are created as preemptible instances for which the market price at the time of purchase is automatically used as the bid price.
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// The tags of elastic container instances. Tags are specified in the key-value format.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsTags> Tags { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The buffer time during which a program handles operations before the program stops.
            /// </summary>
            [NameInMap("TerminationGracePeriodSeconds")]
            [Validation(Required=false)]
            public int? TerminationGracePeriodSeconds { get; set; }

            /// <summary>
            /// The volumes.
            /// </summary>
            [NameInMap("Volumes")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumes> Volumes { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumes : TeaModel {
                /// <summary>
                /// The paths to configuration files.
                /// </summary>
                [NameInMap("ConfigFileVolumeConfigFileToPaths")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumesConfigFileVolumeConfigFileToPaths> ConfigFileVolumeConfigFileToPaths { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumesConfigFileVolumeConfigFileToPaths : TeaModel {
                    /// <summary>
                    /// The content of the configuration file (32 KB).
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The permissions on the ConfigFile volume.
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public int? Mode { get; set; }

                    /// <summary>
                    /// The relative path to the configuration file.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// The default permissions on the ConfigFile volume.
                /// </summary>
                [NameInMap("ConfigFileVolumeDefaultMode")]
                [Validation(Required=false)]
                public int? ConfigFileVolumeDefaultMode { get; set; }

                /// <summary>
                /// The size of the disk volume. Unit: GiB.
                /// </summary>
                [NameInMap("DiskVolumeDiskId")]
                [Validation(Required=false)]
                public string DiskVolumeDiskId { get; set; }

                /// <summary>
                /// The size of the disk volume. Unit: GiB.
                /// </summary>
                [NameInMap("DiskVolumeDiskSize")]
                [Validation(Required=false)]
                public int? DiskVolumeDiskSize { get; set; }

                /// <summary>
                /// The system type of the disk volume.
                /// </summary>
                [NameInMap("DiskVolumeFsType")]
                [Validation(Required=false)]
                public string DiskVolumeFsType { get; set; }

                /// <summary>
                /// The storage medium of the emptyDir volume. If you do not specify a storage medium for the emptyDir volume, the volume stores data in the file system of a node by default. We recommend that you set this parameter to memory. In this case, the emptyDir volume stores data in the specified memory.
                /// </summary>
                [NameInMap("EmptyDirVolumeMedium")]
                [Validation(Required=false)]
                public string EmptyDirVolumeMedium { get; set; }

                /// <summary>
                /// The storage size of the emptyDir volume.
                /// </summary>
                [NameInMap("EmptyDirVolumeSizeLimit")]
                [Validation(Required=false)]
                public string EmptyDirVolumeSizeLimit { get; set; }

                /// <summary>
                /// The name of the FlexVolume driver.
                /// </summary>
                [NameInMap("FlexVolumeDriver")]
                [Validation(Required=false)]
                public string FlexVolumeDriver { get; set; }

                /// <summary>
                /// The type of the mounted file system. The default value is determined by the script of FlexVolume.
                /// </summary>
                [NameInMap("FlexVolumeFsType")]
                [Validation(Required=false)]
                public string FlexVolumeFsType { get; set; }

                /// <summary>
                /// The FlexVolume options. Each option is a key-value pair in a JSON string.
                /// 
                /// For example, if you use FlexVolume to mount a disk, the format of Options is `{"volumeId":"d-2zehdahrwoa7srg****","performanceLevel": "PL2"}`.
                /// </summary>
                [NameInMap("FlexVolumeOptions")]
                [Validation(Required=false)]
                public string FlexVolumeOptions { get; set; }

                /// <summary>
                /// The path to the HostPath volume on the host.
                /// </summary>
                [NameInMap("HostPathVolumePath")]
                [Validation(Required=false)]
                public string HostPathVolumePath { get; set; }

                /// <summary>
                /// The type of the HostPath volume.
                /// </summary>
                [NameInMap("HostPathVolumeType")]
                [Validation(Required=false)]
                public string HostPathVolumeType { get; set; }

                /// <summary>
                /// The path to the Network File System (NFS) volume.
                /// </summary>
                [NameInMap("NFSVolumePath")]
                [Validation(Required=false)]
                public string NFSVolumePath { get; set; }

                /// <summary>
                /// Indicates whether the NFS volume is read-only.
                /// 
                /// Default value: false.
                /// </summary>
                [NameInMap("NFSVolumeReadOnly")]
                [Validation(Required=false)]
                public bool? NFSVolumeReadOnly { get; set; }

                /// <summary>
                /// The endpoint of the NFS server.
                /// </summary>
                [NameInMap("NFSVolumeServer")]
                [Validation(Required=false)]
                public string NFSVolumeServer { get; set; }

                /// <summary>
                /// The volume name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The volume type. Valid values:
                /// 
                /// *   EmptyDirVolume
                /// *   NFSVolume
                /// *   ConfigFileVolume
                /// *   FlexVolume
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The total number of scaling configurations.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
