// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class SplitVideoPartsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SplitVideoPartsResponseBodyData Data { get; set; }
        public class SplitVideoPartsResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<SplitVideoPartsResponseBodyDataElements> Elements { get; set; }
            public class SplitVideoPartsResponseBodyDataElements : TeaModel {
                public float? BeginTime { get; set; }
                public float? EndTime { get; set; }
                public long? Index { get; set; }
            }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
