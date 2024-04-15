// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class LockVirtualMFADeviceRequest : TeaModel {
        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The serial number of the virtual MFA device, which is a unique identifier.
        /// 
        /// You can call the [DescribeVirtualMFADevices](~~206210~~) operation to query the serial number of the virtual MFA device bound to AD users.
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

    }

}
