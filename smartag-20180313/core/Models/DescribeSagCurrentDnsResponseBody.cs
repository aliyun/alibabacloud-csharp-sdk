// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagCurrentDnsResponseBody : TeaModel {
        [NameInMap("MasterDns")]
        [Validation(Required=false)]
        public string MasterDns { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlaveDns")]
        [Validation(Required=false)]
        public string SlaveDns { get; set; }

    }

}
