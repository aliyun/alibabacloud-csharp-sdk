// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyDBClusterPayTypeRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("DbClusterId")]
        [Validation(Required=false)]
        public string DbClusterId { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   **Postpaid**: pay-as-you-go.
        /// *   **Prepaid**: subscription.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The subscription type of the subscription cluster. Valid values:
        /// 
        /// *   **Year**: subscription on a yearly basis.
        /// *   **Month**: subscription on a monthly basis.
        /// 
        /// > This parameter must be specified when PayType is set to Prepaid.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The subscription duration of the subscription cluster.
        /// 
        /// *   Valid values when Period is set to Year: 1, 2, 3, and 5 (integer).
        /// *   Valid values when Period is set to Month: 1 to 11 (integer).
        /// 
        /// > 
        /// 
        /// *   This parameter must be specified when PayType is set to Prepaid.
        /// 
        /// *   Longer subscription durations offer more savings. Purchasing a cluster for one year is more cost-effective than purchasing the cluster for 10 or 11 months.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

    }

}
