// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsSlowSqlsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDrdsSlowSqlsResponseBodyItems Items { get; set; }
        public class DescribeDrdsSlowSqlsResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeDrdsSlowSqlsResponseBodyItemsItem> Item { get; set; }
            public class DescribeDrdsSlowSqlsResponseBodyItemsItem : TeaModel {
                public string Host { get; set; }
                public string Schema { get; set; }
                public long? SendTime { get; set; }
                public string Sql { get; set; }
                public long? ResponseTime { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
