// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListTasksRequest : TeaModel {
        /// <summary>
        /// The ID of the access configuration. The ID can be used to filter asynchronous tasks.
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The filter condition.
        /// 
        /// Specify the value in the \<Attribute> \<Operator> \<Value> format. The value is not case sensitive. You can set Attribute only to StartTime and Operator only to ge. You must set Value in the YYYY-MM-DDTHH:mm:SSZ format and enter a value that is no more than 7 days from the current time. The value ge indicates Greater Than or Equals.
        /// 
        /// For example, if you set Filter to StartTime ge 2021-03-15T01:12:23Z, the operation queries the tasks from 2021-03-15T01:12:23 GMT.
        /// 
        /// >  If you do not specify this parameter, the operation queries the tasks within the previous 24 hours by default.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: 1 to 20.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token to return for the next page. If this is your first time to call this operation, you do not need to specify `NextToken`.
        /// 
        /// When you call this operation for the first time, if the total number of entries to return exceeds the value of `MaxResults`, the entries are truncated. Only the entries that match the value of `MaxResults` are returned, and the excess entries are not returned. In this case, the value of the response parameter `IsTruncated` is `true`, and `NextToken` is returned. In the next call, you can use the value of `NextToken` and maintain the settings of the other request parameters to query the excess entries. You can repeat the call until the value of `IsTruncated` becomes `false`. This way, all entries are returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the CloudSSO identity. The ID can be used to filter asynchronous tasks.
        /// 
        /// *   If you set `PrincipalType` to `User`, set `PrincipalId` to the ID of the CloudSSO user.
        /// *   If you set `PrincipalType` to `Group`, set `PrincipalId` to the ID of the CloudSSO group.
        /// 
        /// >  You can use the ID to filter asynchronous tasks only if you specify both `PrincipalId` and `PrincipalType`.
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// The type of the CloudSSO identity. The type can be used to filter asynchronous tasks. Valid values:
        /// 
        /// *   User
        /// *   Group
        /// 
        /// >  You can use the type to filter asynchronous tasks only if you specify both `PrincipalId` and `PrincipalType`.
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// The ID of the task. The ID can be used to filter asynchronous tasks. Valid values:
        /// 
        /// *   InProgress: The task is running.
        /// *   Success: The task is successful.
        /// *   Failed: The task failed.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The ID of the task object. The ID can be used to filter asynchronous tasks.
        /// 
        /// >  You can use the ID to filter asynchronous tasks only if you specify both `TargetId` and `TargetType`.
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// The type of the task object. The type can be used to filter asynchronous tasks.
        /// 
        /// Set the value to RD-Account, which indicates an account in your resource directory.
        /// 
        /// >  You can use the type to filter asynchronous tasks only if you specify both `TargetId` and `TargetType`.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// The type of the task. The type can be used to filter asynchronous tasks. Valid values:
        /// 
        /// *   ProvisionAccessConfiguration: An access configuration is provisioned.
        /// *   DeprovisionAccessConfiguration: An access configuration is de-provisioned.
        /// *   CreateAccessAssignment: Access permissions on an account in your resource directory are assigned.
        /// *   DeleteAccessAssignment: Access permissions on an account in your resource directory are removed.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
