// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyRouteForSubscription : TeaModel {
        /// <summary>
        /// <para>An array of objects, each defining a notification channel.</para>
        /// </summary>
        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<NotifyRouteForSubscriptionChannels> Channels { get; set; }
        public class NotifyRouteForSubscriptionChannels : TeaModel {
            /// <summary>
            /// <para>The channel type. For example, <c>Email</c>, <c>SMS</c>, or <c>Webhook</c>.</para>
            /// </summary>
            [NameInMap("channelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// <para>A list of enabled sub-channels. Applicable to channels that support finer-grained topics or categories.</para>
            /// </summary>
            [NameInMap("enabledSubChannels")]
            [Validation(Required=false)]
            public List<string> EnabledSubChannels { get; set; }

            /// <summary>
            /// <para>A list of notification receivers. The receiver format depends on the <c>channelType</c>.</para>
            /// </summary>
            [NameInMap("receivers")]
            [Validation(Required=false)]
            public List<string> Receivers { get; set; }

        }

        /// <summary>
        /// <para>The active period for the notification rule.</para>
        /// </summary>
        [NameInMap("effectTimeRange")]
        [Validation(Required=false)]
        public NotifyRouteForSubscriptionEffectTimeRange EffectTimeRange { get; set; }
        public class NotifyRouteForSubscriptionEffectTimeRange : TeaModel {
            /// <summary>
            /// <para>The active days of the week, specified as an array of integers.</para>
            /// </summary>
            [NameInMap("dayInWeek")]
            [Validation(Required=false)]
            public List<int?> DayInWeek { get; set; }

            /// <summary>
            /// <para>The end of the active period, in minutes from 00:00. The value ranges from 0 to 1439.</para>
            /// </summary>
            [NameInMap("endTimeInMinute")]
            [Validation(Required=false)]
            public int? EndTimeInMinute { get; set; }

            /// <summary>
            /// <para>The start of the active period, in minutes from 00:00. The value ranges from 0 to 1439.</para>
            /// </summary>
            [NameInMap("startTimeInMinute")]
            [Validation(Required=false)]
            public int? StartTimeInMinute { get; set; }

            /// <summary>
            /// <para>The time zone for the effect time range, specified in the IANA Time Zone Database format. For example, <c>UTC</c> or <c>Asia/Shanghai</c>.</para>
            /// </summary>
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

    }

}
