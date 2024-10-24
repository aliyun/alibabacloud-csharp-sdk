// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class CompanyTwoElementsVerificationResponseBody : TeaModel {
        /// <summary>
        /// The details about the access denial.
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CompanyTwoElementsVerificationResponseBodyData Data { get; set; }
        public class CompanyTwoElementsVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the enterprise.
            /// </summary>
            [NameInMap("DetailInfo")]
            [Validation(Required=false)]
            public CompanyTwoElementsVerificationResponseBodyDataDetailInfo DetailInfo { get; set; }
            public class CompanyTwoElementsVerificationResponseBodyDataDetailInfo : TeaModel {
                /// <summary>
                /// The business status of the enterprise.
                /// </summary>
                [NameInMap("EnterpriseStatus")]
                [Validation(Required=false)]
                public string EnterpriseStatus { get; set; }

                /// <summary>
                /// The business term of the enterprise.
                /// </summary>
                [NameInMap("OpenTime")]
                [Validation(Required=false)]
                public string OpenTime { get; set; }

            }

            /// <summary>
            /// The fields to be verified.
            /// </summary>
            [NameInMap("InconsistentData")]
            [Validation(Required=false)]
            public List<string> InconsistentData { get; set; }

            /// <summary>
            /// The code of the verification result. Valid values:
            /// 
            /// *   0: The two elements belong to the same enterprise.
            /// *   1: The two elements belong to the same enterprise, but the business status of the enterprise is abnormal.
            /// *   3: The two elements do not belong to the same enterprise.
            /// *   4: No information about the enterprise is found.
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// The verification result. Valid values:
            /// 
            /// *   true: The two elements belong to the same enterprise and the business status of the enterprise is Active.
            /// *   false: The two elements do not belong to the same enterprise.
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The unique request ID. It is a common parameter and can be used to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
