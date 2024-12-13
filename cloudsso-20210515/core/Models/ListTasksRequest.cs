// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListTasksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access configuration. The ID can be used to filter access permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac-00jhtfl8thteu6uj****</para>
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The filter condition.</para>
        /// <para>The condition is not case-sensitive. The condition must be in the StartTime ge YYYY-MM-DDTHH:mm:SSZ format. You must set YYYY-MM-DDTHH:mm:SSZ to a value that is no more than 7 days from the current time. ge indicates Greater Than or Equals.</para>
        /// <para>For example, if you set the Filter parameter to StartTime ge 2021-03-15T01:12:23Z, the operation queries the tasks from 2021-03-15T01:12:23 GMT.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the operation queries the tasks within the previous 24 hours by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>StartTime ge 2021-03-15T01:12:23Z</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// <para>Valid values: 1 to 20.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If this is your first time to call this operation, you do not need to specify the <c>NextToken</c> parameter.</para>
        /// <para>When you call this operation for the first time, if the total number of entries to return exceeds the value of <c>MaxResults</c>, the entries are truncated. Only the entries that match the value of <c>MaxResults</c> are returned, and the excess entries are not returned. In this case, the value of the response parameter <c>IsTruncated</c> is <c>true</c>, and <c>NextToken</c> is returned. In the next call, you can use the value of <c>NextToken</c> and maintain the settings of the other request parameters to query the excess entries. You can repeat the call until the value of <c>IsTruncated</c> becomes <c>false</c>. This way, all entries are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the CloudSSO identity. The ID can be used to filter access permissions.</para>
        /// <list type="bullet">
        /// <item><description>If you set <c>PrincipalType</c> to <c>User</c>, set <c>PrincipalId</c> to the ID of the CloudSSO user.</description></item>
        /// <item><description>If you set <c>PrincipalType</c> to <c>Group</c>, set <c>PrincipalId</c> to the ID of the CloudSSO group.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can use the type to filter access permissions only if you specify both <c>PrincipalId</c> and <c>PrincipalType</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>u-00q8wbq42wiltcrk****</para>
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The type of the CloudSSO identity. The type can be used to filter access permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User</description></item>
        /// <item><description>Group</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can use the type to filter access permissions only if you specify both <c>PrincipalId</c> and <c>PrincipalType</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// <para>The ID of the task. The ID can be used to filter tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InProgress: The task is running.</description></item>
        /// <item><description>Success: The task is successful.</description></item>
        /// <item><description>Failed: The task failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the task object. The ID can be used to filter access permissions.</para>
        /// <remarks>
        /// <para> You can use the type to filter access permissions only if you specify both <c>TargetId</c> and <c>TargetType</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>114240524784****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the task object. The type can be used to filter access permissions.</para>
        /// <para>Set the value to RD-Account, which specifies the accounts in the resource directory.</para>
        /// <remarks>
        /// <para> You can use the type to filter access permissions only if you specify both <c>TargetId</c> and <c>TargetType</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RD-Account</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The type of the task. The type can be used to filter tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ProvisionAccessConfiguration: An access configuration is provisioned.</description></item>
        /// <item><description>DeprovisionAccessConfiguration: An access configuration is de-provisioned.</description></item>
        /// <item><description>CreateAccessAssignment: Access permissions on an account in the resource directory are assigned.</description></item>
        /// <item><description>DeleteAccessAssignment: Access permissions on an account in the resource directory are removed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateAccessAssignment</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
