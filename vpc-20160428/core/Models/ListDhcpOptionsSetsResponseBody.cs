// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListDhcpOptionsSetsResponseBody : TeaModel {
        [NameInMap("DhcpOptionsSets")]
        [Validation(Required=false)]
        public List<ListDhcpOptionsSetsResponseBodyDhcpOptionsSets> DhcpOptionsSets { get; set; }
        public class ListDhcpOptionsSetsResponseBodyDhcpOptionsSets : TeaModel {
            [NameInMap("DhcpOptionsSetDescription")]
            [Validation(Required=false)]
            public string DhcpOptionsSetDescription { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("DhcpOptionsSetId")]
            [Validation(Required=false)]
            public string DhcpOptionsSetId { get; set; }

            [NameInMap("DhcpOptions")]
            [Validation(Required=false)]
            public ListDhcpOptionsSetsResponseBodyDhcpOptionsSetsDhcpOptions DhcpOptions { get; set; }
            public class ListDhcpOptionsSetsResponseBodyDhcpOptionsSetsDhcpOptions : TeaModel {
                [NameInMap("DomainNameServers")]
                [Validation(Required=false)]
                public string DomainNameServers { get; set; }
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }
            };

            [NameInMap("DhcpOptionsSetName")]
            [Validation(Required=false)]
            public string DhcpOptionsSetName { get; set; }

            [NameInMap("AssociateVpcCount")]
            [Validation(Required=false)]
            public int? AssociateVpcCount { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
