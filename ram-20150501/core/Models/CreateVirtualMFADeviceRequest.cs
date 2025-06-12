// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreateVirtualMFADeviceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the MFA device.</para>
        /// <para>The name must be 1 to 64 characters in length, and can contain letters, digits, periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>device001</para>
        /// </summary>
        [NameInMap("VirtualMFADeviceName")]
        [Validation(Required=false)]
        public string VirtualMFADeviceName { get; set; }

    }

}
