// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnBandWidthDataRequest : TeaModel {
        /// <summary>
        /// The ID of the EPN instance.
        /// </summary>
        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        /// <summary>
        /// The end of the time range to query.
        /// 
        /// *   Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// *   If the value of the seconds place is not 00, the start time is automatically set to the next minute.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the Edge Node Service (ENS) node.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The Internet service provider (ISP). Valid values:
        /// 
        /// *   cmcc: China Mobile
        /// *   telecom: China Telecom
        /// *   unicom: China Unicom
        /// *   multiCarrier: multi-line ISP
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// The networking mode. Valid values:
        /// 
        /// *   **SpeedUp**: intelligent acceleration network (Internet)
        /// *   **Connection**: internal network
        /// *   **SpeedUpAndConnection**: intelligent acceleration network and internal network
        /// </summary>
        [NameInMap("NetworkingModel")]
        [Validation(Required=false)]
        public string NetworkingModel { get; set; }

        /// <summary>
        /// The precision of the monitoring data that you want to obtain. Valid values: 300, 1200, 3600, and 14400. Default value: 300. Unit: seconds.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// *   Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// *   If the value of the seconds place is not 00, the start time is automatically set to the next minute.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
