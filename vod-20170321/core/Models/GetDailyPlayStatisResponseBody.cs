// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDailyPlayStatisResponseBody : TeaModel {
        [NameInMap("DailyPlayStatisList")]
        [Validation(Required=false)]
        public List<GetDailyPlayStatisResponseBodyDailyPlayStatisList> DailyPlayStatisList { get; set; }
        public class GetDailyPlayStatisResponseBodyDailyPlayStatisList : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("Flow")]
            [Validation(Required=false)]
            public double? Flow { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("PlayCount")]
            [Validation(Required=false)]
            public long? PlayCount { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
