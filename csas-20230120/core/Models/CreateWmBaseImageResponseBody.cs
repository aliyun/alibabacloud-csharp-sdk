// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmBaseImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateWmBaseImageResponseBodyData Data { get; set; }
        public class CreateWmBaseImageResponseBodyData : TeaModel {
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            [NameInMap("ImageUrlExp")]
            [Validation(Required=false)]
            public long? ImageUrlExp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
