// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CreateAlarmRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public CreateAlarmRequestDeviceInfo DeviceInfo { get; set; }
        public class CreateAlarmRequestDeviceInfo : TeaModel {
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
        public CreateAlarmRequestPayload Payload { get; set; }
        public class CreateAlarmRequestPayload : TeaModel {
            [NameInMap("MusicInfo")]
            [Validation(Required=false)]
            public CreateAlarmRequestPayloadMusicInfo MusicInfo { get; set; }
            public class CreateAlarmRequestPayloadMusicInfo : TeaModel {
                [NameInMap("MusicId")]
                [Validation(Required=false)]
                public long? MusicId { get; set; }

                [NameInMap("MusicName")]
                [Validation(Required=false)]
                public string MusicName { get; set; }

                [NameInMap("MusicType")]
                [Validation(Required=false)]
                public long? MusicType { get; set; }

                [NameInMap("MusicTypeName")]
                [Validation(Required=false)]
                public string MusicTypeName { get; set; }

                [NameInMap("MusicUrl")]
                [Validation(Required=false)]
                public string MusicUrl { get; set; }

            }

            [NameInMap("ScheduleInfo")]
            [Validation(Required=false)]
            public CreateAlarmRequestPayloadScheduleInfo ScheduleInfo { get; set; }
            public class CreateAlarmRequestPayloadScheduleInfo : TeaModel {
                [NameInMap("Once")]
                [Validation(Required=false)]
                public CreateAlarmRequestPayloadScheduleInfoOnce Once { get; set; }
                public class CreateAlarmRequestPayloadScheduleInfoOnce : TeaModel {
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

                [NameInMap("StatutoryWorkingDay")]
                [Validation(Required=false)]
                public CreateAlarmRequestPayloadScheduleInfoStatutoryWorkingDay StatutoryWorkingDay { get; set; }
                public class CreateAlarmRequestPayloadScheduleInfoStatutoryWorkingDay : TeaModel {
                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Weekly")]
                [Validation(Required=false)]
                public CreateAlarmRequestPayloadScheduleInfoWeekly Weekly { get; set; }
                public class CreateAlarmRequestPayloadScheduleInfoWeekly : TeaModel {
                    [NameInMap("DaysOfWeek")]
                    [Validation(Required=false)]
                    public List<int?> DaysOfWeek { get; set; }

                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                }

            }

            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CreateAlarmRequestUserInfo UserInfo { get; set; }
        public class CreateAlarmRequestUserInfo : TeaModel {
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
