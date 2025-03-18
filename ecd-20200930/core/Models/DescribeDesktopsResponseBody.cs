// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the cloud computers.</para>
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopsResponseBodyDesktops> Desktops { get; set; }
        public class DescribeDesktopsResponseBodyDesktops : TeaModel {
            /// <summary>
            /// <para>The number of concurrent sessions of each cloud computer in a multi-session cloud computer pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BindAmount")]
            [Validation(Required=false)]
            public int? BindAmount { get; set; }

            /// <summary>
            /// <para>The ID of the template used to create the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b-2g65ljy4291vl****</para>
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// <para>The name of the template used to create the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Name</para>
            /// </summary>
            [NameInMap("BundleName")]
            [Validation(Required=false)]
            public string BundleName { get; set; }

            /// <summary>
            /// <para>The billing method of the cloud computer.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Postpaid (default): pay-as-you-go</description></item>
            /// <item><description>PrePaid: subscription</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The connection status of the end user.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Unknown</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Connected</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Disconnected</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
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
            /// <para>The time when the cloud computer was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-06T08:28Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            [NameInMap("DesktopDurationList")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsDesktopDurationList> DesktopDurationList { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsDesktopDurationList : TeaModel {
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
            /// <para>The ID of the cloud computer pool to which cloud computers belong. Default value: null.``</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <para>The cloud computer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-gx2x1dhsmucyy****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The cloud computer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDesktopName</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The cloud computer status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// <para>The cloud computer type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd.basic.large</para>
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// <para>The directory ID, which is the same as the office network ID (OfficeSiteId).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>The information about the disks.</para>
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsDisks> Disks { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsDisks : TeaModel {
                /// <summary>
                /// <para>The type of the disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_efficiency: ultra disk.</description></item>
                /// <item><description>cloud_auto: standard SSD.</description></item>
                /// <item><description>cloud_essd: enhanced SSD (ESSD).</description></item>
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
                /// <para>The type of the disk.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>SYSTEM: system disk</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>DATA: data disk</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- --></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The performance level (PL) of the disk when an enterprise SSD (ESSD) is used.</para>
                /// <para>For more information about the differences among enterprise SSDs (ESSDs) at different PLs, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL1</description></item>
                /// <item><description>PL0</description></item>
                /// <item><description>PL3</description></item>
                /// <item><description>PL2</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PL0</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

            }

            /// <summary>
            /// <para>The number of times for which the cloud desktop can be downgraded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DowngradeQuota")]
            [Validation(Required=false)]
            public long? DowngradeQuota { get; set; }

            /// <summary>
            /// <para>The number of times for which the cloud desktop has been downgraded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DowngradedTimes")]
            [Validation(Required=false)]
            public long? DowngradedTimes { get; set; }

            /// <summary>
            /// <para>The end user IDs.</para>
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// <para>The time when a subscription cloud computer expired.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-31T15:59Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The information about the image version of the cloud computer.</para>
            /// </summary>
            [NameInMap("FotaUpdate")]
            [Validation(Required=false)]
            public DescribeDesktopsResponseBodyDesktopsFotaUpdate FotaUpdate { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsFotaUpdate : TeaModel {
                /// <summary>
                /// <para>The current image version of the cloud computer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0-D-20220102.000000</para>
                /// </summary>
                [NameInMap("CurrentAppVersion")]
                [Validation(Required=false)]
                public string CurrentAppVersion { get; set; }

                /// <summary>
                /// <para>The version number to which the image of the cloud computer can be updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0-R-20220307.190736</para>
                /// </summary>
                [NameInMap("NewAppVersion")]
                [Validation(Required=false)]
                public string NewAppVersion { get; set; }

                /// <summary>
                /// <para>The description of the version to which the image of the cloud computer can be updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Upgrade package for testing 03-07</para>
                /// </summary>
                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

                /// <summary>
                /// <para>The English description of the version to which the image of the cloud computer can be updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Release note</para>
                /// </summary>
                [NameInMap("ReleaseNoteEn")]
                [Validation(Required=false)]
                public string ReleaseNoteEn { get; set; }

                /// <summary>
                /// <para>The Japanese description of the image version to which the cloud desktop can be updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>リリースノート</para>
                /// </summary>
                [NameInMap("ReleaseNoteJp")]
                [Validation(Required=false)]
                public string ReleaseNoteJp { get; set; }

                /// <summary>
                /// <para>The size of the installation package for the image to which the cloud desktop can be updated. Unit: KB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>108815097</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the cloud computer uses GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("GpuCategory")]
            [Validation(Required=false)]
            public long? GpuCategory { get; set; }

            /// <summary>
            /// <para>The number of GPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            /// <summary>
            /// <para>The GPU driver version used by the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("GpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

            /// <summary>
            /// <para>The GPU Specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NVIDIA T4</para>
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
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
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HibernationOptionsConfigured")]
            [Validation(Required=false)]
            public bool? HibernationOptionsConfigured { get; set; }

            /// <summary>
            /// <para>The hostname of the cloud desktop.</para>
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
            /// <para>The flag that is used to manage the cloud computer.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Migrating: The cloud computer is being migrated.</description></item>
            /// <item><description>Updating: The configurations of the cloud computer are being updated.</description></item>
            /// <item><description>NoFlag: No flags are available.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoFlag</para>
            /// </summary>
            [NameInMap("ManagementFlag")]
            [Validation(Required=false)]
            public string ManagementFlag { get; set; }

            /// <summary>
            /// <para>The flags that are used to manage the cloud computers.</para>
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
            /// <para>The ID of the supplementary network interface controller (NIC) created by EDS within an RAM user or Active Directory (AD) user. You cannot modify the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The IP address of the supplementary NIC created by EDS within an RAM or AD user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.74.165</para>
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
            /// <para>test</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The account type of the office network.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SIMPLE: convenience account</description></item>
            /// <item><description>AD_CONNECTOR: enterprise AD account</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// <para>The VPC type of the office network.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard</description></item>
            /// <item><description>customized</description></item>
            /// <item><description>basic</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("OfficeSiteVpcType")]
            [Validation(Required=false)]
            public string OfficeSiteVpcType { get; set; }

            /// <summary>
            /// <para>The OS that is defined in the desktop template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("OsUpdate")]
            [Validation(Required=false)]
            public DescribeDesktopsResponseBodyDesktopsOsUpdate OsUpdate { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsOsUpdate : TeaModel {
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                [NameInMap("PackageCount")]
                [Validation(Required=false)]
                public int? PackageCount { get; set; }

                [NameInMap("Packages")]
                [Validation(Required=false)]
                public List<DescribeDesktopsResponseBodyDesktopsOsUpdatePackages> Packages { get; set; }
                public class DescribeDesktopsResponseBodyDesktopsOsUpdatePackages : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Kb")]
                    [Validation(Required=false)]
                    public string Kb { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about the OS platform.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Ubuntu</description></item>
            /// <item><description>Windows Server 2022</description></item>
            /// <item><description>UOS</description></item>
            /// <item><description>CentOS</description></item>
            /// <item><description>Windows Server 2019</description></item>
            /// <item><description>Windows Server 2016</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ubuntu</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system-all-enabled-policy</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The IDs of the cloud computer policies.</para>
            /// </summary>
            [NameInMap("PolicyGroupIdList")]
            [Validation(Required=false)]
            public List<string> PolicyGroupIdList { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// <para>The names of the cloud computer policies.</para>
            /// </summary>
            [NameInMap("PolicyGroupNameList")]
            [Validation(Required=false)]
            public List<string> PolicyGroupNameList { get; set; }

            /// <summary>
            /// <para>The progress of creating the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The protocol.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HDX</description></item>
            /// <item><description>ASP</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The information about the enterprise resource groups.</para>
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
                /// <para>Resource group 01</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The type of the session.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SINGLE_SESSION</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>MULTIPLE_SESSION</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SINGLE_SESSION</para>
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <para>The session information about cloud computers connected by end users.</para>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsSessions> Sessions { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsSessions : TeaModel {
                /// <summary>
                /// <para>The ID of the end user that connects to the cloud computer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29615820929547****</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <para>The time when the cloud computer session was established.</para>
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
            /// <para>sp-gi007jgyc3kcey2bb</para>
            /// </summary>
            [NameInMap("SnapshotPolicyId")]
            [Validation(Required=false)]
            public string SnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>The name of the snapshot policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testSnapshotName</para>
            /// </summary>
            [NameInMap("SnapshotPolicyName")]
            [Validation(Required=false)]
            public string SnapshotPolicyName { get; set; }

            /// <summary>
            /// <para>The standard start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02-24T06:38:02Z</para>
            /// </summary>
            [NameInMap("StandardStartTime")]
            [Validation(Required=false)]
            public string StandardStartTime { get; set; }

            /// <summary>
            /// <para>The time when the cloud computer was first started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-06T08:31Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the cloud desktop supports hibernation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportHibernation")]
            [Validation(Required=false)]
            public bool? SupportHibernation { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>Details about the tags.</para>
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
            /// <para>Indicates whether disk encryption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key that is used when disk encryption is enabled. You can call the <a href="https://help.aliyun.com/document_detail/28951.html">ListKeys</a> operation to query the list of KMS keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddfa1d4****</para>
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

            /// <summary>
            /// <para>The zone type. Default value: <c>AvailabilityZone</c>. This value indicates Alibaba Cloud zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AvailabilityZone</para>
            /// </summary>
            [NameInMap("ZoneType")]
            [Validation(Required=false)]
            public string ZoneType { get; set; }

        }

        /// <summary>
        /// <para>The token that is used for the next query. If this parameter is left empty, all results are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
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
