// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ListCouponUsageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCouponUsageResponseBodyData> Data { get; set; }
        public class ListCouponUsageResponseBodyData : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            [NameInMap("Amount")]
            [Validation(Required=false)]
            public double? Amount { get; set; }

            [NameInMap("Balance")]
            [Validation(Required=false)]
            public double? Balance { get; set; }

            [NameInMap("CouponId")]
            [Validation(Required=false)]
            public string CouponId { get; set; }

            [NameInMap("CouponTemplateId")]
            [Validation(Required=false)]
            public long? CouponTemplateId { get; set; }

            [NameInMap("EffDate")]
            [Validation(Required=false)]
            public string EffDate { get; set; }

            [NameInMap("PublishDate")]
            [Validation(Required=false)]
            public string PublishDate { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public long? Uid { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCouponUsageResponseBodyPageInfo PageInfo { get; set; }
        public class ListCouponUsageResponseBodyPageInfo : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
