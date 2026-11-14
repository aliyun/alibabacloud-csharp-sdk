// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class UpdateWarmPoolInput : TeaModel {
        /// <summary>
        /// <para>The warm pool capacity policy, which includes the base target capacity and optional scheduled rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("capacityPolicy")]
        [Validation(Required=false)]
        public WarmPoolCapacityPolicyInput CapacityPolicy { get; set; }

    }

}
