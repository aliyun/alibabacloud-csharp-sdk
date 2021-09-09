// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateWhiteIpsRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("modifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        [NameInMap("esIPWhitelist")]
        [Validation(Required=false)]
        public List<string> EsIPWhitelist { get; set; }

        [NameInMap("whiteIpGroup")]
        [Validation(Required=false)]
        public UpdateWhiteIpsRequestWhiteIpGroup WhiteIpGroup { get; set; }
        public class UpdateWhiteIpsRequestWhiteIpGroup : TeaModel {
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }
            [NameInMap("ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }
            [NameInMap("whiteIpType")]
            [Validation(Required=false)]
            public string WhiteIpType { get; set; }
        };

    }

}
