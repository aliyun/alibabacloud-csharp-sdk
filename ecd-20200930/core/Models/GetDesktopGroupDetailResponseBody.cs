// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetDesktopGroupDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Information about the cloud computer share.</para>
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public GetDesktopGroupDetailResponseBodyDesktops Desktops { get; set; }
        public class GetDesktopGroupDetailResponseBodyDesktops : TeaModel {
            /// <summary>
            /// <para>Whether to allow automatic creation of subscription cloud computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllowAutoSetup")]
            [Validation(Required=false)]
            public int? AllowAutoSetup { get; set; }

            /// <summary>
            /// <para>Number of pre-started, idle cloud computers reserved for immediate connection. Applies only to pay-as-you-go cloud computers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: No reservation</para>
            /// </description></item>
            /// <item><description><para>N: Reserve N cloud computer(s) (1 ≤ N ≤ 100)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllowBufferCount")]
            [Validation(Required=false)]
            public int? AllowBufferCount { get; set; }

            /// <summary>
            /// <para>Maximum concurrent sessions per cloud computer in multi-session, multi-cloud computer deployments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("BindAmount")]
            [Validation(Required=false)]
            public int? BindAmount { get; set; }

            /// <summary>
            /// <para>Initial purchase count for subscription cloud computers. Valid values: 0 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BuyDesktopsCount")]
            [Validation(Required=false)]
            public int? BuyDesktopsCount { get; set; }

            /// <summary>
            /// <para>Remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// <para>Maximum time a session remains connected. The session disconnects automatically when this duration is reached. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600000</para>
            /// </summary>
            [NameInMap("ConnectDuration")]
            [Validation(Required=false)]
            public long? ConnectDuration { get; set; }

            /// <summary>
            /// <para>vCPU count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-06T08:28Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Alibaba Cloud account ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>155177335370****</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>User disk type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// <para>User disk capacity in GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            /// <summary>
            /// <para>Cloud computer share ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dg-3uiojcc0j4kh7****</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer share that you want to query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CloudComputerPool01</para>
            /// </summary>
            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            /// <summary>
            /// <para>Directory ID (office network ID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>Directory type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>Expiration time for subscription cloud computers.</para>
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
            /// <para>Number of GPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            /// <summary>
            /// <para>GPU specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NVIDIA T4</para>
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <para>Time after which an idle session disconnects. If no keyboard or mouse activity occurs during this period, the session disconnects. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900000</para>
            /// </summary>
            [NameInMap("IdleDisconnectDuration")]
            [Validation(Required=false)]
            public long? IdleDisconnectDuration { get; set; }

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
            /// <para>Time to keep a disconnected session active. Unit: milliseconds. Valid range: 180000 (3 minutes) to 345600000 (4 days). A value of 0 means keep indefinitely.</para>
            /// <para>If a session disconnects due to user action or other reasons, the timer starts at disconnection. If no reconnection occurs within this duration, the session logs off and unsaved data is destroyed. If the user reconnects successfully within this duration, they resume the original session and access all previously saved data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180000</para>
            /// </summary>
            [NameInMap("KeepDuration")]
            [Validation(Required=false)]
            public long? KeepDuration { get; set; }

            /// <summary>
            /// <para>Traffic steering policy for multi-session, multi-cloud computer deployments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LoadPolicy")]
            [Validation(Required=false)]
            public int? LoadPolicy { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><para>For pay-as-you-go cloud computers, this is the maximum number of cloud computers that can be created.</para>
            /// </description></item>
            /// <item><description><para>For subscription cloud computers, this is the sum of the initial purchase count (<c>BuyDesktopsCount</c>) and the number of cloud computers allowed for automatic creation.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxDesktopsCount")]
            [Validation(Required=false)]
            public int? MaxDesktopsCount { get; set; }

            /// <summary>
            /// <para>Memory size in MiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><para>For pay-as-you-go cloud computers, this is the minimum number of cloud computers to create.</para>
            /// </description></item>
            /// <item><description><para>For subscription cloud computers, this equals <c>BuyDesktopsCount</c>, the initial purchase count.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinDesktopsCount")]
            [Validation(Required=false)]
            public int? MinDesktopsCount { get; set; }

            /// <summary>
            /// <para>NAS file system ID used for user profile roaming.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0783b4****</para>
            /// </summary>
            [NameInMap("NasFileSystemID")]
            [Validation(Required=false)]
            public string NasFileSystemID { get; set; }

            /// <summary>
            /// <para>NAS file system name used for user profile roaming.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcd</para>
            /// </summary>
            [NameInMap("NasFileSystemName")]
            [Validation(Required=false)]
            public string NasFileSystemName { get; set; }

            /// <summary>
            /// <para>Office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-990541****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>Name of the office network where the cloud computer share resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>Account system type of the office network.</para>
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
            /// <para>Cloud computer template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b-1se9fb37r5tfq****</para>
            /// </summary>
            [NameInMap("OwnBundleId")]
            [Validation(Required=false)]
            public string OwnBundleId { get; set; }

            /// <summary>
            /// <para>Cloud computer template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BundleDemo</para>
            /// </summary>
            [NameInMap("OwnBundleName")]
            [Validation(Required=false)]
            public string OwnBundleName { get; set; }

            /// <summary>
            /// <para>Cloud computer share type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public int? OwnType { get; set; }

            /// <summary>
            /// <para>Billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>ID of the policy associated with the cloud computer share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-9cktlowtxfl6****</para>
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// <para>The IDs of the policies that are associated with the cloud computer share.</para>
            /// </summary>
            [NameInMap("PolicyGroupIds")]
            [Validation(Required=false)]
            public List<string> PolicyGroupIds { get; set; }

            /// <summary>
            /// <para>The name of the policy that is associated with the cloud computer share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>All enabled policy</para>
            /// </summary>
            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// <para>A list of policy names associated with cloud computer share.</para>
            /// </summary>
            [NameInMap("PolicyGroupNames")]
            [Validation(Required=false)]
            public List<string> PolicyGroupNames { get; set; }

            /// <summary>
            /// <para>Whether to enable user profile roaming.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ProfileFollowSwitch")]
            [Validation(Required=false)]
            public bool? ProfileFollowSwitch { get; set; }

            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>Session occupancy threshold used to trigger auto scaling for multi-session, multi-cloud computer deployments. Session occupancy is calculated as:</para>
            /// <para><c>Session occupancy = (Bound sessions / (Total cloud computers × Max sessions per cloud computer)) × 100%</c></para>
            /// <para>When occupancy reaches this threshold, new cloud computers are created. When occupancy falls below this threshold, excess cloud computers are deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.85</para>
            /// </summary>
            [NameInMap("RatioThreshold")]
            [Validation(Required=false)]
            public float? RatioThreshold { get; set; }

            /// <summary>
            /// <para>Resource type. Only Elastic Compute Service (ECS) is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResType")]
            [Validation(Required=false)]
            public int? ResType { get; set; }

            /// <summary>
            /// <para>Cloud computer reset type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public int? ResetType { get; set; }

            /// <summary>
            /// <para>Scheduled scaling task information.</para>
            /// </summary>
            [NameInMap("ScaleTimerInfos")]
            [Validation(Required=false)]
            public List<GetDesktopGroupDetailResponseBodyDesktopsScaleTimerInfos> ScaleTimerInfos { get; set; }
            public class GetDesktopGroupDetailResponseBodyDesktopsScaleTimerInfos : TeaModel {
                /// <summary>
                /// <para>Scaling parameter: Number of cloud computers to buy. Valid values: 0 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("BuyResAmount")]
                [Validation(Required=false)]
                public int? BuyResAmount { get; set; }

                /// <summary>
                /// <para>Cron expression for the scheduled scaling task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 0 * * ?</para>
                /// </summary>
                [NameInMap("Cron")]
                [Validation(Required=false)]
                public string Cron { get; set; }

                /// <summary>
                /// <para>Time to keep a disconnected session active. Unit: milliseconds. Valid range: 180000 (3 minutes) to 345600000 (4 days). A value of 0 means keep indefinitely.</para>
                /// <para>If a session disconnects due to user action or other reasons, the timer starts at disconnection. If no reconnection occurs within this duration, the session logs off and unsaved data is destroyed. If the user reconnects successfully within this duration, they resume the original session and access all previously saved data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180000</para>
                /// </summary>
                [NameInMap("KeepDuration")]
                [Validation(Required=false)]
                public long? KeepDuration { get; set; }

                /// <summary>
                /// <para>Traffic steering policy for multi-session, multi-cloud computer deployments.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LoadPolicy")]
                [Validation(Required=false)]
                public int? LoadPolicy { get; set; }

                /// <summary>
                /// <para>Scaling parameter: Maximum number of cloud computers. Valid values: 0 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxResAmount")]
                [Validation(Required=false)]
                public int? MaxResAmount { get; set; }

                /// <summary>
                /// <para>Scaling parameter: Minimum number of cloud computers. Valid values: 0 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinResAmount")]
                [Validation(Required=false)]
                public int? MinResAmount { get; set; }

                /// <summary>
                /// <para>Session occupancy threshold used to trigger auto scaling for multi-session, multi-cloud computer deployments. Session occupancy is calculated as:</para>
                /// <para><c>Session occupancy = (Bound sessions / (Total cloud computers × Max sessions per cloud computer)) × 100%</c></para>
                /// <para>When occupancy reaches this threshold, new cloud computers are created. When occupancy falls below this threshold, excess cloud computers are deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.85</para>
                /// </summary>
                [NameInMap("RatioThreshold")]
                [Validation(Required=false)]
                public float? RatioThreshold { get; set; }

                /// <summary>
                /// <para>Scheduled scaling task type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rise</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Cloud computer share status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Idle shutdown time. The cloud computer shuts down automatically after being idle for this duration. If a user connects after shutdown, the cloud computer starts automatically. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180000</para>
            /// </summary>
            [NameInMap("StopDuration")]
            [Validation(Required=false)]
            public long? StopDuration { get; set; }

            /// <summary>
            /// <para>System disk type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>System disk capacity in GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>List of scheduled tasks.</para>
            /// </summary>
            [NameInMap("TimerInfos")]
            [Validation(Required=false)]
            public List<GetDesktopGroupDetailResponseBodyDesktopsTimerInfos> TimerInfos { get; set; }
            public class GetDesktopGroupDetailResponseBodyDesktopsTimerInfos : TeaModel {
                /// <summary>
                /// <para>Cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 58 11 ? * 2</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>Whether to force execute this scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Forced")]
                [Validation(Required=false)]
                public bool? Forced { get; set; }

                /// <summary>
                /// <para>Status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>Scheduled task type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public int? TimerType { get; set; }

            }

            /// <summary>
            /// <para>Scheduled application information.</para>
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
            /// <para>2</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1B5268CE-5EB3-545F-9F38-A8BCF710****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
