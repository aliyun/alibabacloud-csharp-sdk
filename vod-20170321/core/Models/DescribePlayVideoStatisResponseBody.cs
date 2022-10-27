// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayVideoStatisResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VideoPlayStatisDetails")]
        [Validation(Required=false)]
        public DescribePlayVideoStatisResponseBodyVideoPlayStatisDetails VideoPlayStatisDetails { get; set; }
        public class DescribePlayVideoStatisResponseBodyVideoPlayStatisDetails : TeaModel {
            [NameInMap("VideoPlayStatisDetail")]
            [Validation(Required=false)]
            public List<DescribePlayVideoStatisResponseBodyVideoPlayStatisDetailsVideoPlayStatisDetail> VideoPlayStatisDetail { get; set; }
            public class DescribePlayVideoStatisResponseBodyVideoPlayStatisDetailsVideoPlayStatisDetail : TeaModel {
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("PlayDuration")]
                [Validation(Required=false)]
                public string PlayDuration { get; set; }

                [NameInMap("PlayRange")]
                [Validation(Required=false)]
                public string PlayRange { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("UV")]
                [Validation(Required=false)]
                public string UV { get; set; }

                [NameInMap("VV")]
                [Validation(Required=false)]
                public string VV { get; set; }

            }

        }

    }

}
