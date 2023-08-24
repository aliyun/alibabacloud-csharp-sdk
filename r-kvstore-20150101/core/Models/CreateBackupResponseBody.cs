// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateBackupResponseBody : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **CreateBackup**.
        /// </summary>
        [NameInMap("BackupJobID")]
        [Validation(Required=false)]
        public string BackupJobID { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
