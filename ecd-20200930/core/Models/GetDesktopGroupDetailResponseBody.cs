// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetDesktopGroupDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about shared cloud computers.</para>
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public GetDesktopGroupDetailResponseBodyDesktops Desktops { get; set; }
        public class GetDesktopGroupDetailResponseBodyDesktops : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic creation of cloud computers is allowed for subscription shared cloud computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllowAutoSetup")]
            [Validation(Required=false)]
            public int? AllowAutoSetup { get; set; }

            /// <summary>
            /// <para>This parameter applies only to pay-as-you-go shared cloud computers. It specifies the number of cloud computers that are always reserved in the powered-on and idle state, ready for connections. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllowBufferCount")]
            [Validation(Required=false)]
            public int? AllowBufferCount { get; set; }

            /// <summary>
            /// <para>The number of concurrent sessions allowed per cloud computer in multi-session shared cloud computers with multiple instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("BindAmount")]
            [Validation(Required=false)]
            public int? BindAmount { get; set; }

            /// <summary>
            /// <para>The initial number of cloud computers purchased. This parameter applies only to subscription shared cloud computers. Valid values: 0 to 200.</para>
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
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// <para>The maximum duration that a session can remain in the connected state. The session is automatically disconnected when this duration is reached. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600000</para>
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
            /// <para>The creation time. The time is in the ISO 8601 standard in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-06T08:28Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>155177335370****</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The user disk type.</para>
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
            /// <para>The ID of the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dg-3uiojcc0j4kh7****</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <para>The name of the shared cloud computer to query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CloudComputerPool01</para>
            /// </summary>
            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            /// <summary>
            /// <para>The directory ID (office network ID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The directory type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>The environment ID. This parameter is not publicly available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adifa****</para>
            /// </summary>
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            /// <summary>
            /// <para>The environment type. This parameter is not publicly available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The expiration time of the subscription shared cloud computers. The time follows the ISO 8601 standard in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-31T15:59Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The list of expiration times.</para>
            /// </summary>
            [NameInMap("ExpiredTimes")]
            [Validation(Required=false)]
            public List<string> ExpiredTimes { get; set; }

            /// <summary>
            /// <para>The number of GPU cores.</para>
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
            /// <para>The maximum idle duration after a user session is connected. If no keyboard or mouse operation is performed within this duration, the session is disconnected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900000</para>
            /// </summary>
            [NameInMap("IdleDisconnectDuration")]
            [Validation(Required=false)]
            public long? IdleDisconnectDuration { get; set; }

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
            /// <para>The duration for which a session is retained after disconnection. Unit: milliseconds. Valid values: 180000 (3 minutes) to 345600000 (4 days). A value of 0 indicates that the session is retained indefinitely.</para>
            /// <para>When a session is disconnected because the user actively disconnects or because of unexpected factors, the retention period starts from the moment of disconnection. If the user does not reconnect to the session within the retention period, the session is logged off and all unsaved data is destroyed. If the user successfully reconnects within the retention period, the user can still access the original session and the data that existed before the disconnection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180000</para>
            /// </summary>
            [NameInMap("KeepDuration")]
            [Validation(Required=false)]
            public long? KeepDuration { get; set; }

            /// <summary>
            /// <para>The load balancing policy for multi-session shared cloud computers with multiple instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LoadPolicy")]
            [Validation(Required=false)]
            public int? LoadPolicy { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>For pay-as-you-go shared cloud computers, this parameter specifies the maximum number of cloud computers that can be created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
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
            /// <list type="bullet">
            /// <item><description>For pay-as-you-go shared cloud computers, this parameter indicates the minimum number of cloud computers to create.</description></item>
            /// <item><description>For subscription shared cloud computers, this parameter is equivalent to BuyDesktopsCount, indicating the number of cloud computers initially purchased.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinDesktopsCount")]
            [Validation(Required=false)]
            public int? MinDesktopsCount { get; set; }

            /// <summary>
            /// <para>The ID of the NAS file system used for user data roaming.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0783b4****</para>
            /// </summary>
            [NameInMap("NasFileSystemID")]
            [Validation(Required=false)]
            public string NasFileSystemID { get; set; }

            /// <summary>
            /// <para>The name of the NAS file system used for user data roaming.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcd</para>
            /// </summary>
            [NameInMap("NasFileSystemName")]
            [Validation(Required=false)]
            public string NasFileSystemName { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-990541****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The name of the office network to which the shared cloud computer belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D Office Network</para>
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
            /// <para>The operating system type of the cloud computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The cloud computer template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b-1se9fb37r5tfq****</para>
            /// </summary>
            [NameInMap("OwnBundleId")]
            [Validation(Required=false)]
            public string OwnBundleId { get; set; }

            /// <summary>
            /// <para>The cloud computer template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BundleDemo</para>
            /// </summary>
            [NameInMap("OwnBundleName")]
            [Validation(Required=false)]
            public string OwnBundleName { get; set; }

            /// <summary>
            /// <para>The type of the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public int? OwnType { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The ID of the policy associated with the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-9cktlowtxfl6****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The list of policy IDs associated with the shared cloud computers.</para>
            /// </summary>
            [NameInMap("PolicyGroupIds")]
            [Validation(Required=false)]
            public List<string> PolicyGroupIds { get; set; }

            /// <summary>
            /// <para>The Policy Name associated with the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>All enabled policy</para>
            /// </summary>
            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// <para>The list of policy names associated with the shared cloud computers.</para>
            /// </summary>
            [NameInMap("PolicyGroupNames")]
            [Validation(Required=false)]
            public List<string> PolicyGroupNames { get; set; }

            /// <summary>
            /// <para>Indicates whether user data roaming is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ProfileFollowSwitch")]
            [Validation(Required=false)]
            public bool? ProfileFollowSwitch { get; set; }

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
            /// <para>The session occupancy threshold, used as the auto scaling trigger condition for multi-session shared cloud computers. The session occupancy is calculated by using the following formula:</para>
            /// <para><c>Session occupancy = Number of bound sessions / (Total number of cloud computer resources × Maximum number of sessions supported per cloud computer) × 100%</c></para>
            /// <para>When the session occupancy reaches this threshold, new cloud computers are created. When the session occupancy is below this threshold, excess cloud computers are deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.85</para>
            /// </summary>
            [NameInMap("RatioThreshold")]
            [Validation(Required=false)]
            public float? RatioThreshold { get; set; }

            /// <summary>
            /// <para>The resource type. Currently, only ECS is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResType")]
            [Validation(Required=false)]
            public int? ResType { get; set; }

            /// <summary>
            /// <para>The reset type of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public int? ResetType { get; set; }

            /// <summary>
            /// <para>The scheduled task information.</para>
            /// </summary>
            [NameInMap("ScaleTimerInfos")]
            [Validation(Required=false)]
            public List<GetDesktopGroupDetailResponseBodyDesktopsScaleTimerInfos> ScaleTimerInfos { get; set; }
            public class GetDesktopGroupDetailResponseBodyDesktopsScaleTimerInfos : TeaModel {
                /// <summary>
                /// <para>The number of cloud computers to purchase, which is one of the scaling policy parameters. Valid values: 0 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("BuyResAmount")]
                [Validation(Required=false)]
                public int? BuyResAmount { get; set; }

                /// <summary>
                /// <para>The cron expression of the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 0 * * ?</para>
                /// </summary>
                [NameInMap("Cron")]
                [Validation(Required=false)]
                public string Cron { get; set; }

                /// <summary>
                /// <para>The duration for which a session is retained after disconnection. Unit: milliseconds. Valid values: 180000 (3 minutes) to 345600000 (4 days). A value of 0 indicates that the session is always retained.</para>
                /// <para>When a session is disconnected because the user actively disconnects or because of other unexpected factors, the retention period starts from the moment of disconnection. If the user does not reconnect to the session within the retention period, the session is logged off and all unsaved data is destroyed. If the user successfully reconnects within the retention period, the user can still access the original session and the data that existed before the disconnection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180000</para>
                /// </summary>
                [NameInMap("KeepDuration")]
                [Validation(Required=false)]
                public long? KeepDuration { get; set; }

                /// <summary>
                /// <para>The load balancing policy for multi-session shared cloud computers with multiple instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LoadPolicy")]
                [Validation(Required=false)]
                public int? LoadPolicy { get; set; }

                /// <summary>
                /// <para>The maximum number of cloud computers, which is one of the scaling policy parameters. Valid values: 0 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxResAmount")]
                [Validation(Required=false)]
                public int? MaxResAmount { get; set; }

                /// <summary>
                /// <para>The minimum number of cloud computers, which is one of the scaling policy parameters. Valid values: 0 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinResAmount")]
                [Validation(Required=false)]
                public int? MinResAmount { get; set; }

                /// <summary>
                /// <para>The session occupancy threshold used as the trigger condition for auto scaling of multi-session shared cloud computers. The session occupancy is calculated by using the following formula:</para>
                /// <para><c>Session occupancy = Number of bound sessions / (Total number of cloud computer resources × Maximum number of sessions supported per cloud computer) × 100%</c></para>
                /// <para>When the session occupancy reaches this threshold, new cloud computers are created. When the session occupancy is below this threshold, excess cloud computers are deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.85</para>
                /// </summary>
                [NameInMap("RatioThreshold")]
                [Validation(Required=false)]
                public float? RatioThreshold { get; set; }

                /// <summary>
                /// <para>The type of the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rise</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The status of the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The idle shutdown duration. When the cloud computer has been idle for this duration, it is automatically shut down. If a user connects after shutdown, the cloud computer is automatically started. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180000</para>
            /// </summary>
            [NameInMap("StopDuration")]
            [Validation(Required=false)]
            public long? StopDuration { get; set; }

            /// <summary>
            /// <para>The system cloud disk type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The system cloud disk capacity. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The list of scheduled times.</para>
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
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The type of the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public int? TimerType { get; set; }

            }

            /// <summary>
            /// <para>The scheduled application information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcd</para>
            /// </summary>
            [NameInMap("TimingStrategyInfo")]
            [Validation(Required=false)]
            public string TimingStrategyInfo { get; set; }

            /// <summary>
            /// <para>The version number of the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1B5268CE-5EB3-545F-9F38-A8BCF710****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
