// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeBandwitdhByInternetChargeTypeResponseBody : TeaModel {
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
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use the ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The timestamp. The time follows the ISO 8601 standard. The time is displayed in UTC. Example: 2016-10-20T04:00:00Z.
        /// </summary>
        [NameInMap("TimeStamp")]
        [Validation(Required=false)]
        public string TimeStamp { get; set; }

    }

}
