// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class CreateHubClusterRequest : TeaModel {
        [NameInMap("ApiServerPublicEip")]
        [Validation(Required=false)]
        public bool? ApiServerPublicEip { get; set; }

        [NameInMap("AuditLogEnabled")]
        [Validation(Required=false)]
        public bool? AuditLogEnabled { get; set; }

        [NameInMap("IsEnterpriseSecurityGroup")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public string VSwitches { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
