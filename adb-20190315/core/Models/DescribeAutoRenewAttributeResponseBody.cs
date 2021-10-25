// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAutoRenewAttributeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAutoRenewAttributeResponseBodyItems Items { get; set; }
        public class DescribeAutoRenewAttributeResponseBodyItems : TeaModel {
            [NameInMap("AutoRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeAutoRenewAttributeResponseBodyItemsAutoRenewAttribute> AutoRenewAttribute { get; set; }
            public class DescribeAutoRenewAttributeResponseBodyItemsAutoRenewAttribute : TeaModel {
                public string DBClusterId { get; set; }
                public string PeriodUnit { get; set; }
                public int? Duration { get; set; }
                public string RenewalStatus { get; set; }
                public bool? AutoRenewEnabled { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
