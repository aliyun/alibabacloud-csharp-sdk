// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Chart : TeaModel {
        [NameInMap("action")]
        [Validation(Required=false)]
        public Dictionary<string, object> Action { get; set; }

        [NameInMap("display")]
        [Validation(Required=false)]
        public Dictionary<string, object> Display { get; set; }

        [NameInMap("search")]
        [Validation(Required=false)]
        public Dictionary<string, object> Search { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
