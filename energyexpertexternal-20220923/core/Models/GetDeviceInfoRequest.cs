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
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// The date on which the statistics are collected.
        /// </summary>
        [NameInMap("ds")]
        [Validation(Required=false)]
        public string Ds { get; set; }

        /// <summary>
        /// The ID of the site.
        /// </summary>
        [NameInMap("factoryId")]
        [Validation(Required=false)]
        public string FactoryId { get; set; }

    }

}
