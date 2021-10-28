// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeExpressSyncsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ExpressSyncs")]
        [Validation(Required=false)]
        public DescribeExpressSyncsResponseBodyExpressSyncs ExpressSyncs { get; set; }
        public class DescribeExpressSyncsResponseBodyExpressSyncs : TeaModel {
            [NameInMap("ExpressSync")]
            [Validation(Required=false)]
            public List<DescribeExpressSyncsResponseBodyExpressSyncsExpressSync> ExpressSync { get; set; }
            public class DescribeExpressSyncsResponseBodyExpressSyncsExpressSync : TeaModel {
                public string BucketName { get; set; }
                public string BucketPrefix { get; set; }
                public string BucketRegion { get; set; }
                public string Description { get; set; }
                public string ExpressSyncId { get; set; }
                public string MnsTopic { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
