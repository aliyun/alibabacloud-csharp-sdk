// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicTemplateVPCConfig : TeaModel {
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("vSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
