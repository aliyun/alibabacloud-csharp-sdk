// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetProhibitedPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the prohibited software policy. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListProhibitedPolicies~~">ListProhibitedPolicies</a>: Lists prohibited software policies.</description></item>
        /// <item><description><a href="~~CreateProhibitedPolicy~~">CreateProhibitedPolicy</a>: Creates a prohibited software policy.</description></item>
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
