// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class OpenStructIdpSyncTask : TeaModel {
        [NameInMap("DepartmentFailed")]
        [Validation(Required=false)]
        public long? DepartmentFailed { get; set; }

        [NameInMap("DepartmentTotal")]
        [Validation(Required=false)]
        public long? DepartmentTotal { get; set; }

        [NameInMap("EndTimeUnix")]
        [Validation(Required=false)]
        public long? EndTimeUnix { get; set; }

        [NameInMap("FailType")]
        [Validation(Required=false)]
        public string FailType { get; set; }

        [NameInMap("IdpConfigId")]
        [Validation(Required=false)]
        public byte[] IdpConfigId { get; set; }

        [NameInMap("StartTimeUnix")]
        [Validation(Required=false)]
        public long? StartTimeUnix { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SyncTaskId")]
        [Validation(Required=false)]
        public string SyncTaskId { get; set; }

        [NameInMap("UpdateTimeUnix")]
        [Validation(Required=false)]
        public long? UpdateTimeUnix { get; set; }

        [NameInMap("UserFailed")]
        [Validation(Required=false)]
        public long? UserFailed { get; set; }

        [NameInMap("UserTotal")]
        [Validation(Required=false)]
        public long? UserTotal { get; set; }

    }

}
