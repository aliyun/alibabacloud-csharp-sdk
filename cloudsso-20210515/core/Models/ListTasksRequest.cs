// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListTasksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access configuration. This parameter is used as a filter condition for the query.</para>
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
        /// <para>Format: <Attribute> <Operator> <Value>. The format is not case-sensitive. <Attribute> only supports StartTime. <Operator> only supports ge (greater than or equal to). <Value> must be in the YYYY-MM-DDTHH:mm:ssZ format and can only be a time within the last 7 days.</para>
        /// <para>Example: Filter = &quot;StartTime ge 2021-03-15T01:12:23Z&quot;. This example queries the list of tasks starting from 2021-03-15T01:12:23Z.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the list of tasks created within the last 24 hours is returned by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>StartTime ge 2021-03-15T01:12:23Z</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
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
        /// <para>The token used to return the next page of the query results. You do not need to specify NextToken when you call this operation for the first time.</para>
        /// <para>When you call this operation for the first time, if the total number of returned entries exceeds the value of MaxResults, the returned data is truncated. Only the number of entries specified by MaxResults is returned, the IsTruncated response parameter is set to true, and a NextToken value is returned. You can use the returned NextToken value to call this operation again while keeping other request parameters unchanged to query the truncated data. You can repeat this process until IsTruncated is set to false, which indicates that all data is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the CloudSSO identity. This parameter is used as a filter condition for the query. Details:</para>
        /// <list type="bullet">
        /// <item><description>If PrincipalType is set to User, PrincipalId is the ID of the CloudSSO user.</description></item>
        /// <item><description>If PrincipalType is set to Group, PrincipalId is the ID of the CloudSSO group.</description></item>
        /// </list>
        /// <remarks>
        /// <para>PrincipalId and PrincipalType must be specified at the same time to serve as a valid filter condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>u-00q8wbq42wiltcrk****</para>
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The type of the CloudSSO identity. This parameter is used as a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: The CloudSSO user.</description></item>
        /// <item><description>Group: The CloudSSO group.</description></item>
        /// </list>
        /// <remarks>
        /// <para>PrincipalId and PrincipalType must be specified at the same time to serve as a valid filter condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// <para>The status of the task. This parameter is used as a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InProgress: The task is running.</description></item>
        /// <item><description>Success: The task succeeded.</description></item>
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
        /// <para>The ID of the task target. This parameter is used as a filter condition for the query.</para>
        /// <remarks>
        /// <para>TargetId and TargetType must be specified at the same time to serve as a valid filter condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>114240524784****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the task target. This parameter is used as a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RD-Account: The task target is an account in a resource directory.</description></item>
        /// </list>
        /// <remarks>
        /// <para>TargetId and TargetType must be specified at the same time to serve as a valid filter condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RD-Account</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The type of the node. This parameter is used as a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ProvisionAccessConfiguration: Access configuration deployment.</description></item>
        /// <item><description>DeprovisionAccessConfiguration: Removes access configuration provisioning.</description></item>
        /// <item><description>CreateAccessAssignment: Grants authorization to an account in a resource directory.</description></item>
        /// <item><description>DeleteAccessAssignment: Removes authorization from an account in a resource directory.</description></item>
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
