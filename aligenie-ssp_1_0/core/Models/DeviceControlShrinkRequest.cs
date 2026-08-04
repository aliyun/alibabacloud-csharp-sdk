// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class DeviceControlShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Input parameters for volume control</para>
        /// </summary>
        [NameInMap("ControlRequest")]
        [Validation(Required=false)]
        public string ControlRequestShrink { get; set; }

        /// <summary>
        /// <para>List of device ID information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfoShrink { get; set; }

    }

}
