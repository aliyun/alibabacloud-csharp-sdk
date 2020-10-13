// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentSkinResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public SegmentSkinResponseData Data { get; set; }
        public class SegmentSkinResponseData : TeaModel {
            [NameInMap("URL")]
            [Validation(Required=true)]
            public string URL { get; set; }
        };

    }

}
