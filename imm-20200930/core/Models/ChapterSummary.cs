// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ChapterSummary : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public List<Summary> Summary { get; set; }

        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public List<long?> TimeRange { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("TitleID")]
        [Validation(Required=false)]
        public string TitleID { get; set; }

    }

}
