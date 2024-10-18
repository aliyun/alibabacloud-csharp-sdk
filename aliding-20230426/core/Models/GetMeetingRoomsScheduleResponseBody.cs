// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetMeetingRoomsScheduleResponseBody : TeaModel {
        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scheduleInformation")]
        [Validation(Required=false)]
        public List<GetMeetingRoomsScheduleResponseBodyScheduleInformation> ScheduleInformation { get; set; }
        public class GetMeetingRoomsScheduleResponseBodyScheduleInformation : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>无权限</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4002f89xxxxx</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-01-02T10:15:30+08:00</para>
                    /// </summary>
                    [NameInMap("DateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Asia/Shanghai</para>
                    /// </summary>
                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>UzZvxxxxx</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                [NameInMap("Organizer")]
                [Validation(Required=false)]
                public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer Organizer { get; set; }
                public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>012345</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }

                [NameInMap("Start")]
                [Validation(Required=false)]
                public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart Start { get; set; }
                public class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-01-02T10:15:30+08:00</para>
                    /// </summary>
                    [NameInMap("DateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Asia/Shanghai</para>
                    /// </summary>
                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BUSY</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

    }

}
