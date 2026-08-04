// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetRegistrationPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the device registration policy. Valid values are obtained from the following sources:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListRegistrationPolicies~~">ListRegistrationPolicies</a>: Queries device registration policies in batches.</description></item>
        /// <item><description><a href="~~GetRegistrationPolicy~~">GetRegistrationPolicy</a>: Queries the details of a device registration policy.</description></item>
        /// <item><description><a href="~~CreateRegistrationPolicy~~">CreateRegistrationPolicy</a>: Creates a device registration policy.</description></item>
        /// <item><description><a href="~~UpdateRegistrationPolicy~~">UpdateRegistrationPolicy</a>: Updates a device registration policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reg-policy-dcbfd33cb004****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
