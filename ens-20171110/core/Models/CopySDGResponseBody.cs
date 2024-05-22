// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CopySDGResponseBody : TeaModel {
        /// <summary>
        /// The returned data object.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CopySDGResponseBodyData Data { get; set; }
        public class CopySDGResponseBodyData : TeaModel {
            /// <summary>
            /// The response message. Success is returned for a successful request.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The execution result of the synchronization request.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public CopySDGResponseBodyDataResult Result { get; set; }
            public class CopySDGResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The number of failed nodes.
                /// </summary>
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                /// <summary>
                /// Details of failed nodes.
                /// </summary>
                [NameInMap("FailedItems")]
                [Validation(Required=false)]
                public List<CopySDGResponseBodyDataResultFailedItems> FailedItems { get; set; }
                public class CopySDGResponseBodyDataResultFailedItems : TeaModel {
                    /// <summary>
                    /// The ID of the destination node.
                    /// </summary>
                    [NameInMap("DestinationRegionId")]
                    [Validation(Required=false)]
                    public string DestinationRegionId { get; set; }

                    /// <summary>
                    /// The error message.
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                /// <summary>
                /// The number of successful nodes.
                /// </summary>
                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public long? SuccessCount { get; set; }

            }

            /// <summary>
            /// Indicates whether all tasks are successful. Valid values:
            /// 
            /// *   **true**: All tasks are successful.
            /// *   **false**: Failed tasks exist.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
