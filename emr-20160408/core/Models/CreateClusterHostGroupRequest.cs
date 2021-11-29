// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class CreateClusterHostGroupRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("HostGroupName")]
        [Validation(Required=false)]
        public string HostGroupName { get; set; }

        [NameInMap("HostGroupParams")]
        [Validation(Required=false)]
        public string HostGroupParams { get; set; }

        [NameInMap("HostGroupType")]
        [Validation(Required=false)]
        public string HostGroupType { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

    }

}
