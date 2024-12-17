// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20200710.Models
{
    public class BillingApplicationRequest : TeaModel {
        [NameInMap("Month")]
        [Validation(Required=false)]
        public int? Month { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Year")]
        [Validation(Required=false)]
        public int? Year { get; set; }

    }

}
