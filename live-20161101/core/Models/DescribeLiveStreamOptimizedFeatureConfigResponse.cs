// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamOptimizedFeatureConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveStreamOptimizedFeatureConfigList")]
        [Validation(Required=true)]
        public DescribeLiveStreamOptimizedFeatureConfigResponseLiveStreamOptimizedFeatureConfigList LiveStreamOptimizedFeatureConfigList { get; set; }
        public class DescribeLiveStreamOptimizedFeatureConfigResponseLiveStreamOptimizedFeatureConfigList : TeaModel {
            [NameInMap("LiveStreamOptimizedFeatureConfig")]
            [Validation(Required=true)]
            public List<DescribeLiveStreamOptimizedFeatureConfigResponseLiveStreamOptimizedFeatureConfigListLiveStreamOptimizedFeatureConfig> LiveStreamOptimizedFeatureConfig { get; set; }
            public class DescribeLiveStreamOptimizedFeatureConfigResponseLiveStreamOptimizedFeatureConfigListLiveStreamOptimizedFeatureConfig : TeaModel {
                public string DomainName { get; set; }
                public string ConfigName { get; set; }
                public string ConfigStatus { get; set; }
                public string ConfigValue { get; set; }
            }
        };

    }

}
