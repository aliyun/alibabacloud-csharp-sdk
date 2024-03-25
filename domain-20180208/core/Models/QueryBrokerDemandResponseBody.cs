// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryBrokerDemandResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryBrokerDemandResponseBodyData> Data { get; set; }
        public class QueryBrokerDemandResponseBodyData : TeaModel {
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public int? AuditStatus { get; set; }

            [NameInMap("BargainSellerMobile")]
            [Validation(Required=false)]
            public string BargainSellerMobile { get; set; }

            [NameInMap("BargainSellerPrice")]
            [Validation(Required=false)]
            public float? BargainSellerPrice { get; set; }

            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("DemandDomain")]
            [Validation(Required=false)]
            public string DemandDomain { get; set; }

            [NameInMap("DemandPrice")]
            [Validation(Required=false)]
            public float? DemandPrice { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public int? OrderType { get; set; }

            [NameInMap("PartnerDomain")]
            [Validation(Required=false)]
            public string PartnerDomain { get; set; }

            [NameInMap("PayDomain")]
            [Validation(Required=false)]
            public string PayDomain { get; set; }

            [NameInMap("PayPrice")]
            [Validation(Required=false)]
            public float? PayPrice { get; set; }

            [NameInMap("PayTime")]
            [Validation(Required=false)]
            public long? PayTime { get; set; }

            [NameInMap("ProduceType")]
            [Validation(Required=false)]
            public int? ProduceType { get; set; }

            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public long? PublishTime { get; set; }

            [NameInMap("PurchaseStatus")]
            [Validation(Required=false)]
            public int? PurchaseStatus { get; set; }

            [NameInMap("ServicePayPrice")]
            [Validation(Required=false)]
            public float? ServicePayPrice { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
