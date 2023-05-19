// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantPrimaryZoneRequest : TeaModel {
        /// <summary>
        /// The primary zone of the tenant.    
        /// It is one of the zones in which the cluster is deployed.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// ```
        /// http(s)://[Endpoint]/?Action=ModifyTenantPrimaryZone
        /// &TenantId=ob2mr3oae0****
        /// &InstanceId=ob317v4uif****
        /// &PrimaryZone=cn-hangzhou-h
        /// &Common request parameters
        /// ```
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
        /// The ID of the vSwitch.
        /// </summary>
        [NameInMap("PrimaryZone")]
        [Validation(Required=false)]
        public string PrimaryZone { get; set; }

        /// <summary>
        /// Example 1
        /// </summary>
        [NameInMap("PrimaryZoneDeployType")]
        [Validation(Required=false)]
        public string PrimaryZoneDeployType { get; set; }

        /// <summary>
        /// The return result of the request.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("UserVSwitchId")]
        [Validation(Required=false)]
        public string UserVSwitchId { get; set; }

    }

}
