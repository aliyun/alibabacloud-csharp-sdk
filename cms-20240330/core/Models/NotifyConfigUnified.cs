// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyConfigUnified : TeaModel {
        /// <summary>
        /// <para>The active days of the week.</para>
        /// </summary>
        [NameInMap("activeDays")]
        [Validation(Required=false)]
        public List<int?> ActiveDays { get; set; }

        /// <summary>
        /// <para>The end of the daily active time window. On active days, the system sends notifications only before this time. Format: <c>HH:mm</c>.</para>
        /// </summary>
        [NameInMap("activeEndTime")]
        [Validation(Required=false)]
        public string ActiveEndTime { get; set; }

        /// <summary>
        /// <para>The start of the daily active time window. On active days, the system sends notifications only after this time. Format: <c>HH:mm</c>.</para>
        /// </summary>
        [NameInMap("activeStartTime")]
        [Validation(Required=false)]
        public string ActiveStartTime { get; set; }

        /// <summary>
        /// <para>The notification channels that receive alerts.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<DirectNotifyChannel> Channels { get; set; }

        /// <summary>
        /// <para>The silence time in seconds. After sending a notification, the system suppresses new notifications for the same alert for this duration.</para>
        /// </summary>
        [NameInMap("silenceTimeSecs")]
        [Validation(Required=false)]
        public int? SilenceTimeSecs { get; set; }

        /// <summary>
        /// <para>The type of the notification configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UTC offset for <c>activeStartTime</c> and <c>activeEndTime</c>. The format is <c>[+/-]HH:mm</c>. For example, <c>+08:00</c> represents the UTC+8 time zone.</para>
        /// </summary>
        [NameInMap("utcOffset")]
        [Validation(Required=false)]
        public string UtcOffset { get; set; }

    }

}
