// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectWhiteBaseImageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectWhiteBaseImageResponseBodyData Data { get; set; }
        public class DetectWhiteBaseImageResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectWhiteBaseImageResponseBodyDataElements> Elements { get; set; }
            public class DetectWhiteBaseImageResponseBodyDataElements : TeaModel {
                public int? WhiteBase { get; set; }
            }
        };

    }

}
