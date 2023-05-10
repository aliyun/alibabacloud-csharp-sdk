// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStacksRequest : TeaModel {
        /// <summary>
        /// The reason why the stack is in its current state.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The state N of the stack. Valid values:
        /// 
        /// *   CREATE_IN_PROGRESS: The stack is being created.
        /// *   CREATE_FAILED: The stack fails to be created.
        /// *   CREATE_COMPLETE: The stack is created.
        /// *   UPDATE_IN_PROGRESS: The stack is being updated.
        /// *   UPDATE_FAILED: The stack fails to be updated.
        /// *   UPDATE_COMPLETE: The stack is updated.
        /// *   DELETE_IN_PROGRESS: The stack is being deleted.
        /// *   DELETE_FAILED: The stack fails to be deleted.
        /// *   CREATE_ROLLBACK_IN_PROGRESS: The resources are being rolled back after the stack fails to be created.
        /// *   CREATE_ROLLBACK_FAILED: The resources fail to be rolled back after the stack fails to be created.
        /// *   CREATE_ROLLBACK_COMPLETE: The resources are rolled back after the stack fails to be created.
        /// *   ROLLBACK_IN_PROGRESS: The resources of the stack are being rolled back.
        /// *   ROLLBACK_FAILED: The resources of the stack fail to be rolled back.
        /// *   ROLLBACK_COMPLETE: The resources of the stack are rolled back.
        /// *   CHECK_IN_PROGRESS: The stack is being validated.
        /// *   CHECK_FAILED: The stack fails to be validated.
        /// *   CHECK_COMPLETE: The stack is validated.
        /// *   REVIEW_IN_PROGRESS: The stack is being reviewed.
        /// *   IMPORT_CREATE_IN_PROGRESS: The stack is being created by using imported resources.
        /// *   IMPORT_CREATE_FAILED: The stack fails to be created by using imported resources.
        /// *   IMPORT_CREATE_COMPLETE: The stack is created by using imported resources.
        /// *   IMPORT_CREATE_ROLLBACK_IN_PROGRESS: The resources are being rolled back after the stack fails to be created by using imported resources.
        /// *   IMPORT_CREATE_ROLLBACK_FAILED: The resources fail to be rolled back after the stack fails to be created by using imported resources.
        /// *   IMPORT_CREATE_ROLLBACK_COMPLETE: The resources are rolled back after the stack fails to be created by using imported resources.
        /// *   IMPORT_UPDATE_IN_PROGRESS: The stack is being updated by using imported resources.
        /// *   IMPORT_UPDATE_FAILED: The stack fails to be updated by using imported resources.
        /// *   IMPORT_UPDATE_COMPLETE: The stack is updated by using imported resources.
        /// *   IMPORT_UPDATE_ROLLBACK_IN_PROGRESS: The resources are being rolled back after the stack fails to be updated by using imported resources.
        /// *   IMPORT_UPDATE_ROLLBACK_FAILED: The resources fail to be rolled back after the stack fails to be updated by using imported resources.
        /// *   IMPORT_UPDATE_ROLLBACK_COMPLETE: The resources are rolled back after the stack fails to be updated by using imported resources.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The name of stack N.
        /// </summary>
        [NameInMap("ParentStackId")]
        [Validation(Required=false)]
        public string ParentStackId { get; set; }

        /// <summary>
        /// The name of stack N.
        /// 
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (\_). The name must start with a digit or letter. You can use the wildcard character (∗) for fuzzy search.
        /// 
        /// Valid values of N: 1 to 5.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The list of stacks.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The key of tag N of the stack.
        /// 
        /// Valid values of N: 1 to 20.
        /// </summary>
        [NameInMap("ShowNestedStack")]
        [Validation(Required=false)]
        public bool? ShowNestedStack { get; set; }

        /// <summary>
        /// The value of tag N of the stack.
        /// 
        /// Valid values of N: 1 to 20.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// The state of the stack.
        /// </summary>
        [NameInMap("StackIds")]
        [Validation(Required=false)]
        public List<string> StackIds { get; set; }

        /// <summary>
        /// The ID of stack N.
        /// 
        /// You can specify one or more IDs to query one or more stacks at the same time.
        /// 
        /// Valid values of N: 1 to 10.
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public List<string> StackName { get; set; }

        /// <summary>
        /// The time when the last successful drift detection was performed on the stack.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// 
        /// For more information about resource groups, see the "Resource Group" section of the [What is Resource Management?](~~94475~~) topic.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// 
        /// Maximum value: 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListStacksRequestTag> Tag { get; set; }
        public class ListStacksRequestTag : TeaModel {
            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
