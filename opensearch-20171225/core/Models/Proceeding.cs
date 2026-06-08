// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class Proceeding : TeaModel {
        [NameInMap("detail")]
        [Validation(Required=false)]
        public Dictionary<string, object> Detail { get; set; }

        [NameInMap("progress")]
        [Validation(Required=false)]
        public float? Progress { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("subTasks")]
        [Validation(Required=false)]
        public Proceeding SubTasks { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
