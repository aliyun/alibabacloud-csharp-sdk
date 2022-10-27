// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantPrimaryZoneRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MasterIntranetAddressZone")]
        [Validation(Required=false)]
        public string MasterIntranetAddressZone { get; set; }

        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        [NameInMap("PrimaryZone")]
        [Validation(Required=false)]
        public string PrimaryZone { get; set; }

        [NameInMap("PrimaryZoneDeployType")]
        [Validation(Required=false)]
        public string PrimaryZoneDeployType { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("UserVSwitchId")]
        [Validation(Required=false)]
        public string UserVSwitchId { get; set; }

    }

}
