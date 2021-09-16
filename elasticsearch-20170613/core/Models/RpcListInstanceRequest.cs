// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class RpcListInstanceRequest : TeaModel {
        [NameInMap("esVersion")]
        [Validation(Required=false)]
        public string EsVersion { get; set; }

        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("vswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

    }

}
