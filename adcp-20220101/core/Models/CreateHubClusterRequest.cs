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

        [NameInMap("AuditLogProject")]
        [Validation(Required=false)]
        public string AuditLogProject { get; set; }

        [NameInMap("AuditLogStoreTTL")]
        [Validation(Required=false)]
        public string AuditLogStoreTTL { get; set; }

        [NameInMap("ControlPlaneLogEnabled")]
        [Validation(Required=false)]
        public bool? ControlPlaneLogEnabled { get; set; }

        [NameInMap("ControlPlaneLogProject")]
        [Validation(Required=false)]
        public string ControlPlaneLogProject { get; set; }

        [NameInMap("ControlPlaneLogTTL")]
        [Validation(Required=false)]
        public string ControlPlaneLogTTL { get; set; }

        /// <summary>
        /// 是否企业安全组
        /// </summary>
        [NameInMap("IsEnterpriseSecurityGroup")]
        [Validation(Required=false)]
        public bool? IsEnterpriseSecurityGroup { get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
