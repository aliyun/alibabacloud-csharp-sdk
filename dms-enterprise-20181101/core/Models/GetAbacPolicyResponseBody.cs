// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetAbacPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
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
        /// <para>The details of the policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetAbacPolicyResponseBodyPolicy Policy { get; set; }
        public class GetAbacPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>The number of users or custom roles to which the policy is attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthorizedQuantity")]
            [Validation(Required=false)]
            public string AuthorizedQuantity { get; set; }

            /// <summary>
            /// <para>The ID of the user who create the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51****</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

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
            [NameInMap("PolicyContent")]
            [Validation(Required=false)]
            public string PolicyContent { get; set; }

            /// <summary>
            /// <para>The description of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PolicyDesc")]
            [Validation(Required=false)]
            public string PolicyDesc { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <para>The name of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policy_test</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The source of the policy. Valid values:</para>
            /// </summary>
            [NameInMap("PolicySource")]
            [Validation(Required=false)]
            public string PolicySource { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2B7844DE-A0C3-50ED-A796-8F07D377144C</para>
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

    }

}
