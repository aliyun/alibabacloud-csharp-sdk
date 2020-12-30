// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class PickOutboundNumbersRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("CalleeNumber")]
        [Validation(Required=false)]
        public string CalleeNumber { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("CandidateNumber")]
        [Validation(Required=false)]
        public List<string> CandidateNumber { get; set; }

    }

}
