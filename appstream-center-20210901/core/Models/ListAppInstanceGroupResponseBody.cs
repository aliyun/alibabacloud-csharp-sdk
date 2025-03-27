// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppInstanceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The delivery groups.</para>
        /// </summary>
        [NameInMap("AppInstanceGroupModels")]
        [Validation(Required=false)]
        public List<ListAppInstanceGroupResponseBodyAppInstanceGroupModels> AppInstanceGroupModels { get; set; }
        public class ListAppInstanceGroupResponseBodyAppInstanceGroupModels : TeaModel {
            /// <summary>
            /// <para>The number of subscription resources. Minimum value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            /// <summary>
            /// <para>The image ID of the app.</para>
            /// 
            /// <b>Example:</b>
            /// <para>img-8z4nztpaqvay4****</para>
            /// </summary>
            [NameInMap("AppCenterImageId")]
            [Validation(Required=false)]
            public string AppCenterImageId { get; set; }

            /// <summary>
            /// <para>The ID of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the delivery group.</para>
            /// </summary>
            [NameInMap("AppInstanceGroupName")]
            [Validation(Required=false)]
            public string AppInstanceGroupName { get; set; }

            /// <summary>
            /// <para>The resource type of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b>dynamic</b></para>
            /// </summary>
            [NameInMap("AppInstanceType")]
            [Validation(Required=false)]
            public string AppInstanceType { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-g3k5wa2ms2****</para>
            /// </summary>
            [NameInMap("AppPolicyId")]
            [Validation(Required=false)]
            public string AppPolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AppPolicyImageCheck")]
            [Validation(Required=false)]
            public bool? AppPolicyImageCheck { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CENTER</para>
            /// </summary>
            [NameInMap("AppPolicyVersion")]
            [Validation(Required=false)]
            public string AppPolicyVersion { get; set; }

            /// <summary>
            /// <para>The apps.</para>
            /// </summary>
            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<ListAppInstanceGroupResponseBodyAppInstanceGroupModelsApps> Apps { get; set; }
            public class ListAppInstanceGroupResponseBodyAppInstanceGroupModelsApps : TeaModel {
                /// <summary>
                /// <para>The app icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://app-center-icon-****.png">https://app-center-icon-****.png</a></para>
                /// </summary>
                [NameInMap("AppIcon")]
                [Validation(Required=false)]
                public string AppIcon { get; set; }

                /// <summary>
                /// <para>The app ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ca-i87mycyn419nu****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The app name.</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The app version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// <para>The name of the app version.</para>
                /// </summary>
                [NameInMap("AppVersionName")]
                [Validation(Required=false)]
                public string AppVersionName { get; set; }

            }

            /// <summary>
            /// <para>The sales mode.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AppInstance: by session</description></item>
            /// <item><description>Node: by resource</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Node</para>
            /// </summary>
            [NameInMap("ChargeResourceMode")]
            [Validation(Required=false)]
            public string ChargeResourceMode { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PostPaid: pay-as-you-go</description></item>
            /// <item><description>PrePaid: subscription</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The time when the delivery group expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-27T16:00:00.000+00:00</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The time when the delivery group was created.</para>
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
            /// <para>The resource groups.</para>
            /// </summary>
            [NameInMap("NodePool")]
            [Validation(Required=false)]
            public List<ListAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePool> NodePool { get; set; }
            public class ListAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePool : TeaModel {
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
                /// <para>The maximum number of idle sessions. After you specify a value for this parameter, auto scale-out is triggered only if the number of idle sessions in the delivery group is smaller than the specified value and the session usage exceeds the value specified for <c>ScalingUsageThreshold</c>. Otherwise, the system determines that idle sessions in the delivery group are sufficient and does not perform auto scale-out.`` You can use this parameter to flexibly manage auto scaling and reduce costs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxIdleAppInstanceAmount")]
                [Validation(Required=false)]
                public int? MaxIdleAppInstanceAmount { get; set; }

                /// <summary>
                /// <para>The maximum number of resources that can be created for scale-out.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("MaxScalingAmount")]
                [Validation(Required=false)]
                public int? MaxScalingAmount { get; set; }

                /// <summary>
                /// <para>The total number of subscription resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeAmount")]
                [Validation(Required=false)]
                public int? NodeAmount { get; set; }

                /// <summary>
                /// <para>The maximum number of sessions that can be connected to a resource at the same time. If a resource connects to a large number of sessions at the same time, user experience can be compromised. The value range varies based on the resource specification. The following items describe the value ranges of different resource types:</para>
                /// <list type="bullet">
                /// <item><description>appstreaming.general.4c8g: 1 to 2</description></item>
                /// <item><description>appstreaming.general.8c16g: 1 to 4</description></item>
                /// <item><description>appstreaming.vgpu.8c16g.4g: 1 to 4</description></item>
                /// <item><description>appstreaming.vgpu.8c31g.16g: 1 to 4</description></item>
                /// <item><description>appstreaming.vgpu.14c93g.12g: 1 to 6</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("NodeCapacity")]
                [Validation(Required=false)]
                public int? NodeCapacity { get; set; }

                /// <summary>
                /// <para>The ID of the resource specification that you purchase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>appstreaming.vgpu.4c8g.2g</para>
                /// </summary>
                [NameInMap("NodeInstanceType")]
                [Validation(Required=false)]
                public string NodeInstanceType { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-g6922kced36hx****</para>
                /// </summary>
                [NameInMap("NodePoolId")]
                [Validation(Required=false)]
                public string NodePoolId { get; set; }

                /// <summary>
                /// <para>The name of the resource specification.</para>
                /// </summary>
                [NameInMap("NodeTypeName")]
                [Validation(Required=false)]
                public string NodeTypeName { get; set; }

                /// <summary>
                /// <para>The number of subscription resources that are in use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeUsed")]
                [Validation(Required=false)]
                public int? NodeUsed { get; set; }

                /// <summary>
                /// <para>The intervals at which the scaling policy is executed.</para>
                /// </summary>
                [NameInMap("RecurrenceSchedules")]
                [Validation(Required=false)]
                public List<ListAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedules> RecurrenceSchedules { get; set; }
                public class ListAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedules : TeaModel {
                    /// <summary>
                    /// <para>The schedule type of the scaling policy. This parameter must be configured together with <c>RecurrenceValues</c>.``</para>
                    /// <para>Valid value:</para>
                    /// <list type="bullet">
                    /// <item><description>weekly: The scaling policy is executed on specific days each week.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Weekly</para>
                    /// </summary>
                    [NameInMap("RecurrenceType")]
                    [Validation(Required=false)]
                    public string RecurrenceType { get; set; }

                    /// <summary>
                    /// <para>The days of each week on which the scaling policy is executed.</para>
                    /// </summary>
                    [NameInMap("RecurrenceValues")]
                    [Validation(Required=false)]
                    public List<int?> RecurrenceValues { get; set; }

                    /// <summary>
                    /// <para>The time periods during which the scaling policy can be executed.</para>
                    /// </summary>
                    [NameInMap("TimerPeriods")]
                    [Validation(Required=false)]
                    public List<ListAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedulesTimerPeriods> TimerPeriods { get; set; }
                    public class ListAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedulesTimerPeriods : TeaModel {
                        /// <summary>
                        /// <para>The number of destination resources.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Amount")]
                        [Validation(Required=false)]
                        public int? Amount { get; set; }

                        /// <summary>
                        /// <para>The time when the scaling policy ends. Format: HH:mm.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>11:00</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The time when the scaling policy starts. Format: HH:mm.</para>
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
                /// <para>The duration for which no session is connected. Unit: minutes. If no session is connected in the resources after the specified duration elapses, auto scale-in is triggered. Default value: 5.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ScalingDownAfterIdleMinutes")]
                [Validation(Required=false)]
                public int? ScalingDownAfterIdleMinutes { get; set; }

                /// <summary>
                /// <para>The total number of scalable resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("ScalingNodeAmount")]
                [Validation(Required=false)]
                public int? ScalingNodeAmount { get; set; }

                /// <summary>
                /// <para>The number of scalable resources that are in use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("ScalingNodeUsed")]
                [Validation(Required=false)]
                public int? ScalingNodeUsed { get; set; }

                /// <summary>
                /// <para>The number of resources that are created each time resources are scaled out. Valid values: 1 to 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ScalingStep")]
                [Validation(Required=false)]
                public int? ScalingStep { get; set; }

                /// <summary>
                /// <para>The upper limit of session usage. If the session usage exceeds the specified upper limit, auto scale-out is triggered. The session usage is calculated by using the following formula: <c>Session usage = Number of current sessions/(Total number of resources × Number of concurrent sessions) × 100%</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85</para>
                /// </summary>
                [NameInMap("ScalingUsageThreshold")]
                [Validation(Required=false)]
                public string ScalingUsageThreshold { get; set; }

                /// <summary>
                /// <para>The expiration date of the scaling policy. Format: yyyy-MM-dd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-08</para>
                /// </summary>
                [NameInMap("StrategyDisableDate")]
                [Validation(Required=false)]
                public string StrategyDisableDate { get; set; }

                /// <summary>
                /// <para>The effective date of the scaling policy. Format: yyyy-MM-dd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-01</para>
                /// </summary>
                [NameInMap("StrategyEnableDate")]
                [Validation(Required=false)]
                public string StrategyEnableDate { get; set; }

                /// <summary>
                /// <para>The type of the scaling policy.</para>
                /// <remarks>
                /// <para> <c>NODE_SCALING_BY_USAGE</c> is returned for this parameter only if ChargeType is set to <c>PrePaid</c>. <c>NODE_SCALING_BY_SCHEDULE</c> is returned for this parameter only if ChargeType is set to <c>PostPaid</c>.</para>
                /// </remarks>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NODE_FIXED: No scalable resources are used.</description></item>
                /// <item><description>NODE_SCALING_BY_SCHEDULE: Scheduled scaling is used.</description></item>
                /// <item><description>NODE_SCALING_BY_USAGE: Resources are scaled based on usage.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NODE_FIXED</para>
                /// </summary>
                [NameInMap("StrategyType")]
                [Validation(Required=false)]
                public string StrategyType { get; set; }

                /// <summary>
                /// <para>Indicates whether resource prefetch is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("WarmUp")]
                [Validation(Required=false)]
                public bool? WarmUp { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing+dir-172301****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The type of the operating system.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Windows</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The information about the over-the-air (OTA) update task.</para>
            /// </summary>
            [NameInMap("OtaInfo")]
            [Validation(Required=false)]
            public ListAppInstanceGroupResponseBodyAppInstanceGroupModelsOtaInfo OtaInfo { get; set; }
            public class ListAppInstanceGroupResponseBodyAppInstanceGroupModelsOtaInfo : TeaModel {
                /// <summary>
                /// <para>The new OTA version. A null value indicates that no new version is available.</para>
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
                /// <para>The ID of the OTA update task.</para>
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
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>CloudApp: App Streaming</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CloudApp</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The ID of the region where the delivery group resides. For information about the supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The percentage of reserved instances. The value indicates the percentage of unused sessions in the delivery group. Valid values: 0 to 99.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ReserveAmountRatio")]
            [Validation(Required=false)]
            public string ReserveAmountRatio { get; set; }

            /// <summary>
            /// <para>The maximum number of reserved instances. The value indicates the maximum number of unused sessions in the delivery group. Minimum value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ReserveMaxAmount")]
            [Validation(Required=false)]
            public int? ReserveMaxAmount { get; set; }

            /// <summary>
            /// <para>The minimum number of reserved instances. The value indicates the minimum number of unused sessions in the delivery group. Minimum value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReserveMinAmount")]
            [Validation(Required=false)]
            public int? ReserveMinAmount { get; set; }

            /// <summary>
            /// <para>The resource status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AVAILABLE</description></item>
            /// <item><description>RELEASED</description></item>
            /// <item><description>EXPIRED_IN_7_DAYS</description></item>
            /// <item><description>UNAVAILABLE</description></item>
            /// <item><description>UPGRADING</description></item>
            /// <item><description>CREATING</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <para>The resource tags.</para>
            /// </summary>
            [NameInMap("ResourceTags")]
            [Validation(Required=false)]
            public List<ListAppInstanceGroupResponseBodyAppInstanceGroupModelsResourceTags> ResourceTags { get; set; }
            public class ListAppInstanceGroupResponseBodyAppInstanceGroupModelsResourceTags : TeaModel {
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
                /// <para>The tag type. Valid values: Custom System</para>
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
            /// <para>The duration for which no session is connected. Unit: minutes. If no session is connected in the resources after the specified duration elapses, auto scale-in is triggered. Minimum value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScalingDownAfterIdleMinutes")]
            [Validation(Required=false)]
            public int? ScalingDownAfterIdleMinutes { get; set; }

            /// <summary>
            /// <para>The number of sessions that are created each time the delivery group is scaled out. Minimum value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ScalingStep")]
            [Validation(Required=false)]
            public int? ScalingStep { get; set; }

            /// <summary>
            /// <para>The upper limit of session usage. If the session usage exceeds the specified upper limit, auto scale-out is triggered. The session usage rate is calculated by using the following formula: Session usage rate = Number of sessions in use/Total number of sessions × 100%. Valid values: 0 to 99.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85</para>
            /// </summary>
            [NameInMap("ScalingUsageThreshold")]
            [Validation(Required=false)]
            public string ScalingUsageThreshold { get; set; }

            /// <summary>
            /// <para>The duration for which sessions are retained after disconnection. Unit: minutes. After an end user disconnects from a session, the session is closed only after the specified duration elapses. If you want to permanently retain sessions, set this parameter to <c>-1</c>. Valid values:-1 and 3 to 300. Default value: <c>15</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("SessionTimeout")]
            [Validation(Required=false)]
            public string SessionTimeout { get; set; }

            /// <summary>
            /// <para>Indicates whether user permission verification is skipped.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false: This is the default value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SkipUserAuthCheck")]
            [Validation(Required=false)]
            public bool? SkipUserAuthCheck { get; set; }

            /// <summary>
            /// <para>The specification ID that uniquely corresponds to the ID of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spec-8o18t8uc31qib0****</para>
            /// </summary>
            [NameInMap("SpecId")]
            [Validation(Required=false)]
            public string SpecId { get; set; }

            /// <summary>
            /// <para>The status of the delivery group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PUBLISHED: The delivery group is published.</description></item>
            /// <item><description>FAILED: The delivery group failed to be published.</description></item>
            /// <item><description>MAINTAIN_FAILED: The delivery group failed to be updated.</description></item>
            /// <item><description>EXPIRED: The delivery group is expired.</description></item>
            /// <item><description>MAINTAINING: The delivery group is being updated.</description></item>
            /// <item><description>CEASED: The delivery group has overdue payments.</description></item>
            /// <item><description>EXPIRED_RECYCLING: The delivery group is expired and being recycled.</description></item>
            /// <item><description>DEPLOYING: The delivery group is being published.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
