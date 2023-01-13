// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchAddDataForApiSourceShrinkRequest : TeaModel {
        [NameInMap("ApiId")]
        [Validation(Required=true)]
        public string ApiId { get; set; }

        [NameInMap("ContentList")]
        [Validation(Required=true)]
        public string ContentListShrink { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=true)]
        public string IotInstanceId { get; set; }

    }

}
