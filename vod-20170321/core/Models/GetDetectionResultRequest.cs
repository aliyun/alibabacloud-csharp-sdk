// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDetectionResultRequest : TeaModel {
        [NameInMap("CountByPage")]
        [Validation(Required=false)]
        public long? CountByPage { get; set; }

        [NameInMap("Desensitization")]
        [Validation(Required=false)]
        public bool? Desensitization { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
