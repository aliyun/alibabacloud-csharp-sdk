// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDISyncTaskResponseBody : TeaModel {
        /// <summary>
        /// *   If the TaskType parameter is set to DI_REALTIME, the details of the real-time synchronization node are returned.
        /// *   If the TaskType parameter is set to DI_SOLUTION, the value null is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDISyncTaskResponseBodyData Data { get; set; }
        public class GetDISyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the details of the real-time synchronization node or data synchronization solution are obtained. Valid values:
            /// 
            /// success: The details are obtained.
            /// 
            /// fail: The details fail to be obtained.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// *   If the TaskType parameter is set to DI_REALTIME, the value null is returned.
            /// *   If the TaskType parameter is set to DI_SOLUTION, the details of the data synchronization solution task are returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The status of the data synchronization solution. Valid values:
            /// 
            /// *   0: successful
            /// *   1: not running
            /// *   2: running
            /// *   3: failed
            /// *   4: committed
            /// *   5: pending manual confirmation
            /// *   6: manually confirmed
            /// *   7: others
            /// *   8: waiting
            /// *   9: deleted
            /// </summary>
            [NameInMap("SolutionDetail")]
            [Validation(Required=false)]
            public GetDISyncTaskResponseBodyDataSolutionDetail SolutionDetail { get; set; }
            public class GetDISyncTaskResponseBodyDataSolutionDetail : TeaModel {
                /// <summary>
                /// The ID of the project to which the data synchronization solution belongs.
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The additional parameters of the data synchronization solution.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The name of the data synchronization solution.
                /// </summary>
                [NameInMap("ProcessContent")]
                [Validation(Required=false)]
                public string ProcessContent { get; set; }

                /// <summary>
                /// The time when the data synchronization solution was committed.
                /// </summary>
                [NameInMap("ProcessExtra")]
                [Validation(Required=false)]
                public string ProcessExtra { get; set; }

                /// <summary>
                /// The type of the source of the data synchronization solution.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// The configuration details of the data synchronization solution.
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// The creator of the data synchronization solution.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The type of the data synchronization solution.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the data synchronization solution.
                /// </summary>
                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public string SubmitTime { get; set; }

                /// <summary>
                /// The start time of the data synchronization solution.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The cause of the failure to obtain the details of the real-time synchronization node or data synchronization solution.
            /// 
            /// If the details of the real-time synchronization node or data synchronization solution are obtained, the value null is returned.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The details of the real-time synchronization node or data synchronization solution.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request. You can query logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
