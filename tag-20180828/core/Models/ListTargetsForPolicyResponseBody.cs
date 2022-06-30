// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListTargetsForPolicyResponseBody : TeaModel {
        [NameInMap("IsRd")]
        [Validation(Required=false)]
        public bool? IsRd { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RdId")]
        [Validation(Required=false)]
        public string RdId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<ListTargetsForPolicyResponseBodyTargets> Targets { get; set; }
        public class ListTargetsForPolicyResponseBodyTargets : TeaModel {
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public int? TargetType { get; set; }

        }

    }

}
