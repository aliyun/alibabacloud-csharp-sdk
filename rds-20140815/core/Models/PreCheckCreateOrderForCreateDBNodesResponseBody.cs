// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class PreCheckCreateOrderForCreateDBNodesResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Failures")]
        [Validation(Required=false)]
        public PreCheckCreateOrderForCreateDBNodesResponseBodyFailures Failures { get; set; }
        public class PreCheckCreateOrderForCreateDBNodesResponseBodyFailures : TeaModel {
            [NameInMap("Failures")]
            [Validation(Required=false)]
            public List<PreCheckCreateOrderForCreateDBNodesResponseBodyFailuresFailures> Failures { get; set; }
            public class PreCheckCreateOrderForCreateDBNodesResponseBodyFailuresFailures : TeaModel {
                /// <summary>
                /// The response code returned. Valid values:
                /// 
                /// *   **200**: success
                /// *   **400**: client error
                /// *   **401**: identity authentication failed
                /// *   **404**: request page not found
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
        /// Indicates the result of the precheck task.
        /// </summary>
        [NameInMap("PreCheckResult")]
        [Validation(Required=false)]
        public bool? PreCheckResult { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
