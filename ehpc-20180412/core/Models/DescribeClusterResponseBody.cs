// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeClusterResponseBody : TeaModel {
        /// <summary>
        /// The information about the cluster.
        /// </summary>
        [NameInMap("ClusterInfo")]
        [Validation(Required=false)]
        public DescribeClusterResponseBodyClusterInfo ClusterInfo { get; set; }
        public class DescribeClusterResponseBodyClusterInfo : TeaModel {
            /// <summary>
            /// The service type of the domain account. Valid values:
            /// 
            /// *   nis
            /// *   ldap
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

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
            /// The time when the cluster was created.
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
            /// *   Tiny: A management node and multiple compute nodes are deployed. The management node consists of an account node, a scheduling node, and a logon node. The compute nodes are separately deployed.
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
                    /// The number of compute nodes.
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
                    /// The number of logon nodes.
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
                /// The list of management nodes.
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
            /// Indicates whether the high availability feature is enabled.
            /// 
            /// >  If high availability is enabled, a primary management node and a secondary management node are used.
            /// </summary>
            [NameInMap("HaEnable")]
            [Validation(Required=false)]
            public bool? HaEnable { get; set; }

            /// <summary>
            /// The ID of the Elastic Compute Service (ECS) instance.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The ID of the image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The name of the image.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

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
            /// The name of the AccessKey pair.
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// The location where the cluster is deployed. Valid values:
            /// 
            /// *   OnPremise: The cluster is deployed on a hybrid cloud.
            /// *   PublicCloud: The node is deployed on a public cloud.
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
                    /// - scheduler
                    /// - account
                    /// - account, scheduler
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// The image tag of the operating system.
            /// </summary>
            [NameInMap("OsTag")]
            [Validation(Required=false)]
            public string OsTag { get; set; }

            /// <summary>
            /// The list of scripts downloaded after the cluster was created.
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
                    /// The runtime parameter of the script.
                    /// </summary>
                    [NameInMap("Args")]
                    [Validation(Required=false)]
                    public string Args { get; set; }

                    /// <summary>
                    /// The URL that was used to download the script.
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            [NameInMap("RamNodeTypes")]
            [Validation(Required=false)]
            public string RamNodeTypes { get; set; }

            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// The region ID of the security group.
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
            /// The ID of the Super Computing Cluster (SCC) instance. If the cluster is not an SCC instance, a null string is returned.
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
            /// The ID of the vSwitch. E-HPC can be deployed only in VPCs.
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
            /// The mount target of the file system. Mount targets cannot be automatically created for NAS file systems.
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
            /// The ID of the VPC.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
