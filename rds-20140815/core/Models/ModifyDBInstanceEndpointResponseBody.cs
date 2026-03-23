// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceEndpointResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyDBInstanceEndpointResponseBodyData Data { get; set; }
        public class ModifyDBInstanceEndpointResponseBodyData : TeaModel {
            [NameInMap("DBInstanceEndpointId")]
            [Validation(Required=false)]
            public string DBInstanceEndpointId { get; set; }

            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
