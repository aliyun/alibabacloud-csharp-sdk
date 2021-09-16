// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class SkipPreCheckRequest : TeaModel {
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("Skip")]
        [Validation(Required=false)]
        public bool? Skip { get; set; }

        [NameInMap("SkipPreCheckItems")]
        [Validation(Required=false)]
        public string SkipPreCheckItems { get; set; }

        [NameInMap("SkipPreCheckNames")]
        [Validation(Required=false)]
        public string SkipPreCheckNames { get; set; }

        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
