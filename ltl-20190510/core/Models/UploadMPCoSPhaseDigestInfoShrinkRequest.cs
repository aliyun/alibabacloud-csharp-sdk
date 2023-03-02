// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class UploadMPCoSPhaseDigestInfoShrinkRequest : TeaModel {
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        [NameInMap("BizChainId")]
        [Validation(Required=false)]
        public string BizChainId { get; set; }

        [NameInMap("DataKey")]
        [Validation(Required=false)]
        public string DataKey { get; set; }

        [NameInMap("DataSeq")]
        [Validation(Required=false)]
        public string DataSeq { get; set; }

        [NameInMap("PhaseData")]
        [Validation(Required=false)]
        public string PhaseData { get; set; }

        [NameInMap("PhaseGroupId")]
        [Validation(Required=false)]
        public string PhaseGroupId { get; set; }

        [NameInMap("PhaseId")]
        [Validation(Required=false)]
        public string PhaseId { get; set; }

        [NameInMap("RelatedDataList")]
        [Validation(Required=false)]
        public string RelatedDataListShrink { get; set; }

    }

}
