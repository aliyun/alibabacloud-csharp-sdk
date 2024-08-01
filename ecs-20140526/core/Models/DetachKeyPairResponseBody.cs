// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DetachKeyPairResponseBody : TeaModel {
        /// <summary>
        /// The number of instances from which the SSH key pair failed to be unbound.
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public string FailCount { get; set; }

        /// <summary>
        /// The name of the key pair.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result set of the unbind operation.
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public DetachKeyPairResponseBodyResults Results { get; set; }
        public class DetachKeyPairResponseBodyResults : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DetachKeyPairResponseBodyResultsResult> Result { get; set; }
            public class DetachKeyPairResponseBodyResultsResult : TeaModel {
                /// <summary>
                /// The operation status code that is returned. 200 indicates that the operation is successful.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The result of the operation. For example, if the value of `Code` is 200, the value of `Message` is `successful`.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// Indicates whether the operation is successful.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public string Success { get; set; }

            }

        }

        /// <summary>
        /// The total number of instances from which you want to unbind the SSH key pair.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
