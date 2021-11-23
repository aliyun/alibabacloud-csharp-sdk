// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePurchasedApiGroupsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PurchasedApiGroupAttributes")]
        [Validation(Required=false)]
        public DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributes PurchasedApiGroupAttributes { get; set; }
        public class DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributes : TeaModel {
            [NameInMap("PurchasedApiGroupAttribute")]
            [Validation(Required=false)]
            public List<DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributesPurchasedApiGroupAttribute> PurchasedApiGroupAttribute { get; set; }
            public class DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributesPurchasedApiGroupAttribute : TeaModel {
                public string BillingType { get; set; }
                public string Description { get; set; }
                public string ExpireTime { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public long? InvokeTimesMax { get; set; }
                public long? InvokeTimesNow { get; set; }
                public string PurchasedTime { get; set; }
                public string RegionId { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
