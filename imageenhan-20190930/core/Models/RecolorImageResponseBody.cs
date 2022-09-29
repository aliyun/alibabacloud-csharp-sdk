// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class RecolorImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecolorImageResponseBodyData Data { get; set; }
        public class RecolorImageResponseBodyData : TeaModel {
            [NameInMap("ImageList")]
            [Validation(Required=false)]
            public List<string> ImageList { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
