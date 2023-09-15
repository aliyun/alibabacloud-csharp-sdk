// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MLDataParamAnnotationsValue : TeaModel {
        [NameInMap("annotatedBy")]
        [Validation(Required=false)]
        public string AnnotatedBy { get; set; }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

        [NameInMap("results")]
        [Validation(Required=false)]
        public List<string> Results { get; set; }

    }

}
