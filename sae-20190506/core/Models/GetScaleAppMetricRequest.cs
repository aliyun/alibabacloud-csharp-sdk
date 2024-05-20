// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetScaleAppMetricRequest : TeaModel {
        [NameInMap("AppSource")]
        [Validation(Required=false)]
        public string AppSource { get; set; }

        [NameInMap("CpuStrategy")]
        [Validation(Required=false)]
        public string CpuStrategy { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
