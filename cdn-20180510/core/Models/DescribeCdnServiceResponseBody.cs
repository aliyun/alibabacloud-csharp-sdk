// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnServiceResponseBody : TeaModel {
        /// <summary>
        /// The time when the metering method for the next cycle takes effect. The time is displayed in GMT.
        /// </summary>
        [NameInMap("ChangingAffectTime")]
        [Validation(Required=false)]
        public string ChangingAffectTime { get; set; }

        /// <summary>
        /// The metering method for the next cycle. Valid values:
        /// 
        /// *   **PayByTraffic**: pay-by-data-transfer
        /// *   **PayByBandwidth**: pay-by-bandwidth
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
        /// The current metering method. Valid values:
        /// 
        /// *   **PayByTraffic**: pay-by-data-transfer
        /// *   **PayByBandwidth**: pay-by-bandwidth
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The time when the service was activated. The time follows the ISO 8601 standard.
        /// </summary>
        [NameInMap("OpeningTime")]
        [Validation(Required=false)]
        public string OpeningTime { get; set; }

        /// <summary>
        /// The lock status.
        /// </summary>
        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeCdnServiceResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeCdnServiceResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeCdnServiceResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeCdnServiceResponseBodyOperationLocksLockReason : TeaModel {
                /// <summary>
                /// The reason why the service is locked. A value of financial indicates that the service is locked due to overdue payments.
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
