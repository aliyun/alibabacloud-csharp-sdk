// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitSnapshotJobRequest : TeaModel {
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

        [NameInMap("SpecifiedOffsetTime")]
        [Validation(Required=false)]
        public long? SpecifiedOffsetTime { get; set; }

        [NameInMap("Width")]
        [Validation(Required=false)]
        public string Width { get; set; }

        [NameInMap("Height")]
        [Validation(Required=false)]
        public string Height { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        [NameInMap("SpriteSnapshotConfig")]
        [Validation(Required=false)]
        public string SpriteSnapshotConfig { get; set; }

        [NameInMap("SnapshotTemplateId")]
        [Validation(Required=false)]
        public string SnapshotTemplateId { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

    }

}
