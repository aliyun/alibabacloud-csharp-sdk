// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class DescribeAlertSettingByIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAlertSettingByIdResponseBodyData Data { get; set; }
        public class DescribeAlertSettingByIdResponseBodyData : TeaModel {
            [NameInMap("AlarmLevel")]
            [Validation(Required=false)]
            public string AlarmLevel { get; set; }

            [NameInMap("AlertBusinessSettingId")]
            [Validation(Required=false)]
            public long? AlertBusinessSettingId { get; set; }

            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            [NameInMap("DataCreateTime")]
            [Validation(Required=false)]
            public string DataCreateTime { get; set; }

            [NameInMap("DataCreateUser")]
            [Validation(Required=false)]
            public string DataCreateUser { get; set; }

            [NameInMap("DataModifyTime")]
            [Validation(Required=false)]
            public string DataModifyTime { get; set; }

            [NameInMap("DataModifyUser")]
            [Validation(Required=false)]
            public string DataModifyUser { get; set; }

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

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public long? Uid { get; set; }

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

    }

}
