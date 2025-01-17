// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppInstanceGroupResponseBody : TeaModel {
        [NameInMap("AppInstanceGroupModels")]
        [Validation(Required=false)]
        public List<ListAppInstanceGroupResponseBodyAppInstanceGroupModels> AppInstanceGroupModels { get; set; }
        public class ListAppInstanceGroupResponseBodyAppInstanceGroupModels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>img-8z4nztpaqvay4****</para>
            /// </summary>
            [NameInMap("AppCenterImageId")]
            [Validation(Required=false)]
            public string AppCenterImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            [NameInMap("AppInstanceGroupName")]
            [Validation(Required=false)]
            public string AppInstanceGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b>dynamic</b></para>
            /// </summary>
            [NameInMap("AppInstanceType")]
            [Validation(Required=false)]
            public string AppInstanceType { get; set; }

            /// <summary>
            /// <para>策略ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-g3k5wa2ms2****</para>
            /// </summary>
            [NameInMap("AppPolicyId")]
            [Validation(Required=false)]
            public string AppPolicyId { get; set; }

            [NameInMap("AppPolicyImageCheck")]
            [Validation(Required=false)]
            public bool? AppPolicyImageCheck { get; set; }

            [NameInMap("AppPolicyVersion")]
            [Validation(Required=false)]
            public string AppPolicyVersion { get; set; }

            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<ListAppInstanceGroupResponseBodyAppInstanceGroupModelsApps> Apps { get; set; }
            public class ListAppInstanceGroupResponseBodyAppInstanceGroupModelsApps : TeaModel {
                /// <summary>
                /// <para>应用图标。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://app-center-icon-****.png">https://app-center-icon-****.png</a></para>
                /// </summary>
                [NameInMap("AppIcon")]
                [Validation(Required=false)]
                public string AppIcon { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ca-i87mycyn419nu****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>应用版本。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// <para>应用版本名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>初始版本</para>
                /// </summary>
                [NameInMap("AppVersionName")]
                [Validation(Required=false)]
                public string AppVersionName { get; set; }

            }

            /// <summary>
            /// <para>售卖模式。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node</para>
            /// </summary>
            [NameInMap("ChargeResourceMode")]
            [Validation(Required=false)]
            public string ChargeResourceMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-04-27T16:00:00.000+00:00</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-04-26T15:06:16.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxAmount")]
            [Validation(Required=false)]
            public int? MaxAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinAmount")]
            [Validation(Required=false)]
            public int? MinAmount { get; set; }

            [NameInMap("NodePool")]
            [Validation(Required=false)]
            public List<ListAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePool> NodePool { get; set; }
            public class ListAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePool : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                [NameInMap("MaxIdleAppInstanceAmount")]
                [Validation(Required=false)]
                public int? MaxIdleAppInstanceAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("MaxScalingAmount")]
                [Validation(Required=false)]
                public int? MaxScalingAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeAmount")]
                [Validation(Required=false)]
                public int? NodeAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("NodeCapacity")]
                [Validation(Required=false)]
                public int? NodeCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>appstreaming.vgpu.4c8g.2g</para>
                /// </summary>
                [NameInMap("NodeInstanceType")]
                [Validation(Required=false)]
                public string NodeInstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rg-g6922kced36hx****</para>
                /// </summary>
                [NameInMap("NodePoolId")]
                [Validation(Required=false)]
                public string NodePoolId { get; set; }

                [NameInMap("NodeTypeName")]
                [Validation(Required=false)]
                public string NodeTypeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeUsed")]
                [Validation(Required=false)]
                public int? NodeUsed { get; set; }

                [NameInMap("RecurrenceSchedules")]
                [Validation(Required=false)]
                public List<ListAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedules> RecurrenceSchedules { get; set; }
                public class ListAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedules : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Weekly</para>
                    /// </summary>
                    [NameInMap("RecurrenceType")]
                    [Validation(Required=false)]
                    public string RecurrenceType { get; set; }

                    [NameInMap("RecurrenceValues")]
                    [Validation(Required=false)]
                    public List<int?> RecurrenceValues { get; set; }

                    [NameInMap("TimerPeriods")]
                    [Validation(Required=false)]
                    public List<ListAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedulesTimerPeriods> TimerPeriods { get; set; }
                    public class ListAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedulesTimerPeriods : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Amount")]
                        [Validation(Required=false)]
                        public int? Amount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>11:00</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>09:30</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ScalingDownAfterIdleMinutes")]
                [Validation(Required=false)]
                public int? ScalingDownAfterIdleMinutes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("ScalingNodeAmount")]
                [Validation(Required=false)]
                public int? ScalingNodeAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("ScalingNodeUsed")]
                [Validation(Required=false)]
                public int? ScalingNodeUsed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ScalingStep")]
                [Validation(Required=false)]
                public int? ScalingStep { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>85</para>
                /// </summary>
                [NameInMap("ScalingUsageThreshold")]
                [Validation(Required=false)]
                public string ScalingUsageThreshold { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-09-08</para>
                /// </summary>
                [NameInMap("StrategyDisableDate")]
                [Validation(Required=false)]
                public string StrategyDisableDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-08-01</para>
                /// </summary>
                [NameInMap("StrategyEnableDate")]
                [Validation(Required=false)]
                public string StrategyEnableDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NODE_FIXED</para>
                /// </summary>
                [NameInMap("StrategyType")]
                [Validation(Required=false)]
                public string StrategyType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("WarmUp")]
                [Validation(Required=false)]
                public bool? WarmUp { get; set; }

            }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("OtaInfo")]
            [Validation(Required=false)]
            public ListAppInstanceGroupResponseBodyAppInstanceGroupModelsOtaInfo OtaInfo { get; set; }
            public class ListAppInstanceGroupResponseBodyAppInstanceGroupModelsOtaInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0.1-D-20220630.11****</para>
                /// </summary>
                [NameInMap("NewOtaVersion")]
                [Validation(Required=false)]
                public string NewOtaVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0.1-D-20220615.11****</para>
                /// </summary>
                [NameInMap("OtaVersion")]
                [Validation(Required=false)]
                public string OtaVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ota-e49929gv8acz5****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CloudApp</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ReserveAmountRatio")]
            [Validation(Required=false)]
            public string ReserveAmountRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ReserveMaxAmount")]
            [Validation(Required=false)]
            public int? ReserveMaxAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReserveMinAmount")]
            [Validation(Required=false)]
            public int? ReserveMinAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScalingDownAfterIdleMinutes")]
            [Validation(Required=false)]
            public int? ScalingDownAfterIdleMinutes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ScalingStep")]
            [Validation(Required=false)]
            public int? ScalingStep { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>85</para>
            /// </summary>
            [NameInMap("ScalingUsageThreshold")]
            [Validation(Required=false)]
            public string ScalingUsageThreshold { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("SessionTimeout")]
            [Validation(Required=false)]
            public string SessionTimeout { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SkipUserAuthCheck")]
            [Validation(Required=false)]
            public bool? SkipUserAuthCheck { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>spec-8o18t8uc31qib0****</para>
            /// </summary>
            [NameInMap("SpecId")]
            [Validation(Required=false)]
            public string SpecId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
