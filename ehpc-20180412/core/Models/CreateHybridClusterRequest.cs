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
                /// <para>The instance type of the compute nodes.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.n1.tiny</para>
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
                /// <para>The instance type of the management node. Only Proxy Mode is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.n1.tiny</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

        }

        /// <summary>
        /// <para>An array that consists of the information about the software.</para>
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public List<CreateHybridClusterRequestApplication> Application { get; set; }
        public class CreateHybridClusterRequestApplication : TeaModel {
            /// <summary>
            /// <para>The tag of the software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenMPI_11.1</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How do I ensure the idempotence of a request?</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The version of the client. By default, the latest version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.64</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>The maximum hourly price for the ECS instance under the compute node. A maximum of three decimal places can be used in the value of the parameter. The parameter is valid only when the ComputeSpotStrategy parameter is set to SpotWithPriceLimit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.034</para>
        /// </summary>
        [NameInMap("ComputeSpotPriceLimit")]
        [Validation(Required=false)]
        public float? ComputeSpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The preemption policy of the compute nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The compute nodes are pay-as-you-go instances.</description></item>
        /// <item><description>SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("ComputeSpotStrategy")]
        [Validation(Required=false)]
        public string ComputeSpotStrategy { get; set; }

        /// <summary>
        /// <para>The description of the E-HPC cluster. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or<c> https://</c>.</para>
        /// <para>This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The type of the domain account service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>nis</description></item>
        /// <item><description>ldap</description></item>
        /// </list>
        /// <para>Default value: nis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nis</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The version of E-HPC. By default, the latest version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("EhpcVersion")]
        [Validation(Required=false)]
        public string EhpcVersion { get; set; }

        /// <summary>
        /// <para>The mode in which the proxy node manages the offline nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SSH: indicates management via SSH logon.</description></item>
        /// <item><description>CA: indicates management through Cloud Assistant.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SSH</para>
        /// </summary>
        [NameInMap("HybridClusterOpMode")]
        [Validation(Required=false)]
        public string HybridClusterOpMode { get; set; }

        /// <summary>
        /// <para>The IDs of the images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wi_1607_x64_dtc_zh_40G_alibase****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The type of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: public image</description></item>
        /// <item><description>self: custom image</description></item>
        /// <item><description>others: shared image</description></item>
        /// <item><description>marketplace: Alibaba Cloud Marketplace image</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// <para>The default queue of the scale-out nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workq</para>
        /// </summary>
        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        /// <summary>
        /// <para>The name of the key pair. The name must be 2 to 128 characters in length, and can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with http:// or https://.<a href="http://https://%E3%80%82%E3%80%81%EF%BC%88:%EF%BC%89%E3%80%81%EF%BC%88_%EF%BC%89%EF%BC%88-%EF%BC%89%E3%80%82"></a></para>
        /// <remarks>
        /// <para>To use an SSH key pair, see <a href="https://help.aliyun.com/document_detail/51793.html">Create an SSH key pair</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The location where the cluster resides. Set the value to OnPremise.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OnPremise</para>
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>Specifies whether the cluster supports multiple operating systems. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MultiOs")]
        [Validation(Required=false)]
        public bool? MultiOs { get; set; }

        /// <summary>
        /// <para>The name of the cluster. The name must be 2 to 64 characters in length, and can contain only letters, digits, hyphens (-), and underscores (_). It must start with a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hybridcluster</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The information about the nodes in the local cluster.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<CreateHybridClusterRequestNodes> Nodes { get; set; }
        public class CreateHybridClusterRequestNodes : TeaModel {
            /// <summary>
            /// <para>The service type of the domain account to which the on-premises node in the cluster belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>nis</description></item>
            /// <item><description>ldap</description></item>
            /// </list>
            /// <para>Default value: nis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nis</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The directory of the on-premises node in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/opt/sge/default/</para>
            /// </summary>
            [NameInMap("Dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }

            /// <summary>
            /// <para>The hostname of the on-premises node in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The IP address of the on-premises node in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00b648b****</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// <para>The role of the on-premises node in the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Manager: management node</description></item>
            /// <item><description>Login: logon node</description></item>
            /// <item><description>Compute: compute node</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Compute</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The scheduler type of the on-premises node in the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pbs</description></item>
            /// <item><description>slurm</description></item>
            /// <item><description>opengridscheduler</description></item>
            /// <item><description>deadline</description></item>
            /// </list>
            /// <para>Default value: pbs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pbs</para>
            /// </summary>
            [NameInMap("SchedulerType")]
            [Validation(Required=false)]
            public string SchedulerType { get; set; }

        }

        /// <summary>
        /// <para>The path in which the on-premises file system is mounted on the nodes on the cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/OnCloudDirectory</para>
        /// </summary>
        [NameInMap("OnPremiseVolumeLocalPath")]
        [Validation(Required=false)]
        public string OnPremiseVolumeLocalPath { get; set; }

        /// <summary>
        /// <para>The mount target of the on-premises file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RemoteNasDomain.com</para>
        /// </summary>
        [NameInMap("OnPremiseVolumeMountPoint")]
        [Validation(Required=false)]
        public string OnPremiseVolumeMountPoint { get; set; }

        /// <summary>
        /// <para>The type of the protocol that is used by the on-premises file system. Only NFS is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NFS</para>
        /// </summary>
        [NameInMap("OnPremiseVolumeProtocol")]
        [Validation(Required=false)]
        public string OnPremiseVolumeProtocol { get; set; }

        /// <summary>
        /// <para>The mount path of the on-premises file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/RemoteDirectory</para>
        /// </summary>
        [NameInMap("OnPremiseVolumeRemotePath")]
        [Validation(Required=false)]
        public string OnPremiseVolumeRemotePath { get; set; }

        /// <summary>
        /// <para>The parameter that is used to connect to the OpenLDAP server.</para>
        /// </summary>
        [NameInMap("OpenldapPar")]
        [Validation(Required=false)]
        public CreateHybridClusterRequestOpenldapPar OpenldapPar { get; set; }
        public class CreateHybridClusterRequestOpenldapPar : TeaModel {
            /// <summary>
            /// <para>The BaseDN of the LDAP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ehpctest</para>
            /// </summary>
            [NameInMap("BaseDn")]
            [Validation(Required=false)]
            public string BaseDn { get; set; }

            /// <summary>
            /// <para>The home directory of the Linux server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home</para>
            /// </summary>
            [NameInMap("FallbackHomeDir")]
            [Validation(Required=false)]
            public string FallbackHomeDir { get; set; }

            /// <summary>
            /// <para>The IP address of the LDAP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.2</para>
            /// </summary>
            [NameInMap("LdapServerIp")]
            [Validation(Required=false)]
            public string LdapServerIp { get; set; }

        }

        /// <summary>
        /// <para>The image tag of the operating system. You can call the <a href="https://help.aliyun.com/document_detail/87213.html">ListImages</a> operation to query the image tag.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CentOS_7.2_64</para>
        /// </summary>
        [NameInMap("OsTag")]
        [Validation(Required=false)]
        public string OsTag { get; set; }

        /// <summary>
        /// <para>The root password of the logon node. The password must be 8 to 30 characters in length and contain at least three of the following items: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported: <c>() ~ ! @ # $ % ^ &amp; * - = + | { } [ ] : ; ‘ &lt; &gt; , . ? /</c></para>
        /// <remarks>
        /// <para>We recommend that you use HTTPS to call the API operation to prevent password leakage.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The mode configurations of the plug-in. This parameter takes effect only when the SchedulerType parameter is set to custom.</para>
        /// <para>The value must be a JSON string. The parameter contains the following parameters: pluginMod, pluginLocalPath, and pluginOssPath.</para>
        /// <list type="bullet">
        /// <item><description><para>pluginMod: the mode of the plug-in. The following modes are supported:</para>
        /// <list type="bullet">
        /// <item><description>oss: The plug-in is downloaded and decompressed from OSS to a local path. The local path is specified by the pluginLocalPath parameter.</description></item>
        /// <item><description>image: By default, the plug-in is stored in a pre-defined local path. The local path is specified by the pluginLocalPath parameter.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>pluginLocalPath: the local path where the plug-in is stored. We recommend that you select a shared directory in oss mode and a non-shared directory in image mode.</para>
        /// </description></item>
        /// <item><description><para>pluginOssPath: the remote path where the plug-in is stored in OSS. This parameter takes effect only when the pluginMod parameter is set to oss.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;pluginMod&quot;: &quot;oss&quot;,&quot;pluginLocalPath&quot;: &quot;/opt/plugin&quot;,&quot;pluginOssPath&quot;: &quot;<a href="https://bucket.oss-cn-hangzhou.aliyuncs.com/plugin/plugin.tgz%22%7D">https://bucket.oss-cn-hangzhou.aliyuncs.com/plugin/plugin.tgz&quot;}</a></para>
        /// </summary>
        [NameInMap("Plugin")]
        [Validation(Required=false)]
        public string Plugin { get; set; }

        /// <summary>
        /// <para>The list of post-installation script information.</para>
        /// </summary>
        [NameInMap("PostInstallScript")]
        [Validation(Required=false)]
        public List<CreateHybridClusterRequestPostInstallScript> PostInstallScript { get; set; }
        public class CreateHybridClusterRequestPostInstallScript : TeaModel {
            /// <summary>
            /// <para>The parameter that is used to run the script after the cluster is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bash file.sh</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <para>The full path of the post-installation script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/opt/job.sh</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The remote directory to which the file system is mounted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/RemoteDirectory</para>
        /// </summary>
        [NameInMap("RemoteDirectory")]
        [Validation(Required=false)]
        public string RemoteDirectory { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether the scheduler is preinstalled for the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The scheduler is preinstalled. When you create or add a node, you do not need to install the scheduler.</description></item>
        /// <item><description>false: The scheduler is not preinstalled. When you create or add a cluster, you must install the scheduler.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SchedulerPreInstall")]
        [Validation(Required=false)]
        public bool? SchedulerPreInstall { get; set; }

        /// <summary>
        /// <para>You can select an existing security group by its ID.</para>
        /// <remarks>
        /// <para>If you specify this parameter, you cannot specify the <c>SecurityGroupName</c>  parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp13n61xsydodfyg****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>If you do not use an existing security group, set the parameter to the name of a new security group. A default policy is applied to the new security group.</para>
        /// <remarks>
        /// <para>If you specify this parameter, you cannot specify the <c>SecurityGroupId</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-SecurityGroup</para>
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the instance connects to.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1lfcjbfb099rrjn****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the file system. NAS file systems cannot be automatically created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>008b64****</para>
        /// </summary>
        [NameInMap("VolumeId")]
        [Validation(Required=false)]
        public string VolumeId { get; set; }

        /// <summary>
        /// <para>The mount target of the NAS file system. The mount target is of the VPC type. Mount targets cannot be automatically created for NAS file systems.</para>
        /// 
        /// <b>Example:</b>
        /// <para>008b648bcb-s****.cn-hangzhou.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("VolumeMountpoint")]
        [Validation(Required=false)]
        public string VolumeMountpoint { get; set; }

        /// <summary>
        /// <para>The type of the protocol that is used by the NAS file system. Only NFS is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NFS</para>
        /// </summary>
        [NameInMap("VolumeProtocol")]
        [Validation(Required=false)]
        public string VolumeProtocol { get; set; }

        /// <summary>
        /// <para>The type of the file system. Only NAS file systems are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NAS</para>
        /// </summary>
        [NameInMap("VolumeType")]
        [Validation(Required=false)]
        public string VolumeType { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the E-HPC cluster belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-b3f3edefefeep0760yju****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The parameter that is used to connect to the Windows AD server.</para>
        /// </summary>
        [NameInMap("WinAdPar")]
        [Validation(Required=false)]
        public CreateHybridClusterRequestWinAdPar WinAdPar { get; set; }
        public class CreateHybridClusterRequestWinAdPar : TeaModel {
            /// <summary>
            /// <para>The name of the AD domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ad-hybrid001.ehpcad.com</para>
            /// </summary>
            [NameInMap("AdDc")]
            [Validation(Required=false)]
            public string AdDc { get; set; }

            /// <summary>
            /// <para>The IP address of the AD domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.2</para>
            /// </summary>
            [NameInMap("AdIp")]
            [Validation(Required=false)]
            public string AdIp { get; set; }

            /// <summary>
            /// <para>The AD user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Administrator</para>
            /// </summary>
            [NameInMap("AdUser")]
            [Validation(Required=false)]
            public string AdUser { get; set; }

            /// <summary>
            /// <para>The password of the AD user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("AdUserPasswd")]
            [Validation(Required=false)]
            public string AdUserPasswd { get; set; }

        }

        /// <summary>
        /// <para>The ID of the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
