// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ErasePersonResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ErasePersonResponseBodyData Data { get; set; }
        public class ErasePersonResponseBodyData : TeaModel {
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
