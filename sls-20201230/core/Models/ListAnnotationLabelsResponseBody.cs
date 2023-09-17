// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListAnnotationLabelsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<MLLabelParam> Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
