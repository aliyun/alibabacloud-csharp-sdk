// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetDhcpOptionsSetResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("DhcpOptionsSetId")]
        [Validation(Required=false)]
        public string DhcpOptionsSetId { get; set; }

        [NameInMap("DhcpOptions")]
        [Validation(Required=false)]
        public GetDhcpOptionsSetResponseBodyDhcpOptions DhcpOptions { get; set; }
        public class GetDhcpOptionsSetResponseBodyDhcpOptions : TeaModel {
            [NameInMap("DomainNameServers")]
            [Validation(Required=false)]
            public string DomainNameServers { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("DhcpOptionsSetName")]
        [Validation(Required=false)]
        public string DhcpOptionsSetName { get; set; }

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

        [NameInMap("DhcpOptionsSetDescription")]
        [Validation(Required=false)]
        public string DhcpOptionsSetDescription { get; set; }

    }

}
