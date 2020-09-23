// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterRequest : TeaModel {
        /// <summary>
        /// 集群是否开启删除保护。
        /// </summary>
        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// 集群的Ingress SLB的ID。
        /// </summary>
        [NameInMap("ingress_loadbalancer_id")]
        [Validation(Required=false)]
        public string IngressLoadbalancerId { get; set; }

        /// <summary>
        /// 集群是否开启EIP。
        /// </summary>
        [NameInMap("api_server_eip")]
        [Validation(Required=false)]
        public bool? ApiServerEip { get; set; }

        /// <summary>
        /// 集群的API Server的EIP ID。
        /// </summary>
        [NameInMap("api_server_eip_id")]
        [Validation(Required=false)]
        public string ApiServerEipId { get; set; }

        /// <summary>
        /// 集群资源组ID。
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// 域名是否重新绑定到Ingress的SLB地址。
        /// </summary>
        [NameInMap("ingress_domain_rebinding")]
        [Validation(Required=false)]
        public string IngressDomainRebinding { get; set; }

    }

}
