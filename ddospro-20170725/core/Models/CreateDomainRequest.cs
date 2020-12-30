// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class CreateDomainRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("CcEnable")]
        [Validation(Required=false)]
        public bool? CcEnable { get; set; }

        [NameInMap("RealServer")]
        [Validation(Required=false)]
        public List<string> RealServer { get; set; }

        [NameInMap("ProxyType")]
        [Validation(Required=false)]
        public List<string> ProxyType { get; set; }

        [NameInMap("Ips")]
        [Validation(Required=false)]
        public List<string> Ips { get; set; }

    }

}
