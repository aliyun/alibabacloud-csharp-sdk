// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class RecolorHDImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecolorHDImageResponseBodyData Data { get; set; }
        public class RecolorHDImageResponseBodyData : TeaModel {
            /// <summary>
            /// 1
            /// </summary>
            [NameInMap("ImageList")]
            [Validation(Required=false)]
            public List<string> ImageList { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
