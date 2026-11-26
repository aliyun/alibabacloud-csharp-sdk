// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListAccessAssignmentsRequest : TeaModel {
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
        /// <para>The token for the next page of query results. You do not need to specify <c>NextToken</c> when you call this operation for the first time.</para>
        /// <para>When you call this operation for the first time, if the total number of returned entries exceeds the value of <c>MaxResults</c>, the returned entries are truncated. Only the number of entries specified by <c>MaxResults</c> is returned, the <c>IsTruncated</c> parameter is set to <c>true</c>, and a <c>NextToken</c> value is returned. You can use the returned <c>NextToken</c> value to call this operation again to query the truncated entries while keeping other request parameters unchanged. You can repeat this process until <c>IsTruncated</c> is set to <c>false</c>, which indicates that all entries are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the authorization target belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114240524784****</para>
        /// </summary>
        [NameInMap("OriginTargetId")]
        [Validation(Required=false)]
        public string OriginTargetId { get; set; }

        /// <summary>
        /// <para>The ID of the CloudSSO identity, which is used as a filter condition for the query. Details:</para>
        /// <list type="bullet">
        /// <item><description>If <c>PrincipalType</c> is set to User, <c>PrincipalId</c> is the ID of the CloudSSO user.</description></item>
        /// <item><description>If <c>PrincipalType</c> is set to Group, <c>PrincipalId</c> is the ID of the CloudSSO group.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify both <c>PrincipalId</c> and <c>PrincipalType</c> for the filter condition to take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>u-00q8wbq42wiltcrk****</para>
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The type of the CloudSSO identity, which is used as a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: user.</description></item>
        /// <item><description>Group: group.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify both <c>PrincipalId</c> and <c>PrincipalType</c> for the filter condition to take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// <para>The ID of the task target, which is used as a filter condition for the query.</para>
        /// <remarks>
        /// <para>You must specify both <c>TargetId</c> and <c>TargetType</c> for the filter condition to take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>114240524784****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the task target, which is used as a filter condition for the query.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RD-Account: The task target is an account in a resource directory.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify both <c>TargetId</c> and <c>TargetType</c> for the filter condition to take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RD-Account</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
