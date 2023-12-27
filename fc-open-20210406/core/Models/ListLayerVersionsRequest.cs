// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListLayerVersionsRequest : TeaModel {
        /// <summary>
        /// The maximum number of resources to return. Default value: 20. The value cannot exceed 100. The number of returned configurations is less than or equal to the specified number.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The initial version of the layer.
        /// </summary>
        [NameInMap("startVersion")]
        [Validation(Required=false)]
        public int? StartVersion { get; set; }

    }

}
