// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class GeneralBill : TeaModel {
        [NameInMap("billId")]
        [Validation(Required=false)]
        public string BillId { get; set; }

        [NameInMap("billPeriod")]
        [Validation(Required=false)]
        public string BillPeriod { get; set; }

        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public List<string> DownloadUrl { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        [NameInMap("shopName")]
        [Validation(Required=false)]
        public string ShopName { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public Money TotalAmount { get; set; }

    }

}
