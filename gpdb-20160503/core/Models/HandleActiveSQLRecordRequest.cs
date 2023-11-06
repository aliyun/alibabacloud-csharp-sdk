// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class HandleActiveSQLRecordRequest : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public int? OperateType { get; set; }

        [NameInMap("Pids")]
        [Validation(Required=false)]
        public string Pids { get; set; }

    }

}
