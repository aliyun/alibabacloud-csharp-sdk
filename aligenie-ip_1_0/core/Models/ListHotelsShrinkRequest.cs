// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelsShrinkRequest : TeaModel {
        [NameInMap("HotelRequest")]
        [Validation(Required=false)]
        public string HotelRequestShrink { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public string PageShrink { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
