// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketProductCategory : TeaModel {
        [NameInMap("categoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public HiMarketIcon Icon { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
