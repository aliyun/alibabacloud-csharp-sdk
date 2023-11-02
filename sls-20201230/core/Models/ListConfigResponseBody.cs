// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListConfigResponseBody : TeaModel {
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<string> Configs { get; set; }

        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
