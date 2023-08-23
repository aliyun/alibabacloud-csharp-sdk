// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListSubResponseBody : TeaModel {
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
        public ListSubResponseBodyResult Result { get; set; }
        public class ListSubResponseBodyResult : TeaModel {
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<ListSubResponseBodyResultDataList> DataList { get; set; }
            public class ListSubResponseBodyResultDataList : TeaModel {
                [NameInMap("AlbumId")]
                [Validation(Required=false)]
                public string AlbumId { get; set; }

                [NameInMap("CoverUrl")]
                [Validation(Required=false)]
                public string CoverUrl { get; set; }

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
                public ListSubResponseBodyResultDataListScheduleInfo ScheduleInfo { get; set; }
                public class ListSubResponseBodyResultDataListScheduleInfo : TeaModel {
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

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

            }

            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("TotalPageCount")]
            [Validation(Required=false)]
            public int? TotalPageCount { get; set; }

        }

    }

}
