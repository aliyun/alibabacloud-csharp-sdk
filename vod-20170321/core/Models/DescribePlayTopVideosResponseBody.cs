// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayTopVideosResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TopPlayVideos")]
        [Validation(Required=false)]
        public DescribePlayTopVideosResponseBodyTopPlayVideos TopPlayVideos { get; set; }
        public class DescribePlayTopVideosResponseBodyTopPlayVideos : TeaModel {
            [NameInMap("TopPlayVideoStatis")]
            [Validation(Required=false)]
            public List<DescribePlayTopVideosResponseBodyTopPlayVideosTopPlayVideoStatis> TopPlayVideoStatis { get; set; }
            public class DescribePlayTopVideosResponseBodyTopPlayVideosTopPlayVideoStatis : TeaModel {
                [NameInMap("PlayDuration")]
                [Validation(Required=false)]
                public string PlayDuration { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("UV")]
                [Validation(Required=false)]
                public string UV { get; set; }

                [NameInMap("VV")]
                [Validation(Required=false)]
                public string VV { get; set; }

                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

            }

        }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
