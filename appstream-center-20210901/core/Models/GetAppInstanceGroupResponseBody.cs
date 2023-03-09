// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetAppInstanceGroupResponseBody : TeaModel {
        /// <summary>
        /// AppInstanceGroupModels
        /// </summary>
        [NameInMap("AppInstanceGroupModels")]
        [Validation(Required=false)]
        public GetAppInstanceGroupResponseBodyAppInstanceGroupModels AppInstanceGroupModels { get; set; }
        public class GetAppInstanceGroupResponseBodyAppInstanceGroupModels : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            [NameInMap("AppCenterImageId")]
            [Validation(Required=false)]
            public string AppCenterImageId { get; set; }

            [NameInMap("AppCenterImageName")]
            [Validation(Required=false)]
            public string AppCenterImageName { get; set; }

            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            [NameInMap("AppInstanceGroupName")]
            [Validation(Required=false)]
            public string AppInstanceGroupName { get; set; }

            [NameInMap("AppInstanceType")]
            [Validation(Required=false)]
            public string AppInstanceType { get; set; }

            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<GetAppInstanceGroupResponseBodyAppInstanceGroupModelsApps> Apps { get; set; }
            public class GetAppInstanceGroupResponseBodyAppInstanceGroupModelsApps : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

            }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("NodePool")]
            [Validation(Required=false)]
            public List<GetAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePool> NodePool { get; set; }
            public class GetAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePool : TeaModel {
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                [NameInMap("MaxScalingAmount")]
                [Validation(Required=false)]
                public int? MaxScalingAmount { get; set; }

                [NameInMap("NodeAmount")]
                [Validation(Required=false)]
                public int? NodeAmount { get; set; }

                [NameInMap("NodeCapacity")]
                [Validation(Required=false)]
                public int? NodeCapacity { get; set; }

                [NameInMap("NodeInstanceType")]
                [Validation(Required=false)]
                public string NodeInstanceType { get; set; }

                [NameInMap("NodePoolId")]
                [Validation(Required=false)]
                public string NodePoolId { get; set; }

                [NameInMap("NodeTypeName")]
                [Validation(Required=false)]
                public string NodeTypeName { get; set; }

                [NameInMap("NodeUsed")]
                [Validation(Required=false)]
                public int? NodeUsed { get; set; }

                [NameInMap("RecurrenceSchedules")]
                [Validation(Required=false)]
                public List<GetAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedules> RecurrenceSchedules { get; set; }
                public class GetAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedules : TeaModel {
                    [NameInMap("RecurrenceType")]
                    [Validation(Required=false)]
                    public string RecurrenceType { get; set; }

                    [NameInMap("RecurrenceValues")]
                    [Validation(Required=false)]
                    public List<int?> RecurrenceValues { get; set; }

                    [NameInMap("TimerPeriods")]
                    [Validation(Required=false)]
                    public List<GetAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedulesTimerPeriods> TimerPeriods { get; set; }
                    public class GetAppInstanceGroupResponseBodyAppInstanceGroupModelsNodePoolRecurrenceSchedulesTimerPeriods : TeaModel {
                        [NameInMap("Amount")]
                        [Validation(Required=false)]
                        public int? Amount { get; set; }

                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                [NameInMap("ScalingDownAfterIdleMinutes")]
                [Validation(Required=false)]
                public int? ScalingDownAfterIdleMinutes { get; set; }

                [NameInMap("ScalingNodeAmount")]
                [Validation(Required=false)]
                public int? ScalingNodeAmount { get; set; }

                [NameInMap("ScalingNodeUsed")]
                [Validation(Required=false)]
                public int? ScalingNodeUsed { get; set; }

                [NameInMap("ScalingStep")]
                [Validation(Required=false)]
                public int? ScalingStep { get; set; }

                [NameInMap("ScalingUsageThreshold")]
                [Validation(Required=false)]
                public string ScalingUsageThreshold { get; set; }

                [NameInMap("StrategyDisableDate")]
                [Validation(Required=false)]
                public string StrategyDisableDate { get; set; }

                [NameInMap("StrategyEnableDate")]
                [Validation(Required=false)]
                public string StrategyEnableDate { get; set; }

                [NameInMap("StrategyType")]
                [Validation(Required=false)]
                public string StrategyType { get; set; }

                [NameInMap("WarmUp")]
                [Validation(Required=false)]
                public bool? WarmUp { get; set; }

            }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("OtaInfo")]
            [Validation(Required=false)]
            public GetAppInstanceGroupResponseBodyAppInstanceGroupModelsOtaInfo OtaInfo { get; set; }
            public class GetAppInstanceGroupResponseBodyAppInstanceGroupModelsOtaInfo : TeaModel {
                [NameInMap("NewOtaVersion")]
                [Validation(Required=false)]
                public string NewOtaVersion { get; set; }

                [NameInMap("OtaVersion")]
                [Validation(Required=false)]
                public string OtaVersion { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            [NameInMap("SessionTimeout")]
            [Validation(Required=false)]
            public string SessionTimeout { get; set; }

            [NameInMap("SpecId")]
            [Validation(Required=false)]
            public string SpecId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
