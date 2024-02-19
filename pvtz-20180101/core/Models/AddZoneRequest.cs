// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class AddZoneRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DnsGroup")]
        [Validation(Required=false)]
        public string DnsGroup { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ProxyPattern")]
        [Validation(Required=false)]
        public string ProxyPattern { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ZoneName")]
        [Validation(Required=false)]
        public string ZoneName { get; set; }

        [NameInMap("ZoneTag")]
        [Validation(Required=false)]
        public string ZoneTag { get; set; }

        [NameInMap("ZoneType")]
        [Validation(Required=false)]
        public string ZoneType { get; set; }

    }

}
