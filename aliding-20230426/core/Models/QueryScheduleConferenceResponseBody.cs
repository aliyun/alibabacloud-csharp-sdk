// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryScheduleConferenceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1687928400000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[ &quot;+86123xxxx&quot; ]</para>
        /// </summary>
        [NameInMap("phones")]
        [Validation(Required=false)]
        public List<string> Phones { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>838 722 xxxxx</para>
        /// </summary>
        [NameInMap("roomCode")]
        [Validation(Required=false)]
        public string RoomCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2a489c68-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("scheduleConferenceId")]
        [Validation(Required=false)]
        public string ScheduleConferenceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1687924800000</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>预约会议标题</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://meeting.dingtalk.com/j/Bsbp3ixxxxxUyJJ9">https://meeting.dingtalk.com/j/Bsbp3ixxxxxUyJJ9</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
