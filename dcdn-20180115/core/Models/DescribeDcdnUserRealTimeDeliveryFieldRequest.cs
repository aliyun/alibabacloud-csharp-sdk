// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserRealTimeDeliveryFieldRequest : TeaModel {
        /// <summary>
        /// The type of the collected logs. Default value: cdn_log_access_l1. Valid values:
        /// 
        /// *   **cdn_log_access_l1**: access logs of L1 Dynamic Content Delivery Network (DCDN) points of presence (POPs)
        /// *   **cdn_log_origin**: back-to-origin logs
        /// *   **cdn_log_er**: EdgeRoutine logs
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

    }

}
