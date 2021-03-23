// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstanceAutoRenewalAttributeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeInstanceAutoRenewalAttributeResponseBodyItems Items { get; set; }
        public class DescribeInstanceAutoRenewalAttributeResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeInstanceAutoRenewalAttributeResponseBodyItemsItem> Item { get; set; }
            public class DescribeInstanceAutoRenewalAttributeResponseBodyItemsItem : TeaModel {
                public string DBInstanceId { get; set; }
                public string RegionId { get; set; }
                public int? Duration { get; set; }
                public string AutoRenew { get; set; }
            }
        };

    }

}
