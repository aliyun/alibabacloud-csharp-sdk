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
        /// 
        /// This parameter is required.
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
        /// The ID of the vSwitch.
        /// </summary>
        [NameInMap("PrimaryZone")]
        [Validation(Required=false)]
        public string PrimaryZone { get; set; }

        [NameInMap("TenantEndpointDirectId")]
        [Validation(Required=false)]
        public string TenantEndpointDirectId { get; set; }

        [NameInMap("TenantEndpointId")]
        [Validation(Required=false)]
        public string TenantEndpointId { get; set; }

        /// <summary>
        /// The return result of the request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("UserDirectVSwitchId")]
        [Validation(Required=false)]
        public string UserDirectVSwitchId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("UserVSwitchId")]
        [Validation(Required=false)]
        public string UserVSwitchId { get; set; }

        [NameInMap("UserVpcOwnerId")]
        [Validation(Required=false)]
        public string UserVpcOwnerId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
