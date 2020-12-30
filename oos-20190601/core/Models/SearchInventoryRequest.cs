// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class SearchInventoryRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<SearchInventoryRequestFilter> Filter { get; set; }
        public class SearchInventoryRequestFilter : TeaModel {
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Aggregator")]
        [Validation(Required=false)]
        public List<string> Aggregator { get; set; }

    }

}
