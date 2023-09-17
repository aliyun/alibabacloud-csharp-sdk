// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class QueryMLServiceResultsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Data { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public Dictionary<string, string> Status { get; set; }

    }

}
