// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckModifyConfigNeedRestartResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the cluster was restarted after you modified the configuration parameters. Valid values:
        /// 
        /// *   **true**: The cluster was restarted.
        /// *   **false**: The cluster was not restarted.
        /// </summary>
        [NameInMap("NeedRestart")]
        [Validation(Required=false)]
        public bool? NeedRestart { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
