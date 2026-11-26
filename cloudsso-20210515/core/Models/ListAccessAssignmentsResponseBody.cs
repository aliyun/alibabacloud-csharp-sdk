// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListAccessAssignmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of access assignments.</para>
        /// </summary>
        [NameInMap("AccessAssignments")]
        [Validation(Required=false)]
        public List<ListAccessAssignmentsResponseBodyAccessAssignments> AccessAssignments { get; set; }
        public class ListAccessAssignmentsResponseBodyAccessAssignments : TeaModel {
            /// <summary>
            /// <para>The ID of the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac-00jhtfl8thteu6uj****</para>
            /// </summary>
            [NameInMap("AccessConfigurationId")]
            [Validation(Required=false)]
            public string AccessConfigurationId { get; set; }

            /// <summary>
            /// <para>The name of the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS-Admin</para>
            /// </summary>
            [NameInMap("AccessConfigurationName")]
            [Validation(Required=false)]
            public string AccessConfigurationName { get; set; }

            /// <summary>
            /// <para>The time when the access assignment was successful. The time follows the RFC 3339 standard and is displayed in UTC in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-04T10:03:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

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
            /// <para>The ID of the CloudSSO identity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u-00q8wbq42wiltcrk****</para>
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>The name of the CloudSSO identity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// <para>The type of the CloudSSO identity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>User: user.</description></item>
            /// <item><description>Group: group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

            /// <summary>
            /// <para>The ID of the task target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>114240524784****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the task target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev-test</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The path ID of the task target in the resource directory.</para>
            /// </summary>
            [NameInMap("TargetPath")]
            [Validation(Required=false)]
            public string TargetPath { get; set; }

            /// <summary>
            /// <para>The path name of the task target in the resource directory.</para>
            /// </summary>
            [NameInMap("TargetPathName")]
            [Validation(Required=false)]
            public string TargetPathName { get; set; }

            /// <summary>
            /// <para>The type of the task target.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RD-Account: The task target is an account in a resource directory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RD-Account</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the returned result is truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The result is truncated.</description></item>
        /// <item><description>false: The result is not truncated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page of query results.</para>
        /// <remarks>
        /// <para>This parameter is returned only when <c>IsTruncated</c> is set to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66898413-EB80-556D-9429-06FE3548F672</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the filter conditions specified in the request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
