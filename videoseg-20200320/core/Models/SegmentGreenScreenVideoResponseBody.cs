// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoseg20200320.Models
{
    public class SegmentGreenScreenVideoResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SegmentGreenScreenVideoResponseBodyData Data { get; set; }
        public class SegmentGreenScreenVideoResponseBodyData : TeaModel {
            [NameInMap("VideoURL")]
            [Validation(Required=false)]
            public string VideoURL { get; set; }
        };

    }

}
