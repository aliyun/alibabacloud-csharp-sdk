// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the cluster.</para>
        /// </summary>
        [NameInMap("ClusterInfo")]
        [Validation(Required=false)]
        public DescribeClusterResponseBodyClusterInfo ClusterInfo { get; set; }
        public class DescribeClusterResponseBodyClusterInfo : TeaModel {
            /// <summary>
            /// <para>The server type of the account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>nis</description></item>
            /// <item><description>ldap</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>nis</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The information about the custom component service.</para>
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
                    /// <para>The deployment mode of the custom component. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>local</description></item>
                    /// <item><description>ecs</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>local</para>
                    /// </summary>
                    [NameInMap("DeployMode")]
                    [Validation(Required=false)]
                    public string DeployMode { get; set; }

                    /// <summary>
                    /// <para>The TCP port number of the custom component.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The software ID of the component.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CROMWELL_85</para>
                    /// </summary>
                    [NameInMap("SoftwareId")]
                    [Validation(Required=false)]
                    public string SoftwareId { get; set; }

                    /// <summary>
                    /// <para>The running status of the custom component. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>running</description></item>
                    /// <item><description>stopped</description></item>
                    /// <item><description>exception</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>running</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The URL of the custom component service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://172.16.10.12:10000/">http://172.16.10.12:10000/</a></para>
                    /// </summary>
                    [NameInMap("URL")]
                    [Validation(Required=false)]
                    public string URL { get; set; }

                }

            }

            /// <summary>
            /// <para>The array of the software in the cluster. The array contains the name and version of the software.</para>
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
                    /// <para>The name of the software.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>openmpi</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The tag of the software.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OpenMPI_1.8.7</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The version of the software.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.10</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// <para>Specifies whether to enable auto-renewal. The parameter takes effect only when EcsChargeType is set to PrePaid. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables auto-renewal.</description></item>
            /// <item><description>false: disables auto-renewal.</description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public string AutoRenew { get; set; }

            /// <summary>
            /// <para>The auto-renewal period of the subscription compute nodes. The parameter takes effect when AutoRenew is set to true.</para>
            /// <list type="bullet">
            /// <item><description>If PeriodUnit is set to Week, the valid values of the AutoRenewPeriod parameter are 1, 2, and 3.</description></item>
            /// <item><description>If PeriodUnit is set to Month, the valid values of the AutoRenewPeriod parameter are 1, 2, 3, 6, and 12.</description></item>
            /// </list>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoRenewPeriod")]
            [Validation(Required=false)]
            public string AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The image of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS_7.2_64</para>
            /// </summary>
            [NameInMap("BaseOsTag")]
            [Validation(Required=false)]
            public string BaseOsTag { get; set; }

            /// <summary>
            /// <para>The version of the E-HPC client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.1</para>
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// <para>The version of the E-HPC cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("ClusterVersion")]
            [Validation(Required=false)]
            public string ClusterVersion { get; set; }

            /// <summary>
            /// <para>The maximum hourly price of the compute nodes. A maximum of three decimal places can be used in the value of the parameter. The parameter is valid only when the ComputeSpotStrategy parameter is set to SpotWithPriceLimit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.56</para>
            /// </summary>
            [NameInMap("ComputeSpotPriceLimit")]
            [Validation(Required=false)]
            public string ComputeSpotPriceLimit { get; set; }

            /// <summary>
            /// <para>The bidding method of the compute node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoSpot: The instance is created as a pay-as-you-go instance.</description></item>
            /// <item><description>SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.</description></item>
            /// <item><description>SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("ComputeSpotStrategy")]
            [Validation(Required=false)]
            public string ComputeSpotStrategy { get; set; }

            /// <summary>
            /// <para>The time at which the instance is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-24T03:18:23.000Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The mode in which the cluster is deployed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: An account node, a scheduling node, a logon node, and multiple compute nodes are separately deployed.</description></item>
            /// <item><description>Advanced: Two high availability (HA) account nodes, two HA scheduler nodes, one logon node, and multiple compute nodes are separately deployed.</description></item>
            /// <item><description>Simple: A management node, a logon node, and multiple compute nodes are deployed. The management node consists of an account node and a scheduling node. The logon node and compute nodes are separately deployed.</description></item>
            /// <item><description>Tiny: The account node, scheduling node, and logon node are deployed on one node. The compute node is separately deployed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Simple</para>
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// <para>The description of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The domain name of the on-premises E-HPC cluster.</para>
            /// <para>This parameter takes effect only when the AccoutType parameter is set to Idap.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ldap</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The billing method of the nodes in the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PostPaid: pay-as-you-go</description></item>
            /// <item><description>PrePaid: subscription</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("EcsChargeType")]
            [Validation(Required=false)]
            public string EcsChargeType { get; set; }

            /// <summary>
            /// <para>The list of ECS instance specifications and quantity.</para>
            /// </summary>
            [NameInMap("EcsInfo")]
            [Validation(Required=false)]
            public DescribeClusterResponseBodyClusterInfoEcsInfo EcsInfo { get; set; }
            public class DescribeClusterResponseBodyClusterInfoEcsInfo : TeaModel {
                /// <summary>
                /// <para>The list of compute nodes.</para>
                /// </summary>
                [NameInMap("Compute")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoCompute Compute { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoCompute : TeaModel {
                    /// <summary>
                    /// <para>The number of compute nodes in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>The instance type of the compute nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs.n1.tiny</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

                /// <summary>
                /// <para>The list of logon nodes.</para>
                /// </summary>
                [NameInMap("Login")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoLogin Login { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoLogin : TeaModel {
                    /// <summary>
                    /// <para>The number of logon nodes in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>The instance type of the logon nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs.n1.tiny</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

                /// <summary>
                /// <para>The information of management nodes.</para>
                /// </summary>
                [NameInMap("Manager")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoManager Manager { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoManager : TeaModel {
                    /// <summary>
                    /// <para>The number of management nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>The instance type of the management nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs.n1.tiny</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

                /// <summary>
                /// <para>The list of proxy nodes on the cloud.</para>
                /// <para>This parameter is returned only when the cluster is deployed across hybrid environments and the hybrid-cloud proxy mode is enabled for the cluster.</para>
                /// </summary>
                [NameInMap("ProxyMgr")]
                [Validation(Required=false)]
                public DescribeClusterResponseBodyClusterInfoEcsInfoProxyMgr ProxyMgr { get; set; }
                public class DescribeClusterResponseBodyClusterInfoEcsInfoProxyMgr : TeaModel {
                    /// <summary>
                    /// <para>The number of proxy nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>The instance type of the proxy node.</para>
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
            /// <para>Specifies whether to enable the high availability feature.</para>
            /// <remarks>
            /// <para> If high availability is enabled, each management role in the cluster uses both primary and secondary instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HaEnable")]
            [Validation(Required=false)]
            public bool? HaEnable { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp15de54eet1c43f****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos_7_02_64_20G_alibase_20170818****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_for_Image</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The image type. Valid values:</para>
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
            /// <para>The image information of the operating systems.</para>
            /// </summary>
            [NameInMap("InitialImage")]
            [Validation(Required=false)]
            public DescribeClusterResponseBodyClusterInfoInitialImage InitialImage { get; set; }
            public class DescribeClusterResponseBodyClusterInfoInitialImage : TeaModel {
                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_7_6_x64_20G_alibase_20211130.vhd</para>
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
                /// <para>An array of OS images that are supported by E-HPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS_7.6_64</para>
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

            }

            /// <summary>
            /// <para>The name of the AccessKey pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The location where the cluster is deployed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OnPremise: The node is deployed on a hybrid cloud.</description></item>
            /// <item><description>PublicCloud: The cluster is deployed on a public cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PublicCloud</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The information of the on-premises node in the cluster.</para>
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
                    /// <para>The service type of the domain account to which the node in the on-premises cluster belongs. Valid values:</para>
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
                    /// <para>The directory of the node in the on-premises cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/opt/sge/default/</para>
                    /// </summary>
                    [NameInMap("Dir")]
                    [Validation(Required=false)]
                    public string Dir { get; set; }

                    /// <summary>
                    /// <para>The hostname of the node in the on-premises cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>compute000</para>
                    /// </summary>
                    [NameInMap("HostName")]
                    [Validation(Required=false)]
                    public string HostName { get; set; }

                    /// <summary>
                    /// <para>The IP address of the node in the on-premises cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.XX.XX</para>
                    /// </summary>
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public string IpAddress { get; set; }

                    /// <summary>
                    /// <para>The role of the node in the on-premises cluster. Valid values:</para>
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
                    /// <para>The scheduler type of the node in the on-premises cluster. Valid values:</para>
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

            }

            /// <summary>
            /// <para>The list of on-premises management nodes.</para>
            /// <para>This parameter is returned only when the cluster is deployed across hybrid environments and the hybrid-cloud proxy mode is enabled for the cluster.</para>
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
                    /// <para>The hostname of the management node in the on-premises cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testecs</para>
                    /// </summary>
                    [NameInMap("HostName")]
                    [Validation(Required=false)]
                    public string HostName { get; set; }

                    /// <summary>
                    /// <para>The IP address of the management node in the on-premises cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.<em>.</em></para>
                    /// </summary>
                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    /// <summary>
                    /// <para>The type of the management node in the on-premises cluster. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>scheduler</description></item>
                    /// <item><description>account</description></item>
                    /// <item><description>account, scheduler</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>scheduler</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The parameter that is used to connect to the OpenLDAP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;LdapServerIp&quot;: &quot;192.168.XX.XX&quot;,
            ///     &quot;BaseDn&quot;: &quot;ehpctest&quot;,
            ///     &quot;FallbackHomeDir&quot;: &quot;/home&quot;
            /// }</para>
            /// </summary>
            [NameInMap("OpenldapPar")]
            [Validation(Required=false)]
            public string OpenldapPar { get; set; }

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
            /// <para>The duration of the subscription. The unit of the duration is specified by the <c>PeriodUnit</c> parameter.</para>
            /// <list type="bullet">
            /// <item><description>If you set PriceUnit to Year, the valid values of the Period parameter are 1, 2, and 3.</description></item>
            /// <item><description>If you set PriceUnit to Month, the valid values of the Period parameter are 1, 2, 3, 4, 5, 6, 7, 8, and 9.</description></item>
            /// <item><description>If you set PriceUnit to Hour, the valid value of the Period parameter is 1.</description></item>
            /// </list>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// <para>The unit of the subscription duration. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Year</description></item>
            /// <item><description>Month</description></item>
            /// <item><description>Hour</description></item>
            /// </list>
            /// <para>Default value: Month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The mode configurations of the plug-in. This parameter takes effect only when the SchedulerType parameter is set to custom.</para>
            /// <para>The value must be a JSON string. The parameter contains the following parameters: pluginMod, pluginLocalPath, and pluginOssPath.</para>
            /// <list type="bullet">
            /// <item><description><para>pluginMod: the mode of the plug-in. The following modes are supported:</para>
            /// <list type="bullet">
            /// <item><description>oss: The plug-in is downloaded and decompressed from OSS to a local path that is specified by the pluginLocalPath parameter.</description></item>
            /// <item><description>image: By default, the plug-in is stored in a pre-defined local path that is specified by the pluginLocalPath parameter.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>pluginLocalPath: the local path where the plug-in is stored. We recommend that you select a shared directory in the oss mode and a non-shared directory in the image mode.</para>
            /// </description></item>
            /// <item><description><para>pluginOssPath: the remote path where the plug-in is stored in OSS. This parameter takes effect only if you set the pluginMod parameter to oss.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;pluginMod\&quot;:\&quot;image\&quot;,\&quot;pluginLocalPath\&quot;:\&quot;/opt/plugin\&quot;}</para>
            /// </summary>
            [NameInMap("Plugin")]
            [Validation(Required=false)]
            public string Plugin { get; set; }

            /// <summary>
            /// <para>The list of post-installation scripts</para>
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
                    /// <para>The parameter used to run the script.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bash file.sh</para>
                    /// </summary>
                    [NameInMap("Args")]
                    [Validation(Required=false)]
                    public string Args { get; set; }

                    /// <summary>
                    /// <para>The URL used to download the script.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.com</para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>The node type details of the instance RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;manager&quot;, &quot;compute&quot;]</para>
            /// </summary>
            [NameInMap("RamNodeTypes")]
            [Validation(Required=false)]
            public string RamNodeTypes { get; set; }

            /// <summary>
            /// <para>The name of the instance Resource Access Management (RAM) role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunEHPCFullAccess</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The remote directory on which the file system is mounted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NasMountpoint:/RemoteDirectory</para>
            /// </summary>
            [NameInMap("RemoteDirectory")]
            [Validation(Required=false)]
            public string RemoteDirectory { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek23szz5i2****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the Super Computing Cluster (SCC) instance. If the cluster is not an SCC instance, a null string is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00b648b****</para>
            /// </summary>
            [NameInMap("SccClusterId")]
            [Validation(Required=false)]
            public string SccClusterId { get; set; }

            /// <summary>
            /// <para>Specifies whether the scheduler is preinstalled for the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The scheduler is preinstalled. When you create a node or scale out a cluster, you do not need to install the scheduler.</description></item>
            /// <item><description>false: The scheduler is not preinstalled. When you create or add a cluster, you must install the scheduler.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SchedulerPreInstall")]
            [Validation(Required=false)]
            public int? SchedulerPreInstall { get; set; }

            /// <summary>
            /// <para>The type of the scheduler. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pbs</description></item>
            /// <item><description>slurm</description></item>
            /// <item><description>opengridscheduler</description></item>
            /// <item><description>deadline</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pbs</para>
            /// </summary>
            [NameInMap("SchedulerType")]
            [Validation(Required=false)]
            public string SchedulerType { get; set; }

            /// <summary>
            /// <para>The version of the scheduler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18.1.1</para>
            /// </summary>
            [NameInMap("SchedulerVersion")]
            [Validation(Required=false)]
            public string SchedulerVersion { get; set; }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp1asugr34gzn****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>uninit: The cluster is not initialized.</description></item>
            /// <item><description>creating: The cluster is being created.</description></item>
            /// <item><description>init: The cluster is being initialized.</description></item>
            /// <item><description>running: The cluster is running.</description></item>
            /// <item><description>exception: The cluster encounters an exception.</description></item>
            /// <item><description>releasing: The cluster is being released.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>creating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The vSwitch ID. E-HPC can be deployed only in VPCs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1e47optm9g58zcu****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the File Storage NAS file system. NAS file systems cannot be automatically created.</para>
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
            /// <para>The type of the protocol that is used by the file system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>nfs</description></item>
            /// <item><description>smb</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>nfs</para>
            /// </summary>
            [NameInMap("VolumeProtocol")]
            [Validation(Required=false)]
            public string VolumeProtocol { get; set; }

            /// <summary>
            /// <para>The type of the network shared storage. Valid value: NAS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NAS</para>
            /// </summary>
            [NameInMap("VolumeType")]
            [Validation(Required=false)]
            public string VolumeType { get; set; }

            /// <summary>
            /// <para>The VPC ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1pxkcvmmz53ki89****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The parameter that is used to connect to the Windows AD server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{	&quot;AdUser&quot;: &quot;Administrator&quot;,	&quot;AdUserPasswd&quot;: &quot;xxxxxx&quot;,	&quot;AdDc&quot;: &quot;ad-hybrid001.ehpcad.com&quot;,	&quot;AdIp&quot;: &quot;192.168.XX.XX&quot;}</para>
            /// </summary>
            [NameInMap("WinAdPar")]
            [Validation(Required=false)]
            public string WinAdPar { get; set; }

            /// <summary>
            /// <para>Specifies whether to not install the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WithoutAgent")]
            [Validation(Required=false)]
            public int? WithoutAgent { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
