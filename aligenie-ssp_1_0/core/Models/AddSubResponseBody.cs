// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class AddSubResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddSubResponseBodyResult Result { get; set; }
        public class AddSubResponseBodyResult : TeaModel {
            [NameInMap("AlbumId")]
            [Validation(Required=false)]
            public string AlbumId { get; set; }

            [NameInMap("DailyStudyCnt")]
            [Validation(Required=false)]
            public int? DailyStudyCnt { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("PlayMode")]
            [Validation(Required=false)]
            public string PlayMode { get; set; }

            [NameInMap("ScheduleInfo")]
            [Validation(Required=false)]
            public AddSubResponseBodyResultScheduleInfo ScheduleInfo { get; set; }
            public class AddSubResponseBodyResultScheduleInfo : TeaModel {
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

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
