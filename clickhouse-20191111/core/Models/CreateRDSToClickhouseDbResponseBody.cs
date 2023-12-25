// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CreateRDSToClickhouseDbResponseBody : TeaModel {
        /// <summary>
        /// If -1 is returned for the **Status** parameter, the cause of the creation failure is returned.
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Duplicate tables in the synchronization task.
        /// </summary>
        [NameInMap("RepeatedDbs")]
        [Validation(Required=false)]
        public List<string> RepeatedDbs { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the synchronization task was created. Valid values:
        /// 
        /// *   **1**: Created.
        /// *   **0**: Creation failed. The tables in the synchronization task are duplicate. The duplicate tables are returned for the **RepeatedDbs** parameter.
        /// *   **1**: Creation failed. The cause why the creation failed is returned for the **ErrorMsg** parameter.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

    }

}
