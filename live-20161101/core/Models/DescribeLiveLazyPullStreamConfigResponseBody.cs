// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveLazyPullStreamConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LiveLazyPullConfigList")]
        [Validation(Required=false)]
        public DescribeLiveLazyPullStreamConfigResponseBodyLiveLazyPullConfigList LiveLazyPullConfigList { get; set; }
        public class DescribeLiveLazyPullStreamConfigResponseBodyLiveLazyPullConfigList : TeaModel {
            [NameInMap("LiveLazyPullConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveLazyPullStreamConfigResponseBodyLiveLazyPullConfigListLiveLazyPullConfig> LiveLazyPullConfig { get; set; }
            public class DescribeLiveLazyPullStreamConfigResponseBodyLiveLazyPullConfigListLiveLazyPullConfig : TeaModel {
                public string AppName { get; set; }
                public string PullAppName { get; set; }
                public string PullProtocol { get; set; }
                public string PullDomainName { get; set; }
                public string DomainName { get; set; }
            }
        };

    }

}
