// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class NetworkConfiguration : TeaModel {
        [NameInMap("networkMode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        [NameInMap("securityGroupID")]
        [Validation(Required=false)]
        public string SecurityGroupID { get; set; }

        [NameInMap("vpcID")]
        [Validation(Required=false)]
        public string VpcID { get; set; }

        [NameInMap("vswitchIDs")]
        [Validation(Required=false)]
        public List<string> VswitchIDs { get; set; }

    }

}
