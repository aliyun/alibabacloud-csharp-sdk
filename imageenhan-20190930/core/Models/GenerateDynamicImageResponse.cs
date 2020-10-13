// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateDynamicImageResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GenerateDynamicImageResponseData Data { get; set; }
        public class GenerateDynamicImageResponseData : TeaModel {
            [NameInMap("Url")]
            [Validation(Required=true)]
            public string Url { get; set; }
        };

    }

}
