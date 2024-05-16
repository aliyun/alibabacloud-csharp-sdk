// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribePatternTypesRequest : TeaModel {
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public List<string> Architecture { get; set; }

        [NameInMap("BurstablePerformance")]
        [Validation(Required=false)]
        public string BurstablePerformance { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public long? ChannelId { get; set; }

        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        [NameInMap("CoresList")]
        [Validation(Required=false)]
        public List<int?> CoresList { get; set; }

        [NameInMap("ExcludedInstanceType")]
        [Validation(Required=false)]
        public List<string> ExcludedInstanceType { get; set; }

        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        [NameInMap("MaxPrice")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        [NameInMap("MemoryList")]
        [Validation(Required=false)]
        public List<float?> MemoryList { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

    }

}
