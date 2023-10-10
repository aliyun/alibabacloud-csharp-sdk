// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UnbindSlbRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Specifies whether to remove the configured listeners. Valid values:
        /// 
        /// *   true: removes the configured listeners.
        /// *   false: does not remove the configured listeners.
        /// </summary>
        [NameInMap("DeleteListener")]
        [Validation(Required=false)]
        public string DeleteListener { get; set; }

        /// <summary>
        /// The ID of the SLB instance.
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// The network type of the SLB instance. Valid values:
        /// 
        /// *   **internet**: Internet-facing SLB instance
        /// *   **intranet**: internal-facing SLB instance
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
