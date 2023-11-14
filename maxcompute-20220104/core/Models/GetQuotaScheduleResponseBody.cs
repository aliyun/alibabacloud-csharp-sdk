// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaScheduleResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetQuotaScheduleResponseBodyData> Data { get; set; }
        public class GetQuotaScheduleResponseBodyData : TeaModel {
            /// <summary>
            /// The condition value.
            /// </summary>
            [NameInMap("condition")]
            [Validation(Required=false)]
            public GetQuotaScheduleResponseBodyDataCondition Condition { get; set; }
            public class GetQuotaScheduleResponseBodyDataCondition : TeaModel {
                /// <summary>
                /// The start time when the quota plan takes effect.
                /// </summary>
                [NameInMap("after")]
                [Validation(Required=false)]
                public string After { get; set; }

                /// <summary>
                /// The time when the quota plan takes effect.
                /// </summary>
                [NameInMap("at")]
                [Validation(Required=false)]
                public string At { get; set; }

            }

            /// <summary>
            /// The ID of the quota plan.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the operator.
            /// </summary>
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// The name of the quota plan.
            /// </summary>
            [NameInMap("plan")]
            [Validation(Required=false)]
            public string Plan { get; set; }

            /// <summary>
            /// The time zone.
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// The type of the quota plan.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// *   If the value of success was false, an error code was returned.
        /// *   If the value of success was true, a null value was returned.
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. If this parameter was not empty and the value of this parameter was not 200, the request failed.
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
