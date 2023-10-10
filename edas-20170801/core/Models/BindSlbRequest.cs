// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class BindSlbRequest : TeaModel {
        /// <summary>
        /// The ID of the EDAS application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The listener port for the SLB instance.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The ID of the SLB instance.
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// The IP address of the SLB instance.
        /// </summary>
        [NameInMap("SlbIp")]
        [Validation(Required=false)]
        public string SlbIp { get; set; }

        /// <summary>
        /// The type of the SLB instance. Valid values:
        /// 
        /// *   internet: Internet-facing SLB instance
        /// *   intranet: internal-facing SLB instance
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the vServer group for the internal-facing SLB instance.
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
