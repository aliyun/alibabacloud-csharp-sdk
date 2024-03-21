// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchPutDcdnKvShrinkRequest : TeaModel {
        /// <summary>
        /// The key-value pairs. The key-value pairs can be up to 2 MB in size.
        /// </summary>
        [NameInMap("KvList")]
        [Validation(Required=false)]
        public string KvListShrink { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
