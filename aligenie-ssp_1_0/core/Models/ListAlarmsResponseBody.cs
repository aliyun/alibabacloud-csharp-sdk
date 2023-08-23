// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListAlarmsResponseBody : TeaModel {
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
        public ListAlarmsResponseBodyResult Result { get; set; }
        public class ListAlarmsResponseBodyResult : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public List<ListAlarmsResponseBodyResultModel> Model { get; set; }
            public class ListAlarmsResponseBodyResultModel : TeaModel {
                [NameInMap("AlarmId")]
                [Validation(Required=false)]
                public long? AlarmId { get; set; }

                [NameInMap("MusicInfo")]
                [Validation(Required=false)]
                public ListAlarmsResponseBodyResultModelMusicInfo MusicInfo { get; set; }
                public class ListAlarmsResponseBodyResultModelMusicInfo : TeaModel {
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
                public ListAlarmsResponseBodyResultModelScheduleInfo ScheduleInfo { get; set; }
                public class ListAlarmsResponseBodyResultModelScheduleInfo : TeaModel {
                    [NameInMap("Once")]
                    [Validation(Required=false)]
                    public ListAlarmsResponseBodyResultModelScheduleInfoOnce Once { get; set; }
                    public class ListAlarmsResponseBodyResultModelScheduleInfoOnce : TeaModel {
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
                    public ListAlarmsResponseBodyResultModelScheduleInfoStatutoryWorkingDay StatutoryWorkingDay { get; set; }
                    public class ListAlarmsResponseBodyResultModelScheduleInfoStatutoryWorkingDay : TeaModel {
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
                    public ListAlarmsResponseBodyResultModelScheduleInfoWeekly Weekly { get; set; }
                    public class ListAlarmsResponseBodyResultModelScheduleInfoWeekly : TeaModel {
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

                [NameInMap("ScheduleTypeDesc")]
                [Validation(Required=false)]
                public string ScheduleTypeDesc { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TriggerDateDesc")]
                [Validation(Required=false)]
                public string TriggerDateDesc { get; set; }

                [NameInMap("TriggerTimeDesc")]
                [Validation(Required=false)]
                public string TriggerTimeDesc { get; set; }

                [NameInMap("Volume")]
                [Validation(Required=false)]
                public int? Volume { get; set; }

            }

            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
