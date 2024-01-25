// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePurchasedApiGroupResponseBody : TeaModel {
        /// <summary>
        /// The description of the API group.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The list of domain names.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribePurchasedApiGroupResponseBodyDomains Domains { get; set; }
        public class DescribePurchasedApiGroupResponseBodyDomains : TeaModel {
            [NameInMap("DomainItem")]
            [Validation(Required=false)]
            public List<DescribePurchasedApiGroupResponseBodyDomainsDomainItem> DomainItem { get; set; }
            public class DescribePurchasedApiGroupResponseBodyDomainsDomainItem : TeaModel {
                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the API group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the API group.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The time when the API group was purchased.
        /// </summary>
        [NameInMap("PurchasedTime")]
        [Validation(Required=false)]
        public string PurchasedTime { get; set; }

        /// <summary>
        /// The region where the API group is located.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the API group.
        /// 
        /// *   **NORMAL**: The API group is normal.
        /// *   **DELETE**: The API group is deleted.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
