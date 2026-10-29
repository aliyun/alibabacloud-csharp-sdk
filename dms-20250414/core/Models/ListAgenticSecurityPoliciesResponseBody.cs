// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListAgenticSecurityPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of security policies returned by this query. Enabled system default policies are placed at the beginning, followed by the user policies on the current page. You can use Readonly to distinguish between the two types of policies.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAgenticSecurityPoliciesResponseBodyData> Data { get; set; }
        public class ListAgenticSecurityPoliciesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The UID of the Alibaba Cloud account to which the user policy belongs. This value is not returned for system default policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789012****</para>
            /// </summary>
            [NameInMap("AliyunAccountUid")]
            [Validation(Required=false)]
            public string AliyunAccountUid { get; set; }

            /// <summary>
            /// <para>The ID of the system default policy inherited by the user policy. This value is empty if no inheritance relationship is configured. This value is not returned for system default policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-sys-default</para>
            /// </summary>
            [NameInMap("BasePolicyId")]
            [Validation(Required=false)]
            public string BasePolicyId { get; set; }

            /// <summary>
            /// <para>The description of the security policy. The description of a system default policy is returned in the language of the request context.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Read-only access policy for analytics</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the security policy was created. The time is in the yyyy-MM-dd HH:mm:ss format and does not contain a time zone offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-13 14:30:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the security policy was last modified. The time is in the yyyy-MM-dd HH:mm:ss format and does not contain a time zone offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-13 14:35:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The business ID of the security policy. A system default policy ID starts with sp-sys-, and a user policy ID starts with sp-usr-.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-sys-default</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The Policy Name of the security policy. The Policy Name of a system default policy is returned in the language of the request context.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team-readonly-policy</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The current state of the security policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ON: Enabled.</description></item>
            /// <item><description>OFF: Disabled.</description></item>
            /// <item><description>ARCHIVED: Archived.
            /// All system default policies returned by this operation are in the ON state.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy is read-only. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The policy is a system default policy.</description></item>
            /// <item><description>false: The policy is a user policy of the current account.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Readonly")]
            [Validation(Required=false)]
            public bool? Readonly { get; set; }

            /// <summary>
            /// <para>The tags of the system default policy. Multiple tags are separated by commas (,). This value is not returned for user policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default,phase1</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The identifier of the operator that last modified the policy. For a user policy, the operator ID is recorded first. If no operator ID is available, the UID of the current Alibaba Cloud account is recorded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when the request fails. This parameter is empty when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INVALID_PARAMETER</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the request fails. This parameter is empty when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>invalid policyStatus: ARCHIVED</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and trace this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of policies that meet the query conditions. The value is the sum of the number of all enabled system default policies and the number of user policies of the current account that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
