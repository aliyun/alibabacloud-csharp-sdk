// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SubmitSqlFlashbackTaskRequest : TeaModel {
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RecallRestoreType")]
        [Validation(Required=false)]
        public int? RecallRestoreType { get; set; }

        [NameInMap("RecallType")]
        [Validation(Required=false)]
        public int? RecallType { get; set; }

        [NameInMap("SqlPk")]
        [Validation(Required=false)]
        public string SqlPk { get; set; }

        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
