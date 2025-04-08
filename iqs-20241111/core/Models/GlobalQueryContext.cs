// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GlobalQueryContext : TeaModel {
        [NameInMap("originalQuery")]
        [Validation(Required=false)]
        public GlobalQueryContextOriginalQuery OriginalQuery { get; set; }
        public class GlobalQueryContextOriginalQuery : TeaModel {
            [NameInMap("page")]
            [Validation(Required=false)]
            public string Page { get; set; }

            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            [NameInMap("timeRange")]
            [Validation(Required=false)]
            public string TimeRange { get; set; }

        }

    }

}
