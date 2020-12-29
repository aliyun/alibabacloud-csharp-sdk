// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20180713.Models
{
    public class DescribeDVOrderResultResponseBody : TeaModel {
        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

        [NameInMap("CheckName")]
        [Validation(Required=false)]
        public string CheckName { get; set; }

        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public string CheckType { get; set; }

        [NameInMap("CheckValue")]
        [Validation(Required=false)]
        public string CheckValue { get; set; }

        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

    }

}
