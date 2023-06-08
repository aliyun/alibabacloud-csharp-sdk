// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnsecServiceResponseBody : TeaModel {
        /// <summary>
        /// The time when the renewed service takes effect. The time is displayed in UTC.
        /// </summary>
        [NameInMap("ChangingAffectTime")]
        [Validation(Required=false)]
        public string ChangingAffectTime { get; set; }

        /// <summary>
        /// The new metering method for the renewed DCDN. Valid values:
        /// 
        /// *   **PayByTraffic**: pay by data transfer
        /// *   **PayByBandwidth**: pay by bandwidth
        /// *   **PayByBandwidth95**: pay by 95th percentile bandwidth
        /// *   **PayByBandwidth_monthavg**: pay by monthly average bandwidth
        /// *   **PayByBandwidth_month4th**: pay by fourth peak bandwidth per month
        /// *   **PayByBandwidth_monthday95avg**: pay by monthly average 95th percentile bandwidth
        /// *   **PayByBandwidth_nighthalf95**: pay by 95th percentile bandwidth (50% off during nighttime)
        /// </summary>
        [NameInMap("ChangingChargeType")]
        [Validation(Required=false)]
        public string ChangingChargeType { get; set; }

        /// <summary>
        /// The number of accelerated domain names that use DCDN.
        /// </summary>
        [NameInMap("DomainNum")]
        [Validation(Required=false)]
        public string DomainNum { get; set; }

        /// <summary>
        /// The service expiration time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The metering method for traffic.
        /// </summary>
        [NameInMap("FlowType")]
        [Validation(Required=false)]
        public string FlowType { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The current metering method. Valid values:
        /// 
        /// *   **PayByTraffic**: pay by data transfer
        /// *   **PayByBandwidth**: pay by bandwidth
        /// *   **PayByBandwidth95**: pay by 95th percentile bandwidth
        /// *   **PayByBandwidth_monthavg**: pay by monthly average bandwidth
        /// *   **PayByBandwidth_month4th**: pay by fourth peak bandwidth per month
        /// *   **PayByBandwidth_monthday95avg**: pay by monthly average 95th percentile bandwidth
        /// *   **PayByBandwidth_nighthalf95**: pay by 95th percentile bandwidth (50% off during nighttime)
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The lock status of DCDN.
        /// </summary>
        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeDcdnsecServiceResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeDcdnsecServiceResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeDcdnsecServiceResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeDcdnsecServiceResponseBodyOperationLocksLockReason : TeaModel {
                /// <summary>
                /// The reason why the instance was locked.
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

        /// <summary>
        /// The metering method for requests.
        /// </summary>
        [NameInMap("RequestType")]
        [Validation(Required=false)]
        public string RequestType { get; set; }

        /// <summary>
        /// The service activation time.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The version number.
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
