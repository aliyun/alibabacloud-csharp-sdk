// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class SwitchDBInstanceNetTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OldConnectionString")]
        [Validation(Required=false)]
        public string OldConnectionString { get; set; }

        [NameInMap("NewConnectionString")]
        [Validation(Required=false)]
        public string NewConnectionString { get; set; }

    }

}
