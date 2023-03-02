// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class ListMPCoSPhaseHistoryRequest : TeaModel {
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        [NameInMap("BizChainId")]
        [Validation(Required=false)]
        public string BizChainId { get; set; }

        [NameInMap("DataKey")]
        [Validation(Required=false)]
        public string DataKey { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Num")]
        [Validation(Required=false)]
        public int? Num { get; set; }

        [NameInMap("PhaseGroupId")]
        [Validation(Required=false)]
        public string PhaseGroupId { get; set; }

        [NameInMap("PhaseId")]
        [Validation(Required=false)]
        public string PhaseId { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
