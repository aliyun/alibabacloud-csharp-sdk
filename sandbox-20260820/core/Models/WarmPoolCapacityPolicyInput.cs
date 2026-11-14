// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class WarmPoolCapacityPolicyInput : TeaModel {
        /// <summary>
        /// <para>The base target number of ready sandboxes, which is required and can be set to 0.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("minReadySandboxes")]
        [Validation(Required=false)]
        public long? MinReadySandboxes { get; set; }

        /// <summary>
        /// <para>The list of scheduled capacity rules, which is optional.</para>
        /// </summary>
        [NameInMap("scheduledPolicies")]
        [Validation(Required=false)]
        public List<WarmPoolScheduledPolicyInput> ScheduledPolicies { get; set; }

    }

}
