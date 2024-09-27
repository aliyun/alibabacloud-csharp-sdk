// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeGlobalDesktopsResponseBody : TeaModel {
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public List<DescribeGlobalDesktopsResponseBodyDesktops> Desktops { get; set; }
        public class DescribeGlobalDesktopsResponseBodyDesktops : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>支持的客户端信息</para>
            /// </summary>
            [NameInMap("Clients")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsClients> Clients { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsClients : TeaModel {
                /// <summary>
                /// <para>客户端类型，取值：</para>
                /// <list type="bullet">
                /// <item><description>macos：Mac客户端</description></item>
                /// <item><description>ios：IOS客户端</description></item>
                /// <item><description>android：Android客户端</description></item>
                /// <item><description>html5：Web客户端</description></item>
                /// <item><description>windows：Windows客户端</description></item>
                /// <item><description>linux：Linux客户端</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// <para>客户端状态，取值：</para>
                /// <list type="bullet">
                /// <item><description>ON：允许登录</description></item>
                /// <item><description>OFF：不允许登录</description></item>
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
            /// <b>Example:</b>
            /// <para>Disconnected</para>
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-11-06T08:28Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dg-3uiojcc0j4kh7****</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd-gx2x1dhsmucyy****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testDesktopName</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            [NameInMap("DesktopTimers")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsDesktopTimers> DesktopTimers { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsDesktopTimers : TeaModel {
                [NameInMap("AllowClientSetting")]
                [Validation(Required=false)]
                public bool? AllowClientSetting { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0 0 0 ? * 1</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enforce")]
                [Validation(Required=false)]
                public bool? Enforce { get; set; }

                [NameInMap("ExecutionTime")]
                [Validation(Required=false)]
                public string ExecutionTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RESET_TYPE_BOTH</para>
                /// </summary>
                [NameInMap("ResetType")]
                [Validation(Required=false)]
                public string ResetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NoConnectShutdown</para>
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public string TimerType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd.basic.large</para>
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-jedbpr4sl9l37****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsDisks> Disks { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsDisks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>d-jedbpr4sl9l37****</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>User1</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-31T15:59Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("FotaUpdate")]
            [Validation(Required=false)]
            public DescribeGlobalDesktopsResponseBodyDesktopsFotaUpdate FotaUpdate { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsFotaUpdate : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Enterprise</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0.0-D-20220102.xxxx</para>
                /// </summary>
                [NameInMap("CurrentAppVersion")]
                [Validation(Required=false)]
                public string CurrentAppVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Force")]
                [Validation(Required=false)]
                public bool? Force { get; set; }

                /// <summary>
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
                /// <b>Example:</b>
                /// <para>testProject</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

                [NameInMap("ReleaseNoteEn")]
                [Validation(Required=false)]
                public string ReleaseNoteEn { get; set; }

                [NameInMap("ReleaseNoteJp")]
                [Validation(Required=false)]
                public string ReleaseNoteJp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("GpuMemory")]
            [Validation(Required=false)]
            public int? GpuMemory { get; set; }

            [NameInMap("HibernationBeta")]
            [Validation(Required=false)]
            public bool? HibernationBeta { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>m-4zfb6zj728hhr****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-07-13T15:59Z</para>
            /// </summary>
            [NameInMap("LastStartTime")]
            [Validation(Required=false)]
            public string LastStartTime { get; set; }

            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            [NameInMap("ManagementFlags")]
            [Validation(Required=false)]
            public List<string> ManagementFlags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.xx.xx</para>
            /// </summary>
            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pg-9cktlowtxfl6****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd-gx2x1dhsm****</para>
            /// </summary>
            [NameInMap("RealDesktopId")]
            [Validation(Required=false)]
            public string RealDesktopId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RegionLocation")]
            [Validation(Required=false)]
            public string RegionLocation { get; set; }

            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsSessions> Sessions { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsSessions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>User1</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-03-07T08:23Z</para>
                /// </summary>
                [NameInMap("EstablishmentTime")]
                [Validation(Required=false)]
                public string EstablishmentTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportHibernation")]
            [Validation(Required=false)]
            public bool? SupportHibernation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testDesktop</para>
            /// </summary>
            [NameInMap("UserCustomName")]
            [Validation(Required=false)]
            public string UserCustomName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJkZWZhdWx0IjpbIjIwMjItMDgtMTdUM****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4686A731-D601-548C-83E2-4CB6371E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
