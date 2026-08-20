// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetProhibitedPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The software prohibition policy ID. You can obtain this value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListProhibitedPolicies~~">ListProhibitedPolicies</a>: Lists software prohibition policies.</description></item>
        /// <item><description><a href="~~CreateProhibitedPolicy~~">CreateProhibitedPolicy</a>: Creates a software prohibition policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pid-7da5ea4192c1****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
