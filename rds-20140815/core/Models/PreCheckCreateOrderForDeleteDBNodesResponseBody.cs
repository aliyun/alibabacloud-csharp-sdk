// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class PreCheckCreateOrderForDeleteDBNodesResponseBody : TeaModel {
        /// <summary>
        /// The information about the failed order.
        /// </summary>
        [NameInMap("Failures")]
        [Validation(Required=false)]
        public PreCheckCreateOrderForDeleteDBNodesResponseBodyFailures Failures { get; set; }
        public class PreCheckCreateOrderForDeleteDBNodesResponseBodyFailures : TeaModel {
            [NameInMap("Failures")]
            [Validation(Required=false)]
            public List<PreCheckCreateOrderForDeleteDBNodesResponseBodyFailuresFailures> Failures { get; set; }
            public class PreCheckCreateOrderForDeleteDBNodesResponseBodyFailuresFailures : TeaModel {
                /// <summary>
                /// The response code. Valid values:
                /// 
                /// *   **200**: success
                /// *   **400**: client error
                /// *   **401**: identity authentication failed
                /// *   **404**: requested page not found
                /// *   **500**: server error
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The returned message.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        /// <summary>
        /// The precheck result.
        /// </summary>
        [NameInMap("PreCheckResult")]
        [Validation(Required=false)]
        public bool? PreCheckResult { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
