// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaAlarmResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("QuotaAlarm")]
        [Validation(Required=false)]
        public GetQuotaAlarmResponseBodyQuotaAlarm QuotaAlarm { get; set; }
        public class GetQuotaAlarmResponseBodyQuotaAlarm : TeaModel {
            [NameInMap("ThresholdPercent")]
            [Validation(Required=false)]
            public float? ThresholdPercent { get; set; }
            [NameInMap("QuotaDimension")]
            [Validation(Required=false)]
            public Dictionary<string, string> QuotaDimension { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }
            [NameInMap("AlarmName")]
            [Validation(Required=false)]
            public string AlarmName { get; set; }
            [NameInMap("NotifyTarget")]
            [Validation(Required=false)]
            public string NotifyTarget { get; set; }
            [NameInMap("NotifyChannels")]
            [Validation(Required=false)]
            public List<string> NotifyChannels { get; set; }
            [NameInMap("QuotaUsage")]
            [Validation(Required=false)]
            public float? QuotaUsage { get; set; }
            [NameInMap("QuotaValue")]
            [Validation(Required=false)]
            public float? QuotaValue { get; set; }
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public string AlarmId { get; set; }
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }
        };

    }

}
