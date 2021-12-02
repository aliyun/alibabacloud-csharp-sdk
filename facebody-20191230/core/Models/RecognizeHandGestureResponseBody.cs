// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizeHandGestureResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeHandGestureResponseBodyData Data { get; set; }
        public class RecognizeHandGestureResponseBodyData : TeaModel {
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }
            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }
            [NameInMap("X")]
            [Validation(Required=false)]
            public long? X { get; set; }
            [NameInMap("Y")]
            [Validation(Required=false)]
            public long? Y { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
