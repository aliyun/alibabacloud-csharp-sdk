// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPlayInfoResponseBody : TeaModel {
        [NameInMap("PlayInfoList")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyPlayInfoList PlayInfoList { get; set; }
        public class GetPlayInfoResponseBodyPlayInfoList : TeaModel {
            [NameInMap("PlayInfo")]
            [Validation(Required=false)]
            public List<GetPlayInfoResponseBodyPlayInfoListPlayInfo> PlayInfo { get; set; }
            public class GetPlayInfoResponseBodyPlayInfoListPlayInfo : TeaModel {
                public string Bitrate { get; set; }
                public string CreationTime { get; set; }
                public string Definition { get; set; }
                public string Duration { get; set; }
                public long? Encrypt { get; set; }
                public string EncryptType { get; set; }
                public string Format { get; set; }
                public string Fps { get; set; }
                public long? Height { get; set; }
                public string JobId { get; set; }
                public string ModificationTime { get; set; }
                public string NarrowBandType { get; set; }
                public string PlayURL { get; set; }
                public long? Size { get; set; }
                public string Specification { get; set; }
                public string Status { get; set; }
                public string StreamType { get; set; }
                public string WatermarkId { get; set; }
                public long? Width { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VideoBase")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyVideoBase VideoBase { get; set; }
        public class GetPlayInfoResponseBodyVideoBase : TeaModel {
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("DanMuURL")]
            [Validation(Required=false)]
            public string DanMuURL { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }
        };

    }

}
