// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class BusinessCategoryBasicInfo : TeaModel {
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public int? Bid { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OriginalId")]
        [Validation(Required=false)]
        public long? OriginalId { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public int? ServiceType { get; set; }

    }

}
