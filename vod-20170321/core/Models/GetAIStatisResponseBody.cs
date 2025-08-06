// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAIStatisResponseBody : TeaModel {
        [NameInMap("AIStatisList")]
        [Validation(Required=false)]
        public List<GetAIStatisResponseBodyAIStatisList> AIStatisList { get; set; }
        public class GetAIStatisResponseBodyAIStatisList : TeaModel {
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("StatTime")]
            [Validation(Required=false)]
            public string StatTime { get; set; }

            [NameInMap("StatTimeUTC")]
            [Validation(Required=false)]
            public string StatTimeUTC { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
