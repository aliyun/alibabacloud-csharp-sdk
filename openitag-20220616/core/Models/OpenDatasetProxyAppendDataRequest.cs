// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class OpenDatasetProxyAppendDataRequest : TeaModel {
        [NameInMap("DataMeta")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> DataMeta { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

        [NameInMap("UUID")]
        [Validation(Required=false)]
        public string UUID { get; set; }

    }

}
