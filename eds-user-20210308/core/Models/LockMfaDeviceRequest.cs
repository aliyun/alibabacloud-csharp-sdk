// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class LockMfaDeviceRequest : TeaModel {
        /// <summary>
        /// The address of the Active Directory (AD) workspace.
        /// </summary>
        [NameInMap("AdDomain")]
        [Validation(Required=false)]
        public string AdDomain { get; set; }

        /// <summary>
        /// The serial number of the virtual MFA device, which is a unique identifier.
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

    }

}
