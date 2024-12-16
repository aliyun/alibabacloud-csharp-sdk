// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the cloud desktops.</para>
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopsResponseBodyDesktops> Desktops { get; set; }
        public class DescribeDesktopsResponseBodyDesktops : TeaModel {
            /// <summary>
            /// <para>The number of sessions that are allowed for each cloud desktop in the multi-session desktop group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BindAmount")]
            [Validation(Required=false)]
            public int? BindAmount { get; set; }

            /// <summary>
            /// <para>The ID of the desktop template that is used to create the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b-2g65ljy4291vl****</para>
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// <para>The name of the desktop template that is used to create the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Name</para>
            /// </summary>
            [NameInMap("BundleName")]
            [Validation(Required=false)]
            public string BundleName { get; set; }

            /// <summary>
            /// <para>The billing method of the cloud desktop.</para>
            /// <para>Default value: PostPaid. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Postpaid: pay-as-you-go</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>PrePaid: subscription</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
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
            /// <para>The time when the cloud desktop was created.</para>
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

            /// <summary>
            /// <para>The ID of the desktop group to which the cloud desktop belongs. Default value: null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
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
            /// <para>testDesktopName</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The status of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// <para>The type of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd.basic.large</para>
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// <para>The directory ID. The value of this parameter is the same as the workspace ID that is indicated by the OfficeSiteId parameter.</para>
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
            /// <para>Details of the disks.</para>
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsDisks> Disks { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsDisks : TeaModel {
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
                /// <para>The performance level (PL) of the disk when an enhanced SSD (ESSD) is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL0</description></item>
                /// <item><description>PL1</description></item>
                /// <item><description>PL2</description></item>
                /// <item><description>PL3</description></item>
                /// </list>
                /// <para>For more information about the differences among ESSDs at different PLs, see <a href="https://help.aliyun.com/document_detail/122389.html">Enhanced SSDs</a>.</para>
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
            /// <para>The IDs of the end users who are authorized to connect to the cloud desktop.</para>
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// <para>The time when the subscription cloud desktop expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-31T15:59Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The information about the image version that the cloud desktop uses.</para>
            /// </summary>
            [NameInMap("FotaUpdate")]
            [Validation(Required=false)]
            public DescribeDesktopsResponseBodyDesktopsFotaUpdate FotaUpdate { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsFotaUpdate : TeaModel {
                /// <summary>
                /// <para>The current image version of the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0-D-20220102.000000</para>
                /// </summary>
                [NameInMap("CurrentAppVersion")]
                [Validation(Required=false)]
                public string CurrentAppVersion { get; set; }

                /// <summary>
                /// <para>The image version to which the cloud desktop can be updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0-R-20220307.190736</para>
                /// </summary>
                [NameInMap("NewAppVersion")]
                [Validation(Required=false)]
                public string NewAppVersion { get; set; }

                /// <summary>
                /// <para>The description of the image version to which the cloud desktop can be updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Upgrade package for testing 03-07</para>
                /// </summary>
                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

                /// <summary>
                /// <para>The English description of the image version to which the cloud desktop can be updated.</para>
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
            /// <para>Indicates whether the cloud desktop is a GPU-accelerated desktop.</para>
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
            /// <para>The version number of the GPU driver of the cloud desktop.</para>
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
            /// <para>The flag that is used to manage the cloud desktop.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Updating: The configurations of the cloud desktop are being updated.</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>NoFlag: No flags are available.</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoFlag</para>
            /// </summary>
            [NameInMap("ManagementFlag")]
            [Validation(Required=false)]
            public string ManagementFlag { get; set; }

            /// <summary>
            /// <para>The flags that are used to manage the cloud desktops.</para>
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
            /// <para>The ID of the secondary network interface controller (NIC) created by the RAM or Active Directory (AD) user in Elastic Desktop Service (EDS). You do not have permissions to modify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The IP address of the secondary NIC that is created by the RAM or AD user in EDS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.74.165</para>
            /// </summary>
            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The account type of the workspace.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SIMPLE: convenience account</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>AD_CONNECTOR: enterprise AD account</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) type of the workspace.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>standard</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>customized</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>basic</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
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

            /// <summary>
            /// <para>The information about the OS platform. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CentOS</description></item>
            /// <item><description>Ubuntu</description></item>
            /// <item><description>Windows Server 2016</description></item>
            /// <item><description>Windows Server 2019</description></item>
            /// <item><description>UOS</description></item>
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
            /// <para>The policy IDs.</para>
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
            /// <para>The policy names.</para>
            /// </summary>
            [NameInMap("PolicyGroupNameList")]
            [Validation(Required=false)]
            public List<string> PolicyGroupNameList { get; set; }

            /// <summary>
            /// <para>The progress when the cloud desktop was created.</para>
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
            /// <item><description><para>HDX: High-definition Experience (HDX) protocol</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>ASP: Adaptive Streaming Protocol (ASP) developed by Alibaba Cloud</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            [NameInMap("ResourceGroups")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsResourceGroups> ResourceGroups { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsResourceGroups : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

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
            /// <para>The information about the desktop sessions of end users.</para>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsSessions> Sessions { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsSessions : TeaModel {
                /// <summary>
                /// <para>The ID of the end user who logged on to the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29615820929547****</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <para>The time when the desktop session was established.</para>
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
            /// <para>The ID of the snapshot policy.</para>
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
            /// <para>The time when the cloud desktop was first started.</para>
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
            /// <para>The zone type. Default value: <b>AvailabilityZone</b>. This value indicates Alibaba Cloud zones.</para>
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

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

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
        /// <para>The total number of cloud desktops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
