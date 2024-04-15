// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListLayerVersionsRequest : TeaModel {
        /// <summary>
        /// The number of versions to be returned.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The initial version of the layer.
        /// </summary>
        [NameInMap("startVersion")]
        [Validation(Required=false)]
        public string StartVersion { get; set; }

    }

}
