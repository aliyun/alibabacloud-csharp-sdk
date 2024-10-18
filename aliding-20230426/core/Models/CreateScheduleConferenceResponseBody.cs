// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateScheduleConferenceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>+861234567</para>
        /// </summary>
        [NameInMap("phones")]
        [Validation(Required=false)]
        public List<string> Phones { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>83150xxxxxx</para>
        /// </summary>
        [NameInMap("roomCode")]
        [Validation(Required=false)]
        public string RoomCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5c7c9bb1-b256-4dc5-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("scheduleConferenceId")]
        [Validation(Required=false)]
        public string ScheduleConferenceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://meeting.dingtalk.com/j/knvMq1ixxxx">https://meeting.dingtalk.com/j/knvMq1ixxxx</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
