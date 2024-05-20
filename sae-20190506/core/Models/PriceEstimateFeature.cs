// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class PriceEstimateFeature : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CpuCore")]
        [Validation(Required=false)]
        public float? CpuCore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CpuStrategy")]
        [Validation(Required=false)]
        public string CpuStrategy { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        [NameInMap("HighLoadInstanceCount")]
        [Validation(Required=false)]
        public long? HighLoadInstanceCount { get; set; }

        [NameInMap("HighLoadQps")]
        [Validation(Required=false)]
        public float? HighLoadQps { get; set; }

        [NameInMap("HighLoadSeconds")]
        [Validation(Required=false)]
        public long? HighLoadSeconds { get; set; }

        [NameInMap("InstanceQps")]
        [Validation(Required=false)]
        public float? InstanceQps { get; set; }

        [NameInMap("InternetOutboundGiB")]
        [Validation(Required=false)]
        public float? InternetOutboundGiB { get; set; }

        [NameInMap("LowLoadInstanceCount")]
        [Validation(Required=false)]
        public long? LowLoadInstanceCount { get; set; }

        [NameInMap("LowLoadQps")]
        [Validation(Required=false)]
        public float? LowLoadQps { get; set; }

        [NameInMap("LowLoadSeconds")]
        [Validation(Required=false)]
        public long? LowLoadSeconds { get; set; }

        [NameInMap("MaxInstanceCount")]
        [Validation(Required=false)]
        public long? MaxInstanceCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MemoryGiB")]
        [Validation(Required=false)]
        public float? MemoryGiB { get; set; }

        [NameInMap("MinInstanceCount")]
        [Validation(Required=false)]
        public long? MinInstanceCount { get; set; }

        [NameInMap("NoneLoadInstanceCount")]
        [Validation(Required=false)]
        public long? NoneLoadInstanceCount { get; set; }

        [NameInMap("NoneLoadSeconds")]
        [Validation(Required=false)]
        public long? NoneLoadSeconds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
