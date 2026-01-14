// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChunkItem : TeaModel {
        [NameInMap("chunkContent")]
        [Validation(Required=false)]
        public string ChunkContent { get; set; }

        [NameInMap("chunkId")]
        [Validation(Required=false)]
        public string ChunkId { get; set; }

        [NameInMap("docElsIds")]
        [Validation(Required=false)]
        public List<string> DocElsIds { get; set; }

        [NameInMap("docId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        [NameInMap("docName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        [NameInMap("docUrl")]
        [Validation(Required=false)]
        public string DocUrl { get; set; }

        [NameInMap("rerankScore")]
        [Validation(Required=false)]
        public float? RerankScore { get; set; }

        [NameInMap("score")]
        [Validation(Required=false)]
        public float? Score { get; set; }

        [NameInMap("weightedScore")]
        [Validation(Required=false)]
        public float? WeightedScore { get; set; }

    }

}
