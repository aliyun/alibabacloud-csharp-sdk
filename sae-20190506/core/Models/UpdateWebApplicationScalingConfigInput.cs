// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateWebApplicationScalingConfigInput : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaximumInstanceCount")]
        [Validation(Required=false)]
        public long? MaximumInstanceCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MinimumInstanceCount")]
        [Validation(Required=false)]
        public long? MinimumInstanceCount { get; set; }

    }

}
