// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStacksResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Maximum value: 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details of the stacks.
        /// </summary>
        [NameInMap("Stacks")]
        [Validation(Required=false)]
        public List<ListStacksResponseBodyStacks> Stacks { get; set; }
        public class ListStacksResponseBodyStacks : TeaModel {
            /// <summary>
            /// The time when the stack was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// Indicates whether deletion protection is enabled for the stack. Valid values:
            /// 
            /// *   Enabled: Deletion protection is enabled for the stack.
            /// *   Disabled: Deletion protection is disabled for the stack. In this case, you can delete the stack by using the console or calling the [DeleteStack](https://help.aliyun.com/document_detail/610812.html) operation.
            /// 
            /// >  Deletion protection of a nested stack is the same as that of its root stack.
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public string DeletionProtection { get; set; }

            /// <summary>
            /// Indicates whether rollback is disabled when the stack fails to be created. Valid values:
            /// 
            /// *   true
            /// *   false (default)
            /// </summary>
            [NameInMap("DisableRollback")]
            [Validation(Required=false)]
            public bool? DisableRollback { get; set; }

            /// <summary>
            /// The time when the most recent successful drift detection was performed on the stack.
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// The supplementary information that is returned if an error occurs on a stack operation.
            /// 
            /// >  This parameter is returned only under specific conditions, and is returned together with at least one sub-parameter. For example, an error occurred when an API operation of another Alibaba Cloud service was called.
            /// </summary>
            [NameInMap("OperationInfo")]
            [Validation(Required=false)]
            public ListStacksResponseBodyStacksOperationInfo OperationInfo { get; set; }
            public class ListStacksResponseBodyStacksOperationInfo : TeaModel {
                /// <summary>
                /// The name of the API operation that belongs to another Alibaba Cloud service.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The error code.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The logical ID of the resource on which the operation error occurred.
                /// </summary>
                [NameInMap("LogicalResourceId")]
                [Validation(Required=false)]
                public string LogicalResourceId { get; set; }

                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The ID of the request that is initiated to call the API operation of another Alibaba Cloud service.
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// The type of the resource on which the operation error occurred.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// The ID of the parent stack.
            /// </summary>
            [NameInMap("ParentStackId")]
            [Validation(Required=false)]
            public string ParentStackId { get; set; }

            /// <summary>
            /// The region ID of the stack. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// Indicates whether the stack is a managed stack. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// The name of the service to which the managed stack belongs.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// The state of the stack on which the most recent successful drift detection was performed. Valid values:
            /// 
            /// *   DRIFTED: The stack has drifted.
            /// *   NOT_CHECKED: No successful drift detection is performed on the stack.
            /// *   IN_SYNC: The stack is being synchronized.
            /// </summary>
            [NameInMap("StackDriftStatus")]
            [Validation(Required=false)]
            public string StackDriftStatus { get; set; }

            /// <summary>
            /// The stack ID.
            /// </summary>
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// The stack name.
            /// </summary>
            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// The stack type. Valid values:
            /// 
            /// *   ROS: ROS stack. The stack is created by using a ROS template.
            /// *   Terraform: Terraform stack. The stack is created by using a Terraform template.
            /// </summary>
            [NameInMap("StackType")]
            [Validation(Required=false)]
            public string StackType { get; set; }

            /// <summary>
            /// The state of the stack.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The reason why the stack is in its current state.
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// The tags of the stack.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListStacksResponseBodyStacksTags> Tags { get; set; }
            public class ListStacksResponseBodyStacksTags : TeaModel {
                /// <summary>
                /// The tag key of the stack.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value of the stack.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The timeout period for creating the stack. Unit: minutes.
            /// </summary>
            [NameInMap("TimeoutInMinutes")]
            [Validation(Required=false)]
            public int? TimeoutInMinutes { get; set; }

            /// <summary>
            /// The time when the stack was updated. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The total number of stacks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
