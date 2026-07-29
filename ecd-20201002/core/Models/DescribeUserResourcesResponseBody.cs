// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeUserResourcesResponseBody : TeaModel {
        [NameInMap("AgentBriefSummary")]
        [Validation(Required=false)]
        public DescribeUserResourcesResponseBodyAgentBriefSummary AgentBriefSummary { get; set; }
        public class DescribeUserResourcesResponseBodyAgentBriefSummary : TeaModel {
            [NameInMap("AgentBriefs")]
            [Validation(Required=false)]
            public List<DescribeUserResourcesResponseBodyAgentBriefSummaryAgentBriefs> AgentBriefs { get; set; }
            public class DescribeUserResourcesResponseBodyAgentBriefSummaryAgentBriefs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ENTERPRISE_JVS</para>
                /// </summary>
                [NameInMap("AgentPlatform")]
                [Validation(Required=false)]
                public string AgentPlatform { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OpenClaw</para>
                /// </summary>
                [NameInMap("AgentProvider")]
                [Validation(Required=false)]
                public string AgentProvider { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxx.png">https://xxx.png</a></para>
                /// </summary>
                [NameInMap("AvatarNoResourceUrl")]
                [Validation(Required=false)]
                public string AvatarNoResourceUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://abc.com/efg.png">https://abc.com/efg.png</a></para>
                /// </summary>
                [NameInMap("AvatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>JVS Claw</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Intelligent Evolution, Happy Shrimp Farming.</para>
                /// </summary>
                [NameInMap("SubTitle")]
                [Validation(Required=false)]
                public string SubTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://test.png">https://test.png</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to start the next query. An empty NextToken indicates that there is no next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of resource types that failed to be queried.</para>
        /// </summary>
        [NameInMap("QueryFailedResourceTypes")]
        [Validation(Required=false)]
        public List<string> QueryFailedResourceTypes { get; set; }

        /// <summary>
        /// <para>The ranking data version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1732869815062</para>
        /// </summary>
        [NameInMap("RankVersion")]
        [Validation(Required=false)]
        public long? RankVersion { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of resource details.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DescribeUserResourcesResponseBodyResources> Resources { get; set; }
        public class DescribeUserResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The access type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://wuying.aliyun.com/OpenIM/chat?desktopId=ecd-xxxxx">https://wuying.aliyun.com/OpenIM/chat?desktopId=ecd-xxxxx</a></para>
            /// </summary>
            [NameInMap("AgentImUrl")]
            [Validation(Required=false)]
            public string AgentImUrl { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>194101959****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The application ID. This parameter is specific to resources of the App type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-0001</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The cloud application authorization mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>App</para>
            /// </summary>
            [NameInMap("AuthMode")]
            [Validation(Required=false)]
            public string AuthMode { get; set; }

            /// <summary>
            /// <para>The secondary category of the resource. This parameter is specific to resources of the App type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            /// <summary>
            /// <para>The primary category of the resource. This parameter is specific to resources of the App type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CategoryType")]
            [Validation(Required=false)]
            public int? CategoryType { get; set; }

            /// <summary>
            /// <para>The cloud drive name. This parameter is specific to resources of the CloudDrive type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai+cds-695277****</para>
            /// </summary>
            [NameInMap("CdsName")]
            [Validation(Required=false)]
            public string CdsName { get; set; }

            /// <summary>
            /// <para>The centralized resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecds-0****</para>
            /// </summary>
            [NameInMap("CenterResourceId")]
            [Validation(Required=false)]
            public string CenterResourceId { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The list of client types supported by the resource.</para>
            /// </summary>
            [NameInMap("Clients")]
            [Validation(Required=false)]
            public List<DescribeUserResourcesResponseBodyResourcesClients> Clients { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesClients : TeaModel {
                /// <summary>
                /// <para>The client type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// <para>The support status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The connection properties in JSON string format. The client does not need to parse the content. The value is passed directly to the central resource management service when the application resource establishes a connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;authMode&quot;:&quot;App&quot;}</para>
            /// </summary>
            [NameInMap("ConnectionProperties")]
            [Validation(Required=false)]
            public string ConnectionProperties { get; set; }

            /// <summary>
            /// <para>The time when the resource was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-11T07:12:12Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The list of cloud desktop package information.</para>
            /// </summary>
            [NameInMap("DesktopDurationList")]
            [Validation(Required=false)]
            public List<DescribeUserResourcesResponseBodyResourcesDesktopDurationList> DesktopDurationList { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesDesktopDurationList : TeaModel {
                /// <summary>
                /// <para>The order instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mdp-0bxls4qpi6bl6****</para>
                /// </summary>
                [NameInMap("OrderInstanceId")]
                [Validation(Required=false)]
                public string OrderInstanceId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-17T07:01Z</para>
                /// </summary>
                [NameInMap("PackageCreationTime")]
                [Validation(Required=false)]
                public string PackageCreationTime { get; set; }

                /// <summary>
                /// <para>The expiration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-02-17T15:59Z</para>
                /// </summary>
                [NameInMap("PackageExpiredTime")]
                [Validation(Required=false)]
                public string PackageExpiredTime { get; set; }

                /// <summary>
                /// <para>The package ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mdp-0bxls4qpi6bl6****</para>
                /// </summary>
                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public string PackageId { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("PackageStatus")]
                [Validation(Required=false)]
                public string PackageStatus { get; set; }

                /// <summary>
                /// <para>The duration package type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL_PACKAGE</para>
                /// </summary>
                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                /// <summary>
                /// <para>The cloud desktop status policy after the monthly quota of the plan is used up.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Postpaid</para>
                /// </summary>
                [NameInMap("PackageUsedUpStrategy")]
                [Validation(Required=false)]
                public string PackageUsedUpStrategy { get; set; }

                /// <summary>
                /// <para>The end time of the current monthly package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-02-17T15:59Z</para>
                /// </summary>
                [NameInMap("PeriodEndTime")]
                [Validation(Required=false)]
                public string PeriodEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the current monthly package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-17T07:01Z</para>
                /// </summary>
                [NameInMap("PeriodStartTime")]
                [Validation(Required=false)]
                public string PeriodStartTime { get; set; }

                /// <summary>
                /// <para>The cap amount for the second-phase package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>199</para>
                /// </summary>
                [NameInMap("PostPaidLimitFee")]
                [Validation(Required=false)]
                public float? PostPaidLimitFee { get; set; }

                /// <summary>
                /// <para>The total duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>432000</para>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public long? TotalDuration { get; set; }

                /// <summary>
                /// <para>The used duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16850</para>
                /// </summary>
                [NameInMap("UsedDuration")]
                [Validation(Required=false)]
                public long? UsedDuration { get; set; }

            }

            /// <summary>
            /// <para>The list of Cloud Desktop scheduled task settings.</para>
            /// </summary>
            [NameInMap("DesktopTimers")]
            [Validation(Required=false)]
            public List<DescribeUserResourcesResponseBodyResourcesDesktopTimers> DesktopTimers { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesDesktopTimers : TeaModel {
                /// <summary>
                /// <para>Indicates whether the client is allowed to configure this setting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowClientSetting")]
                [Validation(Required=false)]
                public string AllowClientSetting { get; set; }

                /// <summary>
                /// <para>The cron expression of the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 30 13 ? * 1-7</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>Indicates whether the task is forcibly executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enforce")]
                [Validation(Required=false)]
                public bool? Enforce { get; set; }

                /// <summary>
                /// <para>The execution time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-21T11:37Z</para>
                /// </summary>
                [NameInMap("ExecutionTime")]
                [Validation(Required=false)]
                public string ExecutionTime { get; set; }

                /// <summary>
                /// <para>The interval of the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The operation type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hibernate</para>
                /// </summary>
                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <para>The reset type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RESET_TYPE_SYSTEM</para>
                /// </summary>
                [NameInMap("ResetType")]
                [Validation(Required=false)]
                public string ResetType { get; set; }

                /// <summary>
                /// <para>The task type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TimerBoot</para>
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public string TimerType { get; set; }

            }

            /// <summary>
            /// <para>The expiration time of subscription resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02-22T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The external domain ID. This parameter is specific to resources of the CloudDrive type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stg114510</para>
            /// </summary>
            [NameInMap("ExternalDomainId")]
            [Validation(Required=false)]
            public string ExternalDomainId { get; set; }

            /// <summary>
            /// <para>The external user ID. This parameter is specific to resources of the CloudDrive type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("ExternalUserId")]
            [Validation(Required=false)]
            public string ExternalUserId { get; set; }

            /// <summary>
            /// <para>The cloud desktop upgrade information.</para>
            /// </summary>
            [NameInMap("FotaUpdate")]
            [Validation(Required=false)]
            public DescribeUserResourcesResponseBodyResourcesFotaUpdate FotaUpdate { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesFotaUpdate : TeaModel {
                /// <summary>
                /// <para>The channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>The version number of the current image on the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.7.0-R-20250122.154826</para>
                /// </summary>
                [NameInMap("CurrentAppVersion")]
                [Validation(Required=false)]
                public string CurrentAppVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the upgrade is mandatory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Force")]
                [Validation(Required=false)]
                public bool? Force { get; set; }

                /// <summary>
                /// <para>The version number available for upgrade on the cloud desktop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.7.0-R-20250125.154826</para>
                /// </summary>
                [NameInMap("NewAppVersion")]
                [Validation(Required=false)]
                public string NewAppVersion { get; set; }

                /// <summary>
                /// <para>The component disk version number available for upgrade.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.6.9-R-20250123.153415</para>
                /// </summary>
                [NameInMap("NewDcdVersion")]
                [Validation(Required=false)]
                public string NewDcdVersion { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wuying-asp_single_session_desktop_win_x64</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The release note for the available upgrade version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>New version.</para>
                /// </summary>
                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

                /// <summary>
                /// <para>The English release note for the available upgrade version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>new version</para>
                /// </summary>
                [NameInMap("ReleaseNoteEn")]
                [Validation(Required=false)]
                public string ReleaseNoteEn { get; set; }

                /// <summary>
                /// <para>The Japanese release note for the available upgrade version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>新バージョン.</para>
                /// </summary>
                [NameInMap("ReleaseNoteJp")]
                [Validation(Required=false)]
                public string ReleaseNoteJp { get; set; }

                /// <summary>
                /// <para>The installation package size of the available upgrade version. Unit: KB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>474981930</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether cross-region access is supported. This parameter is specific to resources of the CloudDrive type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GlobalStatus")]
            [Validation(Required=false)]
            public bool? GlobalStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether an update is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasUpgrade")]
            [Validation(Required=false)]
            public bool? HasUpgrade { get; set; }

            /// <summary>
            /// <para>Indicates whether the resource is a hibernation beta version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HibernationBeta")]
            [Validation(Required=false)]
            public bool? HibernationBeta { get; set; }

            /// <summary>
            /// <para>The resource icon URL. This parameter is specific to resources of the App type.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com/icon.png">http://example.com/icon.png</a></para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>The last time the resource was started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-24T03:12:04Z</para>
            /// </summary>
            [NameInMap("LastStartTime")]
            [Validation(Required=false)]
            public string LastStartTime { get; set; }

            /// <summary>
            /// <para>The region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Singapore.</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The list of management statuses.</para>
            /// </summary>
            [NameInMap("ManagementStatuses")]
            [Validation(Required=false)]
            public List<string> ManagementStatuses { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai+dir-3367****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The order status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public string OrderStatus { get; set; }

            /// <summary>
            /// <para>The operating system platform information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows Server 2022</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The operating system platform description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows Genuine License.</para>
            /// </summary>
            [NameInMap("OsDescription")]
            [Validation(Required=false)]
            public string OsDescription { get; set; }

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
            /// <para>The operating system upgrade information.</para>
            /// </summary>
            [NameInMap("OsUpdate")]
            [Validation(Required=false)]
            public DescribeUserResourcesResponseBodyResourcesOsUpdate OsUpdate { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesOsUpdate : TeaModel {
                /// <summary>
                /// <para>The check ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wua-1740652957251743***</para>
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                /// <summary>
                /// <para>The patch number list information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KB2267***</para>
                /// </summary>
                [NameInMap("KbListString")]
                [Validation(Required=false)]
                public string KbListString { get; set; }

                /// <summary>
                /// <para>The number of packages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PackageCount")]
                [Validation(Required=false)]
                public int? PackageCount { get; set; }

                /// <summary>
                /// <para>The list of patch package information.</para>
                /// </summary>
                [NameInMap("Packages")]
                [Validation(Required=false)]
                public List<DescribeUserResourcesResponseBodyResourcesOsUpdatePackages> Packages { get; set; }
                public class DescribeUserResourcesResponseBodyResourcesOsUpdatePackages : TeaModel {
                    /// <summary>
                    /// <para>The patch description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Install this update to modify the files that are used to detect viruses, spyware, and other potentially unwanted software. Once installed, this item cannot be removed.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The patch number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KB2267***</para>
                    /// </summary>
                    [NameInMap("Kb")]
                    [Validation(Required=false)]
                    public string Kb { get; set; }

                    /// <summary>
                    /// <para>The patch title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Patch for ****.</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The update catalog URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://catalog.update.microsoft.com/home.aspx">https://catalog.update.microsoft.com/home.aspx</a></para>
                /// </summary>
                [NameInMap("UpdateCatalogUrl")]
                [Validation(Required=false)]
                public string UpdateCatalogUrl { get; set; }

            }

            /// <summary>
            /// <para>The product type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AndroidCloud</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

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
            /// <para>The real cloud desktop ID of the shared cloud desktop. This value exists only when the shared cloud desktop has an active session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-0001</para>
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

            /// <summary>
            /// <para>The region location.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mainland</para>
            /// </summary>
            [NameInMap("RegionLocation")]
            [Validation(Required=false)]
            public string RegionLocation { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dg-0****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-d19tya8zi4****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Center</para>
            /// </summary>
            [NameInMap("ResourceLevel")]
            [Validation(Required=false)]
            public string ResourceLevel { get; set; }

            /// <summary>
            /// <para>The resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName01</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The session status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Connected</para>
            /// </summary>
            [NameInMap("ResourceSessionStatus")]
            [Validation(Required=false)]
            public string ResourceSessionStatus { get; set; }

            /// <summary>
            /// <para>The resource status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Desktop</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

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
            /// <para>The list of resource user session information.</para>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeUserResourcesResponseBodyResourcesSessions> Sessions { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesSessions : TeaModel {
                [NameInMap("LastClientIp")]
                [Validation(Required=false)]
                public string LastClientIp { get; set; }

                /// <summary>
                /// <para>The nickname of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-001</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The time when the resource session was connected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-22T11:03:36Z</para>
                /// </summary>
                [NameInMap("ResourceSessionStartTime")]
                [Validation(Required=false)]
                public string ResourceSessionStartTime { get; set; }

                /// <summary>
                /// <para>The username logged on to the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user001</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The User Principal Name (UPN) of the user bound to the resource, if available. This value is populated only for the session of the currently queried user.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:benchmark_test@test.shenzhen">benchmark_test@test.shenzhen</a></para>
                /// </summary>
                [NameInMap("UserPrincipalName")]
                [Validation(Required=false)]
                public string UserPrincipalName { get; set; }

            }

            /// <summary>
            /// <para>The sub-billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("SubPayType")]
            [Validation(Required=false)]
            public string SubPayType { get; set; }

            [NameInMap("SupportAgentIm")]
            [Validation(Required=false)]
            public bool? SupportAgentIm { get; set; }

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
            /// <para>The list of supported action types. Currently supported only for cloud phones and cloud desktops (including shared cloud desktops).</para>
            /// </summary>
            [NameInMap("SupportedActions")]
            [Validation(Required=false)]
            public List<string> SupportedActions { get; set; }

            /// <summary>
            /// <para>The resource theme color. This parameter is specific to resources of the App type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>#FFFFFF</para>
            /// </summary>
            [NameInMap("ThemeColor")]
            [Validation(Required=false)]
            public string ThemeColor { get; set; }

            /// <summary>
            /// <para>The user-defined name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My cloud desktop</para>
            /// </summary>
            [NameInMap("UserCustomName")]
            [Validation(Required=false)]
            public string UserCustomName { get; set; }

            /// <summary>
            /// <para>The resource version. This parameter is specific to resources of the App type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resource version.</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
