// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateVirtualMFADeviceRequest : TeaModel {
        [NameInMap("VirtualMFADeviceName")]
        [Validation(Required=false)]
        public string VirtualMFADeviceName { get; set; }

        [NameInMap("AkProxySuffix")]
        [Validation(Required=false)]
        public string AkProxySuffix { get; set; }

    }

}
