// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListTasksResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the queried entries are truncated. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// The maximum number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.
        /// 
        /// >  This parameter is returned only when the value of `IsTruncated` is `true`.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The tasks.
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListTasksResponseBodyTasks> Tasks { get; set; }
        public class ListTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// The ID of the access configuration.
            /// </summary>
            [NameInMap("AccessConfigurationId")]
            [Validation(Required=false)]
            public string AccessConfigurationId { get; set; }

            /// <summary>
            /// The name of the access configuration.
            /// </summary>
            [NameInMap("AccessConfigurationName")]
            [Validation(Required=false)]
            public string AccessConfigurationName { get; set; }

            /// <summary>
            /// The end time of the task.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The cause of the task failure.
            /// 
            /// >  This parameter is returned only when the value of `Status` is `Failed`.
            /// </summary>
            [NameInMap("FailureReason")]
            [Validation(Required=false)]
            public string FailureReason { get; set; }

            /// <summary>
            /// The ID of the CloudSSO identity.
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// The name of the CloudSSO identity.
            /// </summary>
            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// The type of the CloudSSO identity. Valid values:
            /// 
            /// *   User
            /// *   Group
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

            /// <summary>
            /// The start time of the task.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The task status. Valid values:
            /// 
            /// *   InProgress: The task is running.
            /// *   Success: The task is successful.
            /// *   Failed: The task failed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the task object.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// The name of the task object.
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// The path ID of the task object in the resource directory.
            /// </summary>
            [NameInMap("TargetPath")]
            [Validation(Required=false)]
            public string TargetPath { get; set; }

            /// <summary>
            /// The path name of the task object in the resource directory.
            /// </summary>
            [NameInMap("TargetPathName")]
            [Validation(Required=false)]
            public string TargetPathName { get; set; }

            /// <summary>
            /// The type of the task object.
            /// 
            /// The value is fixed as RD-Account, which indicates the accounts in the resource directory.
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The ID of the job.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The task type. Valid values:
            /// 
            /// *   ProvisionAccessConfiguration: An access configuration is provisioned.
            /// *   DeprovisionAccessConfiguration: An access configuration is de-provisioned.
            /// *   CreateAccessAssignment: Access permissions on an account in the resource directory are assigned.
            /// *   DeleteAccessAssignment: Access permissions on an account in the resource directory are removed.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
