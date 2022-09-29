// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ExtendImageStyleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExtendImageStyleResponseBodyData Data { get; set; }
        public class ExtendImageStyleResponseBodyData : TeaModel {
            [NameInMap("MajorUrl")]
            [Validation(Required=false)]
            public string MajorUrl { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
