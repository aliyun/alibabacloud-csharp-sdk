// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateTopicRouteTableResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The list of topics returned if the call fails.
        /// </summary>
        [NameInMap("FailureTopics")]
        [Validation(Required=false)]
        public CreateTopicRouteTableResponseBodyFailureTopics FailureTopics { get; set; }
        public class CreateTopicRouteTableResponseBodyFailureTopics : TeaModel {
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Topic { get; set; }

        }

        /// <summary>
        /// Indicates whether all the message routing relationships between topics are established.
        /// 
        /// *   **true**: All the message routing relationships between topics are established.
        /// *   **false**: Not all the message routing relationships between topics are established.
        /// </summary>
        [NameInMap("IsAllSucceed")]
        [Validation(Required=false)]
        public bool? IsAllSucceed { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
