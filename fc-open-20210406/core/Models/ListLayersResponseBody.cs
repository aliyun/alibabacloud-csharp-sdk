// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListLayersResponseBody : TeaModel {
        /// <summary>
        /// The information about layers.
        /// </summary>
        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<Layer> Layers { get; set; }

        /// <summary>
        /// The name of the start layer for the next query, which is also the token used to obtain more results.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
