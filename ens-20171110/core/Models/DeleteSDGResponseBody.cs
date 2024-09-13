// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteSDGResponseBody : TeaModel {
        /// <summary>
        /// The returned data object.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteSDGResponseBodyData Data { get; set; }
        public class DeleteSDGResponseBodyData : TeaModel {
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
            public DeleteSDGResponseBodyDataResult Result { get; set; }
            public class DeleteSDGResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The number of failed tasks.
                /// </summary>
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                /// <summary>
                /// Details about the failed tasks.
                /// </summary>
                [NameInMap("FailedItems")]
                [Validation(Required=false)]
                public List<DeleteSDGResponseBodyDataResultFailedItems> FailedItems { get; set; }
                public class DeleteSDGResponseBodyDataResultFailedItems : TeaModel {
                    /// <summary>
                    /// The error message.
                    /// </summary>
                    [NameInMap("ErrMessage")]
                    [Validation(Required=false)]
                    public string ErrMessage { get; set; }

                    /// <summary>
                    /// Description
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public DeleteSDGResponseBodyDataResultFailedItemsItem Item { get; set; }
                    public class DeleteSDGResponseBodyDataResultFailedItemsItem : TeaModel {
                        /// <summary>
                        /// The ID of the shared data group (SDG).
                        /// </summary>
                        [NameInMap("SdgId")]
                        [Validation(Required=false)]
                        public string SdgId { get; set; }

                    }

                }

                /// <summary>
                /// The number of successful tasks.
                /// </summary>
                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public long? SuccessCount { get; set; }

            }

            /// <summary>
            /// Indicates whether all tasks are successful. Valid values:
            /// 
            /// *   true: All tasks are successful.
            /// *   false: Failed tasks exist.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
