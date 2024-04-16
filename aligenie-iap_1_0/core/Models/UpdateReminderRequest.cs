// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class UpdateReminderRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public UpdateReminderRequestDeviceInfo DeviceInfo { get; set; }
        public class UpdateReminderRequestDeviceInfo : TeaModel {
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
        public UpdateReminderRequestPayload Payload { get; set; }
        public class UpdateReminderRequestPayload : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IsDebug")]
            [Validation(Required=false)]
            public bool? IsDebug { get; set; }

            [NameInMap("RecurrenceRule")]
            [Validation(Required=false)]
            public UpdateReminderRequestPayloadRecurrenceRule RecurrenceRule { get; set; }
            public class UpdateReminderRequestPayloadRecurrenceRule : TeaModel {
                [NameInMap("Day")]
                [Validation(Required=false)]
                public int? Day { get; set; }

                [NameInMap("DaysOfMonth")]
                [Validation(Required=false)]
                public List<int?> DaysOfMonth { get; set; }

                [NameInMap("DaysOfWeek")]
                [Validation(Required=false)]
                public List<int?> DaysOfWeek { get; set; }

                [NameInMap("EndDateTime")]
                [Validation(Required=false)]
                public long? EndDateTime { get; set; }

                [NameInMap("Freq")]
                [Validation(Required=false)]
                public string Freq { get; set; }

                [NameInMap("Hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                [NameInMap("Minute")]
                [Validation(Required=false)]
                public int? Minute { get; set; }

                [NameInMap("Month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                [NameInMap("Second")]
                [Validation(Required=false)]
                public int? Second { get; set; }

                [NameInMap("StartDateTime")]
                [Validation(Required=false)]
                public long? StartDateTime { get; set; }

                [NameInMap("Year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public UpdateReminderRequestUserInfo UserInfo { get; set; }
        public class UpdateReminderRequestUserInfo : TeaModel {
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
