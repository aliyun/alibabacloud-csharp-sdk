// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeHistoryTasksStatResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried information about the request denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeHistoryTasksStatResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeHistoryTasksStatResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>Authorized action</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the requester.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the authentication principal belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>141345906006****</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The requester type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encoded diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The type of the policy denial. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ImplicitDeny</b>: The resource holder has not configured a policy for the current user. By default, unauthorized operations are denied.</description></item>
            /// <item><description><b>ExplicitDeny</b>: The RAM policy configured by the resource holder explicitly denies the current user access to the corresponding resources.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The type of the policy that causes the access denied error.</para>
            /// <list type="bullet">
            /// <item><description><b>ControlPolicy</b>: control policy</description></item>
            /// <item><description><b>SessionPolicy</b>: an additional policy that is added to the temporary token.</description></item>
            /// <item><description><b>AssumeRolePolicy</b>: the authorization policy of the RAM role.</description></item>
            /// <item><description><b>AccountLevelIdentityBasedPolicy</b>: the principal policies of the account authorization scope, including custom policies and system policies.</description></item>
            /// <item><description><b>ResourceGroupLevelIdentityBasedPolicy</b>: the principal policy of the resource group authorization scope, including custom policies and system policies.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ControlPolicy</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>API status or POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksStatResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksStatResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The status of the APS job.</para>
            /// <list type="bullet">
            /// <item><description><b>Scheduled</b></description></item>
            /// <item><description><b>Running</b></description></item>
            /// <item><description><b>Succeed</b></description></item>
            /// <item><description><b>Failed</b>: The task failed.</description></item>
            /// <item><description><b>Cancelling</b></description></item>
            /// <item><description><b>Canceled</b></description></item>
            /// <item><description><b>Waiting</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The returned message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, an success message is returned.</description></item>
        /// <item><description>If the request failed, an error message is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
