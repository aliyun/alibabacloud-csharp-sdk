// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeChangeOrderResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request was invalid.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the change order.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeChangeOrderResponseBodyData Data { get; set; }
        public class DescribeChangeOrderResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The approval ID of the change order.
            /// </summary>
            [NameInMap("ApprovalId")]
            [Validation(Required=false)]
            public string ApprovalId { get; set; }

            /// <summary>
            /// Indicates whether SAE automatically determines the release batches. Valid values:
            /// 
            /// *   **true**: SAE automatically determines the release batches.
            /// *   **false**: SAE does not automatically determine the release batches.
            /// </summary>
            [NameInMap("Auto")]
            [Validation(Required=false)]
            public bool? Auto { get; set; }

            /// <summary>
            /// The number of release batches.
            /// </summary>
            [NameInMap("BatchCount")]
            [Validation(Required=false)]
            public int? BatchCount { get; set; }

            /// <summary>
            /// The mode in which the release batches are determined. Valid values:
            /// 
            /// *   **auto**: SAE automatically determines the release batches.
            /// *   **Manual**: You must manually determine the release batches.
            /// </summary>
            [NameInMap("BatchType")]
            [Validation(Required=false)]
            public string BatchType { get; set; }

            /// <summary>
            /// The interval between batches when SAE automatically determines the release batches in a phased release. Unit: minutes.
            /// </summary>
            [NameInMap("BatchWaitTime")]
            [Validation(Required=false)]
            public int? BatchWaitTime { get; set; }

            /// <summary>
            /// The ID of the change order.
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

            /// <summary>
            /// The description about the change type, which corresponds to the **CoTypeCode** parameter.
            /// </summary>
            [NameInMap("CoType")]
            [Validation(Required=false)]
            public string CoType { get; set; }

            /// <summary>
            /// The code of the change type. Valid values:
            /// 
            /// *   **CoBindSlb**: associates the Server Load Balancer (SLB) instance with the application.
            /// *   **CoUnbindSlb**: disassociates the SLB instance from the application.
            /// *   **CoCreateApp**: creates the application.
            /// *   **CoDeleteApp**: deletes the application.
            /// *   **CoDeploy**: deploys the application.
            /// *   **CoRestartApplication**: restarts the application.
            /// *   **CoRollback**: rolls back the application.
            /// *   **CoScaleIn**: scales in the application.
            /// *   **CoScaleOut**: scales out the application.
            /// *   **CoStart**: starts the application.
            /// *   **CoStop**: stops the application.
            /// *   **CoRescaleApplicationVertically**: modifies the instance specifications.
            /// *   **CoDeployHistroy**: rolls back the application to a historical version.
            /// *   **CoBindNas**: associates a network-attached storage (NAS) file system with the application.
            /// *   **CoUnbindNas**: disassociates the NAS file system from the application.
            /// *   **CoBatchStartApplication**: starts multiple applications concurrently.
            /// *   **CoBatchStopApplication**: stops multiple applications concurrently.
            /// *   **CoRestartInstances**: restarts the instances.
            /// *   **CoDeleteInstances**: deletes the instances.
            /// *   **CoScaleInAppWithInstances**: reduces the number of specified application instances.
            /// </summary>
            [NameInMap("CoTypeCode")]
            [Validation(Required=false)]
            public string CoTypeCode { get; set; }

            /// <summary>
            /// The time when the change order was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the current batch.
            /// </summary>
            [NameInMap("CurrentPipelineId")]
            [Validation(Required=false)]
            public string CurrentPipelineId { get; set; }

            /// <summary>
            /// The description of the change order.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The batch information.
            /// </summary>
            [NameInMap("Pipelines")]
            [Validation(Required=false)]
            public List<DescribeChangeOrderResponseBodyDataPipelines> Pipelines { get; set; }
            public class DescribeChangeOrderResponseBodyDataPipelines : TeaModel {
                /// <summary>
                /// The batch type.
                /// </summary>
                [NameInMap("BatchType")]
                [Validation(Required=false)]
                public int? BatchType { get; set; }

                /// <summary>
                /// The number of parallel tasks in a batch.
                /// </summary>
                [NameInMap("ParallelCount")]
                [Validation(Required=false)]
                public int? ParallelCount { get; set; }

                /// <summary>
                /// The ID of the batch.
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// The name of the batch.
                /// </summary>
                [NameInMap("PipelineName")]
                [Validation(Required=false)]
                public string PipelineName { get; set; }

                /// <summary>
                /// The time when the batch processing starts.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// The status of the batch. Valid values:
                /// 
                /// *   **0**: The batch is being prepared.
                /// *   **1**: The batch is being processed.
                /// *   **2**: The batch was processed.
                /// *   **3**: The batch could not be processed.
                /// *   **6**: The batch processing was terminated.
                /// *   **8**: The execution process is pending. You must manually determine the release batch.
                /// *   **9**: The execution process is pending. SAE will automatically determine the release batch.
                /// *   **10**: The batch could not be processed due to a system exception.
                /// *   **11**: The change order is pending approval.
                /// *   **12**: The change order is approved and is pending execution.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The time when the batch information is last modified.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// The status of the change order. Valid values:
            /// 
            /// *   **0**: The change order is being prepared.
            /// *   **1**: The change order is being executed.
            /// *   **2**: The change order was executed.
            /// *   **3**: The change order could not be executed.
            /// *   **6**: The change order was terminated.
            /// *   **8**: The execution process is pending. You must manually determine the release batch.
            /// *   **9**: The execution process is pending. SAE will automatically determine the release batches.
            /// *   **10**: The execution failed due to a system exception.
            /// *   **11**: The change order is pending approval.
            /// *   **12**: The change order is approved and is pending execution.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The substatus of the change order. This parameter indicates whether an exception occurred while the change order was being executed. Valid values:
            /// 
            /// *   **0**: No exception occurred.
            /// *   **1**: An exception occurred. For example, when an error occurred during a phased release, you must manually roll back the application. In this case, the change order cannot be completed, so the Status parameter is still displayed as "1", which indicates that the change order is being executed. You can check the value of this parameter to determine whether an exception occurs.
            /// </summary>
            [NameInMap("SubStatus")]
            [Validation(Required=false)]
            public int? SubStatus { get; set; }

            /// <summary>
            /// Indicates whether the application can be rolled back. Valid values:
            /// 
            /// *   **true**: The application can be rolled back.
            /// *   **false**: The application cannot be rolled back.
            /// </summary>
            [NameInMap("SupportRollback")]
            [Validation(Required=false)]
            public bool? SupportRollback { get; set; }

        }

        /// <summary>
        /// The error code.
        /// 
        /// *   The **ErrorCode** parameter is not returned when the request succeeds.
        /// *   The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the information of a change order was obtained. Valid values:
        /// 
        /// *   **true**: The information was obtained.
        /// *   **false**: The information could not be obtained.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the trace. It is used to query the details of a request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
