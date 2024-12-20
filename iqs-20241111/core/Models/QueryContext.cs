// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class QueryContext : TeaModel {
        [NameInMap("originalQuery")]
        [Validation(Required=false)]
        public QueryContextOriginalQuery OriginalQuery { get; set; }
        public class QueryContextOriginalQuery : TeaModel {
            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

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

        [NameInMap("rewrite")]
        [Validation(Required=false)]
        public QueryContextRewrite Rewrite { get; set; }
        public class QueryContextRewrite : TeaModel {
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("timeRange")]
            [Validation(Required=false)]
            public string TimeRange { get; set; }

        }

    }

}
