// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetCallMeasureSummaryReportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NumberReports")]
        [Validation(Required=false)]
        public GetCallMeasureSummaryReportResponseBodyNumberReports NumberReports { get; set; }
        public class GetCallMeasureSummaryReportResponseBodyNumberReports : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public GetCallMeasureSummaryReportResponseBodyNumberReportsList List { get; set; }
            public class GetCallMeasureSummaryReportResponseBodyNumberReportsList : TeaModel {
                [NameInMap("NumberReport")]
                [Validation(Required=false)]
                public List<GetCallMeasureSummaryReportResponseBodyNumberReportsListNumberReport> NumberReport { get; set; }
                public class GetCallMeasureSummaryReportResponseBodyNumberReportsListNumberReport : TeaModel {
                    [NameInMap("Day")]
                    [Validation(Required=false)]
                    public int? Day { get; set; }

                    [NameInMap("InboundCount")]
                    [Validation(Required=false)]
                    public long? InboundCount { get; set; }

                    [NameInMap("InboundDurationByMinute")]
                    [Validation(Required=false)]
                    public long? InboundDurationByMinute { get; set; }

                    [NameInMap("Month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                    [NameInMap("OutboundCount")]
                    [Validation(Required=false)]
                    public long? OutboundCount { get; set; }

                    [NameInMap("OutboundDurationByMinute")]
                    [Validation(Required=false)]
                    public long? OutboundDurationByMinute { get; set; }

                    [NameInMap("Year")]
                    [Validation(Required=false)]
                    public int? Year { get; set; }

                }

            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("SummaryReport")]
        [Validation(Required=false)]
        public GetCallMeasureSummaryReportResponseBodySummaryReport SummaryReport { get; set; }
        public class GetCallMeasureSummaryReportResponseBodySummaryReport : TeaModel {
            [NameInMap("Day")]
            [Validation(Required=false)]
            public int? Day { get; set; }
            [NameInMap("InboundCount")]
            [Validation(Required=false)]
            public long? InboundCount { get; set; }
            [NameInMap("InboundDurationByMinute")]
            [Validation(Required=false)]
            public long? InboundDurationByMinute { get; set; }
            [NameInMap("Month")]
            [Validation(Required=false)]
            public int? Month { get; set; }
            [NameInMap("OutboundCount")]
            [Validation(Required=false)]
            public long? OutboundCount { get; set; }
            [NameInMap("OutboundDurationByMinute")]
            [Validation(Required=false)]
            public long? OutboundDurationByMinute { get; set; }
            [NameInMap("Year")]
            [Validation(Required=false)]
            public int? Year { get; set; }
        };

    }

}
