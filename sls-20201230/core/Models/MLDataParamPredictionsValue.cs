// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MLDataParamPredictionsValue : TeaModel {
        [NameInMap("annotatedBy")]
        [Validation(Required=false)]
        public string AnnotatedBy { get; set; }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

        [NameInMap("results")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Results { get; set; }

    }

}
