// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class GetAICoachDebugResultRequest : TeaModel {
        [NameInMap("dataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("scriptDebugId")]
        [Validation(Required=false)]
        public string ScriptDebugId { get; set; }

        [NameInMap("scriptRecordId")]
        [Validation(Required=false)]
        public string ScriptRecordId { get; set; }

        [NameInMap("scriptSnapshotId")]
        [Validation(Required=false)]
        public string ScriptSnapshotId { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
