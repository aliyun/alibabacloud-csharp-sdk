// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoPlayAuthResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PlayAuth")]
        [Validation(Required=false)]
        public string PlayAuth { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **GetVideoPlayAuth**.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Queries the credential required for media playback.
        /// </summary>
        [NameInMap("VideoMeta")]
        [Validation(Required=false)]
        public GetVideoPlayAuthResponseBodyVideoMeta VideoMeta { get; set; }
        public class GetVideoPlayAuthResponseBodyVideoMeta : TeaModel {
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
