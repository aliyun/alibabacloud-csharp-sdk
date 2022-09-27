// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class WhiteIpGroup : TeaModel {
        [NameInMap("WhiteIpType")]
        [Validation(Required=false)]
        public string WhiteIpType { get; set; }

        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("ips")]
        [Validation(Required=false)]
        public List<string> Ips { get; set; }

    }

}
