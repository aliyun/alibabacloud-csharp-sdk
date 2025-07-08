// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryWarningThresholdNewResponseBody : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("ContactPhone")]
        [Validation(Required=false)]
        public string ContactPhone { get; set; }

        [NameInMap("DailyHaltLimit")]
        [Validation(Required=false)]
        public int? DailyHaltLimit { get; set; }

        [NameInMap("DailyWarningLimit")]
        [Validation(Required=false)]
        public int? DailyWarningLimit { get; set; }

        [NameInMap("DomesticDailySuccess")]
        [Validation(Required=false)]
        public long? DomesticDailySuccess { get; set; }

        [NameInMap("DomesticDailyTotal")]
        [Validation(Required=false)]
        public long? DomesticDailyTotal { get; set; }

        [NameInMap("DomesticMonthlySuccess")]
        [Validation(Required=false)]
        public long? DomesticMonthlySuccess { get; set; }

        [NameInMap("DomesticMonthlyTotal")]
        [Validation(Required=false)]
        public long? DomesticMonthlyTotal { get; set; }

        [NameInMap("MonthlyHaltLimit")]
        [Validation(Required=false)]
        public int? MonthlyHaltLimit { get; set; }

        [NameInMap("MonthlyWarningLimit")]
        [Validation(Required=false)]
        public int? MonthlyWarningLimit { get; set; }

        [NameInMap("OutDailySuccess")]
        [Validation(Required=false)]
        public long? OutDailySuccess { get; set; }

        [NameInMap("OutDailyTotal")]
        [Validation(Required=false)]
        public long? OutDailyTotal { get; set; }

        [NameInMap("OutMonthlySuccess")]
        [Validation(Required=false)]
        public long? OutMonthlySuccess { get; set; }

        [NameInMap("OutMonthlyTotal")]
        [Validation(Required=false)]
        public long? OutMonthlyTotal { get; set; }

        [NameInMap("PrevWaringNotice")]
        [Validation(Required=false)]
        public bool? PrevWaringNotice { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
