// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class CreateProtectionPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of associated resource categories.</para>
        /// </summary>
        [NameInMap("BoundResourceCategoryIds")]
        [Validation(Required=false)]
        public List<string> BoundResourceCategoryIds { get; set; }

        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-<b><b>-</b></b>-****-a1b2c3d4f5e6</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the protection policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My***Policy</para>
        /// </summary>
        [NameInMap("ProtectionPolicyName")]
        [Validation(Required=false)]
        public string ProtectionPolicyName { get; set; }

        /// <summary>
        /// <para>The region ID of the protection policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ProtectionPolicyRegionId")]
        [Validation(Required=false)]
        public string ProtectionPolicyRegionId { get; set; }

        /// <summary>
        /// <para>The sub-protection policies.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubProtectionPolicies")]
        [Validation(Required=false)]
        public List<CreateProtectionPolicyRequestSubProtectionPolicies> SubProtectionPolicies { get; set; }
        public class CreateProtectionPolicyRequestSubProtectionPolicies : TeaModel {
            /// <summary>
            /// <para>The configuration of the sub-protection policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;PlaybookUuid\&quot;: \&quot;2093d1ea-0651-48a6-bea2-fa7157285dc1\&quot;, \&quot;ParamType\&quot;: \&quot;custom\&quot;, \&quot;InputParams\&quot;: \&quot;\&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The type of the sub-protection policy.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_AUTO_SNAPSHOT_POLICY</para>
            /// </summary>
            [NameInMap("SubProtectionPolicyType")]
            [Validation(Required=false)]
            public string SubProtectionPolicyType { get; set; }

        }

    }

}
