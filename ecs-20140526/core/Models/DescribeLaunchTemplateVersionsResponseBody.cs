// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplateVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the launch template versions.</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersionSets")]
        [Validation(Required=false)]
        public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSets LaunchTemplateVersionSets { get; set; }
        public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSets : TeaModel {
            [NameInMap("LaunchTemplateVersionSet")]
            [Validation(Required=false)]
            public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSet> LaunchTemplateVersionSet { get; set; }
            public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSet : TeaModel {
                /// <summary>
                /// <para>The time when the launch template version was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-17T08:22:43Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that created the launch template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789****</para>
                /// </summary>
                [NameInMap("CreatedBy")]
                [Validation(Required=false)]
                public string CreatedBy { get; set; }

                /// <summary>
                /// <para>Indicates whether the launch template version is the default version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DefaultVersion")]
                [Validation(Required=false)]
                public bool? DefaultVersion { get; set; }

                /// <summary>
                /// <para>The configurations of the launch template.</para>
                /// </summary>
                [NameInMap("LaunchTemplateData")]
                [Validation(Required=false)]
                public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateData LaunchTemplateData { get; set; }
                public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateData : TeaModel {
                    [NameInMap("SystemDisk")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataSystemDisk SystemDisk { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataSystemDisk : TeaModel {
                        [NameInMap("AutoSnapshotPolicyId")]
                        [Validation(Required=false)]
                        public string AutoSnapshotPolicyId { get; set; }

                        [NameInMap("BurstingEnabled")]
                        [Validation(Required=false)]
                        public bool? BurstingEnabled { get; set; }

                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        [NameInMap("DeleteWithInstance")]
                        [Validation(Required=false)]
                        public bool? DeleteWithInstance { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("DiskName")]
                        [Validation(Required=false)]
                        public string DiskName { get; set; }

                        [NameInMap("Encrypted")]
                        [Validation(Required=false)]
                        public string Encrypted { get; set; }

                        [NameInMap("Iops")]
                        [Validation(Required=false)]
                        public int? Iops { get; set; }

                        [NameInMap("KMSKeyId")]
                        [Validation(Required=false)]
                        public string KMSKeyId { get; set; }

                        [NameInMap("PerformanceLevel")]
                        [Validation(Required=false)]
                        public string PerformanceLevel { get; set; }

                        [NameInMap("ProvisionedIops")]
                        [Validation(Required=false)]
                        public long? ProvisionedIops { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                    }

                    /// <summary>
                    /// <para>The automatic release time of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-05-14T14:18:00Z</para>
                    /// </summary>
                    [NameInMap("AutoReleaseTime")]
                    [Validation(Required=false)]
                    public string AutoReleaseTime { get; set; }

                    /// <summary>
                    /// <para>Indicates whether auto-renewal is enabled for the instance. This parameter is valid only if <c>InstanceChargeType</c> is set to <c>PrePaid</c>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// <para>Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AutoRenew")]
                    [Validation(Required=false)]
                    public bool? AutoRenew { get; set; }

                    /// <summary>
                    /// <para>The auto-renewal period of the instance. Valid values:</para>
                    /// <para>Valid values when PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
                    /// <para>Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AutoRenewPeriod")]
                    [Validation(Required=false)]
                    public int? AutoRenewPeriod { get; set; }

                    /// <summary>
                    /// <para>The performance mode of the burstable instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Standard: the standard mode. For more information, see the &quot;Standard mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
                    /// <item><description>Unlimited: the unlimited mode. For more information, see the &quot;Unlimited mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Standard</para>
                    /// </summary>
                    [NameInMap("CreditSpecification")]
                    [Validation(Required=false)]
                    public string CreditSpecification { get; set; }

                    /// <summary>
                    /// <para>Details about the data disks.</para>
                    /// </summary>
                    [NameInMap("DataDisks")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataDataDisks DataDisks { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataDataDisks : TeaModel {
                        [NameInMap("DataDisk")]
                        [Validation(Required=false)]
                        public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataDataDisksDataDisk> DataDisk { get; set; }
                        public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataDataDisksDataDisk : TeaModel {
                            /// <summary>
                            /// <para>The ID of the automatic snapshot policy.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>sp-wz91dz3ghear2a5s****</para>
                            /// </summary>
                            [NameInMap("AutoSnapshotPolicyId")]
                            [Validation(Required=false)]
                            public string AutoSnapshotPolicyId { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the performance burst feature is enabled. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>true</description></item>
                            /// <item><description>false</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("BurstingEnabled")]
                            [Validation(Required=false)]
                            public bool? BurstingEnabled { get; set; }

                            /// <summary>
                            /// <para>The category of the data disk.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>cloud_ssd</para>
                            /// </summary>
                            [NameInMap("Category")]
                            [Validation(Required=false)]
                            public string Category { get; set; }

                            /// <summary>
                            /// <para>Indicates whether to release the data disk when the instance is released.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("DeleteWithInstance")]
                            [Validation(Required=false)]
                            public bool? DeleteWithInstance { get; set; }

                            /// <summary>
                            /// <para>The description of the data disk.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>testDiskDescription</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The mount point of the data disk. The mount points are named based on the number of data disks:</para>
                            /// <list type="bullet">
                            /// <item><description>1st to 25th data disks: /dev/xvd<c>[b-z]</c>.</description></item>
                            /// <item><description>From the 26th data disk on: /dev/xvd<c>[aa-zz]</c>. For example, the 26th data disk is named /dev/xvdaa, the 27th data disk is named /dev/xvdab, and so on.</description></item>
                            /// </list>
                            /// <remarks>
                            /// <para> This parameter is applicable to scenarios in which a full image is used to create instances. A full image is an image that contains an operating system, application software, and business data. For these scenarios, you can set the parameter to the mount point of data disk N contained in the full image and modify <c>DataDisk.N.Size</c> and <c>DataDisk.N.Category</c> to change the category and size of data disk N created based on the image.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/dev/xvda</para>
                            /// </summary>
                            [NameInMap("Device")]
                            [Validation(Required=false)]
                            public string Device { get; set; }

                            /// <summary>
                            /// <para>The name of the data disk.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>testDiskName</para>
                            /// </summary>
                            [NameInMap("DiskName")]
                            [Validation(Required=false)]
                            public string DiskName { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the data disk is encrypted.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Encrypted")]
                            [Validation(Required=false)]
                            public string Encrypted { get; set; }

                            [NameInMap("KMSKeyId")]
                            [Validation(Required=false)]
                            public string KMSKeyId { get; set; }

                            /// <summary>
                            /// <para>The performance level of the ESSD to use as a data disk. This parameter is returned only when the value of <c>Category</c> is cloud_essd. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
                            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
                            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
                            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>PL1</para>
                            /// </summary>
                            [NameInMap("PerformanceLevel")]
                            [Validation(Required=false)]
                            public string PerformanceLevel { get; set; }

                            /// <summary>
                            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}.</para>
                            /// <para>Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
                            /// <remarks>
                            /// <para> This parameter is available only if you set DataDisk.N.Category to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a> and <a href="https://help.aliyun.com/document_detail/413275.html">Modify the performance configurations of an ESSD AutoPL disk</a>.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>50000</para>
                            /// </summary>
                            [NameInMap("ProvisionedIops")]
                            [Validation(Required=false)]
                            public long? ProvisionedIops { get; set; }

                            /// <summary>
                            /// <para>The size of the data disk.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2000</para>
                            /// </summary>
                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public int? Size { get; set; }

                            /// <summary>
                            /// <para>The ID of the snapshot to use to create the data disk.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>s-bp67acfmxazb4p****</para>
                            /// </summary>
                            [NameInMap("SnapshotId")]
                            [Validation(Required=false)]
                            public string SnapshotId { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>Indicates whether release protection is enabled for the instance. This parameter indicates whether you can use the ECS console or call the <a href="https://help.aliyun.com/document_detail/25507.html">DeleteInstance</a> operation to release the instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// <para>Default value: false.</para>
                    /// <remarks>
                    /// <para> This parameter is applicable only to pay-as-you-go instances. The release protection feature can protect instances against manual releases, but not against automatic releases.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DeletionProtection")]
                    [Validation(Required=false)]
                    public bool? DeletionProtection { get; set; }

                    /// <summary>
                    /// <para>The ID of the deployment set.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ds-bp1brhwhoqinyjd6****</para>
                    /// </summary>
                    [NameInMap("DeploymentSetId")]
                    [Validation(Required=false)]
                    public string DeploymentSetId { get; set; }

                    /// <summary>
                    /// <para>The description of the system disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testInstanceDescription</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the operating system configuration of the instance is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EnableVmOsConfig")]
                    [Validation(Required=false)]
                    public bool? EnableVmOsConfig { get; set; }

                    /// <summary>
                    /// <para>The hostname of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testHostName</para>
                    /// </summary>
                    [NameInMap("HostName")]
                    [Validation(Required=false)]
                    public string HostName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the access channel is enabled for instance metadata. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>enabled</description></item>
                    /// <item><description>disabled</description></item>
                    /// </list>
                    /// <para>Default value: enabled.</para>
                    /// <remarks>
                    /// <para> For information about instance metadata, see <a href="https://help.aliyun.com/document_detail/108460.html">Obtain information about an ECS instance, such as instance attributes, by using instance metadata</a>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enabled</para>
                    /// </summary>
                    [NameInMap("HttpEndpoint")]
                    [Validation(Required=false)]
                    public string HttpEndpoint { get; set; }

                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is not publicly available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("HttpPutResponseHopLimit")]
                    [Validation(Required=false)]
                    public int? HttpPutResponseHopLimit { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the security hardening mode (IMDSv2) is forcefully used to access instance metadata. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>optional: The security hardening mode (IMDSv2) is not forcefully used.</description></item>
                    /// <item><description>required: The security hardening mode (IMDSv2) is forcefully used. After you set this parameter to required, you cannot access instance metadata in normal mode.</description></item>
                    /// </list>
                    /// <para>Default value: optional.</para>
                    /// <remarks>
                    /// <para> For more information about the modes of accessing instance metadata, see <a href="https://help.aliyun.com/document_detail/108460.html">Obtain information about an ECS instance, such as instance attributes, by using instance metadata</a>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>optional</para>
                    /// </summary>
                    [NameInMap("HttpTokens")]
                    [Validation(Required=false)]
                    public string HttpTokens { get; set; }

                    /// <summary>
                    /// <para>The ID of the image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>m-bp67acfmxazb4p****</para>
                    /// </summary>
                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }

                    /// <summary>
                    /// <para>The source of the image. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>system: public image provided by Alibaba Cloud</description></item>
                    /// <item><description>self: custom image that you created</description></item>
                    /// <item><description>others: shared image from another Alibaba Cloud account</description></item>
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
                    /// <para>The billing method of the instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PrePaid: subscription</description></item>
                    /// <item><description>PostPaid: pay-as-you-go</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Postpaid</para>
                    /// </summary>
                    [NameInMap("InstanceChargeType")]
                    [Validation(Required=false)]
                    public string InstanceChargeType { get; set; }

                    /// <summary>
                    /// <para>The name of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testInstanceName</para>
                    /// </summary>
                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                    /// <summary>
                    /// <para>The instance type of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs.g5.large</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>The billing method for network usage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PayByTraffic</para>
                    /// </summary>
                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                    /// <summary>
                    /// <para>The maximum inbound public bandwidth.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("InternetMaxBandwidthIn")]
                    [Validation(Required=false)]
                    public int? InternetMaxBandwidthIn { get; set; }

                    /// <summary>
                    /// <para>The maximum outbound public bandwidth.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("InternetMaxBandwidthOut")]
                    [Validation(Required=false)]
                    public int? InternetMaxBandwidthOut { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the instance is I/O optimized.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>none</para>
                    /// </summary>
                    [NameInMap("IoOptimized")]
                    [Validation(Required=false)]
                    public string IoOptimized { get; set; }

                    /// <summary>
                    /// <para>The number of IPv6 addresses to assign to the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Ipv6AddressCount")]
                    [Validation(Required=false)]
                    public int? Ipv6AddressCount { get; set; }

                    /// <summary>
                    /// <para>The name of the key pair.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testKeyPairName</para>
                    /// </summary>
                    [NameInMap("KeyPairName")]
                    [Validation(Required=false)]
                    public string KeyPairName { get; set; }

                    /// <summary>
                    /// <para>Details about the secondary elastic network interfaces (ENIs).</para>
                    /// </summary>
                    [NameInMap("NetworkInterfaces")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfaces NetworkInterfaces { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfaces : TeaModel {
                        [NameInMap("NetworkInterface")]
                        [Validation(Required=false)]
                        public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterface> NetworkInterface { get; set; }
                        public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterface : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether to retain the ENI when the associated instance is released. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>true</description></item>
                            /// <item><description>false</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("DeleteOnRelease")]
                            [Validation(Required=false)]
                            public bool? DeleteOnRelease { get; set; }

                            /// <summary>
                            /// <para>The description of the secondary ENI.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>testNetworkInterfacesDescription</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The instance type of the instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ecs.s2.xlarge</para>
                            /// </summary>
                            [NameInMap("InstanceType")]
                            [Validation(Required=false)]
                            public string InstanceType { get; set; }

                            /// <summary>
                            /// <para>The name of the secondary ENI.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>testNetworkInterfaceName</para>
                            /// </summary>
                            [NameInMap("NetworkInterfaceName")]
                            [Validation(Required=false)]
                            public string NetworkInterfaceName { get; set; }

                            /// <summary>
                            /// <para>The communication mode of the primary ENI. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>Standard: uses the TCP communication mode.</description></item>
                            /// <item><description>HighPerformance: uses the remote direct memory access (RDMA) communication mode with Elastic RDMA Interface (ERI) enabled.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Standard</para>
                            /// </summary>
                            [NameInMap("NetworkInterfaceTrafficMode")]
                            [Validation(Required=false)]
                            public string NetworkInterfaceTrafficMode { get; set; }

                            /// <summary>
                            /// <para>The primary private IP address of the secondary ENI.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>203.0.<em>.</em></para>
                            /// </summary>
                            [NameInMap("PrimaryIpAddress")]
                            [Validation(Required=false)]
                            public string PrimaryIpAddress { get; set; }

                            /// <summary>
                            /// <para>The ID of the security group to which to assign the secondary ENI. The security group and the ENI must belong to the same VPC.</para>
                            /// <remarks>
                            /// <para> SecurityGroupId and SecurityGroupIds are mutually exclusive in the response.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>sg-bp67acfmxazb4p****</para>
                            /// </summary>
                            [NameInMap("SecurityGroupId")]
                            [Validation(Required=false)]
                            public string SecurityGroupId { get; set; }

                            /// <summary>
                            /// <para>The IDs of the security groups to which to assign the secondary ENI.</para>
                            /// <remarks>
                            /// <para> SecurityGroupId and SecurityGroupIds are mutually exclusive in the response.</para>
                            /// </remarks>
                            /// </summary>
                            [NameInMap("SecurityGroupIds")]
                            [Validation(Required=false)]
                            public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterfaceSecurityGroupIds SecurityGroupIds { get; set; }
                            public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterfaceSecurityGroupIds : TeaModel {
                                [NameInMap("SecurityGroupId")]
                                [Validation(Required=false)]
                                public List<string> SecurityGroupId { get; set; }

                            }

                            /// <summary>
                            /// <para>The ID of the vSwitch to which to connect the ENI.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>vsw-bp67acfmxazb4p****</para>
                            /// </summary>
                            [NameInMap("VSwitchId")]
                            [Validation(Required=false)]
                            public string VSwitchId { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The network type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>classic: classic network</description></item>
                    /// <item><description>vpc: VPC</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc</para>
                    /// </summary>
                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the username and password preset in the image are used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("PasswordInherit")]
                    [Validation(Required=false)]
                    public bool? PasswordInherit { get; set; }

                    /// <summary>
                    /// <para>The subscription duration of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Period")]
                    [Validation(Required=false)]
                    public int? Period { get; set; }

                    /// <summary>
                    /// <para>The unit of the subscription period. Valid values:</para>
                    /// <para>Month (default)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Month</para>
                    /// </summary>
                    [NameInMap("PeriodUnit")]
                    [Validation(Required=false)]
                    public string PeriodUnit { get; set; }

                    /// <summary>
                    /// <para>The private IP address to assign to the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><c>10.1.**.**</c></para>
                    /// </summary>
                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public string PrivateIpAddress { get; set; }

                    /// <summary>
                    /// <para>The name of the instance Resource Access Management (RAM) role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testRamRoleName</para>
                    /// </summary>
                    [NameInMap("RamRoleName")]
                    [Validation(Required=false)]
                    public string RamRoleName { get; set; }

                    /// <summary>
                    /// <para>The ID of the resource group to which the launch template belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rg-bp67acfmxazb4p****</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether Security Hardening is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>active</para>
                    /// </summary>
                    [NameInMap("SecurityEnhancementStrategy")]
                    [Validation(Required=false)]
                    public string SecurityEnhancementStrategy { get; set; }

                    /// <summary>
                    /// <para>The ID of the security group to which to assign the instance.</para>
                    /// <remarks>
                    /// <para> <c>SecurityGroupId</c> and <c>SecurityGroupIds</c> are mutually exclusive in the response.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-bp67acfmxazb4p****</para>
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The IDs of the security groups to which to assign the instance.</para>
                    /// <remarks>
                    /// <para> <c>SecurityGroupId</c> and <c>SecurityGroupIds</c> are mutually exclusive in the response.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("SecurityGroupIds")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataSecurityGroupIds SecurityGroupIds { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataSecurityGroupIds : TeaModel {
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public List<string> SecurityGroupId { get; set; }

                    }

                    /// <summary>
                    /// <para>The protection period of the preemptible instance. Unit: hours. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: After a preemptible instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After the 1-hour protection period ends, the system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</description></item>
                    /// <item><description>0: After a preemptible instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</description></item>
                    /// </list>
                    /// <para>Alibaba Cloud sends an ECS system event to notify you 5 minutes before the instance is released. Preemptible instances are billed by second. We recommend that you specify a protection period based on your business requirements.</para>
                    /// <remarks>
                    /// <para> This parameter is returned when SpotStrategy is set to SpotWithPriceLimit or SpotAsPriceGo.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SpotDuration")]
                    [Validation(Required=false)]
                    public int? SpotDuration { get; set; }

                    /// <summary>
                    /// <para>The maximum hourly price of the preemptible instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.98</para>
                    /// </summary>
                    [NameInMap("SpotPriceLimit")]
                    [Validation(Required=false)]
                    public float? SpotPriceLimit { get; set; }

                    /// <summary>
                    /// <para>The bidding policy for the pay-as-you-go instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>NoSpot: The instance is a regular pay-as-you-go instance.</description></item>
                    /// <item><description>SpotWithPriceLimit: The instance is a preemptible instance with a user-defined maximum hourly price.</description></item>
                    /// <item><description>SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bid price. The market price can be up to the pay-as-you-go price.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NoSpot</para>
                    /// </summary>
                    [NameInMap("SpotStrategy")]
                    [Validation(Required=false)]
                    public string SpotStrategy { get; set; }

                    /// <summary>
                    /// <para>The tags to add to the instance.</para>
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataTags Tags { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataTags : TeaModel {
                        [NameInMap("InstanceTag")]
                        [Validation(Required=false)]
                        public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataTagsInstanceTag> InstanceTag { get; set; }
                        public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataTagsInstanceTag : TeaModel {
                            /// <summary>
                            /// <para>The key of the tag to add to the instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TestKey</para>
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// <para>The value of the tag to add to the instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TestValue</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The user data of the instance, which is Base64-encoded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SGVsbG9FQ1M=</para>
                    /// </summary>
                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                    /// <summary>
                    /// <para>The ID of the vSwitch to which to connect the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp67acfmxazb4p****</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The ID of the virtual private cloud (VPC).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v-bp67acfmxazb4p****</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    /// <summary>
                    /// <para>The zone ID of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-g</para>
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the launch template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lt-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                /// <summary>
                /// <para>The name of the launch template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testLaunchTemplateName</para>
                /// </summary>
                [NameInMap("LaunchTemplateName")]
                [Validation(Required=false)]
                public string LaunchTemplateName { get; set; }

                /// <summary>
                /// <para>The time when the launch template version was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-17T08:40:00Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The description of the launch template version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testVersionDescription</para>
                /// </summary>
                [NameInMap("VersionDescription")]
                [Validation(Required=false)]
                public string VersionDescription { get; set; }

                /// <summary>
                /// <para>The number of the launch template version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("VersionNumber")]
                [Validation(Required=false)]
                public long? VersionNumber { get; set; }

            }

        }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3989ED0C-20A1-4351-A127-2067FF8390AX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of launch templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
