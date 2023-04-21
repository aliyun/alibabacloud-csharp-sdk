// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PutWebtrackingRequest : TeaModel {
        [NameInMap("__logs__")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Logs { get; set; }

        [NameInMap("__source__")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("__tags__")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

        [NameInMap("__topic__")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
