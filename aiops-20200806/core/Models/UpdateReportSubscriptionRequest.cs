// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class UpdateReportSubscriptionRequest : TeaModel {
        [NameInMap("DayOfWeek")]
        [Validation(Required=false)]
        public int? DayOfWeek { get; set; }

        [NameInMap("HourOfDay")]
        [Validation(Required=false)]
        public int? HourOfDay { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("ReportName")]
        [Validation(Required=false)]
        public string ReportName { get; set; }

        [NameInMap("Subscribe")]
        [Validation(Required=false)]
        public int? Subscribe { get; set; }

    }

}
