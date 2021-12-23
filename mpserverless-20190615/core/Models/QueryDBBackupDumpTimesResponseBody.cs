// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class QueryDBBackupDumpTimesResponseBody : TeaModel {
        [NameInMap("BackupDumpTimes")]
        [Validation(Required=false)]
        public List<QueryDBBackupDumpTimesResponseBodyBackupDumpTimes> BackupDumpTimes { get; set; }
        public class QueryDBBackupDumpTimesResponseBodyBackupDumpTimes : TeaModel {
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            [NameInMap("DumpTime")]
            [Validation(Required=false)]
            public string DumpTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
