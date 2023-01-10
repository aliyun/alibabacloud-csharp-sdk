// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListLayerVersionsResponseBody : TeaModel {
        /// <summary>
        /// The information about layer versions.
        /// </summary>
        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<Layer> Layers { get; set; }

        /// <summary>
        /// The initial version of the layer for the next query.
        /// </summary>
        [NameInMap("nextVersion")]
        [Validation(Required=false)]
        public int? NextVersion { get; set; }

    }

}
