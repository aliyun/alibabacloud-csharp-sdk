// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class PreCheckSqlFlashbackTaskRequest : TeaModel {
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
