// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class DescribePurchasedApiGroupDetailResponseBody : TeaModel {
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DomainItems")]
        [Validation(Required=false)]
        public DescribePurchasedApiGroupDetailResponseBodyDomainItems DomainItems { get; set; }
        public class DescribePurchasedApiGroupDetailResponseBodyDomainItems : TeaModel {
            [NameInMap("DomainItem")]
            [Validation(Required=false)]
            public List<DescribePurchasedApiGroupDetailResponseBodyDomainItemsDomainItem> DomainItem { get; set; }
            public class DescribePurchasedApiGroupDetailResponseBodyDomainItemsDomainItem : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

            }

        }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

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
