// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GetEffectivePolicyResponseBody : TeaModel {
        /// <summary>
        /// The effective tag policy.
        /// </summary>
        [NameInMap("EffectivePolicy")]
        [Validation(Required=false)]
        public string EffectivePolicy { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
