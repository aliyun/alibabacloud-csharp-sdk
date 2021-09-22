// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class DescribeVerifySchemeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SchemeQueryResultDTO")]
        [Validation(Required=false)]
        public DescribeVerifySchemeResponseBodySchemeQueryResultDTO SchemeQueryResultDTO { get; set; }
        public class DescribeVerifySchemeResponseBodySchemeQueryResultDTO : TeaModel {
            [NameInMap("AppEncryptInfo")]
            [Validation(Required=false)]
            public string AppEncryptInfo { get; set; }
        };

    }

}
