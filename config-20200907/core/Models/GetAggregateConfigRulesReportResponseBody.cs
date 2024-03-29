// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateConfigRulesReportResponseBody : TeaModel {
        /// <summary>
        /// The information about the compliance evaluation report.
        /// </summary>
        [NameInMap("ConfigRulesReport")]
        [Validation(Required=false)]
        public GetAggregateConfigRulesReportResponseBodyConfigRulesReport ConfigRulesReport { get; set; }
        public class GetAggregateConfigRulesReportResponseBodyConfigRulesReport : TeaModel {
            /// <summary>
            /// The ID of the management account to which the rules belong.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// The ID of the account group.
            /// </summary>
            [NameInMap("AggregatorId")]
            [Validation(Required=false)]
            public string AggregatorId { get; set; }

            /// <summary>
            /// The timestamp when the compliance evaluation report was generated. Unit: milliseconds.
            /// </summary>
            [NameInMap("ReportCreateTimestamp")]
            [Validation(Required=false)]
            public long? ReportCreateTimestamp { get; set; }

            /// <summary>
            /// The ID of the compliance evaluation report.
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// The status of the compliance evaluation report. Valid values:
            /// 
            /// *   NONE: The compliance evaluation report was not generated.
            /// *   CREATING: The compliance evaluation report was being generated.
            /// *   COMPLETE: The compliance evaluation report was generated.
            /// </summary>
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

            /// <summary>
            /// The URL that is used to download the compliance evaluation report.
            /// </summary>
            [NameInMap("ReportUrl")]
            [Validation(Required=false)]
            public string ReportUrl { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
