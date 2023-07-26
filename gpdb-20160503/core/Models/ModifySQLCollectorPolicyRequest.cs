// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifySQLCollectorPolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// Specifies whether to enable or disable SQL collection.
        /// 
        /// *   Enable: enables SQL collection.
        /// *   Disabled: disables SQL collection.
        /// </summary>
        [NameInMap("SQLCollectorStatus")]
        [Validation(Required=false)]
        public string SQLCollectorStatus { get; set; }

    }

}
