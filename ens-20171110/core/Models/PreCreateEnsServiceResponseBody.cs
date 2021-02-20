// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PreCreateEnsServiceResponseBody : TeaModel {
        [NameInMap("BuyResourcesDetail")]
        [Validation(Required=false)]
        public string BuyResourcesDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("EnsServiceId")]
        [Validation(Required=false)]
        public string EnsServiceId { get; set; }

        [NameInMap("NetLevel")]
        [Validation(Required=false)]
        public string NetLevel { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
