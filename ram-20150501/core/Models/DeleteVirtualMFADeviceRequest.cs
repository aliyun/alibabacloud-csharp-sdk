// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class DeleteVirtualMFADeviceRequest : TeaModel {
        /// <summary>
        /// <para>The serial number of the MFA device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:mfa/device002</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

    }

}
