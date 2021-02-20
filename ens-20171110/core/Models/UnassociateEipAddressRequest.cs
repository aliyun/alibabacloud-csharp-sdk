// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UnassociateEipAddressRequest : TeaModel {
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        [NameInMap("Eip")]
        [Validation(Required=false)]
        public string Eip { get; set; }

        [NameInMap("InstanceIdInternetIp")]
        [Validation(Required=false)]
        public string InstanceIdInternetIp { get; set; }

    }

}
