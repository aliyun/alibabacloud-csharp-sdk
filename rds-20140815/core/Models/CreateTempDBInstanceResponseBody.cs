// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateTempDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the temporary instance.
        /// </summary>
        [NameInMap("TempDBInstanceId")]
        [Validation(Required=false)]
        public string TempDBInstanceId { get; set; }

    }

}
