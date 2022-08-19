// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetDhcpOptionsSetResponseBody : TeaModel {
        [NameInMap("AssociateVpcs")]
        [Validation(Required=false)]
        public List<GetDhcpOptionsSetResponseBodyAssociateVpcs> AssociateVpcs { get; set; }
        public class GetDhcpOptionsSetResponseBodyAssociateVpcs : TeaModel {
            [NameInMap("AssociateStatus")]
            [Validation(Required=false)]
            public string AssociateStatus { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("DhcpOptions")]
        [Validation(Required=false)]
        public GetDhcpOptionsSetResponseBodyDhcpOptions DhcpOptions { get; set; }
        public class GetDhcpOptionsSetResponseBodyDhcpOptions : TeaModel {
            [NameInMap("BootFileName")]
            [Validation(Required=false)]
            public string BootFileName { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
            [NameInMap("DomainNameServers")]
            [Validation(Required=false)]
            public string DomainNameServers { get; set; }
            [NameInMap("Ipv6LeaseTime")]
            [Validation(Required=false)]
            public string Ipv6LeaseTime { get; set; }
            [NameInMap("LeaseTime")]
            [Validation(Required=false)]
            public string LeaseTime { get; set; }
            [NameInMap("TFTPServerName")]
            [Validation(Required=false)]
            public string TFTPServerName { get; set; }
        };

        [NameInMap("DhcpOptionsSetDescription")]
        [Validation(Required=false)]
        public string DhcpOptionsSetDescription { get; set; }

        [NameInMap("DhcpOptionsSetId")]
        [Validation(Required=false)]
        public string DhcpOptionsSetId { get; set; }

        [NameInMap("DhcpOptionsSetName")]
        [Validation(Required=false)]
        public string DhcpOptionsSetName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
