// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SubtitleStream : TeaModel {
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        [NameInMap("CodecLongName")]
        [Validation(Required=false)]
        public string CodecLongName { get; set; }

        [NameInMap("CodecName")]
        [Validation(Required=false)]
        public string CodecName { get; set; }

        [NameInMap("CodecTag")]
        [Validation(Required=false)]
        public string CodecTag { get; set; }

        [NameInMap("CodecTagString")]
        [Validation(Required=false)]
        public string CodecTagString { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        [NameInMap("Height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        [NameInMap("Index")]
        [Validation(Required=false)]
        public long? Index { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public double? StartTime { get; set; }

        [NameInMap("Width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
