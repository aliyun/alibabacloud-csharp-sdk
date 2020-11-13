// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentHDCommonImageResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public SegmentHDCommonImageResponseData Data { get; set; }
        public class SegmentHDCommonImageResponseData : TeaModel {
            [NameInMap("ImageUrl")]
            [Validation(Required=true)]
            public string ImageUrl { get; set; }
        };

    }

}
