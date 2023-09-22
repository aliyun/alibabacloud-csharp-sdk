// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DescribeWeb3RiskScoreResponseBody : TeaModel {
        /// <summary>
        /// Return code. For the full list of codes, see Codes and Messages.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeWeb3RiskScoreResponseBodyData Data { get; set; }
        public class DescribeWeb3RiskScoreResponseBodyData : TeaModel {
            /// <summary>
            /// risk results
            /// </summary>
            [NameInMap("RiskResults")]
            [Validation(Required=false)]
            public List<DescribeWeb3RiskScoreResponseBodyDataRiskResults> RiskResults { get; set; }
            public class DescribeWeb3RiskScoreResponseBodyDataRiskResults : TeaModel {
                /// <summary>
                /// description
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// [ CRITICAL, HIGH, MEDIUM, LOW, NO ]
                /// 100: Critical
                /// 67-99: High risk
                /// 34-66: Medium risk
                /// 1-33: Low risk
                /// 0: No risk
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// Address
                /// Transaction
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// Risk score
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// Response detailed message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The unique ID of the request, which can be used to locate issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
