// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class CreateBackupResponseBody : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("ClusterBizId")]
        [Validation(Required=false)]
        public string ClusterBizId { get; set; }

        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        [NameInMap("EcmTaskId")]
        [Validation(Required=false)]
        public long? EcmTaskId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TaskDetail")]
        [Validation(Required=false)]
        public string TaskDetail { get; set; }

        [NameInMap("TaskProcess")]
        [Validation(Required=false)]
        public int? TaskProcess { get; set; }

        [NameInMap("TaskResultDetail")]
        [Validation(Required=false)]
        public string TaskResultDetail { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        [NameInMap("TriggerUser")]
        [Validation(Required=false)]
        public string TriggerUser { get; set; }

    }

}
