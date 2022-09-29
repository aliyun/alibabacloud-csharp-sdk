// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class EraseVideoSubtitlesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EraseVideoSubtitlesResponseBodyData Data { get; set; }
        public class EraseVideoSubtitlesResponseBodyData : TeaModel {
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
