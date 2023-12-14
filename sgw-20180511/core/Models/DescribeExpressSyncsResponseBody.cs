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
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                [NameInMap("BucketPrefix")]
                [Validation(Required=false)]
                public string BucketPrefix { get; set; }

                [NameInMap("BucketRegion")]
                [Validation(Required=false)]
                public string BucketRegion { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpressSyncId")]
                [Validation(Required=false)]
                public string ExpressSyncId { get; set; }

                [NameInMap("MnsTopic")]
                [Validation(Required=false)]
                public string MnsTopic { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

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
