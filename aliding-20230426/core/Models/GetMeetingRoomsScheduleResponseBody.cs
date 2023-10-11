// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetMeetingRoomsScheduleResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scheduleInformation")]
        [Validation(Required=false)]
        public List<GetMeetingRoomsScheduleResponseBodyScheduleInformation> ScheduleInformation { get; set; }
        public class GetMeetingRoomsScheduleResponseBodyScheduleInformation : TeaModel {
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("ScheduleItems")]
            [Validation(Required=false)]
            public List<GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems> ScheduleItems { get; set; }
            public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems : TeaModel {
                [NameInMap("End")]
                [Validation(Required=false)]
                public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd End { get; set; }
                public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd : TeaModel {
                    [NameInMap("DateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }

                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                [NameInMap("Organizer")]
                [Validation(Required=false)]
                public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer Organizer { get; set; }
                public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }

                [NameInMap("Start")]
                [Validation(Required=false)]
                public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart Start { get; set; }
                public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart : TeaModel {
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

        }

    }

}
