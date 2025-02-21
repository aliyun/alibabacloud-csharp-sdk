// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateEventSourceResponseBody : TeaModel {
        /// <summary>
        /// The returned response code. Valid values:
        /// 
        /// *   Success: The request is successful.
        /// *   Other codes: The request failed. For more information about error codes, see Error codes.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateEventSourceResponseBodyData Data { get; set; }
        public class CreateEventSourceResponseBodyData : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the resource.
            /// </summary>
            [NameInMap("EventSourceARN")]
            [Validation(Required=false)]
            public string EventSourceARN { get; set; }

        }

        /// <summary>
        /// The returned error message.
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
        /// Indicates whether the operation is successful. The value true indicates that the operation is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
