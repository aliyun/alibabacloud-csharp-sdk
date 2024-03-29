// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class TaggingAdImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TaggingAdImageResponseBodyData Data { get; set; }
        public class TaggingAdImageResponseBodyData : TeaModel {
            [NameInMap("TagInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> TagInfo { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
