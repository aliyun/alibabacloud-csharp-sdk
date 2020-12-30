// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20191111.Models
{
    public class CreateModelShrinkRequest : TeaModel {
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("DatasetIdList")]
        [Validation(Required=false)]
        public string DatasetIdListShrink { get; set; }

        [NameInMap("TestDatasetIdList")]
        [Validation(Required=false)]
        public string TestDatasetIdListShrink { get; set; }

        [NameInMap("IsIncrementalTrain")]
        [Validation(Required=false)]
        public string IsIncrementalTrain { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

    }

}
