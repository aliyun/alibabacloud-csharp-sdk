// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaServiceResponseBody : TeaModel {
        /// <summary>
        /// The time when the change of the billing method starts to take effect. The time is in GMT. This time appears on the frontend only when it is later than the current time.
        /// </summary>
        [NameInMap("ChangingAffectTime")]
        [Validation(Required=false)]
        public string ChangingAffectTime { get; set; }

        /// <summary>
        /// The new billing method to take effect. Valid values:
        /// 
        /// *   **PayByTraffic**: pay-by-data-transfer
        /// *   **PayByBandwidth**: pay-by-bandwidth
        /// *   **PayByBandwidth95**: pay-by-95th percentile bandwidth
        /// *   **PayByBandwidth_monthavg**: pay-by-monthly average bandwidth
        /// *   **PayByBandwidth_month4th**: pay-by-fourth peak bandwidth per month
        /// *   **PayByBandwidth_monthday95avg**: pay-by-monthly average 95th percentile bandwidth
        /// *   **PayByBandwidth_nighthalf95**: pay-by-95th percentile bandwidth (50% off during nighttime)
        /// </summary>
        [NameInMap("ChangingChargeType")]
        [Validation(Required=false)]
        public string ChangingChargeType { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **PayByTraffic**: pay-by-data-transfer
        /// *   **PayByBandwidth**: pay-by-bandwidth
        /// *   **PayByBandwidth95**: pay-by-95th percentile bandwidth
        /// *   **PayByBandwidth_monthavg**: pay-by-monthly average bandwidth
        /// *   **PayByBandwidth_month4th**: pay-by-fourth peak bandwidth per month
        /// *   **PayByBandwidth_monthday95avg**: pay-by-monthly average 95th percentile bandwidth
        /// *   **PayByBandwidth_nighthalf95**: pay-by-95th percentile bandwidth (50% off during nighttime)
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The time when the DCDN service was activated. The time follows the ISO 8601 standard.
        /// </summary>
        [NameInMap("OpeningTime")]
        [Validation(Required=false)]
        public string OpeningTime { get; set; }

        /// <summary>
        /// The lock status of secure DCDN.
        /// </summary>
        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeDcdnIpaServiceResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeDcdnIpaServiceResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeDcdnIpaServiceResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeDcdnIpaServiceResponseBodyOperationLocksLockReason : TeaModel {
                /// <summary>
                /// The reason why the instance is locked. For example, a value of **financial** indicates that an overdue payment exists.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
