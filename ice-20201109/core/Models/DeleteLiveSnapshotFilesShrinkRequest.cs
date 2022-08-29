// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteLiveSnapshotFilesShrinkRequest : TeaModel {
        [NameInMap("CreateTimestampList")]
        [Validation(Required=false)]
        public string CreateTimestampListShrink { get; set; }

        [NameInMap("DeleteOriginalFile")]
        [Validation(Required=false)]
        public bool? DeleteOriginalFile { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
