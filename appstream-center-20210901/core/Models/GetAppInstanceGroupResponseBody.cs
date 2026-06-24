// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetAppInstanceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>AppInstanceGroupModels</para>
        /// </summary>
        [NameInMap("AppInstanceGroupModels")]
        [Validation(Required=false)]
        public GetAppInstanceGroupResponseBodyAppInstanceGroupModels AppInstanceGroupModels { get; set; }
        public class GetAppInstanceGroupResponseBodyAppInstanceGroupModels : TeaModel {
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
            /// <para>The number of subscription resources configured by the user. Minimum value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            /// <summary>
            /// <para>The application image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>img-8z4nztpaqvay4****</para>
            /// </summary>
            [NameInMap("AppCenterImageId")]
            [Validation(Required=false)]
            public string AppCenterImageId { get; set; }

            /// <summary>
            /// <para>The application image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OfficeApps</para>
            /// </summary>
            [NameInMap("AppCenterImageName")]
            [Validation(Required=false)]
            public string AppCenterImageName { get; set; }

            /// <summary>
            /// <para>The delivery group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The delivery group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>办公应用</para>
            /// </summary>
            [NameInMap("AppInstanceGroupName")]
            [Validation(Required=false)]
            public string AppInstanceGroupName { get; set; }

            /// <summary>
            /// <para>The instance type of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b>dynamic</b></para>
            /// </summary>
            [NameInMap("AppInstanceType")]
            [Validation(Required=false)]
            public string AppInstanceType { get; set; }

            /// <summary>
            /// <para>The name of the instance type of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("AppInstanceTypeName")]
            [Validation(Required=false)]
            public string AppInstanceTypeName { get; set; }

            /// <summary>
            /// <para>The application policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-g3k5wa2ms2****</para>
            /// </summary>
            [NameInMap("AppPolicyId")]
            [Validation(Required=false)]
            public string AppPolicyId { get; set; }

            /// <summary>
            /// <para>The list of application information.</para>
            /// </summary>
            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<GetAppInstanceGroupResponseBodyAppInstanceGroupModelsApps> Apps { get; set; }
            public class GetAppInstanceGroupResponseBodyAppInstanceGroupModelsApps : TeaModel {
                /// <summary>
                /// <para>The application icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://app-center-icon-****.png">https://app-center-icon-****.png</a></para>
                /// </summary>
                [NameInMap("AppIcon")]
                [Validation(Required=false)]
                public string AppIcon { get; set; }

                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ca-i87mycyn419nu****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>办公应用</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The application version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// <para>The application version name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>初始版本</para>
                /// </summary>
                [NameInMap("AppVersionName")]
                [Validation(Required=false)]
                public string AppVersionName { get; set; }

            }

            /// <summary>
            /// <para>The authorization mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>App</para>
            /// </summary>
            [NameInMap("AuthMode")]
            [Validation(Required=false)]
            public string AuthMode { get; set; }

            /// <summary>
            /// <para>The sales mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node</para>
            /// </summary>
            [NameInMap("ChargeResourceMode")]
            [Validation(Required=false)]
            public string ChargeResourceMode { get; set; }

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
            /// <para>The expiration time of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-27T16:00:00.000+00:00</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-26T15:06:16.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The maximum number of instances. Minimum value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxAmount")]
            [Validation(Required=false)]
            public int? MaxAmount { get; set; }

            /// <summary>
            /// <para>The minimum number of instances. Minimum value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinAmount")]
            [Validation(Required=false)]
            public int? MinAmount { get; set; }

            /// <summary>
            /// <para>The resource group information.</para>
            /// </summary>
            [NameInMap("NodePool")]
            [Validation(Required=false)]
            public List<GetAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePool> NodePool { get; set; }
            public class GetAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePool : TeaModel {
                /// <summary>
                /// <para>The number of resources purchased when the delivery group was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The upper limit of idle sessions. When this value is specified, automatic scale-out is triggered only when the session usage exceeds <c>ScalingUsageThreshold</c> and the number of idle sessions in the delivery group is less than <c>MaxIdleAppInstanceAmount</c>. Otherwise, the delivery group is considered to have sufficient idle sessions and no automatic scale-out is performed. This parameter allows you to flexibly control elastic scaling behavior and reduce costs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxIdleAppInstanceAmount")]
                [Validation(Required=false)]
                public int? MaxIdleAppInstanceAmount { get; set; }

                /// <summary>
                /// <para>The maximum number of resources that can be created during scale-out.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("MaxScalingAmount")]
                [Validation(Required=false)]
                public int? MaxScalingAmount { get; set; }

                /// <summary>
                /// <para>The total number of current subscription resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeAmount")]
                [Validation(Required=false)]
                public int? NodeAmount { get; set; }

                /// <summary>
                /// <para>The number of concurrent sessions, which is the number of sessions that a single resource can handle simultaneously. If too many sessions are connected simultaneously, the application experience may degrade. The valid values vary by resource specification:</para>
                /// <list type="bullet">
                /// <item><description>appstreaming.general.4c8g: 1 to 2.</description></item>
                /// <item><description>appstreaming.general.8c16g: 1 to 4.</description></item>
                /// <item><description>appstreaming.vgpu.8c16g.4g: 1 to 4.</description></item>
                /// <item><description>appstreaming.vgpu.8c31g.16g: 1 to 4.</description></item>
                /// <item><description>appstreaming.vgpu.14c93g.12g: 1 to 6.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("NodeCapacity")]
                [Validation(Required=false)]
                public int? NodeCapacity { get; set; }

                /// <summary>
                /// <para>The instance type ID of the purchased resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>appstreaming.vgpu.4c8g.2g</para>
                /// </summary>
                [NameInMap("NodeInstanceType")]
                [Validation(Required=false)]
                public string NodeInstanceType { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-g6922kced36hx****</para>
                /// </summary>
                [NameInMap("NodePoolId")]
                [Validation(Required=false)]
                public string NodePoolId { get; set; }

                /// <summary>
                /// <para>The resource specification name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无影-通用型_4核8G</para>
                /// </summary>
                [NameInMap("NodeTypeName")]
                [Validation(Required=false)]
                public string NodeTypeName { get; set; }

                /// <summary>
                /// <para>The resource count of subscription resources in use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeUsed")]
                [Validation(Required=false)]
                public int? NodeUsed { get; set; }

                /// <summary>
                /// <para>The list of policy execution cycles.</para>
                /// </summary>
                [NameInMap("RecurrenceSchedules")]
                [Validation(Required=false)]
                public List<GetAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedules> RecurrenceSchedules { get; set; }
                public class GetAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedules : TeaModel {
                    /// <summary>
                    /// <para>The type of the policy execution cycle. You must specify both <c>RecurrenceType</c> and <c>RecurrenceValues</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Weekly</para>
                    /// </summary>
                    [NameInMap("RecurrenceType")]
                    [Validation(Required=false)]
                    public string RecurrenceType { get; set; }

                    /// <summary>
                    /// <para>The list of values for the policy execution cycle.</para>
                    /// </summary>
                    [NameInMap("RecurrenceValues")]
                    [Validation(Required=false)]
                    public List<int?> RecurrenceValues { get; set; }

                    /// <summary>
                    /// <para>The list of time periods for the policy execution cycle.</para>
                    /// </summary>
                    [NameInMap("TimerPeriods")]
                    [Validation(Required=false)]
                    public List<GetAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedulesTimerPeriods> TimerPeriods { get; set; }
                    public class GetAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedulesTimerPeriods : TeaModel {
                        /// <summary>
                        /// <para>The target resource count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Amount")]
                        [Validation(Required=false)]
                        public int? Amount { get; set; }

                        /// <summary>
                        /// <para>The end time. Format: HH:mm.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>11:00</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The start time. Format: HH:mm.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>09:30</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>The idle duration without session connections, in minutes. When a resource remains without session connections for the specified duration, automatic scale-in is triggered. Default value: 5.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ScalingDownAfterIdleMinutes")]
                [Validation(Required=false)]
                public int? ScalingDownAfterIdleMinutes { get; set; }

                /// <summary>
                /// <para>The total number of elastic resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("ScalingNodeAmount")]
                [Validation(Required=false)]
                public int? ScalingNodeAmount { get; set; }

                /// <summary>
                /// <para>The resource count of elastic resources in use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("ScalingNodeUsed")]
                [Validation(Required=false)]
                public int? ScalingNodeUsed { get; set; }

                /// <summary>
                /// <para>The number of resources created during each scale-out event. Valid values: 1 to 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ScalingStep")]
                [Validation(Required=false)]
                public int? ScalingStep { get; set; }

                /// <summary>
                /// <para>The upper threshold of session usage (%). When the session usage exceeds this threshold, automatic scale-out is triggered. The session usage is calculated as follows: <c>Session usage = Number of current sessions ÷ (Total number of resources × Concurrent sessions per resource) × 100%</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85</para>
                /// </summary>
                [NameInMap("ScalingUsageThreshold")]
                [Validation(Required=false)]
                public string ScalingUsageThreshold { get; set; }

                /// <summary>
                /// <para>The date when the policy expires. Format: yyyy-MM-dd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-08</para>
                /// </summary>
                [NameInMap("StrategyDisableDate")]
                [Validation(Required=false)]
                public string StrategyDisableDate { get; set; }

                /// <summary>
                /// <para>The date when the policy takes effect. Format: yyyy-MM-dd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-01</para>
                /// </summary>
                [NameInMap("StrategyEnableDate")]
                [Validation(Required=false)]
                public string StrategyEnableDate { get; set; }

                /// <summary>
                /// <para>The elastic policy type.</para>
                /// <remarks>
                /// <para><c>NODE_SCALING_BY_USAGE</c> (usage-based scaling policy) applies only to <c>PrePaid</c> (subscription) resources. <c>NODE_SCALING_BY_SCHEDULE</c> (scheduled scaling policy) applies only to <c>PostPaid</c> (pay-as-you-go) resources.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>NODE_FIXED</para>
                /// </summary>
                [NameInMap("StrategyType")]
                [Validation(Required=false)]
                public string StrategyType { get; set; }

                /// <summary>
                /// <para>Indicates whether the resource prefetch policy is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("WarmUp")]
                [Validation(Required=false)]
                public bool? WarmUp { get; set; }

            }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing+dir-172301****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

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
            /// <para>The OTA upgrade task information.</para>
            /// </summary>
            [NameInMap("OtaInfo")]
            [Validation(Required=false)]
            public GetAppInstanceGroupResponseBodyAppInstanceGroupModelsOtaInfo OtaInfo { get; set; }
            public class GetAppInstanceGroupResponseBodyAppInstanceGroupModelsOtaInfo : TeaModel {
                /// <summary>
                /// <para>The new OTA version. An empty value indicates that no new version is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.1-D-20220630.11****</para>
                /// </summary>
                [NameInMap("NewOtaVersion")]
                [Validation(Required=false)]
                public string NewOtaVersion { get; set; }

                /// <summary>
                /// <para>The current OTA version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.1-D-20220615.11****</para>
                /// </summary>
                [NameInMap("OtaVersion")]
                [Validation(Required=false)]
                public string OtaVersion { get; set; }

                /// <summary>
                /// <para>The OTA upgrade task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ota-e49929gv8acz5****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <para>The product type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CloudApp</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The region ID of the delivery group. For more information about supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The percentage of reserved instances, which represents the ratio of unused sessions in the delivery group. Valid values: 0 to 99.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ReserveAmountRatio")]
            [Validation(Required=false)]
            public string ReserveAmountRatio { get; set; }

            /// <summary>
            /// <para>The maximum number of reserved instances, which represents the maximum number of unused sessions in the delivery group. Minimum value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ReserveMaxAmount")]
            [Validation(Required=false)]
            public int? ReserveMaxAmount { get; set; }

            /// <summary>
            /// <para>The minimum number of reserved instances, which represents the minimum number of unused sessions in the delivery group. Minimum value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReserveMinAmount")]
            [Validation(Required=false)]
            public int? ReserveMinAmount { get; set; }

            /// <summary>
            /// <para>The resource status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <para>The idle duration without session connections, in minutes. When a resource remains without session connections for the specified duration, automatic scale-in is triggered. Minimum value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScalingDownAfterIdleMinutes")]
            [Validation(Required=false)]
            public int? ScalingDownAfterIdleMinutes { get; set; }

            /// <summary>
            /// <para>The number of sessions created during each scale-out event. Minimum value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ScalingStep")]
            [Validation(Required=false)]
            public int? ScalingStep { get; set; }

            /// <summary>
            /// <para>The upper threshold of session usage (%). When the session usage exceeds this threshold, automatic scale-out is triggered. The session usage is calculated as follows: Session usage = Number of sessions in use ÷ Total number of sessions × 100%. Valid values: 0 to 99.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85</para>
            /// </summary>
            [NameInMap("ScalingUsageThreshold")]
            [Validation(Required=false)]
            public string ScalingUsageThreshold { get; set; }

            /// <summary>
            /// <para>The session disconnection retention duration, in minutes. After an end user session is disconnected, the session is retained for the specified duration before being logged off. Set this parameter to <c>-1</c> to retain the session indefinitely. Valid values: -1 and 3 to 300. Default value: <c>15</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("SessionTimeout")]
            [Validation(Required=false)]
            public string SessionTimeout { get; set; }

            /// <summary>
            /// <para>The session type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <para>Indicates whether user authorization verification is skipped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SkipUserAuthCheck")]
            [Validation(Required=false)]
            public bool? SkipUserAuthCheck { get; set; }

            /// <summary>
            /// <para>The ID that uniquely corresponds to the delivery group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spec-8o18t8uc31qib0****</para>
            /// </summary>
            [NameInMap("SpecId")]
            [Validation(Required=false)]
            public string SpecId { get; set; }

            /// <summary>
            /// <para>The delivery group status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SupportUserGroupMixedAuth")]
            [Validation(Required=false)]
            public bool? SupportUserGroupMixedAuth { get; set; }

            /// <summary>
            /// <para>The list of resource tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetAppInstanceGroupResponseBodyAppInstanceGroupModelsTags> Tags { get; set; }
            public class GetAppInstanceGroupResponseBodyAppInstanceGroupModelsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>department</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>design</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Mixed</para>
            /// </summary>
            [NameInMap("UserGroupAuthMode")]
            [Validation(Required=false)]
            public string UserGroupAuthMode { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
