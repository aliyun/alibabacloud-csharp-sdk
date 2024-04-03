// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetReductionProposalResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetReductionProposalResponseBodyData Data { get; set; }
        public class GetReductionProposalResponseBodyData : TeaModel {
            /// <summary>
            /// Proactive carbon reduction recommendations and advice.
            /// </summary>
            [NameInMap("reduction")]
            [Validation(Required=false)]
            public string Reduction { get; set; }

            /// <summary>
            /// Active carbon reduction assessment.
            /// </summary>
            [NameInMap("reductionEvaluation")]
            [Validation(Required=false)]
            public string ReductionEvaluation { get; set; }

        }

        /// <summary>
        /// The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
