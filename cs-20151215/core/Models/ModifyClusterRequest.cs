// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterRequest : TeaModel {
        [NameInMap("api_server_eip")]
        [Validation(Required=false)]
        public bool? ApiServerEip { get; set; }

        [NameInMap("api_server_eip_id")]
        [Validation(Required=false)]
        public string ApiServerEipId { get; set; }

        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        [NameInMap("enable_rrsa")]
        [Validation(Required=false)]
        public bool? EnableRrsa { get; set; }

        [NameInMap("ingress_domain_rebinding")]
        [Validation(Required=false)]
        public string IngressDomainRebinding { get; set; }

        [NameInMap("ingress_loadbalancer_id")]
        [Validation(Required=false)]
        public string IngressLoadbalancerId { get; set; }

        [NameInMap("instance_deletion_protection")]
        [Validation(Required=false)]
        public bool? InstanceDeletionProtection { get; set; }

        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
