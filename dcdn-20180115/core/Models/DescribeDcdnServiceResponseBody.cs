// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnServiceResponseBody : TeaModel {
        /// <summary>
        /// The time when the renewed secure DCDN takes effect. The time is displayed in UTC.
        /// </summary>
        [NameInMap("ChangingAffectTime")]
        [Validation(Required=false)]
        public string ChangingAffectTime { get; set; }

        /// <summary>
        /// The new metering method for the renewed secure DCDN. Valid values:
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
        /// The time when the DCDN service was activated. The time follows the ISO 8601 standard.
        /// </summary>
        [NameInMap("OpeningTime")]
        [Validation(Required=false)]
        public string OpeningTime { get; set; }

        /// <summary>
        /// The lock status of DCDN.
        /// </summary>
        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeDcdnServiceResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeDcdnServiceResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeDcdnServiceResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeDcdnServiceResponseBodyOperationLocksLockReason : TeaModel {
                /// <summary>
                /// The reason why secure DCDN was locked. For example, a value of financial indicates that an overdue payment exists.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time when the changes of the WebSocket configuration take effect. The value is the same as that of the ChangingAffectTime parameter. This parameter can be displayed in the console only if the specified time is later than the current time.
        /// </summary>
        [NameInMap("WebsocketChangingTime")]
        [Validation(Required=false)]
        public string WebsocketChangingTime { get; set; }

        /// <summary>
        /// The next effective billing method of WebSocket. Valid values: **websockettraffic** and **websocketbps**. A value of websockettraffic indicates that you are billed based on the traffic volume. A value of websocketbps indicates that you are billed based on the bandwidth.
        /// </summary>
        [NameInMap("WebsocketChangingType")]
        [Validation(Required=false)]
        public string WebsocketChangingType { get; set; }

        /// <summary>
        /// The current billing method of WebSocket. Valid values: **websockettraffic** and **websocketbps**. A value of websockettraffic indicates that you are billed based on the traffic volume. A value of websocketbps indicates that you are billed based on the bandwidth.
        /// </summary>
        [NameInMap("WebsocketType")]
        [Validation(Required=false)]
        public string WebsocketType { get; set; }

    }

}
