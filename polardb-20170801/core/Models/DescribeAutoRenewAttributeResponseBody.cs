// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAutoRenewAttributeResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAutoRenewAttributeResponseBodyItems Items { get; set; }
        public class DescribeAutoRenewAttributeResponseBodyItems : TeaModel {
            [NameInMap("AutoRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeAutoRenewAttributeResponseBodyItemsAutoRenewAttribute> AutoRenewAttribute { get; set; }
            public class DescribeAutoRenewAttributeResponseBodyItemsAutoRenewAttribute : TeaModel {
                [NameInMap("AutoRenewEnabled")]
                [Validation(Required=false)]
                public bool? AutoRenewEnabled { get; set; }

                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RenewalStatus")]
                [Validation(Required=false)]
                public string RenewalStatus { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
