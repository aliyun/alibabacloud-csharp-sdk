// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QuerySupplierItemBillDownloadUrlRequest : TeaModel {
        [NameInMap("BillId")]
        [Validation(Required=false)]
        public string BillId { get; set; }

        [NameInMap("BillPeriod")]
        [Validation(Required=false)]
        public string BillPeriod { get; set; }

        [NameInMap("BillStatus")]
        [Validation(Required=false)]
        public string BillStatus { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        [NameInMap("LmShopId")]
        [Validation(Required=false)]
        public long? LmShopId { get; set; }

        [NameInMap("LmShopName")]
        [Validation(Required=false)]
        public string LmShopName { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
