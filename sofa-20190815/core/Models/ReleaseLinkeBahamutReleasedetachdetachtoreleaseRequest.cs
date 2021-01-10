// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ReleaseLinkeBahamutReleasedetachdetachtoreleaseRequest : TeaModel {
        [NameInMap("IterationId")]
        [Validation(Required=false)]
        public string IterationId { get; set; }

        [NameInMap("IterationIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> IterationIdsRepeatList { get; set; }

        [NameInMap("OverdueFastDev")]
        [Validation(Required=false)]
        public bool? OverdueFastDev { get; set; }

        [NameInMap("OverdueMes")]
        [Validation(Required=false)]
        public string OverdueMes { get; set; }

        [NameInMap("OverdueReason")]
        [Validation(Required=false)]
        public string OverdueReason { get; set; }

        [NameInMap("ReleaseId")]
        [Validation(Required=false)]
        public string ReleaseId { get; set; }

    }

}
