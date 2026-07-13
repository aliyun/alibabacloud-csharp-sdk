// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class UpdateProtectionPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of associated resource category IDs.</para>
        /// </summary>
        [NameInMap("BoundResourceCategoryIds")]
        [Validation(Required=false)]
        public string BoundResourceCategoryIdsShrink { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters. If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-<b><b>-</b></b>-****-a1b2c3d4f5e6</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The protection policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My***Policy</para>
        /// </summary>
        [NameInMap("ProtectionPolicyName")]
        [Validation(Required=false)]
        public string ProtectionPolicyName { get; set; }

        /// <summary>
        /// <para>The list of enabled sub-protection policies.</para>
        /// </summary>
        [NameInMap("SubProtectionPolicies")]
        [Validation(Required=false)]
        public string SubProtectionPoliciesShrink { get; set; }

    }

}
