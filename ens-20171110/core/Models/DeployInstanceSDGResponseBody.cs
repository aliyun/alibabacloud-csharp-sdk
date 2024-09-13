// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeployInstanceSDGResponseBody : TeaModel {
        /// <summary>
        /// The returned data object.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeployInstanceSDGResponseBodyData Data { get; set; }
        public class DeployInstanceSDGResponseBodyData : TeaModel {
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
            public DeployInstanceSDGResponseBodyDataResult Result { get; set; }
            public class DeployInstanceSDGResponseBodyDataResult : TeaModel {
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
                public List<DeployInstanceSDGResponseBodyDataResultFailedItems> FailedItems { get; set; }
                public class DeployInstanceSDGResponseBodyDataResultFailedItems : TeaModel {
                    /// <summary>
                    /// The error message that is returned.
                    /// </summary>
                    [NameInMap("ErrMessage")]
                    [Validation(Required=false)]
                    public string ErrMessage { get; set; }

                    /// <summary>
                    /// The ID of the instance.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

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
