// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UnlockMfaDeviceRequest : TeaModel {
        /// <summary>
        /// The domain of the Active Directory (AD) workspace.
        /// </summary>
        [NameInMap("AdDomain")]
        [Validation(Required=false)]
        public string AdDomain { get; set; }

        /// <summary>
        /// The serial number of the virtual MFA device. The serial number is unique for each device.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

    }

}
