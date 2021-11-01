// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectTransparentImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectTransparentImageResponseBodyData Data { get; set; }
        public class DetectTransparentImageResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectTransparentImageResponseBodyDataElements> Elements { get; set; }
            public class DetectTransparentImageResponseBodyDataElements : TeaModel {
                public int? TransparentImage { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
