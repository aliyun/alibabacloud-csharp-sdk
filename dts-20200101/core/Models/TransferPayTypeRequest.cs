// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class TransferPayTypeRequest : TeaModel {
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The subscription length.
        /// 
        /// *   If the **Period** parameter is set to **Year**, the value range is **1** to **5**.
        /// *   If the **Period** parameter is set to **Month**, the value range is **1** to **60**.
        /// 
        /// >  You must specify this parameter only if you set the **ChargeType** parameter to **PrePaid**.
        /// </summary>
        [NameInMap("BuyCount")]
        [Validation(Required=false)]
        public string BuyCount { get; set; }

        /// <summary>
        /// The billing method that you want to use. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid**: pay-as-you-go
        /// 
        /// > 
        /// *   The billing method of subscription instances cannot be changed to pay-as-you-go. To prevent resource waste, determine whether you need to change the billing method of your resources.
        /// *   If you do not need to change the billing method, specify the current billing method.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The ID of the data synchronization or change tracking task. You can call the [DescribeDtsJobs](https://help.aliyun.com/document_detail/209702.html) operation to query the task ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        [NameInMap("MaxDu")]
        [Validation(Required=false)]
        public int? MaxDu { get; set; }

        [NameInMap("MinDu")]
        [Validation(Required=false)]
        public int? MinDu { get; set; }

        /// <summary>
        /// The billing cycle of the subscription instance. Valid values:
        /// 
        /// *   **Year**
        /// *   **Month** (default value)
        /// 
        /// >  You must specify this parameter only if you set the **ChargeType** parameter to **PrePaid**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The ID of the region where the DTS instance resides. For more information, see [List of supported regions](https://help.aliyun.com/document_detail/141033.html).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
