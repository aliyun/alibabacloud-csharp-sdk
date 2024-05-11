// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Runtime : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Hyperparameters")]
        [Validation(Required=false)]
        public Hyperparameters Hyperparameters { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public Resource Resource { get; set; }

    }

}
