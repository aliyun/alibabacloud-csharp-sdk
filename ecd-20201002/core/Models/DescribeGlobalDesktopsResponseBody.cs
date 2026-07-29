// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeGlobalDesktopsResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed cloud desktop information.</para>
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public List<DescribeGlobalDesktopsResponseBodyDesktops> Desktops { get; set; }
        public class DescribeGlobalDesktopsResponseBodyDesktops : TeaModel {
            /// <summary>
            /// <para>Billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>Supported client information.</para>
            /// </summary>
            [NameInMap("Clients")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsClients> Clients { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsClients : TeaModel {
                /// <summary>
                /// <para>Client type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// <para>Client status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Endpoint connection status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Disconnected</para>
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// <para>Number of CPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>Time when the cloud desktop was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-06T08:28Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Shared cloud desktop ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dg-3uiojcc0j4kh7****</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <para>Cloud desktop ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-gx2x1dhsmucyy****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>Cloud desktop name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDesktopName</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>Cloud desktop status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// <para>Cloud desktop timer object.</para>
            /// </summary>
            [NameInMap("DesktopTimers")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsDesktopTimers> DesktopTimers { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsDesktopTimers : TeaModel {
                /// <summary>
                /// <para>Whether clients can set policies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowClientSetting")]
                [Validation(Required=false)]
                public bool? AllowClientSetting { get; set; }

                /// <summary>
                /// <para>Cron expression for the scheduled task.</para>
                /// <para>Example: <c>0 0 4 1/1 * ?</c> means run daily starting at 4:00 AM on the first day of each month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 0 ? * 1</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>Whether to enforce execution. If <c>true</c>, the scheduled task runs regardless of cloud desktop or connection status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enforce")]
                [Validation(Required=false)]
                public bool? Enforce { get; set; }

                /// <summary>
                /// <para>Task execution time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-31T15:59Z</para>
                /// </summary>
                [NameInMap("ExecutionTime")]
                [Validation(Required=false)]
                public string ExecutionTime { get; set; }

                /// <summary>
                /// <para>Time interval, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>Scheduled task type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHUTDOWN</para>
                /// </summary>
                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <para>Reset type for reset tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RESET_TYPE_BOTH</para>
                /// </summary>
                [NameInMap("ResetType")]
                [Validation(Required=false)]
                public string ResetType { get; set; }

                /// <summary>
                /// <para>Scheduled task type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NoConnectShutdown</para>
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public string TimerType { get; set; }

            }

            /// <summary>
            /// <para>Cloud desktop specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd.basic.large</para>
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// <para>Office site ID. Same as <c>OfficeSiteId</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-jedbpr4sl9l37****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>Disk information.</para>
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsDisks> Disks { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsDisks : TeaModel {
                /// <summary>
                /// <para>Disk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-jedbpr4sl9l37****</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>Disk size, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// <para>Disk type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            /// <summary>
            /// <para>End user name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>List of end users.</para>
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// <para>Time when the cloud desktop expires.</para>
            /// <list type="bullet">
            /// <item><description><para>Valid for subscription cloud desktops.</para>
            /// </description></item>
            /// <item><description><para>For pay-as-you-go cloud desktops, always returns <c>2099-12-31T15:59Z</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-31T15:59Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>Image update information.</para>
            /// </summary>
            [NameInMap("FotaUpdate")]
            [Validation(Required=false)]
            public DescribeGlobalDesktopsResponseBodyDesktopsFotaUpdate FotaUpdate { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsFotaUpdate : TeaModel {
                /// <summary>
                /// <para>Subscription channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enterprise</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Current version number of the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0-D-20220102.xxxx</para>
                /// </summary>
                [NameInMap("CurrentAppVersion")]
                [Validation(Required=false)]
                public string CurrentAppVersion { get; set; }

                /// <summary>
                /// <para>Whether the upgrade is forced.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Force")]
                [Validation(Required=false)]
                public bool? Force { get; set; }

                /// <summary>
                /// <para>New application version number after the update.</para>
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
                /// <para>Project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testProject</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>Description of the upgradable version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test upgrade package 03-07</para>
                /// </summary>
                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

                /// <summary>
                /// <para>English description of the upgradable version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Release note</para>
                /// </summary>
                [NameInMap("ReleaseNoteEn")]
                [Validation(Required=false)]
                public string ReleaseNoteEn { get; set; }

                /// <summary>
                /// <para>Japanese description of the upgradable version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>リリースノート</para>
                /// </summary>
                [NameInMap("ReleaseNoteJp")]
                [Validation(Required=false)]
                public string ReleaseNoteJp { get; set; }

                /// <summary>
                /// <para>Size of the upgradable version package, in MiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

            }

            /// <summary>
            /// <para>GPU memory size. Valid for GPU cloud desktops. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("GpuMemory")]
            [Validation(Required=false)]
            public int? GpuMemory { get; set; }

            /// <summary>
            /// <para>Whether this is a hibernation beta version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HibernationBeta")]
            [Validation(Required=false)]
            public bool? HibernationBeta { get; set; }

            /// <summary>
            /// <para>Host name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>Image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-4zfb6zj728hhr****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>Last startup time — the most recent time the cloud desktop started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-13T15:59Z</para>
            /// </summary>
            [NameInMap("LastStartTime")]
            [Validation(Required=false)]
            public string LastStartTime { get; set; }

            /// <summary>
            /// <para>Region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Shanghai)</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>List of cloud desktop management statuses.</para>
            /// </summary>
            [NameInMap("ManagementFlags")]
            [Validation(Required=false)]
            public List<string> ManagementFlags { get; set; }

            /// <summary>
            /// <para>Cloud desktop memory size, in MiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>Network interface IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            /// <summary>
            /// <para>Office site ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>Operating system type</para>
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
            /// <para>Operating system type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>Operating system platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ubuntu</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>Cloud desktop policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-9cktlowtxfl6****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>Protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>If this is a shared cloud desktop and a real cloud desktop has been assigned, this field shows the cloud desktop ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-gx2x1dhsm****</para>
            /// </summary>
            [NameInMap("RealDesktopId")]
            [Validation(Required=false)]
            public string RealDesktopId { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
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
            /// <para>Session type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SINGLE_SESSION</para>
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <para>List of session information.</para>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsSessions> Sessions { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsSessions : TeaModel {
                /// <summary>
                /// <para>End user information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alice</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <para>Time when the session was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-07T08:23Z</para>
                /// </summary>
                [NameInMap("EstablishmentTime")]
                [Validation(Required=false)]
                public string EstablishmentTime { get; set; }

            }

            /// <summary>
            /// <para>Whether hibernation is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportHibernation")]
            [Validation(Required=false)]
            public bool? SupportHibernation { get; set; }

            /// <summary>
            /// <para>User-defined cloud desktop name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDesktop</para>
            /// </summary>
            [NameInMap("UserCustomName")]
            [Validation(Required=false)]
            public string UserCustomName { get; set; }

        }

        /// <summary>
        /// <para>Token that marks the start of the next query. If NextToken is empty, no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJkZWZhdWx0IjpbIjIwMjItMDgtMTdUM****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4686A731-D601-548C-83E2-4CB6371E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
