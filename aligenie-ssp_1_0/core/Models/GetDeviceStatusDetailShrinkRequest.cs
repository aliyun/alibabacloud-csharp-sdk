// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetDeviceStatusDetailShrinkRequest : TeaModel {
        /// <summary>
        /// <para>List of device identification information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfoShrink { get; set; }

        /// <summary>
        /// <para>A collection of specified keys for device settings:<br>Player: player<br>Device volume: speaker<br>Battery level: power</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public string KeysShrink { get; set; }

    }

}
