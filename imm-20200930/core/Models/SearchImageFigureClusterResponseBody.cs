// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SearchImageFigureClusterResponseBody : TeaModel {
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<SearchImageFigureClusterResponseBodyClusters> Clusters { get; set; }
        public class SearchImageFigureClusterResponseBodyClusters : TeaModel {
            [NameInMap("Boundary")]
            [Validation(Required=false)]
            public Boundary Boundary { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("Similarity")]
            [Validation(Required=false)]
            public float? Similarity { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
