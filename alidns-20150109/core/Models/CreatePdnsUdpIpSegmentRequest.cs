// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class CreatePdnsUdpIpSegmentRequest : TeaModel {
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("IpToken")]
        [Validation(Required=false)]
        public string IpToken { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
