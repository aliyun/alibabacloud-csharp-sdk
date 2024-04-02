// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeNotificationSettingResponseBody : TeaModel {
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("RealtimeMessageList")]
        [Validation(Required=false)]
        public List<string> RealtimeMessageList { get; set; }

        [NameInMap("ReminderModeList")]
        [Validation(Required=false)]
        public List<string> ReminderModeList { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScheduleMessageTime")]
        [Validation(Required=false)]
        public int? ScheduleMessageTime { get; set; }

        [NameInMap("ScheduleMessageTimeZone")]
        [Validation(Required=false)]
        public int? ScheduleMessageTimeZone { get; set; }

    }

}
