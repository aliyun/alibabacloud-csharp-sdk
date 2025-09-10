// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateIntegrationPolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CS_Pro</para>
        /// </summary>
        [NameInMap("feePackage")]
        [Validation(Required=false)]
        public string FeePackage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>metrics-inner-manage</para>
        /// </summary>
        [NameInMap("policyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aekzoiafjtr7zyq</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<UpdateIntegrationPolicyRequestTags> Tags { get; set; }
        public class UpdateIntegrationPolicyRequestTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>algo_bhv_expose_in_airec_exposure</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{\&quot;Id\&quot;: \&quot;kgqie6hm\&quot;, \&quot;Name\&quot;: \&quot;Sheet1\&quot;}]</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
