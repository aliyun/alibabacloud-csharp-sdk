// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamOptimizedFeatureConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LiveStreamOptimizedFeatureConfigList")]
        [Validation(Required=false)]
        public DescribeLiveStreamOptimizedFeatureConfigResponseBodyLiveStreamOptimizedFeatureConfigList LiveStreamOptimizedFeatureConfigList { get; set; }
        public class DescribeLiveStreamOptimizedFeatureConfigResponseBodyLiveStreamOptimizedFeatureConfigList : TeaModel {
            [NameInMap("LiveStreamOptimizedFeatureConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamOptimizedFeatureConfigResponseBodyLiveStreamOptimizedFeatureConfigListLiveStreamOptimizedFeatureConfig> LiveStreamOptimizedFeatureConfig { get; set; }
            public class DescribeLiveStreamOptimizedFeatureConfigResponseBodyLiveStreamOptimizedFeatureConfigListLiveStreamOptimizedFeatureConfig : TeaModel {
                public string ConfigName { get; set; }
                public string ConfigValue { get; set; }
                public string ConfigStatus { get; set; }
                public string DomainName { get; set; }
            }
        };

    }

}
