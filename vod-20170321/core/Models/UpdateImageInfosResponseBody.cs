// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateImageInfosResponseBody : TeaModel {
        [NameInMap("NonExistImageIds")]
        [Validation(Required=false)]
        public UpdateImageInfosResponseBodyNonExistImageIds NonExistImageIds { get; set; }
        public class UpdateImageInfosResponseBodyNonExistImageIds : TeaModel {
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public List<string> ImageId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
