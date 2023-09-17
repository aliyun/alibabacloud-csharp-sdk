// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateAnnotationDataSetRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public MLDataSetParam Body { get; set; }

        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

    }

}
