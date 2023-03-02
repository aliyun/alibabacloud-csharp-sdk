// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class UpdateMPCoSAuthorizedInfoRequest : TeaModel {
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        [NameInMap("AuthorizedPhaseList")]
        [Validation(Required=false)]
        public Dictionary<string, object> AuthorizedPhaseList { get; set; }

        [NameInMap("BizChainId")]
        [Validation(Required=false)]
        public string BizChainId { get; set; }

        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        [NameInMap("PhaseGroupId")]
        [Validation(Required=false)]
        public string PhaseGroupId { get; set; }

    }

}
