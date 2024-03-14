// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeCfwRiskLevelSummaryResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of risks.
        /// </summary>
        [NameInMap("RiskList")]
        [Validation(Required=false)]
        public List<DescribeCfwRiskLevelSummaryResponseBodyRiskList> RiskList { get; set; }
        public class DescribeCfwRiskLevelSummaryResponseBodyRiskList : TeaModel {
            /// <summary>
            /// The risk levels. Valid values:
            /// 
            /// *   **medium**
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The number of at-risk Elastic Compute Service (ECS) instances.
            /// </summary>
            [NameInMap("Num")]
            [Validation(Required=false)]
            public string Num { get; set; }

            /// <summary>
            /// The type.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
