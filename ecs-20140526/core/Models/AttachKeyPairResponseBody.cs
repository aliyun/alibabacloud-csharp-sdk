// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AttachKeyPairResponseBody : TeaModel {
        /// <summary>
        /// The number of instances to which the SSH key pair fails to be bound.
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public string FailCount { get; set; }

        /// <summary>
        /// The name of the SSH key pair.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that contains the results of the operation.
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public AttachKeyPairResponseBodyResults Results { get; set; }
        public class AttachKeyPairResponseBodyResults : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<AttachKeyPairResponseBodyResultsResult> Result { get; set; }
            public class AttachKeyPairResponseBodyResultsResult : TeaModel {
                /// <summary>
                /// The operation status code returned. 200 indicates that the operation was successful.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The operation information returned. When the value of Code is 200, the value of Message is successful.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// Indicates whether the request was successful.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public string Success { get; set; }

            }

        }

        /// <summary>
        /// The total number of instances to which the SSH key pair is bound.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
