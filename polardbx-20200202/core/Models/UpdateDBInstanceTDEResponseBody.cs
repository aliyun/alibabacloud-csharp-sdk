// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class UpdateDBInstanceTDEResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateDBInstanceTDEResponseBodyData Data { get; set; }
        public class UpdateDBInstanceTDEResponseBodyData : TeaModel {
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
