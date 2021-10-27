// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupDbsRequest : TeaModel {
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("PreferredRestoreTime")]
        [Validation(Required=false)]
        public string PreferredRestoreTime { get; set; }

    }

}
