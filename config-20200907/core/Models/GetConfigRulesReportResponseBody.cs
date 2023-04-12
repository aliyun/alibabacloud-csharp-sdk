// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigRulesReportResponseBody : TeaModel {
        /// <summary>
        /// The information about the compliance evaluation report.
        /// </summary>
        [NameInMap("ConfigRulesReport")]
        [Validation(Required=false)]
        public GetConfigRulesReportResponseBodyConfigRulesReport ConfigRulesReport { get; set; }
        public class GetConfigRulesReportResponseBodyConfigRulesReport : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account to which the rules belong.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

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
            /// *   NONE: The compliance evaluation report is not generated.
            /// *   CREATING: The compliance evaluation report is being generated.
            /// *   COMPLETE: The compliance evaluation report is generated.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
