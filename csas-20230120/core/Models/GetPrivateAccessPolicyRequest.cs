// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetPrivateAccessPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Intranet access policy ID. The value can be obtained from:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessPolices~~">ListPrivateAccessPolices</a>: Query multiple intranet access policies in bulk.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessPolicy~~">CreatePrivateAccessPolicy</a>: Create an intranet access policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-policy-63b2f1844b86****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
