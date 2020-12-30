// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DescAccountSummaryResponseBody : TeaModel {
        [NameInMap("DayuStatus")]
        [Validation(Required=false)]
        public int? DayuStatus { get; set; }

        [NameInMap("SmsRecord")]
        [Validation(Required=false)]
        public int? SmsRecord { get; set; }

        [NameInMap("MonthQuota")]
        [Validation(Required=false)]
        public int? MonthQuota { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Receivers")]
        [Validation(Required=false)]
        public int? Receivers { get; set; }

        [NameInMap("SmsTemplates")]
        [Validation(Required=false)]
        public int? SmsTemplates { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public int? Templates { get; set; }

        [NameInMap("DailyQuota")]
        [Validation(Required=false)]
        public int? DailyQuota { get; set; }

        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public int? UserStatus { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=false)]
        public int? Domains { get; set; }

        [NameInMap("QuotaLevel")]
        [Validation(Required=false)]
        public int? QuotaLevel { get; set; }

        [NameInMap("SmsSign")]
        [Validation(Required=false)]
        public int? SmsSign { get; set; }

        [NameInMap("MaxQuotaLevel")]
        [Validation(Required=false)]
        public int? MaxQuotaLevel { get; set; }

        [NameInMap("EnableTimes")]
        [Validation(Required=false)]
        public int? EnableTimes { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public int? Tags { get; set; }

        [NameInMap("MailAddresses")]
        [Validation(Required=false)]
        public int? MailAddresses { get; set; }

    }

}
