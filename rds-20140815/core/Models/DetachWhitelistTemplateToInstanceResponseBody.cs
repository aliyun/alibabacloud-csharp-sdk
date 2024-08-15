// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DetachWhitelistTemplateToInstanceResponseBody : TeaModel {
        /// <summary>
        /// The response code. Valid values:
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
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetachWhitelistTemplateToInstanceResponseBodyData Data { get; set; }
        public class DetachWhitelistTemplateToInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The status code returned. Valid values:
            /// 
            /// *   **ok**: The request is successful.
            /// *   **error**: The request fails.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned. Valid values:
        /// 
        /// *   **200**: success
        /// *   **400**: client error
        /// *   **500**: server error
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
