// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class AddMeetingRoomsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>primary</para>
        /// </summary>
        [NameInMap("CalendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>U5Kxxxxx</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MeetingRoomsToAdd")]
        [Validation(Required=false)]
        public List<AddMeetingRoomsRequestMeetingRoomsToAdd> MeetingRoomsToAdd { get; set; }
        public class AddMeetingRoomsRequestMeetingRoomsToAdd : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4002fxxxxx</para>
            /// </summary>
            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

        }

    }

}
