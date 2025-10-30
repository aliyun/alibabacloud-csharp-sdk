// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateIntegrationPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Fee package type, CS_Pro/CS_Basic/empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CS_Pro</para>
        /// </summary>
        [NameInMap("feePackage")]
        [Validation(Required=false)]
        public string FeePackage { get; set; }

        /// <summary>
        /// <para>Rule name, minimum 3 characters, maximum 63 characters, must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>metrics-inner-manage</para>
        /// </summary>
        [NameInMap("policyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>Resource group ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzoiafjtr7zyq</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Resource tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<UpdateIntegrationPolicyRequestTags> Tags { get; set; }
        public class UpdateIntegrationPolicyRequestTags : TeaModel {
            /// <summary>
            /// <para>Tag <c>key</c> value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>algo_bhv_expose_in_airec_exposure</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Tag <c>value</c> value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;Id\&quot;: \&quot;kgqie6hm\&quot;, \&quot;Name\&quot;: \&quot;Sheet1\&quot;}]</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
