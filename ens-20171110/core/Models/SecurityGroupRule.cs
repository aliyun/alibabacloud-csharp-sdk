// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SecurityGroupRule : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DestCidrIp")]
        [Validation(Required=false)]
        public string DestCidrIp { get; set; }

        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

    }

}
