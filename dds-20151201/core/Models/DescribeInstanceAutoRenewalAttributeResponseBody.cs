// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeInstanceAutoRenewalAttributeResponseBody : TeaModel {
        /// <summary>
        /// Details about returned entries.
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
                /// Indicates whether auto-renewal is enabled for the instance. Valid values:
                /// 
                /// *   **true**: Auto-renewal is enabled for the instance.
                /// *   **false**: Auto-renewal is disabled for the instance.
                /// </summary>
                [NameInMap("AutoRenew")]
                [Validation(Required=false)]
                public string AutoRenew { get; set; }

                /// <summary>
                /// The category of the instance. Valid values:
                /// 
                /// *   **replicate**: the standalone or replica set instance
                /// *   **sharding**: the sharded cluster instance
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("DbInstanceId")]
                [Validation(Required=false)]
                public string DbInstanceId { get; set; }

                /// <summary>
                /// The auto-renewal period. Unit: months.
                /// 
                /// > * This parameter is ruturned only when the returned value of the **AutoRenew** parameter is **true**.
                /// > * You can call the [ModifyInstanceAutoRenewalAttribute](https://help.aliyun.com/document_detail/145979.html) operation to modify the auto-renewal period.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("ItemsNumbers")]
        [Validation(Required=false)]
        public int? ItemsNumbers { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries that were returned on the current page.
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

    }

}
