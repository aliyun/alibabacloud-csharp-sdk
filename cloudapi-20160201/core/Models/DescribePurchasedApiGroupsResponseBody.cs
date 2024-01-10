// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
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
                [NameInMap("BillingType")]
                [Validation(Required=false)]
                public string BillingType { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("GroupDescription")]
                [Validation(Required=false)]
                public string GroupDescription { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("InvokeTimesMax")]
                [Validation(Required=false)]
                public long? InvokeTimesMax { get; set; }

                [NameInMap("InvokeTimesNow")]
                [Validation(Required=false)]
                public long? InvokeTimesNow { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
