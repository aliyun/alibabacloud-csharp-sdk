// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateLifecycleHookResponseBody : TeaModel {
        /// <summary>
        /// The ID of the lifecycle hook.
        /// </summary>
        [NameInMap("LifecycleHookId")]
        [Validation(Required=false)]
        public string LifecycleHookId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
