// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class UpdateNotificationSettingRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("RealtimeMessageList")]
        [Validation(Required=false)]
        public string RealtimeMessageList { get; set; }

        [NameInMap("ReminderModeList")]
        [Validation(Required=false)]
        public string ReminderModeList { get; set; }

        [NameInMap("ScheduleMessageTime")]
        [Validation(Required=false)]
        public int? ScheduleMessageTime { get; set; }

        [NameInMap("ScheduleMessageTimeZone")]
        [Validation(Required=false)]
        public int? ScheduleMessageTimeZone { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
