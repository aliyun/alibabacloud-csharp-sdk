// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListCallMeasureSummaryReportsResponseBody : TeaModel {
        [NameInMap("CallMeasureSummaryReportList")]
        [Validation(Required=false)]
        public ListCallMeasureSummaryReportsResponseBodyCallMeasureSummaryReportList CallMeasureSummaryReportList { get; set; }
        public class ListCallMeasureSummaryReportsResponseBodyCallMeasureSummaryReportList : TeaModel {
            [NameInMap("CallMeasureSummaryReport")]
            [Validation(Required=false)]
            public List<ListCallMeasureSummaryReportsResponseBodyCallMeasureSummaryReportListCallMeasureSummaryReport> CallMeasureSummaryReport { get; set; }
            public class ListCallMeasureSummaryReportsResponseBodyCallMeasureSummaryReportListCallMeasureSummaryReport : TeaModel {
                public string Day { get; set; }
                public long? InboundCount { get; set; }
                public long? InboundDurationByMinute { get; set; }
                public string Month { get; set; }
                public long? OutboundCount { get; set; }
                public long? OutboundDurationByMinute { get; set; }
                public string Year { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
