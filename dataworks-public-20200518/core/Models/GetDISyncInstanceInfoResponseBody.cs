// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDISyncInstanceInfoResponseBody : TeaModel {
        /// <summary>
        /// *   If the TaskType parameter is set to DI_REALTIME, the Status parameter indicates the status of the real-time synchronization node. Valid values: PAUSE, NORUN, RUN, KILLING, and WAIT.
        /// *   If the TaskType parameter is set to DI_SOLITION, the Status parameter indicates the status of the data synchronization solution. Valid values: success and fail.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDISyncInstanceInfoResponseBodyData Data { get; set; }
        public class GetDISyncInstanceInfoResponseBodyData : TeaModel {
            /// <summary>
            /// *   If the TaskType parameter is set to DI_REALTIME, the Name parameter indicates the name of the real-time synchronization node.
            /// *   If the TaskType parameter is set to DI_SOLITION, the value null is returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// *   If the TaskType parameter is set to DI_REALTIME, the value null is returned.
            /// *   If the TaskType parameter is set to DI_SOLITION, the SolutionInfo parameter indicates the details of the data synchronization solution.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The status of the data synchronization solution.
            /// </summary>
            [NameInMap("SolutionInfo")]
            [Validation(Required=false)]
            public GetDISyncInstanceInfoResponseBodyDataSolutionInfo SolutionInfo { get; set; }
            public class GetDISyncInstanceInfoResponseBodyDataSolutionInfo : TeaModel {
                /// <summary>
                /// The step details of the synchronization solution.
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// The creator of the data synchronization solution.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The ID of the data synchronization solution.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The status of the step in the data synchronization solution.
                /// </summary>
                [NameInMap("StepDetail")]
                [Validation(Required=false)]
                public List<GetDISyncInstanceInfoResponseBodyDataSolutionInfoStepDetail> StepDetail { get; set; }
                public class GetDISyncInstanceInfoResponseBodyDataSolutionInfoStepDetail : TeaModel {
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public string Info { get; set; }

                    /// <summary>
                    /// The ID of the step in the data synchronization solution.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The name of the step in the data synchronization solution.
                    /// </summary>
                    [NameInMap("StepId")]
                    [Validation(Required=false)]
                    public long? StepId { get; set; }

                    /// <summary>
                    /// The information of the data synchronization solution.
                    /// </summary>
                    [NameInMap("StepName")]
                    [Validation(Required=false)]
                    public string StepName { get; set; }

                }

            }

            /// <summary>
            /// The cause of the failure to obtain the status of the real-time synchronization node or data synchronization solution. If the status of the real-time synchronization node or data synchronization solution is obtained, the value null is returned.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The status of the real-time synchronization node or data synchronization solution.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
