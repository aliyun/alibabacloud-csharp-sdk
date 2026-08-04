// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DeletePrivateAccessPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the private network access policy. Obtain this ID from:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="~~ListPrivateAccessPolices~~">ListPrivateAccessPolices</a>: Batch query private network access policies.</para>
        /// </description></item>
        /// <item><description><para><a href="~~CreatePrivateAccessPolicy~~">CreatePrivateAccessPolicy</a>: Create a private network access policy.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-policy-867ef4007c8a****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
