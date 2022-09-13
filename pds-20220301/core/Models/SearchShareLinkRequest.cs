// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchShareLinkRequest : TeaModel {
        [NameInMap("creators")]
        [Validation(Required=false)]
        public List<string> Creators { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("order_direction")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("return_total_count")]
        [Validation(Required=false)]
        public bool? ReturnTotalCount { get; set; }

    }

}
