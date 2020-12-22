// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class AbstractEcommerceVideoAdvanceRequest : TeaModel {
        [NameInMap("VideoUrlObject")]
        [Validation(Required=true)]
        public Stream VideoUrlObject { get; set; }

        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public float? Duration { get; set; }

        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

    }

}
