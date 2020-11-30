// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class JoinSecurityGroupRequest : TeaModel {
        [NameInMap("SecurityGroupId")]
        [Validation(Required=true)]
        public string SecurityGroupId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
