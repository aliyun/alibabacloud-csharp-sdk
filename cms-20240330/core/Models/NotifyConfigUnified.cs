// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyConfigUnified : TeaModel {
        /// <summary>
        /// <para>The days of the week on which notifications are sent, 1-7.</para>
        /// </summary>
        [NameInMap("activeDays")]
        [Validation(Required=false)]
        public List<int?> ActiveDays { get; set; }

        /// <summary>
        /// <para>The daily notification effective end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20:00</para>
        /// </summary>
        [NameInMap("activeEndTime")]
        [Validation(Required=false)]
        public string ActiveEndTime { get; set; }

        /// <summary>
        /// <para>The daily notification effective start time.</para>
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
        /// <para>The list of notification policy IDs (type=NOTIFY_POLICY, currently a maximum of 1 is supported. Mutually exclusive with the DIRECT_NOTIFY fields channels/silenceTimeSecs/activeDays/activeStartTime/activeEndTime/utcOffset).</para>
        /// </summary>
        [NameInMap("notifyStrategies")]
        [Validation(Required=false)]
        public List<string> NotifyStrategies { get; set; }

        /// <summary>
        /// <para>Specifies whether to send recovery notifications (type=DIRECT_NOTIFY). Default value: true. Each severity level in severityChannels can independently override this setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("sendRecoverNotification")]
        [Validation(Required=false)]
        public bool? SendRecoverNotification { get; set; }

        /// <summary>
        /// <para>The Notification Recipients and channels configured by severity level (type=DIRECT_NOTIFY, new mode, mutually exclusive with channels). The key is the severity level: CRITICAL/ERROR/WARNING/INFO.</para>
        /// </summary>
        [NameInMap("severityChannels")]
        [Validation(Required=false)]
        public Dictionary<string, SeverityNotifyConfig> SeverityChannels { get; set; }

        /// <summary>
        /// <para>The mute for epoch in seconds.</para>
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
