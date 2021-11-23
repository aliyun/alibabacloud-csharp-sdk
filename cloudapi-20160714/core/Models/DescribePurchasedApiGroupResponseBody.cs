// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePurchasedApiGroupResponseBody : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribePurchasedApiGroupResponseBodyDomains Domains { get; set; }
        public class DescribePurchasedApiGroupResponseBodyDomains : TeaModel {
            [NameInMap("DomainItem")]
            [Validation(Required=false)]
            public List<DescribePurchasedApiGroupResponseBodyDomainsDomainItem> DomainItem { get; set; }
            public class DescribePurchasedApiGroupResponseBodyDomainsDomainItem : TeaModel {
                public string DomainName { get; set; }
            }
        };

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("PurchasedTime")]
        [Validation(Required=false)]
        public string PurchasedTime { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
