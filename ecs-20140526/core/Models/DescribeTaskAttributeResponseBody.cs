// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeTaskAttributeResponseBody : TeaModel {
        /// <summary>
        /// The time when the task was created.
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// The number of failed tasks.
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// The time when the task was complete.
        /// </summary>
        [NameInMap("FinishedTime")]
        [Validation(Required=false)]
        public string FinishedTime { get; set; }

        /// <summary>
        /// An array consisting of OperationProgress data of each subtask.
        /// </summary>
        [NameInMap("OperationProgressSet")]
        [Validation(Required=false)]
        public DescribeTaskAttributeResponseBodyOperationProgressSet OperationProgressSet { get; set; }
        public class DescribeTaskAttributeResponseBodyOperationProgressSet : TeaModel {
            [NameInMap("OperationProgress")]
            [Validation(Required=false)]
            public List<DescribeTaskAttributeResponseBodyOperationProgressSetOperationProgress> OperationProgress { get; set; }
            public class DescribeTaskAttributeResponseBodyOperationProgressSetOperationProgress : TeaModel {
                /// <summary>
                /// The error code.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// The status of the operation.
                /// </summary>
                [NameInMap("OperationStatus")]
                [Validation(Required=false)]
                public string OperationStatus { get; set; }

                /// <summary>
                /// An array consisting of RelatedItem data.
                /// </summary>
                [NameInMap("RelatedItemSet")]
                [Validation(Required=false)]
                public DescribeTaskAttributeResponseBodyOperationProgressSetOperationProgressRelatedItemSet RelatedItemSet { get; set; }
                public class DescribeTaskAttributeResponseBodyOperationProgressSetOperationProgressRelatedItemSet : TeaModel {
                    [NameInMap("RelatedItem")]
                    [Validation(Required=false)]
                    public List<DescribeTaskAttributeResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem> RelatedItem { get; set; }
                    public class DescribeTaskAttributeResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem : TeaModel {
                        /// <summary>
                        /// The name of the related item.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The value of the related item.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The region ID of the task.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of completed tasks.
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// Indicates whether the task can be canceled ([CancelTask](https://www.alibabacloud.com/help/en/elastic-compute-service/latest/canceltask)). Valid values: 
        /// 
        /// - true: The task can be canceled.
        /// - false: The task cannot be canceled.
        /// </summary>
        [NameInMap("SupportCancel")]
        [Validation(Required=false)]
        public string SupportCancel { get; set; }

        /// <summary>
        /// The operation name of the task.
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// The ID of the task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The progress of the task.
        /// </summary>
        [NameInMap("TaskProcess")]
        [Validation(Required=false)]
        public string TaskProcess { get; set; }

        /// <summary>
        /// The status of the task.
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// The total number of tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
