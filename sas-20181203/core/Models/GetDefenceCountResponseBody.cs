// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDefenceCountResponseBody : TeaModel {
        /// <summary>
        /// The number of handled alerts of the precise defense type in the last 15 days.
        /// </summary>
        [NameInMap("DefenceCount15Days")]
        [Validation(Required=false)]
        public int? DefenceCount15Days { get; set; }

        /// <summary>
        /// The number of handled alerts of the precision defense type.
        /// </summary>
        [NameInMap("DefenceCountTotal")]
        [Validation(Required=false)]
        public int? DefenceCountTotal { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of handled alerts of the web tamper proofing type in the last 15 days.
        /// </summary>
        [NameInMap("TamperProof15Days")]
        [Validation(Required=false)]
        public int? TamperProof15Days { get; set; }

        /// <summary>
        /// The number of handled alerts of the web tamper proofing type.
        /// </summary>
        [NameInMap("TamperProofTotal")]
        [Validation(Required=false)]
        public int? TamperProofTotal { get; set; }

    }

}
