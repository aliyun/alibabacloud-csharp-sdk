// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddDeviceInternetPortRequest : TeaModel {
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        [NameInMap("InternalPort")]
        [Validation(Required=false)]
        public string InternalPort { get; set; }

        [NameInMap("NatType")]
        [Validation(Required=false)]
        public string NatType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
