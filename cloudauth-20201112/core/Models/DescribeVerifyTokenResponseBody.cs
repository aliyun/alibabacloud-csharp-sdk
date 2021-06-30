// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20201112.Models
{
    public class DescribeVerifyTokenResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeVerifyTokenResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVerifyTokenResponseBodyResultObject : TeaModel {
            [NameInMap("VerifyPageUrl")]
            [Validation(Required=false)]
            public string VerifyPageUrl { get; set; }
            [NameInMap("VerifyToken")]
            [Validation(Required=false)]
            public string VerifyToken { get; set; }
        };

    }

}
