// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class DescribeApiErrorResponseBody : TeaModel {
        [NameInMap("ClientErrors")]
        [Validation(Required=false)]
        public DescribeApiErrorResponseBodyClientErrors ClientErrors { get; set; }
        public class DescribeApiErrorResponseBodyClientErrors : TeaModel {
            [NameInMap("ClientError")]
            [Validation(Required=false)]
            public List<DescribeApiErrorResponseBodyClientErrorsClientError> ClientError { get; set; }
            public class DescribeApiErrorResponseBodyClientErrorsClientError : TeaModel {
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServerErrors")]
        [Validation(Required=false)]
        public DescribeApiErrorResponseBodyServerErrors ServerErrors { get; set; }
        public class DescribeApiErrorResponseBodyServerErrors : TeaModel {
            [NameInMap("ServerError")]
            [Validation(Required=false)]
            public List<DescribeApiErrorResponseBodyServerErrorsServerError> ServerError { get; set; }
            public class DescribeApiErrorResponseBodyServerErrorsServerError : TeaModel {
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
