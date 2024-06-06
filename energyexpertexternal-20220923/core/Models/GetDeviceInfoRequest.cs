// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDeviceInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the device.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// The time string in the YYYY-mm-dd format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ds")]
        [Validation(Required=false)]
        public string Ds { get; set; }

        /// <summary>
        /// The ID of the site.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("factoryId")]
        [Validation(Required=false)]
        public string FactoryId { get; set; }

    }

}
