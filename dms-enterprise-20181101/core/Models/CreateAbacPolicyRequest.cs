// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateAbacPolicyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
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
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AbacPolicyDesc")]
        [Validation(Required=false)]
        public string AbacPolicyDesc { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy_test</para>
        /// </summary>
        [NameInMap("AbacPolicyName")]
        [Validation(Required=false)]
        public string AbacPolicyName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
