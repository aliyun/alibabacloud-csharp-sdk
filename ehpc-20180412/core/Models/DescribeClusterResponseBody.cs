// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeClusterResponseBody : TeaModel {
        /// <summary>
        /// The cluster information.
        /// </summary>
        [NameInMap("ClusterInfo")]
        [Validation(Required=false)]
        public DescribeClusterResponseBodyClusterInfo ClusterInfo { get; set; }
        public class DescribeClusterResponseBodyClusterInfo : TeaModel {
            /// <summary>
            /// The server type of the account. Valid values:
            /// 
            /// *   nis
            /// *   ldap
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// The information about the custom component service.
            /// </summary>
            [NameInMap("AddOnsInfo")]
            [Validation(Required=false)]
            public DescribeClusterResponseBodyClusterInfoAddOnsInfo AddOnsInfo { get; set; }
            public class DescribeClusterResponseBodyClusterInfoAddOnsInfo : TeaModel {
                [NameInMap("AddOnsInfo")]
                [Validation(Required=false)]
                public List<DescribeClusterResponseBodyClusterInfoAddOnsInfoAddOnsInfo> AddOnsInfo { get; set; }
                public class DescribeClusterResponseBodyClusterInfoAddOnsInfoAddOnsInfo : TeaModel {
                    /// <summary>
                    /// The deployment mode of the custom component. Valid values:
                    /// 
                    /// *   local
                    /// *   ecs
                    /// </summary>
                    [NameInMap("DeployMode")]
                    [Validation(Required=false)]
                    public string DeployMode { get; set; }

                    /// <summary>
                    /// The TCP port number of the custom component.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The software ID of the component.
                    /// </summary>
                    [NameInMap("SoftwareId")]
                    [Validation(Required=false)]
                    public string SoftwareId { get; set; }

                    /// <summary>
                    /// The running status of the custom component. Valid values:
                    /// 
                    /// *   running
                    /// *   stopped
                    /// *   exception
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The endpoint of the custom component service.
                    /// </summary>
                    [NameInMap("URL")]
                    [Validation(Required=false)]
                    public string URL { get; set; }

                }

            }

            /// <summary>
            /// The array of the software in the cluster. The array contains the name and version of the software.
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public DescribeClusterResponseBodyClusterInfoApplications Applications { get; set; }
            public class DescribeClusterResponseBodyClusterInfoApplications : TeaModel {
                [NameInMap("ApplicationInfo")]
                [Validation(Required=false)]
                public List<DescribeClusterResponseBodyClusterInfoApplicationsApplicationInfo> ApplicationInfo { get; set; }
                public class DescribeClusterResponseBodyClusterInfoApplicationsApplicationInfo : TeaModel {
                    /// <summary>
                    /// The name of the software.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The tag of the software.
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// The version of the software.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// Specifies whether to enable auto-renewal. The parameter takes effect only when EcsChargeType is set to PrePaid. Valid values:
            /// 
            /// *   true: enables auto-renewal.
            /// *   false: disables auto-renewal.
            /// 
            /// Default value: true.
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public string AutoRenew { get; set; }

            /// <summary>
            /// The auto-renewal period of the subscription compute nodes. The parameter takes effect when AutoRenew is set to true.
            /// 
            /// *   If PeriodUnit is set to Week, the valid values of the AutoRenewPeriod parameter are 1, 2, and 3.
            /// *   If PeriodUnit is set to Month, the valid values of the AutoRenewPeriod parameter are 1, 2, 3, 6, and 12.
            /// 
            /// Default value: 1.
            /// </summary>
            [NameInMap("AutoRenewPeriod")]
            [Validation(Required=false)]
            public string AutoRenewPeriod { get; set; }

            /// <summary>
            /// The image of the cluster.
            /// </summary>
            [NameInMap("BaseOsTag")]
            [Validation(Required=false)]
            public string BaseOsTag { get; set; }

            /// <summary>
            /// The version of the E-HPC client.
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// The version of the E-HPC cluster.
            /// </summary>
            [NameInMap("ClusterVersion")]
            [Validation(Required=false)]
            public string ClusterVersion { get; set; }

            /// <summary>
            /// The maximum hourly price of the compute nodes. A maximum of three decimal places can be used in the value of the parameter. The parameter is valid only when the ComputeSpotStrategy parameter is set to SpotWithPriceLimit.
            /// </summary>
            [NameInMap("ComputeSpotPriceLimit")]
            [Validation(Required=false)]
            public string ComputeSpotPriceLimit { get; set; }

            /// <summary>
            /// The bidding method of the compute node. Valid values:
            /// 
            /// *   NoSpot: The instance is created as a pay-as-you-go instance.
            /// *   SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.
            /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.
            /// </summary>
            [NameInMap("ComputeSpotStrategy")]
            [Validation(Required=false)]
            public string ComputeSpotStrategy { get; set; }

            /// <summary>
            /// The time at which the instance is created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The mode in which the cluster is deployed. Valid values:
            /// 
            /// *   Standard: An account node, a scheduling node, a logon node, and multiple compute nodes are separately deployed.
            /// *   Advanced: Two high availability (HA) account nodes, two HA scheduler nodes, one logon node, and multiple compute nodes are separately deployed.
            /// *   Simple: A management node, a logon node, and multiple compute nodes are deployed. The management node consists of an account node and a scheduling node. The logon node and compute nodes are separately deployed.
            /// *   Tiny: The account node, scheduling node, and logon node are deployed on one node. The compute node is separately deployed.
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// The description of the cluster.
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
            /// The billing method of the nodes in the cluster. Valid values:
            /// 
            /// *   PostPaid: pay-as-you-go
            /// *   PrePaid: subscription
            /// </summary>
            [NameInMap("EcsChargeType")]
            [Validation(Required=false)]
            public string EcsChargeType { get; set; }

            /// <summary>
            /// The list of ECS instance specifications and quantity.
            /// </summary>
            [NameInMap("EcsInfo")]
            [Validation(Required=false)]
            public DescribeClusterResponseBodyClusterInfoEcsInfo EcsInfo { get; set; }
            public class DescribeClusterResponseBodyClusterInfoEcsInfo : TeaModel {
                /// <summary>
                /// The list of compute nodes.
                /// </summary>
                [NameInMap("Compute")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoCompute Compute { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoCompute : TeaModel {
                    /// <summary>
                    /// The number of compute nodes in the cluster.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// The instance type of the compute nodes.
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

                /// <summary>
                /// The list of logon nodes.
                /// </summary>
                [NameInMap("Login")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoLogin Login { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoLogin : TeaModel {
                    /// <summary>
                    /// The number of logon nodes in the cluster.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// The instance type of the logon nodes.
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

                /// <summary>
                /// The information of management nodes.
                /// </summary>
                [NameInMap("Manager")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoManager Manager { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoManager : TeaModel {
                    /// <summary>
                    /// The number of management nodes.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// The instance type of the management nodes.
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

                /// <summary>
                /// The list of proxy nodes on the cloud.
                /// 
                /// This parameter is returned only when the cluster is deployed across hybrid environments and the hybrid-cloud proxy mode is enabled for the cluster.
                /// </summary>
                [NameInMap("ProxyMgr")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoProxyMgr ProxyMgr { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoProxyMgr : TeaModel {
                    /// <summary>
                    /// The number of proxy nodes.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// The instance type of the proxy node.
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

            }

            /// <summary>
            /// Specifies whether to enable the high availability feature.
            /// 
            /// >  If high availability is enabled, each management role in the cluster uses both primary and secondary instances.
            /// </summary>
            [NameInMap("HaEnable")]
            [Validation(Required=false)]
            public bool? HaEnable { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The image ID.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The image name.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// The image type. Valid values:
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
            /// The image information of the operating systems.
            /// </summary>
            [NameInMap("InitialImage")]
            [Validation(Required=false)]
            public DescribeClusterResponseBodyClusterInfoInitialImage InitialImage { get; set; }
            public class DescribeClusterResponseBodyClusterInfoInitialImage : TeaModel {
                /// <summary>
                /// The image ID.
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
                /// An array of OS images that are supported by E-HPC.
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

            }

            /// <summary>
            /// The name of the AccessKey pair.
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// The location where the cluster is deployed. Valid values:
            /// 
            /// *   OnPremise: The node is deployed on a hybrid cloud.
            /// *   PublicCloud: The cluster is deployed on a public cloud.
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The information of the on-premises node in the cluster.
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public DescribeClusterResponseBodyClusterInfoNodes Nodes { get; set; }
            public class DescribeClusterResponseBodyClusterInfoNodes : TeaModel {
                [NameInMap("NodesInfo")]
                [Validation(Required=false)]
                public List<DescribeClusterResponseBodyClusterInfoNodesNodesInfo> NodesInfo { get; set; }
                public class DescribeClusterResponseBodyClusterInfoNodesNodesInfo : TeaModel {
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

            }

            /// <summary>
            /// The list of on-premises management nodes.
            /// 
            /// This parameter is returned only when the cluster is deployed across hybrid environments and the hybrid-cloud proxy mode is enabled for the cluster.
            /// </summary>
            [NameInMap("OnPremiseInfo")]
            [Validation(Required=false)]
            public DescribeClusterResponseBodyClusterInfoOnPremiseInfo OnPremiseInfo { get; set; }
            public class DescribeClusterResponseBodyClusterInfoOnPremiseInfo : TeaModel {
                [NameInMap("OnPremiseInfo")]
                [Validation(Required=false)]
                public List<DescribeClusterResponseBodyClusterInfoOnPremiseInfoOnPremiseInfo> OnPremiseInfo { get; set; }
                public class DescribeClusterResponseBodyClusterInfoOnPremiseInfoOnPremiseInfo : TeaModel {
                    /// <summary>
                    /// The hostname of the on-premises management nodes.
                    /// </summary>
                    [NameInMap("HostName")]
                    [Validation(Required=false)]
                    public string HostName { get; set; }

                    /// <summary>
                    /// The IP address of the on-premises management nodes.
                    /// </summary>
                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    /// <summary>
                    /// The type of on-premises management nodes. Valid values:
                    /// 
                    /// *   scheduler
                    /// *   account
                    /// *   account, scheduler
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// The parameter that is used to connect to the OpenLDAP server.
            /// </summary>
            [NameInMap("OpenldapPar")]
            [Validation(Required=false)]
            public string OpenldapPar { get; set; }

            /// <summary>
            /// The operating system tag of the image.
            /// </summary>
            [NameInMap("OsTag")]
            [Validation(Required=false)]
            public string OsTag { get; set; }

            /// <summary>
            /// The duration of the subscription. The unit of the duration is specified by the `PeriodUnit` parameter.
            /// 
            /// *   If you set PriceUnit to Year, the valid values of the Period parameter are 1, 2, and 3.
            /// *   If you set PriceUnit to Month, the valid values of the Period parameter are 1, 2, 3, 4, 5, 6, 7, 8, and 9.
            /// *   If you set PriceUnit to Hour, the valid value of the Period parameter is 1.
            /// 
            /// Default value: 1.
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// The unit of the subscription duration. Valid value:
            /// 
            /// *   Year
            /// *   Month
            /// *   Hour
            /// 
            /// Default value: Month.
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
            ///     *   oss: The plug-in is downloaded and decompressed from OSS to a local path that is specified by the pluginLocalPath parameter.
            ///     *   image: By default, the plug-in is stored in a pre-defined local path that is specified by the pluginLocalPath parameter.
            /// 
            /// *   pluginLocalPath: the local path where the plug-in is stored. We recommend that you select a shared directory in the oss mode and a non-shared directory in the image mode.
            /// 
            /// *   pluginOssPath: the remote path where the plug-in is stored in OSS. This parameter takes effect only if you set the pluginMod parameter to oss.
            /// </summary>
            [NameInMap("Plugin")]
            [Validation(Required=false)]
            public string Plugin { get; set; }

            /// <summary>
            /// The list of post-installation scripts
            /// </summary>
            [NameInMap("PostInstallScripts")]
            [Validation(Required=false)]
            public DescribeClusterResponseBodyClusterInfoPostInstallScripts PostInstallScripts { get; set; }
            public class DescribeClusterResponseBodyClusterInfoPostInstallScripts : TeaModel {
                [NameInMap("PostInstallScriptInfo")]
                [Validation(Required=false)]
                public List<DescribeClusterResponseBodyClusterInfoPostInstallScriptsPostInstallScriptInfo> PostInstallScriptInfo { get; set; }
                public class DescribeClusterResponseBodyClusterInfoPostInstallScriptsPostInstallScriptInfo : TeaModel {
                    /// <summary>
                    /// The runtime parameters of the script.
                    /// </summary>
                    [NameInMap("Args")]
                    [Validation(Required=false)]
                    public string Args { get; set; }

                    /// <summary>
                    /// The URL used to download the script.
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// The node type details of the instance RAM role.
            /// </summary>
            [NameInMap("RamNodeTypes")]
            [Validation(Required=false)]
            public string RamNodeTypes { get; set; }

            /// <summary>
            /// The name of the instance Resource Access Management (RAM) role.
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The remote directory on which the file system is mounted.
            /// </summary>
            [NameInMap("RemoteDirectory")]
            [Validation(Required=false)]
            public string RemoteDirectory { get; set; }

            /// <summary>
            /// The resource group ID.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The ID of the Super Computing Cluster (SCC) instance. If the cluster is not an SCC instance, a null string is returned.
            /// </summary>
            [NameInMap("SccClusterId")]
            [Validation(Required=false)]
            public string SccClusterId { get; set; }

            /// <summary>
            /// Specifies whether the scheduler is preinstalled for the image. Valid values:
            /// 
            /// *   true: The scheduler is preinstalled. When you create a node or scale out a cluster, you do not need to install the scheduler.
            /// *   false: The scheduler is not preinstalled. When you create or add a cluster, you must install the scheduler.
            /// </summary>
            [NameInMap("SchedulerPreInstall")]
            [Validation(Required=false)]
            public int? SchedulerPreInstall { get; set; }

            /// <summary>
            /// The type of the scheduler. Valid values:
            /// 
            /// *   pbs
            /// *   slurm
            /// *   opengridscheduler
            /// *   deadline
            /// </summary>
            [NameInMap("SchedulerType")]
            [Validation(Required=false)]
            public string SchedulerType { get; set; }

            /// <summary>
            /// The ID of the security group.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The status of the cluster. Valid values:
            /// 
            /// *   uninit: The cluster is not initialized.
            /// *   creating: The cluster is being created.
            /// *   init: The cluster is being initialized.
            /// *   running: The cluster is running.
            /// *   exception: The cluster encounters an exception.
            /// *   releasing: The cluster is being released.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The vSwitch ID. E-HPC can be deployed only in VPCs.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the Apsara File Storage NAS file system. NAS file systems cannot be automatically created.
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
            /// The type of the protocol that is used by the file system. Valid values:
            /// 
            /// *   nfs
            /// *   smb
            /// </summary>
            [NameInMap("VolumeProtocol")]
            [Validation(Required=false)]
            public string VolumeProtocol { get; set; }

            /// <summary>
            /// The type of the network shared storage. Valid value: NAS.
            /// </summary>
            [NameInMap("VolumeType")]
            [Validation(Required=false)]
            public string VolumeType { get; set; }

            /// <summary>
            /// The VPC ID of the node.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The parameter that is used to connect to the Windows AD server.
            /// </summary>
            [NameInMap("WinAdPar")]
            [Validation(Required=false)]
            public string WinAdPar { get; set; }

            /// <summary>
            /// Specifies whether to not install the agent.
            /// </summary>
            [NameInMap("WithoutAgent")]
            [Validation(Required=false)]
            public int? WithoutAgent { get; set; }

            /// <summary>
            /// The zone ID.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
