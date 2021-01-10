// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryODPSchemasPhysicalSchemasResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryODPSchemasPhysicalSchemasResponseBodyData> Data { get; set; }
        public class QueryODPSchemasPhysicalSchemasResponseBodyData : TeaModel {
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("ReadOnly")]
            [Validation(Required=false)]
            public bool? ReadOnly { get; set; }

            [NameInMap("RelSchemaName")]
            [Validation(Required=false)]
            public string RelSchemaName { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

    }

}
