// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the cloud desktops.</para>
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopsResponseBodyDesktops> Desktops { get; set; }
        public class DescribeDesktopsResponseBodyDesktops : TeaModel {
            /// <summary>
            /// <para>The account type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The list of agents supported by the cloud desktop.</para>
            /// </summary>
            [NameInMap("AgentProviderList")]
            [Validation(Required=false)]
            public List<string> AgentProviderList { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent sessions allowed per cloud desktop in a multi-session cloud desktop pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("BindAmount")]
            [Validation(Required=false)]
            public int? BindAmount { get; set; }

            /// <summary>
            /// <para>The ID of the cloud desktop template used by the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b-2g65ljy4291vl****</para>
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// <para>The name of the cloud desktop template used by the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TemplateName</para>
            /// </summary>
            [NameInMap("BundleName")]
            [Validation(Required=false)]
            public string BundleName { get; set; }

            /// <summary>
            /// <para>The billing method of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The connection status of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Disconnected</para>
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The creation time of the cloud desktop. The time is in the ISO 8601 standard (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-06T08:28Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_auto</para>
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            [NameInMap("DesktopDurationList")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsDesktopDurationList> DesktopDurationList { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsDesktopDurationList : TeaModel {
                [NameInMap("DisableRemainingNotify")]
                [Validation(Required=false)]
                public bool? DisableRemainingNotify { get; set; }

                [NameInMap("OrderInstanceId")]
                [Validation(Required=false)]
                public string OrderInstanceId { get; set; }

                [NameInMap("PackageCreationTime")]
                [Validation(Required=false)]
                public string PackageCreationTime { get; set; }

                [NameInMap("PackageExpiredTime")]
                [Validation(Required=false)]
                public string PackageExpiredTime { get; set; }

                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public string PackageId { get; set; }

                [NameInMap("PackageStatus")]
                [Validation(Required=false)]
                public string PackageStatus { get; set; }

                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                [NameInMap("PackageUsedUpStrategy")]
                [Validation(Required=false)]
                public string PackageUsedUpStrategy { get; set; }

                [NameInMap("PeriodEndTime")]
                [Validation(Required=false)]
                public string PeriodEndTime { get; set; }

                [NameInMap("PeriodStartTime")]
                [Validation(Required=false)]
                public string PeriodStartTime { get; set; }

                [NameInMap("PostPaidLimitFee")]
                [Validation(Required=false)]
                public float? PostPaidLimitFee { get; set; }

                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public long? TotalDuration { get; set; }

                [NameInMap("UsedDuration")]
                [Validation(Required=false)]
                public long? UsedDuration { get; set; }

            }

            /// <summary>
            /// <para>The ID of the cloud desktop pool to which the cloud desktop belongs. Default value: <c>null</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dg-2i8qxpv6t1a03****</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <para>The cloud desktop ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-gx2x1dhsmucyy****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The cloud desktop name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DemoComputer01</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The cloud desktop status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// <para>The specifications of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd.basic.large</para>
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// <para>The directory ID. This is the same as the office network ID (OfficeSiteId).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>The disk information.</para>
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsDisks> Disks { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsDisks : TeaModel {
                /// <summary>
                /// <para>The disk category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_efficiency (ultra cloud disk)</description></item>
                /// <item><description>cloud_auto (auto cloud disk)</description></item>
                /// <item><description>cloud_essd (enhanced standard SSD cloud disk, supported only by specific instance types)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_auto</para>
                /// </summary>
                [NameInMap("DiskCategory")]
                [Validation(Required=false)]
                public string DiskCategory { get; set; }

                /// <summary>
                /// <para>The disk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-jedbpr4sl9l37****</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>The disk size. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// <para>The disk type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The performance level of the enhanced standard SSD cloud disk. This parameter is valid only when the cloud disk is an enhanced standard SSD cloud disk.</para>
                /// <para>For more information about the differences between performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">Enhanced standard SSD cloud disks</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL0</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

            }

            /// <summary>
            /// <para>The domain type of the directory to which the cloud desktop belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AD</para>
            /// </summary>
            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// <para>The number of times the specifications can be downgraded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DowngradeQuota")]
            [Validation(Required=false)]
            public long? DowngradeQuota { get; set; }

            /// <summary>
            /// <para>The number of times the specifications have been downgraded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DowngradedTimes")]
            [Validation(Required=false)]
            public long? DowngradedTimes { get; set; }

            /// <summary>
            /// <para>The IDs of the authorized users of the cloud desktop.</para>
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// <para>The domain name of Microsoft Entra ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>contoso.onmicrosoft.com</para>
            /// </summary>
            [NameInMap("EntraDomainName")]
            [Validation(Required=false)]
            public string EntraDomainName { get; set; }

            /// <summary>
            /// <para>The environment ID. This parameter is for internal use only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adifa****</para>
            /// </summary>
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            /// <summary>
            /// <para>The environment type. This parameter is for internal use only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The expiration time of the subscription cloud desktop. The time is in the ISO 8601 standard (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-31T15:59Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The image version information of the cloud desktop.</para>
            /// </summary>
            [NameInMap("FotaUpdate")]
            [Validation(Required=false)]
            public DescribeDesktopsResponseBodyDesktopsFotaUpdate FotaUpdate { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsFotaUpdate : TeaModel {
                /// <summary>
                /// <para>The version number of the current image of the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0-D-20220102.000000</para>
                /// </summary>
                [NameInMap("CurrentAppVersion")]
                [Validation(Required=false)]
                public string CurrentAppVersion { get; set; }

                /// <summary>
                /// <para>The version number of the image to which the cloud desktop can be upgraded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0-R-20220307.190736</para>
                /// </summary>
                [NameInMap("NewAppVersion")]
                [Validation(Required=false)]
                public string NewAppVersion { get; set; }

                /// <summary>
                /// <para>The release notes of the upgradable image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test upgrade package 03-07</para>
                /// </summary>
                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

                /// <summary>
                /// <para>The English description of the upgradable version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>What\&quot;s new</para>
                /// </summary>
                [NameInMap("ReleaseNoteEn")]
                [Validation(Required=false)]
                public string ReleaseNoteEn { get; set; }

                /// <summary>
                /// <para>The Japanese description of the upgradable version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>リリースノート</para>
                /// </summary>
                [NameInMap("ReleaseNoteJp")]
                [Validation(Required=false)]
                public string ReleaseNoteJp { get; set; }

                /// <summary>
                /// <para>The size of the installation package for the upgradable version. Unit: KB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>108815097</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the cloud desktop is a GPU-accelerated cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("GpuCategory")]
            [Validation(Required=false)]
            public long? GpuCategory { get; set; }

            /// <summary>
            /// <para>The number of GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            /// <summary>
            /// <para>The GPU driver version of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>471.68</para>
            /// </summary>
            [NameInMap("GpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

            /// <summary>
            /// <para>The GPU specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NVIDIA T4</para>
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HibernationBeta")]
            [Validation(Required=false)]
            public bool? HibernationBeta { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HibernationOptionsConfigured")]
            [Validation(Required=false)]
            public bool? HibernationOptionsConfigured { get; set; }

            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-4zfb6zj728hhr****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image name before the change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows server 2019 Mainland</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>Indicates whether the directory is an LDAP directory.</para>
            /// </summary>
            [NameInMap("IsLdap")]
            [Validation(Required=false)]
            public bool? IsLdap { get; set; }

            /// <summary>
            /// <para>The management flag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NoFlag</para>
            /// </summary>
            [NameInMap("ManagementFlag")]
            [Validation(Required=false)]
            public string ManagementFlag { get; set; }

            /// <summary>
            /// <para>The management flag.</para>
            /// </summary>
            [NameInMap("ManagementFlags")]
            [Validation(Required=false)]
            public List<string> ManagementFlags { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: MiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The ID of the secondary elastic network interface (ENI) created by the cloud desktop service for a RAM or AD user. This ID cannot be modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The IP address of the secondary ENI created by the cloud desktop service for a RAM or AD user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The office network name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The account system type of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// <para>The VPC type of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("OfficeSiteVpcType")]
            [Validation(Required=false)]
            public string OfficeSiteVpcType { get; set; }

            /// <summary>
            /// <para>The operating system type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The operating system update information of the cloud desktop.</para>
            /// </summary>
            [NameInMap("OsUpdate")]
            [Validation(Required=false)]
            public DescribeDesktopsResponseBodyDesktopsOsUpdate OsUpdate { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsOsUpdate : TeaModel {
                /// <summary>
                /// <para>The ID of the health check task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ck-8f2a1b****</para>
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                /// <summary>
                /// <para>The number of patch packages to be updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("PackageCount")]
                [Validation(Required=false)]
                public int? PackageCount { get; set; }

                /// <summary>
                /// <para>The list of system patch packages.</para>
                /// </summary>
                [NameInMap("Packages")]
                [Validation(Required=false)]
                public List<DescribeDesktopsResponseBodyDesktopsOsUpdatePackages> Packages { get; set; }
                public class DescribeDesktopsResponseBodyDesktopsOsUpdatePackages : TeaModel {
                    /// <summary>
                    /// <para>The description of the NAS file system.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>newDescription</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The KB number of the system patch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KB5032190</para>
                    /// </summary>
                    [NameInMap("Kb")]
                    [Validation(Required=false)]
                    public string Kb { get; set; }

                    /// <summary>
                    /// <para>The vulnerability name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-05 Servicing Stack Update for Windows Server 2019 for x64-based Systems (KB5003243)</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            /// <summary>
            /// <para>The operating system platform information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ubuntu</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The cloud desktop policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system-all-enabled-policy</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The collection of cloud desktop policy IDs.</para>
            /// </summary>
            [NameInMap("PolicyGroupIdList")]
            [Validation(Required=false)]
            public List<string> PolicyGroupIdList { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>All enabled policy</para>
            /// </summary>
            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// <para>The list of cloud desktop policy names.</para>
            /// </summary>
            [NameInMap("PolicyGroupNameList")]
            [Validation(Required=false)]
            public List<string> PolicyGroupNameList { get; set; }

            /// <summary>
            /// <para>The creation progress of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The ID of the resource reservation pool associated with the cloud desktop, such as rp-xxx. This parameter is empty if no pool is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rp-xxx</para>
            /// </summary>
            [NameInMap("ReservePoolId")]
            [Validation(Required=false)]
            public string ReservePoolId { get; set; }

            /// <summary>
            /// <para>The name of the resource reservation pool associated with the cloud desktop. This parameter is empty if no pool is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>reserve-pool</para>
            /// </summary>
            [NameInMap("ReservePoolName")]
            [Validation(Required=false)]
            public string ReservePoolName { get; set; }

            /// <summary>
            /// <para>The list of enterprise resource groups.</para>
            /// </summary>
            [NameInMap("ResourceGroups")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsResourceGroups> ResourceGroups { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsResourceGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the enterprise resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-4hsvzbbmqdzu3s****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the enterprise resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ResourceGroup01</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The serial number of the terminal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>96c530bc-6095-4014-8bbc-d461b8ac****</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>The session type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SINGLE_SESSION</para>
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <para>The user session information of the cloud desktop.</para>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsSessions> Sessions { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsSessions : TeaModel {
                /// <summary>
                /// <para>The ID of the user connected to the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29615820929547****</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <para>The time when the cloud desktop session was connected. The time follows the ISO 8601 standard in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-07T08:23Z</para>
                /// </summary>
                [NameInMap("EstablishmentTime")]
                [Validation(Required=false)]
                public string EstablishmentTime { get; set; }

                /// <summary>
                /// <para>The name of the external user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Testname</para>
                /// </summary>
                [NameInMap("ExternalUserName")]
                [Validation(Required=false)]
                public string ExternalUserName { get; set; }

            }

            /// <summary>
            /// <para>The snapshot policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-gi007jgyc3kce****</para>
            /// </summary>
            [NameInMap("SnapshotPolicyId")]
            [Validation(Required=false)]
            public string SnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>The snapshot policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testSnapshotName</para>
            /// </summary>
            [NameInMap("SnapshotPolicyName")]
            [Validation(Required=false)]
            public string SnapshotPolicyName { get; set; }

            /// <summary>
            /// <para>The start time of the query. The time is expressed in the ISO 8601 standard in UTC+0, in the <c>yyyy-mm-ddthh:mm:ssz</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-27T02:20:10Z</para>
            /// </summary>
            [NameInMap("StandardStartTime")]
            [Validation(Required=false)]
            public string StandardStartTime { get; set; }

            /// <summary>
            /// <para>The time when the cloud desktop was started for the first time. The time follows the ISO 8601 standard in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-06T08:31Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The subnet ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-dgea1*****</para>
            /// </summary>
            [NameInMap("SubnetId")]
            [Validation(Required=false)]
            public string SubnetId { get; set; }

            /// <summary>
            /// <para>The subnet name of the desktop instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VswName</para>
            /// </summary>
            [NameInMap("SubnetName")]
            [Validation(Required=false)]
            public string SubnetName { get; set; }

            /// <summary>
            /// <para>Indicates whether hibernation is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportHibernation")]
            [Validation(Required=false)]
            public bool? SupportHibernation { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_auto</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The tag information.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsTags> Tags { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsTags : TeaModel {
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
            /// <para>Indicates whether volume encryption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key used when volume encryption is enabled. You can obtain the key ID by calling the <a href="https://help.aliyun.com/document_detail/28951.html">ListKeys</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddfa1d4****</para>
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <para>The type of the zone. Default value: <c>AvailabilityZone</c>, which indicates a regular availability zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AvailabilityZone</para>
            /// </summary>
            [NameInMap("ZoneType")]
            [Validation(Required=false)]
            public string ZoneType { get; set; }

        }

        /// <summary>
        /// <para>The token that is used to start the next query. If NextToken is empty, no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number for a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>484256DA-D816-44D2-9D86-B6EE4D5BA78C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of cloud computers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
