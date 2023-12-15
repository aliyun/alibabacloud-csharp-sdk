// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeCloudIntegrationServiceTokenResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeCloudIntegrationServiceTokenResponseBodyResult Result { get; set; }
        public class DescribeCloudIntegrationServiceTokenResponseBodyResult : TeaModel {
            [NameInMap("History")]
            [Validation(Required=false)]
            public List<DescribeCloudIntegrationServiceTokenResponseBodyResultHistory> History { get; set; }
            public class DescribeCloudIntegrationServiceTokenResponseBodyResultHistory : TeaModel {
                [NameInMap("Service")]
                [Validation(Required=false)]
                public string Service { get; set; }

                [NameInMap("Token")]
                [Validation(Required=false)]
                public string Token { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
