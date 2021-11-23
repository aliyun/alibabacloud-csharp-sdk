// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePurchasedApisResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PurchasedApis")]
        [Validation(Required=false)]
        public DescribePurchasedApisResponseBodyPurchasedApis PurchasedApis { get; set; }
        public class DescribePurchasedApisResponseBodyPurchasedApis : TeaModel {
            [NameInMap("PurchasedApi")]
            [Validation(Required=false)]
            public List<DescribePurchasedApisResponseBodyPurchasedApisPurchasedApi> PurchasedApi { get; set; }
            public class DescribePurchasedApisResponseBodyPurchasedApisPurchasedApi : TeaModel {
                public string ApiId { get; set; }
                public string ApiName { get; set; }
                public string DeployedTime { get; set; }
                public string Description { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string ModifiedTime { get; set; }
                public string PurchasedTime { get; set; }
                public string RegionId { get; set; }
                public string StageName { get; set; }
                public string Visibility { get; set; }
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
