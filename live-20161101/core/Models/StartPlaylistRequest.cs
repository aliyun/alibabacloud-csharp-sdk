// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartPlaylistRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        [NameInMap("ResumeMode")]
        [Validation(Required=false)]
        public string ResumeMode { get; set; }

        [NameInMap("StartItemId")]
        [Validation(Required=false)]
        public string StartItemId { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

    }

}
