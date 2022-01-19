// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class TransferVersionResponseBody : TeaModel {
        [NameInMap("DBInstanceID")]
        [Validation(Required=false)]
        public int? DBInstanceID { get; set; }

        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public long? DBInstanceName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public bool? TaskId { get; set; }

    }

}
