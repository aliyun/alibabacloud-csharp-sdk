// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeUserResourcesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("QueryFailedResourceTypes")]
        [Validation(Required=false)]
        public List<string> QueryFailedResourceTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1732869815062</para>
        /// </summary>
        [NameInMap("RankVersion")]
        [Validation(Required=false)]
        public long? RankVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DescribeUserResourcesResponseBodyResources> Resources { get; set; }
        public class DescribeUserResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>194101959****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>app-0001</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>App</para>
            /// </summary>
            [NameInMap("AuthMode")]
            [Validation(Required=false)]
            public string AuthMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CategoryType")]
            [Validation(Required=false)]
            public int? CategoryType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai+cds-695277****</para>
            /// </summary>
            [NameInMap("CdsName")]
            [Validation(Required=false)]
            public string CdsName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecds-0****</para>
            /// </summary>
            [NameInMap("CenterResourceId")]
            [Validation(Required=false)]
            public string CenterResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("Clients")]
            [Validation(Required=false)]
            public List<DescribeUserResourcesResponseBodyResourcesClients> Clients { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesClients : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;authMode&quot;:&quot;App&quot;}</para>
            /// </summary>
            [NameInMap("ConnectionProperties")]
            [Validation(Required=false)]
            public string ConnectionProperties { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-12-11T07:12:12Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DesktopDurationList")]
            [Validation(Required=false)]
            public List<DescribeUserResourcesResponseBodyResourcesDesktopDurationList> DesktopDurationList { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesDesktopDurationList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>mdp-0bxls4qpi6bl6****</para>
                /// </summary>
                [NameInMap("OrderInstanceId")]
                [Validation(Required=false)]
                public string OrderInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-17T07:01Z</para>
                /// </summary>
                [NameInMap("PackageCreationTime")]
                [Validation(Required=false)]
                public string PackageCreationTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-02-17T15:59Z</para>
                /// </summary>
                [NameInMap("PackageExpiredTime")]
                [Validation(Required=false)]
                public string PackageExpiredTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mdp-0bxls4qpi6bl6****</para>
                /// </summary>
                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public string PackageId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("PackageStatus")]
                [Validation(Required=false)]
                public string PackageStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL_PACKAGE</para>
                /// </summary>
                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Postpaid</para>
                /// </summary>
                [NameInMap("PackageUsedUpStrategy")]
                [Validation(Required=false)]
                public string PackageUsedUpStrategy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-02-17T15:59Z</para>
                /// </summary>
                [NameInMap("PeriodEndTime")]
                [Validation(Required=false)]
                public string PeriodEndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-17T07:01Z</para>
                /// </summary>
                [NameInMap("PeriodStartTime")]
                [Validation(Required=false)]
                public string PeriodStartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>199</para>
                /// </summary>
                [NameInMap("PostPaidLimitFee")]
                [Validation(Required=false)]
                public float? PostPaidLimitFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>432000</para>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public long? TotalDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16850</para>
                /// </summary>
                [NameInMap("UsedDuration")]
                [Validation(Required=false)]
                public long? UsedDuration { get; set; }

            }

            [NameInMap("DesktopTimers")]
            [Validation(Required=false)]
            public List<DescribeUserResourcesResponseBodyResourcesDesktopTimers> DesktopTimers { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesDesktopTimers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowClientSetting")]
                [Validation(Required=false)]
                public string AllowClientSetting { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0 30 13 ? * 1-7</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-21T11:37Z</para>
                /// </summary>
                [NameInMap("ExecutionTime")]
                [Validation(Required=false)]
                public string ExecutionTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Hibernate</para>
                /// </summary>
                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RESET_TYPE_SYSTEM</para>
                /// </summary>
                [NameInMap("ResetType")]
                [Validation(Required=false)]
                public string ResetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TimerBoot</para>
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public string TimerType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-02-22T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stg114510</para>
            /// </summary>
            [NameInMap("ExternalDomainId")]
            [Validation(Required=false)]
            public string ExternalDomainId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("ExternalUserId")]
            [Validation(Required=false)]
            public string ExternalUserId { get; set; }

            [NameInMap("FotaUpdate")]
            [Validation(Required=false)]
            public DescribeUserResourcesResponseBodyResourcesFotaUpdate FotaUpdate { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesFotaUpdate : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.7.0-R-20250122.154826</para>
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
                /// <para>2.7.0-R-20250125.154826</para>
                /// </summary>
                [NameInMap("NewAppVersion")]
                [Validation(Required=false)]
                public string NewAppVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.6.9-R-20250123.153415</para>
                /// </summary>
                [NameInMap("NewDcdVersion")]
                [Validation(Required=false)]
                public string NewDcdVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>wuying-asp_single_session_desktop_win_x64</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>up</para>
                /// </summary>
                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>up</para>
                /// </summary>
                [NameInMap("ReleaseNoteEn")]
                [Validation(Required=false)]
                public string ReleaseNoteEn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>up</para>
                /// </summary>
                [NameInMap("ReleaseNoteJp")]
                [Validation(Required=false)]
                public string ReleaseNoteJp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>474981930</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GlobalStatus")]
            [Validation(Required=false)]
            public bool? GlobalStatus { get; set; }

            [NameInMap("HasUpgrade")]
            [Validation(Required=false)]
            public bool? HasUpgrade { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HibernationBeta")]
            [Validation(Required=false)]
            public bool? HibernationBeta { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://example.com/icon.png">http://example.com/icon.png</a></para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-24T03:12:04Z</para>
            /// </summary>
            [NameInMap("LastStartTime")]
            [Validation(Required=false)]
            public string LastStartTime { get; set; }

            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            [NameInMap("ManagementStatuses")]
            [Validation(Required=false)]
            public List<string> ManagementStatuses { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai+dir-3367****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public string OrderStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Windows Server 2022</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("OsDescription")]
            [Validation(Required=false)]
            public string OsDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("OsUpdate")]
            [Validation(Required=false)]
            public DescribeUserResourcesResponseBodyResourcesOsUpdate OsUpdate { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesOsUpdate : TeaModel {
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                [NameInMap("KbListString")]
                [Validation(Required=false)]
                public string KbListString { get; set; }

                [NameInMap("PackageCount")]
                [Validation(Required=false)]
                public int? PackageCount { get; set; }

                [NameInMap("Packages")]
                [Validation(Required=false)]
                public List<DescribeUserResourcesResponseBodyResourcesOsUpdatePackages> Packages { get; set; }
                public class DescribeUserResourcesResponseBodyResourcesOsUpdatePackages : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Kb")]
                    [Validation(Required=false)]
                    public string Kb { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("UpdateCatalogUrl")]
                [Validation(Required=false)]
                public string UpdateCatalogUrl { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AndroidCloud</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd-0001</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>Mainland</para>
            /// </summary>
            [NameInMap("RegionLocation")]
            [Validation(Required=false)]
            public string RegionLocation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dg-0****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd-d19tya8zi4****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Center</para>
            /// </summary>
            [NameInMap("ResourceLevel")]
            [Validation(Required=false)]
            public string ResourceLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testName01</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Connected</para>
            /// </summary>
            [NameInMap("ResourceSessionStatus")]
            [Validation(Required=false)]
            public string ResourceSessionStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Desktop</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SINGLE_SESSION</para>
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeUserResourcesResponseBodyResourcesSessions> Sessions { get; set; }
            public class DescribeUserResourcesResponseBodyResourcesSessions : TeaModel {
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-22T11:03:36Z</para>
                /// </summary>
                [NameInMap("ResourceSessionStartTime")]
                [Validation(Required=false)]
                public string ResourceSessionStartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user001</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:benchmark_test@test.shenzhen">benchmark_test@test.shenzhen</a></para>
                /// </summary>
                [NameInMap("UserPrincipalName")]
                [Validation(Required=false)]
                public string UserPrincipalName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("SubPayType")]
            [Validation(Required=false)]
            public string SubPayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportHibernation")]
            [Validation(Required=false)]
            public bool? SupportHibernation { get; set; }

            [NameInMap("SupportedActions")]
            [Validation(Required=false)]
            public List<string> SupportedActions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>#FFFFFF</para>
            /// </summary>
            [NameInMap("ThemeColor")]
            [Validation(Required=false)]
            public string ThemeColor { get; set; }

            [NameInMap("UserCustomName")]
            [Validation(Required=false)]
            public string UserCustomName { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
