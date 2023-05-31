// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockProcessStatusRequest : TeaModel {
        /// <summary>
        /// Specifies whether to change the status of the process on multiple servers on which the process runs at the same time. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("DealAll")]
        [Validation(Required=false)]
        public int? DealAll { get; set; }

        /// <summary>
        /// The parameters required to change the status of multiple processes at a time. The value is in the JSON format.
        /// </summary>
        [NameInMap("OperateInfo")]
        [Validation(Required=false)]
        public string OperateInfo { get; set; }

        /// <summary>
        /// The paths to the processes.
        /// </summary>
        [NameInMap("ProcessPath")]
        [Validation(Required=false)]
        public List<string> ProcessPath { get; set; }

        /// <summary>
        /// The status of the process. Valid values:
        /// 
        /// *   **0**: cancels adding the process to the process whitelist
        /// *   **1**: adds the process to the process whitelist
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The UUID of the server.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
