// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobSanityCheckResultRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SanityCheckNumber")]
        [Validation(Required=false)]
        public int? SanityCheckNumber { get; set; }

        [NameInMap("SanityCheckPhase")]
        [Validation(Required=false)]
        public string SanityCheckPhase { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
