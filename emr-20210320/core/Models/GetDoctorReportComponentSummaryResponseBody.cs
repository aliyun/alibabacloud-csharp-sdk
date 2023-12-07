// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorReportComponentSummaryResponseBody : TeaModel {
        /// <summary>
        /// The content of the report.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorReportComponentSummaryResponseBodyData Data { get; set; }
        public class GetDoctorReportComponentSummaryResponseBodyData : TeaModel {
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            /// <summary>
            /// The summary of the report.
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
