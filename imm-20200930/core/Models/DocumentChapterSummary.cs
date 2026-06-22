// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DocumentChapterSummary : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ChapterSummary> Data { get; set; }

        [NameInMap("NextMarker")]
        [Validation(Required=false)]
        public int? NextMarker { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
