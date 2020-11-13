// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ErasePersonResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ErasePersonResponseData Data { get; set; }
        public class ErasePersonResponseData : TeaModel {
            [NameInMap("ImageUrl")]
            [Validation(Required=true)]
            public string ImageUrl { get; set; }
        };

    }

}
