// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateIntegrationPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The type of the paid plan. Valid values: CS_Pro, CS_Basic, and empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CS_Pro</para>
        /// </summary>
        [NameInMap("feePackage")]
        [Validation(Required=false)]
        public string FeePackage { get; set; }

        /// <summary>
        /// <para>The name of the rule. The name must be 3 to 63 characters in length and start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>metrics-inner-manage</para>
        /// </summary>
        [NameInMap("policyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzoiafjtr7zyq</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<UpdateIntegrationPolicyRequestTags> Tags { get; set; }
        public class UpdateIntegrationPolicyRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>algo_bhv_expose_in_airec_exposure</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
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
