// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListAbacPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The details of the permission policies.</para>
        /// </summary>
        [NameInMap("PolicyList")]
        [Validation(Required=false)]
        public List<ListAbacPoliciesResponseBodyPolicyList> PolicyList { get; set; }
        public class ListAbacPoliciesResponseBodyPolicyList : TeaModel {
            /// <summary>
            /// <para>The content of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;Statement&quot;: [
            ///     {
            ///       &quot;Action&quot;: &quot;<em>&quot;,
            ///       &quot;Effect&quot;: &quot;Allow&quot;,
            ///       &quot;Resource&quot;: &quot;</em>&quot;,
            ///       &quot;Condition&quot;: {
            ///         &quot;StringEqualsIgnoreCase&quot;: {
            ///           &quot;dms:DbType&quot;: [
            ///             &quot;redis&quot;
            ///           ]
            ///         }
            ///       }
            ///     }
            ///   ],
            ///   &quot;Version&quot;: &quot;1&quot;
            /// }</para>
            /// </summary>
            [NameInMap("AbacPolicyContent")]
            [Validation(Required=false)]
            public string AbacPolicyContent { get; set; }

            /// <summary>
            /// <para>The description of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AbacPolicyDesc")]
            [Validation(Required=false)]
            public string AbacPolicyDesc { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12****</para>
            /// </summary>
            [NameInMap("AbacPolicyId")]
            [Validation(Required=false)]
            public long? AbacPolicyId { get; set; }

            /// <summary>
            /// <para>The name of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policy_test</para>
            /// </summary>
            [NameInMap("AbacPolicyName")]
            [Validation(Required=false)]
            public string AbacPolicyName { get; set; }

            /// <summary>
            /// <para>The source of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER_DEFINE</para>
            /// </summary>
            [NameInMap("AbacPolicySource")]
            [Validation(Required=false)]
            public string AbacPolicySource { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51****</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the request ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The total number of policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
