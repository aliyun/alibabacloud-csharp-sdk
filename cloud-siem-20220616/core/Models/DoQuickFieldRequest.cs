// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DoQuickFieldRequest : TeaModel {
        [NameInMap("From")]
        [Validation(Required=false)]
        public int? From { get; set; }

        [NameInMap("Index")]
        [Validation(Required=false)]
        public string Index { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("To")]
        [Validation(Required=false)]
        public int? To { get; set; }

    }

}
