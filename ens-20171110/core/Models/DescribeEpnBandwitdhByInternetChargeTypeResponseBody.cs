// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnBandwitdhByInternetChargeTypeResponseBody : TeaModel {
        /// <summary>
        /// The bandwidth. Unit: bit/s.
        /// </summary>
        [NameInMap("BandwidthValue")]
        [Validation(Required=false)]
        public long? BandwidthValue { get; set; }

        /// <summary>
        /// The metering method. Valid values:
        /// 
        /// *   BandwidthByDay: Pay by daily peak bandwidth
        /// *   95BandwidthByMonth: Pay by monthly 95th percentile bandwidth
        /// *   PayByBandwidth4thMonth: Pay by monthly fourth peak bandwidth
        /// *   PayByBandwidth: Pay by fixed bandwidth
        /// 
        /// You can specify only one metering method for network usage and cannot overwrite the existing metering method.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The timestamp when the monitoring data was queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("TimeStamp")]
        [Validation(Required=false)]
        public string TimeStamp { get; set; }

    }

}
