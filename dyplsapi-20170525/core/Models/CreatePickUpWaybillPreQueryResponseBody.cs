// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillPreQueryResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreatePickUpWaybillPreQueryResponseBodyData Data { get; set; }
        public class CreatePickUpWaybillPreQueryResponseBodyData : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("CpTimeSelectList")]
            [Validation(Required=false)]
            public List<CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectList> CpTimeSelectList { get; set; }
            public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectList : TeaModel {
                [NameInMap("AppointTimes")]
                [Validation(Required=false)]
                public List<CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimes> AppointTimes { get; set; }
                public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimes : TeaModel {
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    [NameInMap("DateSelectable")]
                    [Validation(Required=false)]
                    public bool? DateSelectable { get; set; }

                    [NameInMap("TimeList")]
                    [Validation(Required=false)]
                    public List<CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimesTimeList> TimeList { get; set; }
                    public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListAppointTimesTimeList : TeaModel {
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        [NameInMap("SelectDisableTip")]
                        [Validation(Required=false)]
                        public string SelectDisableTip { get; set; }

                        [NameInMap("Selectable")]
                        [Validation(Required=false)]
                        public bool? Selectable { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                [NameInMap("PrePrice")]
                [Validation(Required=false)]
                public string PrePrice { get; set; }

                [NameInMap("RealTime")]
                [Validation(Required=false)]
                public CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListRealTime RealTime { get; set; }
                public class CreatePickUpWaybillPreQueryResponseBodyDataCpTimeSelectListRealTime : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("SelectDisableTip")]
                    [Validation(Required=false)]
                    public string SelectDisableTip { get; set; }

                    [NameInMap("Selectable")]
                    [Validation(Required=false)]
                    public bool? Selectable { get; set; }

                }

            }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
