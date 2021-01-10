// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class FindCustomizedFiltersResponseBody : TeaModel {
        [NameInMap("CustomizedFilterList")]
        [Validation(Required=false)]
        public FindCustomizedFiltersResponseBodyCustomizedFilterList CustomizedFilterList { get; set; }
        public class FindCustomizedFiltersResponseBodyCustomizedFilterList : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<FindCustomizedFiltersResponseBodyCustomizedFilterListItems> Items { get; set; }
            public class FindCustomizedFiltersResponseBodyCustomizedFilterListItems : TeaModel {
                public long? GmtModifyTimestamp { get; set; }
                public long? GmtCreateTimestamp { get; set; }
                public string Value { get; set; }
                public string GmtModify { get; set; }
                public string ValueCompareType { get; set; }
                public string GmtCreate { get; set; }
                public string BlackWhiteType { get; set; }
                public string Name { get; set; }
                public long? Id { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
