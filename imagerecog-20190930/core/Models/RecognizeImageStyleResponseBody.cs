// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class RecognizeImageStyleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeImageStyleResponseBodyData Data { get; set; }
        public class RecognizeImageStyleResponseBodyData : TeaModel {
            [NameInMap("Styles")]
            [Validation(Required=false)]
            public List<string> Styles { get; set; }
        };

    }

}
