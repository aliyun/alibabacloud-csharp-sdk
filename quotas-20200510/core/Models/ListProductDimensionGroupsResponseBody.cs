// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductDimensionGroupsResponseBody : TeaModel {
        [NameInMap("DimensionGroups")]
        [Validation(Required=false)]
        public List<ListProductDimensionGroupsResponseBodyDimensionGroups> DimensionGroups { get; set; }
        public class ListProductDimensionGroupsResponseBodyDimensionGroups : TeaModel {
            [NameInMap("DimensionKeys")]
            [Validation(Required=false)]
            public List<string> DimensionKeys { get; set; }

            [NameInMap("GroupCode")]
            [Validation(Required=false)]
            public string GroupCode { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
