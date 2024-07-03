// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutConcurrencyConfigRequest : TeaModel {
        /// <summary>
        /// The concurrency configurations.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public PutConcurrencyInput Body { get; set; }

    }

}
