// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ReceiveDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the disaster recovery instance after the switchover.
        /// </summary>
        [NameInMap("GuardDBInstanceId")]
        [Validation(Required=false)]
        public string GuardDBInstanceId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
