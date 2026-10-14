// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeHistoryTasksStatResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denial details.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeHistoryTasksStatResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeHistoryTasksStatResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The authentication action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the authorized principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the authenticated principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>141345906006****</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The type of the authorized principal.</para>
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
            /// <para>The type of the access policy denial. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ImplicitDeny</b>: The resource owner has not configured a relevant access policy for the current user, and unauthorized operations are denied by default.</description></item>
            /// <item><description><b>ExplicitDeny</b>: The RAM policy configured by the resource owner explicitly denies the current user access to the corresponding resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The type of the policy that caused the permission denial. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ControlPolicy</b>: Control policy.</description></item>
            /// <item><description><b>SessionPolicy</b>: An additional permission policy added to the temporary token.</description></item>
            /// <item><description><b>AssumeRolePolicy</b>: The trust policy of the RAM role.</description></item>
            /// <item><description><b>AccountLevelIdentityBasedPolicy</b>: The identity-access policy at the account level, including custom policies and system policies.</description></item>
            /// <item><description><b>ResourceGroupLevelIdentityBasedPolicy</b>: The identity-access policy at the resource group level, including custom policies and system policies.</description></item>
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
        /// <para>The API status code or POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksStatResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksStatResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Scheduled</b>: Pending execution.</para>
            /// </description></item>
            /// <item><description><para><b>Running</b>: Running.</para>
            /// </description></item>
            /// <item><description><para><b>Succeed</b>: Succeeded.</para>
            /// </description></item>
            /// <item><description><para><b>Failed</b>: Failed.</para>
            /// </description></item>
            /// <item><description><para><b>Cancelling</b>: Cancelling.</para>
            /// </description></item>
            /// <item><description><para><b>Canceled</b>: Canceled.</para>
            /// </description></item>
            /// <item><description><para><b>Waiting</b>: Waiting for the scheduled time.</para>
            /// </description></item>
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
        /// <para>The additional information about the call result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the request is normal, OK is returned.</description></item>
        /// <item><description>If the request is abnormal, a specific error code is returned.</description></item>
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
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
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
