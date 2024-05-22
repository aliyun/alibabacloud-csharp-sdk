// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEpnInstanceRequest : TeaModel {
        /// <summary>
        /// The name of the EPN instance.
        /// </summary>
        [NameInMap("EPNInstanceName")]
        [Validation(Required=false)]
        public string EPNInstanceName { get; set; }

        /// <summary>
        /// The type of the EPN instance. Set the value to **EdgeToEdge**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EPNInstanceType")]
        [Validation(Required=false)]
        public string EPNInstanceType { get; set; }

        /// <summary>
        /// The billing method for network usage. Valid values:
        /// 
        /// *   **BandwidthByDay**: Pay by daily peak bandwidth.
        /// *   **95BandwidthByMonth**: Pay by monthly 95th percentile bandwidth.
        /// *   **PayByBandwidth4thMonth**: Pay by monthly fourth peak bandwidth.
        /// *   **PayByBandwidth**: Pay by fixed bandwidth.
        /// 
        /// You can specify only one metering method for network usage and cannot overwrite the existing metering method.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 1 to 100.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// The networking mode. Valid values:
        /// 
        /// *   **SpeedUp**: intelligent acceleration network (Internet)
        /// *   **Connection**: internal network
        /// *   **SpeedUpAndConnection**: intelligent acceleration network and internal network
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetworkingModel")]
        [Validation(Required=false)]
        public string NetworkingModel { get; set; }

    }

}
