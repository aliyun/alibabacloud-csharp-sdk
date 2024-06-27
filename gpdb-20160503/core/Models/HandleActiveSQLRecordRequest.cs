// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class HandleActiveSQLRecordRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The type of the operation on the process ID. Valid values:
        /// 
        /// *   **0**: cancel.
        /// *   **1**: terminate.
        /// *   **2**: forcefully terminate.
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public int? OperateType { get; set; }

        /// <summary>
        /// The process IDs. A process ID is a unique identifier of a query.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Pids")]
        [Validation(Required=false)]
        public string Pids { get; set; }

    }

}
