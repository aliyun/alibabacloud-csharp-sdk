// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20191111.Models
{
    public class GetPredictResultRequest : TeaModel {
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public int? ModelId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        [NameInMap("DetailTag")]
        [Validation(Required=false)]
        public string DetailTag { get; set; }

        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

    }

}
