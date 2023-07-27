// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class MetaQuery : TeaModel {
        [NameInMap("Aggregations")]
        [Validation(Required=false)]
        public MetaQueryAggregations Aggregations { get; set; }
        public class MetaQueryAggregations : TeaModel {
            [NameInMap("Aggregation")]
            [Validation(Required=false)]
            public List<MetaQueryAggregation> Aggregation { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}
