// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeUserResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>返回最大数量。</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource types that failed to be queried.</para>
        /// </summary>
        [NameInMap("QueryFailedResourceTypes")]
        [Validation(Required=false)]
        public List<string> QueryFailedResourceTypes { get; set; }

        /// <summary>
        /// <para>The version number of the ranking data.</para>
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
        /// <para>The resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DescribeUserResourcesResponseBodyResources> Resources { get; set; }
        public class DescribeUserResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The access type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INTERNET: access over the Internet.</description></item>
            /// <item><description>VPC: access over an enterprise VPC.</description></item>
            /// <item><description>ANY: access over the Internet or an enterprise VPC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>194101959****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The app ID. This parameter is for apps only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-0001</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The authorization mode of the cloud app.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>App: authorizes access to apps.</description></item>
            /// <item><description>AppInstanceGroup: authorizes access to delivery groups.</description></item>
            /// <item><description>Session: authorizes access to sessions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>App</para>
            /// </summary>
            [NameInMap("AuthMode")]
            [Validation(Required=false)]
            public string AuthMode { get; set; }

            /// <summary>
            /// <para>The level-2 resource category. This parameter is for apps only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            /// <summary>
            /// <para>The level-1 resource category. This parameter is for apps only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CategoryType")]
            [Validation(Required=false)]
            public int? CategoryType { get; set; }

            /// <summary>
            /// <para>The drive name. This parameter is for enterprise drives only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai+cds-695277****</para>
            /// </summary>
            [NameInMap("CdsName")]
            [Validation(Required=false)]
            public string CdsName { get; set; }

            /// <summary>
            /// <para>The ID of the centralized resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecds-0****</para>
            /// </summary>
            [NameInMap("CenterResourceId")]
            [Validation(Required=false)]
            public string CenterResourceId { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Postpaid (default): pay-as-you-go.</description></item>
            /// <item><description>PrePaid: subscription.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The client types supported by resources.</para>
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
                /// <para>The status.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OFF</description></item>
                /// <item><description>ON</description></item>
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
            /// <para>The connection attributes in JSON format. The client does not need to process the attributes; they are directly passed to the resource management center when the app resource is created.</para>
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
            /// <para>The cloud computer plans.</para>
            /// </summary>
            [NameInMap("DesktopDurationList")]
            [Validation(Required=false)]
            public List<DescribeUserResourcesResponseBodyResourcesDesktopDurationList> DesktopDurationList { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesDesktopDurationList : TeaModel {
                /// <summary>
                /// <para>The ID of the instance order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mdp-0bxls4qpi6bl6****</para>
                /// </summary>
                [NameInMap("OrderInstanceId")]
                [Validation(Required=false)]
                public string OrderInstanceId { get; set; }

                /// <summary>
                /// <para>The time when the package was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-17T07:01Z</para>
                /// </summary>
                [NameInMap("PackageCreationTime")]
                [Validation(Required=false)]
                public string PackageCreationTime { get; set; }

                /// <summary>
                /// <para>The expiration time of the package.</para>
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
                /// <para>The package status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("PackageStatus")]
                [Validation(Required=false)]
                public string PackageStatus { get; set; }

                /// <summary>
                /// <para>The package type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>FREE_PACKAGE: a free package.</description></item>
                /// <item><description>NORMAL_PACKAGE: a paid package (120-hour computing plan).</description></item>
                /// <item><description>POSTPAID_PACKAGE: a pay-as-you-go package (200-hour computing plan).</description></item>
                /// <item><description>Duration: an hourly package.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL_PACKAGE</para>
                /// </summary>
                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                /// <summary>
                /// <para>The policy for the cloud computer status once the monthly package quota is exhausted.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Shutdown: The cloud computer enters the Stopped or Hibernated state.</description></item>
                /// <item><description>PostPaid: The cloud computer continues providing services that are billed on the pay-as-you-go basis.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Postpaid</para>
                /// </summary>
                [NameInMap("PackageUsedUpStrategy")]
                [Validation(Required=false)]
                public string PackageUsedUpStrategy { get; set; }

                /// <summary>
                /// <para>The package\&quot;s effective end time for the current month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-02-17T15:59Z</para>
                /// </summary>
                [NameInMap("PeriodEndTime")]
                [Validation(Required=false)]
                public string PeriodEndTime { get; set; }

                /// <summary>
                /// <para>The package\&quot;s effective start time for the current month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-17T07:01Z</para>
                /// </summary>
                [NameInMap("PeriodStartTime")]
                [Validation(Required=false)]
                public string PeriodStartTime { get; set; }

                /// <summary>
                /// <para>The maximum fee for the package in the second phase.</para>
                /// <remarks>
                /// <para> This parameter is returned if you set ResourceType to <c>POSTPAID_PACKAG</c> or <c>FREE_PACKAGE</c>.</para>
                /// </remarks>
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
                /// <para>The subscription duration consumed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16850</para>
                /// </summary>
                [NameInMap("UsedDuration")]
                [Validation(Required=false)]
                public long? UsedDuration { get; set; }

            }

            /// <summary>
            /// <para>The scheduled tasks for cloud computers.</para>
            /// </summary>
            [NameInMap("DesktopTimers")]
            [Validation(Required=false)]
            public List<DescribeUserResourcesResponseBodyResourcesDesktopTimers> DesktopTimers { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesDesktopTimers : TeaModel {
                /// <summary>
                /// <para>Indicates whether to allow end users to configure scheduled tasks on clients.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowClientSetting")]
                [Validation(Required=false)]
                public string AllowClientSetting { get; set; }

                /// <summary>
                /// <para>The cron expression specified in the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 30 13 ? * 1-7</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>Indicates whether to forcibly execute the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enforce")]
                [Validation(Required=false)]
                public bool? Enforce { get; set; }

                /// <summary>
                /// <para>The time when the scheduled task is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-21T11:37Z</para>
                /// </summary>
                [NameInMap("ExecutionTime")]
                [Validation(Required=false)]
                public string ExecutionTime { get; set; }

                /// <summary>
                /// <para>The interval at which the scheduled task is executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The type of the scheduled action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hibernate</para>
                /// </summary>
                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <para>The reset option.</para>
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
            /// <para>The expiration time of the subscription resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02-22T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The ID of the external domain. This parameter is for enterprise drives only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stg114510</para>
            /// </summary>
            [NameInMap("ExternalDomainId")]
            [Validation(Required=false)]
            public string ExternalDomainId { get; set; }

            /// <summary>
            /// <para>The ID of the external user. This parameter is for enterprise drives only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("ExternalUserId")]
            [Validation(Required=false)]
            public string ExternalUserId { get; set; }

            /// <summary>
            /// <para>The update info of the cloud computer.</para>
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
                /// <para>The current version number of the cloud computer\&quot;s image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.7.0-R-20250122.154826</para>
                /// </summary>
                [NameInMap("CurrentAppVersion")]
                [Validation(Required=false)]
                public string CurrentAppVersion { get; set; }

                /// <summary>
                /// <para>Specifies whether to implement a forced update.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Force")]
                [Validation(Required=false)]
                public bool? Force { get; set; }

                /// <summary>
                /// <para>The target version number of the cloud computer\&quot;s image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.7.0-R-20250125.154826</para>
                /// </summary>
                [NameInMap("NewAppVersion")]
                [Validation(Required=false)]
                public string NewAppVersion { get; set; }

                /// <summary>
                /// <para>The latest version available for updating the component disk.</para>
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
                /// <para>The version description of the cloud computer\&quot;s image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>up</para>
                /// </summary>
                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

                /// <summary>
                /// <para>The English release note for the new image version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>up</para>
                /// </summary>
                [NameInMap("ReleaseNoteEn")]
                [Validation(Required=false)]
                public string ReleaseNoteEn { get; set; }

                /// <summary>
                /// <para>The Japanese release note for the new image version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>up</para>
                /// </summary>
                [NameInMap("ReleaseNoteJp")]
                [Validation(Required=false)]
                public string ReleaseNoteJp { get; set; }

                /// <summary>
                /// <para>The size of the update package for the cloud computer image. Unit: KB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>474981930</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether cross-region access is supported. This parameter is for enterprise drives only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GlobalStatus")]
            [Validation(Required=false)]
            public bool? GlobalStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether an update exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasUpgrade")]
            [Validation(Required=false)]
            public bool? HasUpgrade { get; set; }

            /// <summary>
            /// <para>Indicates whether this is a beta version of the hibernation feature.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HibernationBeta")]
            [Validation(Required=false)]
            public bool? HibernationBeta { get; set; }

            /// <summary>
            /// <para>The resource icon. This parameter is for apps only.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com/icon.png">http://example.com/icon.png</a></para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>The time when the resource was last started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-24T03:12:04Z</para>
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
            /// <para>The management status.</para>
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
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Ceased: Your account has an overdue payment.</description></item>
            /// <item><description>Released: The order is closed.</description></item>
            /// <item><description>Expired: The subscription resource has expired.</description></item>
            /// <item><description>Normal: The order is normal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public string OrderStatus { get; set; }

            /// <summary>
            /// <para>The OS platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows Server 2022</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The description of the OS platform.</para>
            /// </summary>
            [NameInMap("OsDescription")]
            [Validation(Required=false)]
            public string OsDescription { get; set; }

            /// <summary>
            /// <para>The OS type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Linux</description></item>
            /// <item><description>Windows</description></item>
            /// <item><description>Android</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The update info of the OS.</para>
            /// </summary>
            [NameInMap("OsUpdate")]
            [Validation(Required=false)]
            public DescribeUserResourcesResponseBodyResourcesOsUpdate OsUpdate { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesOsUpdate : TeaModel {
                /// <summary>
                /// <para>The ID of the check task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wua-1740652957251743***</para>
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                /// <summary>
                /// <para>The patch numbers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KB2267***</para>
                /// </summary>
                [NameInMap("KbListString")]
                [Validation(Required=false)]
                public string KbListString { get; set; }

                /// <summary>
                /// <para>The number of packets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PackageCount")]
                [Validation(Required=false)]
                public int? PackageCount { get; set; }

                /// <summary>
                /// <para>The patch packages.</para>
                /// </summary>
                [NameInMap("Packages")]
                [Validation(Required=false)]
                public List<DescribeUserResourcesResponseBodyResourcesOsUpdatePackages> Packages { get; set; }
                public class DescribeUserResourcesResponseBodyResourcesOsUpdatePackages : TeaModel {
                    /// <summary>
                    /// <para>The patch description.</para>
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
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The update categorization URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://catalog.update.microsoft.com/home.aspx">https://catalog.update.microsoft.com/home.aspx</a></para>
                /// </summary>
                [NameInMap("UpdateCatalogUrl")]
                [Validation(Required=false)]
                public string UpdateCatalogUrl { get; set; }

            }

            /// <summary>
            /// <para>The service type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CloudDesktop: regular cloud computers or cloud computer shares.</description></item>
            /// <item><description>CloudApp: App Streaming</description></item>
            /// <item><description>CloudBrowser: Cloud Browser.</description></item>
            /// <item><description>AndroidCloud: Cloud Phone.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AndroidCloud</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
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
            /// <para>The real ID of the cloud computer (from a share). This parameter is returned only when the cloud computer share has ongoing sessions.</para>
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
            /// <para>The geographical location.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Mainland: regions in the Chinese mainland.</description></item>
            /// <item><description>Overseas: regions outside the Chinese mainland, including China (Hong Kong).</description></item>
            /// </list>
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
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Center: a centralized resource.</description></item>
            /// <item><description>Region: a unit resource.</description></item>
            /// </list>
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
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Unknown</description></item>
            /// <item><description>Connected</description></item>
            /// <item><description>Disconnected</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Connected</para>
            /// </summary>
            [NameInMap("ResourceSessionStatus")]
            [Validation(Required=false)]
            public string ResourceSessionStatus { get; set; }

            /// <summary>
            /// <para>The resource status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Unknown: The resource status is unknown.</description></item>
            /// <item><description>Stopped: The resource is stopped.</description></item>
            /// <item><description>Failed: The resource failed to be created.</description></item>
            /// <item><description>Starting: The resource is being started.</description></item>
            /// <item><description>Rebuilding: The resource is changing.</description></item>
            /// <item><description>Running: The resource is running.</description></item>
            /// <item><description>Stopping: The resource is being stopped.</description></item>
            /// <item><description>FotaUpdating: The image is being updated.</description></item>
            /// <item><description>Pending: The resource is still being prepared.</description></item>
            /// <item><description>Deleting: The resource is being deleted.</description></item>
            /// <item><description>Unavailable: The resource is unavailable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>App: cloud apps including App Streaming, Cloud Phone, and Cloud Browser.</description></item>
            /// <item><description>Desktop: cloud computers.</description></item>
            /// <item><description>DesktopGroup: cloud computer shares.</description></item>
            /// <item><description>CloudDrive: enterprise drives.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Desktop</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The session type.</para>
            /// <para>Valid values:</para>
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
            /// <para>The sessions established between users and resources.</para>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeUserResourcesResponseBodyResourcesSessions> Sessions { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesSessions : TeaModel {
                /// <summary>
                /// <para>用户的昵称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-001</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The timestamp when the resource session was established.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-22T11:03:36Z</para>
                /// </summary>
                [NameInMap("ResourceSessionStartTime")]
                [Validation(Required=false)]
                public string ResourceSessionStartTime { get; set; }

                /// <summary>
                /// <para>The username used to log on to the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user001</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The User Principal Name (UPN) of the resource-bound user (if applicable). This parameter is returned only when you query the current user\&quot;s sessions.</para>
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
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>monthPackage: monthly subscription.</description></item>
            /// <item><description>PrePaid: hourly plans.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("SubPayType")]
            [Validation(Required=false)]
            public string SubPayType { get; set; }

            /// <summary>
            /// <para>Indicates whether hibernation is supported.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportHibernation")]
            [Validation(Required=false)]
            public bool? SupportHibernation { get; set; }

            /// <summary>
            /// <para>The supported actions. This parameter is returned only for cloud computers or phones.</para>
            /// </summary>
            [NameInMap("SupportedActions")]
            [Validation(Required=false)]
            public List<string> SupportedActions { get; set; }

            /// <summary>
            /// <para>The theme color of the resource. This parameter is for apps only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>#FFFFFF</para>
            /// </summary>
            [NameInMap("ThemeColor")]
            [Validation(Required=false)]
            public string ThemeColor { get; set; }

            /// <summary>
            /// <para>The custom name of the resource.</para>
            /// </summary>
            [NameInMap("UserCustomName")]
            [Validation(Required=false)]
            public string UserCustomName { get; set; }

            /// <summary>
            /// <para>The resource version. This parameter is for apps only.</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>总数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
