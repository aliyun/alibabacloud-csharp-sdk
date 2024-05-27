// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeInstanceInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the WAF instance.
        /// </summary>
        [NameInMap("InstanceInfo")]
        [Validation(Required=false)]
        public DescribeInstanceInfoResponseBodyInstanceInfo InstanceInfo { get; set; }
        public class DescribeInstanceInfoResponseBodyInstanceInfo : TeaModel {
            /// <summary>
            /// The expiration time of the WAF instance. This value is a UNIX timestamp. Unit: seconds.
            /// 
            /// >  If the value of **PayType** is **0**, this parameter is not returned. The value 0 indicates that no WAF instances are purchased.
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public long? EndDate { get; set; }

            /// <summary>
            /// Indicates whether the WAF instance has overdue payments. Valid values:
            /// 
            /// *   **0**: The instance has overdue payments.
            /// *   **1**: The instance does not have overdue payments.
            /// 
            /// >  If the value of **PayType** is **0**, this parameter is not returned. The value 0 indicates that no WAF instances are purchased.
            /// </summary>
            [NameInMap("InDebt")]
            [Validation(Required=false)]
            public int? InDebt { get; set; }

            /// <summary>
            /// The ID of the WAF instance.
            /// 
            /// >  If the value of **PayType** is **0**, this parameter is not returned. The value 0 indicates that no WAF instances are purchased.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The activation status of WAF. Valid values:
            /// 
            /// *   **0**: No WAF instances are purchased within the Alibaba Cloud account.
            /// *   **1**: A subscription WAF instance is purchased within the Alibaba Cloud account.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            /// <summary>
            /// The region in which the WAF instance resides. Valid values:
            /// 
            /// *   **cn**: a region in the Chinese mainland
            /// *   **cn-hongkong**: a region outside the Chinese mainland
            /// 
            /// >  If the value of **PayType** is **0**, this parameter is not returned. The value 0 indicates that no WAF instances are purchased.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The number of remaining days before the trial period of the WAF instance ends.
            /// 
            /// >  This parameter is returned only if the value of **Trial** is **1**. The value 1 indicates that the free trial of a WAF instance is activated.
            /// </summary>
            [NameInMap("RemainDay")]
            [Validation(Required=false)]
            public int? RemainDay { get; set; }

            /// <summary>
            /// Indicates whether the WAF instance expires. Valid values:
            /// 
            /// *   **0**: The instance expires.
            /// *   **1**: The instance does not expire.
            /// 
            /// >  If the value of **PayType** is **0**, this parameter is not returned. The value 0 indicates that no WAF instances are purchased.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The billing method of the WAF instance: The value is fixed as **Subscription**.
            /// 
            /// >  If the value of **PayType** is **0**, this parameter is not returned. The value 0 indicates that no WAF instances are purchased.
            /// </summary>
            [NameInMap("SubscriptionType")]
            [Validation(Required=false)]
            public string SubscriptionType { get; set; }

            /// <summary>
            /// Indicates whether a WAF instance of the free trial edition is activated within the Alibaba Cloud account. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// 
            /// >  This parameter is returned only if a WAF instance of the free trial edition is activated within the Alibaba Cloud account.
            /// </summary>
            [NameInMap("Trial")]
            [Validation(Required=false)]
            public int? Trial { get; set; }

            /// <summary>
            /// The edition of the WAF instance. Valid values:
            /// 
            /// *   **version_pro_china**: a WAF Pro instance in the Chinese mainland
            /// *   **version_business_china**: a WAF Business instance in the Chinese mainland
            /// *   **version_enterprise_china**: a WAF Enterprise instance in the Chinese mainland
            /// *   **version_exclusive_china**: a WAF Exclusive instance in the Chinese mainland
            /// *   **version_hybrid_cloud_standard_china**: a Hybrid Cloud WAF instance in the Chinese mainland
            /// *   **version_pro_china**: a WAF Pro instance outside the Chinese mainland
            /// *   **version_business**: a WAF Business instance outside the Chinese mainland
            /// *   **version_enterprise**: a WAF Enterprise instance outside the Chinese mainland
            /// *   **version_exclusive**: a WAF Exclusive instance outside the Chinese mainland
            /// *   **version_hybrid_cloud_standard**: a Hybrid Cloud WAF instance outside the Chinese mainland
            /// 
            /// The preceding list contains all the editions of WAF instances within accounts that are created at the International site. If the returned version is not in the list, check whether your account is created at the International site.
            /// 
            /// >  If the value of **PayType** is **0**, this parameter is not returned. The value 0 indicates that no WAF instances are purchased.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
