// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class ListRemindersResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public ListRemindersResponseBodyModel Model { get; set; }
        public class ListRemindersResponseBodyModel : TeaModel {
            [NameInMap("RemindResponses")]
            [Validation(Required=false)]
            public List<ListRemindersResponseBodyModelRemindResponses> RemindResponses { get; set; }
            public class ListRemindersResponseBodyModelRemindResponses : TeaModel {
                [NameInMap("ActionTopic")]
                [Validation(Required=false)]
                public string ActionTopic { get; set; }

                [NameInMap("DayDesc")]
                [Validation(Required=false)]
                public string DayDesc { get; set; }

                [NameInMap("RecurrenceRule")]
                [Validation(Required=false)]
                public ListRemindersResponseBodyModelRemindResponsesRecurrenceRule RecurrenceRule { get; set; }
                public class ListRemindersResponseBodyModelRemindResponsesRecurrenceRule : TeaModel {
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
                    public string EndDateTime { get; set; }

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
                    public string StartDateTime { get; set; }

                    [NameInMap("Year")]
                    [Validation(Required=false)]
                    public int? Year { get; set; }

                }

                [NameInMap("RemindId")]
                [Validation(Required=false)]
                public long? RemindId { get; set; }

                [NameInMap("RemindTime")]
                [Validation(Required=false)]
                public string RemindTime { get; set; }

                [NameInMap("RepeatCount")]
                [Validation(Required=false)]
                public int? RepeatCount { get; set; }

                [NameInMap("Week")]
                [Validation(Required=false)]
                public string Week { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
