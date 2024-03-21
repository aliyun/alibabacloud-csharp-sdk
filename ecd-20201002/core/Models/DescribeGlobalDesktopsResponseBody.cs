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
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// 支持的客户端信息
            /// </summary>
            [NameInMap("Clients")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsClients> Clients { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsClients : TeaModel {
                /// <summary>
                /// 客户端类型，取值：
                /// 
                /// - macos：Mac客户端
                /// - ios：IOS客户端
                /// - android：Android客户端
                /// - html5：Web客户端
                /// - windows：Windows客户端
                /// - linux：Linux客户端
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// 客户端状态，取值：
                /// 
                /// - ON：允许登录
                /// - OFF：不允许登录
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

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

                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                [NameInMap("Enforce")]
                [Validation(Required=false)]
                public bool? Enforce { get; set; }

                [NameInMap("ExecutionTime")]
                [Validation(Required=false)]
                public string ExecutionTime { get; set; }

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                [NameInMap("ResetType")]
                [Validation(Required=false)]
                public string ResetType { get; set; }

                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public string TimerType { get; set; }

            }

            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsDisks> Disks { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsDisks : TeaModel {
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("FotaUpdate")]
            [Validation(Required=false)]
            public DescribeGlobalDesktopsResponseBodyDesktopsFotaUpdate FotaUpdate { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsFotaUpdate : TeaModel {
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                [NameInMap("CurrentAppVersion")]
                [Validation(Required=false)]
                public string CurrentAppVersion { get; set; }

                [NameInMap("Force")]
                [Validation(Required=false)]
                public bool? Force { get; set; }

                [NameInMap("NewAppVersion")]
                [Validation(Required=false)]
                public string NewAppVersion { get; set; }

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

                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

            }

            [NameInMap("GpuMemory")]
            [Validation(Required=false)]
            public int? GpuMemory { get; set; }

            [NameInMap("HibernationBeta")]
            [Validation(Required=false)]
            public bool? HibernationBeta { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("LastStartTime")]
            [Validation(Required=false)]
            public string LastStartTime { get; set; }

            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            [NameInMap("ManagementFlags")]
            [Validation(Required=false)]
            public List<string> ManagementFlags { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            [NameInMap("RealDesktopId")]
            [Validation(Required=false)]
            public string RealDesktopId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopsResponseBodyDesktopsSessions> Sessions { get; set; }
            public class DescribeGlobalDesktopsResponseBodyDesktopsSessions : TeaModel {
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                [NameInMap("EstablishmentTime")]
                [Validation(Required=false)]
                public string EstablishmentTime { get; set; }

            }

            [NameInMap("SupportHibernation")]
            [Validation(Required=false)]
            public bool? SupportHibernation { get; set; }

            [NameInMap("UserCustomName")]
            [Validation(Required=false)]
            public string UserCustomName { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
