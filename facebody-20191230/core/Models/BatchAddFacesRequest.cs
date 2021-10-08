// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class BatchAddFacesRequest : TeaModel {
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        [NameInMap("SimilarityScoreThresholdInEntity")]
        [Validation(Required=false)]
        public float? SimilarityScoreThresholdInEntity { get; set; }

        [NameInMap("SimilarityScoreThresholdBetweenEntity")]
        [Validation(Required=false)]
        public float? SimilarityScoreThresholdBetweenEntity { get; set; }

        [NameInMap("Faces")]
        [Validation(Required=false)]
        public List<BatchAddFacesRequestFaces> Faces { get; set; }
        public class BatchAddFacesRequestFaces : TeaModel {
            [NameInMap("ExtraData")]
            [Validation(Required=false)]
            public string ExtraData { get; set; }

            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

        [NameInMap("QualityScoreThreshold")]
        [Validation(Required=false)]
        public float? QualityScoreThreshold { get; set; }

    }

}
