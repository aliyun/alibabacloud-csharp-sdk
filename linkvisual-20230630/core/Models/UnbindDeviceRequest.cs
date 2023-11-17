// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class UnbindDeviceRequest : TeaModel {
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("IdentityId")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        [NameInMap("OpenId")]
        [Validation(Required=false)]
        public string OpenId { get; set; }

        [NameInMap("OpenIdAppKey")]
        [Validation(Required=false)]
        public string OpenIdAppKey { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("UnbindSubDevice")]
        [Validation(Required=false)]
        public bool? UnbindSubDevice { get; set; }

    }

}
