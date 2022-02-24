// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListUserCertificateOrderResponseBody : TeaModel {
        [NameInMap("CertificateOrderList")]
        [Validation(Required=false)]
        public string CertificateOrderList { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
