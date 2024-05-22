// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyEpnInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the EPN instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        /// <summary>
        /// The name of the EPN instance.
        /// </summary>
        [NameInMap("EPNInstanceName")]
        [Validation(Required=false)]
        public string EPNInstanceName { get; set; }

        /// <summary>
        /// The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 1 Mbit/s to 100 Mbit/s.
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// The networking mode. Valid values:
        /// 
        /// *   **SpeedUp**: Intelligent acceleration network (Internet).
        /// *   **Connection**: Internal network.
        /// *   **SpeedUpAndConnection**: Intelligent acceleration network and internal network.
        /// 
        /// >  The internal network supports only **Connection** and **SpeedUpAndConnection**.
        /// </summary>
        [NameInMap("NetworkingModel")]
        [Validation(Required=false)]
        public string NetworkingModel { get; set; }

    }

}
