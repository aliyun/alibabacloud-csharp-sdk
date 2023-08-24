// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstanceAutoRenewalAttributeResponseBody : TeaModel {
        /// <summary>
        /// Details of the auto-renewal information for the instance.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeInstanceAutoRenewalAttributeResponseBodyItems Items { get; set; }
        public class DescribeInstanceAutoRenewalAttributeResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeInstanceAutoRenewalAttributeResponseBodyItemsItem> Item { get; set; }
            public class DescribeInstanceAutoRenewalAttributeResponseBodyItemsItem : TeaModel {
                /// <summary>
                /// Indicates whether auto-renewal is enabled. Valid values:
                /// 
                /// *   **true**: Auto-renewal is enabled.
                /// *   **false**: Auto-renewal is disabled.
                /// </summary>
                [NameInMap("AutoRenew")]
                [Validation(Required=false)]
                public string AutoRenew { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The auto-renewal period. Unit: months.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
