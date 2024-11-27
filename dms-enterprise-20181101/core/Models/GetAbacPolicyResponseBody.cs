// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetAbacPolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetAbacPolicyResponseBodyPolicy Policy { get; set; }
        public class GetAbacPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthorizedQuantity")]
            [Validation(Required=false)]
            public string AuthorizedQuantity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>51****</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PolicyDesc")]
            [Validation(Required=false)]
            public string PolicyDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>policy_test</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            [NameInMap("PolicySource")]
            [Validation(Required=false)]
            public string PolicySource { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2B7844DE-A0C3-50ED-A796-8F07D377144C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
