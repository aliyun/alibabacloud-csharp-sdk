// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddPrivateRegistryRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("ExtraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        [NameInMap("NetType")]
        [Validation(Required=false)]
        public long? NetType { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public long? ProtocolType { get; set; }

        [NameInMap("RegistryHostIp")]
        [Validation(Required=false)]
        public string RegistryHostIp { get; set; }

        [NameInMap("RegistryRegionId")]
        [Validation(Required=false)]
        public string RegistryRegionId { get; set; }

        [NameInMap("RegistryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

        [NameInMap("RegistryVersion")]
        [Validation(Required=false)]
        public string RegistryVersion { get; set; }

        [NameInMap("TransPerHour")]
        [Validation(Required=false)]
        public int? TransPerHour { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
