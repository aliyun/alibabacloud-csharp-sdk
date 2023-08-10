// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// The subscription duration of the DTS instance after renewal. Default value: 1.
        /// 
        /// *   If the **Period** parameter is set to **Year**, the valid values are **1 to 5**.
        /// *   If the **Period** parameter is set to **Month**, the valid values are **1 to 60**.
        /// </summary>
        [NameInMap("BuyCount")]
        [Validation(Required=false)]
        public string BuyCount { get; set; }

        /// <summary>
        /// The billing method of the DTS instance. Set the value to **PREPAY**, which indicates the subscription billing method.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The ID of the data synchronization or change tracking task. You can call the [DescribeDtsJobs](~~209702~~) operation to query the task ID.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The billing cycle of the DTS instance after renewal. Valid values:
        /// 
        /// *   **Year**: annual subscription.
        /// *   **Month**: monthly subscription. This is the default value.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The region ID of the DTS instance. For more information, see [List of supported regions](~~141033~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
