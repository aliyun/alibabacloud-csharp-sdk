// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamOptimizedFeatureConfigResponseBody : TeaModel {
        [NameInMap("LiveStreamOptimizedFeatureConfigList")]
        [Validation(Required=false)]
        public DescribeLiveStreamOptimizedFeatureConfigResponseBodyLiveStreamOptimizedFeatureConfigList LiveStreamOptimizedFeatureConfigList { get; set; }
        public class DescribeLiveStreamOptimizedFeatureConfigResponseBodyLiveStreamOptimizedFeatureConfigList : TeaModel {
            [NameInMap("LiveStreamOptimizedFeatureConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamOptimizedFeatureConfigResponseBodyLiveStreamOptimizedFeatureConfigListLiveStreamOptimizedFeatureConfig> LiveStreamOptimizedFeatureConfig { get; set; }
            public class DescribeLiveStreamOptimizedFeatureConfigResponseBodyLiveStreamOptimizedFeatureConfigListLiveStreamOptimizedFeatureConfig : TeaModel {
                [NameInMap("ConfigName")]
                [Validation(Required=false)]
                public string ConfigName { get; set; }

                [NameInMap("ConfigStatus")]
                [Validation(Required=false)]
                public string ConfigStatus { get; set; }

                [NameInMap("ConfigValue")]
                [Validation(Required=false)]
                public string ConfigValue { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
