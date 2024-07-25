// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetPlayInfoResponseBody : TeaModel {
        [NameInMap("MediaBase")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyMediaBase MediaBase { get; set; }
        public class GetPlayInfoResponseBodyMediaBase : TeaModel {
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("MediaTags")]
            [Validation(Required=false)]
            public string MediaTags { get; set; }

            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("PlayInfoList")]
        [Validation(Required=false)]
        public List<GetPlayInfoResponseBodyPlayInfoList> PlayInfoList { get; set; }
        public class GetPlayInfoResponseBodyPlayInfoList : TeaModel {
            [NameInMap("BitDepth")]
            [Validation(Required=false)]
            public int? BitDepth { get; set; }

            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("Encrypt")]
            [Validation(Required=false)]
            public long? Encrypt { get; set; }

            [NameInMap("EncryptType")]
            [Validation(Required=false)]
            public string EncryptType { get; set; }

            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            [NameInMap("HDRType")]
            [Validation(Required=false)]
            public string HDRType { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            [NameInMap("NarrowBandType")]
            [Validation(Required=false)]
            public string NarrowBandType { get; set; }

            [NameInMap("PlayURL")]
            [Validation(Required=false)]
            public string PlayURL { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StreamTags")]
            [Validation(Required=false)]
            public string StreamTags { get; set; }

            [NameInMap("StreamType")]
            [Validation(Required=false)]
            public string StreamType { get; set; }

            [NameInMap("TransTemplateType")]
            [Validation(Required=false)]
            public string TransTemplateType { get; set; }

            [NameInMap("WatermarkId")]
            [Validation(Required=false)]
            public string WatermarkId { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
