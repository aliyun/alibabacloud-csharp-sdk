// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class CreateHybridClusterRequest : TeaModel {
        [NameInMap("EcsOrder")]
        [Validation(Required=false)]
        public CreateHybridClusterRequestEcsOrder EcsOrder { get; set; }
        public class CreateHybridClusterRequestEcsOrder : TeaModel {
            [NameInMap("Compute")]
            [Validation(Required=false)]
            public CreateHybridClusterRequestEcsOrderCompute Compute { get; set; }
            public class CreateHybridClusterRequestEcsOrderCompute : TeaModel {
                /// <summary>
                /// The instance type of the compute nodes.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            [NameInMap("Manager")]
            [Validation(Required=false)]
            public CreateHybridClusterRequestEcsOrderManager Manager { get; set; }
            public class CreateHybridClusterRequestEcsOrderManager : TeaModel {
                /// <summary>
                /// The instance type of the management node. Only Proxy Mode is supported.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

        }

        /// <summary>
        /// An array that consists of the information about the software.
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public List<CreateHybridClusterRequestApplication> Application { get; set; }
        public class CreateHybridClusterRequestApplication : TeaModel {
            /// <summary>
            /// The tag of the software.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How do I ensure the idempotence of a request?](~~25693~~)
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The version of the client. By default, the latest version is used.
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// The maximum hourly price for the ECS instance under the compute node. A maximum of three decimal places can be used in the value of the parameter. The parameter is valid only when the ComputeSpotStrategy parameter is set to SpotWithPriceLimit.
        /// </summary>
        [NameInMap("ComputeSpotPriceLimit")]
        [Validation(Required=false)]
        public float? ComputeSpotPriceLimit { get; set; }

        /// <summary>
        /// The preemption policy of the compute nodes. Valid values:
        /// 
        /// *   NoSpot: The compute nodes are pay-as-you-go instances.
        /// *   SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.
        /// 
        /// Default value: NoSpot.
        /// </summary>
        [NameInMap("ComputeSpotStrategy")]
        [Validation(Required=false)]
        public string ComputeSpotStrategy { get; set; }

        /// <summary>
        /// The description of the E-HPC cluster. The description must be 2 to 256 characters in length and cannot start with `http://` or` https://`.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The type of the domain account service. Valid values:
        /// 
        /// *   nis
        /// *   ldap
        /// 
        /// Default value: nis.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The version of E-HPC. By default, the latest version is used.
        /// </summary>
        [NameInMap("EhpcVersion")]
        [Validation(Required=false)]
        public string EhpcVersion { get; set; }

        /// <summary>
        /// The mode in which the proxy node manages the offline nodes. Valid values:
        /// 
        /// *   SSH: indicates management via SSH logon.
        /// *   CA: indicates management through Cloud Assistant.
        /// </summary>
        [NameInMap("HybridClusterOpMode")]
        [Validation(Required=false)]
        public string HybridClusterOpMode { get; set; }

        /// <summary>
        /// The IDs of the images.
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
        /// *   marketplace: Alibaba Cloud Marketplace image
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// The default queue of the scale-out nodes.
        /// </summary>
        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        /// <summary>
        /// The name of the key pair. The name must be 2 to 128 characters in length, and can contain letters, digits, colons (:), underscores (\_), and hyphens (-). It must start with a letter and cannot start with http:// or https://.[](http://https://。、（:）、（\_）（-）。)
        /// 
        /// > To use an SSH key pair, see [Create an SSH key pair](~~51793~~).
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// The location where the cluster resides. Set the value to OnPremise.
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// Specifies whether the cluster supports multiple operating systems. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("MultiOs")]
        [Validation(Required=false)]
        public bool? MultiOs { get; set; }

        /// <summary>
        /// The name of the cluster. The name must be 2 to 64 characters in length, and can contain only letters, digits, hyphens (-), and underscores (\_). It must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The information about the nodes in the local cluster.
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<CreateHybridClusterRequestNodes> Nodes { get; set; }
        public class CreateHybridClusterRequestNodes : TeaModel {
            /// <summary>
            /// The service type of the domain account to which the on-premises node in the cluster belongs. Valid values:
            /// 
            /// *   nis
            /// *   ldap
            /// 
            /// Default value: nis.
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// The directory of the on-premises node in the cluster.
            /// </summary>
            [NameInMap("Dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }

            /// <summary>
            /// The hostname of the on-premises node in the cluster.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The IP address of the on-premises node in the cluster.
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// The role of the on-premises node in the cluster. Valid values:
            /// 
            /// *   Manager: management node
            /// *   Login: logon node
            /// *   Compute: compute node
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// The scheduler type of the on-premises node in the cluster. Valid values:
            /// 
            /// *   pbs
            /// *   slurm
            /// *   opengridscheduler
            /// *   deadline
            /// 
            /// Default value: pbs.
            /// </summary>
            [NameInMap("SchedulerType")]
            [Validation(Required=false)]
            public string SchedulerType { get; set; }

        }

        /// <summary>
        /// The path in which the on-premises file system is mounted on the nodes on the cloud.
        /// </summary>
        [NameInMap("OnPremiseVolumeLocalPath")]
        [Validation(Required=false)]
        public string OnPremiseVolumeLocalPath { get; set; }

        /// <summary>
        /// The mount target of the on-premises file system.
        /// </summary>
        [NameInMap("OnPremiseVolumeMountPoint")]
        [Validation(Required=false)]
        public string OnPremiseVolumeMountPoint { get; set; }

        /// <summary>
        /// The type of the protocol that is used by the on-premises file system. Only NFS is supported.
        /// </summary>
        [NameInMap("OnPremiseVolumeProtocol")]
        [Validation(Required=false)]
        public string OnPremiseVolumeProtocol { get; set; }

        /// <summary>
        /// The mount path of the on-premises file system.
        /// </summary>
        [NameInMap("OnPremiseVolumeRemotePath")]
        [Validation(Required=false)]
        public string OnPremiseVolumeRemotePath { get; set; }

        /// <summary>
        /// The parameter that is used to connect to the OpenLDAP server.
        /// </summary>
        [NameInMap("OpenldapPar")]
        [Validation(Required=false)]
        public CreateHybridClusterRequestOpenldapPar OpenldapPar { get; set; }
        public class CreateHybridClusterRequestOpenldapPar : TeaModel {
            /// <summary>
            /// The BaseDN of the LDAP server.
            /// </summary>
            [NameInMap("BaseDn")]
            [Validation(Required=false)]
            public string BaseDn { get; set; }

            /// <summary>
            /// The home directory of the Linux server.
            /// </summary>
            [NameInMap("FallbackHomeDir")]
            [Validation(Required=false)]
            public string FallbackHomeDir { get; set; }

            /// <summary>
            /// The IP address of the LDAP server.
            /// </summary>
            [NameInMap("LdapServerIp")]
            [Validation(Required=false)]
            public string LdapServerIp { get; set; }

        }

        /// <summary>
        /// The image tag of the operating system. You can call the [ListImages](~~87213~~) operation to query the image tag.
        /// </summary>
        [NameInMap("OsTag")]
        [Validation(Required=false)]
        public string OsTag { get; set; }

        /// <summary>
        /// The root password of the logon node. The password must be 8 to 30 characters in length and contain at least three of the following items: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported: `() ~ ! @ # $ % ^ & * - = + | { } [ ] : ; ‘ < > , . ? /`
        /// 
        /// > We recommend that you use HTTPS to call the API operation to prevent password leakage.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

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

        /// <summary>
        /// The list of post-installation script information.
        /// </summary>
        [NameInMap("PostInstallScript")]
        [Validation(Required=false)]
        public List<CreateHybridClusterRequestPostInstallScript> PostInstallScript { get; set; }
        public class CreateHybridClusterRequestPostInstallScript : TeaModel {
            /// <summary>
            /// The parameter that is used to run the script after the cluster is created.
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// The full path of the post-installation script.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The remote directory to which the file system is mounted.
        /// </summary>
        [NameInMap("RemoteDirectory")]
        [Validation(Required=false)]
        public string RemoteDirectory { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Specifies whether the scheduler is preinstalled for the image. Valid values:
        /// 
        /// *   true: The scheduler is preinstalled. When you create or add a node, you do not need to install the scheduler.
        /// *   false: The scheduler is not preinstalled. When you create or add a cluster, you must install the scheduler.
        /// </summary>
        [NameInMap("SchedulerPreInstall")]
        [Validation(Required=false)]
        public bool? SchedulerPreInstall { get; set; }

        /// <summary>
        /// You can select an existing security group by its ID.
        /// 
        /// > If you specify this parameter, you cannot specify the `SecurityGroupName`  parameter.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// If you do not use an existing security group, set the parameter to the name of a new security group. A default policy is applied to the new security group.
        /// 
        /// > If you specify this parameter, you cannot specify the `SecurityGroupId` parameter.
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which the instance connects to.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the file system. NAS file systems cannot be automatically created.
        /// </summary>
        [NameInMap("VolumeId")]
        [Validation(Required=false)]
        public string VolumeId { get; set; }

        /// <summary>
        /// The mount target of the NAS file system. The mount target is of the VPC type. Mount targets cannot be automatically created for NAS file systems.
        /// </summary>
        [NameInMap("VolumeMountpoint")]
        [Validation(Required=false)]
        public string VolumeMountpoint { get; set; }

        /// <summary>
        /// The type of the protocol that is used by the NAS file system. Only NFS is supported.
        /// </summary>
        [NameInMap("VolumeProtocol")]
        [Validation(Required=false)]
        public string VolumeProtocol { get; set; }

        /// <summary>
        /// The type of the file system. Only NAS file systems are supported.
        /// </summary>
        [NameInMap("VolumeType")]
        [Validation(Required=false)]
        public string VolumeType { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the E-HPC cluster belongs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The parameter that is used to connect to the Windows AD server.
        /// </summary>
        [NameInMap("WinAdPar")]
        [Validation(Required=false)]
        public CreateHybridClusterRequestWinAdPar WinAdPar { get; set; }
        public class CreateHybridClusterRequestWinAdPar : TeaModel {
            /// <summary>
            /// The name of the AD domain.
            /// </summary>
            [NameInMap("AdDc")]
            [Validation(Required=false)]
            public string AdDc { get; set; }

            /// <summary>
            /// The IP address of the AD domain.
            /// </summary>
            [NameInMap("AdIp")]
            [Validation(Required=false)]
            public string AdIp { get; set; }

            /// <summary>
            /// The AD user.
            /// </summary>
            [NameInMap("AdUser")]
            [Validation(Required=false)]
            public string AdUser { get; set; }

            /// <summary>
            /// The password of the AD user.
            /// </summary>
            [NameInMap("AdUserPasswd")]
            [Validation(Required=false)]
            public string AdUserPasswd { get; set; }

        }

        /// <summary>
        /// The ID of the zone.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
