// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyRouteForSubscription : TeaModel {
        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<NotifyRouteForSubscriptionChannels> Channels { get; set; }
        public class NotifyRouteForSubscriptionChannels : TeaModel {
            [NameInMap("channelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            [NameInMap("enabledSubChannels")]
            [Validation(Required=false)]
            public List<string> EnabledSubChannels { get; set; }

            [NameInMap("receivers")]
            [Validation(Required=false)]
            public List<string> Receivers { get; set; }

        }

        [NameInMap("effectTimeRange")]
        [Validation(Required=false)]
        public NotifyRouteForSubscriptionEffectTimeRange EffectTimeRange { get; set; }
        public class NotifyRouteForSubscriptionEffectTimeRange : TeaModel {
            [NameInMap("dayInWeek")]
            [Validation(Required=false)]
            public List<int?> DayInWeek { get; set; }

            [NameInMap("endTimeInMinute")]
            [Validation(Required=false)]
            public int? EndTimeInMinute { get; set; }

            [NameInMap("startTimeInMinute")]
            [Validation(Required=false)]
            public int? StartTimeInMinute { get; set; }

            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

    }

}
