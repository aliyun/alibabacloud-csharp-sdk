// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20190701.Models
{
    public class PredictMTModelByDocRequest : TeaModel {
        [NameInMap("FileContent")]
        [Validation(Required=true)]
        public string FileContent { get; set; }

        [NameInMap("FileType")]
        [Validation(Required=true)]
        public string FileType { get; set; }

        [NameInMap("ModelId")]
        [Validation(Required=true)]
        public int? ModelId { get; set; }

        [NameInMap("NeedXLIFF")]
        [Validation(Required=false)]
        public bool? NeedXLIFF { get; set; }

        [NameInMap("ModelVersion")]
        [Validation(Required=true)]
        public string ModelVersion { get; set; }

    }

}
