// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterRequest : TeaModel {
        /// <summary>
        /// 集群是否绑定EIP，用于公网访问API Server。 true | false
        /// </summary>
        [NameInMap("api_server_eip")]
        [Validation(Required=false)]
        public bool? ApiServerEip { get; set; }

        /// <summary>
        /// 集群API Server 公网连接端点。
        /// </summary>
        [NameInMap("api_server_eip_id")]
        [Validation(Required=false)]
        public string ApiServerEipId { get; set; }

        /// <summary>
        /// 集群是否开启删除保护。默认值false。
        /// </summary>
        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// 域名是否重新绑定到Ingress的SLB地址。
        /// </summary>
        [NameInMap("ingress_domain_rebinding")]
        [Validation(Required=false)]
        public string IngressDomainRebinding { get; set; }

        /// <summary>
        /// 集群的Ingress SLB的ID。
        /// </summary>
        [NameInMap("ingress_loadbalancer_id")]
        [Validation(Required=false)]
        public string IngressLoadbalancerId { get; set; }

        /// <summary>
        /// 实例删除保护，防止通过控制台或API误删除释放节点。
        /// </summary>
        [NameInMap("instance_deletion_protection")]
        [Validation(Required=false)]
        public bool? InstanceDeletionProtection { get; set; }

        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// 集群资源组ID。
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
