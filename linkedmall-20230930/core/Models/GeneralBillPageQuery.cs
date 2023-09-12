// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class GeneralBillPageQuery : TeaModel {
        [NameInMap("asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        [NameInMap("billId")]
        [Validation(Required=false)]
        public string BillId { get; set; }

        [NameInMap("billPeriod")]
        [Validation(Required=false)]
        public string BillPeriod { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

    }

}
