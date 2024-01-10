// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDocumentCollectionRequest : TeaModel {
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("EmbeddingModel")]
        [Validation(Required=false)]
        public string EmbeddingModel { get; set; }

        [NameInMap("ExternalStorage")]
        [Validation(Required=false)]
        public int? ExternalStorage { get; set; }

        [NameInMap("FullTextRetrievalFields")]
        [Validation(Required=false)]
        public string FullTextRetrievalFields { get; set; }

        [NameInMap("HnswM")]
        [Validation(Required=false)]
        public int? HnswM { get; set; }

        [NameInMap("ManagerAccount")]
        [Validation(Required=false)]
        public string ManagerAccount { get; set; }

        [NameInMap("ManagerAccountPassword")]
        [Validation(Required=false)]
        public string ManagerAccountPassword { get; set; }

        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string Metadata { get; set; }

        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Parser")]
        [Validation(Required=false)]
        public string Parser { get; set; }

        [NameInMap("PqEnable")]
        [Validation(Required=false)]
        public int? PqEnable { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
