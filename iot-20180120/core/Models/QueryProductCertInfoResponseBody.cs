// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryProductCertInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ProductCertInfo")]
        [Validation(Required=false)]
        public QueryProductCertInfoResponseBodyProductCertInfo ProductCertInfo { get; set; }
        public class QueryProductCertInfoResponseBodyProductCertInfo : TeaModel {
            [NameInMap("IssueModel")]
            [Validation(Required=false)]
            public int? IssueModel { get; set; }
        };

    }

}
