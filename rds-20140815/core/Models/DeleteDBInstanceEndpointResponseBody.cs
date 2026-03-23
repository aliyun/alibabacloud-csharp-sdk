// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DeleteDBInstanceEndpointResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteDBInstanceEndpointResponseBodyData Data { get; set; }
        public class DeleteDBInstanceEndpointResponseBodyData : TeaModel {
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
