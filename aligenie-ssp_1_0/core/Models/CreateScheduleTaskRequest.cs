// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CreateScheduleTaskRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public CreateScheduleTaskRequestDeviceInfo DeviceInfo { get; set; }
        public class CreateScheduleTaskRequestDeviceInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public CreateScheduleTaskRequestPayload Payload { get; set; }
        public class CreateScheduleTaskRequestPayload : TeaModel {
            [NameInMap("ActionDTOs")]
            [Validation(Required=false)]
            public List<CreateScheduleTaskRequestPayloadActionDTOs> ActionDTOs { get; set; }
            public class CreateScheduleTaskRequestPayloadActionDTOs : TeaModel {
                [NameInMap("customAction")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomAction { get; set; }

            }

            [NameInMap("IdempotentId")]
            [Validation(Required=false)]
            public string IdempotentId { get; set; }

            [NameInMap("ScheduleDTO")]
            [Validation(Required=false)]
            public CreateScheduleTaskRequestPayloadScheduleDTO ScheduleDTO { get; set; }
            public class CreateScheduleTaskRequestPayloadScheduleDTO : TeaModel {
                [NameInMap("Once")]
                [Validation(Required=false)]
                public CreateScheduleTaskRequestPayloadScheduleDTOOnce Once { get; set; }
                public class CreateScheduleTaskRequestPayloadScheduleDTOOnce : TeaModel {
                    [NameInMap("Day")]
                    [Validation(Required=false)]
                    public int? Day { get; set; }

                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                    [NameInMap("Month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    [NameInMap("Year")]
                    [Validation(Required=false)]
                    public int? Year { get; set; }

                }

                [NameInMap("ScheduleEndTime")]
                [Validation(Required=false)]
                public long? ScheduleEndTime { get; set; }

                [NameInMap("ScheduleStartTime")]
                [Validation(Required=false)]
                public long? ScheduleStartTime { get; set; }

                [NameInMap("ScheduleType")]
                [Validation(Required=false)]
                public string ScheduleType { get; set; }

                [NameInMap("StatutoryWorkingDay")]
                [Validation(Required=false)]
                public CreateScheduleTaskRequestPayloadScheduleDTOStatutoryWorkingDay StatutoryWorkingDay { get; set; }
                public class CreateScheduleTaskRequestPayloadScheduleDTOStatutoryWorkingDay : TeaModel {
                    [NameInMap("Hours")]
                    [Validation(Required=false)]
                    public List<int?> Hours { get; set; }

                    [NameInMap("Minutes")]
                    [Validation(Required=false)]
                    public List<int?> Minutes { get; set; }

                }

                [NameInMap("Weekly")]
                [Validation(Required=false)]
                public CreateScheduleTaskRequestPayloadScheduleDTOWeekly Weekly { get; set; }
                public class CreateScheduleTaskRequestPayloadScheduleDTOWeekly : TeaModel {
                    [NameInMap("DaysOfWeek")]
                    [Validation(Required=false)]
                    public List<int?> DaysOfWeek { get; set; }

                    [NameInMap("Hours")]
                    [Validation(Required=false)]
                    public List<int?> Hours { get; set; }

                    [NameInMap("Minutes")]
                    [Validation(Required=false)]
                    public List<int?> Minutes { get; set; }

                }

            }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CreateScheduleTaskRequestUserInfo UserInfo { get; set; }
        public class CreateScheduleTaskRequestUserInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
