// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyRouteForSubscription : TeaModel {
        /// <summary>
        /// <para>The list of notification channels.</para>
        /// </summary>
        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<NotifyRouteForSubscriptionChannels> Channels { get; set; }
        public class NotifyRouteForSubscriptionChannels : TeaModel {
            /// <summary>
            /// <para>The channel type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("channelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// <para>The list of enabled sub-channels.</para>
            /// </summary>
            [NameInMap("enabledSubChannels")]
            [Validation(Required=false)]
            public List<string> EnabledSubChannels { get; set; }

            /// <summary>
            /// <para>The list of receivers.</para>
            /// </summary>
            [NameInMap("receivers")]
            [Validation(Required=false)]
            public List<string> Receivers { get; set; }

        }

        /// <summary>
        /// <para>The effective period configuration.</para>
        /// </summary>
        [NameInMap("effectTimeRange")]
        [Validation(Required=false)]
        public NotifyRouteForSubscriptionEffectTimeRange EffectTimeRange { get; set; }
        public class NotifyRouteForSubscriptionEffectTimeRange : TeaModel {
            /// <summary>
            /// <para>The valid days of the week. Valid values: 0 to 6, where 0 indicates Sunday and 6 indicates Saturday.</para>
            /// </summary>
            [NameInMap("dayInWeek")]
            [Validation(Required=false)]
            public List<int?> DayInWeek { get; set; }

            /// <summary>
            /// <para>The end time of the day in minutes, calculated from 00:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("endTimeInMinute")]
            [Validation(Required=false)]
            public int? EndTimeInMinute { get; set; }

            /// <summary>
            /// <para>The start time of the day in minutes, calculated from 00:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("startTimeInMinute")]
            [Validation(Required=false)]
            public int? StartTimeInMinute { get; set; }

            /// <summary>
            /// <para>The time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700000000</para>
            /// </summary>
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

    }

}
