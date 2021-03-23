// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSplitItemBillRequest : TeaModel {
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public List<DescribeSplitItemBillRequestTagFilter> TagFilter { get; set; }
        public class DescribeSplitItemBillRequestTagFilter : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("TagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

        [NameInMap("InstanceID")]
        [Validation(Required=false)]
        public string InstanceID { get; set; }

        [NameInMap("SplitItemID")]
        [Validation(Required=false)]
        public string SplitItemID { get; set; }

    }

}
