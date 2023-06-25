// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchSimilarImageClustersResponseBody : TeaModel {
        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        [NameInMap("similar_image_clusters")]
        [Validation(Required=false)]
        public List<SearchSimilarImageClustersResponseBodySimilarImageClusters> SimilarImageClusters { get; set; }
        public class SearchSimilarImageClustersResponseBodySimilarImageClusters : TeaModel {
            [NameInMap("files")]
            [Validation(Required=false)]
            public List<File> Files { get; set; }

        }

    }

}
