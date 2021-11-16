// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ModifyWhiteIpsRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("modifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("whiteIpGroup")]
        [Validation(Required=false)]
        public ModifyWhiteIpsRequestWhiteIpGroup WhiteIpGroup { get; set; }
        public class ModifyWhiteIpsRequestWhiteIpGroup : TeaModel {
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }
            [NameInMap("ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }
        };

        [NameInMap("whiteIpList")]
        [Validation(Required=false)]
        public List<string> WhiteIpList { get; set; }

    }

}
