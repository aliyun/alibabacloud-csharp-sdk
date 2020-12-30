// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DescAccountSummary2ResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MnsForceMigrating")]
        [Validation(Required=false)]
        public int? MnsForceMigrating { get; set; }

        [NameInMap("MnsBag")]
        [Validation(Required=false)]
        public int? MnsBag { get; set; }

        [NameInMap("MnsMigrating")]
        [Validation(Required=false)]
        public int? MnsMigrating { get; set; }

    }

}
