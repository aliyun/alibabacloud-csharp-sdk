// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeInstancePasswordsSettingResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether a logon password is set for the simple application server.
        /// </summary>
        [NameInMap("InstancePasswordSetting")]
        [Validation(Required=false)]
        public bool? InstancePasswordSetting { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether a VNC connection password is set.
        /// </summary>
        [NameInMap("VncPasswordSetting")]
        [Validation(Required=false)]
        public bool? VncPasswordSetting { get; set; }

    }

}
