// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectIPCObjectResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectIPCObjectResponseBodyData Data { get; set; }
        public class DetectIPCObjectResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectIPCObjectResponseBodyDataElements> Elements { get; set; }
            public class DetectIPCObjectResponseBodyDataElements : TeaModel {
                public string Type { get; set; }
                public float? Score { get; set; }
                public List<string> Box { get; set; }
                public float? TargetRate { get; set; }
            }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }
        };

    }

}
