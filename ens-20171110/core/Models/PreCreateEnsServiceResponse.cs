// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PreCreateEnsServiceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("EnsServiceId")]
        [Validation(Required=true)]
        public string EnsServiceId { get; set; }

        [NameInMap("NetLevel")]
        [Validation(Required=true)]
        public string NetLevel { get; set; }

        [NameInMap("BuyResourcesDetail")]
        [Validation(Required=true)]
        public string BuyResourcesDetail { get; set; }

    }

}
