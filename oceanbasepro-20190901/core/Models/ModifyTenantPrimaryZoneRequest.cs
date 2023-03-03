// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantPrimaryZoneRequest : TeaModel {
        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The availability zone where the primary node is located.
        /// </summary>
        [NameInMap("MasterIntranetAddressZone")]
        [Validation(Required=false)]
        public string MasterIntranetAddressZone { get; set; }

        /// <summary>
        /// The switching mode.
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// The primary zone of the tenant.    
        /// It is one of the zones in which the cluster is deployed.
        /// </summary>
        [NameInMap("PrimaryZone")]
        [Validation(Required=false)]
        public string PrimaryZone { get; set; }

        /// <summary>
        /// The deployment type of the primary zone.
        /// </summary>
        [NameInMap("PrimaryZoneDeployType")]
        [Validation(Required=false)]
        public string PrimaryZoneDeployType { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// </summary>
        [NameInMap("UserVSwitchId")]
        [Validation(Required=false)]
        public string UserVSwitchId { get; set; }

    }

}
