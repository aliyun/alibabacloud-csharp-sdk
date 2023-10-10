// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class BindEcsSlbRequest : TeaModel {
        /// <summary>
        /// The ID of the application. You can query the application ID by calling the ListApplication operation. For more information, see [ListApplication](~~149390~~).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The ID of the instance group whose application you want to bind. You can call the ListDeployGroup operation to query the group ID. For more information, see [ListDeployGroup](~~62077~~).
        /// </summary>
        [NameInMap("DeployGroupId")]
        [Validation(Required=false)]
        public string DeployGroupId { get; set; }

        /// <summary>
        /// The health check URL.
        /// </summary>
        [NameInMap("ListenerHealthCheckUrl")]
        [Validation(Required=false)]
        public string ListenerHealthCheckUrl { get; set; }

        /// <summary>
        /// The listener port for the SLB instance.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The listener protocol for the SLB instance.
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// The ID of the SLB instance.
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// The forwarding rule of the SLB listener.
        /// </summary>
        [NameInMap("VForwardingUrlRule")]
        [Validation(Required=false)]
        public string VForwardingUrlRule { get; set; }

        /// <summary>
        /// The ID of the vServer group for the SLB instance.
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        /// <summary>
        /// The name of the vServer group.
        /// </summary>
        [NameInMap("VServerGroupName")]
        [Validation(Required=false)]
        public string VServerGroupName { get; set; }

    }

}
