// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateNetworkAclEntryRequest : TeaModel {
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("NetworkAclEntryName")]
        [Validation(Required=false)]
        public string NetworkAclEntryName { get; set; }

        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}
