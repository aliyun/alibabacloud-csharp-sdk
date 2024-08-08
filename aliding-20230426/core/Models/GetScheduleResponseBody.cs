// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetScheduleResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scheduleInformation")]
        [Validation(Required=false)]
        public List<GetScheduleResponseBodyScheduleInformation> ScheduleInformation { get; set; }
        public class GetScheduleResponseBodyScheduleInformation : TeaModel {
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            [NameInMap("ScheduleItems")]
            [Validation(Required=false)]
            public List<GetScheduleResponseBodyScheduleInformationScheduleItems> ScheduleItems { get; set; }
            public class GetScheduleResponseBodyScheduleInformationScheduleItems : TeaModel {
                [NameInMap("End")]
                [Validation(Required=false)]
                public GetScheduleResponseBodyScheduleInformationScheduleItemsEnd End { get; set; }
                public class GetScheduleResponseBodyScheduleInformationScheduleItemsEnd : TeaModel {
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    [NameInMap("DateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }

                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                [NameInMap("Start")]
                [Validation(Required=false)]
                public GetScheduleResponseBodyScheduleInformationScheduleItemsStart Start { get; set; }
                public class GetScheduleResponseBodyScheduleInformationScheduleItemsStart : TeaModel {
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    [NameInMap("DateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }

                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
