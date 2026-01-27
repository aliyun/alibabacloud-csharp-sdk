// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeGlobalDesktopsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the cloud computer.</para>
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public List<DescribeGlobalDesktopsResponseBodyDesktops> Desktops { get; set; }
        public class DescribeGlobalDesktopsResponseBodyDesktops : TeaModel {
            /// <summary>
            /// <para>The billing method of the cloud computer pool.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>PostPaid: pay-as-you-go</description></item>
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
            /// <para>The information about the supported clients.</para>
            /// </summary>
            [NameInMap("Clients")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsClients> Clients { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsClients : TeaModel {
                /// <summary>
                /// <para>The client type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>html5: the web client.</description></item>
                /// <item><description>android: the Android client.</description></item>
                /// <item><description>linux: Linux client.</description></item>
                /// <item><description>ios: the iOS client.</description></item>
                /// <item><description>windows: the Windows client.</description></item>
                /// <item><description>macos: the macOS client.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// <para>The status of the client.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OFF: does not allow logon.</description></item>
                /// <item><description>ON: allows logon.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The state of the endpoint connection.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Connected</description></item>
            /// <item><description>Disconnecting</description></item>
            /// <item><description>Pending.</description></item>
            /// <item><description>Connecting.</description></item>
            /// <item><description>Disconnected.</description></item>
            /// <item><description>Deleting</description></item>
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
            /// <para>The ID of the cloud computer share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dg-3uiojcc0j4kh7****</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <para>The cloud compute ID.</para>
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
            /// <para>The cloud computer timer object.</para>
            /// </summary>
            [NameInMap("DesktopTimers")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsDesktopTimers> DesktopTimers { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsDesktopTimers : TeaModel {
                /// <summary>
                /// <para>Whether to allow clients to set policies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowClientSetting")]
                [Validation(Required=false)]
                public bool? AllowClientSetting { get; set; }

                /// <summary>
                /// <para>The CRON expression for the scheduled task.</para>
                /// <para>For example, a <c>0 0 4 1/1 * ?</c> indicates that the operation is executed every day from 4:00 a.m. on the first day of each month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 0 ? * 1</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>Indicates whether to forcibly execute the scheduled task. To <c>true</c> indicates that cloud computer and connection status detection are ignored, and scheduled tasks are forcibly executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enforce")]
                [Validation(Required=false)]
                public bool? Enforce { get; set; }

                /// <summary>
                /// <para>The task duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-31T15:59Z</para>
                /// </summary>
                [NameInMap("ExecutionTime")]
                [Validation(Required=false)]
                public string ExecutionTime { get; set; }

                /// <summary>
                /// <para>The interval at which the monitoring data was queried. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The type of the scheduled task.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>HIBERNATE</description></item>
                /// <item><description>SHUTDOWN</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SHUTDOWN</para>
                /// </summary>
                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <para>For a reset task, you must set the reset type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RESET_TYPE_SYSTEM: resets the system disk.</description></item>
                /// <item><description>RESET_TYPE_USER_DISK: resets the data disk.</description></item>
                /// <item><description>RESET_TYPE_BOTH: resets the system disk and data disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RESET_TYPE_BOTH</para>
                /// </summary>
                [NameInMap("ResetType")]
                [Validation(Required=false)]
                public string ResetType { get; set; }

                /// <summary>
                /// <para>The type of the scheduled task.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NoOperationDisconnect: scheduled disconnection upon inactivity.</description></item>
                /// <item><description>NoConnectShutdown: connectionless shutdown.</description></item>
                /// <item><description>TimerBoot: scheduled start.</description></item>
                /// <item><description>TimerReset: scheduled reset.</description></item>
                /// <item><description>NoOperationShutdown: scheduled shutdown upon inactivity.</description></item>
                /// <item><description>TimerShutdown: Stops the cloud computers on schedule.</description></item>
                /// <item><description>NoOperationReboot: scheduled restart upon inactivity.</description></item>
                /// <item><description>TimerReboot: scheduled restart.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoConnectShutdown</para>
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public string TimerType { get; set; }

            }

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
            /// <para>The network ID of the office. Same as <c>OfficeSiteId</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-jedbpr4sl9l37****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The disks.</para>
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsDisks> Disks { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsDisks : TeaModel {
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
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description>SYSTEM: a system disk.</description></item>
                /// <item><description>DATA: a data disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            /// <summary>
            /// <para>The names of end users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User1</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The list of end user.</para>
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// <para>The expiration time of the cloud computer.</para>
            /// <list type="bullet">
            /// <item><description>For a cloud computer that is a package year or month, the return value is meaningful.</description></item>
            /// <item><description>For pay-as-you-go cloud computers, the <c>2099-12-31T15:59Z</c> is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-31T15:59Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The information about image update.</para>
            /// </summary>
            [NameInMap("FotaUpdate")]
            [Validation(Required=false)]
            public DescribeGlobalDesktopsResponseBodyDesktopsFotaUpdate FotaUpdate { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsFotaUpdate : TeaModel {
                /// <summary>
                /// <para>Subscription Channel</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enterprise</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>The current version number of the cloud computer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0-D-20220102.xxxx</para>
                /// </summary>
                [NameInMap("CurrentAppVersion")]
                [Validation(Required=false)]
                public string CurrentAppVersion { get; set; }

                /// <summary>
                /// <para>Whether to force upgrade.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Force")]
                [Validation(Required=false)]
                public bool? Force { get; set; }

                /// <summary>
                /// <para>The version number of the application after the update.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0-R-20220307.xxxx</para>
                /// </summary>
                [NameInMap("NewAppVersion")]
                [Validation(Required=false)]
                public string NewAppVersion { get; set; }

                [NameInMap("NewDcdVersion")]
                [Validation(Required=false)]
                public string NewDcdVersion { get; set; }

                /// <summary>
                /// <para>The name of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testProject</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The description of the version that can be upgraded.</para>
                /// </summary>
                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

                /// <summary>
                /// <para>The English release note for the new image version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Release note</para>
                /// </summary>
                [NameInMap("ReleaseNoteEn")]
                [Validation(Required=false)]
                public string ReleaseNoteEn { get; set; }

                /// <summary>
                /// <para>The Japanese release note for the new image version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>リリースノート</para>
                /// </summary>
                [NameInMap("ReleaseNoteJp")]
                [Validation(Required=false)]
                public string ReleaseNoteJp { get; set; }

                /// <summary>
                /// <para>The size of the update package for the cloud computer image. Unit: MiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

            }

            /// <summary>
            /// <para>The GPU memory size. For GPU-accelerated cloud computers, this return value is significant. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("GpuMemory")]
            [Validation(Required=false)]
            public int? GpuMemory { get; set; }

            /// <summary>
            /// <para>Indicates whether this is a beta version of the hibernation feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HibernationBeta")]
            [Validation(Required=false)]
            public bool? HibernationBeta { get; set; }

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
            /// <para>The time when the cloud desktop was last started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-13T15:59Z</para>
            /// </summary>
            [NameInMap("LastStartTime")]
            [Validation(Required=false)]
            public string LastStartTime { get; set; }

            /// <summary>
            /// <para>The region name.</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The list of cloud computer status.</para>
            /// </summary>
            [NameInMap("ManagementFlags")]
            [Validation(Required=false)]
            public List<string> ManagementFlags { get; set; }

            /// <summary>
            /// <para>The memory of the cloud computer. Unit: MiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The IP address of the ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.xx.xx</para>
            /// </summary>
            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            /// <summary>
            /// <para>The IDs of the office networks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>OS Type</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("OsDescription")]
            [Validation(Required=false)]
            public string OsDescription { get; set; }

            /// <summary>
            /// <para>The operating system.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Linux</description></item>
            /// <item><description>Windows</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The OS platform.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Ubuntu</description></item>
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
            /// <para>The cloud computer policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-9cktlowtxfl6****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The type of the protocol.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>High-definition Experience (HDX)</description></item>
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
            /// <para>If a shared cloud computer is assigned a real cloud computer, the ID of the cloud computer is displayed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-gx2x1dhsm****</para>
            /// </summary>
            [NameInMap("RealDesktopId")]
            [Validation(Required=false)]
            public string RealDesktopId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RegionLocation")]
            [Validation(Required=false)]
            public string RegionLocation { get; set; }

            /// <summary>
            /// <para>The type of the session.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>SINGLE_SESSION</description></item>
            /// <item><description>MULTIPLE_SESSION</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SINGLE_SESSION</para>
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <para>The list of session information.</para>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsSessions> Sessions { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsSessions : TeaModel {
                /// <summary>
                /// <para>End user information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>User1</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <para>The time when the session was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-07T08:23Z</para>
                /// </summary>
                [NameInMap("EstablishmentTime")]
                [Validation(Required=false)]
                public string EstablishmentTime { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether hibernation is supported.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: supported</description></item>
            /// <item><description>false: not supported</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportHibernation")]
            [Validation(Required=false)]
            public bool? SupportHibernation { get; set; }

            /// <summary>
            /// <para>The custom cloud computer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDesktop</para>
            /// </summary>
            [NameInMap("UserCustomName")]
            [Validation(Required=false)]
            public string UserCustomName { get; set; }

        }

        /// <summary>
        /// <para>The token used to start the next query. If NextToken is empty, it indicates that there is no next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJkZWZhdWx0IjpbIjIwMjItMDgtMTdUM****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4686A731-D601-548C-83E2-4CB6371E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
