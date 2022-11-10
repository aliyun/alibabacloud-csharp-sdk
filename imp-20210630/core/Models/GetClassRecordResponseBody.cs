// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetClassRecordResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetClassRecordResponseBodyResult Result { get; set; }
        public class GetClassRecordResponseBodyResult : TeaModel {
            [NameInMap("PlaybackUrlMap")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> PlaybackUrlMap { get; set; }

        }

    }

}
