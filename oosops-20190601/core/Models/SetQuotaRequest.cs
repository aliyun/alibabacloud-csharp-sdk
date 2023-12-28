// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class SetQuotaRequest : TeaModel {
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
