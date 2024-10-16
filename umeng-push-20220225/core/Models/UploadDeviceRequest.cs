// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class UploadDeviceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>device_token_1\ndevice_token_2\ndevice_token_3\n...
        /// alias1\nalias2\nalias3\n...</para>
        /// </summary>
        [NameInMap("DeviceTokens")]
        [Validation(Required=false)]
        public string DeviceTokens { get; set; }

    }

}
