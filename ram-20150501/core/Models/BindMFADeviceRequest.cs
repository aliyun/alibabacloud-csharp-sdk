// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class BindMFADeviceRequest : TeaModel {
        /// <summary>
        /// The first authentication code.
        /// </summary>
        [NameInMap("AuthenticationCode1")]
        [Validation(Required=false)]
        public string AuthenticationCode1 { get; set; }

        /// <summary>
        /// The second authentication code.
        /// </summary>
        [NameInMap("AuthenticationCode2")]
        [Validation(Required=false)]
        public string AuthenticationCode2 { get; set; }

        /// <summary>
        /// The serial number of the MFA device.
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// The name of the RAM user.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
