// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeEciScalingConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The total number of scaling configurations.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Details of the scaling configurations.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time when the scaling configuration was created.
        /// </summary>
        [NameInMap("ScalingConfigurations")]
        [Validation(Required=false)]
        public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurations> ScalingConfigurations { get; set; }
        public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurations : TeaModel {
            /// <summary>
            /// The ID of the Container Registry Enterprise Edition instance.
            /// </summary>
            [NameInMap("AcrRegistryInfos")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsAcrRegistryInfos> AcrRegistryInfos { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsAcrRegistryInfos : TeaModel {
                /// <summary>
                /// The IP addresses of the DNS servers.
                /// </summary>
                [NameInMap("Domains")]
                [Validation(Required=false)]
                public List<string> Domains { get; set; }

                /// <summary>
                /// The region ID of the Container Registry Enterprise Edition instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The domain name of the Container Registry Enterprise Edition instance. By default, all domain names of the Container Registry Enterprise Edition instance are displayed. You can specify one or more domain names. Separate multiple domain names with commas (,).
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The domain name of the Container Registry Enterprise Edition instance. By default, all domain names of the Container Registry Enterprise Edition instance are displayed. You can specify one or more domain names. Separate multiple domain names with commas (,).
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// Indicates whether an elastic IP address (EIP) is automatically created, and then bound to the elastic container instance.
            /// </summary>
            [NameInMap("ActiveDeadlineSeconds")]
            [Validation(Required=false)]
            public int? ActiveDeadlineSeconds { get; set; }

            /// <summary>
            /// The size of the temporary storage space. Unit: GiB.
            /// </summary>
            [NameInMap("AutoCreateEip")]
            [Validation(Required=false)]
            public bool? AutoCreateEip { get; set; }

            /// <summary>
            /// The name of the elastic container instance.
            /// </summary>
            [NameInMap("AutoMatchImageCache")]
            [Validation(Required=false)]
            public bool? AutoMatchImageCache { get; set; }

            /// <summary>
            /// The number of physical CPU cores. This parameter can be specified for only some instance types. For more information, see [Specify custom CPU options](~~197781~~).
            /// </summary>
            [NameInMap("ContainerGroupName")]
            [Validation(Required=false)]
            public string ContainerGroupName { get; set; }

            /// <summary>
            /// The path to which the system sends an HTTP GET request for a probe.
            /// </summary>
            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainers> Containers { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainers : TeaModel {
                /// <summary>
                /// The commands that are run in the container when you use the CLI to perform probes.
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public List<string> Args { get; set; }

                /// <summary>
                /// The commands that are run in the container when you use the CLI to perform probes.
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

                /// <summary>
                /// The minimum number of consecutive failures for a probe to be considered failed after having been successful.
                /// 
                /// Default value: 3.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// The name of the environment variable.
                /// </summary>
                [NameInMap("EnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersEnvironmentVars> EnvironmentVars { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersEnvironmentVars : TeaModel {
                    /// <summary>
                    /// The container startup commands. You can specify up to 20 commands. Each command can contain up to 256 characters.
                    /// </summary>
                    [NameInMap("FieldRefFieldPath")]
                    [Validation(Required=false)]
                    public string FieldRefFieldPath { get; set; }

                    /// <summary>
                    /// > This parameter is unavailable.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The container startup commands. You can specify up to 20 commands. Each command can contain up to 256 characters.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// Indicates whether the container allocates buffer resources to standard input streams when the container runs. If you do not specify this parameter, an end-of-file (EOF) error may occur. Default value: false.
                /// </summary>
                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }

                /// <summary>
                /// The protocol type of HTTP GET requests when you use HTTP requests to perform probes. Valid values:
                /// 
                /// *   HTTP
                /// *   HTTPS
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// The number of vCPUs that are allocated to the container.
                /// </summary>
                [NameInMap("ImagePullPolicy")]
                [Validation(Required=false)]
                public string ImagePullPolicy { get; set; }

                /// <summary>
                /// The arguments that are passed to the container startup commands. You can specify up to 10 arguments.
                /// </summary>
                [NameInMap("LivenessProbeExecCommands")]
                [Validation(Required=false)]
                public List<string> LivenessProbeExecCommands { get; set; }

                /// <summary>
                /// The exposed ports and protocols of the container.
                /// </summary>
                [NameInMap("LivenessProbeFailureThreshold")]
                [Validation(Required=false)]
                public int? LivenessProbeFailureThreshold { get; set; }

                /// <summary>
                /// The port number of TcpSocket.
                /// </summary>
                [NameInMap("LivenessProbeHttpGetPath")]
                [Validation(Required=false)]
                public string LivenessProbeHttpGetPath { get; set; }

                /// <summary>
                /// The number of seconds between the time when the startup of the container ends and the time when the probe starts.
                /// </summary>
                [NameInMap("LivenessProbeHttpGetPort")]
                [Validation(Required=false)]
                public int? LivenessProbeHttpGetPort { get; set; }

                /// <summary>
                /// Indicates whether interaction is enabled. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// If the value of the Command parameter is /bin/bash, the value of this parameter is true.
                /// 
                /// Default value: false.
                /// </summary>
                [NameInMap("LivenessProbeHttpGetScheme")]
                [Validation(Required=false)]
                public string LivenessProbeHttpGetScheme { get; set; }

                /// <summary>
                /// The image pulling policy. Valid values:
                /// 
                /// *   Always: Image pulling is performed each time.
                /// *   IfNotPresent: Image pulling is performed only if on-premises images are unavailable. On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.
                /// *   Never: On-premises images are always used. Image pulling is not performed.
                /// </summary>
                [NameInMap("LivenessProbeInitialDelaySeconds")]
                [Validation(Required=false)]
                public int? LivenessProbeInitialDelaySeconds { get; set; }

                /// <summary>
                /// The protocol type of HTTP GET requests when you use HTTP requests to perform probes. Valid values:
                /// 
                /// *   HTTP
                /// *   HTTPS
                /// </summary>
                [NameInMap("LivenessProbePeriodSeconds")]
                [Validation(Required=false)]
                public int? LivenessProbePeriodSeconds { get; set; }

                /// <summary>
                /// The user ID (UID) that is used to run the entry point of the container process.
                /// </summary>
                [NameInMap("LivenessProbeSuccessThreshold")]
                [Validation(Required=false)]
                public int? LivenessProbeSuccessThreshold { get; set; }

                /// <summary>
                /// The working directory of the container.
                /// </summary>
                [NameInMap("LivenessProbeTcpSocketPort")]
                [Validation(Required=false)]
                public int? LivenessProbeTcpSocketPort { get; set; }

                /// <summary>
                /// The minimum number of consecutive failures for a probe to be considered failed after having been successful.
                /// 
                /// Default value: 3.
                /// </summary>
                [NameInMap("LivenessProbeTimeoutSeconds")]
                [Validation(Required=false)]
                public int? LivenessProbeTimeoutSeconds { get; set; }

                /// <summary>
                /// Indicates whether the root file system is set to the read-only mode. The only valid value is true.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// The path to which the system sends an HTTP GET request for a probe.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The port number. Valid values: 1 to 65535.
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersPorts> Ports { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersPorts : TeaModel {
                    /// <summary>
                    /// The volumes that are mounted on the container.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The volumes that are mounted on the container.
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// The permissions granted to processes in the container. Valid values: NET_ADMIN and NET_RAW.
                /// 
                /// > To use NET_RAW, you need to submit a ticket.
                /// </summary>
                [NameInMap("ReadinessProbeExecCommands")]
                [Validation(Required=false)]
                public List<string> ReadinessProbeExecCommands { get; set; }

                /// <summary>
                /// The exposed ports and protocols of the container.
                /// </summary>
                [NameInMap("ReadinessProbeFailureThreshold")]
                [Validation(Required=false)]
                public int? ReadinessProbeFailureThreshold { get; set; }

                /// <summary>
                /// The interval at which probes are performed. Default value: 10. Minimum value: 1. Unit: seconds.
                /// </summary>
                [NameInMap("ReadinessProbeHttpGetPath")]
                [Validation(Required=false)]
                public string ReadinessProbeHttpGetPath { get; set; }

                /// <summary>
                /// The timeout period of a probe. Default value: 1. Minimum value: 1. Unit: seconds.
                /// </summary>
                [NameInMap("ReadinessProbeHttpGetPort")]
                [Validation(Required=false)]
                public int? ReadinessProbeHttpGetPort { get; set; }

                /// <summary>
                /// The minimum number of consecutive successes for a probe to be considered successful after having failed. Default value: 1. Valid value: 1.
                /// </summary>
                [NameInMap("ReadinessProbeHttpGetScheme")]
                [Validation(Required=false)]
                public string ReadinessProbeHttpGetScheme { get; set; }

                /// <summary>
                /// The memory size of the container.
                /// </summary>
                [NameInMap("ReadinessProbeInitialDelaySeconds")]
                [Validation(Required=false)]
                public int? ReadinessProbeInitialDelaySeconds { get; set; }

                /// <summary>
                /// Indicates whether standard input streams are disconnected after a client is disconnected. If Stdin is set to true, standard input streams remain connected during multiple sessions.
                /// 
                /// If StdinOnce is set to true, standard input streams are connected after the container is started and remain idle until a client is connected to receive data. After the client is disconnected, streams are also disconnected and remain in the disconnected state until the container is started again.
                /// </summary>
                [NameInMap("ReadinessProbePeriodSeconds")]
                [Validation(Required=false)]
                public int? ReadinessProbePeriodSeconds { get; set; }

                /// <summary>
                /// The port number of TcpSocket.
                /// </summary>
                [NameInMap("ReadinessProbeSuccessThreshold")]
                [Validation(Required=false)]
                public int? ReadinessProbeSuccessThreshold { get; set; }

                /// <summary>
                /// The path to which the system sends an HTTP GET request for a probe.
                /// </summary>
                [NameInMap("ReadinessProbeTcpSocketPort")]
                [Validation(Required=false)]
                public int? ReadinessProbeTcpSocketPort { get; set; }

                /// <summary>
                /// The number of seconds between the time when the startup of the container ends and the time when the probe starts.
                /// </summary>
                [NameInMap("ReadinessProbeTimeoutSeconds")]
                [Validation(Required=false)]
                public int? ReadinessProbeTimeoutSeconds { get; set; }

                /// <summary>
                /// The init containers.
                /// </summary>
                [NameInMap("SecurityContextCapabilityAdds")]
                [Validation(Required=false)]
                public List<string> SecurityContextCapabilityAdds { get; set; }

                /// <summary>
                /// The image of the container.
                /// </summary>
                [NameInMap("SecurityContextReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? SecurityContextReadOnlyRootFilesystem { get; set; }

                /// <summary>
                /// The interval at which probes are performed. Default value: 10. Minimum value: 1. Unit: seconds.
                /// </summary>
                [NameInMap("SecurityContextRunAsUser")]
                [Validation(Required=false)]
                public long? SecurityContextRunAsUser { get; set; }

                /// <summary>
                /// The name of the container.
                /// </summary>
                [NameInMap("Stdin")]
                [Validation(Required=false)]
                public bool? Stdin { get; set; }

                /// <summary>
                /// The timeout period of a probe. Default value: 1. Minimum value: 1. Unit: seconds.
                /// </summary>
                [NameInMap("StdinOnce")]
                [Validation(Required=false)]
                public bool? StdinOnce { get; set; }

                /// <summary>
                /// The number of GPUs.
                /// </summary>
                [NameInMap("Tty")]
                [Validation(Required=false)]
                public bool? Tty { get; set; }

                /// <summary>
                /// Indicates whether the volume is read-only.
                /// 
                /// Default value: false.
                /// </summary>
                [NameInMap("VolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersVolumeMounts> VolumeMounts { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsContainersVolumeMounts : TeaModel {
                    /// <summary>
                    /// Details of the environment variables.
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// Details of the environment variables.
                    /// </summary>
                    [NameInMap("MountPropagation")]
                    [Validation(Required=false)]
                    public string MountPropagation { get; set; }

                    /// <summary>
                    /// The directory in which the container mounts the volume.
                    /// 
                    /// > Data in this directory is overwritten by the data on the volume.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The name of the volume. The value of this parameter is the same as the value of the Volumes.Name parameter.
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// The mount propagation setting of the volume. Mount propagation allows the sharing of volumes that are mounted on one container with other containers in the same pod, or even with other pods on the same node. Valid values:
                    /// 
                    /// *   None: The volume mount does not receive subsequent mounts that are mounted to this volume or its subdirectories.
                    /// *   HostToCotainer: The volume mount receives all subsequent mounts that are mounted to this volume or its subdirectories.
                    /// *   Bidirectional: This value is similar to HostToCotainer. The volume mount receives all subsequent mounts that are mounted to this volume or its subdirectories. In addition, all volume mounts that are created by the container are propagated back to the instance and to all containers of all pods that use the same volume.
                    /// 
                    /// Default value: None.
                    /// </summary>
                    [NameInMap("SubPath")]
                    [Validation(Required=false)]
                    public string SubPath { get; set; }

                }

                /// <summary>
                /// The port to which HTTP GET requests were sent.
                /// </summary>
                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

            /// <summary>
            /// auditing
            /// </summary>
            [NameInMap("CostOptimization")]
            [Validation(Required=false)]
            public bool? CostOptimization { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// The containers in the elastic container instance.
            /// </summary>
            [NameInMap("CpuOptionsCore")]
            [Validation(Required=false)]
            public int? CpuOptionsCore { get; set; }

            /// <summary>
            /// The weight of the elastic container instance as a backend server. Valid values: 1 to 100.
            /// </summary>
            [NameInMap("CpuOptionsThreadsPerCore")]
            [Validation(Required=false)]
            public int? CpuOptionsThreadsPerCore { get; set; }

            /// <summary>
            /// The ID of the security group with which the elastic container instance is associated. Elastic container instances that are associated with the same security group can access each other.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The ID of the image cache snapshot.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The DNS lookup domains.
            /// </summary>
            [NameInMap("DnsConfigNameServers")]
            [Validation(Required=false)]
            public List<string> DnsConfigNameServers { get; set; }

            /// <summary>
            /// The variable name of the option.
            /// </summary>
            [NameInMap("DnsConfigOptions")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsDnsConfigOptions> DnsConfigOptions { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsDnsConfigOptions : TeaModel {
                /// <summary>
                /// The hostname aliases of a container.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The hostname aliases of a container.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The domain names of the Network Time Protocol (NTP) servers.
            /// </summary>
            [NameInMap("DnsConfigSearches")]
            [Validation(Required=false)]
            public List<string> DnsConfigSearches { get; set; }

            /// <summary>
            /// The maximum outbound bandwidth. Unit: bytes.
            /// </summary>
            [NameInMap("DnsPolicy")]
            [Validation(Required=false)]
            public string DnsPolicy { get; set; }

            /// <summary>
            /// The name of the instance RAM role. You can use an instance RAM role to access both elastic container instances and Elastic Compute Service (ECS) instances. For more information, see [Use the instance RAM role by calling APIs](~~61178~~).
            /// </summary>
            [NameInMap("EgressBandwidth")]
            [Validation(Required=false)]
            public long? EgressBandwidth { get; set; }

            /// <summary>
            /// The size of the memory.
            /// 
            /// You can specify the number of vCPUs and the memory size to determine the range of instance types. For example, you can set the Cpu parameter to 2 and the Memory parameter to 16 to specify the instance types that have 2 vCPUs and 16 GiB of memory. If you specify the Cpu and Memory parameters, Auto Scaling determines available instance types based on factors such as I/O optimization requirements and zones. Then, Auto Scaling preferentially creates instances of the instance type that is provided at the lowest price.
            /// 
            /// > You can specify CPU and memory specifications to determine the range of instance types only if the Scaling Policy parameter is set to Cost Optimization Policy and no instance type is specified in the scaling configuration.
            /// </summary>
            [NameInMap("EipBandwidth")]
            [Validation(Required=false)]
            public int? EipBandwidth { get; set; }

            /// <summary>
            /// > This parameter is unavailable.
            /// </summary>
            [NameInMap("EphemeralStorage")]
            [Validation(Required=false)]
            public int? EphemeralStorage { get; set; }

            /// <summary>
            /// The IP address that is added.
            /// </summary>
            [NameInMap("HostAliases")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsHostAliases> HostAliases { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsHostAliases : TeaModel {
                /// <summary>
                /// The system information of the security context in which the elastic container instance runs.
                /// </summary>
                [NameInMap("Hostnames")]
                [Validation(Required=false)]
                public List<string> Hostnames { get; set; }

                /// <summary>
                /// The hostnames that are added.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// The region ID of the elastic container instance.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The password that is used to access the image repository.
            /// </summary>
            [NameInMap("ImageRegistryCredentials")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsImageRegistryCredentials> ImageRegistryCredentials { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsImageRegistryCredentials : TeaModel {
                /// <summary>
                /// The username that is used to access the image repository.
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// The options. Each option is a name-value pair. The value in the name-value pair is optional.
                /// </summary>
                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

                /// <summary>
                /// The options. Each option is a name-value pair. The value in the name-value pair is optional.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// The restart policy of the elastic container instance. Valid values:
            /// 
            /// *   Never: never restarts the elastic container instance.
            /// *   Always: always restarts the elastic container instance.
            /// *   OnFailure: restarts the elastic container instance upon failures.
            /// </summary>
            [NameInMap("ImageSnapshotId")]
            [Validation(Required=false)]
            public string ImageSnapshotId { get; set; }

            /// <summary>
            /// The buffer time in which the program handles operations before the program stops.
            /// </summary>
            [NameInMap("IngressBandwidth")]
            [Validation(Required=false)]
            public long? IngressBandwidth { get; set; }

            /// <summary>
            /// Indicates whether the root file system is read-only. The only valid value is true.
            /// </summary>
            [NameInMap("InitContainers")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainers> InitContainers { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainers : TeaModel {
                /// <summary>
                /// The number of GPUs that are allocated to the container.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// The size of the memory.
                /// </summary>
                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }

                /// <summary>
                /// The ID of the user that runs the container.
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// The number of vCPUs.
                /// </summary>
                [NameInMap("ImagePullPolicy")]
                [Validation(Required=false)]
                public string ImagePullPolicy { get; set; }

                /// <summary>
                /// The tags of the elastic container instance. The tags are specified in the key-value pair format.
                /// </summary>
                [NameInMap("InitContainerArgs")]
                [Validation(Required=false)]
                public List<string> InitContainerArgs { get; set; }

                /// <summary>
                /// The container startup arguments.
                /// </summary>
                [NameInMap("InitContainerCommands")]
                [Validation(Required=false)]
                public List<string> InitContainerCommands { get; set; }

                /// <summary>
                /// The name of the environment variable.
                /// </summary>
                [NameInMap("InitContainerEnvironmentVars")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerEnvironmentVars> InitContainerEnvironmentVars { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerEnvironmentVars : TeaModel {
                    /// <summary>
                    /// Details of the init container ports.
                    /// </summary>
                    [NameInMap("FieldRefFieldPath")]
                    [Validation(Required=false)]
                    public string FieldRefFieldPath { get; set; }

                    /// <summary>
                    /// > This parameter is unavailable.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// Details of the init container ports.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The port number. Valid values: 1 to 65535.
                /// </summary>
                [NameInMap("InitContainerPorts")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerPorts> InitContainerPorts { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerPorts : TeaModel {
                    /// <summary>
                    /// The volumes that are mounted on the container.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The volumes that are mounted on the container.
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// Indicates whether the mount path is read-only.
                /// 
                /// Default value: false.
                /// </summary>
                [NameInMap("InitContainerVolumeMounts")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerVolumeMounts> InitContainerVolumeMounts { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsInitContainersInitContainerVolumeMounts : TeaModel {
                    /// <summary>
                    /// The permissions that are granted to the processes in the container. Valid values: NET_ADMIN and NET_RAW.
                    /// 
                    /// > To use NET_RAW, you need to submit a ticket.
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// The permissions that are granted to the processes in the container. Valid values: NET_ADMIN and NET_RAW.
                    /// 
                    /// > To use NET_RAW, you need to submit a ticket.
                    /// </summary>
                    [NameInMap("MountPropagation")]
                    [Validation(Required=false)]
                    public string MountPropagation { get; set; }

                    /// <summary>
                    /// The directory to which the volume is mounted. Data under this directory is overwritten by the data on the volume.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The name of the volume.
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// The mount propagation setting of the volume. Mount propagation allows the sharing of volumes that are mounted on one container with other containers in the same pod, or even with other pods on the same node. Valid values:
                    /// 
                    /// *   None: The volume mount does not receive subsequent mounts that are mounted to this volume or its subdirectories.
                    /// *   HostToCotainer: The volume mount receives all subsequent mounts that are mounted to this volume or its subdirectories.
                    /// *   Bidirectional: This value is similar to HostToCotainer. The volume mount receives all subsequent mounts that are mounted to this volume or its subdirectories. In addition, all volume mounts that are created by the container are propagated back to the instance and to all containers of all pods that use the same volume.
                    /// 
                    /// Default value: None.
                    /// </summary>
                    [NameInMap("SubPath")]
                    [Validation(Required=false)]
                    public string SubPath { get; set; }

                }

                /// <summary>
                /// Details of the environment variables.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// Details of the environment variables.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The container startup commands.
                /// </summary>
                [NameInMap("SecurityContextCapabilityAdds")]
                [Validation(Required=false)]
                public List<string> SecurityContextCapabilityAdds { get; set; }

                /// <summary>
                /// The working directory.
                /// </summary>
                [NameInMap("SecurityContextReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? SecurityContextReadOnlyRootFilesystem { get; set; }

                /// <summary>
                /// The name of the container.
                /// </summary>
                [NameInMap("SecurityContextRunAsUser")]
                [Validation(Required=false)]
                public string SecurityContextRunAsUser { get; set; }

                /// <summary>
                /// The container image.
                /// </summary>
                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

            /// <summary>
            /// 5292
            /// </summary>
            [NameInMap("InstanceFamilyLevel")]
            [Validation(Required=false)]
            public string InstanceFamilyLevel { get; set; }

            /// <summary>
            /// The bandwidth of the EIP. Default value: 5 Mbit/s.
            /// </summary>
            [NameInMap("Ipv6AddressCount")]
            [Validation(Required=false)]
            public int? Ipv6AddressCount { get; set; }

            /// <summary>
            /// The instance family level, which is used to filter the range of instance types that meet the requirements. This parameter takes effect when the `CostOptimization` parameter is set to true. Valid values:
            /// 
            /// *   EntryLevel: shared instance type. Instances of this level are the most cost-effective but may not provide stable computing performance in a consistent manner. Instances of this level are suitable for business scenarios in which the CPU utilization is low. For more information, see [Shared instance families](~~108489~~).
            /// *   EnterpriseLevel: Instances of this level provide stable performance and dedicated resources, and are suitable for business scenarios that require high stability. For more information, see [Instance family](~~25378~~).
            /// *   CreditEntryLevel: This value is valid only for burstable instances. CPU credits are used to ensure computing performance. Instances of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For more information, see [Overview](~~59977~~) of burstable instances.
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// The hostname.
            /// </summary>
            [NameInMap("LoadBalancerWeight")]
            [Validation(Required=false)]
            public int? LoadBalancerWeight { get; set; }

            /// <summary>
            /// The maximum hourly price for the preemptible instance.
            /// 
            /// This parameter is returned only if you set the SpotStrategy parameter to SpotWithPriceLimit.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// The state of the scaling configuration in the scaling group. Valid values:
            /// 
            /// *   Active: The scaling configuration is active in the scaling group. Auto Scaling uses active scaling configurations to automatically create ECS instances.
            /// *   Inactive: The scaling configuration is inactive in the scaling group. Auto Scaling does not use inactive scaling configurations to automatically create ECS instances. Inactive scaling configurations are retained in the scaling group.
            /// </summary>
            [NameInMap("NtpServers")]
            [Validation(Required=false)]
            public List<string> NtpServers { get; set; }

            /// <summary>
            /// Indicates whether the image cache is automatically matched. Default value: false.
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// The number of vCPUs of the elastic container instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the scaling configuration.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The maximum inbound bandwidth. Unit: bit/s.
            /// </summary>
            [NameInMap("RestartPolicy")]
            [Validation(Required=false)]
            public string RestartPolicy { get; set; }

            /// <summary>
            /// > This parameter is unavailable.
            /// </summary>
            [NameInMap("ScalingConfigurationId")]
            [Validation(Required=false)]
            public string ScalingConfigurationId { get; set; }

            /// <summary>
            /// The validity period. Unit: seconds.
            /// </summary>
            [NameInMap("ScalingConfigurationName")]
            [Validation(Required=false)]
            public string ScalingConfigurationName { get; set; }

            /// <summary>
            /// The number of IPv6 addresses.
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// The name of the security context in which the elastic container instance runs.
            /// </summary>
            [NameInMap("SecurityContextSysCtls")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsSecurityContextSysCtls> SecurityContextSysCtls { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsSecurityContextSysCtls : TeaModel {
                /// <summary>
                /// Details of the Container Registry Enterprise Edition instances.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Details of the Container Registry Enterprise Edition instances.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The preemption policy of the instance. Valid values:
            /// 
            /// *   NoSpot: The instance is created as a regular pay-as-you-go instance.
            /// *   SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.
            /// *   SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The containers in the elastic container instance.
            /// </summary>
            [NameInMap("SlsEnable")]
            [Validation(Required=false)]
            public bool? SlsEnable { get; set; }

            /// <summary>
            /// The number of threads per core. This parameter can be specified for only some instance types. If you set this parameter to 1, Hyper-Threading is disabled. For more information, see [Specify custom CPU options](~~197781~~).
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

            /// <summary>
            /// The scaling group ID of the scaling configuration.
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsTags> Tags { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsTags : TeaModel {
                /// <summary>
                /// Details of the volumes.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// Details of the volumes.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The Domain Name System (DNS) policy.
            /// </summary>
            [NameInMap("TerminationGracePeriodSeconds")]
            [Validation(Required=false)]
            public int? TerminationGracePeriodSeconds { get; set; }

            /// <summary>
            /// The type of the volume. Valid values:
            /// 
            /// *   EmptyDirVolume
            /// *   NFSVolume
            /// *   ConfigFileVolume
            /// *   FlexVolume
            /// </summary>
            [NameInMap("Volumes")]
            [Validation(Required=false)]
            public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumes> Volumes { get; set; }
            public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumes : TeaModel {
                /// <summary>
                /// The relative path to the configuration file.
                /// </summary>
                [NameInMap("ConfigFileVolumeConfigFileToPaths")]
                [Validation(Required=false)]
                public List<DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumesConfigFileVolumeConfigFileToPaths> ConfigFileVolumeConfigFileToPaths { get; set; }
                public class DescribeEciScalingConfigurationsResponseBodyScalingConfigurationsVolumesConfigFileVolumeConfigFileToPaths : TeaModel {
                    /// <summary>
                    /// The information about the image repository.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The information about the image repository.
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public int? Mode { get; set; }

                    /// <summary>
                    /// The content of the configuration file (32 KB).
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// The FlexVolume options. Each option is a key-value pair in a JSON string.
                /// 
                /// For example, when you use FlexVolume to mount a disk, the format of options is `{"volumeId":"d-2zehdahrwoa7srg****","performanceLevel": "PL2"}`.
                /// </summary>
                [NameInMap("ConfigFileVolumeDefaultMode")]
                [Validation(Required=false)]
                public int? ConfigFileVolumeDefaultMode { get; set; }

                /// <summary>
                /// The storage medium of EmptyDirVolume. If this parameter is left empty, the file system that backs the node is used as the storage medium. If this parameter is set to memory, the memory is used as the storage medium.
                /// </summary>
                [NameInMap("DiskVolumeDiskId")]
                [Validation(Required=false)]
                public string DiskVolumeDiskId { get; set; }

                /// <summary>
                /// The file system type of the volume. The default value is determined by the script of FlexVolume.
                /// </summary>
                [NameInMap("DiskVolumeDiskSize")]
                [Validation(Required=false)]
                public int? DiskVolumeDiskSize { get; set; }

                /// <summary>
                /// The path to the Network File System (NFS) volume.
                /// </summary>
                [NameInMap("DiskVolumeFsType")]
                [Validation(Required=false)]
                public string DiskVolumeFsType { get; set; }

                /// <summary>
                /// The storage size of a disk volume. Unit: GiB.
                /// </summary>
                [NameInMap("EmptyDirVolumeMedium")]
                [Validation(Required=false)]
                public string EmptyDirVolumeMedium { get; set; }

                [NameInMap("EmptyDirVolumeSizeLimit")]
                [Validation(Required=false)]
                public string EmptyDirVolumeSizeLimit { get; set; }

                /// <summary>
                /// The endpoint of the NFS server.
                /// </summary>
                [NameInMap("FlexVolumeDriver")]
                [Validation(Required=false)]
                public string FlexVolumeDriver { get; set; }

                /// <summary>
                /// The FlexVolume driver name of the volume.
                /// </summary>
                [NameInMap("FlexVolumeFsType")]
                [Validation(Required=false)]
                public string FlexVolumeFsType { get; set; }

                /// <summary>
                /// The name of the volume.
                /// </summary>
                [NameInMap("FlexVolumeOptions")]
                [Validation(Required=false)]
                public string FlexVolumeOptions { get; set; }

                /// <summary>
                /// Indicates whether the NFS volume is read-only.
                /// 
                /// Default value: false.
                /// </summary>
                [NameInMap("NFSVolumePath")]
                [Validation(Required=false)]
                public string NFSVolumePath { get; set; }

                /// <summary>
                /// The default permissions on the ConfigFile volume.
                /// </summary>
                [NameInMap("NFSVolumeReadOnly")]
                [Validation(Required=false)]
                public bool? NFSVolumeReadOnly { get; set; }

                /// <summary>
                /// The paths to configuration files.
                /// </summary>
                [NameInMap("NFSVolumeServer")]
                [Validation(Required=false)]
                public string NFSVolumeServer { get; set; }

                /// <summary>
                /// The paths to configuration files.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The file system type of a disk volume.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// Details of the scaling configurations.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
