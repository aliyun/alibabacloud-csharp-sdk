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
                /// <para>The number of compute nodes in the cluster. Valid values: 0 to 99.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The instance type of the compute nodes.</para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/188592.html">ListPreferredEcsTypes</a> operation to query the recommended instance types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.n1.tiny</para>
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
                /// <para>The number of the logon nodes. Valid value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The instance type of the logon nodes.</para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/188592.html">ListPreferredEcsTypes</a> operation to query the recommended instance types.</para>
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
            public CreateClusterRequestEcsOrderManager Manager { get; set; }
            public class CreateClusterRequestEcsOrderManager : TeaModel {
                /// <summary>
                /// <para>The number of the management nodes. Valid values: 1 and 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The instance type of the management nodes.</para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/188592.html">ListPreferredEcsTypes</a> operation to query the recommended instance types.</para>
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
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>The custom component service.</para>
        /// </summary>
        [NameInMap("AddOns")]
        [Validation(Required=false)]
        public List<CreateClusterRequestAddOns> AddOns { get; set; }
        public class CreateClusterRequestAddOns : TeaModel {
            /// <summary>
            /// <para>The path to the configuration file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local/addon/cromwell/cromwell.conf</para>
            /// </summary>
            [NameInMap("ConfigFile")]
            [Validation(Required=false)]
            public string ConfigFile { get; set; }

            /// <summary>
            /// <para>The type of the database engine. Valid values: Mysql, and null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mysql</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>Indicates whether to auto-start the custom component. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DefaultStart")]
            [Validation(Required=false)]
            public bool? DefaultStart { get; set; }

            /// <summary>
            /// <para>The deployment mode. Valid values: local and ecs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>local</para>
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// <para>The component name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cromwell</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The access port of the custom component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public float? Port { get; set; }

            /// <summary>
            /// <para>The version number of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The information of the NAS file system.</para>
        /// </summary>
        [NameInMap("AdditionalVolumes")]
        [Validation(Required=false)]
        public List<CreateClusterRequestAdditionalVolumes> AdditionalVolumes { get; set; }
        public class CreateClusterRequestAdditionalVolumes : TeaModel {
            /// <summary>
            /// <para>The queue of the nodes to which the NAS file system is attached.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("JobQueue")]
            [Validation(Required=false)]
            public string JobQueue { get; set; }

            /// <summary>
            /// <para>The local directory on which the NAS file system is mounted.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/ff</para>
            /// </summary>
            [NameInMap("LocalDirectory")]
            [Validation(Required=false)]
            public string LocalDirectory { get; set; }

            /// <summary>
            /// <para>The type of the E-HPC cluster. Set the value to PublicCloud.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PublicCloud</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The remote directory to which the NAS file system is mounted.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test</para>
            /// </summary>
            [NameInMap("RemoteDirectory")]
            [Validation(Required=false)]
            public string RemoteDirectory { get; set; }

            /// <summary>
            /// <para>The node information to which the NAS file system is attached.</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<CreateClusterRequestAdditionalVolumesRoles> Roles { get; set; }
            public class CreateClusterRequestAdditionalVolumesRoles : TeaModel {
                /// <summary>
                /// <para>The type of the nodes to which the NAS file system is attached.</para>
                /// <para>Valid values of N in AdditionalVolumes.N.Roles: 1 to 10</para>
                /// <para>Valid values of N in Roles.N.Name: 0 to 8.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;Compute&quot;]</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The ID of the NAS file system.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>extreme-00b88****</para>
            /// </summary>
            [NameInMap("VolumeId")]
            [Validation(Required=false)]
            public string VolumeId { get; set; }

            /// <summary>
            /// <para>The mount options of the NAS file system.</para>
            /// <para>You can specify 1 to 10 vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-t nfs -o vers=4.0</para>
            /// </summary>
            [NameInMap("VolumeMountOption")]
            [Validation(Required=false)]
            public string VolumeMountOption { get; set; }

            /// <summary>
            /// <para>The mount target of the NAS file system.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0088****-sihc.cn-hangzhou.extreme.nas.aliyuncs.com</para>
            /// </summary>
            [NameInMap("VolumeMountpoint")]
            [Validation(Required=false)]
            public string VolumeMountpoint { get; set; }

            /// <summary>
            /// <para>The type of the protocol that is used by the NAS file system. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>NFS</description></item>
            /// <item><description>SMB</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 10.</para>
            /// <para>Default value: NFS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NFS</para>
            /// </summary>
            [NameInMap("VolumeProtocol")]
            [Validation(Required=false)]
            public string VolumeProtocol { get; set; }

            /// <summary>
            /// <para>The type of the additional shared storage. Only NAS file systems are supported.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nas</para>
            /// </summary>
            [NameInMap("VolumeType")]
            [Validation(Required=false)]
            public string VolumeType { get; set; }

        }

        /// <summary>
        /// <para>The application information.</para>
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public List<CreateClusterRequestApplication> Application { get; set; }
        public class CreateClusterRequestApplication : TeaModel {
            /// <summary>
            /// <para>The tag of the software.</para>
            /// <para>Valid values of N: 0 to 100.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87216.html">ListSoftwares</a> operation to query the tag of the software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenMPI_11.1</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period of the subscription compute nodes. The parameter takes effect when AutoRenew is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but make sure that the value is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The version of the E-HPC client. By default, the parameter is set to the latest version number.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87223.html">ListCurrentClientVersion</a> operation to query the latest version of the E-HPC client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.64</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>The version of the E-HPC cluster.</para>
        /// <para>Default value: 1.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("ClusterVersion")]
        [Validation(Required=false)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable hyper-threading for the compute node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ComputeEnableHt")]
        [Validation(Required=false)]
        public bool? ComputeEnableHt { get; set; }

        /// <summary>
        /// <para>The maximum hourly price of the compute nodes. A maximum of three decimal places can be used in the value of the parameter. The parameter is valid only when the ComputeSpotStrategy parameter is set to SpotWithPriceLimit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.034</para>
        /// </summary>
        [NameInMap("ComputeSpotPriceLimit")]
        [Validation(Required=false)]
        public string ComputeSpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The bidding method of the compute nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The compute nodes are pay-as-you-go instances.</description></item>
        /// <item><description>SpotWithPriceLimit: The compute nodes are preemptible instances that have a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.</description></item>
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
        /// <para>The mode in which the E-HPC cluster is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: An account node, a scheduling node, a logon node, and multiple compute nodes are separately deployed.</description></item>
        /// <item><description>Simple: A management node, which consists of an account node and a scheduling node, is deployed, while a logon node and multiple compute nodes are separately deployed.</description></item>
        /// <item><description>Tiny: A management node and multiple compute nodes are deployed. The management node consists of an account node, a scheduling node, and a logon node. The compute nodes are separately deployed.</description></item>
        /// </list>
        /// <para>Default value: Standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Simple</para>
        /// </summary>
        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        /// <summary>
        /// <para>The ID of the deployment set in which to deploy the instance. You can obtain the deployment set ID by calling the <a href="https://help.aliyun.com/document_detail/91313.html">DescribeDeploymentSets</a> operation. Only the deployment sets that use low latency policy are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-bp1frxuzdg87zh4pzq****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The description of the E-HPC cluster. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The domain name of the on-premises E-HPC cluster.</para>
        /// <para>This parameter takes effect only when the AccountType parameter is set to Idap.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ldap</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The billing method of the nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// <item><description>PrePaid: subscription.</description></item>
        /// </list>
        /// <para>If you set the parameter to PrePaid, auto-renewal is enabled by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("EcsChargeType")]
        [Validation(Required=false)]
        public string EcsChargeType { get; set; }

        /// <summary>
        /// <para>The version of E-HPC. By default, the parameter is set to the latest version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("EhpcVersion")]
        [Validation(Required=false)]
        public string EhpcVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the high availability feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>If high availability is enabled, a primary management node and a secondary management node are used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HaEnable")]
        [Validation(Required=false)]
        public bool? HaEnable { get; set; }

        /// <summary>
        /// <para>The image IDs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87213.html">ListImages</a> and <a href="https://help.aliyun.com/document_detail/87215.html">ListCustomImages</a> operations to query the images that are supported by E-HPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos_7_02_64_20G_alibase_20170818****</para>
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
        /// </list>
        /// <para>Default value: system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>self</para>
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// <para>The URL of the job file that is uploaded to an Object Storage Service (OSS) bucket.</para>
        /// </summary>
        [NameInMap("InputFileUrl")]
        [Validation(Required=false)]
        public string InputFileUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto scaling. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsComputeEss")]
        [Validation(Required=false)]
        public bool? IsComputeEss { get; set; }

        /// <summary>
        /// <para>The queue to which the compute nodes are added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workq</para>
        /// </summary>
        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/51793.html">Create an SSH key pair</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The name of the E-HPC cluster. The name must be 2 to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The communication model of the ENI. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: The TCP communication mode is used.</description></item>
        /// <item><description>HighPerformance: uses the remote direct memory access (RDMA) communication mode with the Elastic RDMA Interface (ERI) enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficMode")]
        [Validation(Required=false)]
        public string NetworkInterfaceTrafficMode { get; set; }

        /// <summary>
        /// <para>The operating system tag of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CentOS_7.2_64</para>
        /// </summary>
        [NameInMap("OsTag")]
        [Validation(Required=false)]
        public string OsTag { get; set; }

        /// <summary>
        /// <para>The root password of the logon node. The password must be 8 to 30 characters in length and contain at least three of the following items: uppercase letters, lowercase letters, digits, and special characters. Special characters include:</para>
        /// <para><c>( ) ~ ! @ # $ % ^ &amp; * - + = | { } [ ] : ; ‘ &lt; &gt; , . ? /</c></para>
        /// <para>You must specify either Password or KeyPairName. If both are specified, the Password parameter prevails.</para>
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
        /// <para>The duration of the subscription. The unit of the duration is specified by the <c>PeriodUnit</c> parameter.</para>
        /// <list type="bullet">
        /// <item><description>Valid values if PriceUnit is set to Year: 1, 2, and 3.</description></item>
        /// <item><description>Valid values if PriceUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, and 9.</description></item>
        /// <item><description>Valid value if PriceUnit is set to Hour: 1.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Year</description></item>
        /// <item><description>Month</description></item>
        /// <item><description>Hour</description></item>
        /// </list>
        /// <para>Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The mode configurations of the plug-in. This parameter takes effect only when the SchedulerType parameter is set to custom.</para>
        /// <para>The value must be a JSON string. The parameter contains the following parameters: pluginMod, pluginLocalPath, and pluginOssPath.</para>
        /// <list type="bullet">
        /// <item><description><para>pluginMod: the plug-in mode. The following modes are supported:</para>
        /// <list type="bullet">
        /// <item><description>oss: The plug-in is downloaded and decompressed from OSS to a local path that is specified by the pluginLocalPath parameter.</description></item>
        /// <item><description>image: By default, the plug-in is stored in a pre-defined local path that is specified by the pluginLocalPath parameter.</description></item>
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
        /// <para>The information of the post-installation script.</para>
        /// </summary>
        [NameInMap("PostInstallScript")]
        [Validation(Required=false)]
        public List<CreateClusterRequestPostInstallScript> PostInstallScript { get; set; }
        public class CreateClusterRequestPostInstallScript : TeaModel {
            /// <summary>
            /// <para>The parameter that is used to run the script after the cluster is created.</para>
            /// <para>Valid values of N: 0 to 16.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bashfile.sh</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <para>The URL that is used to download the script after the E-HPC cluster is created.</para>
            /// <para>Valid values of N: 0 to 16</para>
            /// 
            /// <b>Example:</b>
            /// <para>/opt/job.sh</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The node of the RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("RamNodeTypes")]
        [Validation(Required=false)]
        public List<string> RamNodeTypes { get; set; }

        /// <summary>
        /// <para>The name of the Resource Access Management (RAM) role.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> operation provided by RAM to query the instance RAM roles that you created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRamRoleName</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The remote directory to which the NAS file system is mounted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NasMountpoint:/RemoteDirectory</para>
        /// </summary>
        [NameInMap("RemoteDirectory")]
        [Validation(Required=false)]
        public string RemoteDirectory { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Virtual Network Computing (VNC). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RemoteVisEnable")]
        [Validation(Required=false)]
        public string RemoteVisEnable { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to obtain the ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The Super Computing Cluster (SCC) instance ID.</para>
        /// <para>If you specify the parameter, the SCC instance is moved to a new SCC cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00b648b****</para>
        /// </summary>
        [NameInMap("SccClusterId")]
        [Validation(Required=false)]
        public string SccClusterId { get; set; }

        /// <summary>
        /// <para>The type of the scheduler. Valid values:</para>
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

        /// <summary>
        /// <para>The ID of the security group to which the E-HPC cluster belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/25556.html">DescribeSecurityGroups</a> operation to query available security groups in the current region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp13n61xsydodfyg****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>If you do not use an existing security group, set the parameter to the name of a new security group. A default policy is applied to the new security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-SecurityGroup</para>
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// <para>The performance level of the ESSD to be used as the system disk. Default value: PL1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: An ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: An ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
        /// <item><description>PL2: An ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
        /// <item><description>PL3: An ESSD delivers up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// <para>Default value: PL1.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("SystemDiskLevel")]
        [Validation(Required=false)]
        public string SystemDiskLevel { get; set; }

        /// <summary>
        /// <para>The system disk size. Unit: GB.</para>
        /// <para>Valid values: 40 to 500.</para>
        /// <para>Default value: 40.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The type of the system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_efficiency: ultra disk</description></item>
        /// <item><description>cloud_ssd: standard SSD</description></item>
        /// <item><description>cloud_essd: enhanced SSD (ESSD)</description></item>
        /// <item><description>cloud: basic disk. Disks of this type are retired.</description></item>
        /// </list>
        /// <para>Default value: cloud_ssd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("SystemDiskType")]
        [Validation(Required=false)]
        public string SystemDiskType { get; set; }

        /// <summary>
        /// <para>The array of the tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTag> Tag { get; set; }
        public class CreateClusterRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch ID. E-HPC supports only VPC networks.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> operation to query available vSwitches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1lfcjbfb099rrjn****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the NAS file system. If you leave the parameter empty, a Performance NAS file system is created by default.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/204364.html">ListFileSystemWithMountTargets</a> operation to query available mount targets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>008b64****</para>
        /// </summary>
        [NameInMap("VolumeId")]
        [Validation(Required=false)]
        public string VolumeId { get; set; }

        /// <summary>
        /// <para>The mount options of the NFS file system that you want to mount by running the mount command.</para>
        /// <para>For more information, see <a href="https://www.alibabacloud.com/help/en/nas/latest/mount-an-nfs-file-system-on-a-linux-ecs-instance#section-jyi-hyd-hbr">Mount an NFS file system on a Linux ECS instance</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-t nfs -o vers=4</para>
        /// </summary>
        [NameInMap("VolumeMountOption")]
        [Validation(Required=false)]
        public string VolumeMountOption { get; set; }

        /// <summary>
        /// <para>The mount target of the NAS file system. The mount target is of the VPC type. Take note of the following information:</para>
        /// <list type="bullet">
        /// <item><description>If the VolumeId parameter is not specified, you can leave the VolumeMountpoint parameter empty. In this case, a mount target is created by default.</description></item>
        /// <item><description>When the VolumeId parameter is specified, the VolumeMountpoint parameter is required. You can call the <a href="https://help.aliyun.com/document_detail/204364.html">ListFileSystemWithMountTargets</a> operation to query available mount targets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>008b648bcb-s****.cn-hangzhou.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("VolumeMountpoint")]
        [Validation(Required=false)]
        public string VolumeMountpoint { get; set; }

        /// <summary>
        /// <para>The type of the protocol that is used by the NAS file system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NFS</description></item>
        /// <item><description>SMB</description></item>
        /// </list>
        /// <para>Default value: NFS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NFS</para>
        /// </summary>
        [NameInMap("VolumeProtocol")]
        [Validation(Required=false)]
        public string VolumeProtocol { get; set; }

        /// <summary>
        /// <para>The type of the shared storage. Set the value to <c>nas</c>, which indicates NAS file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nas</para>
        /// </summary>
        [NameInMap("VolumeType")]
        [Validation(Required=false)]
        public string VolumeType { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the E-HPC cluster belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> operation to query available VPCs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-b3f3edefefeep0760yju****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>Specifies whether not to install the agent.</para>
        /// <list type="bullet">
        /// <item><description>true: does not install the agent.</description></item>
        /// <item><description>false: installs the agent.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WithoutAgent")]
        [Validation(Required=false)]
        public bool? WithoutAgent { get; set; }

        /// <summary>
        /// <para>Specifies whether the logon node uses an elastic IP address (EIP). Default value: false.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithoutElasticIp")]
        [Validation(Required=false)]
        public bool? WithoutElasticIp { get; set; }

        /// <summary>
        /// <para>Indicates whether to use NAS as a shared storage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: does not use NAS.</description></item>
        /// <item><description>false: use NAS.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WithoutNas")]
        [Validation(Required=false)]
        public bool? WithoutNas { get; set; }

        /// <summary>
        /// <para>The ID of the zone in which the resource resides.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/188593.html">ListRegions</a> and <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> operations to query the IDs of the zones where E-HPC is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
