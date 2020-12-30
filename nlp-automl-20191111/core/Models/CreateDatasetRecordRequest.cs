// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20191111.Models
{
    public class CreateDatasetRecordRequest : TeaModel {
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        [NameInMap("DatasetRecord")]
        [Validation(Required=false)]
        public string DatasetRecord { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
