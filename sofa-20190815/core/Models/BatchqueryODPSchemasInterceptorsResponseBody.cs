// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchqueryODPSchemasInterceptorsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<BatchqueryODPSchemasInterceptorsResponseBodyData> Data { get; set; }
        public class BatchqueryODPSchemasInterceptorsResponseBodyData : TeaModel {
            [NameInMap("InterceptSqls")]
            [Validation(Required=false)]
            public List<string> InterceptSqls { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            [NameInMap("InterceptorName")]
            [Validation(Required=false)]
            public string InterceptorName { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("InterceptRule")]
            [Validation(Required=false)]
            public string InterceptRule { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
