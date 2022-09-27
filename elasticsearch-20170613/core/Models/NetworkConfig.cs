// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class NetworkConfig : TeaModel {
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("vsArea")]
        [Validation(Required=false)]
        public string VsArea { get; set; }

        [NameInMap("vswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        [NameInMap("whiteIpGroupList")]
        [Validation(Required=false)]
        public List<WhiteIpGroup> WhiteIpGroupList { get; set; }

    }

}
