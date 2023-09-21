// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRisksResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The baselines.
        /// </summary>
        [NameInMap("Risks")]
        [Validation(Required=false)]
        public List<DescribeRisksResponseBodyRisks> Risks { get; set; }
        public class DescribeRisksResponseBodyRisks : TeaModel {
            /// <summary>
            /// The description of the baseline.
            /// </summary>
            [NameInMap("RiskDetail")]
            [Validation(Required=false)]
            public string RiskDetail { get; set; }

            /// <summary>
            /// The baseline ID.
            /// </summary>
            [NameInMap("RiskId")]
            [Validation(Required=false)]
            public long? RiskId { get; set; }

            /// <summary>
            /// The name of the baseline.
            /// </summary>
            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            /// <summary>
            /// The name of the baseline type.
            /// </summary>
            [NameInMap("RiskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

            /// <summary>
            /// The name of the baseline subtype.
            /// </summary>
            [NameInMap("SubRiskType")]
            [Validation(Required=false)]
            public string SubRiskType { get; set; }

            /// <summary>
            /// The display name of the baseline subtype.
            /// </summary>
            [NameInMap("SubTypeAlias")]
            [Validation(Required=false)]
            public string SubTypeAlias { get; set; }

            /// <summary>
            /// The display name of the baseline type.
            /// </summary>
            [NameInMap("TypeAlias")]
            [Validation(Required=false)]
            public string TypeAlias { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
