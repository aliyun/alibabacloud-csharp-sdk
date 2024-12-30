// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchSimilarImageClustersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0***</para>
        /// </summary>
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
