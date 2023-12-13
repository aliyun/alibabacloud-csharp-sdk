// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class TransferClusterBackupResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the instance is switched to the cluster backup mode. If the value of this parameter is **1**, the instance is switched to the cluster backup mode.
        /// </summary>
        [NameInMap("AlreadyDone")]
        [Validation(Required=false)]
        public string AlreadyDone { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
