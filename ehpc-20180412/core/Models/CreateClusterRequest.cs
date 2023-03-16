// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class CreateClusterRequest : TeaModel {
        [NameInMap("EcsOrder")]
        [Validation(Required=false)]
        public CreateClusterRequestEcsOrder EcsOrder { get; set; }
        public class CreateClusterRequestEcsOrder : TeaModel {
            [NameInMap("Compute")]
            [Validation(Required=false)]
            public CreateClusterRequestEcsOrderCompute Compute { get; set; }
            public class CreateClusterRequestEcsOrderCompute : TeaModel {
                /// <summary>
                /// The number of the compute nodes. Valid values: 1 to 99.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The instance type of the compute nodes.
                /// 
                /// You can call the [ListPreferredEcsTypes](~~188592~~) operation to query the recommended instance types.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            [NameInMap("Login")]
            [Validation(Required=false)]
            public CreateClusterRequestEcsOrderLogin Login { get; set; }
            public class CreateClusterRequestEcsOrderLogin : TeaModel {
                /// <summary>
                /// The number of the logon nodes. Valid value: 1.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The instance type of the logon nodes.
                /// 
                /// You can call the [ListPreferredEcsTypes](~~188592~~) operation to query the recommended instance types.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            [NameInMap("Manager")]
            [Validation(Required=false)]
            public CreateClusterRequestEcsOrderManager Manager { get; set; }
            public class CreateClusterRequestEcsOrderManager : TeaModel {
                /// <summary>
                /// The number of the management nodes. Valid values: 1 and 2.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The instance type of the management nodes.
                /// 
                /// You can call the [ListPreferredEcsTypes](~~188592~~) operation to query the recommended instance types.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

        }

        /// <summary>
        /// The type of the domain account service. Valid values:
        /// 
        /// *   nis
        /// *   ldap
        /// 
        /// Default value: nis
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("AdditionalVolumes")]
        [Validation(Required=false)]
        public List<CreateClusterRequestAdditionalVolumes> AdditionalVolumes { get; set; }
        public class CreateClusterRequestAdditionalVolumes : TeaModel {
            /// <summary>
            /// The queue of the nodes to which the additional file system is attached.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("JobQueue")]
            [Validation(Required=false)]
            public string JobQueue { get; set; }

            /// <summary>
            /// The local directory on which the additional file system is mounted.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("LocalDirectory")]
            [Validation(Required=false)]
            public string LocalDirectory { get; set; }

            /// <summary>
            /// The type of the E-HPC cluster. Set the value to PublicCloud.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// The remote directory on which the additional file system is mounted.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("RemoteDirectory")]
            [Validation(Required=false)]
            public string RemoteDirectory { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<CreateClusterRequestAdditionalVolumesRoles> Roles { get; set; }
            public class CreateClusterRequestAdditionalVolumesRoles : TeaModel {
                /// <summary>
                /// The type of the nodes to which the additional file system is attached.
                /// 
                /// Valid values of N in AdditionalVolumes.N.Roles: 1 to 10
                /// 
                /// Valid values of N in Roles.N.Name: 0 to 8
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The ID of the additional file system.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("VolumeId")]
            [Validation(Required=false)]
            public string VolumeId { get; set; }

            /// <summary>
            /// The mount options of the additional file system.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("VolumeMountOption")]
            [Validation(Required=false)]
            public string VolumeMountOption { get; set; }

            /// <summary>
            /// The mount target of the additional file system.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("VolumeMountpoint")]
            [Validation(Required=false)]
            public string VolumeMountpoint { get; set; }

            /// <summary>
            /// The type of the protocol that is used by the additional file system. Valid values:
            /// 
            /// *   NFS
            /// *   SMB
            /// 
            /// Valid values of N: 1 to 10
            /// 
            /// Default value: NFS
            /// </summary>
            [NameInMap("VolumeProtocol")]
            [Validation(Required=false)]
            public string VolumeProtocol { get; set; }

            /// <summary>
            /// The type of the additional shared storage. Only NAS file systems are supported.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("VolumeType")]
            [Validation(Required=false)]
            public string VolumeType { get; set; }

        }

        [NameInMap("Application")]
        [Validation(Required=false)]
        public List<CreateClusterRequestApplication> Application { get; set; }
        public class CreateClusterRequestApplication : TeaModel {
            /// <summary>
            /// The tag of the software.
            /// 
            /// Valid values of N: 0 to 100
            /// 
            /// You can call the [ListSoftwares](~~87216~~) operation to query the tag of the software.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the subscription. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal period of the subscription compute nodes. The parameter takes effect when AutoRenew is set to true.
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see [How do I ensure the idempotence of a request?](~~25693~~)
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The version of the E-HPC client. By default, the parameter is set to the latest version number.
        /// 
        /// You can call the [ListCurrentClientVersion](~~87223~~) operation to query the latest version of the E-HPC client.
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// The version of the E-HPC cluster.
        /// 
        /// Default value: 1.0
        /// </summary>
        [NameInMap("ClusterVersion")]
        [Validation(Required=false)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// Specifies whether the compute nodes support hyper-threading. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: true
        /// </summary>
        [NameInMap("ComputeEnableHt")]
        [Validation(Required=false)]
        public bool? ComputeEnableHt { get; set; }

        /// <summary>
        /// The maximum hourly price of the compute nodes. A maximum of three decimal places can be used in the value of the parameter. The parameter is valid only when the ComputeSpotStrategy parameter is set to SpotWithPriceLimit.
        /// </summary>
        [NameInMap("ComputeSpotPriceLimit")]
        [Validation(Required=false)]
        public string ComputeSpotPriceLimit { get; set; }

        /// <summary>
        /// The bidding method of the compute nodes. Valid values:
        /// 
        /// *   NoSpot: The compute nodes are pay-as-you-go instances.
        /// *   SpotWithPriceLimit: The compute nodes are preemptible instances that have a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.
        /// 
        /// Default value: NoSpot
        /// </summary>
        [NameInMap("ComputeSpotStrategy")]
        [Validation(Required=false)]
        public string ComputeSpotStrategy { get; set; }

        /// <summary>
        /// The mode in which the E-HPC cluster is deployed. Valid values:
        /// 
        /// *   Standard: An account node, a scheduling node, a logon node, and multiple compute nodes are separately deployed.
        /// *   Simple: A management node, a logon node, and multiple compute nodes are deployed. The management node consists of an account node and a scheduling node. The logon node and compute nodes are separately deployed.
        /// *   Tiny: A management node and multiple compute nodes are deployed. The management node consists of an account node, a scheduling node, and a logon node. The compute nodes are separately deployed.
        /// 
        /// Default value: Standard
        /// </summary>
        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        /// <summary>
        /// The description of the E-HPC cluster. The description must be 2 to 256 characters in length. It cannot start with http:// or https://.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The domain name of the on-premises E-HPC cluster.
        /// 
        /// This parameter takes effect only when the AccoutType parameter is set to Idap.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The billing method of the nodes. Valid values:
        /// 
        /// *   PostPaid: pay-as-you-go
        /// *   PrePaid: subscription
        /// 
        /// If you set the parameter to PrePaid, auto-renewal is enabled by default.
        /// </summary>
        [NameInMap("EcsChargeType")]
        [Validation(Required=false)]
        public string EcsChargeType { get; set; }

        /// <summary>
        /// The version of E-HPC. By default, the parameter is set to the latest version number.
        /// </summary>
        [NameInMap("EhpcVersion")]
        [Validation(Required=false)]
        public string EhpcVersion { get; set; }

        /// <summary>
        /// Specifies whether to enable the high availability feature. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false
        /// 
        /// >  If high availability is enabled, a primary management node and a secondary management node are used.
        /// </summary>
        [NameInMap("HaEnable")]
        [Validation(Required=false)]
        public bool? HaEnable { get; set; }

        /// <summary>
        /// The ID of the image.
        /// 
        /// You can call the [ListImages](~~87213~~) and [ListCustomImages](~~87215~~) operations to query the images that are supported by E-HPC.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The type of the image. Valid values:
        /// 
        /// *   system: public image
        /// *   self: custom image
        /// *   others: shared image
        /// 
        /// Default value: system
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// The URL of the job files that are uploaded to an Object Storage Service (OSS) bucket.
        /// </summary>
        [NameInMap("InputFileUrl")]
        [Validation(Required=false)]
        public string InputFileUrl { get; set; }

        /// <summary>
        /// Specifies whether to enable auto scaling. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("IsComputeEss")]
        [Validation(Required=false)]
        public bool? IsComputeEss { get; set; }

        /// <summary>
        /// The queue to which the compute nodes are added.
        /// </summary>
        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        /// <summary>
        /// The name of the AccessKey pair.
        /// 
        /// >  For more information, see [Create an SSH key pair](~~51793~~).
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// The name of the E-HPC cluster. The name must be 2 to 64 characters in length.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NetworkInterfaceTrafficMode")]
        [Validation(Required=false)]
        public string NetworkInterfaceTrafficMode { get; set; }

        /// <summary>
        /// The operating system tag of the image.
        /// </summary>
        [NameInMap("OsTag")]
        [Validation(Required=false)]
        public string OsTag { get; set; }

        /// <summary>
        /// The root password of the logon node. The password must be 8 to 30 characters in length and contain at least three of the following items: uppercase letters, lowercase letters, digits, and special characters. The password can contain the following special characters:
        /// 
        /// `( ) ~ ! @ # $ % ^ & * - + = | { } [ ] : ; ‘ < > , . ? /`
        /// 
        /// You must specify either Password or KeyPairName. If both are specified, the Password parameter prevails.
        /// 
        /// >  We recommend that you use HTTPS to call the API operation to prevent password leakages.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The duration of the subscription. The unit of the duration is specified by the `PeriodUnit` parameter.
        /// 
        /// *   If you set PriceUnit to Year, the valid values of the Period parameter are 1, 2, and 3.
        /// *   If you set PriceUnit to Month, the valid values of the Period parameter are 1, 2, 3, 4, 5, 6, 7, 8, and 9.
        /// *   If you set PriceUnit to Hour, the valid value of the Period parameter is 1.
        /// 
        /// Default value: 1
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the subscription duration. Valid values:
        /// 
        /// *   Year
        /// *   Month
        /// *   Hour
        /// 
        /// Default value: Month
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The mode configurations of the plug-in. This parameter takes effect only when the SchedulerType parameter is set to custom.
        /// 
        /// The value must be a JSON string. The parameter contains the following parameters: pluginMod, pluginLocalPath, and pluginOssPath.
        /// 
        /// *   pluginMod: the mode of the plug-in. The following modes are supported:
        /// 
        ///     *   oss: The plug-in is downloaded and decompressed from OSS to a local path. The local path is specified by the pluginLocalPath parameter.
        ///     *   image: By default, the plug-in is stored in a pre-defined local path. The local path is specified by the pluginLocalPath parameter.
        /// 
        /// *   pluginLocalPath: the local path where the plug-in is stored. We recommend that you select a shared directory in oss mode and a non-shared directory in image mode.
        /// 
        /// *   pluginOssPath: the remote path where the plug-in is stored in OSS. This parameter takes effect only when the pluginMod parameter is set to oss.
        /// </summary>
        [NameInMap("Plugin")]
        [Validation(Required=false)]
        public string Plugin { get; set; }

        [NameInMap("PostInstallScript")]
        [Validation(Required=false)]
        public List<CreateClusterRequestPostInstallScript> PostInstallScript { get; set; }
        public class CreateClusterRequestPostInstallScript : TeaModel {
            /// <summary>
            /// The parameter that is used to run the script after the E-HPC cluster is created.
            /// 
            /// Valid values of N: 0 to 16
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// The URL that is used to download the script after the E-HPC cluster is created.
            /// 
            /// Valid values of N: 0 to 16
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("RamNodeTypes")]
        [Validation(Required=false)]
        public List<string> RamNodeTypes { get; set; }

        /// <summary>
        /// The name of the Resource Access Management (RAM) role.
        /// 
        /// You can call the [ListRoles](~~28713~~) operation provided by RAM to query the created RAM roles.
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The remote directory on which the file system is mounted.
        /// </summary>
        [NameInMap("RemoteDirectory")]
        [Validation(Required=false)]
        public string RemoteDirectory { get; set; }

        /// <summary>
        /// Specifies whether to enable Virtual Network Computing (VNC). Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("RemoteVisEnable")]
        [Validation(Required=false)]
        public string RemoteVisEnable { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// 
        /// You can call the [ListResourceGroups](~~158855~~) operation to obtain the ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the Super Computing Cluster (SCC) instance.
        /// 
        /// If you specify the parameter, the SCC instance is moved to a new SCC cluster.
        /// </summary>
        [NameInMap("SccClusterId")]
        [Validation(Required=false)]
        public string SccClusterId { get; set; }

        /// <summary>
        /// The type of the scheduler. Valid values:
        /// 
        /// *   pbs
        /// *   slurm
        /// *   opengridscheduler
        /// *   deadline
        /// 
        /// Default value: pbs
        /// </summary>
        [NameInMap("SchedulerType")]
        [Validation(Required=false)]
        public string SchedulerType { get; set; }

        /// <summary>
        /// The ID of the security group to which the E-HPC cluster belongs.
        /// 
        /// You can call the [DescribeSecurityGroups](~~25556~~) operation to query available security groups in the current region.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// If you do not use an existing security group, set the parameter to the name of a new security group. A default policy is applied to the new security group.
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// The performance level of the ESSD that is used as the system disk. Valid values:
        /// 
        /// *   PL0: An ESSD can deliver up to 10,000 random read/write IOPS.
        /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
        /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
        /// *   PL3: An ESSD delivers up to 1,000,000 random read/write IOPS.
        /// 
        /// Default value: PL1
        /// 
        /// For more information, see [ESSDs](~~122389~~).
        /// </summary>
        [NameInMap("SystemDiskLevel")]
        [Validation(Required=false)]
        public string SystemDiskLevel { get; set; }

        /// <summary>
        /// The size of the system disk. Unit: GB.
        /// 
        /// Valid values: 40 to 500
        /// 
        /// Default value: 40
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// The type of the system disk. Valid values:
        /// 
        /// *   cloud_efficiency: ultra disk.
        /// *   cloud_ssd: standard SSD.
        /// *   cloud_essd: enhanced SSD (ESSD).
        /// *   cloud: basic disk. Disks of this type are retired.
        /// 
        /// Default value: cloud_ssd
        /// </summary>
        [NameInMap("SystemDiskType")]
        [Validation(Required=false)]
        public string SystemDiskType { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTag> Tag { get; set; }
        public class CreateClusterRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the vSwitch. E-HPC supports only VPC networks.
        /// 
        /// You can call the [DescribeVSwitches](~~35748~~) operation to query available vSwitches.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the file system. If you leave the parameter empty, a Performance NAS file system is created by default.
        /// 
        /// You can call the [ListFileSystemWithMountTargets](~~204364~~) operation to query available mount targets.
        /// </summary>
        [NameInMap("VolumeId")]
        [Validation(Required=false)]
        public string VolumeId { get; set; }

        /// <summary>
        /// The mount options of the NFS file system that you want to mount by running the mount command.
        /// 
        /// For more information, see [Mount an NFS file system on a Linux ECS instance](https://www.alibabacloud.com/help/en/nas/latest/mount-an-nfs-file-system-on-a-linux-ecs-instance#section-jyi-hyd-hbr).
        /// </summary>
        [NameInMap("VolumeMountOption")]
        [Validation(Required=false)]
        public string VolumeMountOption { get; set; }

        /// <summary>
        /// The mount target of the file system. Take note of the following information:
        /// 
        /// *   If you do not specify the VolumeId parameter, you can leave the VolumeMountpoint parameter empty. A mount target is created by default.
        /// *   If you specify the VolumeId parameter, the VolumeMountpoint parameter is required. You can call the [ListFileSystemWithMountTargets](~~204364~~) operation to query available mount targets.
        /// </summary>
        [NameInMap("VolumeMountpoint")]
        [Validation(Required=false)]
        public string VolumeMountpoint { get; set; }

        /// <summary>
        /// The type of the protocol that is used by the file system. Valid values:
        /// 
        /// *   NFS
        /// *   SMB
        /// 
        /// Default value: NFS
        /// </summary>
        [NameInMap("VolumeProtocol")]
        [Validation(Required=false)]
        public string VolumeProtocol { get; set; }

        /// <summary>
        /// The type of the shared storage. Set the value to `nas`, which indicates a NAS file system.
        /// </summary>
        [NameInMap("VolumeType")]
        [Validation(Required=false)]
        public string VolumeType { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the E-HPC cluster belongs.
        /// 
        /// You can call the [DescribeVpcs](~~35739~~) operation to query available VPCs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// Specifies whether not to install the agent.
        /// 
        /// *   true: The agent is not installed.
        /// *   false: The agent is installed.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("WithoutAgent")]
        [Validation(Required=false)]
        public bool? WithoutAgent { get; set; }

        /// <summary>
        /// Specifies whether the logon node uses an elastic IP address (EIP). Default value: false
        /// </summary>
        [NameInMap("WithoutElasticIp")]
        [Validation(Required=false)]
        public bool? WithoutElasticIp { get; set; }

        /// <summary>
        /// The ID of the zone.
        /// 
        /// You can call the [ListRegions](~~188593~~) and [DescribeZones](~~25610~~) operations to query IDs of the zones where E-HPC is supported.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
