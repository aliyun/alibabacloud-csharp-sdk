// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetDesktopGroupDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The cloud computers within the share.</para>
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public GetDesktopGroupDetailResponseBodyDesktops Desktops { get; set; }
        public class GetDesktopGroupDetailResponseBodyDesktops : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable batch-based automatic creation of cloud computers in the subscription cloud computer share.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: enables batch-based automatic creation of cloud computers.</description></item>
            /// <item><description>1: disables batch-based automatic creation of cloud computers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllowAutoSetup")]
            [Validation(Required=false)]
            public int? AllowAutoSetup { get; set; }

            /// <summary>
            /// <para>This parameter applies to pay-as-you-go cloud computer shares and specifies the number of standby cloud computers that can be reserved per cloud computer share. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: does not reserve any cloud computers.</description></item>
            /// <item><description>N: reserves N cloud computers (1≤ N ≤ 100).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllowBufferCount")]
            [Validation(Required=false)]
            public int? AllowBufferCount { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent sessions allowed per cloud computer within the multi-session many-to-many share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BindAmount")]
            [Validation(Required=false)]
            public int? BindAmount { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>The number of purchased cloud computers in the subscription share. Valid values: 0 to 200.</description></item>
            /// <item><description>The minimum initial number of cloud computers created in the pay-as-you-go share. Default value: 1. Valid values: 0 to <c>MaxDesktopsCount</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BuyDesktopsCount")]
            [Validation(Required=false)]
            public int? BuyDesktopsCount { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>for students</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// <para>The maximum period of time during which the session is connected. When the specified maximum period of time is reached, the session is automatically disconnected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60000</para>
            /// </summary>
            [NameInMap("ConnectDuration")]
            [Validation(Required=false)]
            public long? ConnectDuration { get; set; }

            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The time when the desktop group was created. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-06T08:28Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account that creates the cloud computer pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>155177335370****</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The category of the user disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// <para>The user disk capacity. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

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
            /// <para>The name of the cloud computer share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DesktopGroupDemo</para>
            /// </summary>
            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            /// <summary>
            /// <para>The ID of the directory or office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The type of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>The expiration date of the subscription cloud computer share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-31T15:59Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("ExpiredTimes")]
            [Validation(Required=false)]
            public List<string> ExpiredTimes { get; set; }

            /// <summary>
            /// <para>The number of vGPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

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
            /// <para>After an end user connects to a cloud computer, the session is established. If the system does not detect any inputs from the keyboard or mouse within the specified period of time, the session is closed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900000</para>
            /// </summary>
            [NameInMap("IdleDisconnectDuration")]
            [Validation(Required=false)]
            public long? IdleDisconnectDuration { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-4zfb6zj728hhr****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The amount of time to retain a session after it is disconnected. Unit: milliseconds. Valid values: 180000 to 345600000. That is, the session can be retained for 3 to 5760 minutes (4 days). If you specify the value to 0, the session is permanently retained.</para>
            /// <para>When a session is disconnected, take note of the following situations: If an end user does not resume the session within the specified duration, the session is closed and all unsaved data is cleared. If the end user resumes the session within the specified duration, the end user can still access data of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180000</para>
            /// </summary>
            [NameInMap("KeepDuration")]
            [Validation(Required=false)]
            public long? KeepDuration { get; set; }

            /// <summary>
            /// <para>The load balancing policy for the multi-session many-to-many share.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: depth-first.</description></item>
            /// <item><description>1: breadth-first.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LoadPolicy")]
            [Validation(Required=false)]
            public int? LoadPolicy { get; set; }

            /// <summary>
            /// <para>The maximum number of cloud computers allowed in the pay-as-you-go cloud computer share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxDesktopsCount")]
            [Validation(Required=false)]
            public int? MaxDesktopsCount { get; set; }

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
            /// <para>The number of cloud computers created in the initial batch within the subscription cloud computer share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinDesktopsCount")]
            [Validation(Required=false)]
            public int? MinDesktopsCount { get; set; }

            /// <summary>
            /// <para>The ID of the File Storage NAS (NAS) file system for the user data roaming feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0783b4****</para>
            /// </summary>
            [NameInMap("NasFileSystemID")]
            [Validation(Required=false)]
            public string NasFileSystemID { get; set; }

            /// <summary>
            /// <para>The name of the NAS file system for the user data roaming feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcd</para>
            /// </summary>
            [NameInMap("NasFileSystemName")]
            [Validation(Required=false)]
            public string NasFileSystemName { get; set; }

            /// <summary>
            /// <para>The ID of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-990541****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The name of the office network in which the cloud computer resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The office network type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PERSONAL: individual office network</description></item>
            /// <item><description>SIMPLE: convenience office network</description></item>
            /// <item><description>AD_CONNECTOR: enterprise Active Directory (AD) office network</description></item>
            /// <item><description>RAM: Resource Access Management (RAM)-based office network</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The ID of the cloud computer template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b-1se9fb37r5tfq****</para>
            /// </summary>
            [NameInMap("OwnBundleId")]
            [Validation(Required=false)]
            public string OwnBundleId { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BundleDemo</para>
            /// </summary>
            [NameInMap("OwnBundleName")]
            [Validation(Required=false)]
            public string OwnBundleName { get; set; }

            /// <summary>
            /// <para>The type of the cloud computer share.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: a one-to-many share.</description></item>
            /// <item><description>1: a many-to-many share.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public int? OwnType { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PostPaid: pay-as-you-go.</para>
            /// </description></item>
            /// <item><description><para>PrePaid: subscription.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The ID of the applied policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-9cktlowtxfl6****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The IDs of the applied policies.</para>
            /// </summary>
            [NameInMap("PolicyGroupIds")]
            [Validation(Required=false)]
            public List<string> PolicyGroupIds { get; set; }

            /// <summary>
            /// <para>The name of the applied policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// <para>The names of the applied policies.</para>
            /// </summary>
            [NameInMap("PolicyGroupNames")]
            [Validation(Required=false)]
            public List<string> PolicyGroupNames { get; set; }

            /// <summary>
            /// <para>Indicates whether user data roaming is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ProfileFollowSwitch")]
            [Validation(Required=false)]
            public bool? ProfileFollowSwitch { get; set; }

            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The threshold for the ratio of connected sessions, which triggers automatic scaling of cloud computers within the multi-session many-to-many share. To calculate the ratio of connected sessions, use the following formula:</para>
            /// <para><c>Ratio of connected sessions = Number of connected sessions/(Total number of cloud computers × Maximum number of sessions allowed for each cloud computer) × 100%</c>.</para>
            /// <para>If the session ratio exceeds the threshold, new cloud computers are provisioned. If it falls below the threshold, additional cloud computers are removed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("RatioThreshold")]
            [Validation(Required=false)]
            public float? RatioThreshold { get; set; }

            /// <summary>
            /// <para>The type of the resource. Only Elastic Compute Service (ECS) instances are supported.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>0: ECS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResType")]
            [Validation(Required=false)]
            public int? ResType { get; set; }

            /// <summary>
            /// <para>The disk reset type of the cloud computer.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: does not reset disks.</description></item>
            /// <item><description>1: resets only the system disk.</description></item>
            /// <item><description>2: resets only the user disk.</description></item>
            /// <item><description>3: resets the system disk and the user disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public int? ResetType { get; set; }

            /// <summary>
            /// <para>The scheduled tasks.</para>
            /// </summary>
            [NameInMap("ScaleTimerInfos")]
            [Validation(Required=false)]
            public List<GetDesktopGroupDetailResponseBodyDesktopsScaleTimerInfos> ScaleTimerInfos { get; set; }
            public class GetDesktopGroupDetailResponseBodyDesktopsScaleTimerInfos : TeaModel {
                /// <summary>
                /// <para>The number of cloud computers that you purchase in the cloud computer pool. This parameter is one of the auto scaling parameters. Valid values: 0 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("BuyResAmount")]
                [Validation(Required=false)]
                public int? BuyResAmount { get; set; }

                /// <summary>
                /// <para>The cron expression for the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 0 * * ?</para>
                /// </summary>
                [NameInMap("Cron")]
                [Validation(Required=false)]
                public string Cron { get; set; }

                /// <summary>
                /// <para>The duration that is retained after the session is disconnected. Unit: milliseconds. Valid values: 180000 to 345600000. That is, the session can be retained for 3 to 5760 minutes (4 days). If you specify the value to 0, the session is permanently retained.</para>
                /// <para>When a session is disconnected, take note of the following situations: If an end user does not resume the session within the specified duration, the session is closed and all unsaved data is cleared. If the end user resumes the session within the specified duration, the end user can still access data of the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600000</para>
                /// </summary>
                [NameInMap("KeepDuration")]
                [Validation(Required=false)]
                public long? KeepDuration { get; set; }

                /// <summary>
                /// <para>The load balancing policy for the multi-session many-to-many share.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: depth-first.</description></item>
                /// <item><description>1: breadth-first.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LoadPolicy")]
                [Validation(Required=false)]
                public int? LoadPolicy { get; set; }

                /// <summary>
                /// <para>The maximum number of cloud computers in the cloud computer pool. This parameter is one of the auto scaling parameters. Valid values: 0 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxResAmount")]
                [Validation(Required=false)]
                public int? MaxResAmount { get; set; }

                /// <summary>
                /// <para>The minimum number of cloud computers in the cloud computer pool. This parameter is one of the auto scaling parameters. Valid values: 0 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinResAmount")]
                [Validation(Required=false)]
                public int? MinResAmount { get; set; }

                /// <summary>
                /// <para>The threshold for the ratio of connected sessions, which triggers automatic scaling of cloud computers within the multi-session many-to-many share. To calculate the ratio of connected sessions, use the following formula:</para>
                /// <para><c>Ratio of connected sessions = Number of connected sessions/(Total number of cloud computers × Maximum number of sessions allowed for each cloud computer) × 100%</c>.</para>
                /// <para>If the session ratio exceeds the threshold, new cloud computers are provisioned. If it falls below the threshold, additional cloud computers are removed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("RatioThreshold")]
                [Validation(Required=false)]
                public float? RatioThreshold { get; set; }

                /// <summary>
                /// <para>The type of the scheduled task.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>drop: decline policy</description></item>
                /// <item><description>normal: normal policy</description></item>
                /// <item><description>peak: peak hour policy</description></item>
                /// <item><description>rise: rise policy</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>rise</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The status of the cloud computer share.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The cloud computer share is unpaid.</description></item>
            /// <item><description>1: The cloud computer share is normal.</description></item>
            /// <item><description>2: The cloud computer share expired, or your account has an overdue payment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The period of time before the idle cloud computer enters the Stopped state. If the specified value is reached, the cloud computer is automatically stopped. If an end user connects to the stopped cloud computer, the cloud computer automatically starts. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180000</para>
            /// </summary>
            [NameInMap("StopDuration")]
            [Validation(Required=false)]
            public long? StopDuration { get; set; }

            /// <summary>
            /// <para>The category of the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The system disk capacity. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The list of scheduled points in time for desktop group tasks.</para>
            /// </summary>
            [NameInMap("TimerInfos")]
            [Validation(Required=false)]
            public List<GetDesktopGroupDetailResponseBodyDesktopsTimerInfos> TimerInfos { get; set; }
            public class GetDesktopGroupDetailResponseBodyDesktopsTimerInfos : TeaModel {
                /// <summary>
                /// <para>The cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 58 11 ? * 2</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>Indicates whether the scheduled task is forcibly executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Forced")]
                [Validation(Required=false)]
                public bool? Forced { get; set; }

                /// <summary>
                /// <para>The status of the cloud computer pool.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: enabled</description></item>
                /// <item><description>2: disabled</description></item>
                /// <item><description>3: deleted</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The type of the scheduled task.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: scheduled reset</description></item>
                /// <item><description>2: scheduled startup</description></item>
                /// <item><description>3: scheduled stop</description></item>
                /// <item><description>4: scheduled restart</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public int? TimerType { get; set; }

            }

            /// <summary>
            /// <para>The information about the scheduling policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcd</para>
            /// </summary>
            [NameInMap("TimingStrategyInfo")]
            [Validation(Required=false)]
            public string TimingStrategyInfo { get; set; }

            /// <summary>
            /// <para>The version number of the cloud computer share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1B5268CE-5EB3-545F-9F38-A8BCF710****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
