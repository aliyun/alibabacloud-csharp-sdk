// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVideoIPCObjectResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectVideoIPCObjectResponseBodyData Data { get; set; }
        public class DetectVideoIPCObjectResponseBodyData : TeaModel {
            [NameInMap("Frames")]
            [Validation(Required=false)]
            public List<DetectVideoIPCObjectResponseBodyDataFrames> Frames { get; set; }
            public class DetectVideoIPCObjectResponseBodyDataFrames : TeaModel {
                public List<DetectVideoIPCObjectResponseBodyDataFramesElements> Elements { get; set; }
                public class DetectVideoIPCObjectResponseBodyDataFramesElements : TeaModel {
                    public long? Height { get; set; }
                    public float? Score { get; set; }
                    public string Type { get; set; }
                    public long? Width { get; set; }
                    public long? X { get; set; }
                    public long? Y { get; set; }
                }
                public long? Time { get; set; }
            }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }
            [NameInMap("InputFile")]
            [Validation(Required=false)]
            public string InputFile { get; set; }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }
        };

        /// <summary>
        /// JobId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
