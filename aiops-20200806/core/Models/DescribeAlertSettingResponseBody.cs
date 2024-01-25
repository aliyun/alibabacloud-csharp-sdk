// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class DescribeAlertSettingResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAlertSettingResponseBodyData> Data { get; set; }
        public class DescribeAlertSettingResponseBodyData : TeaModel {
            [NameInMap("AlarmLevel")]
            [Validation(Required=false)]
            public string AlarmLevel { get; set; }

            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            [NameInMap("AlertSettingId")]
            [Validation(Required=false)]
            public long? AlertSettingId { get; set; }

            [NameInMap("BusinessGroupIds")]
            [Validation(Required=false)]
            public string BusinessGroupIds { get; set; }

            [NameInMap("BusinessGroupNames")]
            [Validation(Required=false)]
            public string BusinessGroupNames { get; set; }

            [NameInMap("ContactIds")]
            [Validation(Required=false)]
            public string ContactIds { get; set; }

            [NameInMap("ContactNames")]
            [Validation(Required=false)]
            public string ContactNames { get; set; }

            [NameInMap("SendDingtalkNotice")]
            [Validation(Required=false)]
            public bool? SendDingtalkNotice { get; set; }

            [NameInMap("SendEmailNotice")]
            [Validation(Required=false)]
            public bool? SendEmailNotice { get; set; }

            [NameInMap("SendSmsNotice")]
            [Validation(Required=false)]
            public bool? SendSmsNotice { get; set; }

            [NameInMap("SettingStatus")]
            [Validation(Required=false)]
            public long? SettingStatus { get; set; }

            [NameInMap("StopDuration")]
            [Validation(Required=false)]
            public long? StopDuration { get; set; }

            [NameInMap("TotalBusinessResourceNumber")]
            [Validation(Required=false)]
            public long? TotalBusinessResourceNumber { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
