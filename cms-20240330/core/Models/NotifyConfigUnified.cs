// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyConfigUnified : TeaModel {
        /// <summary>
        /// <para>The days of the week when notifications are sent, ranging from 1 to 7.</para>
        /// </summary>
        [NameInMap("activeDays")]
        [Validation(Required=false)]
        public List<int?> ActiveDays { get; set; }

        /// <summary>
        /// <para>The daily end time for the notification effective period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20:00</para>
        /// </summary>
        [NameInMap("activeEndTime")]
        [Validation(Required=false)]
        public string ActiveEndTime { get; set; }

        /// <summary>
        /// <para>The daily start time for the notification effective period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("activeStartTime")]
        [Validation(Required=false)]
        public string ActiveStartTime { get; set; }

        /// <summary>
        /// <para>The list of notification channels.</para>
        /// </summary>
        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<DirectNotifyChannel> Channels { get; set; }

        /// <summary>
        /// <para>The list of notification policy IDs.</para>
        /// </summary>
        [NameInMap("notifyStrategies")]
        [Validation(Required=false)]
        public List<string> NotifyStrategies { get; set; }

        /// <summary>
        /// <para>Specifies whether to send a recovery notification. Default value: true. This setting can be independently overridden for each severity level in severityChannels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("sendRecoverNotification")]
        [Validation(Required=false)]
        public bool? SendRecoverNotification { get; set; }

        /// <summary>
        /// <para>The notification recipients and channels configured for each severity level. The key is the severity level: CRITICAL, ERROR, WARNING, or INFO.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CRITICAL&quot;:{&quot;sendRecoverNotification&quot;:true}}</para>
        /// </summary>
        [NameInMap("severityChannels")]
        [Validation(Required=false)]
        public Dictionary<string, SeverityNotifyConfig> SeverityChannels { get; set; }

        /// <summary>
        /// <para>The mute epoch in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("silenceTimeSecs")]
        [Validation(Required=false)]
        public int? SilenceTimeSecs { get; set; }

        /// <summary>
        /// <para>The notification configuration type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DIRECT_NOTIFY</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UTC time zone offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>+08:00</para>
        /// </summary>
        [NameInMap("utcOffset")]
        [Validation(Required=false)]
        public string UtcOffset { get; set; }

    }

}
