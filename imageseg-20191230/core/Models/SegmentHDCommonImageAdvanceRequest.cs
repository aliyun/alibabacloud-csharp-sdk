// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentHDCommonImageAdvanceRequest : TeaModel {
        [NameInMap("ImageUrlObject")]
        [Validation(Required=true)]
        public Stream ImageUrlObject { get; set; }

        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

    }

}
